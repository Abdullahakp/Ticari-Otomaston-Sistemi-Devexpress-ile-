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
    public partial class FrmFırmalar : Form
    {
        public FrmFırmalar()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        void temizle()
        {
            textıd.Text = "";
            textad.Text = "";
            textsektor.Text = "";
            textyetkı.Text = "";
            textgorev.Text = "";
            msktc.Text = "";
            msktelefon1.Text = "";
            msktelefon2.Text = "";
            msktelefon3.Text = "";
            textmaıl.Text = "";
            mskfax.Text = "";
            cmbıl.Text = "";
            cmbılce.Text = "";
            textvergı.Text = "";
            rickadres.Text = "";
            textkod1.Text = "";
            textkod2.Text = "";
            textkod3.Text = "";
        }
        void IL()
        {
            SqlCommand komut3 = new SqlCommand("Select sehir From iller", bgl.baglanti());
            SqlDataReader dr = komut3.ExecuteReader();
            while (dr.Read())
            {
                cmbıl.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();

        }
        void liste()
        {
            DataTable per = new DataTable();
            SqlDataAdapter d = new SqlDataAdapter("select * from TBL_FIRMALAR", bgl.baglanti());
            d.Fill(per);
            gridControl1.DataSource = per;
            bgl.baglanti().Close();
        }
        private void FrmFırmalar_Load(object sender, EventArgs e)
        {
            IL();
            liste();
           // temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut12 = new SqlCommand("insert into TBL_FIRMALAR(AD,YETKILISTATU,YETKILIADSOYAD,SEKTOR,YETKILITC,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX,IL,ILCE,VERGIDAIRE,ADRES,OZELKOD1,OZELKOD2,OZELKOD3) VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)", bgl.baglanti());
            komut12.Parameters.AddWithValue("@p1", textad.Text);
            komut12.Parameters.AddWithValue("@p2", textsektor.Text);
            komut12.Parameters.AddWithValue("@p3", textyetkı.Text);
            komut12.Parameters.AddWithValue("@p4", textgorev.Text);
            komut12.Parameters.AddWithValue("@p5", msktc.Text);
            komut12.Parameters.AddWithValue("@p6", msktelefon1.Text);
            komut12.Parameters.AddWithValue("@p7", msktelefon2.Text);
            komut12.Parameters.AddWithValue("@p8", msktelefon3.Text);
            komut12.Parameters.AddWithValue("@p9", mskfax.Text);
            komut12.Parameters.AddWithValue("@p10", textmaıl.Text);
            komut12.Parameters.AddWithValue("@p11", cmbıl.Text);
            komut12.Parameters.AddWithValue("@p12", cmbılce.Text);
            komut12.Parameters.AddWithValue("@p13", textvergı.Text);
            komut12.Parameters.AddWithValue("@p14", rickadres.Text);
            komut12.Parameters.AddWithValue("@p15", textkod1.Text);
            komut12.Parameters.AddWithValue("@p16", textkod2.Text);
            komut12.Parameters.AddWithValue("@p17", textkod3.Text);
            komut12.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("KAYIT YAPILMIŞTIR", "KAYIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
        }

        private void Btnsıl_Click(object sender, EventArgs e)
        {

            SqlCommand komusil = new SqlCommand("Delete from TBL_FIRMALAR where ID=@p1", bgl.baglanti());
            komusil.Parameters.AddWithValue("@1", textıd.Text);
            komusil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Silinmiştir", "SİLME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
        }

        private void Btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("update TBL_FIRMALAR set AD=@p1,YETKILISTATU=@p2,YETKILIADSOYAD=@p3,SEKTOR=@p4,YETKILITC=@p5,TELEFON1=@p6,TELEFON2=@p7,TELEFON3=@p8,MAIL=@p9,FAX=@p10,IL=@p11,ILCE=@p12,VERGIDAIRE=@p13,ADRES=@p14,OZELKOD1=@p15,OZELKOD2=@p16,OZELKOD3=@p17 ", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", textad.Text);
            komut1.Parameters.AddWithValue("@p2", textsektor.Text);
            komut1.Parameters.AddWithValue("@p3", textyetkı.Text);
            komut1.Parameters.AddWithValue("@p4", textgorev.Text);
            komut1.Parameters.AddWithValue("@p5", msktc.Text);
            komut1.Parameters.AddWithValue("@p6", msktelefon1.Text);
            komut1.Parameters.AddWithValue("@p7", msktelefon2.Text);
            komut1.Parameters.AddWithValue("@p8", msktelefon3.Text);
            komut1.Parameters.AddWithValue("@p9", mskfax.Text);
            komut1.Parameters.AddWithValue("@p10", textmaıl.Text);
            komut1.Parameters.AddWithValue("@p11", cmbıl.Text);
            komut1.Parameters.AddWithValue("@p12", cmbılce.Text);
            komut1.Parameters.AddWithValue("@p13", textvergı.Text);
            komut1.Parameters.AddWithValue("@p14", rickadres.Text);
            komut1.Parameters.AddWithValue("@p15", textkod1.Text);
            komut1.Parameters.AddWithValue("@p16", textkod2.Text);
            komut1.Parameters.AddWithValue("@p17", textkod3.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("KAYIT Güncelleme Yapıldı", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            liste();
        }

        private void cmbıl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbılce.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ilce From ilceler where sehir=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbıl.SelectedIndex + 1);
            SqlDataReader dr3 = komut.ExecuteReader();
            while (dr3.Read())
            {
                cmbılce.Items.Add(dr3[0]);

            }
            bgl.baglanti().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textıd.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            textad.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            textsektor.Text = gridView1.GetFocusedRowCellValue("SEKTOR").ToString();
            textyetkı.Text = gridView1.GetFocusedRowCellValue("YETKILISTATU").ToString();
            textgorev.Text = gridView1.GetFocusedRowCellValue("YETKILIADSOYAD").ToString();
            msktc.Text = gridView1.GetFocusedRowCellValue("YETKILITC").ToString();
            msktelefon1.Text = gridView1.GetFocusedRowCellValue("TELEFON1").ToString();
            msktelefon2.Text = gridView1.GetFocusedRowCellValue("TELEFON2").ToString();
            msktelefon3.Text = gridView1.GetFocusedRowCellValue("TELEFON3").ToString();
            textmaıl.Text = gridView1.GetFocusedRowCellValue("MAIL").ToString();
            mskfax.Text = gridView1.GetFocusedRowCellValue("FAX").ToString();
            cmbıl.Text = gridView1.GetFocusedRowCellValue("IL").ToString();
            cmbılce.Text = gridView1.GetFocusedRowCellValue("ILCE").ToString();
            textvergı.Text = gridView1.GetFocusedRowCellValue("VERGIDAIRE").ToString();
            rickadres.Text = gridView1.GetFocusedRowCellValue("ADRES").ToString();
            textkod1.Text = gridView1.GetFocusedRowCellValue("OZELKOD1").ToString();
            textkod2.Text = gridView1.GetFocusedRowCellValue("OZELKOD2").ToString();
            textkod3.Text = gridView1.GetFocusedRowCellValue("OZELKOD3").ToString();
        }
    }
}

