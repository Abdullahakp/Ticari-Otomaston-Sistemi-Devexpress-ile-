using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
namespace Tıcarıotomasyonuygulama
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }
        public string maıl;
        private void FrmMail_Load(object sender, EventArgs e)
        {
            Txtmail.Text = maıl;
        }
        
        private void BtnGönder_Click(object sender, EventArgs e)
        {
            MailMessage mesajım = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("abdullahakp581@outlook.com.tr", "188138AA.");
            istemci.Port = 587;
            istemci.Host = "smtp.live.com";
            istemci.EnableSsl = true;
            mesajım.To.Add(Txtmail.Text);
            mesajım.From = new MailAddress("abdullahakp581@outlook.com.tr");
            mesajım.Subject = Txtkonu.Text;
            mesajım.Body = richmesaj.Text;
            istemci.Send(mesajım);



        }
    }
}
