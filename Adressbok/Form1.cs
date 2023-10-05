using Microsoft.VisualBasic.ApplicationServices;

namespace AdressBok {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void buttonAddAddress_Click(object sender, EventArgs e) {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) {
            listBox1.Items.Clear();
            string searchString = textBox1.Text;
            if (searchString == "") {
                return;
            }

            List<string> users = new List<string>();

            string path = @"C:\Users\Douglas\source\repos\DemoNETIntro\files\adresser.txt";
            string row;

            using (StreamReader reader = new StreamReader(path)) {
                while ((row = reader.ReadLine()) != null) {
                    users.Add(row);
                }
            }

            foreach (string line in users) {
                if (line.Contains(searchString)) {
                    listBox1.Items.Add(line);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (listBox1.SelectedItem == null) {
                MessageBox.Show("Var god välj en adress");
                return;
            }
            string selection = listBox1.SelectedItem.ToString();
            string[] selectionParts = selection.Split(",");
            textBoxNamnOut.Text = selectionParts[0];
            textBoxAdrOut.Text = selectionParts[1];
            textBoxPostOut.Text = selectionParts[2];
            textBoxPAOut.Text = selectionParts[3];
            textBoxNumOut.Text = selectionParts[4];
            textBoxMailOut.Text = selectionParts[5];
        }

        private void button3_Click(object sender, EventArgs e) {
            if (listBox1.SelectedItem == null) {
                MessageBox.Show("Var god välj en adress");
                return;
            }
            List<string> updatedUsers = new List<string>();
            string path = @"C:\Users\Douglas\source\repos\DemoNETIntro\files\adresser.txt";
            string row;

            using (StreamReader reader = new StreamReader(path)) {
                while ((row = reader.ReadLine()) != null) {
                    updatedUsers.Add(row);
                }
            }
            foreach (string line in updatedUsers) {
                if (line == listBox1.SelectedItem.ToString()) {
                    updatedUsers.Remove(listBox1.SelectedItem.ToString());
                    break;
                }
            }
            using (StreamWriter writer = new StreamWriter(path)) {
                foreach (string line in updatedUsers) {
                    writer.WriteLine(line);
                }
            }
            button1_Click(this, null);
        }

        //Uppdatera 
        private void button4_Click(object sender, EventArgs e) {
            if (listBox1.SelectedItem == null) {
                MessageBox.Show("Var god välj en adress");
                return;
            }

            List<string> groupBox1 = InitGroupBoxMembers();
            foreach (string text in groupBox1) {
                if (text == null || text == "") {
                    MessageBox.Show("Fyll i alla fält!");
                    return;
                }
            }

            string selection = listBox1.SelectedItem.ToString();

            string updatedInfo = "";
            updatedInfo += textBoxNamnOut.Text + ",";
            updatedInfo += textBoxAdrOut.Text + ",";
            updatedInfo += textBoxPostOut.Text + ",";
            updatedInfo += textBoxPAOut.Text + ",";
            updatedInfo += textBoxNumOut.Text + ",";
            updatedInfo += textBoxMailOut.Text;

            List<string> updatedUsers = new List<string>();
            string path = @"C:\Users\Douglas\source\repos\DemoNETIntro\files\adresser.txt";
            string row;

            using (StreamReader reader = new StreamReader(path)) {
                while ((row = reader.ReadLine()) != null) {
                    updatedUsers.Add(row);
                }
            }

            int position = updatedUsers.IndexOf(selection);
            updatedUsers[position] = updatedInfo;

            using (StreamWriter writer = new StreamWriter(path)) {
                foreach (string line in updatedUsers) {
                    writer.WriteLine(line);
                }
            }
            button1_Click(this, null);
        }
        private List<string> InitGroupBoxMembers() {
            List<string> groupBox1 = new List<string>();
            groupBox1.Add(textBoxNamnOut.Text);
            groupBox1.Add(textBoxAdrOut.Text);
            groupBox1.Add(textBoxPAOut.Text);
            groupBox1.Add(textBoxMailOut.Text);
            groupBox1.Add(textBoxNumOut.Text);
            groupBox1.Add(textBoxPostOut.Text);
            return groupBox1;
        }
    }
}