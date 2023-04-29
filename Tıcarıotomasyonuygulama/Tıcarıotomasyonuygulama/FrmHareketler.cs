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
    public partial class FrmHareketler : Form
    {
        public FrmHareketler()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        void fırma()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter tr = new SqlDataAdapter("EXEC FIRMAHAREKETLER",bgl.baglanti());
            tr.Fill(dt);
            gridControl2.DataSource = dt;
            bgl.baglanti().Close();

        }
        void musterı()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter tr = new SqlDataAdapter("EXEC MUSTERIHAREKETLERI", bgl.baglanti());
            tr.Fill(dt);
            gridControl1.DataSource = dt;
            bgl.baglanti().Close();
        }
        private void xtraTabPage3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmHareketler_Load(object sender, EventArgs e)
        {
            fırma();
            musterı();
        }
    }
}
