using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Four_In_A_Line
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Play_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(p1.Text)) && (string.IsNullOrWhiteSpace(p2.Text)))
            {
                Form1.setPlayerNames("Green", "Pink");
            }
            else if (string.IsNullOrWhiteSpace(p1.Text))
            {
                Form1.setPlayerNames("Green", p2.Text);
            }
            else if (string.IsNullOrWhiteSpace(p2.Text))
            {
                Form1.setPlayerNames(p1.Text, "Pink");
            }
            else
            {
                Form1.setPlayerNames(p1.Text, p2.Text);
            }

            Form f1 = new Form1();

            this.Hide();

            f1.ShowDialog();

            this.Close();
        }

        private void p2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
                Play.PerformClick();
        }
    }
}
