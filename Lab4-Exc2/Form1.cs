using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Exc2 {
    public partial class Form1 : Form {

        List<Person> people = new List<Person>();

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Person p = new Person();
            var editForm = new EditPersonForm(p);

            if (editForm.ShowDialog() != DialogResult.OK)
                return;

            people.Add(p);

            peopleListView.VirtualListSize = people.Count;
            peopleListView.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e) {
            if (peopleListView.SelectedIndices.Count == 0)
                return;
            Person p = people[peopleListView.SelectedIndices[0]];
            EditPersonForm editForm = new EditPersonForm(p);
            if (editForm.ShowDialog() == DialogResult.OK) {
                peopleListView.Invalidate();
            }
        }

        private void peopleListView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e) {
            if (e.ItemIndex >= 0 && e.ItemIndex < people.Count) {
                e.Item = new ListViewItem(people[e.ItemIndex].FirstName);
                e.Item.SubItems.Add(people[e.ItemIndex].LastName);
                e.Item.SubItems.Add(people[e.ItemIndex].Age.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            StringBuilder sb = new StringBuilder();
            foreach (Person item in people) {
                sb.Append("Сотрудник: \n" + item.ToString());
            }
            richTextBox1.Text = sb.ToString();

        }
    }
}
