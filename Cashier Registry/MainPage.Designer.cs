namespace Cashier_Registry
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.output = new System.Windows.Forms.TextBox();
            this.numberOne = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clear = new System.Windows.Forms.Button();
            this.numberZero = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.numberNine = new System.Windows.Forms.Button();
            this.numberEight = new System.Windows.Forms.Button();
            this.numberSeven = new System.Windows.Forms.Button();
            this.numberSix = new System.Windows.Forms.Button();
            this.numberFive = new System.Windows.Forms.Button();
            this.numberFour = new System.Windows.Forms.Button();
            this.numberThree = new System.Windows.Forms.Button();
            this.numberTwo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Search = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Names = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Timer = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Print = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Cash = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Edit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.Enabled = false;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(1, -2);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(770, 289);
            this.output.TabIndex = 0;
            // 
            // numberOne
            // 
            this.numberOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOne.Location = new System.Drawing.Point(10, 20);
            this.numberOne.Name = "numberOne";
            this.numberOne.Size = new System.Drawing.Size(65, 55);
            this.numberOne.TabIndex = 1;
            this.numberOne.Text = "1";
            this.numberOne.UseVisualStyleBackColor = true;
            this.numberOne.Click += new System.EventHandler(this.numberOne_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.numberZero);
            this.groupBox1.Controls.Add(this.back);
            this.groupBox1.Controls.Add(this.numberNine);
            this.groupBox1.Controls.Add(this.numberEight);
            this.groupBox1.Controls.Add(this.numberSeven);
            this.groupBox1.Controls.Add(this.numberSix);
            this.groupBox1.Controls.Add(this.numberFive);
            this.groupBox1.Controls.Add(this.numberFour);
            this.groupBox1.Controls.Add(this.numberThree);
            this.groupBox1.Controls.Add(this.numberTwo);
            this.groupBox1.Controls.Add(this.numberOne);
            this.groupBox1.Location = new System.Drawing.Point(788, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(229, 249);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Number Pad";
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(152, 197);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(65, 50);
            this.clear.TabIndex = 8;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // numberZero
            // 
            this.numberZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberZero.Location = new System.Drawing.Point(81, 197);
            this.numberZero.Name = "numberZero";
            this.numberZero.Size = new System.Drawing.Size(65, 50);
            this.numberZero.TabIndex = 4;
            this.numberZero.Text = "0";
            this.numberZero.UseVisualStyleBackColor = true;
            this.numberZero.Click += new System.EventHandler(this.numberZero_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(10, 197);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(65, 50);
            this.back.TabIndex = 4;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // numberNine
            // 
            this.numberNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberNine.Location = new System.Drawing.Point(151, 137);
            this.numberNine.Name = "numberNine";
            this.numberNine.Size = new System.Drawing.Size(65, 50);
            this.numberNine.TabIndex = 7;
            this.numberNine.Text = "9";
            this.numberNine.UseVisualStyleBackColor = true;
            this.numberNine.Click += new System.EventHandler(this.numberNine_Click);
            // 
            // numberEight
            // 
            this.numberEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberEight.Location = new System.Drawing.Point(81, 137);
            this.numberEight.Name = "numberEight";
            this.numberEight.Size = new System.Drawing.Size(65, 50);
            this.numberEight.TabIndex = 6;
            this.numberEight.Text = "8";
            this.numberEight.UseVisualStyleBackColor = true;
            this.numberEight.Click += new System.EventHandler(this.numberEight_Click);
            // 
            // numberSeven
            // 
            this.numberSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberSeven.Location = new System.Drawing.Point(10, 137);
            this.numberSeven.Name = "numberSeven";
            this.numberSeven.Size = new System.Drawing.Size(65, 50);
            this.numberSeven.TabIndex = 3;
            this.numberSeven.Text = "7";
            this.numberSeven.UseVisualStyleBackColor = true;
            this.numberSeven.Click += new System.EventHandler(this.numberSeven_Click);
            // 
            // numberSix
            // 
            this.numberSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberSix.Location = new System.Drawing.Point(151, 81);
            this.numberSix.Name = "numberSix";
            this.numberSix.Size = new System.Drawing.Size(65, 50);
            this.numberSix.TabIndex = 5;
            this.numberSix.Text = "6";
            this.numberSix.UseVisualStyleBackColor = true;
            this.numberSix.Click += new System.EventHandler(this.numberSix_Click);
            // 
            // numberFive
            // 
            this.numberFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberFive.Location = new System.Drawing.Point(81, 81);
            this.numberFive.Name = "numberFive";
            this.numberFive.Size = new System.Drawing.Size(65, 50);
            this.numberFive.TabIndex = 3;
            this.numberFive.Text = "5";
            this.numberFive.UseVisualStyleBackColor = true;
            this.numberFive.Click += new System.EventHandler(this.numberFive_Click);
            // 
            // numberFour
            // 
            this.numberFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberFour.Location = new System.Drawing.Point(10, 81);
            this.numberFour.Name = "numberFour";
            this.numberFour.Size = new System.Drawing.Size(65, 50);
            this.numberFour.TabIndex = 3;
            this.numberFour.Text = "4";
            this.numberFour.UseVisualStyleBackColor = true;
            this.numberFour.Click += new System.EventHandler(this.numberFour_Click);
            // 
            // numberThree
            // 
            this.numberThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberThree.Location = new System.Drawing.Point(152, 20);
            this.numberThree.Name = "numberThree";
            this.numberThree.Size = new System.Drawing.Size(65, 55);
            this.numberThree.TabIndex = 4;
            this.numberThree.Text = "3";
            this.numberThree.UseVisualStyleBackColor = true;
            this.numberThree.Click += new System.EventHandler(this.numberThree_Click);
            // 
            // numberTwo
            // 
            this.numberTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTwo.Location = new System.Drawing.Point(81, 20);
            this.numberTwo.Name = "numberTwo";
            this.numberTwo.Size = new System.Drawing.Size(65, 55);
            this.numberTwo.TabIndex = 3;
            this.numberTwo.Text = "2";
            this.numberTwo.UseVisualStyleBackColor = true;
            this.numberTwo.Click += new System.EventHandler(this.numberTwo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Search);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Total);
            this.groupBox2.Controls.Add(this.Amount);
            this.groupBox2.Controls.Add(this.Price);
            this.groupBox2.Controls.Add(this.Names);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Id);
            this.groupBox2.Location = new System.Drawing.Point(788, -2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(229, 334);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Data";
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(60, 212);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(121, 50);
            this.Search.TabIndex = 10;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(165, 139);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(44, 20);
            this.Total.TabIndex = 5;
            this.Total.Text = "$0.0";
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(88, 105);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(129, 22);
            this.Amount.TabIndex = 4;
            this.Amount.Enter += new System.EventHandler(this.Amount_Click);
            // 
            // Price
            // 
            this.Price.Enabled = false;
            this.Price.Location = new System.Drawing.Point(88, 77);
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Size = new System.Drawing.Size(129, 22);
            this.Price.TabIndex = 3;
            // 
            // Names
            // 
            this.Names.Enabled = false;
            this.Names.Location = new System.Drawing.Point(88, 49);
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            this.Names.Size = new System.Drawing.Size(129, 22);
            this.Names.TabIndex = 2;
            this.Names.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(88, 21);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(129, 22);
            this.Id.TabIndex = 0;
            this.Id.Enter += new System.EventHandler(this.Id_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Timer);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(12, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(759, 281);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Functions";
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer.Location = new System.Drawing.Point(6, 251);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(0, 20);
            this.Timer.TabIndex = 6;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Print);
            this.groupBox6.Location = new System.Drawing.Point(509, 21);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox6.Size = new System.Drawing.Size(116, 95);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Checkout";
            // 
            // Print
            // 
            this.Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print.Location = new System.Drawing.Point(17, 21);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(84, 50);
            this.Print.TabIndex = 6;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Cash);
            this.groupBox5.Location = new System.Drawing.Point(509, 155);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(116, 93);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Payment";
            // 
            // Cash
            // 
            this.Cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cash.Location = new System.Drawing.Point(17, 25);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(84, 50);
            this.Cash.TabIndex = 2;
            this.Cash.Text = "Cash";
            this.Cash.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Edit);
            this.groupBox4.Controls.Add(this.Add);
            this.groupBox4.Controls.Add(this.Delete);
            this.groupBox4.Location = new System.Drawing.Point(63, 45);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(231, 178);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Alter";
            // 
            // Edit
            // 
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Location = new System.Drawing.Point(121, 21);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(104, 50);
            this.Edit.TabIndex = 2;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(15, 21);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 50);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(15, 110);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(100, 50);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 586);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.output);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier Registry";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button numberOne;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button numberTwo;
        private System.Windows.Forms.Button numberThree;
        private System.Windows.Forms.Button numberNine;
        private System.Windows.Forms.Button numberEight;
        private System.Windows.Forms.Button numberSeven;
        private System.Windows.Forms.Button numberSix;
        private System.Windows.Forms.Button numberFive;
        private System.Windows.Forms.Button numberFour;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button numberZero;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Names;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Cash;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Timer timer1;
    }
}

