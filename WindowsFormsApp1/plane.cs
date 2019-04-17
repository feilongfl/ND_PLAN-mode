using System.Drawing;

namespace WindowsFormsApp1
{
    class Plane
    {
        /// <summary>
        /// location
        /// </summary>
        private Point local;
        /// <summary>
        /// Rotate angel 0,359
        /// </summary>
        private int angel;

        public Point Local { get => local; set => local = value; }
        public int Angel { get => angel; set => angel = value % 360; }

        public Plane(Point point, int angel)
        {
            this.local = point;
            this.angel = angel;
        }

        public Plane(int x, int y, int angel)
        {
            this.local = new Point(x, y);
            this.angel = angel;
        }
    }
}
