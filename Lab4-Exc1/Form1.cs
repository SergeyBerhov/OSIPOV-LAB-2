using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Exc1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Length > 0) {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e) {
            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e) {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = fontDialog1.Font;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            var openFileDialog1 = new OpenFileDialog {
                InitialDirectory = @"c:\",
                Filter = "txt files (*.txt)|*.txt|All files(*.*) | *.* ",
                FilterIndex = 2
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                try {
                    Stream myStream;
                    if ((myStream = openFileDialog1.OpenFile()) != null) {
                        using (myStream) {
                            richTextBox1.LoadFile(openFileDialog1.FileName,
                            RichTextBoxStreamType.PlainText);
                        }
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("Error: Could not read file from disk: " + ex.Message);
                }
            }
        }
    }
}
