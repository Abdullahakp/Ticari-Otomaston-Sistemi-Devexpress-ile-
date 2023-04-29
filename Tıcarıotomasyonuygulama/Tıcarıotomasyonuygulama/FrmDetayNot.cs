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
    public partial class FrmDetayNot : Form
    {
        public FrmDetayNot()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        
        public string detay;
        private void FrmDetayNot_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = detay;
            
        }
    }
}
