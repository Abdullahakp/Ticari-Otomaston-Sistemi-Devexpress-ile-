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
    public partial class FrmMusterı : Form
    {
        public FrmMusterı()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        void IL()
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
            SqlDataAdapter d = new SqlDataAdapter("select * from TBL_MUSTERI", bgl.baglanti());
            d.Fill(per);
            gridControl1.DataSource = per;
            bgl.baglanti().Close();
        }
        private void FrmMusterı_Load(object sender, EventArgs e)
        {
            IL();
            //ILCE();
            liste();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("ınsert ınto TBL_MUSTERI(AD,SOYAD,TELEFON1,TELEFON2,TC,MAIL,IL,ILCE,ADRES,VERGIDAIRE) Values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@10)", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", textad.Text);
            komut1.Parameters.AddWithValue("@p2", textsoyad.Text);
            komut1.Parameters.AddWithValue("@p3", msktelefon1.Text);
            komut1.Parameters.AddWithValue("@p4", msktelefon2.Text);
            komut1.Parameters.AddWithValue("@p5", msktc.Text);
            komut1.Parameters.AddWithValue("@p6", textmaıl.Text);
            komut1.Parameters.AddWithValue("@p7", cmbIL.Text);
            komut1.Parameters.AddWithValue("@p8", cmbILCE.Text);
            komut1.Parameters.AddWithValue("@p9", richadres.Text);
            komut1.Parameters.AddWithValue("@p10", textvergı.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Kayıt yapıldı");
            liste();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komusil = new SqlCommand("Delete from TBL_MUSTERI where ID=@p1", bgl.baglanti());
            komusil.Parameters.AddWithValue("@1", textıd.Text);
            komusil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Kaydı Silinmiş");
            liste();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("update  TBL_MUSTERI set AD=@p1,SOYAD=@p2,TELEFON1=@p3,TELEFON2=@p4,TC=@p5,MAIL=@p6,IL=@p7,ILCE=@p8,ADRES=@p9,VERGIDAIRE=@p10 where ID=@p11", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", textad.Text);
            komut1.Parameters.AddWithValue("@p2", textsoyad.Text);
            komut1.Parameters.AddWithValue("@p3", msktelefon1.Text);
            komut1.Parameters.AddWithValue("@p4", msktelefon2.Text);
            komut1.Parameters.AddWithValue("@p5", msktc.Text);
            komut1.Parameters.AddWithValue("@p6", textmaıl.Text);
            komut1.Parameters.AddWithValue("@p7", cmbIL.Text);
            komut1.Parameters.AddWithValue("@p8", cmbILCE.Text);
            komut1.Parameters.AddWithValue("@p9", richadres.Text);
            komut1.Parameters.AddWithValue("@p10", textvergı.Text);
            komut1.Parameters.AddWithValue("@p11", textıd.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("KAYIT Güncelleme Yapıldı", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           textıd.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            textad.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            textsoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
            msktelefon2.Text = gridView1.GetFocusedRowCellValue("TELEFON1").ToString();
            msktelefon1.Text = gridView1.GetFocusedRowCellValue("TELEFON2").ToString();
            msktc.Text = gridView1.GetFocusedRowCellValue("TC").ToString();
            textmaıl.Text = gridView1.GetFocusedRowCellValue("MAIL").ToString();
            cmbIL.Text = gridView1.GetFocusedRowCellValue("IL").ToString();
            cmbILCE.Text = gridView1.GetFocusedRowCellValue("ILCE").ToString();
            textvergı.Text = gridView1.GetFocusedRowCellValue("VERGIDAIRE").ToString();
            richadres.Text = gridView1.GetFocusedRowCellValue("ADRES").ToString();
        }

        private void cmbIL_SelectedIndexChanged(object sender, EventArgs e)
        {
            // comboBoxEdit2.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ilce From ilceler where sehir=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbIL.SelectedIndex + 1);
            SqlDataReader dr3 = komut.ExecuteReader();
            while (dr3.Read())
            {
                cmbILCE.Items.Add(dr3[0]);

            }
            bgl.baglanti().Close();
        }
    }
}
