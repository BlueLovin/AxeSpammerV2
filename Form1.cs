using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AxeSpammer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//closes program when exit is clicked under file
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 foo = new AboutBox1();//creates instance of AboutBox1()
            foo.Show();//shows aboutbox1()
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            fString = TextBox2.Text;//cleans up a little and makes it easier to type.
            if (TextBox2.TextLength < 1)//this occurs when nothing is entered in the text box
            {
                MessageBox.Show("You must enter something to spam.");
            }
            if (fashs == 0)//occurs if there is no delay chosen
            {
                MessageBox.Show("Ahem, you did not choose a delay.");
            }
            if (fashs > 0 && albino == 1)
            {
                while (true)
                {
                    Thread.Sleep(fashs);//uses the delay to sleep the thread
                    SendKeys.Send(fString + "{ENTER}");//enters after every line
                }
            }
            if (fashs > 0 && albino == 0)//occurs when the checkbox is unselected.
            {
                while (true)
                {
                    Thread.Sleep(fashs);
                    //SendKeys.Send(fString + "{ENTER}");
                    SendKeys.Send(fString);
                }
            }
        }
        public string fString //this is what the program spams.
        {
            get;
            set;
        }
        public int fashs //defines public int that determines the delay
        {
            get;
            set;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            fashs = 50;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            fashs = 150;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            fashs = 300;
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            fashs = 500;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                albino = 1;
            }
            if (checkBox1.Checked == false)
            {
                albino = 0;
            }
        }
        public int albino //defines public int
        { 
            get; 
            set; 
        }
    }
}
