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

    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
            

            
             


        }
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
                    }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            
        }

        private void mainform_Load(object sender, EventArgs e)
        {
           
            myDisplay1.Visible = false;
     
        }
        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
           // mainform mn = new mainform();
            //mn.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
}

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
                    }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
           /* if (hided) button1.Text = "hide";
            else button1.Text = "show";
            timer1.Start();*/ 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           /* if (hided)
            {
                spanel.Width = spanel.Width + 20;
                if (spanel.Width >= PW)
                {
                    timer1.Stop();
                    hided = false;
                    this.Refresh();
                }
                else
                {
                    spanel.Width = spanel.Width - 20;
                    if (spanel.Width <= 0)
                    {
                        timer1.Stop();
                        hided = true;
                        this.Refresh();
                    }
                }
            }*/
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            registration reg = new registration();
            animator2.Show(reg ,true);
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            Billing bill = new Billing();
            animator2.Show(bill, true);

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Reserve ress = new Reserve();
            animator2.Show(ress, true);
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            moniter mon = new moniter();
            animator2.Show(mon);

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            room rm = new room();
            animator2.Show(rm, true);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            panelout.Visible = false;
            
            animator3.Show(myDisplay1 ,true);

        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            animator3.Hide(myDisplay1 ,true );
            panelout.Visible = true;
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            login lg = new login();
            animator2.Show(lg, true);
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            help hp = new help();
            animator1.Show(hp,true );
        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            about ab = new about();
            animator1.Show(ab);
        }

        private void bunifuFlatButton4_Click_1(object sender, EventArgs e)
        {
            developer dp = new developer();
            animator1.Show(dp );
        }
    }
}