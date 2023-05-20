using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Çekiliş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button_Save.Enabled = false;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            Database.Add(textBox_Name.Text, textBox_Surname.Text, textBox_TicketNo.Text);
            button_Save.Enabled = false;
            button_Check.BackgroundImage = Properties.Resources.close;
        }
        private void button_Random_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            textBox_TicketNo.Text = random.Next(100000, 1000000).ToString();
        }

        private void button_List_Click(object sender, EventArgs e)
        {
            Database.GridFill();
        }

        private void textBox_TicketNo_TextChanged(object sender, EventArgs e)
        {
            if(textBox_TicketNo.Text.Length == 6)
            {
                if(Database.Check(textBox_TicketNo.Text))
                {
                    button_Check.BackgroundImage = Properties.Resources.check;
                    button_Save.Enabled = true;
                }
                else
                {
                    button_Check.BackgroundImage= Properties.Resources.close;
                    button_Save.Enabled = false;
                }
            }
        }

        private void button_Result_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
