namespace inventoriz
{
    partial class peremestit
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
            dataGridView2 = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            dataGridView1.Size = new System.Drawing.Size(393, 376);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new System.Drawing.Point(411, 12);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new System.Drawing.Size(948, 376);
            dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 437);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(459, 22);
            label1.TabIndex = 2;
            label1.Text = "Корпус и аудитория нового места через точку:";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(553, 430);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(806, 29);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 477);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(543, 22);
            label2.TabIndex = 4;
            label2.Text = "Название и серийный номер имущества через запятую:";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(553, 470);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(806, 29);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 518);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(317, 22);
            label3.TabIndex = 6;
            label3.Text = "Ответсвенный за перемещение:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(553, 515);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(806, 30);
            comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(335, 515);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(203, 30);
            button1.TabIndex = 8;
            button1.Text = "Получить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(12, 591);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(1347, 31);
            button2.TabIndex = 9;
            button2.Text = "Переместить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 557);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(332, 22);
            label4.TabIndex = 10;
            label4.Text = "Дата перемещения (gggg-mm-dd):";
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(553, 550);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(806, 29);
            textBox3.TabIndex = 11;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(12, 394);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(1347, 30);
            button3.TabIndex = 12;
            button3.Text = "Получить информацию";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // peremestit
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.HighlightText;
            ClientSize = new System.Drawing.Size(1371, 634);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            Name = "peremestit";
            Text = "peremestit";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
    }
}