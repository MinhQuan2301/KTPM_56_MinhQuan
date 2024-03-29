using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinhQuan56;

namespace MinhQuan56
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txt1.Text);
            b = int.Parse(txt2.Text);
            MinhQuan_56 c = new MinhQuan_56(a, b);
            ketqua = c.Execute("+");
            txtKetQua.Text = ketqua.ToString();
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txt1.Text);
            b = int.Parse(txt2.Text);
            MinhQuan_56 c = new MinhQuan_56(a, b);
            ketqua = c.Execute("/");
            txtKetQua.Text = ketqua.ToString();
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txt1.Text);
            b = int.Parse(txt2.Text);
            MinhQuan_56 c = new MinhQuan_56(a, b);
            ketqua = c.Execute("-");
            txtKetQua.Text = ketqua.ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int a, b, ketqua;
            a = int.Parse(txt1.Text);
            b = int.Parse(txt2.Text);
            MinhQuan_56 c = new MinhQuan_56(a, b);
            ketqua = c.Execute("x");
            txtKetQua.Text = ketqua.ToString();
        }
    }
}
