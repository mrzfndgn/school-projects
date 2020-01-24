using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("alt Menu");
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 90;
            toolStripStatusLabel1.Text = toolStripProgressBar1.Value.ToString();
        }

        private void rEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.BackColor = Color.Red;
        }

        private void bLUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.BackColor = Color.Blue;
        }

        private void gREENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.BackColor = Color.Green;
        }

        private void progressBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frmprogress = new Form2();
            frmprogress.Show();
            this.Hide();

        }

        private void linkLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frmLinkLabel = new Form3();
            frmLinkLabel.Show();
            this.Hide();
        }

        private void monthCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frmmonthCalendar = new Form4();
            frmmonthCalendar.Show();
            this.Hide();
        }

        private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frmDTPicker = new Form5();
            frmDTPicker.Show();
            this.Hide();
        }
    }
}
