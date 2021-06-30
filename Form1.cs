using System;
using System.Drawing;
using System.Windows.Forms;

namespace DZ_24_01_2021
{
    public partial class Form1 : Form
    {
        private enum ButtomName
        {
            StraightLine,
            CurvedLine,
            Circle,
            Square,
            Oval,
            Triangle,
            Rectangle,
            Fiveangle,
            Sixangle,
            Righttriangle,
            ThreeStar,
            FourStar,
            FiveStar,
            None
        }
        private ButtomName selectbuttom;
        private Graphics graph;
        private BaseClassFigure baseClassFigure;
        private Pen pen;
        private SolidBrush brushLine;
        private SolidBrush brushFill;
        private int sizePen;        
        private bool selectFill;
        private Point pointStart;
        private Point pointEnd;
        public Form1()
        {
            InitializeComponent();
            sizePen = 1;
            brushLine = new SolidBrush(Color.Black);
            brushFill = new SolidBrush(Color.White);
            pen = new Pen(brushLine, sizePen);
            picture.Image = new Bitmap(1980, 1024);
            comboBoxThickness.SelectedIndex = 0;
            comboBoxTypeLine.SelectedIndex = 0;
            comboBoxFill.SelectedIndex = 0;
            selectbuttom = ButtomName.None;
        }
        private void PictureMouseDown(object sender, MouseEventArgs e) => pointStart = new Point(e.X, e.Y);
        private void PicturePaint(object sender, PaintEventArgs e)
        {         
            graph = e.Graphics;
            graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;            
            switch (selectbuttom) 
            {
                case ButtomName.StraightLine:
                    baseClassFigure = new ClassStraightLine(pointStart, pointEnd, pen, brushFill, selectFill);
                    baseClassFigure.Show(graph);                   
                    break;
                case ButtomName.CurvedLine:
                    graph= Graphics.FromImage(picture.Image);
                    graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    graph.DrawLine(pen, pointStart.X, pointStart.Y, pointEnd.X, pointEnd.Y);
                    pointStart = pointEnd;
                    break;
                case ButtomName.Circle:
                    baseClassFigure = new ClassCircle(pointStart, pointEnd, pen, brushFill, selectFill);
                    baseClassFigure.Show(graph);                    
                    break;
                case ButtomName.Square:
                    baseClassFigure = new ClassSquare(pointStart, pointEnd, pen, brushFill, selectFill);
                    baseClassFigure.Show(graph);                    
                    break;
                case ButtomName.Oval:
                    baseClassFigure = new ClassEllipse(pointStart, pointEnd, pen, brushFill, selectFill);
                    baseClassFigure.Show(graph);                   
                    break;
                case ButtomName.Triangle:
                    baseClassFigure = new ClassTriangle(pointStart, pointEnd, pen, brushFill, selectFill);
                    baseClassFigure.Show(graph);                    
                    break;
                case ButtomName.Rectangle:
                    baseClassFigure = new ClassRectangle(pointStart, pointEnd, pen, brushFill, selectFill);
                    baseClassFigure.Show(graph);
                    break;
                case ButtomName.Fiveangle:
                    baseClassFigure = new ClassFiveangle(pointStart, pointEnd, pen, brushFill, selectFill);
                    baseClassFigure.Show(graph);       
                    break;
                case ButtomName.Sixangle:
                    baseClassFigure = new ClassSixangle(pointStart, pointEnd, pen, brushFill, selectFill);
                    baseClassFigure.Show(graph);
                    break;
                case ButtomName.Righttriangle:
                    baseClassFigure = new ClassRighttriangle(pointStart, pointEnd, pen, brushFill, selectFill);
                    baseClassFigure.Show(graph);
                    break;
                case ButtomName.ThreeStar:
                    baseClassFigure = new ClassThreeStar(pointStart, pointEnd, pen, brushFill, selectFill);
                    baseClassFigure.Show(graph);                    
                    break;
                case ButtomName.FourStar:
                    baseClassFigure = new ClassFourStar(pointStart, pointEnd, pen, brushFill, selectFill);
                    baseClassFigure.Show(graph);                    
                    break;
                case ButtomName.FiveStar:
                    baseClassFigure = new ClassFiveStar(pointStart, pointEnd, pen, brushFill, selectFill);
                    baseClassFigure.Show(graph);                    
                    break;
                default:
                    break;
            }            
        }
        private void PictureMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {       
                pointEnd = new Point(e.X, e.Y);
                picture.Invalidate();
            }
        }
        private void PictureMouseUp(object sender, MouseEventArgs e)
        {
            if (selectbuttom != ButtomName.None&& selectbuttom != ButtomName.CurvedLine)
            { 
                Graphics temp = Graphics.FromImage(picture.Image);
                temp.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                baseClassFigure.Show(temp); 
                temp.Dispose();
            }      
        }
        private void ButtonColorLineClick(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxColorLine.BackColor = colorDialog.Color;
                brushLine = new SolidBrush(colorDialog.Color);
                pen = new Pen(brushLine, sizePen);
            }
        }
        private void ButtonColorFillClick(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxColorFill.BackColor = colorDialog.Color;
                brushFill = new SolidBrush(colorDialog.Color);                
            }            
        }
        private void SelectButtom(ButtomName buttomName)
        {
            switch (buttomName)
            {
                case ButtomName.StraightLine:                    
                    comboBoxTypeLine.Enabled = true;
                    comboBoxFill.SelectedIndex = 0;
                    comboBoxFill.Enabled = false;
                    toolStripButtonStraightLine.Checked = true;
                    toolStripButtonCurvedLine.Checked = false;
                    toolStripButtonCircle.Checked = false;
                    toolStripButtonSquare.Checked = false;
                    toolStripButtonOval.Checked = false;
                    toolStripButtonTriangle.Checked = false;
                    toolStripButtonRectangle.Checked = false;
                    toolStripButtonFiveangle.Checked = false;
                    toolStripButtonSixangle.Checked = false;
                    toolStripButtonRighttriangle.Checked = false;
                    toolStripButtonThreeStar.Checked = false;
                    toolStripButtonFourStar.Checked = false;
                    toolStripButtonFiveStar.Checked = false;
                    selectbuttom = buttomName;
                    break;
                case ButtomName.CurvedLine:
                    comboBoxTypeLine.SelectedIndex = 0;
                    comboBoxTypeLine.Enabled = false;
                    comboBoxFill.SelectedIndex = 0;
                    comboBoxFill.Enabled = false;
                    toolStripButtonStraightLine.Checked = false;
                    toolStripButtonCurvedLine.Checked = true;
                    toolStripButtonCircle.Checked = false;
                    toolStripButtonSquare.Checked = false;
                    toolStripButtonOval.Checked = false;
                    toolStripButtonTriangle.Checked = false;
                    toolStripButtonRectangle.Checked = false;
                    toolStripButtonFiveangle.Checked = false;
                    toolStripButtonSixangle.Checked = false;
                    toolStripButtonRighttriangle.Checked = false;
                    toolStripButtonThreeStar.Checked = false;
                    toolStripButtonFourStar.Checked = false;
                    toolStripButtonFiveStar.Checked = false;
                    selectbuttom = buttomName;
                    break;
                case ButtomName.Circle:
                    comboBoxTypeLine.Enabled = true;
                    comboBoxFill.Enabled = true;
                    toolStripButtonStraightLine.Checked = false;
                    toolStripButtonCurvedLine.Checked = false;
                    toolStripButtonCircle.Checked = true;
                    toolStripButtonSquare.Checked = false;
                    toolStripButtonOval.Checked = false;
                    toolStripButtonTriangle.Checked = false;
                    toolStripButtonRectangle.Checked = false;
                    toolStripButtonFiveangle.Checked = false;
                    toolStripButtonSixangle.Checked = false;
                    toolStripButtonRighttriangle.Checked = false;
                    toolStripButtonThreeStar.Checked = false;
                    toolStripButtonFourStar.Checked = false;
                    toolStripButtonFiveStar.Checked = false;
                    selectbuttom = buttomName;
                    break;
                case ButtomName.Square:
                    comboBoxTypeLine.Enabled = true;
                    comboBoxFill.Enabled = true;
                    toolStripButtonStraightLine.Checked = false;
                    toolStripButtonCurvedLine.Checked = false;
                    toolStripButtonCircle.Checked = false;
                    toolStripButtonSquare.Checked = true;
                    toolStripButtonOval.Checked = false;
                    toolStripButtonTriangle.Checked = false;
                    toolStripButtonRectangle.Checked = false;
                    toolStripButtonFiveangle.Checked = false;
                    toolStripButtonSixangle.Checked = false;
                    toolStripButtonRighttriangle.Checked = false;
                    toolStripButtonThreeStar.Checked = false;
                    toolStripButtonFourStar.Checked = false;
                    toolStripButtonFiveStar.Checked = false;
                    selectbuttom = buttomName;
                    break;
                case ButtomName.Oval:
                    comboBoxTypeLine.Enabled = true;
                    comboBoxFill.Enabled = true;
                    toolStripButtonStraightLine.Checked = false;
                    toolStripButtonCurvedLine.Checked = false;
                    toolStripButtonCircle.Checked = false;
                    toolStripButtonSquare.Checked = false;
                    toolStripButtonOval.Checked = true;
                    toolStripButtonTriangle.Checked = false;
                    toolStripButtonRectangle.Checked = false;
                    toolStripButtonFiveangle.Checked = false;
                    toolStripButtonSixangle.Checked = false;
                    toolStripButtonRighttriangle.Checked = false;
                    toolStripButtonThreeStar.Checked = false;
                    toolStripButtonFourStar.Checked = false;
                    toolStripButtonFiveStar.Checked = false;
                    selectbuttom = buttomName;
                    break;
                case ButtomName.Triangle:
                    comboBoxTypeLine.Enabled = true;
                    comboBoxFill.Enabled = true;
                    toolStripButtonStraightLine.Checked = false;
                    toolStripButtonCurvedLine.Checked = false;
                    toolStripButtonCircle.Checked = false;
                    toolStripButtonSquare.Checked = false;
                    toolStripButtonOval.Checked = false;
                    toolStripButtonTriangle.Checked = true;
                    toolStripButtonRectangle.Checked = false;
                    toolStripButtonFiveangle.Checked = false;
                    toolStripButtonSixangle.Checked = false;
                    toolStripButtonRighttriangle.Checked = false;
                    toolStripButtonThreeStar.Checked = false;
                    toolStripButtonFourStar.Checked = false;
                    toolStripButtonFiveStar.Checked = false;
                    selectbuttom = buttomName;
                    break;
                case ButtomName.Rectangle:
                    comboBoxTypeLine.Enabled = true;
                    comboBoxFill.Enabled = true;
                    toolStripButtonStraightLine.Checked = false;
                    toolStripButtonCurvedLine.Checked = false;
                    toolStripButtonCircle.Checked = false;
                    toolStripButtonSquare.Checked = false;
                    toolStripButtonOval.Checked = false;
                    toolStripButtonTriangle.Checked = false;
                    toolStripButtonRectangle.Checked = true;
                    toolStripButtonFiveangle.Checked = false;
                    toolStripButtonSixangle.Checked = false;
                    toolStripButtonRighttriangle.Checked = false;
                    toolStripButtonThreeStar.Checked = false;
                    toolStripButtonFourStar.Checked = false;
                    toolStripButtonFiveStar.Checked = false;
                    selectbuttom = buttomName;
                    break;
                case ButtomName.Fiveangle:
                    comboBoxTypeLine.Enabled = true;
                    comboBoxFill.Enabled = true;
                    toolStripButtonStraightLine.Checked = false;
                    toolStripButtonCurvedLine.Checked = false;
                    toolStripButtonCircle.Checked = false;
                    toolStripButtonSquare.Checked = false;
                    toolStripButtonOval.Checked = false;
                    toolStripButtonTriangle.Checked = false;
                    toolStripButtonRectangle.Checked = false;
                    toolStripButtonFiveangle.Checked = true;
                    toolStripButtonSixangle.Checked = false;
                    toolStripButtonRighttriangle.Checked = false;
                    toolStripButtonThreeStar.Checked = false;
                    toolStripButtonFourStar.Checked = false;
                    toolStripButtonFiveStar.Checked = false;
                    selectbuttom = buttomName;
                    break;
                case ButtomName.Sixangle:
                    comboBoxTypeLine.Enabled = true;
                    comboBoxFill.Enabled = true;
                    toolStripButtonStraightLine.Checked = false;
                    toolStripButtonCurvedLine.Checked = false;
                    toolStripButtonCircle.Checked = false;
                    toolStripButtonSquare.Checked = false;
                    toolStripButtonOval.Checked = false;
                    toolStripButtonTriangle.Checked = false;
                    toolStripButtonRectangle.Checked = false;
                    toolStripButtonFiveangle.Checked = false;
                    toolStripButtonSixangle.Checked = true;
                    toolStripButtonRighttriangle.Checked = false;
                    toolStripButtonThreeStar.Checked = false;
                    toolStripButtonFourStar.Checked = false;
                    toolStripButtonFiveStar.Checked = false;
                    selectbuttom = buttomName;
                    break;
                case ButtomName.Righttriangle:
                    comboBoxTypeLine.Enabled = true;
                    comboBoxFill.Enabled = true;
                    toolStripButtonStraightLine.Checked = false;
                    toolStripButtonCurvedLine.Checked = false;
                    toolStripButtonCircle.Checked = false;
                    toolStripButtonSquare.Checked = false;
                    toolStripButtonOval.Checked = false;
                    toolStripButtonTriangle.Checked = false;
                    toolStripButtonRectangle.Checked = false;
                    toolStripButtonFiveangle.Checked = false;
                    toolStripButtonSixangle.Checked = false;
                    toolStripButtonRighttriangle.Checked = true;
                    toolStripButtonThreeStar.Checked = false;
                    toolStripButtonFourStar.Checked = false;
                    toolStripButtonFiveStar.Checked = false;
                    selectbuttom = buttomName;
                    break;
                case ButtomName.ThreeStar:
                    comboBoxTypeLine.Enabled = true;
                    comboBoxFill.Enabled = true;
                    toolStripButtonStraightLine.Checked = false;
                    toolStripButtonCurvedLine.Checked = false;
                    toolStripButtonCircle.Checked = false;
                    toolStripButtonSquare.Checked = false;
                    toolStripButtonOval.Checked = false;
                    toolStripButtonTriangle.Checked = false;
                    toolStripButtonRectangle.Checked = false;
                    toolStripButtonFiveangle.Checked = false;
                    toolStripButtonSixangle.Checked = false;
                    toolStripButtonRighttriangle.Checked = false;
                    toolStripButtonThreeStar.Checked = true;
                    toolStripButtonFourStar.Checked = false;
                    toolStripButtonFiveStar.Checked = false;
                    selectbuttom = buttomName;
                    break;
                case ButtomName.FourStar:
                    comboBoxTypeLine.Enabled = true;
                    comboBoxFill.Enabled = true;
                    toolStripButtonStraightLine.Checked = false;
                    toolStripButtonCurvedLine.Checked = false;
                    toolStripButtonCircle.Checked = false;
                    toolStripButtonSquare.Checked = false;
                    toolStripButtonOval.Checked = false;
                    toolStripButtonTriangle.Checked = false;
                    toolStripButtonRectangle.Checked = false;
                    toolStripButtonFiveangle.Checked = false;
                    toolStripButtonSixangle.Checked = false;
                    toolStripButtonRighttriangle.Checked = false;
                    toolStripButtonThreeStar.Checked = false;
                    toolStripButtonFourStar.Checked = true;
                    toolStripButtonFiveStar.Checked = false;
                    selectbuttom = buttomName;
                    break;
                case ButtomName.FiveStar:
                    comboBoxTypeLine.Enabled = true;
                    comboBoxFill.Enabled = true;
                    toolStripButtonStraightLine.Checked = false;
                    toolStripButtonCurvedLine.Checked = false;
                    toolStripButtonCircle.Checked = false;
                    toolStripButtonSquare.Checked = false;
                    toolStripButtonOval.Checked = false;
                    toolStripButtonTriangle.Checked = false;
                    toolStripButtonRectangle.Checked = false;
                    toolStripButtonFiveangle.Checked = false;
                    toolStripButtonSixangle.Checked = false;
                    toolStripButtonRighttriangle.Checked = false;
                    toolStripButtonThreeStar.Checked = false;
                    toolStripButtonFourStar.Checked = false;
                    toolStripButtonFiveStar.Checked = true;
                    selectbuttom = buttomName;
                    break;
                default:
                    break;
            }
        }
        private void ToolStripButtonStraightLineClick(object sender, EventArgs e) => SelectButtom(ButtomName.StraightLine);
        private void ToolStripButtonCurvedLineClick(object sender, EventArgs e) => SelectButtom(ButtomName.CurvedLine);
        private void ToolStripButtonCircleClick(object sender, EventArgs e) => SelectButtom(ButtomName.Circle);
        private void ToolStripButtonSquareClick(object sender, EventArgs e) => SelectButtom(ButtomName.Square);
        private void ToolStripButtonOvalClick(object sender, EventArgs e) => SelectButtom(ButtomName.Oval);
        private void ToolStripButtonTriangleClick(object sender, EventArgs e) => SelectButtom(ButtomName.Triangle);
        private void ToolStripButtonRectangleClick(object sender, EventArgs e) => SelectButtom(ButtomName.Rectangle);
        private void ToolStripButtonFiveangleClick(object sender, EventArgs e) => SelectButtom(ButtomName.Fiveangle);
        private void ToolStripButtonSixangleClick(object sender, EventArgs e) => SelectButtom(ButtomName.Sixangle);
        private void ToolStripButtonRighttriangleClick(object sender, EventArgs e) => SelectButtom(ButtomName.Righttriangle);
        private void ToolStripButtonThreeStarClick(object sender, EventArgs e) => SelectButtom(ButtomName.ThreeStar);
        private void ToolStripButtonFourStarClick(object sender, EventArgs e) => SelectButtom(ButtomName.FourStar);
        private void ToolStripButtonFiveStarClick(object sender, EventArgs e) => SelectButtom(ButtomName.FiveStar);
        private void ComboBoxThicknessSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).SelectedIndex)
            {
                case 0:                   
                    pen.Width = 1;                   
                    break;
                case 1:
                    pen.Width = 3;                   
                    break;
                case 2:
                    pen.Width = 5;                   
                    break;
                case 3:
                    pen.Width = 8;                   
                    break;
                case 4:
                    pen.Width = 10;                   
                    break;
                case 5:
                    pen.Width = 15;                   
                    break;
                case 6:
                    pen.Width = 20;                  
                    break;
                case 7:
                    pen.Width = 25;                   
                    break;
                case 8:
                    pen.Width = 30;                   
                    break;
                case 9:
                    pen.Width = 40;                  
                    break;
            }
        }
        private void ComboBoxTypeLineSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).SelectedIndex)
            {
                case 0:
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;                   
                    break;
                case 1:
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;                   
                    break;
                case 2:
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;                  
                    break;
                case 3:
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;                 
                    break;
                case 4:
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;                   
                    break;                
            }
        }
        private void ComboBoxFillSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (((ComboBox)sender).SelectedIndex)
            {
                case 0:                    
                    pictureBoxColorFill.Visible = false;
                    buttonColorFill.Enabled = false;
                    selectFill = false;
                    break;
                case 1:
                    pictureBoxColorFill.Visible = true;
                    buttonColorFill.Enabled = true;
                    selectFill = true;
                    break;                
            }
        }
        private void ButtonSaveClick(object sender, EventArgs e)
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "jpg";
            saveFileDialog.Filter= "Image files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                picture.Image.Save(saveFileDialog.FileName);
            }            
        }
    }
}