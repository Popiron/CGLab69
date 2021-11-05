
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
            this.figureBox.SuspendLayout();
            this.projectionBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // figureBox
            // 
            this.figureBox.Controls.Add(this.octaRadioButton);
            this.figureBox.Controls.Add(this.hexaRadioButton);
            this.figureBox.Controls.Add(this.tetraRadioButton);
            this.figureBox.Location = new System.Drawing.Point(5, 430);
            this.figureBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.figureBox.Name = "figureBox";
            this.figureBox.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.figureBox.Size = new System.Drawing.Size(157, 94);
            this.figureBox.TabIndex = 0;
            this.figureBox.TabStop = false;
            this.figureBox.Text = "Figure";
            // 
            // octaRadioButton
            // 
            this.octaRadioButton.AutoSize = true;
            this.octaRadioButton.Location = new System.Drawing.Point(27, 64);
            this.octaRadioButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.octaRadioButton.Name = "octaRadioButton";
            this.octaRadioButton.Size = new System.Drawing.Size(88, 19);
            this.octaRadioButton.TabIndex = 2;
            this.octaRadioButton.TabStop = true;
            this.octaRadioButton.Text = "Octahedron";
            this.octaRadioButton.UseVisualStyleBackColor = true;
            this.octaRadioButton.CheckedChanged += new System.EventHandler(this.octaRadioButton_CheckedChanged);
            // 
            // hexaRadioButton
            // 
            this.hexaRadioButton.AutoSize = true;
            this.hexaRadioButton.Location = new System.Drawing.Point(27, 45);
            this.hexaRadioButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.hexaRadioButton.Name = "hexaRadioButton";
            this.hexaRadioButton.Size = new System.Drawing.Size(90, 19);
            this.hexaRadioButton.TabIndex = 1;
            this.hexaRadioButton.TabStop = true;
            this.hexaRadioButton.Text = "Hexahedron";
            this.hexaRadioButton.UseVisualStyleBackColor = true;
            this.hexaRadioButton.CheckedChanged += new System.EventHandler(this.hexaRadioButton_CheckedChanged);
            // 
            // tetraRadioButton
            // 
            this.tetraRadioButton.AutoSize = true;
            this.tetraRadioButton.Location = new System.Drawing.Point(27, 25);
            this.tetraRadioButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tetraRadioButton.Name = "tetraRadioButton";
            this.tetraRadioButton.Size = new System.Drawing.Size(88, 19);
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
            this.projectionBox.Location = new System.Drawing.Point(172, 430);
            this.projectionBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.projectionBox.Name = "projectionBox";
            this.projectionBox.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.projectionBox.Size = new System.Drawing.Size(157, 94);
            this.projectionBox.TabIndex = 1;
            this.projectionBox.TabStop = false;
            this.projectionBox.Text = "Projection";
            // 
            // dimetricRadioButton
            // 
            this.dimetricRadioButton.AutoSize = true;
            this.dimetricRadioButton.Location = new System.Drawing.Point(3, 74);
            this.dimetricRadioButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dimetricRadioButton.Name = "dimetricRadioButton";
            this.dimetricRadioButton.Size = new System.Drawing.Size(70, 19);
            this.dimetricRadioButton.TabIndex = 3;
            this.dimetricRadioButton.TabStop = true;
            this.dimetricRadioButton.Text = "Dimetric";
            this.dimetricRadioButton.UseVisualStyleBackColor = true;
            this.dimetricRadioButton.CheckedChanged += new System.EventHandler(this.dimetricRadioButton_CheckedChanged);
            // 
            // trimetricRadioButton
            // 
            this.trimetricRadioButton.AutoSize = true;
            this.trimetricRadioButton.Location = new System.Drawing.Point(3, 57);
            this.trimetricRadioButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.trimetricRadioButton.Name = "trimetricRadioButton";
            this.trimetricRadioButton.Size = new System.Drawing.Size(71, 19);
            this.trimetricRadioButton.TabIndex = 2;
            this.trimetricRadioButton.TabStop = true;
            this.trimetricRadioButton.Text = "Trimetric";
            this.trimetricRadioButton.UseVisualStyleBackColor = true;
            this.trimetricRadioButton.CheckedChanged += new System.EventHandler(this.trimetricRadioButton_CheckedChanged);
            // 
            // isometricRadioButton
            // 
            this.isometricRadioButton.AutoSize = true;
            this.isometricRadioButton.Location = new System.Drawing.Point(3, 38);
            this.isometricRadioButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.isometricRadioButton.Name = "isometricRadioButton";
            this.isometricRadioButton.Size = new System.Drawing.Size(74, 19);
            this.isometricRadioButton.TabIndex = 1;
            this.isometricRadioButton.TabStop = true;
            this.isometricRadioButton.Text = "Isometric";
            this.isometricRadioButton.UseVisualStyleBackColor = true;
            this.isometricRadioButton.CheckedChanged += new System.EventHandler(this.isometricRadioButton_CheckedChanged);
            // 
            // perspectiveRadioButton
            // 
            this.perspectiveRadioButton.AutoSize = true;
            this.perspectiveRadioButton.Location = new System.Drawing.Point(3, 18);
            this.perspectiveRadioButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.perspectiveRadioButton.Name = "perspectiveRadioButton";
            this.perspectiveRadioButton.Size = new System.Drawing.Size(85, 19);
            this.perspectiveRadioButton.TabIndex = 0;
            this.perspectiveRadioButton.TabStop = true;
            this.perspectiveRadioButton.Text = "Perspective";
            this.perspectiveRadioButton.UseVisualStyleBackColor = true;
            this.perspectiveRadioButton.CheckedChanged += new System.EventHandler(this.perspectiveRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(339, 430);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Size = new System.Drawing.Size(644, 94);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transformations";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(351, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 23);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonScale
            // 
            this.buttonScale.Location = new System.Drawing.Point(351, 62);
            this.buttonScale.Name = "buttonScale";
            this.buttonScale.Size = new System.Drawing.Size(75, 23);
            this.buttonScale.TabIndex = 9;
            this.buttonScale.Text = "Scale";
            this.buttonScale.UseVisualStyleBackColor = true;
            this.buttonScale.Click += new System.EventHandler(this.buttonScale_Click);
            // 
            // buttonRotateZ
            // 
            this.buttonRotateZ.Location = new System.Drawing.Point(256, 62);
            this.buttonRotateZ.Name = "buttonRotateZ";
            this.buttonRotateZ.Size = new System.Drawing.Size(75, 23);
            this.buttonRotateZ.TabIndex = 7;
            this.buttonRotateZ.Text = "RotateZ";
            this.buttonRotateZ.UseVisualStyleBackColor = true;
            this.buttonRotateZ.Click += new System.EventHandler(this.buttonRotateZ_Click);
            // 
            // buttonRotateY
            // 
            this.buttonRotateY.Location = new System.Drawing.Point(256, 38);
            this.buttonRotateY.Name = "buttonRotateY";
            this.buttonRotateY.Size = new System.Drawing.Size(75, 23);
            this.buttonRotateY.TabIndex = 6;
            this.buttonRotateY.Text = "RotateY";
            this.buttonRotateY.UseVisualStyleBackColor = true;
            this.buttonRotateY.Click += new System.EventHandler(this.buttonRotateY_Click);
            // 
            // buttonRotateX
            // 
            this.buttonRotateX.Location = new System.Drawing.Point(256, 14);
            this.buttonRotateX.Name = "buttonRotateX";
            this.buttonRotateX.Size = new System.Drawing.Size(75, 23);
            this.buttonRotateX.TabIndex = 5;
            this.buttonRotateX.Text = "RotateX";
            this.buttonRotateX.UseVisualStyleBackColor = true;
            this.buttonRotateX.Click += new System.EventHandler(this.buttonRotateX_Click);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(194, 14);
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
            this.numericUpDown4.Size = new System.Drawing.Size(56, 23);
            this.numericUpDown4.TabIndex = 4;
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Location = new System.Drawing.Point(60, 60);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(75, 23);
            this.buttonTranslate.TabIndex = 3;
            this.buttonTranslate.Text = "Translate";
            this.buttonTranslate.UseVisualStyleBackColor = true;
            this.buttonTranslate.Click += new System.EventHandler(this.buttonTranslate_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(132, 32);
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
            this.numericUpDown3.Size = new System.Drawing.Size(56, 23);
            this.numericUpDown3.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(70, 32);
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
            this.numericUpDown2.Size = new System.Drawing.Size(56, 23);
            this.numericUpDown2.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(8, 31);
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
            this.numericUpDown1.Size = new System.Drawing.Size(56, 23);
            this.numericUpDown1.TabIndex = 0;
            // 
            // DimaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.projectionBox);
            this.Controls.Add(this.figureBox);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DimaForm";
            this.Text = "DimaForm";
            this.Shown += new System.EventHandler(this.DimaForm_Shown);
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
    }
}