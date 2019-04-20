using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGP_Uygulama
{

    public partial class PGP : Form
    {
        public PGP()
        {
            InitializeComponent();
        }

        private void btnEncyrpt_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            string path1 = @"d:\PlainTextFile.txt";
            FileInfo fi = new FileInfo(path1);

            string duzYazi = txtPlainText.Text;
            string password = txtPassword.Text;

            
            string path = @"d:\EncryptedFile.txt";

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            using (FileStream fs = fi.Create())
            {
                //Byte[] info = new UTF8Encoding(true).GetBytes("This is some text in test file.Test! Test! Test! Created by Burak");
                Byte[] info = new UTF8Encoding(true).GetBytes(duzYazi);


                fs.Write(info, 0, info.Length);
                fs.Flush();
                fs.Close();
                FileStream str = new FileStream(@"d:\EncryptedFile.txt", FileMode.Create);
                PgpEncryptionKeys objPgpEncryptionKeys = new PgpEncryptionKeys(@"d:/keyPublic.txt", @"d:/keyPrivate.txt", password);
                PgpEncrypt objPgpEncrypt = new PgpEncrypt(objPgpEncryptionKeys);
                objPgpEncrypt.EncryptAndSign(str, fi);

                str.Flush();
                str.Close();

                txtEncrypted.Clear();
                StreamReader SR = new StreamReader(@"d:\EncryptedFile.txt");
                string metin = SR.ReadLine();
                while (metin != null)
                {
                    txtEncrypted.Text = txtEncrypted.Text + metin;
                    metin = SR.ReadLine();
                }
                SR.Close();

                //str.Flush();
                str.Close();
                //txtPassword.Text = "";

                timer.Stop();
                long gecenSure = timer.ElapsedMilliseconds ;
                lblSifrelemeSuresi.Text = Convert.ToString(gecenSure) + " milisaniye";
            }
        }

        private void btnDecyrpt_Click(object sender, EventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            string password = txtPassword.Text;

            string path = @"d:\DecryptedFile.txt";

            if (File.Exists(path))
            {
                File.Delete(path);
            }
            FileStream fs1 = new FileStream(@"d:\DecryptedFile.txt", FileMode.Create);
            fs1.Flush();
            fs1.Close();

            PGPDecrypt test = new PGPDecrypt(@"d:\EncryptedFile.txt",
                                 @"d:/keyPrivate.txt",
                                 password,
                                 @"d:",
                                 @"d:/keyPublic.txt");

            FileStream fs = File.Open(@"d:\EncryptedFile.txt", FileMode.Open);
            test.decrypt(fs, @"d:");

            fs.Flush();
            fs.Close();

            txtDecrypted.Clear();
            StreamReader SR = new StreamReader(@"d:\DecryptedFile.txt");
            string metin = SR.ReadLine();
            while (metin != null)
            {
                txtDecrypted.Text = txtDecrypted.Text + metin;
                metin = SR.ReadLine();
            }
            SR.Close();

            timer.Stop();
            long gecenSure = timer.ElapsedMilliseconds;
            lblSifreCozmeSuresi.Text = Convert.ToString(gecenSure) + " milisaniye";

            //txtPassword.Text = "";

        }

    }
}
