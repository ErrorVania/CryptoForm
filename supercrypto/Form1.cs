using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.OpenSsl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supercrypto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            hideall();
            numericUpDownAES_RandomSize.Increment = 1;
            comboBoxHASH_inputtype.SelectedItem = "String";
            comboBox_encryptordecrypt.SelectedItem = "Encrypt";
        }
        private void hideall()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel) c.Visible = false;
            }
        }

        private void aESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideall();
            panelAES.Show();
        }
        private void panelAES_Paint(object sender, PaintEventArgs e)
        {

        }
        private void comboBox_encryptordecrypt_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void buttonAES_RandomKey_Click(object sender, EventArgs e)
        {
            richTextBoxAES_Key.Text = Convert.ToBase64String(cryptoRNG.rng((int)numericUpDownAES_RandomSize.Value));
        }
        private void buttonAES_RandomIV_Click(object sender, EventArgs e)
        {
            richTextBoxAES_IV.Text = Convert.ToBase64String(cryptoRNG.rng((int)numericUpDownAES_RandomSize.Value));
        }
        private void buttonAES_GO_Click(object sender, EventArgs e)
        {

            if (panelAESfunctions.get_selectedmode(comboBox_encryptordecrypt) == panelAESfunctions.cryptomode.ENCRYPT)
            {
                richTextBoxAES_output.Text = AES.AESencrypt(richTextBoxAES_texttoencrypt.Text, richTextBoxAES_Key.Text);
            }
            if (panelAESfunctions.get_selectedmode(comboBox_encryptordecrypt) == panelAESfunctions.cryptomode.DECRYPT)
            {
                richTextBoxAES_output.Text = AES.AESdecrypt(richTextBoxAES_texttoencrypt.Text, richTextBoxAES_Key.Text);
                    
            }
        }

        private void xORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideall();
            panelXOR.Show();
        }
        private void bottonXOR_encrypt_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < (int)numericUpDownXOR_iterations.Value; i++)
                richTextBoxXOR_inout.Text = XOR.XORencrypt(richTextBoxXOR_inout.Text, textBoxXOR_pass.Text);
        }
        private void buttonXOR_decrypt_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < (int)numericUpDownXOR_iterations.Value; i++)
                richTextBoxXOR_inout.Text = XOR.XORdecrypt(richTextBoxXOR_inout.Text, textBoxXOR_pass.Text);
        }

        private void hashAlgorithmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideall();
            panelSHA.Show();
        }
        private void comboBoxHASH_inputtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (comboBoxHASH_inputtype.Text == "File")
            {
                fd.ShowDialog();
                textBoxSHA_input.Text = fd.FileName;
            }
            if (comboBoxHASH_inputtype.Text == "String")
            {
                textBoxSHA_input.Text = "";
            }
        }
        private void buttonSHA_calculate_Click(object sender, EventArgs e)
        {
            if (comboBoxHASH_inputtype.Text == "File")
            {
                byte[] inp = File.ReadAllBytes(textBoxSHA_input.Text);
                Hasher.megahash mg = new Hasher.megahash(inp);
                dataGridViewSHA_hashes.DataSource = Hasher.GetTable(mg);
            }
            if (comboBoxHASH_inputtype.Text == "String")
            {
                byte[] inp = Encoding.ASCII.GetBytes(textBoxSHA_input.Text);
                Hasher.megahash mg = new Hasher.megahash(inp);
                dataGridViewSHA_hashes.DataSource = Hasher.GetTable(mg);
            }
        }

        private void rSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideall();
            panelRSA.Show();
        }
        private void buttonRSA_genkeys_Click(object sender, EventArgs e)
        {
            AsymmetricCipherKeyPair newpair = RSA.GetKeyPair();
            richTextBoxRSA_pubkey.Text = RSA.GetPublic(newpair);
            richTextBoxRSA_privatekey.Text = RSA.GetPrivate(newpair);
        }
        private void buttonRSA_encrypt_Click(object sender, EventArgs e)
        {
            richTextBoxRSA_plaintext.Text = RSAEncryption.RsaEncryptWithPublic(richTextBoxRSA_plaintext.Text, richTextBoxRSA_pubkey.Text);
        }
        private void buttonRSA_decrypt_Click(object sender, EventArgs e)
        {
            richTextBoxRSA_plaintext.Text = RSAEncryption.RsaDecryptWithPrivate(richTextBoxRSA_plaintext.Text, richTextBoxRSA_privatekey.Text);
        }

        private void vigenereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideall();
            panelCiphers_Vigenere.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBoxVigenere_text.Text = Ciphers.Decipher(richTextBoxVigenere_text.Text, textBoxVigenere_Key.Text);
        }
        private void buttonVigenereENC_Click(object sender, EventArgs e)
        {
            richTextBoxVigenere_text.Text = Ciphers.Encipher(richTextBoxVigenere_text.Text, textBoxVigenere_Key.Text);
        }

        private void ceasarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hideall();
            panelCiphers_Ceasar.Show();
        }

        private void buttonCeasarENC_Click(object sender, EventArgs e)
        {
            richTextBoxCeasar_text.Text = Ciphers.EncipherC(richTextBoxCeasar_text.Text, Int32.Parse(textBoxCeasar_Key.Text));
        }

        private void buttonCeasarDEC_Click(object sender, EventArgs e)
        {
            richTextBoxCeasar_text.Text = Ciphers.DecipherC(richTextBoxCeasar_text.Text, Int32.Parse(textBoxCeasar_Key.Text));
        }
    }
}
