using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Cashier_Registry
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private Control focousedControl;
        private Bitmap printBitmap;
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
                ThrowError();
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
                if(Id.Text.Length > 0 && focousedControl == Amount)
                {
                    Amount.Text = "1";
                }
            }
            catch
            {
                ThrowError();
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
                ThrowError();
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            UpdateInformation();
        }
        private async void UpdateInformation()
        {
            var data = await Database.GetData(Id.Text);
            if(data != null)
            {
                Id.Text = data.Id.ToString();
                Names.Text = data.Name.ToString();
                Price.Text = data.Price.ToString();
            }
            else
            {
                MessageBox.Show("Sorry we do not have this item");
            }
        }

        private void Amount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(Id.Text == "")
                {
                    Amount.Text = "";
                    return;
                }
                else
                {
                    Total.Text = $"${Convert.ToDouble(Price.Text) * Convert.ToInt32(Amount.Text)}";
                }
            }
            catch
            {
                ThrowError();
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (Amount.Text == "" || Id.Text == "" || Amount.Text == "0" || Id.Text == "0")
                {
                    MessageBox.Show("Cannot Add Item With Undefined Amount");
                    return;
                }
                else
                {
                    Item item = new Item
                    {
                        Id = Convert.ToInt32(Id.Text),
                        Name = Names.Text,
                        Price = Convert.ToDouble(Price.Text) * Convert.ToDouble(Amount.Text),
                        Amount = Convert.ToDouble(Amount.Text)
                    };
                    Registration.Add(item);
                    EmptyInputs();
                    UpdateOutput();
                }
            }
            catch
            {
                ThrowError();
            }

        }
        void EmptyInputs()
        {
            Id.Text = string.Empty;
            Names.Text = string.Empty;
            Price.Text = string.Empty;
            Amount.Text = string.Empty;
            Total.Text = "$0.0";
        }
        void UpdateOutput()
        {
            output.Text = string.Empty;
            List<Item> list = Registration.getList();
            
            double total = 0.0;
            foreach (Item item in list)
            {
                output.Text += FormatField(item.Name, 22);
                output.Text += FormatField(item.Amount.ToString(), 22);
                output.Text += FormatField("$" + item.Price.ToString(), 22);
                total += Math.Round((item.Price * 0.07) + item.Price, 2);

                output.Text += Environment.NewLine;
            }
            payment.Text = "$" + total;
        }
        string FormatField(string value, int width)
        {
            int dotsCount = Math.Max(0, width - value.Length);
            return value.PadRight(width, '.') + new string('.', dotsCount);
        }
        void ThrowError()
        {
            MessageBox.Show("Something Unexpected Happened");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                Item item = new Item
                {
                    Id = Convert.ToInt32(Id.Text),
                    Name = Names.Text,
                    Price = Convert.ToDouble(Price.Text) * Convert.ToDouble(Amount.Text),
                    Amount = Convert.ToDouble(Amount.Text)
                };
                Registration.RemoveItem(item);
                UpdateOutput();
            }
            catch
            {
                ThrowError();
            }

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            try
            {
                Item item = new Item
                {
                    Id = Convert.ToInt32(Id.Text),
                    Name = Names.Text,
                    Price = Convert.ToDouble(Price.Text) * Convert.ToDouble(Amount.Text),
                    Amount = Convert.ToDouble(Amount.Text)
                };
                Registration.DecreaseItem(item);
                UpdateOutput();
            }
            catch
            {
                ThrowError() ;
            }
        }

        private void Print_Click(object sender, EventArgs e)
        {
            PrintFunctionality();
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            float yPos = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;

            Font printFont = new Font("Arial", 12);

            e.Graphics.DrawString("Name", printFont, Brushes.Black, leftMargin, yPos + topMargin);
            e.Graphics.DrawString("Price", printFont, Brushes.Black, leftMargin + 400, yPos + topMargin);
            e.Graphics.DrawString("Amount", printFont, Brushes.Black, leftMargin + 500, yPos + topMargin);

            yPos += printFont.GetHeight();
            yPos += printFont.GetHeight();

            List<Item> itemList = Registration.getList();
            double total = 0.0;
            foreach (Item item in itemList)
            {
                e.Graphics.DrawString(item.Name, printFont, Brushes.Black, leftMargin, yPos + topMargin);
                e.Graphics.DrawString(item.Price.ToString("C"), printFont, Brushes.Black, leftMargin + 400, yPos + topMargin);
                e.Graphics.DrawString(item.Amount.ToString(), printFont, Brushes.Black, leftMargin + 500, yPos + topMargin);
                total += Math.Round((item.Price * 0.07) + item.Price, 2);
                yPos += printFont.GetHeight();
            }
            yPos += printFont.GetHeight();
            e.Graphics.DrawString("Total: $" + total, printFont, Brushes.Black, leftMargin + 400, yPos + topMargin);
            yPos += printFont.GetHeight();
            yPos += printFont.GetHeight();
            e.Graphics.DrawString("Note: the total amount is the subtotal plus 7% tax included.", printFont, Brushes.Black, leftMargin, yPos + topMargin);
        }
        private Bitmap CaptureForm()
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
            return bitmap;
        }

        private void Cash_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want a receipt?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                PrintFunctionality();
            }
            Registration.Payment();
            UpdateOutput();
        }
        void PrintFunctionality()
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
                using (Bitmap formBitmap = CaptureForm())
                {
                    printBitmap = new Bitmap(formBitmap);
                    printDocument.Print();
                }
            }
        }
    }
}
