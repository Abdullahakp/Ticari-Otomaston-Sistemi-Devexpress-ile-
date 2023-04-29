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
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        void liste()
        {
            DataTable per = new DataTable();
            SqlDataAdapter d = new SqlDataAdapter("select * from TBL_URUNLER", bgl.baglanti());
            d.Fill(per);
            gridControl1.DataSource = per;
            bgl.baglanti().Close();
        }
        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("insert into TBL_URUNLER(URUNAD,MARKA,MODEL,YIL,ADET,ALISFIYAT,SATISFIYAT,DETAY) Values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", textad.Text);
            komut1.Parameters.AddWithValue("@p2", textmarka.Text);
            komut1.Parameters.AddWithValue("@p3", textmodel.Text);
            komut1.Parameters.AddWithValue("@p4", mskyıl.Text);
            komut1.Parameters.AddWithValue("@p5", int.Parse((numadet.Value).ToString()));
            komut1.Parameters.AddWithValue("@p6", decimal.Parse((textalıs.Text).ToString()));
            komut1.Parameters.AddWithValue("@p7", decimal.Parse((textsatıs.Text).ToString()));
            komut1.Parameters.AddWithValue("@p8", rickdetay.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Gerçekleştirildi");
            liste();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komusil = new SqlCommand("Delete from TBL_URUNLER where ID=@p1", bgl.baglanti());
            komusil.Parameters.AddWithValue("@p1", textıd.Text);
            komusil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Silinmiştir");
            liste();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Update TBL_URUNLER set URUNAD=@p1,MARKA=@p2,MODEL=@p3,YIL=@p4,ADET=@p5,ALISFIYAT=@p6,SATISFIYAT=@p7,DETAY=@p8 WHERE ID=@p10", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", textad.Text);
            komut1.Parameters.AddWithValue("@p2", textmarka.Text);
            komut1.Parameters.AddWithValue("@p3", textmodel.Text);
            komut1.Parameters.AddWithValue("@p4", mskyıl.Text);
            komut1.Parameters.AddWithValue("@p5", int.Parse((numadet.Value).ToString()));
            komut1.Parameters.AddWithValue("@p6", decimal.Parse((textalıs.Text).ToString()));
            komut1.Parameters.AddWithValue("@p7", decimal.Parse((textsatıs.Text).ToString()));
            komut1.Parameters.AddWithValue("@p8", rickdetay.Text);
            komut1.Parameters.AddWithValue("@p10", textıd.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("ÜRÜN GÜNCELLEŞTİRİLDİ");
            liste();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textıd.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            textad.Text = gridView1.GetFocusedRowCellValue("URUNAD").ToString();
            textmarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
            textmodel.Text = gridView1.GetFocusedRowCellValue("MODEL").ToString();
            mskyıl.Text = gridView1.GetFocusedRowCellValue("YIL").ToString();
            numadet.Value = int.Parse(gridView1.GetFocusedRowCellValue("ADET").ToString());
            textalıs.Text = gridView1.GetFocusedRowCellValue("ALISFIYAT").ToString();
            textsatıs.Text = gridView1.GetFocusedRowCellValue("SATISFIYAT").ToString();
            rickdetay.Text = gridView1.GetFocusedRowCellValue("DETAY").ToString();
        }
    }
}
