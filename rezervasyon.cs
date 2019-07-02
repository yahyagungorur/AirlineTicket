using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakBileti
{
    public partial class rezervasyon : Form
    {
        AirportDataContext ctx = new AirportDataContext();
        public int pid { get; set; }
        public int fiyat { get; set; }
        public int flyingid { get; set; }
        public int kid { get; set; }
        public int vid { get; set; }
        public DateTime gidisdate { get; set; }
        public DateTime donusdate { get; set; }
        public Boolean tekyon { get; set; }
        public int rezno { get; set; }

        public rezervasyon()
        {
            InitializeComponent();
        }
        private void btnkapat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void rezervasyon_Load(object sender, EventArgs e)
        {
            adlb.Text = ctx.ExecuteQuery<string>("select pname from passenger where id={0}", pid).Single();
            soyadlb.Text = ctx.ExecuteQuery<string>("select plastname from passenger where id={0}", pid).Single();
            dogumtarihilb.Text = ctx.ExecuteQuery<DateTime>("select pdogumtarihi from passenger where id={0}", pid).Single().ToString();
            tcnolb.Text = ctx.ExecuteQuery<string>("select ptcno from passenger where id={0}", pid).Single();

            neredenlb.Text = ctx.ExecuteQuery<string>("select lname from Location where lid ={0}", kid).Single();
            nereyelb.Text = ctx.ExecuteQuery<string>("select lname from Location where lid ={0}", vid).Single();
            gidistarihilb.Text = gidisdate.ToShortDateString();
            reznotext.Text = rezno.ToString();
            if (tekyon == true)
            {
                donustarihilb.Text = "";
                label4.Text = "";
            }
            else
                donustarihilb.Text = donusdate.ToShortDateString();
        }
    }
}
