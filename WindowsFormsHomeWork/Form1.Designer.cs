
namespace WindowsFormsHomeWork
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
            this.londonBtn = new System.Windows.Forms.Button();
            this.bakuBtn = new System.Windows.Forms.Button();
            this.clockLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // londonBtn
            // 
            this.londonBtn.AutoSize = true;
            this.londonBtn.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.londonBtn.Location = new System.Drawing.Point(691, 120);
            this.londonBtn.Name = "londonBtn";
            this.londonBtn.Size = new System.Drawing.Size(171, 46);
            this.londonBtn.TabIndex = 0;
            this.londonBtn.Text = "LONDON";
            this.londonBtn.UseVisualStyleBackColor = true;
            this.londonBtn.Click += new System.EventHandler(this.londonBtn_Click);
            // 
            // bakuBtn
            // 
            this.bakuBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bakuBtn.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bakuBtn.Location = new System.Drawing.Point(691, 47);
            this.bakuBtn.Name = "bakuBtn";
            this.bakuBtn.Size = new System.Drawing.Size(171, 46);
            this.bakuBtn.TabIndex = 0;
            this.bakuBtn.Text = "BAKU";
            this.bakuBtn.UseVisualStyleBackColor = false;
            this.bakuBtn.Click += new System.EventHandler(this.bakuBtn_Click);
            // 
            // clockLbl
            // 
            this.clockLbl.AutoSize = true;
            this.clockLbl.Font = new System.Drawing.Font("Goudy Stout", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.clockLbl.Location = new System.Drawing.Point(12, 9);
            this.clockLbl.Name = "clockLbl";
            this.clockLbl.Size = new System.Drawing.Size(225, 47);
            this.clockLbl.TabIndex = 2;
            this.clockLbl.Text = "CLOCK";
            this.clockLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::WindowsFormsHomeWork.Properties.Resources.Baku;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.clockLbl);
            this.Controls.Add(this.bakuBtn);
            this.Controls.Add(this.londonBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button londonBtn;
        private System.Windows.Forms.Button bakuBtn;
        private System.Windows.Forms.Label clockLbl;
    }
}

