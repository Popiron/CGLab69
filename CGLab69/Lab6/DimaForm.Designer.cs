
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
            this.isometricRadioButton = new System.Windows.Forms.RadioButton();
            this.perspectiveRadioButton = new System.Windows.Forms.RadioButton();
            this.trimetricRadioButton = new System.Windows.Forms.RadioButton();
            this.dimetricRadioButton = new System.Windows.Forms.RadioButton();
            this.figureBox.SuspendLayout();
            this.projectionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // figureBox
            // 
            this.figureBox.Controls.Add(this.octaRadioButton);
            this.figureBox.Controls.Add(this.hexaRadioButton);
            this.figureBox.Controls.Add(this.tetraRadioButton);
            this.figureBox.Location = new System.Drawing.Point(10, 917);
            this.figureBox.Name = "figureBox";
            this.figureBox.Size = new System.Drawing.Size(292, 200);
            this.figureBox.TabIndex = 0;
            this.figureBox.TabStop = false;
            this.figureBox.Text = "Figure";
            // 
            // octaRadioButton
            // 
            this.octaRadioButton.AutoSize = true;
            this.octaRadioButton.Location = new System.Drawing.Point(50, 137);
            this.octaRadioButton.Name = "octaRadioButton";
            this.octaRadioButton.Size = new System.Drawing.Size(171, 36);
            this.octaRadioButton.TabIndex = 2;
            this.octaRadioButton.TabStop = true;
            this.octaRadioButton.Text = "Octahedron";
            this.octaRadioButton.UseVisualStyleBackColor = true;
            this.octaRadioButton.CheckedChanged += new System.EventHandler(this.octaRadioButton_CheckedChanged);
            // 
            // hexaRadioButton
            // 
            this.hexaRadioButton.AutoSize = true;
            this.hexaRadioButton.Location = new System.Drawing.Point(50, 95);
            this.hexaRadioButton.Name = "hexaRadioButton";
            this.hexaRadioButton.Size = new System.Drawing.Size(175, 36);
            this.hexaRadioButton.TabIndex = 1;
            this.hexaRadioButton.TabStop = true;
            this.hexaRadioButton.Text = "Hexahedron";
            this.hexaRadioButton.UseVisualStyleBackColor = true;
            this.hexaRadioButton.CheckedChanged += new System.EventHandler(this.hexaRadioButton_CheckedChanged);
            // 
            // tetraRadioButton
            // 
            this.tetraRadioButton.AutoSize = true;
            this.tetraRadioButton.Location = new System.Drawing.Point(50, 53);
            this.tetraRadioButton.Name = "tetraRadioButton";
            this.tetraRadioButton.Size = new System.Drawing.Size(174, 36);
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
            this.projectionBox.Location = new System.Drawing.Point(319, 917);
            this.projectionBox.Name = "projectionBox";
            this.projectionBox.Size = new System.Drawing.Size(292, 200);
            this.projectionBox.TabIndex = 1;
            this.projectionBox.TabStop = false;
            this.projectionBox.Text = "Projection";
            // 
            // isometricRadioButton
            // 
            this.isometricRadioButton.AutoSize = true;
            this.isometricRadioButton.Location = new System.Drawing.Point(6, 80);
            this.isometricRadioButton.Name = "isometricRadioButton";
            this.isometricRadioButton.Size = new System.Drawing.Size(142, 36);
            this.isometricRadioButton.TabIndex = 1;
            this.isometricRadioButton.TabStop = true;
            this.isometricRadioButton.Text = "Isometric";
            this.isometricRadioButton.UseVisualStyleBackColor = true;
            this.isometricRadioButton.CheckedChanged += new System.EventHandler(this.isometricRadioButton_CheckedChanged);
            // 
            // perspectiveRadioButton
            // 
            this.perspectiveRadioButton.AutoSize = true;
            this.perspectiveRadioButton.Location = new System.Drawing.Point(6, 38);
            this.perspectiveRadioButton.Name = "perspectiveRadioButton";
            this.perspectiveRadioButton.Size = new System.Drawing.Size(165, 36);
            this.perspectiveRadioButton.TabIndex = 0;
            this.perspectiveRadioButton.TabStop = true;
            this.perspectiveRadioButton.Text = "Perspective";
            this.perspectiveRadioButton.UseVisualStyleBackColor = true;
            this.perspectiveRadioButton.CheckedChanged += new System.EventHandler(this.perspectiveRadioButton_CheckedChanged);
            // 
            // trimetricRadioButton
            // 
            this.trimetricRadioButton.AutoSize = true;
            this.trimetricRadioButton.Location = new System.Drawing.Point(6, 122);
            this.trimetricRadioButton.Name = "trimetricRadioButton";
            this.trimetricRadioButton.Size = new System.Drawing.Size(137, 36);
            this.trimetricRadioButton.TabIndex = 2;
            this.trimetricRadioButton.TabStop = true;
            this.trimetricRadioButton.Text = "Trimetric";
            this.trimetricRadioButton.UseVisualStyleBackColor = true;
            this.trimetricRadioButton.CheckedChanged += new System.EventHandler(this.trimetricRadioButton_CheckedChanged);
            // 
            // dimetricRadioButton
            // 
            this.dimetricRadioButton.AutoSize = true;
            this.dimetricRadioButton.Location = new System.Drawing.Point(6, 158);
            this.dimetricRadioButton.Name = "dimetricRadioButton";
            this.dimetricRadioButton.Size = new System.Drawing.Size(135, 36);
            this.dimetricRadioButton.TabIndex = 3;
            this.dimetricRadioButton.TabStop = true;
            this.dimetricRadioButton.Text = "Dimetric";
            this.dimetricRadioButton.UseVisualStyleBackColor = true;
            this.dimetricRadioButton.CheckedChanged += new System.EventHandler(this.dimetricRadioButton_CheckedChanged);
            // 
            // DimaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 1129);
            this.Controls.Add(this.projectionBox);
            this.Controls.Add(this.figureBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DimaForm";
            this.Text = "DimaForm";
            this.Shown += new System.EventHandler(this.DimaForm_Shown);
            this.figureBox.ResumeLayout(false);
            this.figureBox.PerformLayout();
            this.projectionBox.ResumeLayout(false);
            this.projectionBox.PerformLayout();
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
    }
}