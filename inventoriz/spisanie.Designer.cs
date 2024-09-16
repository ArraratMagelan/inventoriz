namespace inventoriz
{
    partial class spisanie
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            textBox4 = new System.Windows.Forms.TextBox();
            button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(1183, 334);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(12, 352);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(1183, 34);
            button1.TabIndex = 1;
            button1.Text = "Вывести имущество";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 405);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(285, 22);
            label1.TabIndex = 2;
            label1.Text = "Дата списания (gggg-mm-dd)";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(561, 403);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(634, 29);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(561, 438);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(634, 29);
            textBox2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 441);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(543, 22);
            label2.TabIndex = 6;
            label2.Text = "Название и серийный номер имущества через запятую:";
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(323, 469);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(203, 30);
            button2.TabIndex = 11;
            button2.Text = "Получить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(561, 473);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(634, 30);
            comboBox1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 473);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(277, 22);
            label3.TabIndex = 9;
            label3.Text = "Ответсвенный за списание:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 509);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(49, 22);
            label4.TabIndex = 12;
            label4.Text = "Акт:";
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(67, 506);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(1128, 29);
            textBox3.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 548);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(195, 22);
            label5.TabIndex = 14;
            label5.Text = "Причина списания:";
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(213, 545);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(982, 29);
            textBox4.TabIndex = 15;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(12, 583);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(1183, 34);
            button3.TabIndex = 16;
            button3.Text = "Провести списание";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // spisanie
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.HighlightText;
            ClientSize = new System.Drawing.Size(1206, 627);
            Controls.Add(button3);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            Name = "spisanie";
            Text = "spisanie";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
    }
}