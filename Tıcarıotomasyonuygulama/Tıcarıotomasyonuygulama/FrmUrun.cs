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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        public string id;
        void liste()
        {
            SqlDataAdapter kt = new SqlDataAdapter("select * from TBL_FATURADETAY where FATURAID='" + id + "'", bgl.baglanti()) ;
            DataTable dr = new DataTable();
            kt.Fill(dr);
            gridControl1.DataSource = dr;
        }
        private void FrmUrun_Load(object sender, EventArgs e)
        {
            labelControl1.Text = id;
            liste();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmUrunBılgıDetay fr = new FrmUrunBılgıDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr!=null)
            {
                fr.urunid = dr["FATURAURUNID"].ToString();
            }
            fr.Show();
        }
    }
}
