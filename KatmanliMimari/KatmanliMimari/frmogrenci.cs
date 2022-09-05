using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer1;
using DataAccessLayer1;
using BusinessLayer;

namespace KatmanliMimari
{
    public partial class frmogrenci : Form
    {
        public frmogrenci()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ad = txtad.Text;
            ent.Soyad = txtsoyad.Text;
            ent.Numara = maskedTextBox1.Text;
            ent.Bolum = txtbolum.Text;
            BLOgrenci.OgrenciEkleBL(ent);


        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            List<EntityOgrenci> ogrenciler = BLOgrenci.OgrenciListesiBL();
            dataGridView1.DataSource = ogrenciler;

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ad = txtad.Text;
            ent.Soyad = txtsoyad.Text;
            ent.Bolum = txtbolum.Text;
            ent.Numara = maskedTextBox1.Text;
            ent.OgrID = int.Parse(txtid.Text);
            BLOgrenci.OgrenciGuncelleBL(ent);

        }

        private void btnsil_Click(object sender, EventArgs e)
        {

        }
    }
}
