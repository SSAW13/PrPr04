namespace PrPr11
{
    partial class Delete
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
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 0, 0);
            button1.Font = new Font("Yandex Sans Display Regular", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(64, 209);
            button1.Name = "button1";
            button1.Size = new Size(125, 41);
            button1.TabIndex = 22;
            button1.Text = "Удалить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Yandex Sans Display Regular", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(112, 55);
            label2.Name = "label2";
            label2.Size = new Size(31, 28);
            label2.TabIndex = 21;
            label2.Text = "id";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Yandex Sans Display Regular", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(64, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 36);
            textBox1.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Yandex Sans Display Regular", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(64, 9);
            label1.Name = "label1";
            label1.Size = new Size(135, 34);
            label1.TabIndex = 19;
            label1.Text = "Удаление";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.Font = new Font("Yandex Sans Display Regular", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 125);
            label3.Name = "label3";
            label3.Size = new Size(242, 28);
            label3.TabIndex = 24;
            label3.Text = "Напишите \"УДАЛИТЬ\"";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Yandex Sans Display Regular", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(64, 156);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 36);
            textBox2.TabIndex = 23;
            // 
            // Delete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.original_c75546efac9018647cfe1a8343fe7a59;
            ClientSize = new Size(263, 271);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Location = new Point(1000, 200);
            Name = "Delete";
            Text = "Delete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Label label3;
        private TextBox textBox2;
    }
}