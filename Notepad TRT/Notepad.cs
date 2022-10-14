using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace Notepad_TRT
{
    partial class Notepad : Form
    {

        public Notepad(string name)
            : this()
        {

            InitializeComponent();
            fontDialog1.Font=new Font("Book Antiqua", 14f);
            if (name != null)
            {
                try
                {
                    file_name_label.Text=name;
                    file_name = name;
                    Open_file();
                }
                catch (Exception)
                {
                    unset();
                    return;
                }
            }
            else
            {
                file_name_label.Text="New File";
            }
            timer1.Start();
            Thread.Sleep(3000);
            timer = new System.Windows.Forms.Timer();
            timer.Interval=1000;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Enabled = true;
            timer.Start();
        }

        public Notepad()
        {
            // TODO: Complete member initialization
        }
        private void Open_file()
        {
            try
            {
                FileStream fileStream = new FileStream(file_name, FileMode.Open, FileAccess.Read);
                byte[] array = new byte[checked((int)fileStream.Length)];
                fileStream.Read(array, 0, (int)fileStream.Length);
                string text = Decrypt(Encoding.UTF8.GetString(array));
                richTextBox1.Text=text;
                fileStream.Close();
                wordcount = richTextBox1.TextLength;
            }
            catch (Exception)
            {
                unset();
                return;
            }
            reset();
        }
    		public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
		{
			byte[] result = null;
			byte[] array = new byte[8]
			{
				1,
				2,
				3,
				4,
				5,
				6,
				7,
				8
			};
			using (MemoryStream memoryStream = new MemoryStream())
			{
				RijndaelManaged val = new RijndaelManaged();
				try
				{
                    val.KeySize=256;
                    val.BlockSize = 128;
					Rfc2898DeriveBytes val2 = new Rfc2898DeriveBytes(passwordBytes, array, 1000);
                    val.Key = val2.GetBytes(val.KeySize / 8);
                    val.IV = val2.GetBytes(val.BlockSize / 8);
                    val.Mode = CipherMode.CBC;
                    CryptoStream val3 = new CryptoStream(memoryStream, val.CreateEncryptor(), CryptoStreamMode.Write);
					try
					{
                        val3.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        val3.Close();
					}
					finally
					{
						val3.Dispose();
					}
					result = memoryStream.ToArray();
				}
				finally
				{
					val.Dispose();
				}
			}
			return result;
		}


    }
}
