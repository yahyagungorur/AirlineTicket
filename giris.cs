using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UcakBileti
{
    public partial class giris : Form
    {
        AirportDataContext ctx = new AirportDataContext();
        Ucuslar uc = new Ucuslar();

        public int kid { get; set; }
        public int vid { get; set; }
        public DateTime gidisdate { get; set; }
        public DateTime donusdate { get; set; }



        public giris()
        {
            InitializeComponent();
        }

        private void giris_Load(object sender, EventArgs e)
        {
            //cmbnereden.DataSource = ctx.locations;
            cmbnereden.DisplayMember = "lname";
            cmbnereden.ValueMember = "lid";
           
            cmbnereden.DataSource = ctx.ExecuteQuery<location>("select * from Location").ToList();
            dtgidis.Text = DateTime.Today.ToShortDateString();
            dtdonus.Text = DateTime.Today.AddDays(1).ToShortDateString();
        }
        private void btnkapat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cmbnereden_SelectedValueChanged(object sender, EventArgs e)
        {
            /*//var rota= ctx.routes.Where(i => i.kid == rid);
         // var rota = ctx.ExecuteQuery<route>("select * from route where kid={0}",rid).ToList();
          var nereye = from rot in rota
                       join air in ctx.locations
                       on rot.vid equals air.lid
                       select air;*/

            int rid = Convert.ToInt32(cmbnereden.SelectedValue); 
            cmbnereye.DisplayMember = "lname";
            cmbnereye.ValueMember = "lid";
            cmbnereye.DataSource = ctx.ExecuteQuery<location>("select * from location,route where kid={0} and vid = lid ", rid).ToList();

        }
        


        private void dtgidis_ValueChanged(object sender, EventArgs e)
        {
            var date = Convert.ToDateTime(dtgidis.Value.Date);
            if (DateTime.Compare(date, DateTime.Today) == -1) {
                MessageBox.Show("Gidiş tarihi , bugünden önce olamaz. ", "Dikkat !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtgidis.Text = DateTime.Today.ToShortDateString();
            }
            else
                dtdonus.Text = date.AddDays(1).ToShortDateString();
        }

        private void dtdonus_ValueChanged(object sender, EventArgs e)
        {
            DateTime gidistarihi = Convert.ToDateTime(dtgidis.Value.Date);
            DateTime donustarihi = Convert.ToDateTime(dtdonus.Value.Date);

            if (DateTime.Compare(donustarihi, gidistarihi) == -1)
            {
                MessageBox.Show("Dönüş tarihi , gidiş tarihinden önce olamaz. ", "Dikkat !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtdonus.Text = gidistarihi.AddDays(1).ToShortDateString();
            }
        }



        private void btnucusara_Click(object sender, EventArgs e)
        {
            DateTime gidistarihi = Convert.ToDateTime(dtgidis.Value.Date);
            DateTime donustarihi = Convert.ToDateTime(dtdonus.Value.Date);
            int kid = Convert.ToInt32(cmbnereden.SelectedValue);
            int vid = Convert.ToInt32(cmbnereye.SelectedValue);
            this.Hide();
            uc.gidisdate = gidistarihi;
            uc.donusdate = donustarihi;
            uc.kid = kid;
            uc.vid = vid;
            uc.Show();
        }

        private void tekyonbtn_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            dtdonus.Visible = false;
            pictureBox1.Visible = false;
            dtdonus.Text = Convert.ToDateTime(dtgidis.Value.Date).AddDays(1).ToShortDateString();
            uc.tekyon = true;
        }

        private void gidisdonusbtn_Click(object sender, EventArgs e)
        {
            label4.Text = "Dönüş Tarihi :";
            dtdonus.Visible = true;
            pictureBox1.Visible = true;
        }

        
    }
}
