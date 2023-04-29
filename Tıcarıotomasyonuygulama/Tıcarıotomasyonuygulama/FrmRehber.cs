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
    public partial class FrmRehber : Form
    {
        public FrmRehber()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        void muste()
        {
            DataTable da = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select AD,SOYAD,TELEFON1,TELEFON2,MAIL from TBL_MUSTERI",bgl.baglanti());
            da1.Fill(da);
            gridControl1.DataSource = da;
        }
        void fırma()
        {
            DataTable da3 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("Select AD,YETKILIADSOYAD,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX from TBL_FIRMALAR",bgl.baglanti());
            da4.Fill(da3);
            gridControl2.DataSource = da3;
        }
        private void FrmRehber_Load(object sender, EventArgs e)
        {
            muste();
            fırma();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmMail mail = new FrmMail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr!=null)
            {
                mail.maıl = dr["MAIL"].ToString();
            }
            mail.Show();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            FrmMail frm = new FrmMail();
            DataRow dr1 = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr1!=null)
            {
                frm.maıl = dr1["MAIL"].ToString();
            }
            frm.Show();
        }
    }
}
