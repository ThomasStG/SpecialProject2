using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace SpecialProject2_Paint
{
    public partial class PaintSpace : Form
    {

        Graphics myGraphics;

        

        public PaintSpace()
        {
            InitializeComponent();

            // Creates a graphic object inside of the panel.
            myGraphics = PaintPanel.CreateGraphics();
        }

        // Prompts the user for a color using the color dialog. Waits until the user clicks OK.
        private Color GetColor()
        {
            ColorDialog colorDiologue = new ColorDialog();

            if (colorDiologue.ShowDialog() == DialogResult.OK)
                return colorDiologue.Color;
            return Color.Black;
        }

        // Draw an ellips or circle.
        private void DrawEllip(int[] placement)
        {
            Pen myPen = new Pen(GetColor());

            myGraphics.DrawEllipse(myPen, placement[0], placement[1], placement[2] - placement[0], placement[3] - placement[1]);
            myPen.Dispose();
        }

        // Draw a rectangle with given dimensions.
        private void DrawRect(int[] placement)
        {
            Pen myPen = new Pen(GetColor());
            myGraphics.DrawRectangle(myPen, placement[0], placement[1], placement[2] - placement[0], placement[3] - placement[1]) ;
            myPen.Dispose();
        }

        // Draws a line. Used in freehand mode.
        private void DrawLine(int[] size)
        {
            Pen myPen = new Pen(GetColor());
            myGraphics.DrawLine(myPen, size[0], size[1], size[2], size[3]); ;
            myPen.Dispose();
        }

        // draws a triangle from an array of points.
        private void DrawTriangle(Point[] size)
        {
            Pen myPen = new Pen(GetColor());
            myGraphics.DrawPolygon(myPen, size);
            myPen.Dispose();
        }

        // Validates input and calls DrawRect.
        private void Rect2Draw_Click(object sender, EventArgs e)
        {
            int X, Y, Width, Height;
            if (!int.TryParse(Rect2X.Text, out X))
            {
                MessageBox.Show("Invalid Input for X");
                Rect2X.Text = "X";
                return;
            }
            else if (!int.TryParse(Rect2Y.Text, out Y))
            {
                MessageBox.Show("Invalid Input for Y");
                Rect2Y.Text = "Y";
                return;
            }
            else if (!int.TryParse(Rect2Width.Text, out Width))
            {
                MessageBox.Show("Invalid Input for Width");
                Rect2Width.Text = "Width";
                return;
            }
            else if (!int.TryParse(Rect2Height.Text, out Height))
            {
                MessageBox.Show("Invalid Input for Height");
                Rect2Height.Text = "Height";
                return;
            }
            int[] RectPoints = new int[4] {
                X, Y, 
                Width - X, Height - Y };
            DrawRect(RectPoints);
        }

        private void Rect1Draw_Click(object sender, EventArgs e)
        {
            int X1, Y1, X2, Y2;
            if (!int.TryParse(Rect1X1.Text, out X1))
            {
                MessageBox.Show("Invalid Input for X1");
                Rect1X1.Text = "X1";
                return;
            }
            else if (!int.TryParse(Rect1Y1.Text, out Y1))
            {
                MessageBox.Show("Invalid Input for Y1");
                Rect1Y1.Text = "Y1";
                return;
            }
            else if (!int.TryParse(Rect1X2.Text, out X2))
            {
                MessageBox.Show("Invalid Input for X1");
                Rect1X2.Text = "X2";
                return;
            }
            else if (!int.TryParse(Rect1Y2.Text, out Y2))
            {
                MessageBox.Show("Invalid Input for Y2");
                Rect1Y2.Text = "Y2";
                return;
            }
            int[] RectPoints = new int[4] {
                X1, Y1,
                X2, Y2 };
            DrawRect(RectPoints);
        }

        // validates input and calls DrawLine.
        private void LineDraw_Click(object sender, EventArgs e)
        {
            int X1, Y1, X2, Y2;
            if (!int.TryParse(LineX1.Text, out X1))
            {
                MessageBox.Show("Invalid Input for X1");
                LineX1.Text = "X1";
                return;
            }
            else if (!int.TryParse(LineY1.Text, out Y1))
            {
                MessageBox.Show("Invalid Input for Y1");
                LineY1.Text = "Y1";
                return;
            }
            else if (!int.TryParse(LineX2.Text, out X2))
            {
                MessageBox.Show("Invalid Input for X1");
                LineX2.Text = "X2";
                return;
            }
            else if (!int.TryParse(LineY2.Text, out Y2))
            {
                MessageBox.Show("Invalid Input for Y2");
                LineY2.Text = "Y2";
                return;
            }
            int[] LinePoints = new int[4] { 
                X1, Y1, 
                X2, Y2 };
            DrawLine(LinePoints);
        }

        // Validates input and calls DrawEllip
        private void CircleDraw_Click(object sender, EventArgs e) // X cord, Y cord, Rad
        {
            int CenterX, CenterY, Radius;
            if (!int.TryParse(CircleX.Text, out CenterX))
            {
                MessageBox.Show("Invalid Input for X");
                CircleX.Text = "X";
                return;
            }
            else if (!int.TryParse(CircleY.Text, out CenterY))
            {
                MessageBox.Show("Invalid Input for Y");
                CircleY.Text = "Y";
                return;
            }
            else if (!int.TryParse(CircleRad.Text, out Radius))
            {
                MessageBox.Show("Invalid Input for Radius");
                CircleRad.Text = "Radius";
                return;
            }
            int[] CirclePoints = new int[4] {
                CenterX - Radius, CenterY - Radius,
                CenterX + Radius, CenterY + Radius };
            DrawEllip(CirclePoints);
        }

        // Validates Input and calls DrawTriangle.
        private void TriDraw_Click(object sender, EventArgs e)
        {
            int X1, Y1, X2, Y2, X3, Y3;
            if (!int.TryParse(TriX1.Text, out X1))
            {
                MessageBox.Show("Invalid Input for X1");
                TriX1.Text = "X1";
                return;
            }
            else if (!int.TryParse(TriY1.Text, out Y1))
            {
                MessageBox.Show("Invalid Input for Y1");
                TriY1.Text = "Y1";
                return;
            }
            else if (!int.TryParse(TriX2.Text, out X2))
            {
                MessageBox.Show("Invalid Input for X2");
                TriX2.Text = "X2";
                return;
            }
            if (!int.TryParse(TriY2.Text, out Y2))
            {
                MessageBox.Show("Invalid Input for Y2");
                TriY2.Text = "Y2";
                return;
            }
            else if (!int.TryParse(TriX3.Text, out X3))
            {
                MessageBox.Show("Invalid Input for X3");
                TriX3.Text = "X3";
                return;
            }
            else if (!int.TryParse(TriY3.Text, out Y3))
            {
                MessageBox.Show("Invalid Input for Y3");
                TriY3.Text = "Y3";
                return;
            }

            Point[] TriPoints = new Point[3];
            TriPoints[0].X = X1;
            TriPoints[0].Y = Y1;
            TriPoints[1].X = X2;
            TriPoints[1].Y = Y2;
            TriPoints[2].X = X3;
            TriPoints[2].Y = Y3;

            DrawTriangle(TriPoints);
        }

        // Resets drawing space.
        private void MenuReset_Click(object sender, EventArgs e)
        {
            myGraphics.Clear(Color.White);
            isDrawing = false;
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackColor_Click_1(object sender, EventArgs e)
        {
            PaintPanel.BackColor = GetColor();
        }
    }
}