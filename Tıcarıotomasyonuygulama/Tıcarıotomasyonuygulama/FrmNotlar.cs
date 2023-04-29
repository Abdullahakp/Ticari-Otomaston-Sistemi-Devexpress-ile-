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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        void liste()
        {
            DataTable dr = new DataTable();
            SqlDataAdapter rd = new SqlDataAdapter("select * from TBL_NOTLAR", bgl.baglanti());
            rd.Fill(dr);
            gridControl1.DataSource = dr;

        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textıd.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            mskTARIH.Text = gridView1.GetFocusedRowCellValue("TARIH").ToString();
            mskSAAT.Text = gridView1.GetFocusedRowCellValue("SAAT").ToString();
            textBASLIK.Text = gridView1.GetFocusedRowCellValue("BASLIK").ToString();
            textOLUS.Text = gridView1.GetFocusedRowCellValue("OLUSTURAN").ToString();
            textHITAP.Text = gridView1.GetFocusedRowCellValue("HITAP").ToString();
            richDETAY.Text = gridView1.GetFocusedRowCellValue("DETAY").ToString();
        }
        void temızle()
        {
            textıd.Text = "";
            mskTARIH.Text = "";
            mskSAAT.Text = "";
            textBASLIK.Text = "";
            textOLUS.Text = "";
            textHITAP.Text = "";
            richDETAY.Text = "";
        }
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void btnKAYDET_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_NOTLAR(TARIH,SAAT,BASLIK,OLUSTURAN,HITAP,DETAY) VALUES(@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",mskTARIH.Text);
            komut.Parameters.AddWithValue("@p2", mskSAAT.Text);
            komut.Parameters.AddWithValue("@p3",textBASLIK.Text);
            komut.Parameters.AddWithValue("@p4",textOLUS.Text);
            komut.Parameters.AddWithValue("@p5",textHITAP.Text);
            komut.Parameters.AddWithValue("@p6",richDETAY.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("NOT OLUŞTURULDU","NOTLAR",MessageBoxButtons.OK,MessageBoxIcon.Information);
            liste();
        }

        private void btnSIL_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("delete from TBL_NOTLAR where ID=@p1",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1",textıd.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("NOT SİLİNMİŞTİR","NOTLAR",MessageBoxButtons.OK,MessageBoxIcon.Information);
            liste();
        }

        private void btnGUNCELLE_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("update TBL_NOTLAR set TARIH=@p1,SAAT=@p2,BASLIK=@p3,OLUSTURAN=@p4,HITAP=@p5,DETAY=@p6 WHERE ID=@p7",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", mskTARIH.Text);
            komut3.Parameters.AddWithValue("@p2", mskSAAT.Text);
            komut3.Parameters.AddWithValue("@p3", textBASLIK.Text);
            komut3.Parameters.AddWithValue("@p4", textOLUS.Text);
            komut3.Parameters.AddWithValue("@p5", textHITAP.Text);
            komut3.Parameters.AddWithValue("@p6", richDETAY.Text);
            komut3.Parameters.AddWithValue("@p7", textıd.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("NOT GÜNCELLENMİŞTİR", "NOTLAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
        }

        private void btnTEMIZLE_Click(object sender, EventArgs e)
        {
           temızle();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmDetayNot fr = new FrmDetayNot();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if(dr!=null)
            {
                fr.detay = dr["DETAY"].ToString();
            }
            fr.Show();
        }
    }
}
