namespace inventoriz
{
    partial class users
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
            label1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(55, 22);
            label1.TabIndex = 0;
            label1.Text = "ФИО";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(12, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(317, 29);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(12, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(317, 29);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 71);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(116, 22);
            label2.TabIndex = 2;
            label2.Text = "Должность";
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(12, 157);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(317, 29);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 132);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(193, 22);
            label3.TabIndex = 4;
            label3.Text = "Электронная почта";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 202);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(59, 22);
            label4.TabIndex = 6;
            label4.Text = "Роль";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(12, 227);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(317, 30);
            comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(83, 192);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(122, 29);
            button1.TabIndex = 8;
            button1.Text = "Получить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(12, 263);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(317, 36);
            button2.TabIndex = 9;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // users
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.HighlightText;
            ClientSize = new System.Drawing.Size(345, 315);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            Name = "users";
            Text = "Прользователь";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}