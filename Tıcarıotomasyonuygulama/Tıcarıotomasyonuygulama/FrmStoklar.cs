using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using System.Data.SqlClient; 
namespace Tıcarıotomasyonuygulama
{
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            /*chartControl1.Series["Series1"].Points.AddPoint("İstanbul",12);
            chartControl1.Series["Series1"].Points.AddPoint("Ankara",24);
            chartControl1.Series["Series1"].Points.AddPoint("İzmir", 11);
            chartControl1.Series["Series1"].Points.AddPoint("Gaziantep",15);**/


            DataTable dr = new DataTable();
            SqlDataAdapter rd = new SqlDataAdapter("select URUNAD,SUM(ADET) from TBL_URUNLER group by URUNAD",bgl.baglanti());
            rd.Fill(dr);
            gridControl1.DataSource = dr;

            SqlCommand komut = new SqlCommand("select URUNAD,SUM(ADET) from TBL_URUNLER group by URUNAD", bgl.baglanti());
            SqlDataReader tr = komut.ExecuteReader();
            while(tr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(tr[0]),int.Parse(tr[1].ToString()));
            }
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("select IL,COUNT(*) from TBL_FIRMALAR group by IL", bgl.baglanti());
            SqlDataReader tf = komut2.ExecuteReader();
            while (tf.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(tf[0]), int.Parse(tf[1].ToString()));
            }
            bgl.baglanti().Close();


        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
