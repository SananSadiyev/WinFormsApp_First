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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox4.Clear();
            textBox2.Focus();
            Application.Exit();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {


            bool result = User.Registration(textBox2.Text, textBox4.Text);

            


            

            
            if (result)
            {

                MessageBox.Show("Sign up is Successful");

                 this.Hide();
                

                Log log = new Log();
               

                log.ShowDialog();

                this.Close();


            }
            else
            {
                
                

                    MessageBox.Show("Invalid email or password");
                    
                
                
                
            }

            textBox2.Clear();
            textBox4.Clear();
            textBox2.Focus();

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
