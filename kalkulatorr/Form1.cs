using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulatorr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPenjumlahan_Click(object sender, EventArgs e)
        {
            int angka1 = Convert.ToInt32(txtAngka1.Text);
            int angka2 = Convert.ToInt32(txtAngka2.Text);
            int hasil = angka1 + angka2;
            lblHasil.Text = hasil.ToString();
        }

        private void btnPengurangan_Click(object sender, EventArgs e)
        {
            int angka1 = Convert.ToInt32(txtAngka1.Text);
            int angka2 = Convert.ToInt32(txtAngka2.Text);
            int hasil = angka1 - angka2;
            lblHasil.Text = hasil.ToString();
        }

        private void btnPerkalian_Click(object sender, EventArgs e)
        {
            int angka1 = Convert.ToInt32(txtAngka1.Text);
            int angka2 = Convert.ToInt32(txtAngka2.Text);
            int hasil = angka1 * angka2;
            lblHasil.Text = hasil.ToString();
        }

        private void btnPembagian_Click(object sender, EventArgs e)
        {
            int angka1 = Convert.ToInt32(txtAngka1.Text);
            int angka2 = Convert.ToInt32(txtAngka2.Text);
            if (angka2 != 0)
            {
                double hasil = (double)angka1 / angka2;
                lblHasil.Text = hasil.ToString();
            }
            else
            {
                lblHasil.Text = "Pembagian dengan nol tidak diperbolehkan.";
            }
        }

        }
    }
