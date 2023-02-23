using EntityFrameworkExercise.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EntityFrameworkExercise
{
    public partial class ResetForm : Form
    {
        public ResetForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //讀取csv
            var text = File.ReadAllLines(@"..\..\..\product.csv").Skip(1).ToList();
            //csv內容加入Class Product
            //del old table
            var context = new ContactsModel();
            var list_all = context.Product.ToList();
            foreach (var row in list_all.ToList())
                context.Product.Remove(row);
            //create new table
            foreach (var row in text)
            {
                string[] values = row.Split(',');
                Product data = new Product()
                {
                    ProductNo = values[0],
                    ProductName = values[1],
                    ProductQuantity = Convert.ToInt32(values[2]),
                    Price = Convert.ToInt32(values[3]),
                    ProductClass = values[4]
                };
                context.Product.Add(data);
            }
            context.SaveChanges();
            MessageBox.Show("重設完成");
        }
    }
}
