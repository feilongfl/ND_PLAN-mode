﻿using System;
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

        //RTE
        private List<Point> points = new List<Point>();
        private Random rnd = new Random();// for test


        /// <summary>
        /// initial picture background
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void initialWindow(object sender, EventArgs e)
        {
            this.pictureBackGround.BackgroundImage = Properties.Resources.background;
            this.pictureBackGround.BackgroundImageLayout = ImageLayout.Stretch;
        }

        /// <summary>
        /// draw image with point and width/height limit
        /// </summary>
        /// <param name="e"></param>
        /// <param name="image"></param>
        /// <param name="point"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        private void DrawImage(PaintEventArgs e, Image image, Point point, int width, int height)
        {
            e.Graphics.DrawImage(image, point.X, point.Y, width, height);
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
            //e.Graphics.DrawImage(Properties.Resources.star_pink, 300, 300, 32, 32);
            for (int i = 0; i < points.Count; i++)
            {
                DrawStar(e, points[i], i + 1 == points.Count);
            }
            if (points.Count > 1)
            {
                e.Graphics.DrawLines(Pens.AntiqueWhite, points.ToArray());
            }
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
            this.points.Add(new Point(rnd.Next(100, 600), rnd.Next(100, 600)));
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
            this.pictureBackGround.Refresh();
        }
    }
}
