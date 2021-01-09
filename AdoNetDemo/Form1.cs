using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    
    public partial class Form1 : Form
    {
        private readonly ProductDal _productDal = new ProductDal();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs eventArgs)
        {
            /* inside form designer change dataGridView AutoSizeColumnsMode to Fill */
            
            // no one use DataTable anymore expensive not serializable
            // DataSource works for List too
            dataGridView_Product.DataSource = _productDal.GetAll(); // put DataTable to DataSource of dataGridView
        }

        private void button_AddProduct_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                // Id automatically increase in database
                Name = textBox_Name.Text,
                UnitPrice = Convert.ToDecimal(textBox_UnitPrice.Text),
                StockAmount = Convert.ToInt32(textBox_StockAmount.Text)
            });
            dataGridView_Product.DataSource = _productDal.GetAll(); // refresh dataGridView
            MessageBox.Show("Product Added!");
        }
    }
}