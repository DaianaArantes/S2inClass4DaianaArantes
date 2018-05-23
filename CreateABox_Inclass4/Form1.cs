/*
 * Daiana Arantes
 * April, 2, 2018
 * Inclass - 4 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateABox_Inclass4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Z { get; set; }

            public Point (int a, int b, int c)
            {
                X = a;
                Y = b;
                Z = c;
            }
        }

        public class Line
        {
            public Point Pt1 {get; set; }
            public Point Pt2 { get; set; }
        }

        public class Box
        {
            public Line Ln1 { get; set; }
            public Line Ln2 { get; set; }
            public Line Ln3 { get; set; }
        }

        //Method to calculate area of the box
        public int CalArea(int l, int w)
        {
            return l * w;
        }

        //Method to calculate Volume of the box
        public int CalVol(int l, int w, int h)
        {
            return l * w * h;
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {

            labelMsg.Text = "";
            string msg = "";
            int l = 0, w = 0, h = 0;
            int s1 = 0, s2 = 0, s3 = 0;
            int volume = 0;

            Box myBox = new Box();
            myBox.Ln1 = new Line();
            myBox.Ln2 = new Line();
            myBox.Ln3 = new Line();

            myBox.Ln1.Pt1 = new Point(Convert.ToInt16(textBoxX1.Text), Convert.ToInt16(textBoxY1.Text), Convert.ToInt16(textBoxZ1.Text));
            myBox.Ln1.Pt2 = new Point(Convert.ToInt16(textBoxX1.Text), Convert.ToInt16(textBoxY1.Text), Convert.ToInt16(textBoxZ2.Text));

            myBox.Ln2.Pt1 = new Point(Convert.ToInt16(textBoxX1.Text), Convert.ToInt16(textBoxY1.Text), Convert.ToInt16(textBoxZ1.Text));
            myBox.Ln2.Pt2 = new Point(Convert.ToInt16(textBoxX1.Text), Convert.ToInt16(textBoxY2.Text), Convert.ToInt16(textBoxZ1.Text));

            myBox.Ln3.Pt1 = new Point(Convert.ToInt16(textBoxX1.Text), Convert.ToInt16(textBoxY1.Text), Convert.ToInt16(textBoxZ1.Text));
            myBox.Ln3.Pt2 = new Point(Convert.ToInt16(textBoxX2.Text), Convert.ToInt16(textBoxY1.Text), Convert.ToInt16(textBoxZ1.Text));

            msg = "The box contains the following lines:\n";
            
            msg += "Line 1: Point 1 (" + myBox.Ln1.Pt1.X + "," + myBox.Ln1.Pt1.Y + "," + myBox.Ln1.Pt1.Z + ")" +
           " ," + "Point 2 (" + myBox.Ln1.Pt2.X + ", " + myBox.Ln1.Pt2.Y + ", " + myBox.Ln1.Pt2.Z + ")\n";
            msg += "Line 2: Point 1 (" + myBox.Ln2.Pt1.X + "," + myBox.Ln2.Pt1.Y + "," + myBox.Ln2.Pt1.Z + ")" +
                " ," + "Point 2 (" + myBox.Ln2.Pt2.X + ", " + myBox.Ln2.Pt2.Y + ", " + myBox.Ln2.Pt2.Z + ")\n";
            msg += "Line 3: Point 1 (" + myBox.Ln3.Pt1.X + "," + myBox.Ln3.Pt1.Y + "," + myBox.Ln3.Pt1.Z + ")" +
                " ," + "Point 2 (" + myBox.Ln3.Pt2.X + ", " + myBox.Ln3.Pt2.Y + ", " + myBox.Ln3.Pt2.Z + ")\n";


            l =Math.Abs(Convert.ToInt16(textBoxX2.Text) - Convert.ToInt16(textBoxX1.Text));
            w = Math.Abs(Convert.ToInt16(textBoxY2.Text) - Convert.ToInt16(textBoxY1.Text));
            h= Math.Abs(Convert.ToInt16(textBoxZ2.Text)-Convert.ToInt16(textBoxZ1.Text));

            s1 = CalArea(l, w);
            s2 = CalArea(l, h);
            s3 = CalArea(h, w);

            volume=CalVol(l, w, h);

            msg += "Area S1: " + s1.ToString()+"\n";
            msg += "Area S2: " + s2.ToString() + "\n";
            msg += "Area S3: " + s3.ToString() + "\n\n";
            msg += "Total surface area: " + ((s1 + s2 + s3) * 2).ToString() + "\n\n";

            msg += "Volume: " + volume.ToString() + "\n";

            labelMsg.Text = msg;
        }
    }
}
