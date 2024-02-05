namespace Banco2
{
    partial class Form3
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
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 1;
            label2.Text = "Id: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 54);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 3;
            label3.Text = "Limite: $";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 39);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 2;
            label4.Text = "Saldo: $";
            // 
            // button1
            // 
            button1.Location = new Point(12, 205);
            button1.Name = "button1";
            button1.Size = new Size(692, 142);
            button1.TabIndex = 4;
            button1.Text = "Transferir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(657, 5);
            button2.Name = "button2";
            button2.Size = new Size(47, 23);
            button2.TabIndex = 5;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 378);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Central de dados";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}