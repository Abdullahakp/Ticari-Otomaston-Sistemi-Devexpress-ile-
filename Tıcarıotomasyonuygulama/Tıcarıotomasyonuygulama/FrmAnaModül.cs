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
using System.Xml;
namespace Tıcarıotomasyonuygulama
{
    public partial class FrmAnaModül : Form
    {
        public FrmAnaModül()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        void stok()
        {
            DataTable tr = new DataTable();
            SqlDataAdapter hg = new SqlDataAdapter("select URUNAD,sum(Adet) as 'ADET' from TBL_URUNLER group by URUNAD having sum(ADET) <= 50 order by sum(adet) asc",bgl.baglanti());
            hg.Fill(tr);
            gridControl5.DataSource = tr;
        }
        void ajanda()
        {
            DataTable tr = new DataTable();
            SqlDataAdapter hg = new SqlDataAdapter("SELECT TOP 10 TARIH, SAAT, BASLIK, OLUSTURAN FROM TBL_NOTLAR ", bgl.baglanti());
            hg.Fill(tr);
            gridControl2.DataSource = tr;
        }
        void hareket()
        {
            DataTable tr = new DataTable();
            SqlDataAdapter hg = new SqlDataAdapter("EXEC HAREKETLER", bgl.baglanti());
            hg.Fill(tr);
            gridControl1.DataSource = tr;
        }
        void fihrist()
        {
            DataTable tr = new DataTable();
            SqlDataAdapter hg = new SqlDataAdapter("Select AD,TELEFON1 from TBL_FIRMALAR", bgl.baglanti());
            hg.Fill(tr);
            gridControl3.DataSource = tr;
        }
        void haber()
        {
            XmlTextReader xmloku = new XmlTextReader("https://www.hurriyet.com.tr/rss/anasayfa");
            while (xmloku.Read())
            {
                if(xmloku.Name=="title")
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }
            }
        }
        private void FrmAnaModül_Load(object sender, EventArgs e)
        {
            stok();
            ajanda();
            hareket();
            fihrist();
            webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/kurlar_tr.html");
            webBrowser2.Navigate("https://www.youtube.com/");
            haber();
        }

        private void gridControl5_Click(object sender, EventArgs e)
        {

        }
    }
}
