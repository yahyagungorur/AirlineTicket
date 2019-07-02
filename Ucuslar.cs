using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakBileti
{
    public partial class Ucuslar : Form
    {
        AirportDataContext ctx = new AirportDataContext();
        bilgiler bl = new bilgiler();
        public int kid { get; set; }
        public int vid { get; set; }
        public DateTime gidisdate { get; set; }
        public DateTime donusdate { get; set; }
        public Boolean tekyon { get; set; }
     

        public Ucuslar()
        {
            InitializeComponent();
        }

        private void Ucuslar_Load(object sender, EventArgs e)
        {
            /*
             airport air = ctx.locations.SingleOrDefault(i => i.lid == @from);
             label1.Text = air.Name;
             airport air2 = ctx.locations.SingleOrDefault(i => i.lid == @to);
             label2.Text = air2.Name;
             label3.Text = gidisdate.ToShortDateString();
             label4.Text = donusdate.ToShortDateString();
             comboBox1.DisplayMember = "id";
             comboBox1.DataSource = ctx.ExecuteQuery<route>("select * from route where kid={0} and vid={1}",kid,vid).ToList();
           

            comboBox1.DisplayMember = "fiyat";
            comboBox1.DataSource = ctx.ExecuteQuery<flightpricess>("select * from flightpricess fp,flying f where f.id = fp.ucusid and rotationid=(select id from route where kid={0} and vid={1})",kid,vid).ToList();

             SqlConnection baglanti = new SqlConnection("Server=Localhost;Database=Airports;Integrated security=true;");
            SqlCommand komut = new SqlCommand(string.Format("select lname from location where lid={0}", kid),baglanti);
            baglanti.Open();
            SqlDataReader rdr = komut.ExecuteReader();
            rdr.Read();
            string isim = rdr["lname"].ToString();
            baglanti.Close();
            kalkislabel.Text = isim;

     */
           // string tarih = ctx.ExecuteQuery<string>("Select ktarih from flying where ktarih ={0}", gidisdate.Date).Single();

            
            kalkislabel.Text = ctx.ExecuteQuery<string>("select lname from Location where lid ={0}",kid).Single();
            varislabel.Text=ctx.ExecuteQuery<string>("select lname from Location where lid ={0}", vid).Single();
            ucussaatilabel.Text = gidisdate.ToShortDateString();
            fiyatlabel.Text = ctx.ExecuteQuery<string>("select fiyat from flightpricess fp,flying f where f.id = fp.ucusid and rotationid=(select id from route where kid={0} and vid={1})", kid, vid).Single()+"TL";
            
            if(tekyon !=true)
            {
              
                kalkislabel2.Text = ctx.ExecuteQuery<string>("select lname from Location where lid ={0}", vid).Single();
                varislabel2.Text = ctx.ExecuteQuery<string>("select lname from Location where lid ={0}", kid).Single();
                ucussaatilabel2.Text = donusdate.ToShortDateString();
               fiyatlabel2.Text = ctx.ExecuteQuery<string>("select fiyat from flightpricess fp,flying f where f.id = fp.ucusid and rotationid=(select id from route where kid={0} and vid={1})", vid, kid).Single() + "TL";
            }
            else
            {
                kalkislabel2.Text = "";
                varislabel2.Text = "";
                ucussaatilabel2.Text = "";
                fiyatlabel2.Text = "";
                label6.Text = "";
                donuscb.Visible = false;
                donuscb.Checked = false;
            }


        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void İleri_Click(object sender, EventArgs e)
        {
            if (gidiscb.Checked == false && donuscb.Checked == false)
            {
                MessageBox.Show("Lütfen bir uçuş seçiniz !! ", "Dikkat !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else { 
                this.Hide();
                bl.fiyat= Convert.ToInt32(ctx.ExecuteQuery<string>("select fiyat from flightpricess fp,flying f where f.id = fp.ucusid and rotationid=(select id from route where kid={0} and vid={1})", kid, vid).Single());
                bl.flyingid= ctx.ExecuteQuery<int>("select id from flying where rotationid=(select id from route where kid={0} and vid={1})", kid, vid).Single();
                bl.kid = kid;
                bl.vid = vid;
                bl.gidisdate = gidisdate;
                bl.donusdate = donusdate;
                bl.tekyon = tekyon;
                bl.Show();
            }
        }
    }
}
