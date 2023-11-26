using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier_Registry
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private Control focousedControl;
        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            focousedControl = Id;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            Timer.Text = dateTime.ToString();
        }

        void Insert(int Number)
        {
            try
            {
                if (focousedControl == Amount)
                {
                    Amount.Text += Number.ToString();
                }
                else if (focousedControl == Id)
                {
                    Id.Text += Number.ToString();
                }
                else
                {
                    MessageBox.Show("Please Select an Input");
                }
            }
            catch
            {
                MessageBox.Show("Something unexpected happened!");
            }
        }
        void Back()
        {
            try
            {
                if (focousedControl == Amount)
                {
                    string last = Amount.Text;
                    string newString  = last.Substring(0, last.Length - 1);
                    Amount.Text = newString;
                }
                else if (focousedControl == Id)
                {
                    string last = Id.Text;
                    string newString = last.Substring(0, last.Length - 1);
                    Id.Text = newString;
                }
                else
                {
                    MessageBox.Show("Please Select an Input");
                }
            }
            catch
            {
                MessageBox.Show("Something unexpected happened");
            }

        }
        private void Id_Click(object sender, EventArgs e)
        {
            focousedControl = Id;
        }

        private void Amount_Click(object sender, EventArgs e)
        {
            focousedControl = Amount;
        }
        private void back_Click(object sender, EventArgs e)
        {
            Back();
        }
        private void numberOne_Click(object sender, EventArgs e)
        {
            Insert(1);
        }

        private void numberTwo_Click(object sender, EventArgs e)
        {
            Insert(2);
        }
        private void numberThree_Click(object sender, EventArgs e)
        {
            Insert(3);
        }
        private void numberFour_Click(object sender, EventArgs e)
        {
            Insert(4);
        }

        private void numberFive_Click(object sender, EventArgs e)
        {
            Insert(5);
        }

        private void numberSix_Click(object sender, EventArgs e)
        {
            Insert(6);
        }

        private void numberSeven_Click(object sender, EventArgs e)
        {
            Insert(7);
        }

        private void numberEight_Click(object sender, EventArgs e)
        {
            Insert(8);
        }

        private void numberNine_Click(object sender, EventArgs e)
        {
            Insert(9);
        }

        private void numberZero_Click(object sender, EventArgs e)
        {
            Insert(0);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            try
            {
                if (focousedControl == Amount)
                {
                    Amount.Text = "";
                }
                else if (focousedControl == Id)
                {
                    Id.Text = "";
                }
                else
                {
                    MessageBox.Show("Please Select an Input");
                }
            }
            catch
            {
                MessageBox.Show("Something unexpected happened");
            }
        }
    }
}
