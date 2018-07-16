using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace biometrics_efficiency
{
    public partial class Form1 : Form
    {
        RSACryptoServiceProvider rsacsp;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rsacsp = new RSACryptoServiceProvider(2048);

            StreamWriter sw = new StreamWriter("PublicKey.xml");
            sw.Write(rsacsp.ToXmlString(false));
            sw.Close();

            sw = new StreamWriter("PrivateKey.xml");
            sw.Write(rsacsp.ToXmlString(true));
            sw.Close();

            StreamReader sr = new StreamReader("PublicKey.xml");
            rsacsp.FromXmlString(sr.ReadToEnd());
            sr.Close();

            sr = new StreamReader("PrivateKey.xml");
            rsacsp.FromXmlString(sr.ReadToEnd());
            sr.Close();

        }


        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if(rbRSACSP_pc.Checked)
            {
                execute_EncRsacspPC();
            }
            else if(rbECC_pc.Checked)
            {

            }
            else if(rbRSACSP_card.Checked)
            {
                X509Certificate2 cert = openCertStore();
                execute_EncRsacspCard(cert);
            }
            else if(rbRSA_card.Checked)
            {
                X509Certificate2 cert = openCertStore();
                execute_EncRsaCard(cert);
            }
        }



        private void btnSign_Click(object sender, EventArgs e)
        {
            if (rbRSACSP_pc.Checked)
            {
                execute_SignRsacspPC();
            }
            else if (rbECC_pc.Checked)
            {
                MessageBox.Show("ECC signature is not supported!");
            }
            else if (rbRSACSP_card.Checked)
            {
                X509Certificate2 cert = openCertStore();
                execute_SignRsacspCard(cert);
            }
            else if (rbRSA_card.Checked)
            {
                X509Certificate2 cert = openCertStore();
                execute_SignRsaCard(cert);
            }
        }


        //// Encryption
        private void execute_EncRsacspPC()
        {
            EncryptionHelper objEncryption = new EncryptionHelper();
            string testString = readTestVector();

            TimeSpan executionTime = new TimeSpan();
            List<TimeSpan> totalTime = new List<TimeSpan>(10);

            for (int i = 0; i < 10; i++)
            {
                executionTime = objEncryption.encryptRSACSP_pc(testString);
                
                totalTime.Add(executionTime);
            }

            TimeSpan averageTime = TimeSpan.FromMilliseconds(totalTime.Average(i => i.TotalMilliseconds));

            writeResults("results_EncRsacspPC", totalTime);

            MessageBox.Show("The test was successfully executed!");
        }
        
        private void execute_EncEccPC()
        {
            EncryptionHelper objEncryption = new EncryptionHelper();
            
            MessageBox.Show("The test was successfully executed!");
        }
        
        private void execute_EncRsacspCard(X509Certificate2 cert)
        {
            EncryptionHelper objEncryption = new EncryptionHelper();
            string testString = readTestVector();

            TimeSpan executionTime = new TimeSpan();
            List<TimeSpan> totalTime = new List<TimeSpan>(10);

            for (int i = 0; i < 10; i++)
            {
                executionTime = objEncryption.encryptRSACSP_card(testString, cert);

                totalTime.Add(executionTime);
            }

            TimeSpan averageTime = TimeSpan.FromMilliseconds(totalTime.Average(i => i.TotalMilliseconds));

            writeResults("results_EncRsacspCard", totalTime);

            MessageBox.Show("The test was successfully executed!");
        }
        
        private void execute_EncRsaCard(X509Certificate2 cert)
        {
            EncryptionHelper objEncryption = new EncryptionHelper();
            string testString = readTestVector();

            TimeSpan executionTime = new TimeSpan();
            List<TimeSpan> totalTime = new List<TimeSpan>(10);

            for (int i = 0; i < 10; i++)
            {
                executionTime = objEncryption.encryptRSA_card(testString, cert);

                totalTime.Add(executionTime);
            }

            TimeSpan averageTime = TimeSpan.FromMilliseconds(totalTime.Average(i => i.TotalMilliseconds));

            writeResults("results_EncRsaCard", totalTime);

            MessageBox.Show("The test was successfully executed!");
        }



        //// Signature
        private void execute_SignRsacspPC()
        {
            SignatureHelper objSignature = new SignatureHelper();
            string testString = readTestVector();

            TimeSpan executionTime = new TimeSpan();
            List<TimeSpan> totalTime = new List<TimeSpan>(10);

            for (int i = 0; i < 10; i++)
            {
                executionTime = objSignature.signRSACSP_pc(testString);

                totalTime.Add(executionTime);
            }

            TimeSpan averageTime = TimeSpan.FromMilliseconds(totalTime.Average(i => i.TotalMilliseconds));

            writeResults("results_SignRsacspPC", totalTime);

            MessageBox.Show("The test was successfully executed!");
        }

        private void execute_SignRsacspCard(X509Certificate2 cert)
        {
            EncryptionHelper objEncryption = new EncryptionHelper();
            string testString = readTestVector();

            TimeSpan executionTime = new TimeSpan();
            List<TimeSpan> totalTime = new List<TimeSpan>(10);

            for (int i = 0; i < 10; i++)
            {
                executionTime = objEncryption.encryptRSACSP_card(testString, cert);

                totalTime.Add(executionTime);
            }

            TimeSpan averageTime = TimeSpan.FromMilliseconds(totalTime.Average(i => i.TotalMilliseconds));

            writeResults("results_SignRsacspCard", totalTime);

            MessageBox.Show("The test was successfully executed!");
        }

        private void execute_SignRsaCard(X509Certificate2 cert)
        {
            SignatureHelper objSignature = new SignatureHelper();
            string testString = readTestVector();

            TimeSpan executionTime = new TimeSpan();
            List<TimeSpan> totalTime = new List<TimeSpan>(10);

            for (int i = 0; i < 10; i++)
            {
                executionTime = objSignature.signRSA_card(testString, cert);

                totalTime.Add(executionTime);
            }

            TimeSpan averageTime = TimeSpan.FromMilliseconds(totalTime.Average(i => i.TotalMilliseconds));

            writeResults("results_SignRsaCard", totalTime);

            MessageBox.Show("The test was successfully executed!");
        }



        private void writeResults(string filename, List<TimeSpan> totalTime)
        {
            StreamWriter sw = new StreamWriter("testresults/" + filename + "_" + readCheckBox() + ".txt");

            sw.WriteLine("----  RESULTS  ----");
            sw.WriteLine();

            foreach(TimeSpan time in totalTime)
            {
                sw.WriteLine(" - " + time.TotalMilliseconds.ToString("N4") + " [ms]");
            }
            
            sw.WriteLine();

            sw.WriteLine("\n Best Time:     " + totalTime.Min().TotalMilliseconds.ToString("N4") + " [ms]");
            sw.WriteLine("\n Worst Time:    " + totalTime.Max().TotalMilliseconds.ToString("N4") + " [ms]");
            sw.WriteLine("\n Average Time:  " 
                + TimeSpan.FromTicks( (long) totalTime.Average(i => i.Ticks)).TotalMilliseconds.ToString("N4") + " [ms]");

            sw.Close();
        }


        private X509Certificate2 openCertStore()
        {
            X509Store store = new X509Store(StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);

            X509Certificate2Collection collection = store.Certificates.Find(X509FindType.FindByIssuerName, "eID ENC Issuing CA", true);
            X509Certificate2Collection selection = X509Certificate2UI.SelectFromCollection(collection, "Zgjedh X509 Certifikatën", "", X509SelectionFlag.SingleSelection);
            X509Certificate2 cert = collection[0];

            store.Close();

            return cert;
        }


        private string readTestVector()
        {
            string path = "";

            if (rb1kb.Checked)
                path = "testvector\\text_1kb.txt";
            else if(rb10kb.Checked)
                path = "testvector\\text_10kb.txt";
            else if (rb50kb.Checked)
                path = "testvector\\text_50kb.txt";
            else if (rb100kb.Checked)
                path = "testvector\\text_100kb.txt";
            else if (rb1mb.Checked)
                path = "testvector\\text_1mb.txt";
            else if (rb2mb.Checked)
                path = "testvector\\text_2mb.txt";
            else if (rb5mb.Checked)
                path = "testvector\\text_5mb.txt";
            else if (rb10mb.Checked)
                path = "testvector\\text_10mb.txt";

            StreamReader sr = new StreamReader(path);
            string text = sr.ReadToEnd();
            sr.Close();

            return text;
        }


        private string readCheckBox()
        {
            string checkBox = "";

            if (rb1kb.Checked)
                checkBox = "1kb";
            else if (rb10kb.Checked)
                checkBox = "10kb";
            else if (rb50kb.Checked)
                checkBox = "50kb";
            else if (rb100kb.Checked)
                checkBox = "100kb";
            else if (rb1mb.Checked)
                checkBox = "1mb";
            else if (rb2mb.Checked)
                checkBox = "2mb";
            else if (rb5mb.Checked)
                checkBox = "5mb";
            else if (rb10mb.Checked)
                checkBox = "10mb";

            return checkBox;
        }

        private void rbRSACSP_pc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRSACSP_pc.Checked)
            {
                rbRSACSP_pc.Checked = true;
                rbECC_pc.Checked = false;
                rbRSA_card.Checked = false;
                rbRSACSP_card.Checked = false;
            }
        }

        private void rbECC_pc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbECC_pc.Checked)
            {
                rbRSACSP_pc.Checked = false;
                rbECC_pc.Checked = true;
                rbRSA_card.Checked = false;
                rbRSACSP_card.Checked = false;
            }
        }

        private void rbRSA_card_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRSA_card.Checked)
            {
                rbRSACSP_pc.Checked = false;
                rbECC_pc.Checked = false;
                rbRSA_card.Checked = true;
                rbRSACSP_card.Checked = false;
            }
        }
        
        private void rbRSACSP_card_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRSACSP_card.Checked)
            {
                rbRSACSP_pc.Checked = false;
                rbECC_pc.Checked = false;
                rbRSA_card.Checked = false;
                rbRSACSP_card.Checked = true;
            }
        }
    }
}
