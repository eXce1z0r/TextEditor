using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3, 3) == "rtf")
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                else 
                    File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                if (openFileDialog1.FileName.Substring(openFileDialog1.FileName.Length - 3, 3) == "rtf")
                richTextBox1.LoadFile(openFileDialog1.FileName);
                else
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
            

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void colorDialog1_Apply(object sender, EventArgs e)
        {

        }
    }
}
