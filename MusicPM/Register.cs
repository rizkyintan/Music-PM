using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPM
{
    public partial class Register : Form
    {

        DBAccess objDBAccess = new DBAccess();

        public Register()
        {
            InitializeComponent();
        }

        private User user;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void radYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool userExists = false;
            StreamReader str;
            StreamWriter stw;
            if (txtPassword.Text != "" && txtUserName.Text != "" && ((radYes.Checked) || (radNo.Checked)))
            {
                using (str = new StreamReader("Pass.txt", true))
                {
                    while (!str.EndOfStream)
                    {
                        if (str.ReadLine().Equals(txtUserName.Text))
                        {
                            userExists = true;
                        }

                    }
                }

                if (userExists == false)
                {
                    using (stw = new StreamWriter("Pass.txt", append: true))
                    {
                        stw.WriteLine(txtUserName.Text);
                        stw.WriteLine(txtPassword.Text);
                        if (radYes.Checked)
                        {
                            stw.WriteLine("true");
                            user = new User(txtUserName.Text, txtPassword.Text, true);
                        }
                        else if (radNo.Checked)
                        {
                            stw.WriteLine("false");
                            user = new User(txtUserName.Text, txtPassword.Text, false);
                        }
                        MusicPM mp = new MusicPM(user);
                        this.Visible = false;
                        MessageBox.Show(txtUserName.Text, "Selamat Datang!");
                        mp.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Kamu sudah terdaftar!");
                }
            }
            else
            {
                MessageBox.Show("Semua bagian harus terisi!");
            }
        }
    }
}