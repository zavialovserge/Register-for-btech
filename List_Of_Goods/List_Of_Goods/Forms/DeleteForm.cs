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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }
        private Form1 _f1;
        public DeleteForm(Form1 f1)// using for Interaction with main window
        {
            InitializeComponent();
            _f1 = f1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ApplicationDatabase.Delete(textBox.Text);
            _f1.Show();
            this._f1.Form1_Load(this, null);//refresh
            this.Close();
        }
    }
}
