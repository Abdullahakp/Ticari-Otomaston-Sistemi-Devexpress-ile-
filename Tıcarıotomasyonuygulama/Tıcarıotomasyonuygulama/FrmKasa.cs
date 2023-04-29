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
namespace Tıcarıotomasyonuygulama
{
    public partial class FrmKasa : Form
    {
        public FrmKasa()
        {
            InitializeComponent();
        }
        void listeleme()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter tr = new SqlDataAdapter("select * from TBL_GIDERLER", bgl.baglanti());
            tr.Fill(dt);
            gridControl3.DataSource = dt;
            bgl.baglanti().Close();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        void fırma()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter tr = new SqlDataAdapter("EXEC FIRMAHAREKETLER", bgl.baglanti());
            tr.Fill(dt);
            gridControl2.DataSource = dt;
            bgl.baglanti().Close();

        }
        void musterı()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter tr = new SqlDataAdapter("EXEC MUSTERIHAREKETLERI", bgl.baglanti());
            tr.Fill(dt);
            gridControl1.DataSource = dt;
            bgl.baglanti().Close();
        }
        public string ad;
            private void FrmKasa_Load(object sender, EventArgs e)
        {
            labelControl17.Text = ad;
                fırma();
                musterı();
            listeleme();

            SqlCommand komut = new SqlCommand("Select SUM(Tutar) from TBL_FATURADETAY",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                labelControl2.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("SELECT (ELEKTRIK+SU+DOGALGAZ+INTERNET+EKSTRA) FROM TBL_GIDERLER ORDER BY ID ASC", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                labelControl3.Text = dr2[0].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand komut3 = new SqlCommand("SELECT MAASLAR FROM TBL_GIDERLER ORDER BY ID ASC", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                labelControl5.Text = dr3[0].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand komut4 = new SqlCommand("SELECT COUNT(*) FROM TBL_MUSTERI", bgl.baglanti());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                labelControl7.Text = dr4[0].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand komut5 = new SqlCommand("SELECT COUNT(*) FROM TBL_FIRMALAR", bgl.baglanti());
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                labelControl9.Text = dr5[0].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand komut6 = new SqlCommand("SELECT COUNT(Distinct(IL)) FROM TBL_FIRMALAR", bgl.baglanti());
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                labelControl11.Text = dr6[0].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand komut7 = new SqlCommand("SELECT COUNT(Distinct(IL)) FROM TBL_MUSTERI", bgl.baglanti());
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                labelControl19.Text = dr7[0].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand komut8 = new SqlCommand("SELECT COUNT(*) FROM TBL_PERSONEL", bgl.baglanti());
            SqlDataReader dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                labelControl13.Text = dr8[0].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand komut9 = new SqlCommand("SELECT SUM(ADET) FROM TBL_URUNLER", bgl.baglanti());
            SqlDataReader dr9 = komut9.ExecuteReader();
            while (dr9.Read())
            {
                labelControl15.Text = dr9[0].ToString();
            }
            bgl.baglanti().Close();

          


            
        }
        int sayac;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac > 0 && sayac <= 5)
            {
                groupControl10.Text = "ELEKTRIK";
                chartControl1.Series["AYLAR"].Points.Clear();
                SqlCommand komut10 = new SqlCommand("select top 6 AY,ELEKTRIK from TBL_GIDERLER order by ıd asc", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl1.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac > 6 && sayac <= 10)
            {
                groupControl10.Text = "SU";
                chartControl1.Series["AYLAR"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("select top 6 AY,SU from TBL_GIDERLER order by ıd asc", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac > 11  && sayac <= 15)
            {
                groupControl10.Text = "DOGALGAZ";
                chartControl1.Series["AYLAR"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("select top 6 AY,DOGALGAZ from TBL_GIDERLER order by ıd asc", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac > 16 && sayac <= 20)
            {
                groupControl10.Text = "INTERNET";
                chartControl1.Series["AYLAR"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("select top 6 AY,INTERNET from TBL_GIDERLER order by ıd asc", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac > 21 && sayac <= 25)
            {
                groupControl10.Text = "EKSTRA";
                chartControl1.Series["AYLAR"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("select top 6 AY,EKSTRA from TBL_GIDERLER order by ıd asc", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }


        }
        int sayac2;
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac2++;
            if (sayac2 > 0 && sayac2 <= 5)
            {
                groupControl11.Text = "ELEKTRIK";
                chartControl2.Series["AYLAR"].Points.Clear();
                SqlCommand komut10 = new SqlCommand("select top 6 AY,ELEKTRIK from TBL_GIDERLER order by ıd desc", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl2.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac2 > 6 && sayac2 <= 10)
            {
                groupControl11.Text = "SU";
                chartControl2.Series["AYLAR"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("select top 6 AY,SU from TBL_GIDERLER order by ıd desc", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac2 > 11 && sayac2 <= 15)
            {
                groupControl11.Text = "DOGALGAZ";
                chartControl2.Series["AYLAR"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("select top 6 AY,DOGALGAZ from TBL_GIDERLER order by ıd desc", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac2 > 16 && sayac2 <= 20)
            {
                groupControl11.Text = "INTERNET";
                chartControl2.Series["AYLAR"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("select top 6 AY,INTERNET from TBL_GIDERLER order by ıd desc", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac2 > 21 && sayac2 <= 25)
            {
                groupControl11.Text = "EKSTRA";
                chartControl2.Series["AYLAR"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("select top 6 AY,EKSTRA from TBL_GIDERLER order by ıd desc", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["AYLAR"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }
        }

        private void dateTimeOffsetEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
