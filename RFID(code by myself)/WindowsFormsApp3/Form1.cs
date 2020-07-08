using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace WindowsFormsApp3
{

    public partial class Form1 : Form
    {

        Byte[] uuid_rd1 = { 0x04, 0x01, 0xd0, 0x2a };
        Byte[] Temporary_deposit = new Byte[50];
        Byte[] check = {0x0d,0x01,0xd0,0x00,0x68,0x83,0xc8,0x80,0x00,0x01,0x04,0xe0,0x09};
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
            timer1.Enabled = true;
        }
        static string  calc(byte a)
        {
            string data = Convert.ToString(a, 2).PadLeft(8, '0');
            int start = 0, length = 4;
            string b, c, d, e,f;
            b = data.Substring(start, length);
            c = data.Substring(start + 4, length);
            int acco = Convert.ToInt32(b, 2);
            d = Convert.ToString(acco, 16);
            int bcco = Convert.ToInt32(c, 2);
            e = Convert.ToString(bcco, 16);
            f = d + e;
            return(f);
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            serialPort1.Write(uuid_rd1, 0, uuid_rd1.Length); //自動傳送指令

            byte val = 0x03;
            if (Temporary_deposit[3].Equals(val) == true)
            {
                label14.Text = "沒感應到卡片";
            }
            else
            {
                label14.Text = "已顯示";
            }

            for (int i=0;i<13;i++)
            {
                if (Temporary_deposit[i].Equals(check[i]) == true)
                {
                    label15.Text = "卡片正確";
                }
                else
                {
                    label15.Text = "卡片錯誤";
                    break;
                }
            }
            

            label1.Text =calc(Temporary_deposit[0]);
            label2.Text = calc(Temporary_deposit[1]);
            label3.Text = calc(Temporary_deposit[2]);
            label4.Text = calc(Temporary_deposit[3]);
            label5.Text = calc(Temporary_deposit[4]);
            label6.Text = calc(Temporary_deposit[5]);
            label7.Text = calc(Temporary_deposit[6]);
            label8.Text = calc(Temporary_deposit[7]);
            label9.Text = calc(Temporary_deposit[8]);
            label10.Text = calc(Temporary_deposit[9]);
            label11.Text = calc(Temporary_deposit[10]);
            label12.Text = calc(Temporary_deposit[11]);
            label13.Text = calc(Temporary_deposit[12]);
            

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(30);
            serialPort1.Read(Temporary_deposit, 0, 50);
        }

        private void button1_Click(object sender, EventArgs e) //單一次
        {
            Thread.Sleep(300);
            serialPort1.Write(uuid_rd1, 0, uuid_rd1.Length);
            string str = System.Text.Encoding.UTF8.GetString(Temporary_deposit).TrimEnd('\0');
            label1.Text = str;
        }
    }
}
