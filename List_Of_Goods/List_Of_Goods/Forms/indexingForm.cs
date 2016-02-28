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
    public partial class indexingForm : Form
    {
        public indexingForm()
        {
            InitializeComponent();
        }
        private Form1 _f1;
        public indexingForm(Form1 f1)// using for Interaction with main window
        {
            InitializeComponent();
            _f1 = f1;
        }
        // user input control
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 44 && textBox.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 44) { e.Handled = true; } 
        }

        private void btnIndexation_Click(object sender, EventArgs e)
        {
            ApplicationDatabase.Indexation(Convert.ToSingle(textBox.Text));
            _f1.Show();
            this._f1.Form1_Load(this, null);//refresh
            this.Close();
        }

        
    }
}
