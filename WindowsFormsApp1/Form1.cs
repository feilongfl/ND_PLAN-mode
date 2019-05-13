using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// RTE
        /// </summary>
        private List<Point> points = new List<Point>();

        private Random rnd = new Random();// for test

        // data bind
        DataBindString DataGS = new DataBindString("267");
        DataBindString DataTAS = new DataBindString("263");
        DataBindString DataWS = new DataBindString("175/5");
        DataBindString DataNEXTWPT = new DataBindString("DEEF/249°");
        DataBindString DataTIME = new DataBindString("10:20");
        DataBindString DataDIST = new DataBindString("49NM");
        DataBindString DataVORL = new DataBindString("VOR L");
        DataBindString DataVORR = new DataBindString("VOR R");
        DataBindString DataDMEL = new DataBindString("DME L");
        DataBindString DataDMER = new DataBindString("DME R");
        DataBindString DataSSB = new DataBindString("SSB");
        DataBindString DataRKN = new DataBindString("RKN");



        /// <summary>
        /// initial picture background
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void initialWindow(object sender, EventArgs e)
        {
            // back image
            this.pictureBackGround.BackgroundImage = Properties.Resources.background;
            this.pictureBackGround.BackgroundImageLayout = ImageLayout.Stretch;

            // plane
            this.plane.Angel = int.Parse(this.textBoxPlane_A.Text);
            this.plane.Local = new Point(
                int.Parse(this.textBoxPlane_X.Text),
                int.Parse(this.textBoxPlane_Y.Text)
                );

            // data bind
            DataGS.Bind(textBoxGS, labelGS);
            DataTAS.Bind(textBoxTAS, labelTAS);
            DataWS.Bind(textBoxWS, labelWS);
            DataNEXTWPT.Bind(textBoxNEXTWPT, labelNEXTWPT);
            DataDIST.Bind(textBoxDIST, labelDIST);
            DataTIME.Bind(textBoxTIME, labelTIME);
            DataVORL.Bind(textBoxVORL, labelVORL);
            DataVORR.Bind(textBoxVORR, labelVORR);
            DataSSB.Bind(textBoxSSB, labelSSB);
            DataDMER.Bind(textBoxDMER, labelDMER);
            DataDMEL.Bind(textBoxDMEL, labelDMEL);
            DataRKN.Bind(textBoxRKN, labelRKN);



            //update picture box
            this.pictureBackGround.Refresh();
        }

        /// <summary>
        /// rotate picture
        /// </summary>
        /// <param name="image"></param>
        /// <param name="angel"></param>
        /// <returns></returns>
        private static Image RotatePicture(Image image, int angel)
        {
            Image imageResult = new Bitmap(image.Width, image.Height);
            Graphics graphics = Graphics.FromImage(imageResult);
            graphics.TranslateTransform((float)image.Width / 2, (float)image.Height / 2);
            graphics.RotateTransform(angel);
            graphics.TranslateTransform(-(float)image.Width / 2, -(float)image.Height / 2);

            graphics.DrawImage(image, new Point(0, 0));
            graphics.Dispose();

            return imageResult;
        }

        /// <summary>
        /// draw image with point and width/height limit
        /// </summary>
        /// <param name="e"></param>
        /// <param name="image"></param>
        /// <param name="point"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        private static void DrawImage(PaintEventArgs e,
            Image image, Point point, int width, int height, int angel = 0)
        {
            if (angel == 0)
                e.Graphics.DrawImage(image, point.X, point.Y, width, height);
            else
            {
                e.Graphics.DrawImage(RotatePicture(image, angel), point.X, point.Y, width, height);//todo
            }
        }

        /// <summary>
        /// star width and height
        /// </summary>
        private const int widthHeight = 32;
        /// <summary>
        /// draw star
        /// </summary>
        /// <param name="e"></param>
        /// <param name="point"></param>
        /// <param name="highlight">pink or white</param>
        private void DrawStar(PaintEventArgs e, Point point, bool highlight)
        {
            point.Offset(-widthHeight / 2, -widthHeight / 2);
            DrawImage(e, highlight ?
                Properties.Resources.star_pink : Properties.Resources.star_white,
                point, widthHeight, widthHeight);
        }

        /// <summary>
        /// rePaint Picture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBackGround_Paint(object sender, PaintEventArgs e)
        {
            // draw star
            for (int i = 0; i < points.Count; i++)
                DrawStar(e, points[i], i + 1 == points.Count);

            // draw lines
            if (points.Count > 1)
                e.Graphics.DrawLines(Pens.AntiqueWhite, points.ToArray());

            // draw plane
            DrawImage(e, Properties.Resources.nplane, plane.Local, widthHeight, widthHeight, plane.Angel);
        }

        /// <summary>
        /// remove last star
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStarRm_click(object sender, EventArgs e)
        {
            if (points.Count > 0)
                points.RemoveAt(points.Count - 1);

            this.pictureBackGround.Refresh();
        }

        /// <summary>
        /// add star
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStarAdd_click(object sender, EventArgs e)
        {
            Point point = new Point(rnd.Next(100, 600), rnd.Next(100, 600));

            if (points.Count == 0)
            {
                this.plane.Local = point;
            }

            this.points.Add(point);
          this.pictureBackGround.Refresh();
        }

        /// <summary>
        /// clear star
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStarClear_click(object sender, EventArgs e)
        {
            points.Clear();
            this.pictureBackGround.Refresh();
        }

        /// <summary>
        /// ref pic timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerRefershPic_Tick(object sender, EventArgs e)
        {
            //this.plane.Local = new Point(rnd.Next(100, 600), rnd.Next(100, 600));
            //this.pictureBackGround.Refresh();

            //this.toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// plane point
        /// </summary>
        private Plane plane = new Plane(0, 0, 0);
        /// <summary>
        /// change plane location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlaneApply_Click(object sender, EventArgs e)
        {
            plane.Local = new Point(
                int.Parse(this.textBoxPlane_X.Text),
                int.Parse(this.textBoxPlane_Y.Text)
                );
            plane.Angel = int.Parse(this.textBoxPlane_A.Text);
            this.pictureBackGround.Refresh();
        }

        private void textBoxPlane_X_TextChanged(object sender, EventArgs e)
        {

        }

        Mcdu myMcdu = new Mcdu();

        private void button1_Click(object sender, EventArgs e)
        {
            myMcdu.ShowDialog();
        }
    }
}
