using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Narudzbina
{
    public partial class Poruci : Form
    {
        public Poruci()
        {
            InitializeComponent();
        }

        private void btnPoruci_Click(object sender, EventArgs e)
        {
            string userMail = "mateja.popovicsmtp@gmail.com";
            string userPassword = "sendingmailwithsmtp";
            string receiver = tbReceiver.Text;

            string subject = "Porudžbina";

            StreamReader sr = new StreamReader("TextFiles/Porudzbina.txt");

            string body = $"Predjelo: {sr.ReadLine()}\nJelo: {sr.ReadLine()}\nDesert: {sr.ReadLine()}\n";

            sr.Close();

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(userMail);
                mail.To.Add(receiver);
                mail.Subject = subject;
                mail.Body = body;

                SmtpServer.Port = 587;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential(userMail, userPassword);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        
    }
}
