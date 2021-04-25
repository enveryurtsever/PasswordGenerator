using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtLength.Text = "8";

            chkNumber.Checked = true;
            chkLower.Checked = true;
            chkCharacter.Checked = true;
            chkUpper.Checked = true;

            btnMD5Copy.Visible = false;
            btnPassCopy.Visible = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {

                lblUyari.ForeColor = Color.Red;

                if (txtLength.Text == "")
                    lblUyari.Text = "!Enter a length";
                else
                {
                    if (int.Parse(txtLength.Text) < 1)
                        lblUyari.Text = "!Min Length : 1";
                    else if (int.Parse(txtLength.Text) > 21)
                        lblUyari.Text = "!Max Length : 20";
                    else if (!chkCharacter.Checked && !chkLower.Checked && !chkNumber.Checked)
                        lblUyari.Text = "!1 option required";
                    else
                        CreatePass();
                }

            }
            catch (Exception)
            {
                lblUyari.Text = "An Error Occurred";
            }
        }

        void CreatePass()
        {
            lblUyari.Text = "";

            string letters = "";
            if (chkNumber.Checked)
                letters += "1234567890";
            if (chkLower.Checked)
                letters += "abcdefghijklmnoprstuvyzx";
            if (chkUpper.Checked)
                letters += "ABCDEFGHIJKLMNOPRSTUVYZX";
            if (chkCharacter.Checked)
                letters += "#$%?£@*";

            int Sayi = int.Parse(txtLength.Text);

            Random rnd = new Random(unchecked((int)DateTime.Now.Ticks));
            string ret = "";
            for (int i = 0; i < Sayi; i++)
            {
                ret += randLetter(rnd);
            }
            char randLetter(Random rndm)
            {
                return letters[rndm.Next(letters.Length)];
            }
            lblPASS.Text = ret;
            btnPassCopy.Visible = true;

            lblMD5.Text = MD5Olustur(ret);
            btnMD5Copy.Visible = true;

            lblUyari.Text = "Randomly Generated";
            lblUyari.ForeColor = Color.Green;

        }

        private void txtLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
          (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }



        public string MD5Olustur(string input)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        private void btnPassCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblPASS.Text);
            lblUyari.Text = "Copied Randomly Text";
            lblUyari.ForeColor = Color.Green;
        }

        private void btnMD5Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblMD5.Text);
            lblUyari.Text = "Copied MD5";
            lblUyari.ForeColor = Color.Green;
        }
    }
}