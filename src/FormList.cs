using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace sinzuku
{
    public partial class FormList : Form
    {
        TcpClient Client;
        StreamReader Reader;
        StreamWriter Writer;
        NetworkStream stream;
        Thread ReceiveThread;

        bool Connected;
        public string[] result = null;
        public int handsCount = 0;
        public int memberCount = 0;
        private delegate void AddTextDelegate(string strText);

        public FormList()
        {
            InitializeComponent();
            this.Left = SystemInformation.VirtualScreen.Left + Screen.PrimaryScreen.WorkingArea.Right - this.Width;
        }

        String IP = "54.146.88.72"; // 접속 할 서버 아이피를 입력
        int port = 3001; // 포트

        private void deleteList()
        {
            CrossThreadWorkHelper.DeleteTestBoxCrossThread(panel2);
        }

        private void connect()
        {
            Client = new TcpClient();
            Client.Connect(IP, port);
            stream = Client.GetStream();

            Connected = true;
            Reader = new StreamReader(stream);
            Writer = new StreamWriter(stream);
            ReceiveThread = new Thread(new ThreadStart(Receive));
            ReceiveThread.Start();
        }

        private void Receive() // 서버로 부터 값 받아오기
        {

            while (Connected)
            {
                Thread.Sleep(1);
                if (stream != null && stream.CanRead)
                {
                    string tempStr = Reader.ReadLine();
                    if (tempStr != null)
                        result = tempStr.Split(new char[] { '-' });
                    else {
                        Application.Exit();
                    }
                    
                    if (result[0] == "userName")
                    {
                        //deleteList();

                        memberCount++;
                        TextBox newText = new TextBox();
                        CrossThreadWorkHelper.AddTestCrossThread(stuCount, memberCount.ToString());
                        if (memberCount * stuPanel.Height > panel2.Height)
                            stuPanel.Width -= 20;

                        newText = new TextBox();
                        newText.Top = (memberCount) * (stuPanel.Height + 5 ) + stuPanel.Height / 2;
                        newText.ReadOnly = true;
                        newText.Visible = true;
                        newText.Text = result[1].ToString();

                        CrossThreadWorkHelper.AddTestBoxCrossThread(panel2, newText);
                    }

                    else if (result[0] == "hand")
                    {
                        handsCount++;
                        CrossThreadWorkHelper.AddTestCrossThread(handsCountBox, handsCount.ToString());
                    }
                    else if (result[0] == "end")
                    {
                        Connected = false;
                        Application.Exit();
                    }

                    Client = new TcpClient();
                    Client.Connect(IP, 3001);
                    stream = Client.GetStream();
                    Reader = new StreamReader(stream);
                    Writer = new StreamWriter(stream);
                }
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            CrossThreadWorkHelper.AddTestBoxCrossThread(panel2, new TextBox());
        }

        private void handsReset_Click(object sender, EventArgs e)
        {
            connect();
            Writer.WriteLine("handreset-" + roomId.Text); // 보내기
            Writer.Flush();
            handsCount = 0;
            handsCountBox.Text = handsCount.ToString();
        }

        private void startClass_Click(object sender, EventArgs e)
        {
            connect();
            if (roomId.Text != null)
            {
                Writer.WriteLine("list-" + roomId.Text); // 보내기
            }
            else
            {
                Writer.WriteLine("list");
            }
            Writer.Flush();

            refresh.Enabled = true;
            handsReset.Enabled = true;
            EndClass.Enabled = true;
            startClass.Enabled = false;
        }

        private void EndClass_Click(object sender, EventArgs e)
        {
            connect();
            Writer.WriteLine("endroom-" + roomId.Text); // 보내기
            Writer.Flush();
        }

        private void FormList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Connected = false;
            if (Reader != null) Reader.Close();
            if (Writer != null) Writer.Close();
            if (Client != null) Client.Close();
            if (ReceiveThread != null) ReceiveThread.Abort();
        }
    }
    public static class CrossThreadWorkHelper
    {

        public static void AddTestBoxCrossThread(this Panel panel, TextBox textbox)
        {
            if (panel.InvokeRequired)
            {
                panel.Invoke(new MethodInvoker(delegate ()
                {
                    panel.Controls.Add(textbox);
                }));
            }
            else
            {
                panel.Controls.Add(textbox);
            }
        }
        public static void DeleteTestBoxCrossThread(this Panel panel)
        {
            if (panel.InvokeRequired)
            {
                panel.Invoke(new MethodInvoker(delegate ()
                {
                    panel.Controls.Clear();
                }));
            }
            else
            {
                panel.Controls.Clear();
            }
        }


        public static void AddTestCrossThread(this TextBox box, string text)
        {
            if (box.InvokeRequired)
            {
                box.Invoke(new MethodInvoker(delegate ()
                {
                    box.Text = text;
                }));
            }
            else
            {
                box.Text = text;
            }
        }

    }
}
