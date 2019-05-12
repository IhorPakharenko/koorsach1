namespace WindowsFormsApp1
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
            this.ButtonDecipher = new System.Windows.Forms.Button();
            this.TextBoxToDecipher = new System.Windows.Forms.TextBox();
            this.TextBoxToEnchipher = new System.Windows.Forms.TextBox();
            this.ButtonEncipher = new System.Windows.Forms.Button();
            this.TextBoxToDecipherKey = new System.Windows.Forms.TextBox();
            this.TextBoxToEncipherKey = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonDecipher
            // 
            this.ButtonDecipher.Location = new System.Drawing.Point(12, 78);
            this.ButtonDecipher.Name = "ButtonDecipher";
            this.ButtonDecipher.Size = new System.Drawing.Size(75, 23);
            this.ButtonDecipher.TabIndex = 0;
            this.ButtonDecipher.Text = "Decipher";
            this.ButtonDecipher.UseVisualStyleBackColor = true;
            this.ButtonDecipher.Click += new System.EventHandler(this.ButtonDecipher_Click);
            // 
            // TextBoxToDecipher
            // 
            this.TextBoxToDecipher.Location = new System.Drawing.Point(12, 25);
            this.TextBoxToDecipher.Name = "TextBoxToDecipher";
            this.TextBoxToDecipher.Size = new System.Drawing.Size(348, 20);
            this.TextBoxToDecipher.TabIndex = 1;
            // 
            // TextBoxToEnchipher
            // 
            this.TextBoxToEnchipher.Location = new System.Drawing.Point(433, 25);
            this.TextBoxToEnchipher.Name = "TextBoxToEnchipher";
            this.TextBoxToEnchipher.Size = new System.Drawing.Size(355, 20);
            this.TextBoxToEnchipher.TabIndex = 2;
            // 
            // ButtonEncipher
            // 
            this.ButtonEncipher.Location = new System.Drawing.Point(712, 78);
            this.ButtonEncipher.Name = "ButtonEncipher";
            this.ButtonEncipher.Size = new System.Drawing.Size(75, 23);
            this.ButtonEncipher.TabIndex = 3;
            this.ButtonEncipher.Text = "Encipher";
            this.ButtonEncipher.UseVisualStyleBackColor = true;
            this.ButtonEncipher.Click += new System.EventHandler(this.ButtonEncipher_Click);
            // 
            // TextBoxToDecipherKey
            // 
            this.TextBoxToDecipherKey.Location = new System.Drawing.Point(12, 52);
            this.TextBoxToDecipherKey.Name = "TextBoxToDecipherKey";
            this.TextBoxToDecipherKey.Size = new System.Drawing.Size(186, 20);
            this.TextBoxToDecipherKey.TabIndex = 4;
            // 
            // TextBoxToEncipherKey
            // 
            this.TextBoxToEncipherKey.Location = new System.Drawing.Point(592, 52);
            this.TextBoxToEncipherKey.Name = "TextBoxToEncipherKey";
            this.TextBoxToEncipherKey.Size = new System.Drawing.Size(195, 20);
            this.TextBoxToEncipherKey.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(366, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Key";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(366, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(61, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Text";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TextBoxToEncipherKey);
            this.Controls.Add(this.TextBoxToDecipherKey);
            this.Controls.Add(this.ButtonEncipher);
            this.Controls.Add(this.TextBoxToEnchipher);
            this.Controls.Add(this.TextBoxToDecipher);
            this.Controls.Add(this.ButtonDecipher);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonDecipher;
        private System.Windows.Forms.TextBox TextBoxToDecipher;
        private System.Windows.Forms.TextBox TextBoxToEnchipher;
        private System.Windows.Forms.Button ButtonEncipher;
        private System.Windows.Forms.TextBox TextBoxToDecipherKey;
        private System.Windows.Forms.TextBox TextBoxToEncipherKey;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

