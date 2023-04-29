using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
namespace Tıcarıotomasyonuygulama
{
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        void listele()
        {
            DataTable rb = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("Select * from ADMIN", bgl.baglanti());
            dt.Fill(rb);
            gridControl2.DataSource = rb;

        }
        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into ADMIN(Kullanıcı,Sifre) Values(@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textEdit1.Text);
            komut.Parameters.AddWithValue("@p2", textEdit2.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kullanıcı Kaydı Yapılmıştır", "KAYIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textEdit1.Text = gridView2.GetFocusedRowCellValue("Kullanıcı").ToString();
            textEdit2.Text = gridView2.GetFocusedRowCellValue("Sifre").ToString();
            textEdit3.Text = gridView2.GetFocusedRowCellValue("ID").ToString();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update ADMIN set Kullanıcı=@p1,Sifre=@p2 where ID=@p3", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", textEdit1.Text);
            komut2.Parameters.AddWithValue("@p2", textEdit2.Text);
            komut2.Parameters.AddWithValue("@p3", textEdit3.Text);
            komut2.ExecuteNonQuery();
            MessageBox.Show("Kullanıcı Kaydı Güncellenmiştir", "GÜNCELLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
        }
    }
}
