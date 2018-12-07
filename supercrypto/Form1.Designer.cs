namespace supercrypto
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelAES = new System.Windows.Forms.Panel();
            this.richTextBoxAES_output = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownAES_RandomSize = new System.Windows.Forms.NumericUpDown();
            this.buttonAES_RandomKey = new System.Windows.Forms.Button();
            this.buttonAES_GO = new System.Windows.Forms.Button();
            this.buttonAES_RandomIV = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxAES_Key = new System.Windows.Forms.RichTextBox();
            this.richTextBoxAES_IV = new System.Windows.Forms.RichTextBox();
            this.comboBox_encryptordecrypt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxAES_texttoencrypt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.algorithmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hashAlgorithmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciphersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vigenereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ceasarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelXOR = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownXOR_iterations = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxXOR_pass = new System.Windows.Forms.TextBox();
            this.buttonXOR_decrypt = new System.Windows.Forms.Button();
            this.bottonXOR_encrypt = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBoxXOR_inout = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelSHA = new System.Windows.Forms.Panel();
            this.dataGridViewSHA_hashes = new System.Windows.Forms.DataGridView();
            this.buttonSHA_calculate = new System.Windows.Forms.Button();
            this.textBoxSHA_input = new System.Windows.Forms.TextBox();
            this.comboBoxHASH_inputtype = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panelRSA = new System.Windows.Forms.Panel();
            this.buttonRSA_genkeys = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.richTextBoxRSA_privatekey = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.richTextBoxRSA_pubkey = new System.Windows.Forms.RichTextBox();
            this.buttonRSA_decrypt = new System.Windows.Forms.Button();
            this.buttonRSA_encrypt = new System.Windows.Forms.Button();
            this.richTextBoxRSA_plaintext = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panelCiphers_Vigenere = new System.Windows.Forms.Panel();
            this.buttonVigenereDEC = new System.Windows.Forms.Button();
            this.buttonVigenereENC = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxVigenere_Key = new System.Windows.Forms.TextBox();
            this.richTextBoxVigenere_text = new System.Windows.Forms.RichTextBox();
            this.Input = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panelCiphers_Ceasar = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.richTextBoxCeasar_text = new System.Windows.Forms.RichTextBox();
            this.textBoxCeasar_Key = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.buttonCeasarENC = new System.Windows.Forms.Button();
            this.buttonCeasarDEC = new System.Windows.Forms.Button();
            this.panelAES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAES_RandomSize)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelXOR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXOR_iterations)).BeginInit();
            this.panelSHA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSHA_hashes)).BeginInit();
            this.panelRSA.SuspendLayout();
            this.panelCiphers_Vigenere.SuspendLayout();
            this.panelCiphers_Ceasar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAES
            // 
            this.panelAES.Controls.Add(this.richTextBoxAES_output);
            this.panelAES.Controls.Add(this.label6);
            this.panelAES.Controls.Add(this.label5);
            this.panelAES.Controls.Add(this.numericUpDownAES_RandomSize);
            this.panelAES.Controls.Add(this.buttonAES_RandomKey);
            this.panelAES.Controls.Add(this.buttonAES_GO);
            this.panelAES.Controls.Add(this.buttonAES_RandomIV);
            this.panelAES.Controls.Add(this.label4);
            this.panelAES.Controls.Add(this.label3);
            this.panelAES.Controls.Add(this.richTextBoxAES_Key);
            this.panelAES.Controls.Add(this.richTextBoxAES_IV);
            this.panelAES.Controls.Add(this.comboBox_encryptordecrypt);
            this.panelAES.Controls.Add(this.label2);
            this.panelAES.Controls.Add(this.richTextBoxAES_texttoencrypt);
            this.panelAES.Controls.Add(this.label1);
            this.panelAES.Location = new System.Drawing.Point(13, 31);
            this.panelAES.Name = "panelAES";
            this.panelAES.Size = new System.Drawing.Size(775, 407);
            this.panelAES.TabIndex = 0;
            this.panelAES.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAES_Paint);
            // 
            // richTextBoxAES_output
            // 
            this.richTextBoxAES_output.Location = new System.Drawing.Point(243, 196);
            this.richTextBoxAES_output.Name = "richTextBoxAES_output";
            this.richTextBoxAES_output.Size = new System.Drawing.Size(529, 208);
            this.richTextBoxAES_output.TabIndex = 15;
            this.richTextBoxAES_output.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Output:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Random Size:";
            // 
            // numericUpDownAES_RandomSize
            // 
            this.numericUpDownAES_RandomSize.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownAES_RandomSize.Location = new System.Drawing.Point(10, 349);
            this.numericUpDownAES_RandomSize.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.numericUpDownAES_RandomSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAES_RandomSize.Name = "numericUpDownAES_RandomSize";
            this.numericUpDownAES_RandomSize.Size = new System.Drawing.Size(206, 20);
            this.numericUpDownAES_RandomSize.TabIndex = 12;
            this.numericUpDownAES_RandomSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // buttonAES_RandomKey
            // 
            this.buttonAES_RandomKey.Location = new System.Drawing.Point(116, 299);
            this.buttonAES_RandomKey.Name = "buttonAES_RandomKey";
            this.buttonAES_RandomKey.Size = new System.Drawing.Size(100, 23);
            this.buttonAES_RandomKey.TabIndex = 11;
            this.buttonAES_RandomKey.Text = "Random Key";
            this.buttonAES_RandomKey.UseVisualStyleBackColor = true;
            this.buttonAES_RandomKey.Click += new System.EventHandler(this.buttonAES_RandomKey_Click);
            // 
            // buttonAES_GO
            // 
            this.buttonAES_GO.Location = new System.Drawing.Point(141, 35);
            this.buttonAES_GO.Name = "buttonAES_GO";
            this.buttonAES_GO.Size = new System.Drawing.Size(75, 23);
            this.buttonAES_GO.TabIndex = 10;
            this.buttonAES_GO.Text = "Go!";
            this.buttonAES_GO.UseVisualStyleBackColor = true;
            this.buttonAES_GO.Click += new System.EventHandler(this.buttonAES_GO_Click);
            // 
            // buttonAES_RandomIV
            // 
            this.buttonAES_RandomIV.Location = new System.Drawing.Point(10, 299);
            this.buttonAES_RandomIV.Name = "buttonAES_RandomIV";
            this.buttonAES_RandomIV.Size = new System.Drawing.Size(100, 23);
            this.buttonAES_RandomIV.TabIndex = 9;
            this.buttonAES_RandomIV.Text = "Random IV";
            this.buttonAES_RandomIV.UseVisualStyleBackColor = true;
            this.buttonAES_RandomIV.Click += new System.EventHandler(this.buttonAES_RandomIV_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Key (BASE64):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "IV (Not Implemented):";
            // 
            // richTextBoxAES_Key
            // 
            this.richTextBoxAES_Key.Location = new System.Drawing.Point(116, 197);
            this.richTextBoxAES_Key.MaxLength = 4906;
            this.richTextBoxAES_Key.Name = "richTextBoxAES_Key";
            this.richTextBoxAES_Key.Size = new System.Drawing.Size(100, 96);
            this.richTextBoxAES_Key.TabIndex = 6;
            this.richTextBoxAES_Key.Text = "";
            // 
            // richTextBoxAES_IV
            // 
            this.richTextBoxAES_IV.Location = new System.Drawing.Point(10, 198);
            this.richTextBoxAES_IV.MaxLength = 4096;
            this.richTextBoxAES_IV.Name = "richTextBoxAES_IV";
            this.richTextBoxAES_IV.Size = new System.Drawing.Size(100, 96);
            this.richTextBoxAES_IV.TabIndex = 5;
            this.richTextBoxAES_IV.Text = "";
            // 
            // comboBox_encryptordecrypt
            // 
            this.comboBox_encryptordecrypt.FormattingEnabled = true;
            this.comboBox_encryptordecrypt.Items.AddRange(new object[] {
            "Encrypt",
            "Decrypt"});
            this.comboBox_encryptordecrypt.Location = new System.Drawing.Point(50, 35);
            this.comboBox_encryptordecrypt.Name = "comboBox_encryptordecrypt";
            this.comboBox_encryptordecrypt.Size = new System.Drawing.Size(85, 21);
            this.comboBox_encryptordecrypt.TabIndex = 4;
            this.comboBox_encryptordecrypt.SelectedIndexChanged += new System.EventHandler(this.comboBox_encryptordecrypt_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mode:";
            // 
            // richTextBoxAES_texttoencrypt
            // 
            this.richTextBoxAES_texttoencrypt.Location = new System.Drawing.Point(7, 58);
            this.richTextBoxAES_texttoencrypt.Name = "richTextBoxAES_texttoencrypt";
            this.richTextBoxAES_texttoencrypt.Size = new System.Drawing.Size(765, 96);
            this.richTextBoxAES_texttoencrypt.TabIndex = 2;
            this.richTextBoxAES_texttoencrypt.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "###_Inputs_###";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algorithmsToolStripMenuItem,
            this.ciphersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // algorithmsToolStripMenuItem
            // 
            this.algorithmsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aESToolStripMenuItem,
            this.xORToolStripMenuItem,
            this.hashAlgorithmsToolStripMenuItem,
            this.rSAToolStripMenuItem});
            this.algorithmsToolStripMenuItem.Name = "algorithmsToolStripMenuItem";
            this.algorithmsToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.algorithmsToolStripMenuItem.Text = "Algorithms";
            // 
            // aESToolStripMenuItem
            // 
            this.aESToolStripMenuItem.Name = "aESToolStripMenuItem";
            this.aESToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.aESToolStripMenuItem.Text = "AES";
            this.aESToolStripMenuItem.Click += new System.EventHandler(this.aESToolStripMenuItem_Click);
            // 
            // xORToolStripMenuItem
            // 
            this.xORToolStripMenuItem.Name = "xORToolStripMenuItem";
            this.xORToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.xORToolStripMenuItem.Text = "XOR";
            this.xORToolStripMenuItem.Click += new System.EventHandler(this.xORToolStripMenuItem_Click);
            // 
            // hashAlgorithmsToolStripMenuItem
            // 
            this.hashAlgorithmsToolStripMenuItem.Name = "hashAlgorithmsToolStripMenuItem";
            this.hashAlgorithmsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.hashAlgorithmsToolStripMenuItem.Text = "Hash Algorithms";
            this.hashAlgorithmsToolStripMenuItem.Click += new System.EventHandler(this.hashAlgorithmsToolStripMenuItem_Click);
            // 
            // rSAToolStripMenuItem
            // 
            this.rSAToolStripMenuItem.Name = "rSAToolStripMenuItem";
            this.rSAToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.rSAToolStripMenuItem.Text = "RSA";
            this.rSAToolStripMenuItem.Click += new System.EventHandler(this.rSAToolStripMenuItem_Click);
            // 
            // ciphersToolStripMenuItem
            // 
            this.ciphersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vigenereToolStripMenuItem,
            this.ceasarToolStripMenuItem});
            this.ciphersToolStripMenuItem.Name = "ciphersToolStripMenuItem";
            this.ciphersToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.ciphersToolStripMenuItem.Text = "Ciphers";
            // 
            // vigenereToolStripMenuItem
            // 
            this.vigenereToolStripMenuItem.Name = "vigenereToolStripMenuItem";
            this.vigenereToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vigenereToolStripMenuItem.Text = "Vigenere";
            this.vigenereToolStripMenuItem.Click += new System.EventHandler(this.vigenereToolStripMenuItem_Click);
            // 
            // ceasarToolStripMenuItem
            // 
            this.ceasarToolStripMenuItem.Name = "ceasarToolStripMenuItem";
            this.ceasarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ceasarToolStripMenuItem.Text = "Ceasar";
            this.ceasarToolStripMenuItem.Click += new System.EventHandler(this.ceasarToolStripMenuItem_Click);
            // 
            // panelXOR
            // 
            this.panelXOR.Controls.Add(this.label10);
            this.panelXOR.Controls.Add(this.numericUpDownXOR_iterations);
            this.panelXOR.Controls.Add(this.label9);
            this.panelXOR.Controls.Add(this.textBoxXOR_pass);
            this.panelXOR.Controls.Add(this.buttonXOR_decrypt);
            this.panelXOR.Controls.Add(this.bottonXOR_encrypt);
            this.panelXOR.Controls.Add(this.label8);
            this.panelXOR.Controls.Add(this.richTextBoxXOR_inout);
            this.panelXOR.Controls.Add(this.label7);
            this.panelXOR.Location = new System.Drawing.Point(13, 31);
            this.panelXOR.Name = "panelXOR";
            this.panelXOR.Size = new System.Drawing.Size(775, 404);
            this.panelXOR.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Iterations:";
            // 
            // numericUpDownXOR_iterations
            // 
            this.numericUpDownXOR_iterations.Location = new System.Drawing.Point(6, 299);
            this.numericUpDownXOR_iterations.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numericUpDownXOR_iterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownXOR_iterations.Name = "numericUpDownXOR_iterations";
            this.numericUpDownXOR_iterations.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownXOR_iterations.TabIndex = 7;
            this.numericUpDownXOR_iterations.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Key:";
            // 
            // textBoxXOR_pass
            // 
            this.textBoxXOR_pass.Location = new System.Drawing.Point(3, 228);
            this.textBoxXOR_pass.MaxLength = 1024;
            this.textBoxXOR_pass.Name = "textBoxXOR_pass";
            this.textBoxXOR_pass.Size = new System.Drawing.Size(769, 20);
            this.textBoxXOR_pass.TabIndex = 5;
            // 
            // buttonXOR_decrypt
            // 
            this.buttonXOR_decrypt.Location = new System.Drawing.Point(388, 156);
            this.buttonXOR_decrypt.Name = "buttonXOR_decrypt";
            this.buttonXOR_decrypt.Size = new System.Drawing.Size(384, 23);
            this.buttonXOR_decrypt.TabIndex = 4;
            this.buttonXOR_decrypt.Text = "Decrypt";
            this.buttonXOR_decrypt.UseVisualStyleBackColor = true;
            this.buttonXOR_decrypt.Click += new System.EventHandler(this.buttonXOR_decrypt_Click);
            // 
            // bottonXOR_encrypt
            // 
            this.bottonXOR_encrypt.Location = new System.Drawing.Point(3, 156);
            this.bottonXOR_encrypt.Name = "bottonXOR_encrypt";
            this.bottonXOR_encrypt.Size = new System.Drawing.Size(384, 23);
            this.bottonXOR_encrypt.TabIndex = 3;
            this.bottonXOR_encrypt.Text = "Encrypt";
            this.bottonXOR_encrypt.UseVisualStyleBackColor = true;
            this.bottonXOR_encrypt.Click += new System.EventHandler(this.bottonXOR_encrypt_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Text:";
            // 
            // richTextBoxXOR_inout
            // 
            this.richTextBoxXOR_inout.Location = new System.Drawing.Point(3, 54);
            this.richTextBoxXOR_inout.Name = "richTextBoxXOR_inout";
            this.richTextBoxXOR_inout.Size = new System.Drawing.Size(769, 96);
            this.richTextBoxXOR_inout.TabIndex = 1;
            this.richTextBoxXOR_inout.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "####_Inputs_####";
            // 
            // panelSHA
            // 
            this.panelSHA.Controls.Add(this.dataGridViewSHA_hashes);
            this.panelSHA.Controls.Add(this.buttonSHA_calculate);
            this.panelSHA.Controls.Add(this.textBoxSHA_input);
            this.panelSHA.Controls.Add(this.comboBoxHASH_inputtype);
            this.panelSHA.Controls.Add(this.label12);
            this.panelSHA.Controls.Add(this.label11);
            this.panelSHA.Location = new System.Drawing.Point(12, 31);
            this.panelSHA.Name = "panelSHA";
            this.panelSHA.Size = new System.Drawing.Size(776, 407);
            this.panelSHA.TabIndex = 9;
            // 
            // dataGridViewSHA_hashes
            // 
            this.dataGridViewSHA_hashes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSHA_hashes.Location = new System.Drawing.Point(6, 157);
            this.dataGridViewSHA_hashes.Name = "dataGridViewSHA_hashes";
            this.dataGridViewSHA_hashes.Size = new System.Drawing.Size(767, 244);
            this.dataGridViewSHA_hashes.TabIndex = 5;
            // 
            // buttonSHA_calculate
            // 
            this.buttonSHA_calculate.Location = new System.Drawing.Point(6, 131);
            this.buttonSHA_calculate.Name = "buttonSHA_calculate";
            this.buttonSHA_calculate.Size = new System.Drawing.Size(195, 23);
            this.buttonSHA_calculate.TabIndex = 4;
            this.buttonSHA_calculate.Text = "Caculate Hashes";
            this.buttonSHA_calculate.UseVisualStyleBackColor = true;
            this.buttonSHA_calculate.Click += new System.EventHandler(this.buttonSHA_calculate_Click);
            // 
            // textBoxSHA_input
            // 
            this.textBoxSHA_input.Location = new System.Drawing.Point(6, 110);
            this.textBoxSHA_input.Name = "textBoxSHA_input";
            this.textBoxSHA_input.Size = new System.Drawing.Size(195, 20);
            this.textBoxSHA_input.TabIndex = 3;
            // 
            // comboBoxHASH_inputtype
            // 
            this.comboBoxHASH_inputtype.FormattingEnabled = true;
            this.comboBoxHASH_inputtype.Items.AddRange(new object[] {
            "File",
            "String"});
            this.comboBoxHASH_inputtype.Location = new System.Drawing.Point(80, 83);
            this.comboBoxHASH_inputtype.Name = "comboBoxHASH_inputtype";
            this.comboBoxHASH_inputtype.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHASH_inputtype.TabIndex = 2;
            this.comboBoxHASH_inputtype.SelectedIndexChanged += new System.EventHandler(this.comboBoxHASH_inputtype_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Input Type ->";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "####_Input_###";
            // 
            // panelRSA
            // 
            this.panelRSA.Controls.Add(this.buttonRSA_genkeys);
            this.panelRSA.Controls.Add(this.label15);
            this.panelRSA.Controls.Add(this.richTextBoxRSA_privatekey);
            this.panelRSA.Controls.Add(this.label14);
            this.panelRSA.Controls.Add(this.richTextBoxRSA_pubkey);
            this.panelRSA.Controls.Add(this.buttonRSA_decrypt);
            this.panelRSA.Controls.Add(this.buttonRSA_encrypt);
            this.panelRSA.Controls.Add(this.richTextBoxRSA_plaintext);
            this.panelRSA.Controls.Add(this.label13);
            this.panelRSA.Location = new System.Drawing.Point(12, 31);
            this.panelRSA.Name = "panelRSA";
            this.panelRSA.Size = new System.Drawing.Size(776, 410);
            this.panelRSA.TabIndex = 6;
            // 
            // buttonRSA_genkeys
            // 
            this.buttonRSA_genkeys.Location = new System.Drawing.Point(1, 381);
            this.buttonRSA_genkeys.Name = "buttonRSA_genkeys";
            this.buttonRSA_genkeys.Size = new System.Drawing.Size(772, 23);
            this.buttonRSA_genkeys.TabIndex = 8;
            this.buttonRSA_genkeys.Text = "Generate Keys";
            this.buttonRSA_genkeys.UseVisualStyleBackColor = true;
            this.buttonRSA_genkeys.Click += new System.EventHandler(this.buttonRSA_genkeys_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(389, 209);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(150, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Private Key: (Used to Decrypt)";
            // 
            // richTextBoxRSA_privatekey
            // 
            this.richTextBoxRSA_privatekey.Location = new System.Drawing.Point(389, 228);
            this.richTextBoxRSA_privatekey.Name = "richTextBoxRSA_privatekey";
            this.richTextBoxRSA_privatekey.Size = new System.Drawing.Size(386, 151);
            this.richTextBoxRSA_privatekey.TabIndex = 6;
            this.richTextBoxRSA_privatekey.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1, 209);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(145, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Public Key: (Used to Encrypt)";
            // 
            // richTextBoxRSA_pubkey
            // 
            this.richTextBoxRSA_pubkey.Location = new System.Drawing.Point(1, 228);
            this.richTextBoxRSA_pubkey.Name = "richTextBoxRSA_pubkey";
            this.richTextBoxRSA_pubkey.Size = new System.Drawing.Size(386, 151);
            this.richTextBoxRSA_pubkey.TabIndex = 4;
            this.richTextBoxRSA_pubkey.Text = "";
            // 
            // buttonRSA_decrypt
            // 
            this.buttonRSA_decrypt.Location = new System.Drawing.Point(389, 171);
            this.buttonRSA_decrypt.Name = "buttonRSA_decrypt";
            this.buttonRSA_decrypt.Size = new System.Drawing.Size(386, 23);
            this.buttonRSA_decrypt.TabIndex = 3;
            this.buttonRSA_decrypt.Text = "Decrypt";
            this.buttonRSA_decrypt.UseVisualStyleBackColor = true;
            this.buttonRSA_decrypt.Click += new System.EventHandler(this.buttonRSA_decrypt_Click);
            // 
            // buttonRSA_encrypt
            // 
            this.buttonRSA_encrypt.Location = new System.Drawing.Point(1, 171);
            this.buttonRSA_encrypt.Name = "buttonRSA_encrypt";
            this.buttonRSA_encrypt.Size = new System.Drawing.Size(386, 23);
            this.buttonRSA_encrypt.TabIndex = 2;
            this.buttonRSA_encrypt.Text = "Encrypt";
            this.buttonRSA_encrypt.UseVisualStyleBackColor = true;
            this.buttonRSA_encrypt.Click += new System.EventHandler(this.buttonRSA_encrypt_Click);
            // 
            // richTextBoxRSA_plaintext
            // 
            this.richTextBoxRSA_plaintext.Location = new System.Drawing.Point(1, 16);
            this.richTextBoxRSA_plaintext.Name = "richTextBoxRSA_plaintext";
            this.richTextBoxRSA_plaintext.Size = new System.Drawing.Size(772, 148);
            this.richTextBoxRSA_plaintext.TabIndex = 1;
            this.richTextBoxRSA_plaintext.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "####_Input_####";
            // 
            // panelCiphers_Vigenere
            // 
            this.panelCiphers_Vigenere.Controls.Add(this.buttonVigenereDEC);
            this.panelCiphers_Vigenere.Controls.Add(this.buttonVigenereENC);
            this.panelCiphers_Vigenere.Controls.Add(this.label18);
            this.panelCiphers_Vigenere.Controls.Add(this.textBoxVigenere_Key);
            this.panelCiphers_Vigenere.Controls.Add(this.richTextBoxVigenere_text);
            this.panelCiphers_Vigenere.Controls.Add(this.Input);
            this.panelCiphers_Vigenere.Controls.Add(this.label16);
            this.panelCiphers_Vigenere.Location = new System.Drawing.Point(12, 34);
            this.panelCiphers_Vigenere.Name = "panelCiphers_Vigenere";
            this.panelCiphers_Vigenere.Size = new System.Drawing.Size(776, 401);
            this.panelCiphers_Vigenere.TabIndex = 9;
            // 
            // buttonVigenereDEC
            // 
            this.buttonVigenereDEC.Location = new System.Drawing.Point(3, 332);
            this.buttonVigenereDEC.Name = "buttonVigenereDEC";
            this.buttonVigenereDEC.Size = new System.Drawing.Size(770, 23);
            this.buttonVigenereDEC.TabIndex = 6;
            this.buttonVigenereDEC.Text = "Decipher";
            this.buttonVigenereDEC.UseVisualStyleBackColor = true;
            this.buttonVigenereDEC.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonVigenereENC
            // 
            this.buttonVigenereENC.Location = new System.Drawing.Point(3, 303);
            this.buttonVigenereENC.Name = "buttonVigenereENC";
            this.buttonVigenereENC.Size = new System.Drawing.Size(770, 23);
            this.buttonVigenereENC.TabIndex = 5;
            this.buttonVigenereENC.Text = "Encipher";
            this.buttonVigenereENC.UseVisualStyleBackColor = true;
            this.buttonVigenereENC.Click += new System.EventHandler(this.buttonVigenereENC_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 260);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(158, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Key: (May not contain numerals)";
            // 
            // textBoxVigenere_Key
            // 
            this.textBoxVigenere_Key.Location = new System.Drawing.Point(3, 276);
            this.textBoxVigenere_Key.Name = "textBoxVigenere_Key";
            this.textBoxVigenere_Key.Size = new System.Drawing.Size(770, 20);
            this.textBoxVigenere_Key.TabIndex = 3;
            // 
            // richTextBoxVigenere_text
            // 
            this.richTextBoxVigenere_text.Location = new System.Drawing.Point(3, 49);
            this.richTextBoxVigenere_text.Name = "richTextBoxVigenere_text";
            this.richTextBoxVigenere_text.Size = new System.Drawing.Size(770, 196);
            this.richTextBoxVigenere_text.TabIndex = 2;
            this.richTextBoxVigenere_text.Text = "";
            // 
            // Input
            // 
            this.Input.AutoSize = true;
            this.Input.Location = new System.Drawing.Point(3, 31);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(34, 13);
            this.Input.TabIndex = 1;
            this.Input.Text = "Input:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "####_Inputs_####";
            // 
            // panelCiphers_Ceasar
            // 
            this.panelCiphers_Ceasar.Controls.Add(this.buttonCeasarDEC);
            this.panelCiphers_Ceasar.Controls.Add(this.buttonCeasarENC);
            this.panelCiphers_Ceasar.Controls.Add(this.label20);
            this.panelCiphers_Ceasar.Controls.Add(this.textBoxCeasar_Key);
            this.panelCiphers_Ceasar.Controls.Add(this.richTextBoxCeasar_text);
            this.panelCiphers_Ceasar.Controls.Add(this.label19);
            this.panelCiphers_Ceasar.Controls.Add(this.label17);
            this.panelCiphers_Ceasar.Location = new System.Drawing.Point(15, 31);
            this.panelCiphers_Ceasar.Name = "panelCiphers_Ceasar";
            this.panelCiphers_Ceasar.Size = new System.Drawing.Size(775, 410);
            this.panelCiphers_Ceasar.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(0, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "####_Input_####";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 44);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Input:";
            // 
            // richTextBoxCeasar_text
            // 
            this.richTextBoxCeasar_text.Location = new System.Drawing.Point(3, 60);
            this.richTextBoxCeasar_text.Name = "richTextBoxCeasar_text";
            this.richTextBoxCeasar_text.Size = new System.Drawing.Size(767, 239);
            this.richTextBoxCeasar_text.TabIndex = 2;
            this.richTextBoxCeasar_text.Text = "";
            // 
            // textBoxCeasar_Key
            // 
            this.textBoxCeasar_Key.Location = new System.Drawing.Point(2, 329);
            this.textBoxCeasar_Key.Name = "textBoxCeasar_Key";
            this.textBoxCeasar_Key.Size = new System.Drawing.Size(767, 20);
            this.textBoxCeasar_Key.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 309);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(162, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "Key: (May only contain numerals)";
            // 
            // buttonCeasarENC
            // 
            this.buttonCeasarENC.Location = new System.Drawing.Point(4, 356);
            this.buttonCeasarENC.Name = "buttonCeasarENC";
            this.buttonCeasarENC.Size = new System.Drawing.Size(765, 23);
            this.buttonCeasarENC.TabIndex = 5;
            this.buttonCeasarENC.Text = "Encipher";
            this.buttonCeasarENC.UseVisualStyleBackColor = true;
            this.buttonCeasarENC.Click += new System.EventHandler(this.buttonCeasarENC_Click);
            // 
            // buttonCeasarDEC
            // 
            this.buttonCeasarDEC.Location = new System.Drawing.Point(4, 381);
            this.buttonCeasarDEC.Name = "buttonCeasarDEC";
            this.buttonCeasarDEC.Size = new System.Drawing.Size(765, 23);
            this.buttonCeasarDEC.TabIndex = 6;
            this.buttonCeasarDEC.Text = "Decipher";
            this.buttonCeasarDEC.UseVisualStyleBackColor = true;
            this.buttonCeasarDEC.Click += new System.EventHandler(this.buttonCeasarDEC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCiphers_Ceasar);
            this.Controls.Add(this.panelCiphers_Vigenere);
            this.Controls.Add(this.panelRSA);
            this.Controls.Add(this.panelSHA);
            this.Controls.Add(this.panelXOR);
            this.Controls.Add(this.panelAES);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelAES.ResumeLayout(false);
            this.panelAES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAES_RandomSize)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelXOR.ResumeLayout(false);
            this.panelXOR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXOR_iterations)).EndInit();
            this.panelSHA.ResumeLayout(false);
            this.panelSHA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSHA_hashes)).EndInit();
            this.panelRSA.ResumeLayout(false);
            this.panelRSA.PerformLayout();
            this.panelCiphers_Vigenere.ResumeLayout(false);
            this.panelCiphers_Vigenere.PerformLayout();
            this.panelCiphers_Ceasar.ResumeLayout(false);
            this.panelCiphers_Ceasar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAES;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem algorithmsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aESToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxAES_texttoencrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_encryptordecrypt;
        private System.Windows.Forms.RichTextBox richTextBoxAES_Key;
        private System.Windows.Forms.RichTextBox richTextBoxAES_IV;
        private System.Windows.Forms.Button buttonAES_RandomKey;
        private System.Windows.Forms.Button buttonAES_GO;
        private System.Windows.Forms.Button buttonAES_RandomIV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownAES_RandomSize;
        private System.Windows.Forms.RichTextBox richTextBoxAES_output;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelXOR;
        private System.Windows.Forms.ToolStripMenuItem xORToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonXOR_decrypt;
        private System.Windows.Forms.Button bottonXOR_encrypt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBoxXOR_inout;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxXOR_pass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDownXOR_iterations;
        private System.Windows.Forms.Panel panelSHA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem hashAlgorithmsToolStripMenuItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxHASH_inputtype;
        private System.Windows.Forms.TextBox textBoxSHA_input;
        private System.Windows.Forms.Button buttonSHA_calculate;
        private System.Windows.Forms.DataGridView dataGridViewSHA_hashes;
        private System.Windows.Forms.Panel panelRSA;
        private System.Windows.Forms.Button buttonRSA_decrypt;
        private System.Windows.Forms.Button buttonRSA_encrypt;
        private System.Windows.Forms.RichTextBox richTextBoxRSA_plaintext;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox richTextBoxRSA_pubkey;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox richTextBoxRSA_privatekey;
        private System.Windows.Forms.Button buttonRSA_genkeys;
        private System.Windows.Forms.ToolStripMenuItem rSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciphersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vigenereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ceasarToolStripMenuItem;
        private System.Windows.Forms.Panel panelCiphers_Vigenere;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxVigenere_Key;
        private System.Windows.Forms.RichTextBox richTextBoxVigenere_text;
        private System.Windows.Forms.Label Input;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonVigenereDEC;
        private System.Windows.Forms.Button buttonVigenereENC;
        private System.Windows.Forms.Panel panelCiphers_Ceasar;
        private System.Windows.Forms.Button buttonCeasarDEC;
        private System.Windows.Forms.Button buttonCeasarENC;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxCeasar_Key;
        private System.Windows.Forms.RichTextBox richTextBoxCeasar_text;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
    }
}

