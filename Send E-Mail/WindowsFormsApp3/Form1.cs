using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                msg.To.Add("blinda12@ms4.hinet.net");
                //msg.To.Add("b@b.com");可以發送給多人
                msg.From = new MailAddress("minyou08042@gmail.com", "小魚", System.Text.Encoding.UTF8);
                /* 上面3個參數分別是發件人地址（可以隨便寫），發件人姓名，編碼*/
                msg.Subject = "測試標題";//郵件標題
                msg.SubjectEncoding = System.Text.Encoding.UTF8;//郵件標題編碼
                msg.Body = "測試一下"; //郵件內容
                msg.BodyEncoding = System.Text.Encoding.UTF8;//郵件內容編碼 
                //msg.Attachments.Add(new Attachment(@"D:\test2.docx"));  //附件
                msg.IsBodyHtml = true;//是否是HTML郵件  

                SmtpClient client = new SmtpClient();
                client.Credentials = new System.Net.NetworkCredential("minyou08042@gmail.com", "eric05182529"); //這裡要填正確的帳號跟密碼
                client.Host = "smtp.gmail.com"; //設定smtp Server
                client.Port = 25; //設定Port
                client.EnableSsl = true; //gmail預設開啟驗證
                client.Send(msg); //寄出信件
                client.Dispose();
                msg.Dispose();
                MessageBox.Show(this, "郵件寄送成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }
    }
}
