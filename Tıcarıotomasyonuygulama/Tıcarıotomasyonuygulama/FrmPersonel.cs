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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        void ıl()
        {
            SqlCommand komut3 = new SqlCommand("Select sehir From iller", bgl.baglanti());
            SqlDataReader dr = komut3.ExecuteReader();
            while (dr.Read())
            {
                cmbIL.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();
        }
        void liste()
        {
            DataTable per = new DataTable();
            SqlDataAdapter d = new SqlDataAdapter("select * from TBL_PERSONEL", bgl.baglanti());
            d.Fill(per);
            gridControl1.DataSource = per;
            bgl.baglanti().Close();
        }
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            ıl();
            liste();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            textAD.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            textsoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
            msktelefon.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
            msktc.Text = gridView1.GetFocusedRowCellValue("TC").ToString();
            textMAIL.Text = gridView1.GetFocusedRowCellValue("MAIL").ToString();
            cmbIL.Text = gridView1.GetFocusedRowCellValue("IL").ToString();
            cmbILCE.Text = gridView1.GetFocusedRowCellValue("ILCE").ToString();
            textgorev.Text = gridView1.GetFocusedRowCellValue("GOREV").ToString();
            richadres.Text = gridView1.GetFocusedRowCellValue("ADRES").ToString();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("insert into TBL_PERSONEL(AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE,ADRES,GOREV) Values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", textAD.Text);
            komut1.Parameters.AddWithValue("@p2", textsoyad.Text);
            komut1.Parameters.AddWithValue("@p3", msktelefon.Text);
            komut1.Parameters.AddWithValue("@p4", msktc.Text);
            komut1.Parameters.AddWithValue("@p5", textMAIL.Text);
            komut1.Parameters.AddWithValue("@p6", cmbIL.Text);
            komut1.Parameters.AddWithValue("@p7", cmbILCE.Text);
            komut1.Parameters.AddWithValue("@p8", richadres.Text);
            komut1.Parameters.AddWithValue("@p9", textgorev.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Kaydı Başarı İle Yapılmıştır", "KAYIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
        }

        private void BtnSıl_Click(object sender, EventArgs e)
        {
            SqlCommand komusil = new SqlCommand("Delete from TBL_PERSONEL where ID=@p1", bgl.baglanti());
            komusil.Parameters.AddWithValue("@p1", textID.Text);
            komusil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Kaydı Silindi", "KAYIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
        }

        private void cmbIL_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbILCE.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ilce From ilceler where sehir=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbIL.SelectedIndex + 1);
            SqlDataReader dr3 = komut.ExecuteReader();
            while (dr3.Read())
            {
                cmbILCE.Items.Add(dr3[0]);

            }
            bgl.baglanti().Close();
        }

        private void Btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_PERSONEL set AD=@p1,SOYAD=@p2,TELEFON=@p3,TC=@p4,MAIL=@p5,IL=@p6,ILCE=@p7,ADRES=@p8,GOREV=@p9 WHERE ID=@p10", bgl.baglanti());
            komut.Parameters.AddWithValue("@p10", textID.Text);
            komut.Parameters.AddWithValue("@p1", textAD.Text);
            komut.Parameters.AddWithValue("@p2", textsoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktelefon.Text);
            komut.Parameters.AddWithValue("@p4", msktc.Text);
            komut.Parameters.AddWithValue("@p5", textMAIL.Text);
            komut.Parameters.AddWithValue("@p6", cmbIL.Text);
            komut.Parameters.AddWithValue("@p7", cmbILCE.Text);
            komut.Parameters.AddWithValue("@p8", richadres.Text);
            komut.Parameters.AddWithValue("@p9", textgorev.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Kaydı Güncellendi", "KAYIT Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
        }
        void temizle()
        {
            textID.Text = "";
            textAD.Text = "";
            textsoyad.Text = "";
            msktelefon.Text = "";
            msktc.Text = "";
            textMAIL.Text = "";
            cmbIL.Text = "";
            cmbILCE.Text = "";
            textgorev.Text = "";
            richadres.Text = "";
        }

        private void Btntemızle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
