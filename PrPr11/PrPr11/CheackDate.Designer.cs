namespace PrPr11
{
    partial class CheackDate
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
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Yandex Sans Display Regular", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            maskedTextBox1.Location = new Point(12, 100);
            maskedTextBox1.Mask = "####-##-##";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 36);
            maskedTextBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Yandex Sans Display Regular", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(536, 34);
            label1.TabIndex = 1;
            label1.Text = "Проверка занятых мест на указаную дату";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Yandex Sans Display Regular", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(376, 28);
            label2.TabIndex = 2;
            label2.Text = "Введите дату в формате гггг-мм-дд";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 0, 0, 0);
            button3.Font = new Font("Yandex Sans Display Regular", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(165, 92);
            button3.Name = "button3";
            button3.Size = new Size(123, 51);
            button3.TabIndex = 9;
            button3.Text = "Поиск";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 0, 0);
            button1.Font = new Font("Yandex Sans Display Regular", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(472, 92);
            button1.Name = "button1";
            button1.Size = new Size(123, 51);
            button1.TabIndex = 11;
            button1.Text = "Выход";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CheackDate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.original_c75546efac9018647cfe1a8343fe7a59;
            ClientSize = new Size(602, 153);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maskedTextBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Location = new Point(1000, 200);
            Name = "CheackDate";
            Text = "CheackDate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private Label label1;
        private Label label2;
        private Button button3;
        private Button button1;
    }
}