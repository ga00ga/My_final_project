using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLanguageAssignment
{
    public class Circle : Shapes
    {
        public int radius;

        public  Circle() : base()
        {
            this.radius = 0;
        }


        public override void set(int x, int y, Pen pen, SolidBrush brush, params int[] list) 
        {
            this.radius = list[0];
            this.x = x;
            this.y = y;
            this.pen = pen;
            this.brush = brush;
        }


        /// <summary>
        /// This method draws a circle
        /// </summary>
        /// <param name="g"></param>
        public override void draw(Graphics g)
        {
            float xPosition = (x - (radius / 2)) + 2;
            float yPosition = (y - (radius / 2)) + 2;

            g.DrawEllipse(pen, xPosition, yPosition, radius, radius);
            g.FillEllipse(brush, xPosition, yPosition, radius, radius);
        }
    }
}
