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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            if (string.IsNullOrWhiteSpace(p1.Text))
            {
                Form1.setPlayerNames("Green", "Computer");
            }
            else
            {
                Form1.setPlayerNames(p1.Text, "Computer");
            }

            Form f1 = new Form1();

            this.Hide();

            f1.ShowDialog();

            this.Close();

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(p1.Text))
            {
                Form1.setPlayerNames("Computer", "Pink");
            }
            else
            {
                Form1.setPlayerNames("Computer", p1.Text);
            }

            Form f1 = new Form1();

            this.Hide();

            f1.ShowDialog();

            this.Close();
        }
        
    }
    
}
