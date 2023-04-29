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
    public partial class FrmFatura : Form
    {
        public FrmFatura()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        void liste()
        {
            DataTable dr = new DataTable();
            SqlDataAdapter rd = new SqlDataAdapter("select * From TBL_FATURABILGI",bgl.baglanti());
            rd.Fill(dr);
            gridControl1.DataSource = dr;
        }
        void temizle()
        {
            textıd.Text = "";
            txtserı.Text = "";
            txtsırano.Text = "";
            msktarıh.Text = "";
            msksaat.Text = "";
            txtvergı.Text = "";
            txtalıcı.Text = "";
            txtteslimeden.Text = "";
            txtteslimalan.Text = "";
        }
        
        private void FrmFatura_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textıd.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtserı.Text = gridView1.GetFocusedRowCellValue("SERI").ToString();
            txtsırano.Text = gridView1.GetFocusedRowCellValue("SIRANO").ToString();
            msktarıh.Text = gridView1.GetFocusedRowCellValue("TARIH").ToString();
            msksaat.Text = gridView1.GetFocusedRowCellValue("SAAT").ToString();
            txtvergı.Text = gridView1.GetFocusedRowCellValue("VERGIDAIRE").ToString();
            txtalıcı.Text = gridView1.GetFocusedRowCellValue("ALICI").ToString();
            txtteslimeden.Text = gridView1.GetFocusedRowCellValue("TESLİMEDEN").ToString();
            txtteslimalan.Text = gridView1.GetFocusedRowCellValue("TESLİMALAN").ToString();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (txtfaturaıd.Text == "")
            {
                SqlCommand komut = new SqlCommand("insert into TBL_FATURABILGI(SERI,SIRANO,TARIH,SAAT,VERGIDAIRE,ALICI,TESLİMEDEN,TESLİMALAN) VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtserı.Text);
                komut.Parameters.AddWithValue("@p2", txtsırano.Text);
                komut.Parameters.AddWithValue("@p3", msktarıh.Text);
                komut.Parameters.AddWithValue("@p4", msksaat.Text);
                komut.Parameters.AddWithValue("@p5", txtvergı.Text);
                komut.Parameters.AddWithValue("@p6", txtalıcı.Text);
                komut.Parameters.AddWithValue("@p7", txtteslimeden.Text);
                komut.Parameters.AddWithValue("@p8", txtteslimalan.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Kayıt Edilmiştir", "FATURA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                liste();
            }
            if (txtfaturaıd.Text != "")
            {
                double fıy, mık, tut;
                fıy = Convert.ToDouble(txtfıyat.Text);
                mık = Convert.ToDouble(txtmıktar.Text);
                tut = fıy * mık;
                txttutar.Text = tut.ToString();
                SqlCommand komut1 = new SqlCommand("insert into TBL_FATURADETAY(URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) VALUES(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", txturunad.Text);
                komut1.Parameters.AddWithValue("@p2", txtmıktar.Text);
                komut1.Parameters.AddWithValue("@p3", txtfıyat.Text);
                komut1.Parameters.AddWithValue("@p4", txttutar.Text);
                komut1.Parameters.AddWithValue("@p5", txtfaturaıd.Text);
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Ait Ürün Kayıt Edilmiştir", "FATURA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                liste();
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void Btnsıl_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("delete from TBL_FATURABILGI where ID=@p1",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1",textıd.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Ait Kayıt Silinmiştir", "FATURA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
        }

        private void Btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("update TBL_FATURABILGI set SERI=@p1,SIRANO=@p2,TARIH=@p3,SAAT=@p4,VERGIDAIRE=@p5,ALICI=@p6,TESLİMEDEN=@p7,TESLİMALAN=@p8 WHERE ID=@p10", bgl.baglanti());
            komut4.Parameters.AddWithValue("@p1", txtserı.Text);
            komut4.Parameters.AddWithValue("@p2", txtsırano.Text);
            komut4.Parameters.AddWithValue("@p3", msktarıh.Text);
            komut4.Parameters.AddWithValue("@p4", msksaat.Text);
            komut4.Parameters.AddWithValue("@p5", txtvergı.Text);
            komut4.Parameters.AddWithValue("@p6", txtalıcı.Text);
            komut4.Parameters.AddWithValue("@p7", txtteslimeden.Text);
            komut4.Parameters.AddWithValue("@p8", txtteslimalan.Text);
            komut4.Parameters.AddWithValue("@p10", textıd.Text);
            komut4.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Kayıt Güncellenmiştir", "FATURA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmUrun fr = new FrmUrun();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                fr.id = dr["ıd"].ToString();
            }
            fr.Show();
        }
    }
}
