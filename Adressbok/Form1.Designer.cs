namespace AdressBok {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            buttonAddAddress = new Button();
            textBoxNamnOut = new TextBox();
            textBoxNumOut = new TextBox();
            textBoxAdrOut = new TextBox();
            textBoxMailOut = new TextBox();
            textBoxPostOut = new TextBox();
            textBoxPAOut = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 30);
            label1.Name = "label1";
            label1.Size = new Size(234, 25);
            label1.TabIndex = 0;
            label1.Text = "Sök efter namn eller postort";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(305, 31);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(362, 61);
            button1.Name = "button1";
            button1.Size = new Size(130, 43);
            button1.TabIndex = 2;
            button1.Text = "Sök";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(34, 141);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(305, 304);
            listBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(362, 165);
            button2.Name = "button2";
            button2.Size = new Size(130, 43);
            button2.TabIndex = 4;
            button2.Text = "Visa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(362, 309);
            button3.Name = "button3";
            button3.Size = new Size(130, 43);
            button3.TabIndex = 5;
            button3.Text = "Ta bort";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(362, 236);
            button4.Name = "button4";
            button4.Size = new Size(130, 43);
            button4.TabIndex = 7;
            button4.Text = "Uppdatera";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // buttonAddAddress
            // 
            buttonAddAddress.Location = new Point(524, 61);
            buttonAddAddress.Name = "buttonAddAddress";
            buttonAddAddress.Size = new Size(167, 43);
            buttonAddAddress.TabIndex = 8;
            buttonAddAddress.Text = "Lägg till adress";
            buttonAddAddress.UseVisualStyleBackColor = true;
            buttonAddAddress.Click += buttonAddAddress_Click;
            // 
            // textBoxNamnOut
            // 
            textBoxNamnOut.Location = new Point(524, 177);
            textBoxNamnOut.Name = "textBoxNamnOut";
            textBoxNamnOut.Size = new Size(167, 31);
            textBoxNamnOut.TabIndex = 10;
            // 
            // textBoxNumOut
            // 
            textBoxNumOut.Location = new Point(719, 177);
            textBoxNumOut.Name = "textBoxNumOut";
            textBoxNumOut.Size = new Size(167, 31);
            textBoxNumOut.TabIndex = 11;
            // 
            // textBoxAdrOut
            // 
            textBoxAdrOut.Location = new Point(524, 281);
            textBoxAdrOut.Name = "textBoxAdrOut";
            textBoxAdrOut.Size = new Size(167, 31);
            textBoxAdrOut.TabIndex = 12;
            // 
            // textBoxMailOut
            // 
            textBoxMailOut.Location = new Point(719, 281);
            textBoxMailOut.Name = "textBoxMailOut";
            textBoxMailOut.Size = new Size(167, 31);
            textBoxMailOut.TabIndex = 13;
            // 
            // textBoxPostOut
            // 
            textBoxPostOut.Location = new Point(524, 389);
            textBoxPostOut.Name = "textBoxPostOut";
            textBoxPostOut.Size = new Size(167, 31);
            textBoxPostOut.TabIndex = 14;
            // 
            // textBoxPAOut
            // 
            textBoxPAOut.Location = new Point(719, 389);
            textBoxPAOut.Name = "textBoxPAOut";
            textBoxPAOut.Size = new Size(167, 31);
            textBoxPAOut.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(524, 149);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 16;
            label2.Text = "Namn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(719, 149);
            label3.Name = "label3";
            label3.Size = new Size(135, 25);
            label3.TabIndex = 17;
            label3.Text = "Telefonnummer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(524, 253);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 18;
            label4.Text = "Gatuadress";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(719, 253);
            label5.Name = "label5";
            label5.Size = new Size(115, 25);
            label5.TabIndex = 19;
            label5.Text = "E-postadress";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(524, 361);
            label6.Name = "label6";
            label6.Size = new Size(113, 25);
            label6.TabIndex = 20;
            label6.Text = "Postnummer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(719, 361);
            label7.Name = "label7";
            label7.Size = new Size(97, 25);
            label7.TabIndex = 21;
            label7.Text = "Postadress";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 553);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxPAOut);
            Controls.Add(textBoxPostOut);
            Controls.Add(textBoxMailOut);
            Controls.Add(textBoxAdrOut);
            Controls.Add(textBoxNumOut);
            Controls.Add(textBoxNamnOut);
            Controls.Add(buttonAddAddress);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Adressbok";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button buttonAddAddress;
        private TextBox textBoxNamnOut;
        private TextBox textBoxNumOut;
        private TextBox textBoxAdrOut;
        private TextBox textBoxMailOut;
        private TextBox textBoxPostOut;
        private TextBox textBoxPAOut;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}