using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using System.Data.SqlClient;

namespace Hotel_Mater
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {           
            String Uname = username .Text ;
            String Passwd = password.Text;

            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\hotelmaster.accdb");
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("select * from tblUser where Username=@Uname and Password=@Passwd", con);
                cmd.Parameters.Add("@Username", OleDbType.VarChar).Value = Uname;
                cmd.Parameters.Add("@Password", OleDbType.VarChar).Value = Passwd;
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    
                    this.Hide();
                    mainform mn = new mainform();
                    mn.Show();
                }
                else
                {
                    MessageBox.Show("Please enter correct user details");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
 




        }


        private void login_Load(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            adduser au = new adduser();
            au.ShowDialog();
        }

        private void password_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
    public class MyDisplay : Panel
    {
        public MyDisplay()
        {
            this.DoubleBuffered = true;

            // or

            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();
        }
    }
}

