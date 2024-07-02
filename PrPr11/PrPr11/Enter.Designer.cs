namespace PrPr11
{
    partial class Enter
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
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Yandex Sans Display Regular", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 9);
            label1.Name = "label1";
            label1.Size = new Size(94, 35);
            label1.TabIndex = 0;
            label1.Text = "ВХОД";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Yandex Sans Display Regular", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(75, 28);
            label2.TabIndex = 1;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.Font = new Font("Yandex Sans Display Regular", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 146);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 2;
            label3.Text = "Пароль";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Yandex Sans Display Regular", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(12, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 36);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Yandex Sans Display Regular", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(12, 177);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 36);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 0, 0);
            button1.Font = new Font("Yandex Sans Display Regular", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(51, 235);
            button1.Name = "button1";
            button1.Size = new Size(105, 41);
            button1.TabIndex = 5;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Enter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = Properties.Resources.original_c75546efac9018647cfe1a8343fe7a59;
            ClientSize = new Size(213, 309);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Location = new Point(1000, 200);
            Name = "Enter";
            Text = "Enter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}