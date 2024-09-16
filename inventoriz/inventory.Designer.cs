namespace inventoriz
{
    partial class inventory
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
            button1 = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label3 = new System.Windows.Forms.Label();
            button4 = new System.Windows.Forms.Button();
            comboBox2 = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            button5 = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(342, 22);
            label1.TabIndex = 0;
            label1.Text = "Дата инветоризации (gggg-mm-dd)";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(12, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(394, 29);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(166, 78);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(152, 31);
            button1.TabIndex = 2;
            button1.Text = "Получить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 87);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(148, 22);
            label2.TabIndex = 3;
            label2.Text = "Пользователь";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(12, 112);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(394, 30);
            comboBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(12, 157);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(394, 32);
            button2.TabIndex = 5;
            button2.Text = "Провести инвенторизацию";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(12, 571);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(836, 36);
            button3.TabIndex = 6;
            button3.Text = "Посмотреть результат";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(12, 258);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(836, 307);
            dataGridView1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(453, 9);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(361, 22);
            label3.TabIndex = 8;
            label3.Text = "Добавить комментарий к имуществу";
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(453, 43);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(395, 29);
            button4.TabIndex = 9;
            button4.Text = "Получить:";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(453, 79);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(395, 30);
            comboBox2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(453, 188);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(138, 22);
            label4.TabIndex = 11;
            label4.Text = "Комментарий";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(597, 185);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(251, 29);
            textBox2.TabIndex = 12;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(453, 220);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(395, 32);
            button5.TabIndex = 13;
            button5.Text = "Добавить";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(453, 120);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(234, 22);
            label5.TabIndex = 14;
            label5.Text = "Номер инвенторизации";
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(453, 150);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(395, 29);
            textBox3.TabIndex = 15;
            // 
            // inventory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.HighlightText;
            ClientSize = new System.Drawing.Size(860, 612);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(button5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            Name = "inventory";
            Text = "inventory";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
    }
}