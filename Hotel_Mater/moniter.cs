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

namespace Hotel_Mater
{
    public partial class moniter : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\hotelmaster.accdb");

        public moniter()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void moniter_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter adp = new OleDbDataAdapter("select * from tblTrans",con );
            DataTable dt = new DataTable();
            adp.Fill(dt );
            dataGridView2.DataSource = dt;
            OleDbDataAdapter adp2 = new OleDbDataAdapter("select * from tblRoom",con );
            DataTable dt2 = new DataTable();
            adp2.Fill(dt2 );
            dataGridView1.DataSource = dt2;
            OleDbDataAdapter adp3 = new OleDbDataAdapter("select * from tbltrans where status='Reserved'",con);
            DataTable dt3 = new DataTable();
            adp3.Fill(dt3 );
            dataGridView3.DataSource = dt3;
            OleDbDataAdapter adp4 = new OleDbDataAdapter("select * from tbltrans where status='BillPaid'", con);
            DataTable dt4 = new DataTable();
            adp4.Fill(dt4);
            dataGridView4.DataSource = dt4;
            
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter adpr = new OleDbDataAdapter("select * from tblRoom where RoomNumber like '"+textBox1 .Text +"%'",con );

            DataTable dtrr = new DataTable();
            adpr.Fill(dtrr );
            dataGridView1.DataSource = dtrr;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter adpru = new OleDbDataAdapter("select * from tblTrans where GuestID like '" + textBox2.Text + "%'", con);

            DataTable dtru = new DataTable();
            adpru.Fill(dtru);
            dataGridView2.DataSource = dtru;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter adpreu = new OleDbDataAdapter("select * from tblTrans where GuestID like '" + textBox3.Text + "%' and status='Reserved'", con);

            DataTable dtre = new DataTable();
            adpreu.Fill(dtre);
            dataGridView3.DataSource = dtre;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter adpcu = new OleDbDataAdapter("select * from tblTrans where GuestID like '" + textBox4.Text + "%' and status='BillPaid'", con);

            DataTable dtcu = new DataTable();
            adpcu.Fill(dtcu);
            dataGridView4.DataSource = dtcu;
        }
    }
}
