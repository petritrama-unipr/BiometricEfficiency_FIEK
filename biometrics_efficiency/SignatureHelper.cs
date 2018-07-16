using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace biometrics_efficiency
{
    class SignatureHelper
    {
        public TimeSpan signRSACSP_pc(string text)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            StreamReader sr = new StreamReader("PrivateKey.xml");
            rsa.FromXmlString(sr.ReadToEnd());
            sr.Close();

            byte[] dataBytes = Encoding.UTF8.GetBytes(text);

            Stopwatch sw = new Stopwatch();
            sw.Start();
            rsa.SignData(dataBytes, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
            sw.Stop();

            return sw.Elapsed;
        }


        public TimeSpan signRSACSP_card(string data, X509Certificate2 cert)
        {
            RSACryptoServiceProvider rsacsp = (RSACryptoServiceProvider) cert.PrivateKey;
            
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);

            Stopwatch sw = new Stopwatch();
            sw.Start();
            rsacsp.SignData(dataBytes, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
            sw.Stop();

            return sw.Elapsed;
        }


        public TimeSpan signRSA_card(string data, X509Certificate2 cert)
        {
            RSA rsa = (RSA)cert.PrivateKey;

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);

            Stopwatch sw = new Stopwatch();
            sw.Start();
            rsa.SignData(dataBytes, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
            sw.Stop();

            return sw.Elapsed;
        }
    }
}
