
namespace Sierpinski_Triangle
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxScreen = new System.Windows.Forms.PictureBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.numericUpDownDotWidth = new System.Windows.Forms.NumericUpDown();
            this.labelDotWidth = new System.Windows.Forms.Label();
            this.timerDraw = new System.Windows.Forms.Timer(this.components);
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.pictureBoxLine = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.numericUpDownDotSpeed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDotAmount = new System.Windows.Forms.Label();
            this.numericUpDownDotAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxRndColors = new System.Windows.Forms.CheckBox();
            this.labelSpeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDotWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDotSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDotAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxScreen
            // 
            this.pictureBoxScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxScreen.Location = new System.Drawing.Point(0, -1);
            this.pictureBoxScreen.Name = "pictureBoxScreen";
            this.pictureBoxScreen.Size = new System.Drawing.Size(487, 511);
            this.pictureBoxScreen.TabIndex = 0;
            this.pictureBoxScreen.TabStop = false;
            this.pictureBoxScreen.Resize += new System.EventHandler(this.pictureBoxScreen_Resize);
            // 
            // buttonDraw
            // 
            this.buttonDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDraw.Location = new System.Drawing.Point(497, 12);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(139, 35);
            this.buttonDraw.TabIndex = 1;
            this.buttonDraw.Text = "НАРИСОВАТЬ";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // numericUpDownDotWidth
            // 
            this.numericUpDownDotWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownDotWidth.DecimalPlaces = 1;
            this.numericUpDownDotWidth.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownDotWidth.Location = new System.Drawing.Point(497, 119);
            this.numericUpDownDotWidth.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownDotWidth.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            this.numericUpDownDotWidth.Name = "numericUpDownDotWidth";
            this.numericUpDownDotWidth.Size = new System.Drawing.Size(139, 20);
            this.numericUpDownDotWidth.TabIndex = 2;
            this.numericUpDownDotWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDotWidth.ValueChanged += new System.EventHandler(this.numericUpDownDotWidth_ValueChanged);
            // 
            // labelDotWidth
            // 
            this.labelDotWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDotWidth.AutoSize = true;
            this.labelDotWidth.Location = new System.Drawing.Point(494, 100);
            this.labelDotWidth.Name = "labelDotWidth";
            this.labelDotWidth.Size = new System.Drawing.Size(80, 13);
            this.labelDotWidth.TabIndex = 3;
            this.labelDotWidth.Text = "Размер точек:";
            // 
            // timerDraw
            // 
            this.timerDraw.Interval = 1000;
            this.timerDraw.Tick += new System.EventHandler(this.timerDraw_Tick);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop.Location = new System.Drawing.Point(566, 53);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(139, 35);
            this.buttonStop.TabIndex = 4;
            this.buttonStop.Text = "СТОП";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClean.Location = new System.Drawing.Point(642, 12);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(139, 35);
            this.buttonClean.TabIndex = 5;
            this.buttonClean.Text = "ОЧИСТИТЬ";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green",
            "Black",
            "Gray"});
            this.comboBoxColor.Location = new System.Drawing.Point(642, 119);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(139, 21);
            this.comboBoxColor.TabIndex = 6;
            // 
            // labelColor
            // 
            this.labelColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(639, 100);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(66, 13);
            this.labelColor.TabIndex = 7;
            this.labelColor.Text = "Цвет точек:";
            // 
            // pictureBoxLine
            // 
            this.pictureBoxLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLine.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxLine.Location = new System.Drawing.Point(484, -26);
            this.pictureBoxLine.Name = "pictureBoxLine";
            this.pictureBoxLine.Size = new System.Drawing.Size(10, 597);
            this.pictureBoxLine.TabIndex = 8;
            this.pictureBoxLine.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(676, 489);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(105, 13);
            this.labelTitle.TabIndex = 9;
            this.labelTitle.Text = "By: Ovseukov Yehor";
            // 
            // numericUpDownDotSpeed
            // 
            this.numericUpDownDotSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownDotSpeed.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownDotSpeed.Location = new System.Drawing.Point(642, 159);
            this.numericUpDownDotSpeed.Maximum = new decimal(new int[] {
            1337,
            0,
            0,
            0});
            this.numericUpDownDotSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDotSpeed.Name = "numericUpDownDotSpeed";
            this.numericUpDownDotSpeed.Size = new System.Drawing.Size(139, 20);
            this.numericUpDownDotSpeed.TabIndex = 10;
            this.numericUpDownDotSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDotSpeed.ValueChanged += new System.EventHandler(this.numericUpDownDotSpeed_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(639, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Скорось точек:";
            // 
            // labelDotAmount
            // 
            this.labelDotAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDotAmount.AutoSize = true;
            this.labelDotAmount.Location = new System.Drawing.Point(497, 143);
            this.labelDotAmount.Name = "labelDotAmount";
            this.labelDotAmount.Size = new System.Drawing.Size(100, 13);
            this.labelDotAmount.TabIndex = 13;
            this.labelDotAmount.Text = "Количество точек:";
            // 
            // numericUpDownDotAmount
            // 
            this.numericUpDownDotAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownDotAmount.Location = new System.Drawing.Point(500, 159);
            this.numericUpDownDotAmount.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDownDotAmount.Name = "numericUpDownDotAmount";
            this.numericUpDownDotAmount.Size = new System.Drawing.Size(139, 20);
            this.numericUpDownDotAmount.TabIndex = 12;
            this.numericUpDownDotAmount.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "* 0 - бесконечный цикл.";
            // 
            // checkBoxRndColors
            // 
            this.checkBoxRndColors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxRndColors.AutoSize = true;
            this.checkBoxRndColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxRndColors.Location = new System.Drawing.Point(588, 198);
            this.checkBoxRndColors.Name = "checkBoxRndColors";
            this.checkBoxRndColors.Size = new System.Drawing.Size(117, 17);
            this.checkBoxRndColors.TabIndex = 15;
            this.checkBoxRndColors.Text = "Рандомные цвета";
            this.checkBoxRndColors.UseVisualStyleBackColor = true;
            // 
            // labelSpeed
            // 
            this.labelSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(639, 182);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(112, 13);
            this.labelSpeed.TabIndex = 16;
            this.labelSpeed.Text = "** 1 - максимальная ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.checkBoxRndColors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDotAmount);
            this.Controls.Add(this.numericUpDownDotAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownDotSpeed);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxLine);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.labelDotWidth);
            this.Controls.Add(this.numericUpDownDotWidth);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.pictureBoxScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "Form1";
            this.Text = "Треугольник Овсеюкова";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDotWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDotSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDotAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxScreen;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.NumericUpDown numericUpDownDotWidth;
        private System.Windows.Forms.Label labelDotWidth;
        private System.Windows.Forms.Timer Draw_Tick;
        private System.Windows.Forms.Timer timerDraw;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.PictureBox pictureBoxLine;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.NumericUpDown numericUpDownDotSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDotAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownDotAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxRndColors;
        private System.Windows.Forms.Label labelSpeed;
    }
}

