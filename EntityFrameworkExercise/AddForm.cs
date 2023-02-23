﻿using EntityFrameworkExercise.Models;
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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product data = new Product()
            {
                ProductNo = textBox1.Text.Trim(),
                ProductName = textBox2.Text.Trim(),
                ProductQuantity = Convert.ToInt32(textBox3.Text.Trim()),
                Price = Convert.ToInt32(textBox4.Text.Trim()),
                ProductClass = textBox5.Text.Trim()
            };
            try
            {
                ContactsModel context = new ContactsModel();
                context.Product.Add(data);
                context.SaveChanges();
                MessageBox.Show("新增完成");
                ClearTextBoxes();
            }
            catch (Exception ex)
            { MessageBox.Show($"發生錯誤 {ex.ToString()}"); }
        }
        private void ClearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

    }
}
