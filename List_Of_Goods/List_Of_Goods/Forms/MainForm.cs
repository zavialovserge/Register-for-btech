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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm f2 = new AddForm(this);
            this.Hide();
            f2.Show();
        }

        private void btnIndexation_Click(object sender, EventArgs e)
        {
            indexingForm f3 = new indexingForm(this);
            this.Hide();
            f3.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteForm f4 = new DeleteForm(this);
            this.Hide();
            f4.Show();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            List<Goods> goodsList;
            try
            {
                goodsList = ApplicationDatabase.getGoods();
                if (goodsList.Count > 0)
                {
                    Goods goods;
                    for (int i = 0; i < goodsList.Count; i++)
                    {
                        goods = goodsList[i];
                        listView1.Items.Add(goods.Name);
                        listView1.Items[i].SubItems.Add(goods.Amount.ToString());
                        listView1.Items[i].SubItems.Add(goods.ProcurementPrice.ToString());
                        listView1.Items[i].SubItems.Add(goods.CategoryOfGoods);
                    }
                }
                else { MessageBox.Show("There are no goods in this Database.\nPlease add some new with Add button"); }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, ex.GetType().ToString()); }
        }
    }
}
