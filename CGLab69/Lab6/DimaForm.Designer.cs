
namespace CGLab69.Lab6
{
    partial class DimaForm
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
            this.figureBox = new System.Windows.Forms.GroupBox();
            this.octaRadioButton = new System.Windows.Forms.RadioButton();
            this.hexaRadioButton = new System.Windows.Forms.RadioButton();
            this.tetraRadioButton = new System.Windows.Forms.RadioButton();
            this.projectionBox = new System.Windows.Forms.GroupBox();
            this.dimetricRadioButton = new System.Windows.Forms.RadioButton();
            this.trimetricRadioButton = new System.Windows.Forms.RadioButton();
            this.isometricRadioButton = new System.Windows.Forms.RadioButton();
            this.perspectiveRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonScale = new System.Windows.Forms.Button();
            this.buttonRotateZ = new System.Windows.Forms.Button();
            this.buttonRotateY = new System.Windows.Forms.Button();
            this.buttonRotateX = new System.Windows.Forms.Button();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.buttonTranslate = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRef = new System.Windows.Forms.Button();
            this.radioButtonZ = new System.Windows.Forms.RadioButton();
            this.radioButtonY = new System.Windows.Forms.RadioButton();
            this.radioButtonX = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonScaleC = new System.Windows.Forms.Button();
            this.textBoxScale = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxZ2 = new System.Windows.Forms.TextBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxZ1 = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxRotate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonRotation = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButtonDP = new System.Windows.Forms.RadioButton();
            this.figureBox.SuspendLayout();
            this.projectionBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // figureBox
            // 
            this.figureBox.Controls.Add(this.octaRadioButton);
            this.figureBox.Controls.Add(this.hexaRadioButton);
            this.figureBox.Controls.Add(this.tetraRadioButton);
            this.figureBox.Location = new System.Drawing.Point(6, 573);
            this.figureBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.figureBox.Name = "figureBox";
            this.figureBox.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.figureBox.Size = new System.Drawing.Size(179, 125);
            this.figureBox.TabIndex = 0;
            this.figureBox.TabStop = false;
            this.figureBox.Text = "Figure";
            // 
            // octaRadioButton
            // 
            this.octaRadioButton.AutoSize = true;
            this.octaRadioButton.Location = new System.Drawing.Point(31, 85);
            this.octaRadioButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.octaRadioButton.Name = "octaRadioButton";
            this.octaRadioButton.Size = new System.Drawing.Size(108, 24);
            this.octaRadioButton.TabIndex = 2;
            this.octaRadioButton.TabStop = true;
            this.octaRadioButton.Text = "Octahedron";
            this.octaRadioButton.UseVisualStyleBackColor = true;
            this.octaRadioButton.CheckedChanged += new System.EventHandler(this.octaRadioButton_CheckedChanged);
            // 
            // hexaRadioButton
            // 
            this.hexaRadioButton.AutoSize = true;
            this.hexaRadioButton.Location = new System.Drawing.Point(31, 60);
            this.hexaRadioButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.hexaRadioButton.Name = "hexaRadioButton";
            this.hexaRadioButton.Size = new System.Drawing.Size(111, 24);
            this.hexaRadioButton.TabIndex = 1;
            this.hexaRadioButton.TabStop = true;
            this.hexaRadioButton.Text = "Hexahedron";
            this.hexaRadioButton.UseVisualStyleBackColor = true;
            this.hexaRadioButton.CheckedChanged += new System.EventHandler(this.hexaRadioButton_CheckedChanged);
            // 
            // tetraRadioButton
            // 
            this.tetraRadioButton.AutoSize = true;
            this.tetraRadioButton.Location = new System.Drawing.Point(31, 33);
            this.tetraRadioButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tetraRadioButton.Name = "tetraRadioButton";
            this.tetraRadioButton.Size = new System.Drawing.Size(110, 24);
            this.tetraRadioButton.TabIndex = 0;
            this.tetraRadioButton.TabStop = true;
            this.tetraRadioButton.Text = "Tetrahedron";
            this.tetraRadioButton.UseVisualStyleBackColor = true;
            this.tetraRadioButton.CheckedChanged += new System.EventHandler(this.tetraRadioButton_CheckedChanged);
            // 
            // projectionBox
            // 
            this.projectionBox.Controls.Add(this.dimetricRadioButton);
            this.projectionBox.Controls.Add(this.trimetricRadioButton);
            this.projectionBox.Controls.Add(this.isometricRadioButton);
            this.projectionBox.Controls.Add(this.perspectiveRadioButton);
            this.projectionBox.Location = new System.Drawing.Point(197, 573);
            this.projectionBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.projectionBox.Name = "projectionBox";
            this.projectionBox.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.projectionBox.Size = new System.Drawing.Size(179, 125);
            this.projectionBox.TabIndex = 1;
            this.projectionBox.TabStop = false;
            this.projectionBox.Text = "Projection";
            // 
            // dimetricRadioButton
            // 
            this.dimetricRadioButton.AutoSize = true;
            this.dimetricRadioButton.Location = new System.Drawing.Point(3, 99);
            this.dimetricRadioButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dimetricRadioButton.Name = "dimetricRadioButton";
            this.dimetricRadioButton.Size = new System.Drawing.Size(87, 24);
            this.dimetricRadioButton.TabIndex = 3;
            this.dimetricRadioButton.TabStop = true;
            this.dimetricRadioButton.Text = "Dimetric";
            this.dimetricRadioButton.UseVisualStyleBackColor = true;
            this.dimetricRadioButton.CheckedChanged += new System.EventHandler(this.dimetricRadioButton_CheckedChanged);
            // 
            // trimetricRadioButton
            // 
            this.trimetricRadioButton.AutoSize = true;
            this.trimetricRadioButton.Location = new System.Drawing.Point(3, 76);
            this.trimetricRadioButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.trimetricRadioButton.Name = "trimetricRadioButton";
            this.trimetricRadioButton.Size = new System.Drawing.Size(88, 24);
            this.trimetricRadioButton.TabIndex = 2;
            this.trimetricRadioButton.TabStop = true;
            this.trimetricRadioButton.Text = "Trimetric";
            this.trimetricRadioButton.UseVisualStyleBackColor = true;
            this.trimetricRadioButton.CheckedChanged += new System.EventHandler(this.trimetricRadioButton_CheckedChanged);
            // 
            // isometricRadioButton
            // 
            this.isometricRadioButton.AutoSize = true;
            this.isometricRadioButton.Location = new System.Drawing.Point(3, 51);
            this.isometricRadioButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.isometricRadioButton.Name = "isometricRadioButton";
            this.isometricRadioButton.Size = new System.Drawing.Size(91, 24);
            this.isometricRadioButton.TabIndex = 1;
            this.isometricRadioButton.TabStop = true;
            this.isometricRadioButton.Text = "Isometric";
            this.isometricRadioButton.UseVisualStyleBackColor = true;
            this.isometricRadioButton.CheckedChanged += new System.EventHandler(this.isometricRadioButton_CheckedChanged);
            // 
            // perspectiveRadioButton
            // 
            this.perspectiveRadioButton.AutoSize = true;
            this.perspectiveRadioButton.Location = new System.Drawing.Point(3, 24);
            this.perspectiveRadioButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.perspectiveRadioButton.Name = "perspectiveRadioButton";
            this.perspectiveRadioButton.Size = new System.Drawing.Size(104, 24);
            this.perspectiveRadioButton.TabIndex = 0;
            this.perspectiveRadioButton.TabStop = true;
            this.perspectiveRadioButton.Text = "Perspective";
            this.perspectiveRadioButton.UseVisualStyleBackColor = true;
            this.perspectiveRadioButton.CheckedChanged += new System.EventHandler(this.perspectiveRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.buttonScale);
            this.groupBox1.Controls.Add(this.buttonRotateZ);
            this.groupBox1.Controls.Add(this.buttonRotateY);
            this.groupBox1.Controls.Add(this.buttonRotateX);
            this.groupBox1.Controls.Add(this.numericUpDown4);
            this.groupBox1.Controls.Add(this.buttonTranslate);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Location = new System.Drawing.Point(387, 573);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Size = new System.Drawing.Size(736, 125);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transformations";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(566, 51);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(94, 29);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(401, 51);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 27);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonScale
            // 
            this.buttonScale.Location = new System.Drawing.Point(401, 83);
            this.buttonScale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonScale.Name = "buttonScale";
            this.buttonScale.Size = new System.Drawing.Size(86, 31);
            this.buttonScale.TabIndex = 9;
            this.buttonScale.Text = "Scale";
            this.buttonScale.UseVisualStyleBackColor = true;
            this.buttonScale.Click += new System.EventHandler(this.buttonScale_Click);
            // 
            // buttonRotateZ
            // 
            this.buttonRotateZ.Location = new System.Drawing.Point(293, 83);
            this.buttonRotateZ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRotateZ.Name = "buttonRotateZ";
            this.buttonRotateZ.Size = new System.Drawing.Size(86, 31);
            this.buttonRotateZ.TabIndex = 7;
            this.buttonRotateZ.Text = "RotateZ";
            this.buttonRotateZ.UseVisualStyleBackColor = true;
            this.buttonRotateZ.Click += new System.EventHandler(this.buttonRotateZ_Click);
            // 
            // buttonRotateY
            // 
            this.buttonRotateY.Location = new System.Drawing.Point(293, 51);
            this.buttonRotateY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRotateY.Name = "buttonRotateY";
            this.buttonRotateY.Size = new System.Drawing.Size(86, 31);
            this.buttonRotateY.TabIndex = 6;
            this.buttonRotateY.Text = "RotateY";
            this.buttonRotateY.UseVisualStyleBackColor = true;
            this.buttonRotateY.Click += new System.EventHandler(this.buttonRotateY_Click);
            // 
            // buttonRotateX
            // 
            this.buttonRotateX.Location = new System.Drawing.Point(293, 19);
            this.buttonRotateX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRotateX.Name = "buttonRotateX";
            this.buttonRotateX.Size = new System.Drawing.Size(86, 31);
            this.buttonRotateX.TabIndex = 5;
            this.buttonRotateX.Text = "RotateX";
            this.buttonRotateX.UseVisualStyleBackColor = true;
            this.buttonRotateX.Click += new System.EventHandler(this.buttonRotateX_Click);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(222, 19);
            this.numericUpDown4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(64, 27);
            this.numericUpDown4.TabIndex = 4;
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Location = new System.Drawing.Point(69, 80);
            this.buttonTranslate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(86, 31);
            this.buttonTranslate.TabIndex = 3;
            this.buttonTranslate.Text = "Translate";
            this.buttonTranslate.UseVisualStyleBackColor = true;
            this.buttonTranslate.Click += new System.EventHandler(this.buttonTranslate_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(151, 43);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(64, 27);
            this.numericUpDown3.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(80, 43);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(64, 27);
            this.numericUpDown2.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(9, 41);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 27);
            this.numericUpDown1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRef);
            this.groupBox2.Controls.Add(this.radioButtonZ);
            this.groupBox2.Controls.Add(this.radioButtonY);
            this.groupBox2.Controls.Add(this.radioButtonX);
            this.groupBox2.Location = new System.Drawing.Point(1128, 573);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 125);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reflection ";
            // 
            // buttonRef
            // 
            this.buttonRef.Location = new System.Drawing.Point(70, 57);
            this.buttonRef.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRef.Name = "buttonRef";
            this.buttonRef.Size = new System.Drawing.Size(86, 31);
            this.buttonRef.TabIndex = 10;
            this.buttonRef.Text = "Reflection";
            this.buttonRef.UseVisualStyleBackColor = true;
            this.buttonRef.Click += new System.EventHandler(this.buttonRef_Click);
            // 
            // radioButtonZ
            // 
            this.radioButtonZ.AutoSize = true;
            this.radioButtonZ.Location = new System.Drawing.Point(6, 95);
            this.radioButtonZ.Name = "radioButtonZ";
            this.radioButtonZ.Size = new System.Drawing.Size(47, 24);
            this.radioButtonZ.TabIndex = 2;
            this.radioButtonZ.TabStop = true;
            this.radioButtonZ.Text = "YZ";
            this.radioButtonZ.UseVisualStyleBackColor = true;
            // 
            // radioButtonY
            // 
            this.radioButtonY.AutoSize = true;
            this.radioButtonY.Location = new System.Drawing.Point(6, 60);
            this.radioButtonY.Name = "radioButtonY";
            this.radioButtonY.Size = new System.Drawing.Size(47, 24);
            this.radioButtonY.TabIndex = 1;
            this.radioButtonY.TabStop = true;
            this.radioButtonY.Text = "XY";
            this.radioButtonY.UseVisualStyleBackColor = true;
            // 
            // radioButtonX
            // 
            this.radioButtonX.AutoSize = true;
            this.radioButtonX.Location = new System.Drawing.Point(6, 26);
            this.radioButtonX.Name = "radioButtonX";
            this.radioButtonX.Size = new System.Drawing.Size(48, 24);
            this.radioButtonX.TabIndex = 0;
            this.radioButtonX.TabStop = true;
            this.radioButtonX.Text = "XZ";
            this.radioButtonX.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonScaleC);
            this.groupBox3.Controls.Add(this.textBoxScale);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(1305, 573);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 125);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Scaling(Center)";
            // 
            // buttonScaleC
            // 
            this.buttonScaleC.Location = new System.Drawing.Point(25, 87);
            this.buttonScaleC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonScaleC.Name = "buttonScaleC";
            this.buttonScaleC.Size = new System.Drawing.Size(101, 31);
            this.buttonScaleC.TabIndex = 11;
            this.buttonScaleC.Text = "Scale";
            this.buttonScaleC.UseVisualStyleBackColor = true;
            this.buttonScaleC.Click += new System.EventHandler(this.buttonScaleC_Click);
            // 
            // textBoxScale
            // 
            this.textBoxScale.Location = new System.Drawing.Point(25, 53);
            this.textBoxScale.Name = "textBoxScale";
            this.textBoxScale.Size = new System.Drawing.Size(101, 27);
            this.textBoxScale.TabIndex = 1;
            this.textBoxScale.TextChanged += new System.EventHandler(this.textBoxScale_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBoxZ2);
            this.groupBox4.Controls.Add(this.textBoxY2);
            this.groupBox4.Controls.Add(this.textBoxX2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBoxZ1);
            this.groupBox4.Controls.Add(this.textBoxY1);
            this.groupBox4.Controls.Add(this.textBoxX1);
            this.groupBox4.Controls.Add(this.buttonDraw);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.textBoxRotate);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(1482, 525);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(321, 173);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rotate(Line)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Point2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Point1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Z";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "X";
            // 
            // textBoxZ2
            // 
            this.textBoxZ2.Location = new System.Drawing.Point(141, 95);
            this.textBoxZ2.Name = "textBoxZ2";
            this.textBoxZ2.Size = new System.Drawing.Size(38, 27);
            this.textBoxZ2.TabIndex = 17;
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(97, 95);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(38, 27);
            this.textBoxY2.TabIndex = 18;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(53, 95);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(38, 27);
            this.textBoxX2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 15;
            // 
            // textBoxZ1
            // 
            this.textBoxZ1.Location = new System.Drawing.Point(141, 66);
            this.textBoxZ1.Name = "textBoxZ1";
            this.textBoxZ1.Size = new System.Drawing.Size(38, 27);
            this.textBoxZ1.TabIndex = 14;
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(97, 66);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(38, 27);
            this.textBoxY1.TabIndex = 14;
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(53, 66);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(38, 27);
            this.textBoxX1.TabIndex = 13;
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(69, 137);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(94, 29);
            this.buttonDraw.TabIndex = 12;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 105);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Rotate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxRotate
            // 
            this.textBoxRotate.Location = new System.Drawing.Point(216, 74);
            this.textBoxRotate.Name = "textBoxRotate";
            this.textBoxRotate.Size = new System.Drawing.Size(83, 27);
            this.textBoxRotate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(125, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 20);
            this.label15.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(125, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 20);
            this.label14.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 23;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(227, 51);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(59, 27);
            this.numericUpDown5.TabIndex = 8;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButtonDP);
            this.groupBox5.Controls.Add(this.buttonCreate);
            this.groupBox5.Controls.Add(this.buttonRotation);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.numericUpDown5);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Location = new System.Drawing.Point(1482, 362);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(321, 157);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rotation figures";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(54, 118);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(94, 29);
            this.buttonCreate.TabIndex = 28;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonRotation
            // 
            this.buttonRotation.Location = new System.Drawing.Point(173, 118);
            this.buttonRotation.Name = "buttonRotation";
            this.buttonRotation.Size = new System.Drawing.Size(94, 29);
            this.buttonRotation.TabIndex = 27;
            this.buttonRotation.Text = "Rotation";
            this.buttonRotation.UseVisualStyleBackColor = true;
            this.buttonRotation.Click += new System.EventHandler(this.buttonRotation_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Ось вращения";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.comboBox1.Location = new System.Drawing.Point(227, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(59, 28);
            this.comboBox1.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Количество разбиений";
            // 
            // radioButtonDP
            // 
            this.radioButtonDP.AutoSize = true;
            this.radioButtonDP.Location = new System.Drawing.Point(49, 29);
            this.radioButtonDP.Name = "radioButtonDP";
            this.radioButtonDP.Size = new System.Drawing.Size(112, 24);
            this.radioButtonDP.TabIndex = 29;
            this.radioButtonDP.TabStop = true;
            this.radioButtonDP.Text = "Draw Points ";
            this.radioButtonDP.UseVisualStyleBackColor = true;
            // 
            // DimaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1806, 700);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.projectionBox);
            this.Controls.Add(this.figureBox);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DimaForm";
            this.Text = "DimaForm";
            this.Shown += new System.EventHandler(this.DimaForm_Shown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DimaForm_Click);
            this.figureBox.ResumeLayout(false);
            this.figureBox.PerformLayout();
            this.projectionBox.ResumeLayout(false);
            this.projectionBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox figureBox;
        private System.Windows.Forms.RadioButton tetraRadioButton;
        private System.Windows.Forms.RadioButton octaRadioButton;
        private System.Windows.Forms.RadioButton hexaRadioButton;
        private System.Windows.Forms.GroupBox projectionBox;
        private System.Windows.Forms.RadioButton isometricRadioButton;
        private System.Windows.Forms.RadioButton perspectiveRadioButton;
        private System.Windows.Forms.RadioButton dimetricRadioButton;
        private System.Windows.Forms.RadioButton trimetricRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonTranslate;
        private System.Windows.Forms.Button buttonRotateX;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Button buttonRotateZ;
        private System.Windows.Forms.Button buttonRotateY;
        private System.Windows.Forms.Button buttonScale;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonZ;
        private System.Windows.Forms.RadioButton radioButtonY;
        private System.Windows.Forms.RadioButton radioButtonX;
        private System.Windows.Forms.Button buttonRef;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonScaleC;
        private System.Windows.Forms.TextBox textBoxScale;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxRotate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxZ2;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxZ1;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonRotation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.RadioButton radioButtonDP;
    }
}