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
    public partial class FrmUrunBılgıDetay : Form
    {
        public FrmUrunBılgıDetay()
        {
            InitializeComponent();
        }

        private void urunıd_EditValueChanged(object sender, EventArgs e)
        {
            
        }
        sqlbaglanti bgl = new sqlbaglanti();
        public string urunid;
        private void FrmUrunBılgıDetay_Load(object sender, EventArgs e)
        {
            txturunıd.Text = urunid;
            SqlCommand komut = new SqlCommand("select * from TBL_FATURADETAY where FATURAURUNID=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",urunid);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txturunad.Text = dr[1].ToString();
                txtfıyat.Text= dr[3].ToString();
                txtmıktar.Text = dr[2].ToString();
                txttutar.Text = dr[4].ToString();
               
            }
            bgl.baglanti().Close();

        }

        private void Btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("update TBL_FATURADETAY set URUNAD=@p1,MIKTAR=@p2,FIYAT=@p3,TUTAR=@p4 where FATURAURUNID=@P6", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", txturunad.Text);
            komut1.Parameters.AddWithValue("@p2", txtmıktar.Text);
            komut1.Parameters.AddWithValue("@p3",decimal.Parse( txtfıyat.Text));
            komut1.Parameters.AddWithValue("@p4", decimal.Parse( txttutar.Text));
            komut1.Parameters.AddWithValue("@P6", txturunıd.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Bilgileri Güncellenmiştir", "ÜRÜN", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Btnsıl_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("delete from TBL_FATURADETAY where FATURAURUNID=@P1",bgl.baglanti());
            komut3.Parameters.AddWithValue("@P1", txturunıd.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Ait Kayıt Silinmiştir", "URUN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
