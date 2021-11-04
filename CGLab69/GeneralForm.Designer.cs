
namespace CGLab69
{
    partial class GeneralForm
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
            this.lab6Button = new System.Windows.Forms.Button();
            this.lab7Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab6Button
            // 
            this.lab6Button.Location = new System.Drawing.Point(399, 262);
            this.lab6Button.Name = "lab6Button";
            this.lab6Button.Size = new System.Drawing.Size(270, 100);
            this.lab6Button.TabIndex = 0;
            this.lab6Button.Text = "Lab 6";
            this.lab6Button.UseVisualStyleBackColor = true;
            this.lab6Button.Click += new System.EventHandler(this.lab6Button_Click);
            // 
            // lab7Button
            // 
            this.lab7Button.Location = new System.Drawing.Point(704, 262);
            this.lab7Button.Name = "lab7Button";
            this.lab7Button.Size = new System.Drawing.Size(270, 100);
            this.lab7Button.TabIndex = 1;
            this.lab7Button.Text = "Lab 7";
            this.lab7Button.UseVisualStyleBackColor = true;
            this.lab7Button.Click += new System.EventHandler(this.lab7Button_Click);
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 629);
            this.Controls.Add(this.lab7Button);
            this.Controls.Add(this.lab6Button);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GeneralForm";
            this.Text = "GeneralForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lab6Button;
        private System.Windows.Forms.Button lab7Button;
    }
}

