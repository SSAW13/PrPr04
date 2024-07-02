namespace PrPr11
{
    partial class Update
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
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 0, 0);
            button1.Font = new Font("Yandex Sans Display Regular", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(12, 325);
            button1.Name = "button1";
            button1.Size = new Size(189, 41);
            button1.TabIndex = 26;
            button1.Text = "Редактировать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.Font = new Font("Yandex Sans Display Regular", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(33, 244);
            label4.Name = "label4";
            label4.Size = new Size(147, 28);
            label4.TabIndex = 25;
            label4.Text = "Цена за день";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.Font = new Font("Yandex Sans Display Regular", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(38, 175);
            label3.Name = "label3";
            label3.Size = new Size(135, 28);
            label3.TabIndex = 24;
            label3.Text = "Этаж офиса";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Yandex Sans Display Regular", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(31, 105);
            label2.Name = "label2";
            label2.Size = new Size(152, 28);
            label2.TabIndex = 23;
            label2.Text = "Объём офиса";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Yandex Sans Display Regular", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(42, 205);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 36);
            textBox3.TabIndex = 22;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Yandex Sans Display Regular", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(42, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 36);
            textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Yandex Sans Display Regular", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(42, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 36);
            textBox1.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Yandex Sans Display Regular", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(206, 34);
            label1.TabIndex = 19;
            label1.Text = "Редактировать";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.Font = new Font("Yandex Sans Display Regular", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(87, 37);
            label5.Name = "label5";
            label5.Size = new Size(31, 28);
            label5.TabIndex = 28;
            label5.Text = "id";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Yandex Sans Display Regular", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox4.Location = new Point(42, 275);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 36);
            textBox4.TabIndex = 27;
            // 
            // Update
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.original_c75546efac9018647cfe1a8343fe7a59;
            ClientSize = new Size(229, 372);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Location = new Point(1000, 200);
            Name = "Update";
            Text = "Update";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label5;
        private TextBox textBox4;
    }
}