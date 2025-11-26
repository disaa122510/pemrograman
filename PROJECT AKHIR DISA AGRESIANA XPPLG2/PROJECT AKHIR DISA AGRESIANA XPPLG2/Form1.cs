using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace PROJECT_AKHIR_DISA_AGRESIANA_XPPLG2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hitungttl_Click(object sender, EventArgs e)
        {
            int Total = 0;

            if (crispy.Checked)  Total += 7000;
            if (dada.Checked)  Total += 8000;
            if (sayap.Checked)  Total += 5000;
            if (pahaatasbawah.Checked) Total += 8000;
            if (dadanasi.Checked) Total += 10000;
            if (sayapnasi.Checked) Total += 7000;
            if (pahanasi.Checked) Total += 10000;
            if (paket.Checked) Total += 12000;
            if (teh.Checked) Total += 3000;

            txtharga.Text = $"{Total}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crispy.Checked = false;
            dada.Checked = false;
            sayap.Checked = false;
            pahaatasbawah.Checked = false;
            dadanasi.Checked = false;
            sayapnasi.Checked = false;
            pahanasi.Checked = false;
            paket.Checked = false;
            teh.Checked = false;
            txtharga.Text = "0";
            txtkembalian.Text = "0";
            ttlbayar.Text = "0";
            


        }

        private void kembalian_Click(object sender, EventArgs e)
        {

        }

        private void bayar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtharga.Text) && !string.IsNullOrEmpty(ttlbayar.Text))
            {
                int uwang = Convert.ToInt32(ttlbayar.Text);
                //int Total = Convert.ToInt32(lblTotal.Text);
                int kembalian = uwang - Convert.ToInt32(txtharga.Text);
                // MessageBox.Show("Kembalian Anda: Rp." + kembalian.ToString());
                txtkembalian.Text = $"{kembalian}";
                // menampilkan kembalian pada txtKembalian
            }
        }

        private void txtharga_Click(object sender, EventArgs e)
        {
            
            txtharga.Text = "Total Harga" + txtharga.ToString();
        }

        private void txtkembalian_Click(object sender, EventArgs e)
        {
            txtkembalian.Text = "Kembalian" + txtkembalian.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int bayar = Convert.ToInt32(txtharga.Text);
            int Total = Convert.ToInt32(ttlbayar.Text);
            int kembalian = bayar - Total;
            txtkembalian.Text = kembalian.ToString();

            if (Total < bayar) ;

            {
                MessageBox.Show("uang anda kurang");
            }

            if (Total > bayar);

            {
                MessageBox.Show("Terimakasih telah berkunjung, Awas kau ga beli lagi nanti!");    
            }


        }
                


        private void ttlharga_Click(object sender, EventArgs e)
        {

        }

        private void uwang_Click(object sender, EventArgs e)
        {

        }

        private void crispy_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
} 
