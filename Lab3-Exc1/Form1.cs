using System;
using System.Windows.Forms;

namespace Lab3_Exc1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            userControlTimer1.TimeEnabled = !userControlTimer1.TimeEnabled;
            button1.Text = userControlTimer1.TimeEnabled ? "Остановить" : "Возобновить";
        }
    }
}
