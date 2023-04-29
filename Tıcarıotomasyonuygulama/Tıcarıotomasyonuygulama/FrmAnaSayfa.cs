using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tıcarıotomasyonuygulama
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        FrmUrunler urun;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (urun == null)
            {
                urun = new FrmUrunler();
                urun.MdiParent = this;
                urun.Show();
            }
        }
        FrmMusterı mus;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mus == null)
            {
                mus = new FrmMusterı();
                mus.MdiParent = this;
                mus.Show();
            }
         }
        public string kullanici;
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            if (modul == null)
            {
                modul = new FrmAnaModül();
                modul.MdiParent = this;
                modul.Show();
            }
        }
        FrmFırmalar fır;
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fır == null)
            {
                fır = new FrmFırmalar();
                fır.MdiParent = this;
                fır.Show();
            }
        }
        FrmPersonel per;
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (per == null)
            {
                per = new FrmPersonel();
                per.MdiParent = this;
                per.Show();
            }
        }
        FrmRehber reh;
        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (reh == null)
            {
                reh = new FrmRehber();
                reh.MdiParent = this;
                reh.Show();
            }
            
        }
        FrmGıderler gıder;
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(gıder==null)
            {
                gıder = new FrmGıderler();
                gıder.MdiParent = this;
                gıder.Show();
            }
        }
        FrmBankalar banka;
        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(banka==null)
            {
                banka = new FrmBankalar();
                banka.MdiParent = this;
                banka.Show();
            }
        }
        FrmFatura fatura;
        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fatura == null)
            {
                fatura = new FrmFatura();
                fatura.MdiParent = this;
                fatura.Show();
            }
            

        }
        FrmNotlar not;
        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (not == null)
            {
                not = new FrmNotlar();
                not.MdiParent = this;
                not.Show();
            }
        }
        FrmHareketler hareket;
        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (hareket == null)
            {
                hareket = new FrmHareketler();
                hareket.MdiParent = this;
                hareket.Show();
            }
        }
        FrmRaporlar rapor;
        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (rapor == null)
            {
                rapor = new FrmRaporlar();
                rapor.MdiParent = this;
                rapor.Show();
            }
        }
        FrmStoklar stok;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (stok == null)
            {
                stok = new FrmStoklar();
                stok.MdiParent = this;
                stok.Show();
            }
        }
        FrmAyarlar ayar;
        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            
                ayar = new FrmAyarlar();
                 ayar.Show();
               
            
        }
        FrmKasa kasa;
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kasa == null)
            {
                kasa = new FrmKasa();
                kasa.ad = kullanici;
                kasa.MdiParent = this;
                kasa.Show();
            }
        }
        FrmAnaModül modul;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (modul == null)
            {
                modul = new FrmAnaModül();
                modul.MdiParent = this;
                modul.Show();
            }
        }
    }
}
