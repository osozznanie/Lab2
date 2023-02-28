using System;
namespace oopLab1
{
	public class Rhombuses
	{
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        private int x3;
        private int y3;
        private int x4;
        private int y4;
        public Rhombuses(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            this.x4 = x4;
            this.y4 = y4;
        }        

        public int getX1()
        {
            return this.x1;
        }
        public void setX1(int x1)
        {
            this.x1 = x1;
        }
        public int getY1()
        {
            return this.y1;
        }
        public void setY1(int y1)
        {
            this.y1 = y1;
        }
        public int getX2()
        {
            return this.x2;
        }
        public void setX2(int x2)
        {
            this.x2 = x2;
        }
        public int getY2()
        {
            return this.y2;
        }
        public void setY2(int y2)
        {
            this.y2 = y2;
        }
        public int getX3()
        {
            return this.x3;
        }
        public void setX3(int x3)
        {
            this.x3 = x3;
        }
        public int getY3()
        {
            return this.y3;
        }
        public void setY3(int y3)
        {
            this.y3 = y3;
        }
        public int getX4()
        {
            return this.x4;
        }
        public void setX4(int x4)
        {
            this.x4 = x4;
        }
        public int getY4()
        {
            return this.y4;
        }
        public void setY4(int y4)
        {
            this.y4 = y4;
        }
        public double squareRhombuses()
        {
            var d1 = Math.Sqrt(Math.Pow(this.x2 - this.x1, 2) + Math.Pow(this.y2 - this.y1, 2));
            var d2 = Math.Sqrt(Math.Pow(this.x4 - this.x3, 2) + Math.Pow(this.y4 - this.y3, 2));
            return Math.Ceiling(d1 * d2 / 2);
        }
        public double perimeterRhombuses()
        {
            var d1 = Math.Sqrt(Math.Pow(this.x2 - this.x1, 2) + Math.Pow(this.y2 - this.y1, 2));
            return Math.Ceiling(d1 * 4);
        }

        public override string ToString()
        {
            return $"Rhombus with vertices ({x1},{y1}), ({x2},{y2}), ({x3},{y3}), ({x4},{y4})";
        }

    }
}

