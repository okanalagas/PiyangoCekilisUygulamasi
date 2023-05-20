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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button_Random_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            textBox_TicketNo.Text = random.Next(100000, 1000000).ToString();
        }

        private void button_Get_Click(object sender, EventArgs e)
        {
            Database.Get(textBox_TicketNo.Text);
            try
            {
                textBox_Name.Text = Database.user[0];
                textBox_Surname.Text = Database.user[1];
            }
            catch (Exception ex)
            {

            }
            
            Database.user = null;

        }
    }
}
