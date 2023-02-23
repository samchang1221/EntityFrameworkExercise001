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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EntityFrameworkExercise
{
    public partial class DelForm : Form
    {
        public DelForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var context = new ContactsModel();
            var list = context.Product.Where(x => x.ProductNo == textBox1.Text).ToList();
            try
            {
                foreach (var row in list)
                    context.Product.Remove(row);
                context.SaveChanges();
                MessageBox.Show("刪除完成");
                ClearTextBoxes();
            }
            catch (Exception ex)
            { MessageBox.Show($"發生錯誤 {ex.ToString()}"); }
        }
        private void ClearTextBoxes()
        {
            textBox1.Clear();
        }
    }
}
