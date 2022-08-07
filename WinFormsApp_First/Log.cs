using DBWorker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormCoreLIb;

namespace WinFormsApp_First
{
    public partial class Log : Form
    {

        public Log()
        {
            InitializeComponent();
        }
        


        



        private void Log_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


           bool result2 = User.Login(textBox3.Text, textBox1.Text) ;



            if (result2)
            {
                
                MessageBox.Show("Login is Successful");

                



            }
            else
            {



                MessageBox.Show("Invalid email or password");




            }

            textBox3.Clear();
            textBox1.Clear();
            textBox3.Focus();

        



    }
       

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
