namespace inventoriz
{
    partial class glav_menu
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
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(12, 165);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(591, 33);
            button1.TabIndex = 0;
            button1.Text = "Добавить организационную информацию";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(12, 204);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(591, 33);
            button2.TabIndex = 1;
            button2.Text = "Добавить пользователя";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button3.Location = new System.Drawing.Point(12, 243);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(591, 33);
            button3.TabIndex = 2;
            button3.Text = "Добавить имущество";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button4.Location = new System.Drawing.Point(12, 12);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(591, 33);
            button4.TabIndex = 3;
            button4.Text = "Провести инвенторизацию";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button5.Location = new System.Drawing.Point(12, 51);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(591, 33);
            button5.TabIndex = 4;
            button5.Text = "Переместить имущество";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button6.Location = new System.Drawing.Point(12, 90);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(591, 33);
            button6.TabIndex = 5;
            button6.Text = "Провести списание";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button7.Location = new System.Drawing.Point(12, 129);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(591, 33);
            button7.TabIndex = 6;
            button7.Text = "Просмотреть информацию";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // glav_menu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.HighlightText;
            ClientSize = new System.Drawing.Size(612, 288);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            Name = "glav_menu";
            Text = "glav_menu";
            Load += glav_menu_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}