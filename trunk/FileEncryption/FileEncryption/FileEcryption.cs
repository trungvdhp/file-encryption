using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FileEncryption
{
    class FileEcryption
    {
        int[] arrKey;
        int block;
        byte cycle;
        byte frequency;

        public int[] Key
        {
            get { return arrKey; }
            set { arrKey = value; }
        }

        public int Block
        {
            get { return block; }
            set { block = value; }
        }

        public byte Cycle
        {
            get { return cycle; }
            set { cycle = value; }
        }

        public byte Frequency
        {
            get { return frequency; }
            set { frequency = value; }
        }

        public FileEcryption(String strKey, int block, byte cycle, byte frequency)
        {
            long a;
            int k = 2, b;
            int n = strKey.Length;
            arrKey = new int[n * cycle + 2];
            arrKey[0] = 0;
            arrKey[1] = block - 1;
            Block = block;
            Cycle = cycle;
            Frequency = frequency;
            for (int i = 0; i < n; ++i)
            {
                a = (long)Math.Pow((double)strKey[i], cycle);
                for (int j = 0; j < cycle; ++j)
                {
                    b = (int)(a % block);
                    if (b != arrKey[k - 1] && b != arrKey[k - 2])
                        arrKey[k++] = b;
                    else arrKey[k++] = (int)((a + cycle) % block);
                    a /= block;
                }
            }
            /*String s = "";
            for (int i = 0; i < arrKey.Length; ++i)
            {
                s += " " + arrKey[i];
            }
            MessageBox.Show(s);*/
        }
        public void Encrypt(ref byte[] buffer)
        {
            int len = buffer.Length;
            int k = arrKey.Length - 1;
            byte tmp;
            int t1, t2;
            for (int u = 0; u < frequency; ++u)
            {
                for (int i = 0; i < k; ++i)
                {
                    t1 = arrKey[i];
                    t2 = arrKey[i + 1];
                    if (t1 >= len) t1 = len - 1;
                    if (t2 >= len) t2 = len - 2;
                    tmp = buffer[t1];
                    buffer[t1] = buffer[t2];
                    buffer[t2] = tmp;
                }
            }
        }

        public void Decrypt(ref byte[] buffer)
        {
            int len = buffer.Length;
            int k = arrKey.Length - 1;
            byte tmp;
            int t1, t2;
            for (int u = 0; u < frequency; ++u)
            {
                for (int i = k; i >0; --i)
                {
                    t1 = arrKey[i];
                    t2 = arrKey[i - 1];
                    if (t1 >= len) t1 = len - 2;
                    if (t2 >= len) t2 = len - 1;
                    tmp = buffer[t1];
                    buffer[t1] = buffer[t2];
                    buffer[t2] = tmp;
                }
            }
        }
        
    }
}
