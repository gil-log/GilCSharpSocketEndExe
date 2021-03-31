using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace GilSocketResultForm
{
    public partial class SocketResultForm : Form
    {
        public SocketResultForm(String[] args)
        {
            InitializeComponent();

            string receiveUrl = args[1];
            receiveData.Text = receiveUrl;

            int key = Int32.Parse(args[2]);
            label2.Text = key.ToString();

            //string url = "https://www.naver.com";

            HtmlRequest htmlRequest = new HtmlRequest();

            string html = htmlRequest.GetRequest(receiveUrl, HttpMethod.Get, null);

            int htmlLength = html.Length;

            label_html.Text = htmlLength.ToString();


            String sendData = htmlLength.ToString() + " " + key + "<REOF>";

            Console.WriteLine("<send data> = {0}", sendData);

            SocketClient socketClient = new SocketClient();

            try { 
                socketClient.StartClient(sendData);
            }

            catch(Exception e) { 
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Application.Exit();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("오우 멋져요!");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            long receiveInt= Int64.Parse(receiveData.Text);

            MessageBox.Show("역시 최고의 타짜,,,,");

            long sendInt = receiveInt / 2;

            String sendDatas = sendInt.ToString();

            string key = label2.Text;

            String sendData = sendInt.ToString() + " " + key + "<REOF>";

            Console.WriteLine("<send data> = {0}", sendData);

            SocketClient socketClient = new SocketClient();

            socketClient.StartClient(sendData);

            //Console.WriteLine("<send>" + sendDatas);


        }

        private void SocketResultForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
