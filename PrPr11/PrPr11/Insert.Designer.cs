namespace PrPr11
{
    partial class Insert
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Yandex Sans Display Regular", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(256, 34);
            label1.TabIndex = 11;
            label1.Text = "Добавление офиса";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Yandex Sans Display Regular", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(74, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 36);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Yandex Sans Display Regular", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(74, 157);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 36);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Yandex Sans Display Regular", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(74, 226);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 36);
            textBox3.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Yandex Sans Display Regular", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(63, 56);
            label2.Name = "label2";
            label2.Size = new Size(152, 28);
            label2.TabIndex = 15;
            label2.Text = "Объём офиса";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.Font = new Font("Yandex Sans Display Regular", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(70, 126);
            label3.Name = "label3";
            label3.Size = new Size(135, 28);
            label3.TabIndex = 16;
            label3.Text = "Этаж офиса";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.Font = new Font("Yandex Sans Display Regular", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(65, 195);
            label4.Name = "label4";
            label4.Size = new Size(147, 28);
            label4.TabIndex = 17;
            label4.Text = "Цена за день";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 0, 0);
            button1.Font = new Font("Yandex Sans Display Regular", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(74, 285);
            button1.Name = "button1";
            button1.Size = new Size(125, 41);
            button1.TabIndex = 18;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Insert
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.original_c75546efac9018647cfe1a8343fe7a59;
            ClientSize = new Size(279, 334);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Location = new Point(1000, 200);
            Name = "Insert";
            Text = "Insert";
            Load += Insert_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}