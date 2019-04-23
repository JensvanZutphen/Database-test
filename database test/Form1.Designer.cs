namespace database_test
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonplus = new System.Windows.Forms.Button();
            this.buttonmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Tomaten";
            // 
            // buttonplus
            // 
            this.buttonplus.Location = new System.Drawing.Point(67, 165);
            this.buttonplus.Name = "buttonplus";
            this.buttonplus.Size = new System.Drawing.Size(75, 23);
            this.buttonplus.TabIndex = 1;
            this.buttonplus.Text = "+";
            this.buttonplus.UseVisualStyleBackColor = true;
            this.buttonplus.Click += new System.EventHandler(this.buttonplus_Click);
            // 
            // buttonmin
            // 
            this.buttonmin.Location = new System.Drawing.Point(67, 220);
            this.buttonmin.Name = "buttonmin";
            this.buttonmin.Size = new System.Drawing.Size(75, 23);
            this.buttonmin.TabIndex = 2;
            this.buttonmin.Text = "-";
            this.buttonmin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonmin);
            this.Controls.Add(this.buttonplus);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonplus;
        private System.Windows.Forms.Button buttonmin;
    }
}

