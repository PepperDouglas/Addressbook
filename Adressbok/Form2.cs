using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdressBok {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e) {
            string path = @"C:\Users\Douglas\source\repos\DemoNETIntro\files\adresser.txt";
            string userInput = "";
            bool allFieldsFilled = true;

            foreach (var control in this.Controls.OfType<TextBox>()) {
                if (control.Text != "" && control.Text != null) {
                    userInput += control.Text + ",";
                } else {
                    MessageBox.Show("Fyll i alla fält!");
                    allFieldsFilled = false;
                    break;
                }
            }
            if (allFieldsFilled) {
            userInput = userInput.Remove(userInput.Length - 1, 1);
                using (StreamWriter writer = new StreamWriter(path, true)) {
                    writer.WriteLine(userInput);
                }
                MessageBox.Show("Adress sparad!");
                this.Close();
            }
        }
    }
}
