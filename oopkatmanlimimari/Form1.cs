using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITYLAYER;
using FACADELAYER;
using BUSINESSLOGICLAYER;
namespace oopkatmanlimimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void OGRENCILISTESI()
        {
            List<ENTITYOGRENCI> ogrlist = BLLOGRENCII.LISTELE();
            dataGridView1.DataSource = ogrlist;
        }
        void KULUPLISTESI()
        {
            List<ENTITYKULUP> kuluplist = BLLKULUP.LISTELE();
            cmbkulup.DisplayMember = "KULUPAD";
            cmbkulup.ValueMember = "KULUPID";
            cmbkulup.DataSource = kuluplist;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OGRENCILISTESI();
            KULUPLISTESI();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ENTITYOGRENCI ent = new ENTITYOGRENCI();
            ent.AD = txtad.Text;
            ent.SOYAD = txtsoyad.Text;
            ent.FOTOGRAF = txtfotograf.Text;
            ent.KULUPID = Convert.ToInt16(txts1.Text);
            BLLOGRENCII.EKLE(ent);
            OGRENCILISTESI();

        }
    }
}
