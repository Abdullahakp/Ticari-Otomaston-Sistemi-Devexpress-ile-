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
    public partial class FrmBankalar : Form
    {
        public FrmBankalar()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        void liste()
        {
            DataTable td = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("EXECUTE Bankabilgileri",bgl.baglanti());
            dt.Fill(td);
            gridControl1.DataSource = td;
            bgl.baglanti().Close();
        }
        void IL()
        {
            SqlCommand gs = new SqlCommand("select * from iller",bgl.baglanti());
            SqlDataReader dr = gs.ExecuteReader();
            while(dr.Read())
            {
                comboıl.Items.Add(dr[1]);

            }
            bgl.baglanti().Close();
        }
        void fırma()
        {
            DataTable fb = new DataTable();
            SqlDataAdapter fd = new SqlDataAdapter("Select ID,AD from TBL_FIRMALAR", bgl.baglanti());
            fd.Fill(fb);
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AD";
            lookUpEdit1.Properties.DataSource = fb;
        }
        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textEdit6_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmBankalar_Load(object sender, EventArgs e)
        {
            liste();
            IL();
            fırma();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
             txtıd.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtbankadi.Text = gridView1.GetFocusedRowCellValue("BANKAADI").ToString();
            comboıl.Text = gridView1.GetFocusedRowCellValue("IL").ToString();
            comboılce.Text = gridView1.GetFocusedRowCellValue("ILCE").ToString();
            txtsube.Text = gridView1.GetFocusedRowCellValue("SUBE").ToString();
            txtıban.Text = gridView1.GetFocusedRowCellValue("IBAN").ToString();
            txthesap.Text = gridView1.GetFocusedRowCellValue("HESAPNO").ToString();
            txtyetkılı.Text = gridView1.GetFocusedRowCellValue("YETKILI").ToString();
            masketelefon.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
            masketarih.Text = gridView1.GetFocusedRowCellValue("TARIH").ToString();
            txthesapturu.Text = gridView1.GetFocusedRowCellValue("HESAPTURU").ToString();
           // txtfırmaadı.Text = gridView1.GetFocusedRowCellValue("FIRMAID").ToString();
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_BANKALAR(BANKAADI,IL,ILCE,SUBE,HESAPNO,YETKILI,TELEFON,TARIH,HESAPTURU,FIRMAID) VALUES(@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2",txtbankadi.Text);
            komut.Parameters.AddWithValue("@p3",comboıl.Text);
            komut.Parameters.AddWithValue("@p4",comboılce.Text);
            komut.Parameters.AddWithValue("@p5", txtsube.Text);
            komut.Parameters.AddWithValue("@p6", txthesap.Text);
            komut.Parameters.AddWithValue("@p7", txtyetkılı.Text);
            komut.Parameters.AddWithValue("@p8", masketelefon.Text);
            komut.Parameters.AddWithValue("@p9", masketarih.Text);
            komut.Parameters.AddWithValue("@p10", txthesapturu.Text);
            komut.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarılı");
            liste();
        }

        private void comboıl_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboılce.Items.Clear();
            SqlCommand bjk = new SqlCommand("select ilce from ilceler where sehir=@p1",bgl.baglanti());
            bjk.Parameters.AddWithValue("@p1",comboıl.SelectedIndex+1);
            SqlDataReader rd = bjk.ExecuteReader();
            while(rd.Read())
            {
                comboılce.Items.Add(rd[0]);
            }
           
            bgl.baglanti().Close();
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnSıl_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Delete FROM TBL_BANKALAR where ID=@p1",bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",txtıd.Text);
            komut1.ExecuteNonQuery();
            liste();
            MessageBox.Show("BANKA BAŞARI İLE SİLİNDİ");
            bgl.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("update TBL_BANKALAR set BANKAADI=@p1,IL=@p2,ILCE=@p3,SUBE=@p4,IBAN=@p5,HESAPNO=@p6,YETKILI=@p7,TELEFON=@p8,TARIH=@p9,HESAPTURU=@p10,FIRMAID=@p11 WHERE ID=@P12", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", txtbankadi.Text);
            komut1.Parameters.AddWithValue("@p2", comboıl.Text);
            komut1.Parameters.AddWithValue("@p3", comboılce.Text);
            komut1.Parameters.AddWithValue("@p4", txtsube.Text);
            komut1.Parameters.AddWithValue("@p5", txtıban.Text);
            komut1.Parameters.AddWithValue("@p6", txthesap.Text);
            komut1.Parameters.AddWithValue("@p7", txtyetkılı.Text);
            komut1.Parameters.AddWithValue("@p8", masketelefon.Text);
            komut1.Parameters.AddWithValue("@p9", masketelefon.Text);
            komut1.Parameters.AddWithValue("@p10",txthesapturu.Text);
            komut1.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
            komut1.Parameters.AddWithValue("@p12",txtıd.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("KAYIT Güncelleme Yapıldı", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            liste();
        }
    }
}
