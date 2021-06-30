namespace DZ_24_01_2021
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picture = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.labelFigure = new System.Windows.Forms.Label();
            this.toolStripIcons = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonStraightLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCurvedLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCircle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSquare = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOval = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTriangle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRectangle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFiveangle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSixangle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRighttriangle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonThreeStar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFourStar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFiveStar = new System.Windows.Forms.ToolStripButton();
            this.comboBoxTypeLine = new System.Windows.Forms.ComboBox();
            this.labelTypeLine = new System.Windows.Forms.Label();
            this.labelThickness = new System.Windows.Forms.Label();
            this.comboBoxThickness = new System.Windows.Forms.ComboBox();
            this.labelFill = new System.Windows.Forms.Label();
            this.comboBoxFill = new System.Windows.Forms.ComboBox();
            this.labelColorFill = new System.Windows.Forms.Label();
            this.labelColorLine = new System.Windows.Forms.Label();
            this.pictureBoxColorLine = new System.Windows.Forms.PictureBox();
            this.pictureBoxColorFill = new System.Windows.Forms.PictureBox();
            this.buttonColorLine = new System.Windows.Forms.Button();
            this.buttonColorFill = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.toolStripIcons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorFill)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture.BackColor = System.Drawing.Color.White;
            this.picture.Location = new System.Drawing.Point(0, 140);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(800, 310);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.Paint += new System.Windows.Forms.PaintEventHandler(this.PicturePaint);
            this.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureMouseDown);
            this.picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureMouseMove);
            this.picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureMouseUp);
            // 
            // labelFigure
            // 
            this.labelFigure.AutoSize = true;
            this.labelFigure.Location = new System.Drawing.Point(27, 85);
            this.labelFigure.Name = "labelFigure";
            this.labelFigure.Size = new System.Drawing.Size(48, 13);
            this.labelFigure.TabIndex = 3;
            this.labelFigure.Text = "Фигуры";
            // 
            // toolStripIcons
            // 
            this.toolStripIcons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripIcons.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripIcons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripIcons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonStraightLine,
            this.toolStripButtonCurvedLine,
            this.toolStripButtonCircle,
            this.toolStripButtonSquare,
            this.toolStripButtonOval,
            this.toolStripButtonTriangle,
            this.toolStripButtonRectangle,
            this.toolStripButtonFiveangle,
            this.toolStripButtonSixangle,
            this.toolStripButtonRighttriangle,
            this.toolStripButtonThreeStar,
            this.toolStripButtonFourStar,
            this.toolStripButtonFiveStar});
            this.toolStripIcons.Location = new System.Drawing.Point(78, 79);
            this.toolStripIcons.Name = "toolStripIcons";
            this.toolStripIcons.Size = new System.Drawing.Size(302, 25);
            this.toolStripIcons.TabIndex = 2;
            this.toolStripIcons.Text = "toolStrip1";
            // 
            // toolStripButtonStraightLine
            // 
            this.toolStripButtonStraightLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStraightLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStraightLine.Image")));
            this.toolStripButtonStraightLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStraightLine.Name = "toolStripButtonStraightLine";
            this.toolStripButtonStraightLine.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonStraightLine.Text = "Прямая линия";
            this.toolStripButtonStraightLine.Click += new System.EventHandler(this.ToolStripButtonStraightLineClick);
            // 
            // toolStripButtonCurvedLine
            // 
            this.toolStripButtonCurvedLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCurvedLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCurvedLine.Image")));
            this.toolStripButtonCurvedLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCurvedLine.Name = "toolStripButtonCurvedLine";
            this.toolStripButtonCurvedLine.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCurvedLine.Text = "Набросок";
            this.toolStripButtonCurvedLine.Click += new System.EventHandler(this.ToolStripButtonCurvedLineClick);
            // 
            // toolStripButtonCircle
            // 
            this.toolStripButtonCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCircle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCircle.Image")));
            this.toolStripButtonCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCircle.Name = "toolStripButtonCircle";
            this.toolStripButtonCircle.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCircle.Text = "Круг";
            this.toolStripButtonCircle.Click += new System.EventHandler(this.ToolStripButtonCircleClick);
            // 
            // toolStripButtonSquare
            // 
            this.toolStripButtonSquare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSquare.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSquare.Image")));
            this.toolStripButtonSquare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSquare.Name = "toolStripButtonSquare";
            this.toolStripButtonSquare.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSquare.Text = "Квадрат";
            this.toolStripButtonSquare.ToolTipText = "Квадрат";
            this.toolStripButtonSquare.Click += new System.EventHandler(this.ToolStripButtonSquareClick);
            // 
            // toolStripButtonOval
            // 
            this.toolStripButtonOval.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOval.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOval.Image")));
            this.toolStripButtonOval.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOval.Name = "toolStripButtonOval";
            this.toolStripButtonOval.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOval.Text = "Овал";
            this.toolStripButtonOval.ToolTipText = "Овал";
            this.toolStripButtonOval.Click += new System.EventHandler(this.ToolStripButtonOvalClick);
            // 
            // toolStripButtonTriangle
            // 
            this.toolStripButtonTriangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonTriangle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTriangle.Image")));
            this.toolStripButtonTriangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTriangle.Name = "toolStripButtonTriangle";
            this.toolStripButtonTriangle.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonTriangle.Text = "Треугольник";
            this.toolStripButtonTriangle.ToolTipText = "Треугольник";
            this.toolStripButtonTriangle.Click += new System.EventHandler(this.ToolStripButtonTriangleClick);
            // 
            // toolStripButtonRectangle
            // 
            this.toolStripButtonRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRectangle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRectangle.Image")));
            this.toolStripButtonRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRectangle.Name = "toolStripButtonRectangle";
            this.toolStripButtonRectangle.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRectangle.Text = "Прямоугольник";
            this.toolStripButtonRectangle.ToolTipText = "Прямоугольник";
            this.toolStripButtonRectangle.Click += new System.EventHandler(this.ToolStripButtonRectangleClick);
            // 
            // toolStripButtonFiveangle
            // 
            this.toolStripButtonFiveangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFiveangle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFiveangle.Image")));
            this.toolStripButtonFiveangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFiveangle.Name = "toolStripButtonFiveangle";
            this.toolStripButtonFiveangle.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFiveangle.Text = "Пятиугольник";
            this.toolStripButtonFiveangle.ToolTipText = "Пятиугольник";
            this.toolStripButtonFiveangle.Click += new System.EventHandler(this.ToolStripButtonFiveangleClick);
            // 
            // toolStripButtonSixangle
            // 
            this.toolStripButtonSixangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSixangle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSixangle.Image")));
            this.toolStripButtonSixangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSixangle.Name = "toolStripButtonSixangle";
            this.toolStripButtonSixangle.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSixangle.Text = "Шестиугольник";
            this.toolStripButtonSixangle.ToolTipText = "Шестиугольник";
            this.toolStripButtonSixangle.Click += new System.EventHandler(this.ToolStripButtonSixangleClick);
            // 
            // toolStripButtonRighttriangle
            // 
            this.toolStripButtonRighttriangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRighttriangle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRighttriangle.Image")));
            this.toolStripButtonRighttriangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRighttriangle.Name = "toolStripButtonRighttriangle";
            this.toolStripButtonRighttriangle.RightToLeftAutoMirrorImage = true;
            this.toolStripButtonRighttriangle.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRighttriangle.Text = "Прямоугольный треугольник";
            this.toolStripButtonRighttriangle.Click += new System.EventHandler(this.ToolStripButtonRighttriangleClick);
            // 
            // toolStripButtonThreeStar
            // 
            this.toolStripButtonThreeStar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonThreeStar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonThreeStar.Image")));
            this.toolStripButtonThreeStar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonThreeStar.Name = "toolStripButtonThreeStar";
            this.toolStripButtonThreeStar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonThreeStar.Text = "Трехконечная звезда";
            this.toolStripButtonThreeStar.Click += new System.EventHandler(this.ToolStripButtonThreeStarClick);
            // 
            // toolStripButtonFourStar
            // 
            this.toolStripButtonFourStar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFourStar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFourStar.Image")));
            this.toolStripButtonFourStar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFourStar.Name = "toolStripButtonFourStar";
            this.toolStripButtonFourStar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFourStar.Text = "Четырехконечная звезда";
            this.toolStripButtonFourStar.Click += new System.EventHandler(this.ToolStripButtonFourStarClick);
            // 
            // toolStripButtonFiveStar
            // 
            this.toolStripButtonFiveStar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFiveStar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFiveStar.Image")));
            this.toolStripButtonFiveStar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFiveStar.Name = "toolStripButtonFiveStar";
            this.toolStripButtonFiveStar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFiveStar.Text = "Пятиконечная звезда";
            this.toolStripButtonFiveStar.Click += new System.EventHandler(this.ToolStripButtonFiveStarClick);
            // 
            // comboBoxTypeLine
            // 
            this.comboBoxTypeLine.FormattingEnabled = true;
            this.comboBoxTypeLine.Items.AddRange(new object[] {
            "Сплошная",
            "Штрих",
            "Точка",
            "Штрих-пунктир",
            "Штрих-две точки"});
            this.comboBoxTypeLine.Location = new System.Drawing.Point(81, 13);
            this.comboBoxTypeLine.Name = "comboBoxTypeLine";
            this.comboBoxTypeLine.Size = new System.Drawing.Size(108, 21);
            this.comboBoxTypeLine.TabIndex = 4;
            this.comboBoxTypeLine.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTypeLineSelectedIndexChanged);
            // 
            // labelTypeLine
            // 
            this.labelTypeLine.AutoSize = true;
            this.labelTypeLine.Location = new System.Drawing.Point(16, 16);
            this.labelTypeLine.Name = "labelTypeLine";
            this.labelTypeLine.Size = new System.Drawing.Size(59, 13);
            this.labelTypeLine.TabIndex = 5;
            this.labelTypeLine.Text = "Тип линии";
            // 
            // labelThickness
            // 
            this.labelThickness.AutoSize = true;
            this.labelThickness.Location = new System.Drawing.Point(193, 16);
            this.labelThickness.Name = "labelThickness";
            this.labelThickness.Size = new System.Drawing.Size(53, 13);
            this.labelThickness.TabIndex = 7;
            this.labelThickness.Text = "Толщина";
            // 
            // comboBoxThickness
            // 
            this.comboBoxThickness.FormattingEnabled = true;
            this.comboBoxThickness.Items.AddRange(new object[] {
            "1 px",
            "3 px",
            "5 px",
            "8 px",
            "10 px",
            "15 px",
            "20 px",
            "25 px",
            "30 px",
            "40 px"});
            this.comboBoxThickness.Location = new System.Drawing.Point(252, 13);
            this.comboBoxThickness.Name = "comboBoxThickness";
            this.comboBoxThickness.Size = new System.Drawing.Size(79, 21);
            this.comboBoxThickness.TabIndex = 6;
            this.comboBoxThickness.SelectedIndexChanged += new System.EventHandler(this.ComboBoxThicknessSelectedIndexChanged);
            // 
            // labelFill
            // 
            this.labelFill.AutoSize = true;
            this.labelFill.Location = new System.Drawing.Point(196, 45);
            this.labelFill.Name = "labelFill";
            this.labelFill.Size = new System.Drawing.Size(50, 13);
            this.labelFill.TabIndex = 9;
            this.labelFill.Text = "Заливка";
            // 
            // comboBoxFill
            // 
            this.comboBoxFill.FormattingEnabled = true;
            this.comboBoxFill.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.comboBoxFill.Location = new System.Drawing.Point(252, 40);
            this.comboBoxFill.Name = "comboBoxFill";
            this.comboBoxFill.Size = new System.Drawing.Size(79, 21);
            this.comboBoxFill.TabIndex = 8;
            this.comboBoxFill.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFillSelectedIndexChanged);
            // 
            // labelColorFill
            // 
            this.labelColorFill.AutoSize = true;
            this.labelColorFill.Location = new System.Drawing.Point(337, 43);
            this.labelColorFill.Name = "labelColorFill";
            this.labelColorFill.Size = new System.Drawing.Size(32, 13);
            this.labelColorFill.TabIndex = 10;
            this.labelColorFill.Text = "Цвет";
            // 
            // labelColorLine
            // 
            this.labelColorLine.AutoSize = true;
            this.labelColorLine.Location = new System.Drawing.Point(337, 16);
            this.labelColorLine.Name = "labelColorLine";
            this.labelColorLine.Size = new System.Drawing.Size(32, 13);
            this.labelColorLine.TabIndex = 11;
            this.labelColorLine.Text = "Цвет";
            // 
            // pictureBoxColorLine
            // 
            this.pictureBoxColorLine.BackColor = System.Drawing.Color.Black;
            this.pictureBoxColorLine.Location = new System.Drawing.Point(375, 13);
            this.pictureBoxColorLine.Name = "pictureBoxColorLine";
            this.pictureBoxColorLine.Size = new System.Drawing.Size(22, 21);
            this.pictureBoxColorLine.TabIndex = 12;
            this.pictureBoxColorLine.TabStop = false;
            // 
            // pictureBoxColorFill
            // 
            this.pictureBoxColorFill.BackColor = System.Drawing.Color.White;
            this.pictureBoxColorFill.Location = new System.Drawing.Point(375, 41);
            this.pictureBoxColorFill.Name = "pictureBoxColorFill";
            this.pictureBoxColorFill.Size = new System.Drawing.Size(22, 20);
            this.pictureBoxColorFill.TabIndex = 13;
            this.pictureBoxColorFill.TabStop = false;
            // 
            // buttonColorLine
            // 
            this.buttonColorLine.Location = new System.Drawing.Point(403, 13);
            this.buttonColorLine.Name = "buttonColorLine";
            this.buttonColorLine.Size = new System.Drawing.Size(72, 21);
            this.buttonColorLine.TabIndex = 14;
            this.buttonColorLine.Text = "Изменить";
            this.buttonColorLine.UseVisualStyleBackColor = true;
            this.buttonColorLine.Click += new System.EventHandler(this.ButtonColorLineClick);
            // 
            // buttonColorFill
            // 
            this.buttonColorFill.Location = new System.Drawing.Point(403, 41);
            this.buttonColorFill.Name = "buttonColorFill";
            this.buttonColorFill.Size = new System.Drawing.Size(72, 20);
            this.buttonColorFill.TabIndex = 15;
            this.buttonColorFill.Text = "Изменить";
            this.buttonColorFill.UseVisualStyleBackColor = true;
            this.buttonColorFill.Click += new System.EventHandler(this.ButtonColorFillClick);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(509, 21);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 98);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 134);
            this.panel1.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTypeLine);
            this.groupBox1.Controls.Add(this.toolStripIcons);
            this.groupBox1.Controls.Add(this.comboBoxTypeLine);
            this.groupBox1.Controls.Add(this.labelFigure);
            this.groupBox1.Controls.Add(this.buttonColorFill);
            this.groupBox1.Controls.Add(this.comboBoxThickness);
            this.groupBox1.Controls.Add(this.buttonColorLine);
            this.groupBox1.Controls.Add(this.labelThickness);
            this.groupBox1.Controls.Add(this.pictureBoxColorFill);
            this.groupBox1.Controls.Add(this.comboBoxFill);
            this.groupBox1.Controls.Add(this.pictureBoxColorLine);
            this.groupBox1.Controls.Add(this.labelFill);
            this.groupBox1.Controls.Add(this.labelColorLine);
            this.groupBox1.Controls.Add(this.labelColorFill);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picture);
            this.Name = "Form1";
            this.Text = "Paint";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PicturePaint);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.toolStripIcons.ResumeLayout(false);
            this.toolStripIcons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorFill)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label labelFigure;
        private System.Windows.Forms.ToolStrip toolStripIcons;
        private System.Windows.Forms.ToolStripButton toolStripButtonStraightLine;
        private System.Windows.Forms.ToolStripButton toolStripButtonCurvedLine;
        private System.Windows.Forms.ToolStripButton toolStripButtonCircle;
        private System.Windows.Forms.ToolStripButton toolStripButtonSquare;
        private System.Windows.Forms.ToolStripButton toolStripButtonOval;
        private System.Windows.Forms.ToolStripButton toolStripButtonTriangle;
        private System.Windows.Forms.ToolStripButton toolStripButtonRectangle;
        private System.Windows.Forms.ToolStripButton toolStripButtonFiveangle;
        private System.Windows.Forms.ToolStripButton toolStripButtonSixangle;
        private System.Windows.Forms.ToolStripButton toolStripButtonRighttriangle;
        private System.Windows.Forms.ToolStripButton toolStripButtonThreeStar;
        private System.Windows.Forms.ToolStripButton toolStripButtonFourStar;
        private System.Windows.Forms.ToolStripButton toolStripButtonFiveStar;
        private System.Windows.Forms.ComboBox comboBoxTypeLine;
        private System.Windows.Forms.Label labelTypeLine;
        private System.Windows.Forms.Label labelThickness;
        private System.Windows.Forms.ComboBox comboBoxThickness;
        private System.Windows.Forms.Label labelFill;
        private System.Windows.Forms.ComboBox comboBoxFill;
        private System.Windows.Forms.Label labelColorFill;
        private System.Windows.Forms.Label labelColorLine;
        private System.Windows.Forms.PictureBox pictureBoxColorLine;
        private System.Windows.Forms.PictureBox pictureBoxColorFill;
        private System.Windows.Forms.Button buttonColorLine;
        private System.Windows.Forms.Button buttonColorFill;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

