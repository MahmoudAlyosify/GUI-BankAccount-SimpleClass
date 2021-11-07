using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp___Account_in_Bank__Simple_Class_
{

    public partial class Form1 : Form
    {
        static string NameIN;
        static double balance1=10000;
        static double balance2=9481;
        static double amount;
        static string textBox;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            amount = double.Parse(textBox3.Text);
        }

        class Account
        {
            private double money_in_an_Account;
            private string name;
            public Account()
            {
                this.name = "";
                this.money_in_an_Account = 0;
            }
            public Account(string n, double m)
            {
                this.name = n;
                this.money_in_an_Account = m;
            }
            public string NAME
            {
                set
                {
                    this.name = value;
                }
                get
                {
                    return this.name;
                }
            }
            public double Money_In_an_Account
            {
                set
                {
                    this.money_in_an_Account = value;
                }
                get
                {
                    return this.money_in_an_Account;
                }
            }
           public void Deposit()
            {
                if ((amount >= 50) && (NameIN == "Mahmoud" || NameIN == "mahmoud"))
                {
                    balance1 += amount;
                    textBox = "The transaction was completed successfully and you have now " + balance1.ToString() + "$";
                }
                
                else if ((amount >= 50) && (NameIN == "Ahmed" || NameIN == "ahmed"))
                {
                    balance2 += amount;
                    textBox = "The transaction was completed successfully and you have now " + balance2.ToString() + "$";
                }
                else textBox = "The minimum deposit amount is 50 $";
            }
           public void Withdrow()
            {
                if ((amount >= 50) && (NameIN == "Mahmoud" || NameIN == "mahmoud"))
                {
                    balance1 -= amount;
                    textBox = "The transaction was completed successfully and you have now " + balance1.ToString() + "$";
                }
                
                else if ((amount >= 50) && (NameIN == "Ahmed" || NameIN == "ahmed"))
                {
                    balance2 -= amount;
                    textBox = "The transaction was completed successfully and you have now " + balance2.ToString() + "$";
                }
                else textBox = "The minimum withdrawal amount is 50 $";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            NameIN=textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(NameIN=="Mahmoud"|| NameIN == "mahmoud")
            {
                textBox2.Text = "Hello Mr/Mahmoud ^__^ Your account balance is " + balance1.ToString() + "$";
            }
            else if (NameIN == "Ahmed" || NameIN == "ahmed")
            {
                textBox2.Text = "Hello Mr/Ahmed ^__^ Your account balance is " +balance2.ToString()+"$";
            }
            else
            {
                textBox2.Text = "wrong name!!!";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Account Client1 = new Account("Mahmoud", balance1);
            Account Client2 = new Account();
            Client2.Money_In_an_Account = balance2;
            Client2.NAME = "Ahmed";
            if ((comboBox1.Text == "Deposit") && (NameIN == "Mahmoud" || NameIN == "mahmoud"))
            {
                Client1.Deposit(); textBox4.Text = textBox;
            }
            else if((comboBox1.Text == "Withdrow") && (NameIN == "Mahmoud" || NameIN == "mahmoud"))
            {
                Client1.Withdrow(); textBox4.Text = textBox;
            }
            if ((comboBox1.Text == "Deposit") && (NameIN == "Ahmed" || NameIN == "ahmed"))
            {
                Client2.Deposit(); textBox4.Text = textBox;
            }
            else if ((comboBox1.Text == "Withdrow") && (NameIN == "Ahmed" || NameIN == "ahmed"))
            {
                Client2.Withdrow(); textBox4.Text = textBox;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (NameIN == "Mahmoud" || NameIN == "mahmoud")
                textBox4.Text= "The transaction is Canceled you have"+ balance1.ToString() + "$";
            else if (NameIN == "Ahmed" || NameIN == "ahmed")
                textBox4.Text = "The transaction is Canceled you have" + balance2.ToString() + "$";
        }
    }
}
