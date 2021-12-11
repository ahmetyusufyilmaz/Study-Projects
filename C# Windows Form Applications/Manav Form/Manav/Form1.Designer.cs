
namespace Manav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sebzeBox = new System.Windows.Forms.ListBox();
            this.selectedSebzeBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sebzeBox
            // 
            this.sebzeBox.FormattingEnabled = true;
            this.sebzeBox.ItemHeight = 25;
            this.sebzeBox.Location = new System.Drawing.Point(47, 117);
            this.sebzeBox.Name = "sebzeBox";
            this.sebzeBox.Size = new System.Drawing.Size(218, 129);
            this.sebzeBox.TabIndex = 0;
            // 
            // selectedSebzeBox
            // 
            this.selectedSebzeBox.FormattingEnabled = true;
            this.selectedSebzeBox.ItemHeight = 25;
            this.selectedSebzeBox.Location = new System.Drawing.Point(327, 117);
            this.selectedSebzeBox.Name = "selectedSebzeBox";
            this.selectedSebzeBox.Size = new System.Drawing.Size(224, 129);
            this.selectedSebzeBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(88, 252);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(112, 34);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Ekle";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click_1);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(379, 252);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(112, 34);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Çıkar";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.BackColor = System.Drawing.Color.Silver;
            this.finishButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.finishButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.finishButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.finishButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.finishButton.Location = new System.Drawing.Point(234, 276);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(122, 69);
            this.finishButton.TabIndex = 4;
            this.finishButton.Text = "Siparişi Tamamla";
            this.finishButton.UseVisualStyleBackColor = false;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(445, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Toplam Tutar: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGreen;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(153, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 54);
            this.label2.TabIndex = 6;
            this.label2.Text = "SANAL MANAV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(683, 417);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.selectedSebzeBox);
            this.Controls.Add(this.sebzeBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sanal Manav";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox sebzeBox;
        private System.Windows.Forms.ListBox selectedSebzeBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

