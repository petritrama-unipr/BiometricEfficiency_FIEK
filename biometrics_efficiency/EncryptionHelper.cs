using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;

namespace biometrics_efficiency
{
    class EncryptionHelper
    {

        public TimeSpan encryptRSACSP_pc(string text)
        {
            int segmentLength = 212;
            int loopLength = text.Length / segmentLength + 1;
            int copyLength;

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            StreamReader sr = new StreamReader("PublicKey.xml");
            rsa.FromXmlString(sr.ReadToEnd());
            sr.Close();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < loopLength; i++)
            {
                if (i == loopLength - 1 || text.Length < segmentLength)
                    copyLength = text.Length - (i * segmentLength);
                else
                    copyLength = segmentLength;

                string segment = text.Substring(i * segmentLength, copyLength);
                byte[] segmentBytes = Encoding.UTF8.GetBytes(segment);
                rsa.Encrypt(segmentBytes, false);
            }
            sw.Stop();

            return sw.Elapsed;
        }


        public void encryptECC_pc(string text)
        {
        }


        public TimeSpan encryptRSACSP_card(string text, X509Certificate2 cert)
        {
            int segmentLength = 212;
            int loopLength = text.Length / segmentLength + 1;
            int copyLength;

            RSACryptoServiceProvider rsa = (RSACryptoServiceProvider)cert.PublicKey.Key;

            byte[] textBytes = Encoding.UTF8.GetBytes(text);

            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < loopLength; i++)
            {
                if (i == loopLength - 1 || text.Length < segmentLength)
                    copyLength = text.Length - (i * segmentLength);
                else
                    copyLength = segmentLength;

                string segment = text.Substring(i * segmentLength, copyLength);
                byte[] segmentBytes = Encoding.UTF8.GetBytes(segment);
                rsa.Encrypt(segmentBytes, false);
            }
            sw.Stop();

            return sw.Elapsed;
        }


        public TimeSpan encryptRSA_card(string text, X509Certificate2 cert)
        {
            int segmentLength = 212;
            int loopLength = text.Length / segmentLength + 1;
            int copyLength;

            RSA rsa = cert.GetRSAPublicKey();

            byte[] textBytes = Encoding.UTF8.GetBytes(text);

            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < loopLength; i++)
            {
                if (i == loopLength - 1 || text.Length < segmentLength)
                    copyLength = text.Length - (i * segmentLength);
                else
                    copyLength = segmentLength;

                string segment = text.Substring(i * segmentLength, copyLength);
                byte[] segmentBytes = Encoding.UTF8.GetBytes(segment);
                rsa.Encrypt(segmentBytes, RSAEncryptionPadding.OaepSHA1);
            }
            sw.Stop();
            
            return sw.Elapsed;
        }

    }
}
