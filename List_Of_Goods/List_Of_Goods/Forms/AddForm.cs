using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_Of_Goods
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }
        private Form1 _f1;
        public AddForm(Form1 f1) // using for Interaction with main window
        {
            InitializeComponent();
            _f1 = f1;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string someStr = (comboBox1.SelectedIndex == 0) ? "Goods": "Service";
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            if (textBox3.Text == "")
            {
                textBox3.Text = "0";
            }
            ApplicationDatabase.AddGoods(textBox1.Text, Convert.ToSingle(textBox2.Text), Convert.ToSingle(textBox3.Text), someStr);
            _f1.Show();
            textBox1.Text = "";
            this._f1.Form1_Load(this, null);//refresh
            this.Close();
        }
        // user input control
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 44 && textBox2.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 44) { e.Handled = true; } 
        }
        
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 44 && textBox3.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 44) { e.Handled = true; } 
        }
    }
}
