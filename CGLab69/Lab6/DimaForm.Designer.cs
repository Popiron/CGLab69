
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
            this.components = new System.ComponentModel.Container();
            this.figureBox = new System.Windows.Forms.GroupBox();
            this.octaRadioButton = new System.Windows.Forms.RadioButton();
            this.hexaRadioButton = new System.Windows.Forms.RadioButton();
            this.tetraRadioButton = new System.Windows.Forms.RadioButton();
            this.projectionBox = new System.Windows.Forms.GroupBox();
            this.dimetricRadioButton = new System.Windows.Forms.RadioButton();
            this.trimetricRadioButton = new System.Windows.Forms.RadioButton();
            this.isometricRadioButton = new System.Windows.Forms.RadioButton();
            this.perspectiveRadioButton = new System.Windows.Forms.RadioButton();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonScale = new System.Windows.Forms.RadioButton();
            this.radioButtonRotation = new System.Windows.Forms.RadioButton();
            this.radioButtonOffset = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.figureBox.SuspendLayout();
            this.projectionBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // figureBox
            // 
            this.figureBox.Controls.Add(this.octaRadioButton);
            this.figureBox.Controls.Add(this.hexaRadioButton);
            this.figureBox.Controls.Add(this.tetraRadioButton);
            this.figureBox.Location = new System.Drawing.Point(6, 573);
            this.figureBox.Margin = new System.Windows.Forms.Padding(2);
            this.figureBox.Name = "figureBox";
            this.figureBox.Padding = new System.Windows.Forms.Padding(2);
            this.figureBox.Size = new System.Drawing.Size(180, 125);
            this.figureBox.TabIndex = 0;
            this.figureBox.TabStop = false;
            this.figureBox.Text = "Figure";
            // 
            // octaRadioButton
            // 
            this.octaRadioButton.AutoSize = true;
            this.octaRadioButton.Location = new System.Drawing.Point(31, 86);
            this.octaRadioButton.Margin = new System.Windows.Forms.Padding(2);
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
            this.hexaRadioButton.Location = new System.Drawing.Point(31, 59);
            this.hexaRadioButton.Margin = new System.Windows.Forms.Padding(2);
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
            this.tetraRadioButton.Margin = new System.Windows.Forms.Padding(2);
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
            this.projectionBox.Location = new System.Drawing.Point(190, 573);
            this.projectionBox.Margin = new System.Windows.Forms.Padding(2);
            this.projectionBox.Name = "projectionBox";
            this.projectionBox.Padding = new System.Windows.Forms.Padding(2);
            this.projectionBox.Size = new System.Drawing.Size(180, 125);
            this.projectionBox.TabIndex = 1;
            this.projectionBox.TabStop = false;
            this.projectionBox.Text = "Projection";
            // 
            // dimetricRadioButton
            // 
            this.dimetricRadioButton.AutoSize = true;
            this.dimetricRadioButton.Location = new System.Drawing.Point(4, 99);
            this.dimetricRadioButton.Margin = new System.Windows.Forms.Padding(2);
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
            this.trimetricRadioButton.Location = new System.Drawing.Point(4, 76);
            this.trimetricRadioButton.Margin = new System.Windows.Forms.Padding(2);
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
            this.isometricRadioButton.Location = new System.Drawing.Point(4, 50);
            this.isometricRadioButton.Margin = new System.Windows.Forms.Padding(2);
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
            this.perspectiveRadioButton.Location = new System.Drawing.Point(4, 24);
            this.perspectiveRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.perspectiveRadioButton.Name = "perspectiveRadioButton";
            this.perspectiveRadioButton.Size = new System.Drawing.Size(104, 24);
            this.perspectiveRadioButton.TabIndex = 0;
            this.perspectiveRadioButton.TabStop = true;
            this.perspectiveRadioButton.Text = "Perspective";
            this.perspectiveRadioButton.UseVisualStyleBackColor = true;
            this.perspectiveRadioButton.CheckedChanged += new System.EventHandler(this.perspectiveRadioButton_CheckedChanged);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(30, 24);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(64, 27);
            this.textBoxX.TabIndex = 2;
            // 
            // textBoxZ
            // 
            this.textBoxZ.Location = new System.Drawing.Point(30, 89);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(64, 27);
            this.textBoxZ.TabIndex = 3;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(30, 56);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(64, 27);
            this.textBoxY.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.radioButtonScale);
            this.groupBox1.Controls.Add(this.radioButtonRotation);
            this.groupBox1.Controls.Add(this.radioButtonOffset);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxX);
            this.groupBox1.Controls.Add(this.textBoxZ);
            this.groupBox1.Controls.Add(this.textBoxY);
            this.groupBox1.Location = new System.Drawing.Point(375, 573);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 125);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Changes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonScale
            // 
            this.radioButtonScale.AutoSize = true;
            this.radioButtonScale.Location = new System.Drawing.Point(110, 88);
            this.radioButtonScale.Name = "radioButtonScale";
            this.radioButtonScale.Size = new System.Drawing.Size(129, 24);
            this.radioButtonScale.TabIndex = 10;
            this.radioButtonScale.TabStop = true;
            this.radioButtonScale.Text = "Scale (1-100%)";
            this.radioButtonScale.UseVisualStyleBackColor = true;
            // 
            // radioButtonRotation
            // 
            this.radioButtonRotation.AutoSize = true;
            this.radioButtonRotation.Location = new System.Drawing.Point(110, 57);
            this.radioButtonRotation.Name = "radioButtonRotation";
            this.radioButtonRotation.Size = new System.Drawing.Size(87, 24);
            this.radioButtonRotation.TabIndex = 9;
            this.radioButtonRotation.TabStop = true;
            this.radioButtonRotation.Text = "Rotation";
            this.radioButtonRotation.UseVisualStyleBackColor = true;
            // 
            // radioButtonOffset
            // 
            this.radioButtonOffset.AutoSize = true;
            this.radioButtonOffset.Location = new System.Drawing.Point(110, 25);
            this.radioButtonOffset.Name = "radioButtonOffset";
            this.radioButtonOffset.Size = new System.Drawing.Size(70, 24);
            this.radioButtonOffset.TabIndex = 8;
            this.radioButtonOffset.TabStop = true;
            this.radioButtonOffset.Text = "Offset";
            this.radioButtonOffset.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            // 
            // DimaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 749);
            this.Controls.Add(this.projectionBox);
            this.Controls.Add(this.figureBox);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonScale;
        private System.Windows.Forms.RadioButton radioButtonRotation;
        private System.Windows.Forms.RadioButton radioButtonOffset;
        private System.Windows.Forms.Button button1;
    }
}