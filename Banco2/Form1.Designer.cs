namespace Banco
{
    partial class Form1
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
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(14, 568);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(373, 112);
            button1.TabIndex = 0;
            button1.Text = "Conectar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 54);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(116, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 36);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 141);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 6;
            label3.Text = "Id:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(10, 159);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(116, 23);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 17);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 7;
            label4.Text = "LOGIN";
            // 
            // button2
            // 
            button2.Location = new Point(68, 14);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(172, 27);
            button2.TabIndex = 8;
            button2.Text = "Não tem uma conta?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 693);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Button button2;
    }
}

