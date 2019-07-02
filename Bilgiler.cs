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

    public partial class bilgiler : Form
    {
        AirportDataContext ctx = new AirportDataContext();
        

        public int fiyat { get; set; }
        public int flyingid { get; set; }
        public int kid { get; set; }
        public int vid { get; set; }
        public DateTime gidisdate { get; set; }
        public DateTime donusdate { get; set; }
        public Boolean tekyon { get; set; }

        rezervasyon rez = new rezervasyon();

        passenger ps = new passenger();
        rezervation rz = new rezervation();
        rezervationprice rp = new rezervationprice();
        reservationflying rf = new reservationflying();
      
        public bilgiler()
        {
            InitializeComponent();
        }

        private void onayla_Click(object sender, EventArgs e)
        {
            Random rno = new Random();
            int rezno = rno.Next(0, 100000);
            SqlConnection baglanti = new SqlConnection("Server=Localhost;Database=Airports;Integrated security=true;");
            SqlCommand komut = new SqlCommand("INSERT INTO rezervations (rezno,reztarihi,rezdurumu) VALUES (@REZNO,@REZTARIHI, @REZDURUMU)", baglanti);
            komut.Parameters.AddWithValue("@REZTARIHI",DateTime.Now);
            komut.Parameters.AddWithValue("@REZDURUMU", "Aktif");
            komut.Parameters.AddWithValue("@REZNO", rezno);
            baglanti.Open();
            komut.ExecuteNonQuery();
            int rezid = Convert.ToInt32(ctx.ExecuteQuery<int>("select id from rezervations where rezno={0}",rezno).Single());

            komut = new SqlCommand("INSERT INTO rezervationprice (rezervationid,fiyat) VALUES ("+rezid+","+fiyat+")", baglanti);
            komut.ExecuteNonQuery();

            komut = new SqlCommand("INSERT INTO reservationflying (rezid,ucusid,durum) VALUES (" + rezid + "," + flyingid + ",@DURUM)", baglanti);
            komut.Parameters.AddWithValue("@DURUM", "Aktif");
            komut.ExecuteNonQuery();

            komut = new SqlCommand("INSERT INTO passenger (pname,plastname,pdogumtarihi,ptcno,rezid) VALUES (@PNAME,@PLASTNAME,@PDOGUMTARIHI,"+tctext.Text+","+rezid+")", baglanti);
            komut.Parameters.AddWithValue("@PNAME", Adtext.Text);
            komut.Parameters.AddWithValue("@PLASTNAME", Soyadtext.Text);
            komut.Parameters.AddWithValue("@PDOGUMTARIHI", dogumtarihidt.Value.Date);
            komut.ExecuteNonQuery();
            baglanti.Close();

            this.Hide();
            rez.pid =Convert.ToInt32(ctx.ExecuteQuery<int>("select id from passenger where ptcno={0}",tctext.Text).Single());
            rez.kid = kid;
            rez.vid = vid;
            rez.fiyat = fiyat;
            rez.flyingid = flyingid;
            rez.gidisdate = gidisdate;
            rez.donusdate = donusdate;
            rez.tekyon = tekyon;
            rez.rezno = Convert.ToInt32(ctx.ExecuteQuery<int>("select rezno from rezervations where id ={0}",rezid).Single());
            rez.Show();

            /* 
             rz.rezno = rno.Next(0, 100);
             rz.reztarihi = DateTime.Today;
             rz.rezdurumu = "Aktif";
             ctx.rezervations.InsertOnSubmit(rz);
             ctx.SubmitChanges();

             rp.rezervationid = rz.id;
             rp.fiyat = fiyat;
             ctx.rezervationprices.InsertOnSubmit(rp);

             rf.rezid = rz.id;
             rf.ucusid = flyingid;
             rf.durum = "asda";
             ctx.reservationflyings.InsertOnSubmit(rf);

             ps.pname = Adtext.Text;
             ps.plastname = Soyadtext.Text;
             ps.pdogumtarihi = dogumtarihidt.Value.Date;
             ps.ptcno = tctext.Text;
             ps.rezid = rz.id;
             ctx.passengers.InsertOnSubmit(ps);
             ctx.SubmitChanges();
            */
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
