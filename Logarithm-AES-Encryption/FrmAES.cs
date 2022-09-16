using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
/*
 Name: Eng. Habeab Alhamed
 Twitter: @Eng_Habeab
 GitHub: https://github.com/Habeab
 Email: Habeab@gmail.com
 Whatsapp: 0553400333
 Location: Saudi Arabia
*/

namespace Logarithm_AES_Encryption
{
    public partial class FrmAES : Form
    {
        public FrmAES()
        {
            InitializeComponent();
        }
        //It should be 16 characters
        byte[] key = Encoding.ASCII.GetBytes("WinMac*&^3+=&^jI");
        //It should be 16 characters
        byte[] Iv = Encoding.ASCII.GetBytes("MacMaxE&^3+=&^jI");


        #region Optional
        /*
          Create random Key and initialization vector
          Appropriate For correspondence
        */
        //byte[] key;
        //byte[] Iv;
        #endregion

        private byte[] Edata(string txt, byte[] _key, byte[] _Iv)
        {
            byte[] Result;
            using (Aes aes = Aes.Create())
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(_key, _Iv), CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                        {
                            streamWriter.Write(txt);
                        }
                        Result = memoryStream.ToArray();
                    }
                }
            }
            return Result;
        }
        private string Ddata(byte[] cipher, byte[] _key, byte[] _Iv)
        {
            string Result = string.Empty;
            using (Aes aes = Aes.Create())
            {
                using (MemoryStream memoryStream = new MemoryStream(cipher))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(_key, _Iv), CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader(cryptoStream))
                        {
                            Result = streamReader.ReadToEnd();
                        }
                    }
                }
            }
            return Result;
        }
        private void BtnEncryption_Click(object sender, EventArgs e)
        {

            #region Optional
            /*
              Create random Key and initialization vector
              Appropriate For correspondence
            */
            //Aes aes = Aes.Create();
            //key = aes.Key;
            //Iv = aes.IV; //initialization Vector
            #endregion

            var data = Edata(TbxData.Text, key, Iv);

            //Info
            TbxKey.Text = Encoding.Default.GetString(key);
            TbxIv.Text = Encoding.Default.GetString(Iv);

            TbxEncryptin.Text = Encoding.Default.GetString(data);
        }

        private void BtnDecryption_Click(object sender, EventArgs e)
        {
            var data = Encoding.Default.GetBytes(TbxEncryptin.Text);
            TbxDecryptin.Text = Ddata(data, key, Iv);
        }
    }
}
