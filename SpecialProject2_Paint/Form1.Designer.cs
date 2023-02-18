namespace SpecialProject2_Paint
{
    partial class PaintSpace
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReset = new System.Windows.Forms.ToolStripTextBox();
            this.MenuExit = new System.Windows.Forms.ToolStripTextBox();
            this.rectangleStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rect1X1 = new System.Windows.Forms.ToolStripTextBox();
            this.Rect1Y1 = new System.Windows.Forms.ToolStripTextBox();
            this.Rect1X2 = new System.Windows.Forms.ToolStripTextBox();
            this.Rect1Y2 = new System.Windows.Forms.ToolStripTextBox();
            this.Rect1Draw = new System.Windows.Forms.ToolStripTextBox();
            this.pointHeightAndWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rect2X = new System.Windows.Forms.ToolStripTextBox();
            this.Rect2Y = new System.Windows.Forms.ToolStripTextBox();
            this.Rect2Width = new System.Windows.Forms.ToolStripTextBox();
            this.Rect2Height = new System.Windows.Forms.ToolStripTextBox();
            this.Rect2Draw = new System.Windows.Forms.ToolStripTextBox();
            this.circleStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CircleX = new System.Windows.Forms.ToolStripTextBox();
            this.CircleY = new System.Windows.Forms.ToolStripTextBox();
            this.CircleRad = new System.Windows.Forms.ToolStripTextBox();
            this.CircleDraw = new System.Windows.Forms.ToolStripTextBox();
            this.lineStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LineX1 = new System.Windows.Forms.ToolStripTextBox();
            this.LineY1 = new System.Windows.Forms.ToolStripTextBox();
            this.LineX2 = new System.Windows.Forms.ToolStripTextBox();
            this.LineY2 = new System.Windows.Forms.ToolStripTextBox();
            this.LineDraw = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.triangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TriX1 = new System.Windows.Forms.ToolStripTextBox();
            this.TriY1 = new System.Windows.Forms.ToolStripTextBox();
            this.TriX2 = new System.Windows.Forms.ToolStripTextBox();
            this.TriY2 = new System.Windows.Forms.ToolStripTextBox();
            this.TriX3 = new System.Windows.Forms.ToolStripTextBox();
            this.TriY3 = new System.Windows.Forms.ToolStripTextBox();
            this.TriDraw = new System.Windows.Forms.ToolStripTextBox();
            this.FreeBool = new System.Windows.Forms.ToolStripTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.PaintPanel = new System.Windows.Forms.Panel();
            this.BackColor = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.rectangleStripItem,
            this.circleStripItem,
            this.lineStripItem,
            this.toolStripMenuItem1,
            this.triangleToolStripMenuItem,
            this.FreeBool,
            this.BackColor});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1700, 43);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuReset,
            this.MenuExit});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(97, 39);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // MenuReset
            // 
            this.MenuReset.Name = "MenuReset";
            this.MenuReset.ReadOnly = true;
            this.MenuReset.Size = new System.Drawing.Size(100, 39);
            this.MenuReset.Text = "Reset";
            this.MenuReset.ToolTipText = "Reset the canvas to white";
            this.MenuReset.Click += new System.EventHandler(this.MenuReset_Click);
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.ReadOnly = true;
            this.MenuExit.Size = new System.Drawing.Size(100, 39);
            this.MenuExit.Text = "Exit";
            this.MenuExit.ToolTipText = "Exit the program";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // rectangleStripItem
            // 
            this.rectangleStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointsToolStripMenuItem,
            this.pointHeightAndWidthToolStripMenuItem});
            this.rectangleStripItem.Name = "rectangleStripItem";
            this.rectangleStripItem.Size = new System.Drawing.Size(138, 39);
            this.rectangleStripItem.Text = "Rectangle";
            // 
            // pointsToolStripMenuItem
            // 
            this.pointsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Rect1X1,
            this.Rect1Y1,
            this.Rect1X2,
            this.Rect1Y2,
            this.Rect1Draw});
            this.pointsToolStripMenuItem.Name = "pointsToolStripMenuItem";
            this.pointsToolStripMenuItem.Size = new System.Drawing.Size(435, 44);
            this.pointsToolStripMenuItem.Text = "2 points";
            // 
            // Rect1X1
            // 
            this.Rect1X1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.Rect1X1.Name = "Rect1X1";
            this.Rect1X1.Size = new System.Drawing.Size(100, 39);
            this.Rect1X1.Text = "X1";
            this.Rect1X1.ToolTipText = "Enter X Coordinate for the top left corner";
            // 
            // Rect1Y1
            // 
            this.Rect1Y1.Name = "Rect1Y1";
            this.Rect1Y1.Size = new System.Drawing.Size(100, 39);
            this.Rect1Y1.Text = "Y1";
            this.Rect1Y1.ToolTipText = "Enter Y Coordinate for the top left corner";
            // 
            // Rect1X2
            // 
            this.Rect1X2.Name = "Rect1X2";
            this.Rect1X2.Size = new System.Drawing.Size(100, 39);
            this.Rect1X2.Text = "X2";
            this.Rect1X2.ToolTipText = "Enter X Coordinate for the bottom right corner";
            // 
            // Rect1Y2
            // 
            this.Rect1Y2.Name = "Rect1Y2";
            this.Rect1Y2.Size = new System.Drawing.Size(100, 39);
            this.Rect1Y2.Text = "Y2";
            this.Rect1Y2.ToolTipText = "Enter Y Coordinate for the bottom right corner";
            // 
            // Rect1Draw
            // 
            this.Rect1Draw.Name = "Rect1Draw";
            this.Rect1Draw.ReadOnly = true;
            this.Rect1Draw.Size = new System.Drawing.Size(100, 39);
            this.Rect1Draw.Text = "Draw";
            this.Rect1Draw.ToolTipText = "Draw the rectangle";
            this.Rect1Draw.Click += new System.EventHandler(this.Rect1Draw_Click);
            // 
            // pointHeightAndWidthToolStripMenuItem
            // 
            this.pointHeightAndWidthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Rect2X,
            this.Rect2Y,
            this.Rect2Width,
            this.Rect2Height,
            this.Rect2Draw});
            this.pointHeightAndWidthToolStripMenuItem.Name = "pointHeightAndWidthToolStripMenuItem";
            this.pointHeightAndWidthToolStripMenuItem.Size = new System.Drawing.Size(435, 44);
            this.pointHeightAndWidthToolStripMenuItem.Text = "1 point + height and width";
            // 
            // Rect2X
            // 
            this.Rect2X.Name = "Rect2X";
            this.Rect2X.Size = new System.Drawing.Size(100, 39);
            this.Rect2X.Text = "X";
            this.Rect2X.ToolTipText = "Enter X Coordinate for the top left corner";
            // 
            // Rect2Y
            // 
            this.Rect2Y.Name = "Rect2Y";
            this.Rect2Y.Size = new System.Drawing.Size(100, 39);
            this.Rect2Y.Text = "Y";
            this.Rect2Y.ToolTipText = "Enter Y Coordinate for the top left corner\r\n";
            // 
            // Rect2Width
            // 
            this.Rect2Width.Name = "Rect2Width";
            this.Rect2Width.Size = new System.Drawing.Size(100, 39);
            this.Rect2Width.Text = "Width";
            this.Rect2Width.ToolTipText = "Enter Width";
            // 
            // Rect2Height
            // 
            this.Rect2Height.Name = "Rect2Height";
            this.Rect2Height.Size = new System.Drawing.Size(100, 39);
            this.Rect2Height.Text = "Height";
            this.Rect2Height.ToolTipText = "Enter Height";
            // 
            // Rect2Draw
            // 
            this.Rect2Draw.Name = "Rect2Draw";
            this.Rect2Draw.ReadOnly = true;
            this.Rect2Draw.Size = new System.Drawing.Size(100, 39);
            this.Rect2Draw.Text = "Draw";
            this.Rect2Draw.ToolTipText = "Draw the Rectangle";
            this.Rect2Draw.Click += new System.EventHandler(this.Rect2Draw_Click);
            // 
            // circleStripItem
            // 
            this.circleStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CircleX,
            this.CircleY,
            this.CircleRad,
            this.CircleDraw});
            this.circleStripItem.Name = "circleStripItem";
            this.circleStripItem.Size = new System.Drawing.Size(93, 39);
            this.circleStripItem.Text = "Circle";
            // 
            // CircleX
            // 
            this.CircleX.Name = "CircleX";
            this.CircleX.Size = new System.Drawing.Size(100, 39);
            this.CircleX.Text = "X";
            this.CircleX.ToolTipText = "Enter X Coordinate of the center";
            // 
            // CircleY
            // 
            this.CircleY.Name = "CircleY";
            this.CircleY.Size = new System.Drawing.Size(100, 39);
            this.CircleY.Text = "Y";
            this.CircleY.ToolTipText = "Enter Y Coordinate of the center";
            // 
            // CircleRad
            // 
            this.CircleRad.Name = "CircleRad";
            this.CircleRad.Size = new System.Drawing.Size(100, 39);
            this.CircleRad.Text = "Radius";
            this.CircleRad.ToolTipText = "Enter Radius";
            // 
            // CircleDraw
            // 
            this.CircleDraw.Name = "CircleDraw";
            this.CircleDraw.ReadOnly = true;
            this.CircleDraw.Size = new System.Drawing.Size(100, 39);
            this.CircleDraw.Text = "Draw";
            this.CircleDraw.ToolTipText = "Draw the circle";
            this.CircleDraw.Click += new System.EventHandler(this.CircleDraw_Click);
            // 
            // lineStripItem
            // 
            this.lineStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LineX1,
            this.LineY1,
            this.LineX2,
            this.LineY2,
            this.LineDraw});
            this.lineStripItem.Name = "lineStripItem";
            this.lineStripItem.Size = new System.Drawing.Size(78, 39);
            this.lineStripItem.Text = "Line";
            // 
            // LineX1
            // 
            this.LineX1.Name = "LineX1";
            this.LineX1.Size = new System.Drawing.Size(100, 39);
            this.LineX1.Text = "X1";
            this.LineX1.ToolTipText = "Enter the X coordinate of the first point";
            // 
            // LineY1
            // 
            this.LineY1.Name = "LineY1";
            this.LineY1.Size = new System.Drawing.Size(100, 39);
            this.LineY1.Text = "Y1";
            this.LineY1.ToolTipText = "Enter Y Coordinate for the first point";
            // 
            // LineX2
            // 
            this.LineX2.Name = "LineX2";
            this.LineX2.Size = new System.Drawing.Size(100, 39);
            this.LineX2.Text = "X2";
            this.LineX2.ToolTipText = "Enter X Coordinate for the second point";
            // 
            // LineY2
            // 
            this.LineY2.Name = "LineY2";
            this.LineY2.Size = new System.Drawing.Size(100, 39);
            this.LineY2.Text = "Y2";
            this.LineY2.ToolTipText = "Enter Y Coordinate for the second point";
            // 
            // LineDraw
            // 
            this.LineDraw.Name = "LineDraw";
            this.LineDraw.ReadOnly = true;
            this.LineDraw.Size = new System.Drawing.Size(100, 39);
            this.LineDraw.Text = "Draw";
            this.LineDraw.ToolTipText = "Draw the line";
            this.LineDraw.Click += new System.EventHandler(this.LineDraw_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(20, 39);
            // 
            // triangleToolStripMenuItem
            // 
            this.triangleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TriX1,
            this.TriY1,
            this.TriX2,
            this.TriY2,
            this.TriX3,
            this.TriY3,
            this.TriDraw});
            this.triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            this.triangleToolStripMenuItem.Size = new System.Drawing.Size(118, 39);
            this.triangleToolStripMenuItem.Text = "Triangle";
            // 
            // TriX1
            // 
            this.TriX1.Name = "TriX1";
            this.TriX1.Size = new System.Drawing.Size(100, 39);
            this.TriX1.Text = "X1";
            this.TriX1.ToolTipText = "Enter the X coordinate of the first point";
            // 
            // TriY1
            // 
            this.TriY1.Name = "TriY1";
            this.TriY1.Size = new System.Drawing.Size(100, 39);
            this.TriY1.Text = "Y1";
            this.TriY1.ToolTipText = "Enter the y coordinate of the first point";
            // 
            // TriX2
            // 
            this.TriX2.Name = "TriX2";
            this.TriX2.Size = new System.Drawing.Size(100, 39);
            this.TriX2.Text = "X2";
            this.TriX2.ToolTipText = "Enter the x coordinate of the second point";
            // 
            // TriY2
            // 
            this.TriY2.Name = "TriY2";
            this.TriY2.Size = new System.Drawing.Size(100, 39);
            this.TriY2.Text = "Y2";
            this.TriY2.ToolTipText = "Enter the y coordinate of the second point";
            // 
            // TriX3
            // 
            this.TriX3.Name = "TriX3";
            this.TriX3.Size = new System.Drawing.Size(100, 39);
            this.TriX3.Text = "X3";
            this.TriX3.ToolTipText = "Enter the x coordinate of the third point";
            // 
            // TriY3
            // 
            this.TriY3.Name = "TriY3";
            this.TriY3.Size = new System.Drawing.Size(100, 39);
            this.TriY3.Text = "Y3";
            this.TriY3.ToolTipText = "Enter the y coordinate of the third point";
            // 
            // TriDraw
            // 
            this.TriDraw.Name = "TriDraw";
            this.TriDraw.ReadOnly = true;
            this.TriDraw.Size = new System.Drawing.Size(100, 39);
            this.TriDraw.Text = "Draw";
            this.TriDraw.ToolTipText = "Draw the triangle";
            this.TriDraw.Click += new System.EventHandler(this.TriDraw_Click);
            // 
            // FreeBool
            // 
            this.FreeBool.Name = "FreeBool";
            this.FreeBool.ReadOnly = true;
            this.FreeBool.Size = new System.Drawing.Size(120, 39);
            this.FreeBool.Text = "Free Hand";
            this.FreeBool.ToolTipText = "Draw lines with your mouse";
            this.FreeBool.Click += new System.EventHandler(this.FreeBool_Click);
            // 
            // PaintPanel
            // 
            this.PaintPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaintPanel.Location = new System.Drawing.Point(11, 55);
            this.PaintPanel.Name = "PaintPanel";
            this.PaintPanel.Size = new System.Drawing.Size(1676, 1157);
            this.PaintPanel.TabIndex = 2;
            this.PaintPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaintPanel_MouseDown);
            this.PaintPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintPanel_MouseMove_1);
            // 
            // BackColor
            // 
            this.BackColor.Name = "BackColor";
            this.BackColor.ReadOnly = true;
            this.BackColor.Size = new System.Drawing.Size(290, 39);
            this.BackColor.Text = "Change Background Color";
            this.BackColor.Click += new System.EventHandler(this.BackColor_Click_1);
            // 
            // PaintSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 1222);
            this.Controls.Add(this.PaintPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PaintSpace";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem rectangleStripItem;
        private ToolStripMenuItem circleStripItem;
        private ToolStripMenuItem lineStripItem;
        private ToolStripMenuItem pointsToolStripMenuItem;
        private ToolStripMenuItem pointHeightAndWidthToolStripMenuItem;
        private ToolStripTextBox Rect2X;
        private ToolStripTextBox Rect2Y;
        private ToolStripTextBox Rect2Width;
        private ToolStripTextBox Rect1X1;
        private ToolStripTextBox Rect1Y1;
        private ToolStripTextBox Rect1X2;
        private ToolStripTextBox Rect1Y2;
        private ToolStripTextBox Rect2Height;
        private ToolStripTextBox CircleX;
        private ToolStripTextBox CircleY;
        private ToolStripTextBox CircleRad;
        private ToolStripTextBox LineX1;
        private ToolStripTextBox LineY1;
        private ToolStripTextBox LineX2;
        private ToolStripTextBox LineY2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ColorDialog colorDialog1;
        private ColorDialog colorDialog2;
        private ColorDialog colorDialog3;
        private ToolStripMenuItem triangleToolStripMenuItem;
        private ToolStripTextBox Rect1Draw;
        private ToolStripTextBox Rect2Draw;
        private ToolStripTextBox CircleDraw;
        private ToolStripTextBox LineDraw;
        private ToolStripTextBox TriX1;
        private ToolStripTextBox TriY1;
        private ToolStripTextBox TriX2;
        private ToolStripTextBox TriY2;
        private ToolStripTextBox TriX3;
        private ToolStripTextBox TriY3;
        private ToolStripTextBox TriDraw;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripTextBox MenuReset;
        private ToolStripTextBox MenuExit;
        private Panel PaintPanel;
        private ToolStripTextBox FreeBool;
        private ToolStripTextBox BackColor;
        //private ToolStripTextBox BackColor;
    }
}