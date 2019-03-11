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
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework.Drawing;


namespace Hotel_Mater
{
    public partial class adduser : Form
    {
        public adduser()
        {
            InitializeComponent();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\hotelmaster.accdb";

            String Uname = textBox1 .Text ;
            String Passwd = textBox2 .Text ;

            OleDbCommand cmd = new OleDbCommand("INSERT into tblUser (username, [password]) Values(@Uname, @Passwd)");
            cmd.Connection = conn;

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                cmd.Parameters.Add("@username", OleDbType.VarChar).Value = Uname;
                cmd.Parameters.Add("@[password]", OleDbType.VarChar).Value = Passwd;

                try
                {
                    cmd.ExecuteNonQuery();
                    this.Hide();
                    MetroFramework.MetroMessageBox.Show(this, "", "User Added", MessageBoxButtons.OK , MessageBoxIcon.Asterisk );    
                    conn.Close();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString ());
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Connection Failed");
            }
            conn.Close();
            /*try
            {
                this.appdata.tblUser.AddtblUserRow(this .appdata .tblUser .NewtblUserRow ());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message ,"message",MessageBoxButtons.OK ,MessageBoxIcon.Stop);
                tblUserBindingSource.ResetBindings(false );
            }
            /*OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\AMMU\Documents\hotelmaster.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO tblUser  values( Username='" + textBox1 .Text + "' and Password='" + textBox2 .Text + ")",con);
           
            con.Close();*/
        }

        private void adduser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appdata.tblUser' table. You can move, or remove it, as needed.
            this.tblUserTableAdapter.Fill(this.appdata.tblUser);
            tblUserBindingSource.DataSource = this.appdata.tblUser;

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
