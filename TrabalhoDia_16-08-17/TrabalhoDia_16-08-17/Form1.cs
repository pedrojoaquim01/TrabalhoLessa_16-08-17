using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoDia_16_08_17
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int clicar1 = 0;
        int clicar2 = 0;
        int clicar3 = 0;
        int clicar4 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mina = rnd.Next(0, 2);
            
            if (mina == 0 && clicar1 == 0)
            {
                button1.Text = "Explosão";
                button1.BackColor = Color.Crimson;
            }
            else if (mina == 1 && clicar1 == 0)
            {
                button1.Text = "Salvo";
                button1.BackColor = Color.Cyan;
            }
            clicar1 = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int mina = rnd.Next(0, 2);
            
            if (mina == 0 && clicar2 == 0)
            {
                button2.Text = "Explosão";
                button2.BackColor = Color.Crimson;
            }
            else if (mina == 1 && clicar2 == 0)
            {
                button2.Text = "Salvo";
                button2.BackColor = Color.Cyan;
            }
            clicar2 = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int mina = rnd.Next(0, 2);
            
            if (mina == 0 && clicar4 == 0)
            {
                button4.Text = "Explosão";
                button4.BackColor = Color.Crimson;
            }
            else if (mina == 1 && clicar4 == 0)
            {
                button4.Text = "Salvo";
                button4.BackColor = Color.Cyan;
            }
            clicar4 = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int mina = rnd.Next(0, 2);
           
            if (mina == 0 && clicar3 == 0)
            {
                button3.Text = "Explosão";
                button3.BackColor = Color.Crimson;
            }
            else if (mina == 1 && clicar3 == 0)
            {
                button3.Text = "Salvo";
                button3.BackColor = Color.Cyan;
            }
            clicar3 = 1;
        }
    }
}
