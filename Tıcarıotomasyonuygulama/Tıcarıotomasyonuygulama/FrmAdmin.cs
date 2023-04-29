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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
           
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void button1_Click(object sender, EventArgs e)
        {
           SqlCommand komut = new SqlCommand("select * from ADMIN where Kullanıcı=@p1 and Sifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",textEdit1.Text);
            komut.Parameters.AddWithValue("@p2",textEdit2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaSayfa fr = new FrmAnaSayfa();
                fr.kullanici = textEdit1.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("HATALI KULLANICI ADI VEYA ŞİFRE GİRDİNİZ");
            }
            bgl.baglanti().Close();
        }
    }
}
