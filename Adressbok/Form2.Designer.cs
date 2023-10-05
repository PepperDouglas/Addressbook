namespace AdressBok {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            buttonAdd = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(134, 33);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Fyll i namn";
            textBox1.Size = new Size(268, 31);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(134, 91);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Fyll i adress";
            textBox2.Size = new Size(268, 31);
            textBox2.TabIndex = 1;
            textBox2.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.ForeColor = Color.Black;
            textBox3.Location = new Point(134, 152);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Fyll i postnummer";
            textBox3.Size = new Size(268, 31);
            textBox3.TabIndex = 2;
            textBox3.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.ForeColor = Color.Black;
            textBox4.Location = new Point(134, 217);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Fyll i postadress";
            textBox4.Size = new Size(268, 31);
            textBox4.TabIndex = 3;
            textBox4.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.ForeColor = Color.Black;
            textBox5.Location = new Point(134, 278);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Fyll i telefonnummer";
            textBox5.Size = new Size(268, 31);
            textBox5.TabIndex = 4;
            textBox5.TabStop = false;
            // 
            // textBox6
            // 
            textBox6.ForeColor = Color.Black;
            textBox6.Location = new Point(134, 345);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Fyll i epostadress";
            textBox6.Size = new Size(268, 31);
            textBox6.TabIndex = 5;
            textBox6.TabStop = false;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(530, 235);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(163, 53);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Lägg till adress";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(530, 323);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(163, 53);
            buttonBack.TabIndex = 7;
            buttonBack.Text = "Gå tillbaka";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBack);
            Controls.Add(buttonAdd);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button buttonAdd;
        private Button buttonBack;
    }
}