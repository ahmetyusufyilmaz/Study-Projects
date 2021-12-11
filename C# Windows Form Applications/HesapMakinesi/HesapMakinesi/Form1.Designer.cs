
namespace HesapMakinesi
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.toplaButton = new System.Windows.Forms.Button();
            this.cikarButton = new System.Windows.Forms.Button();
            this.carpButton = new System.Windows.Forms.Button();
            this.bolmeButton = new System.Windows.Forms.Button();
            this.sonucLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(225, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 31);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // toplaButton
            // 
            this.toplaButton.Location = new System.Drawing.Point(70, 139);
            this.toplaButton.Name = "toplaButton";
            this.toplaButton.Size = new System.Drawing.Size(112, 34);
            this.toplaButton.TabIndex = 2;
            this.toplaButton.Text = "Toplama";
            this.toplaButton.UseVisualStyleBackColor = true;
            this.toplaButton.Click += new System.EventHandler(this.toplaButton_Click);
            // 
            // cikarButton
            // 
            this.cikarButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.cikarButton.Location = new System.Drawing.Point(225, 139);
            this.cikarButton.Name = "cikarButton";
            this.cikarButton.Size = new System.Drawing.Size(112, 34);
            this.cikarButton.TabIndex = 3;
            this.cikarButton.Text = "Çıkarma";
            this.cikarButton.UseVisualStyleBackColor = true;
            this.cikarButton.Click += new System.EventHandler(this.cikarButton_Click);
            // 
            // carpButton
            // 
            this.carpButton.Location = new System.Drawing.Point(70, 194);
            this.carpButton.Name = "carpButton";
            this.carpButton.Size = new System.Drawing.Size(112, 34);
            this.carpButton.TabIndex = 4;
            this.carpButton.Text = "Çarpma";
            this.carpButton.UseVisualStyleBackColor = true;
            this.carpButton.Click += new System.EventHandler(this.carpButton_Click);
            // 
            // bolmeButton
            // 
            this.bolmeButton.Location = new System.Drawing.Point(225, 194);
            this.bolmeButton.Name = "bolmeButton";
            this.bolmeButton.Size = new System.Drawing.Size(112, 34);
            this.bolmeButton.TabIndex = 5;
            this.bolmeButton.Text = "Bölme";
            this.bolmeButton.UseVisualStyleBackColor = true;
            this.bolmeButton.Click += new System.EventHandler(this.bolmeButton_Click);
            // 
            // sonucLabel
            // 
            this.sonucLabel.AutoSize = true;
            this.sonucLabel.Location = new System.Drawing.Point(159, 267);
            this.sonucLabel.Name = "sonucLabel";
            this.sonucLabel.Size = new System.Drawing.Size(91, 25);
            this.sonucLabel.TabIndex = 6;
            this.sonucLabel.Text = "Sonuç = ?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.sonucLabel);
            this.Controls.Add(this.bolmeButton);
            this.Controls.Add(this.carpButton);
            this.Controls.Add(this.cikarButton);
            this.Controls.Add(this.toplaButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button toplaButton;
        private System.Windows.Forms.Button cikarButton;
        private System.Windows.Forms.Button carpButton;
        private System.Windows.Forms.Button bolmeButton;
        private System.Windows.Forms.Label sonucLabel;
    }
}

