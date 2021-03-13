using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Exc4 {
    public partial class Validator : UserControl {

        public String UserName {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }

        }

        public String Field {
            set { richTextBox1.Text = value; }
        }

        public Validator() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Field = "Привет, " + UserName;
            UserName = "";
        }

        private void textBox1_Validating(object sender, CancelEventArgs e) {
            bool containsDigit = e.Cancel = UserName.Any(char.IsDigit);
            if (containsDigit)
                MessageBox.Show("Имя не должно содержать цифры");
        }
    }
}
