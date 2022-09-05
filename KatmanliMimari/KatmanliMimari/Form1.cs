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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            EntityDers ent = new EntityDers();
            ent.DersAd = txtad.Text;
            BLDers.DersEkleBL(ent);

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            List<EntityDers> ders = BLDers.DersListesiBL();
            dataGridView1.DataSource = ders;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            byte deger;
            deger = byte.Parse(txtid.Text);
            BLDers.DersSilBL(byte.Parse(deger.ToString()));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            EntityDers ent = new EntityDers();
            ent.DersAd = txtad.Text;
            ent.DersID = byte.Parse(txtid.Text);
            BLDers.DersGuncelleBL(ent);
        }
    }
}
