
namespace CGLab69.Lab7
{
    partial class Lab7Form
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
            this.amirButton = new System.Windows.Forms.Button();
            this.dimaButton = new System.Windows.Forms.Button();
            this.artemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // amirButton
            // 
            this.amirButton.Location = new System.Drawing.Point(793, 220);
            this.amirButton.Name = "amirButton";
            this.amirButton.Size = new System.Drawing.Size(218, 98);
            this.amirButton.TabIndex = 5;
            this.amirButton.Text = "Amir";
            this.amirButton.UseVisualStyleBackColor = true;
            this.amirButton.Click += new System.EventHandler(this.amirButton_Click);
            // 
            // dimaButton
            // 
            this.dimaButton.Location = new System.Drawing.Point(477, 220);
            this.dimaButton.Name = "dimaButton";
            this.dimaButton.Size = new System.Drawing.Size(218, 98);
            this.dimaButton.TabIndex = 4;
            this.dimaButton.Text = "Dima";
            this.dimaButton.UseVisualStyleBackColor = true;
            this.dimaButton.Click += new System.EventHandler(this.dimaButton_Click);
            // 
            // artemButton
            // 
            this.artemButton.Location = new System.Drawing.Point(166, 220);
            this.artemButton.Name = "artemButton";
            this.artemButton.Size = new System.Drawing.Size(218, 98);
            this.artemButton.TabIndex = 3;
            this.artemButton.Text = "Artem";
            this.artemButton.UseVisualStyleBackColor = true;
            this.artemButton.Click += new System.EventHandler(this.artemButton_Click);
            // 
            // Lab7Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 529);
            this.Controls.Add(this.amirButton);
            this.Controls.Add(this.dimaButton);
            this.Controls.Add(this.artemButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lab7Form";
            this.Text = "Lab7Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button amirButton;
        private System.Windows.Forms.Button dimaButton;
        private System.Windows.Forms.Button artemButton;
    }
}