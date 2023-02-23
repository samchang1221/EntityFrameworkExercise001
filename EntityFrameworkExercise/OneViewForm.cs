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

namespace EntityFrameworkExercise
{
    public partial class OneViewForm : Form
    {
        public OneViewForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindData();
        }
        private void BindData()
        {
            var context = new ContactsModel();
            if (checkBox1.Checked)
            {
                var list = context.Product.Where(x => x.ProductNo == textBox1.Text).ToList();
                dataGridView1.DataSource = list;
            }
            else if (checkBox2.Checked)
            {
                var list = context.Product.Where(x => x.ProductName == textBox1.Text).ToList();
                dataGridView1.DataSource = list;
            }
            else if (checkBox3.Checked)
            {
                var list = context.Product.Where(x => x.ProductClass == textBox1.Text).ToList();
                dataGridView1.DataSource = list;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                label1.Text = "ProductNo";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                label1.Text = "ProductName";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                label1.Text = "ProductClass";
            }
        }
    }
}
