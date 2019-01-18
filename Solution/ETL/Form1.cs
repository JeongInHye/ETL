using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            operation();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Development();
        }

        //private void Button_Click(object sender, EventArgs e)
        //{
        //    Button button = (Button)sender;

        //    switch (button)
        //    {
        //        default:
        //            break;
        //    }
        //}

        private bool Development()  // 개발 접속
        {
            try
            {
                MessageBox.Show("개발");
                string strConnection = string.Format("server={0};user={1};password={2};database={3}", "192.168.3.133", "root", "1234", "test");

                MySqlConnection conn = GetConnection(strConnection);
                if (conn == null)
                {
                    MessageBox.Show("연결 실패");
                    return false;
                }
                MessageBox.Show("연결 성공");
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private bool operation()  // 운영 접속
        {
            try
            {
                MessageBox.Show("운영");
                string strConnection = string.Format("server={0};user={1};password={2};database={3}", "192.168.3.152", "root", "1234", "test");

                MySqlConnection conn = GetConnection(strConnection);
                if (conn == null)
                {
                    MessageBox.Show("연결 실패");
                    return false;
                }
                MessageBox.Show("연결 성공");
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private MySqlConnection GetConnection(string strConnection)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = strConnection;
                conn.Open();
                return conn;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
