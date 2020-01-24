using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "admin" && txtpassword.Text == "pass")
            {
                MessageBox.Show("Successfully Login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }

            else
            {
                switch (MessageBox.Show("Do you want to login again?", "Wrong Username/Password.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Cancel:
                        this.Close();
                        break;
                }
            }
        }
    }
}
