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
    public partial class FrmGıderler : Form
    {
        public FrmGıderler()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        void liste() 
        {
            DataTable td = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("Select * From TBL_GIDERLER",bgl.baglanti());
            dt.Fill(td);
            gridControl1.DataSource = td;
            bgl.baglanti().Close();
        }
        void temizle()
        {
            textID.Text = "";
            cmbay.Text = "";
            comboyıl.Text = "";
            txtelektrık.Text = "";
            txtsu.Text = "";
            txtdogalgaz.Text = "";
            txtınternet.Text = "";
            txtmaas.Text = "";
            richnotlar.Text = "";
        }
        private void FrmGıderler_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_GIDERLER(AY,YIL,ELEKTRIK,SU,DOGALGAZ,INTERNET,MAASLAR,EKSTRA,NOTLAR) VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",cmbay.Text);
            komut.Parameters.AddWithValue("@p2",comboyıl.Text);
            komut.Parameters.AddWithValue("@p3", txtelektrık.Text);
            komut.Parameters.AddWithValue("@p4", txtsu.Text);
            komut.Parameters.AddWithValue("@p5", txtdogalgaz.Text);
            komut.Parameters.AddWithValue("@p6", txtınternet.Text);
            komut.Parameters.AddWithValue("@p7", txtmaas.Text);
            komut.Parameters.AddWithValue("@p8", txtekstra.Text);
            komut.Parameters.AddWithValue("@p9", richnotlar.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("GIDER KAYDI YAPILDI");
            liste();

        }

       private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
          /*  textID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            cmbay.Text = gridView1.GetFocusedRowCellValue("AY").ToString();
            comboyıl.Text = gridView1.GetFocusedRowCellValue("YIL").ToString();
            txtelektrık.Text = gridView1.GetFocusedRowCellValue("ELEKTRIK").ToString();
            txtsu.Text = gridView1.GetFocusedRowCellValue("SU").ToString();
            txtdogalgaz.Text = gridView1.GetFocusedRowCellValue("DOGALGAZ").ToString();
            txtınternet.Text = gridView1.GetFocusedRowCellValue("INTERNET").ToString();
            txtmaas.Text = gridView1.GetFocusedRowCellValue("MAASLAR").ToString();
            txtekstra.Text = gridView1.GetFocusedRowCellValue("EKSTRA").ToString();
            richnotlar.Text = gridView1.GetFocusedRowCellValue("NOTLAR").ToString();*/
             
        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            cmbay.Text = gridView1.GetFocusedRowCellValue("AY").ToString();
            comboyıl.Text = gridView1.GetFocusedRowCellValue("YIL").ToString();
            txtelektrık.Text = gridView1.GetFocusedRowCellValue("ELEKTRIK").ToString();
            txtsu.Text = gridView1.GetFocusedRowCellValue("SU").ToString();
            txtdogalgaz.Text = gridView1.GetFocusedRowCellValue("DOGALGAZ").ToString();
            txtınternet.Text = gridView1.GetFocusedRowCellValue("INTERNET").ToString();
            txtmaas.Text = gridView1.GetFocusedRowCellValue("MAASLAR").ToString();
            txtekstra.Text = gridView1.GetFocusedRowCellValue("EKSTRA").ToString();
            richnotlar.Text = gridView1.GetFocusedRowCellValue("NOTLAR").ToString();

        }

        private void Btntemızle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnSıl_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Delete from TBL_GIDERLER where ID=@p1",bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",textID.Text);
            komut1.ExecuteNonQuery();
            MessageBox.Show("GIDER KAYDI SİLİNMİŞTİR");
            liste();
            
        }

        private void Btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update TBL_GIDERLER set AY=@p1,YIL=@p2,ELEKTRIK=@p3,SU=@p4,DOGALGAZ=@p5,INTERNET=@p6,MAASLAR=@p7,EKSTRA=@p8,NOTLAR=@p9 WHERE ID=@p10", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", cmbay.Text);
            komut2.Parameters.AddWithValue("@p2", comboyıl.Text);
            komut2.Parameters.AddWithValue("@p3", decimal.Parse(txtelektrık.Text));
            komut2.Parameters.AddWithValue("@p4", decimal.Parse(txtsu.Text));
            komut2.Parameters.AddWithValue("@p5", decimal.Parse(txtdogalgaz.Text));
            komut2.Parameters.AddWithValue("@p6", decimal.Parse(txtınternet.Text));
            komut2.Parameters.AddWithValue("@p7", decimal.Parse(txtmaas.Text));
            komut2.Parameters.AddWithValue("@p8", decimal.Parse(txtekstra.Text));
            komut2.Parameters.AddWithValue("@p9", richnotlar.Text);
            komut2.Parameters.AddWithValue("@p10", textID.Text);
            komut2.ExecuteNonQuery();
            MessageBox.Show("GIDER KAYDI GUNCELLENDI");
            liste();
        }
    }
}
