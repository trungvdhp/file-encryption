using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileEncryption
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSourceBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Multiselect = false;
            if(f.ShowDialog() == DialogResult.OK)
            {
                txtSourcePath.Text = f.FileName;
            }
        }

        private void btnDestinationBrowse_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtDestinationPath.Text = f.FileName;
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            FileEcryption f;
            if (txtKey.Text == "")
            {
                MessageBox.Show("Bạn phải nhập vào một từ khóa!", "Nhập từ khóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDestinationPath.Focus();
                return;
            }
            f = new FileEcryption(txtKey.Text, (int)nudBlock.Value, (byte)nudCycle.Value, (byte)nudFrequency.Value);
            if (txtDestinationPath.Text == txtSourcePath.Text)
            {
                MessageBox.Show("Bạn phải chọn một tệp đích khác tệp nguồn!", "Chọn tệp đích", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDestinationPath.Focus();
                return;
            }
            FileStream fsr;
            try
            {
                fsr = new FileStream(txtSourcePath.Text, FileMode.Open, FileAccess.Read);
            }
            catch
            {
                MessageBox.Show("Lỗi trong khi mở tệp nguồn!", "Mở tệp nguồn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSourcePath.Focus();
                return;
            }
            if (fsr != null)
            {
                FileStream fsw = new FileStream(txtDestinationPath.Text, FileMode.OpenOrCreate, FileAccess.Write);
                byte[] buffer;
                int blocks = 10;
                try
                {
                    buffer = new byte[blocks];            // create buffer
                    int count;                            // actual number of bytes read
                    // read until Read method returns 0 (end of the stream has been reached)
                    while ((count = fsr.Read(buffer, 0, blocks)) > 0)
                    {
                        for (int i = 0; i < count; ++i)
                            buffer[i]++;
                        f.Encrypt(ref buffer);
                        fsw.Write(buffer, 0, count);
                    }
                    MessageBox.Show("Mã hóa thành công!", "Mã hóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Có lỗi trong quá trình mã hóa!", "Mã hóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    fsr.Close();
                    fsw.Close();
                }
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            FileEcryption f;
            if (txtKey.Text == "")
            {
                MessageBox.Show("Bạn phải nhập vào một từ khóa!", "Nhập từ khóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDestinationPath.Focus();
                return;
            }
            f = new FileEcryption(txtKey.Text, (int)nudBlock.Value, (byte)nudCycle.Value, (byte)nudFrequency.Value);
            if (txtDestinationPath.Text == txtSourcePath.Text)
            {
                MessageBox.Show("Bạn phải chọn một tệp đích khác tệp nguồn!", "Chọn tệp đích", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDestinationPath.Focus();
                return;
            }
            FileStream fsr;
            try
            {
                fsr = new FileStream(txtSourcePath.Text, FileMode.Open, FileAccess.Read);
            }
            catch
            {
                MessageBox.Show("Lỗi trong khi mở tệp nguồn!", "Mở tệp nguồn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSourcePath.Focus();
                return;
            }
            if (fsr != null)
            {
                FileStream fsw;
                try
                {
                    fsw = new FileStream(txtDestinationPath.Text, FileMode.OpenOrCreate, FileAccess.Write);
                }
                catch
                {
                    MessageBox.Show("Lỗi trong khi tạo tệp đích", "Tạo tệp đích", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDestinationPath.Focus();
                    return;
                }
                byte[] buffer;
                int blocks = 10;
                try
                {
                    buffer = new byte[blocks];            // create buffer
                    int count;                            // actual number of bytes read
                    // read until Read method returns 0 (end of the stream has been reached)
                    while ((count = fsr.Read(buffer, 0, blocks)) > 0)
                    {
                        for (int i = 0; i < count; ++i)
                            buffer[i]--;
                        f.Decrypt(ref buffer);
                        fsw.Write(buffer, 0, count);
                    }
                    MessageBox.Show("Giải mã thành công!", "Giải mã", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Có lỗi trong quá trình giải mã!", "Giải mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    fsr.Close();
                    fsw.Close();
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblDestinationPath_Click(object sender, EventArgs e)
        {

        }

        private void txtDestinationPath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
