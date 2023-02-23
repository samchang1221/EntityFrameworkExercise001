using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkExercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var form = new AddForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var form = new ModifiedForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var form = new DelForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            var form = new OneViewForm();
            form.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            var form = new ViewForm();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var form = new ResetForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
