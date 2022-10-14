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
    partial class Notepad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private string file_name;

        public int wordcount;

        private System.Windows.Forms.Timer timer;

        private bool save_satus = true;

        private SaveFileDialog save_file;

        private ToolStrip toolStrip1;

        private ToolStripButton save_button;

        private ToolStripButton Open_button;

        private ToolStripLabel file_name_label;

        private ToolStripLabel toolStripLabel1;

        private ToolStripLabel toolStripLabel2;

        private ToolStripButton font_button;

        private RichTextBox richTextBox1;

        private FontDialog fontDialog1;

        private System.Windows.Forms.Timer timer1;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.save_button = new System.Windows.Forms.ToolStripButton();
            this.Open_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.font_button = new System.Windows.Forms.ToolStripButton();
            this.file_name_label = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.save_button,
            this.Open_button,
            this.toolStripLabel1,
            this.font_button,
            this.file_name_label,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.toolStrip1.Size = new System.Drawing.Size(787, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // save_button
            // 
            this.save_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.save_button.ForeColor = System.Drawing.Color.DarkGreen;
            this.save_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(35, 22);
            this.save_button.Text = "Save";
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // Open_button
            // 
            this.Open_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Open_button.ForeColor = System.Drawing.Color.DarkGreen;
            this.Open_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Open_button.Name = "Open_button";
            this.Open_button.Size = new System.Drawing.Size(40, 22);
            this.Open_button.Text = "Open";
            this.Open_button.Click += new System.EventHandler(this.Open_button_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(70, 22);
            this.toolStripLabel1.Text = "Opened File";
            // 
            // font_button
            // 
            this.font_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.font_button.ForeColor = System.Drawing.Color.DarkGreen;
            this.font_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.font_button.Name = "font_button";
            this.font_button.Size = new System.Drawing.Size(35, 22);
            this.font_button.Text = "Font";
            this.font_button.Click += new System.EventHandler(this.font_button_Click);
            // 
            // file_name_label
            // 
            this.file_name_label.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.file_name_label.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.file_name_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.file_name_label.Name = "file_name_label";
            this.file_name_label.Size = new System.Drawing.Size(52, 22);
            this.file_name_label.Text = "New File";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(124, 22);
            this.toolStripLabel2.Text = "Repack by Sravan";
            this.toolStripLabel2.ToolTipText = "Email: sravansai681@gmail.com";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(0, 25);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(48, 24, 48, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(787, 350);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // fontDialog1
            // 
            this.fontDialog1.AllowScriptChange = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(787, 375);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Notepad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notepad by Sravan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String text = Path.GetDirectoryName(Application.ExecutablePath + "\\NotepadPlus.exe");
            DialogResult res = MessageBox.Show("Developed by Sravan", "Developer Info",MessageBoxButtons.OK);
            /*if (File.Exists(text))
            {
                if (Enumerable.Count<Process>((IEnumerable<Process>)Process.GetProcessesByName("NotepadPlus")) == 0)
                {
                    ProcessStartInfo val = new ProcessStartInfo();
                    val.FileName=text;
                    val.WindowStyle = ProcessWindowStyle.Normal;
                    ProcessStartInfo val2 = val;
                }
            }
            else
            {
                Application.Exit();
            }*/
        }
        private string Decrypt(string cipherText)
		{
			string text = "GH67FZCGT56YU";
			byte[] array = Convert.FromBase64String(cipherText);
			Aes val = Aes.Create();
			try
			{
				Rfc2898DeriveBytes val2 = new Rfc2898DeriveBytes(text, new byte[13]
				{
					73,
					118,
					97,
					110,
					32,
					77,
					101,
					100,
					118,
					101,
					100,
					101,
					118
				});
                val.Key = val2.GetBytes(32);
                val.IV = val2.GetBytes(16);
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream val3 = new CryptoStream(memoryStream,val.CreateDecryptor(), CryptoStreamMode.Write);
				try
				{
					val3.Write(array, 0, array.Length);
					val3.Close();
				}
				finally
				{
					val3.Dispose();
				}
				cipherText = Encoding.Unicode.GetString(memoryStream.ToArray());
			}
			finally
			{
				val.Dispose();
			}
			return cipherText;
		}
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength - wordcount > 25)
            {
                //richTextBox1.Text="";
                //MessageBox.Show("You are not human. Typing Speed is too high.");
                //wordcount = richTextBox1.TextLength;
            }
            else
            {
                wordcount = richTextBox1.TextLength;
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (save_satus || !richTextBox1.Enabled)
            {
                return;
            }
            DialogResult val = MessageBox.Show("Please save file before closing", "Save file", MessageBoxButtons.YesNoCancel);
            if ((int)val == 6)
            {
                saveClick();
                if (file_name == null)
                {
                    e.Cancel = true;
                }
            }
            else if ((int)val != 7)
            {
                e.Cancel = true;
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {
                saveClick();
            }
            catch (Exception ex)
            {
                Exception ex2 = ex;
                MessageBox.Show("Some thing wrong happed: Error Name: " + ex2.Message);
            }
        }

        private void Open_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog val2;
            if (!save_satus && richTextBox1.Enabled)
            {
                DialogResult val = MessageBox.Show("Please save file before closing", "Save file", MessageBoxButtons.YesNoCancel);
                if ((int)val != 6)
                {
                    if ((int)val == 7)
                    {
                        val2 = new OpenFileDialog();
                        if ((int)val2.ShowDialog() == 1)
                        {
                            file_name = val2.FileName;
                            this.file_name_label.Text=file_name;
                            Open_file();
                            save_satus = true;
                        }
                    }
                    return;
                }
                saveClick();
            }
            val2 = new OpenFileDialog();
            if ((int)val2.ShowDialog() == 1)
            {
                file_name = val2.FileName;
                //((ToolStripItem)file_name_label).set_Text(file_name);
                file_name_label.Text=file_name;
                Open_file();
                save_satus = true;
            }
        }

        private void font_button_Click(object sender, EventArgs e)
        {
            DialogResult val = fontDialog1.ShowDialog();
            fontDialog1.AllowScriptChange = false;
            if ((int)val == 1)
            {
                richTextBox1.Font = fontDialog1.Font;
                richTextBox1.ForeColor = fontDialog1.Color;
            }
        }
        private void saveClick()
        {
            if (file_name != null && !(file_name.Trim() == ""))
            {
                FileStream fileStream = new FileStream(file_name, FileMode.Open, FileAccess.Write);
                fileStream.SetLength(0L);
                string text = richTextBox1.Text;
                string s = Encrypt(text);
                byte[] bytes = Encoding.ASCII.GetBytes(s);
                fileStream.Write(bytes, 0, bytes.Length);
                fileStream.Close();
                save_satus = true;
                return;
            }
            SaveFileDialog val = new SaveFileDialog();
            val.DefaultExt = "wrt";
            val.FileName = ".wrt";
            val.Filter = "WRT files (*.wrt)|*.wrt|All files (*.*)|*.*";
            save_file = val;
            if ((int)save_file.ShowDialog() == 1)
            {
                file_name = save_file.FileName;
                MessageBox.Show(file_name);
                FileStream fileStream = new FileStream(file_name, FileMode.Create, FileAccess.Write);
                if (!file_name.EndsWith(".wrt"))
                {
                    file_name = save_file.FileName + ".wrt";
                }
                string text2 = richTextBox1.Text;
                string s = Encrypt(text2);
                byte[] bytes = Encoding.ASCII.GetBytes(s);
                fileStream.Write(bytes, 0, bytes.Length);
                fileStream.Close();
                save_satus = true;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            /*if (Enumerable.Count<Process>((IEnumerable<Process>)Process.GetProcessesByName("NotepadPlus")) == 0)
            {
                ((Form)this).Close();
            }*/
        }

        private void unset()
        {
            richTextBox1.Enabled=false;
            save_button.Enabled=false;
            richTextBox1.Text="This file is only open with notepad application, please open with notepad.";
        }
        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            save_satus = false;
        }
        private void reset()
        {
            richTextBox1.Enabled=true;
            save_button.Enabled=true;
        }
        private string Encrypt(string clearText)
		{
			string text = "GH67FZCGT56YU";
			byte[] bytes = Encoding.Unicode.GetBytes(clearText);
			Aes val = Aes.Create();		
			try
			{
				Rfc2898DeriveBytes val2 = new Rfc2898DeriveBytes(text, new byte[13]
				{
					73,
					118,
					97,
					110,
					32,
					77,
					101,
					100,
					118,
					101,
					100,
					101,
					118
				});
                val.Key = val2.GetBytes(32);
                val.IV = val2.GetBytes(16);
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream val3 = new CryptoStream(memoryStream, val.CreateEncryptor(), CryptoStreamMode.Write);
				try
				{
					val3.Write(bytes, 0, bytes.Length);
					val3.Close();
				}
				finally
				{
					val3.Dispose();
				}
				clearText = Convert.ToBase64String(memoryStream.ToArray());
			}
			finally
			{
				val.Dispose();
			}
			return clearText;
		}

        #endregion
    }
}

