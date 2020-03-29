namespace CEPGUI.Forms
{
    partial class FrmAgent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgent));
            this.lblWarning = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.MaskedTextBox();
            this.rbtnFem = new System.Windows.Forms.RadioButton();
            this.rbtnMasc = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.passConfTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.adresseTxt = new System.Windows.Forms.TextBox();
            this.fonctionTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nomsTxt = new System.Windows.Forms.TextBox();
            this.gbAgent = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.photo = new System.Windows.Forms.PictureBox();
            this.btnParc = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbAgent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWarning
            // 
            this.lblWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(333, 64);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(349, 16);
            this.lblWarning.TabIndex = 109;
            this.lblWarning.Text = "Votre niveau d\'abilité n\'est vous permet pas d\'ajouter un agent";
            this.lblWarning.Visible = false;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Red;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(676, 10);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 41);
            this.button8.TabIndex = 112;
            this.button8.Text = "X";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 44);
            this.label1.TabIndex = 111;
            this.label1.Text = "Ajouter Agent";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.photo);
            this.groupBox4.Controls.Add(this.btnParc);
            this.groupBox4.Location = new System.Drawing.Point(13, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(243, 324);
            this.groupBox4.TabIndex = 104;
            this.groupBox4.TabStop = false;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(221, 23);
            this.label12.TabIndex = 27;
            this.label12.Text = "Informations sur l\'agent";
            // 
            // phoneTxt
            // 
            this.phoneTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.phoneTxt.Location = new System.Drawing.Point(166, 246);
            this.phoneTxt.Mask = "+243000000000";
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(279, 27);
            this.phoneTxt.TabIndex = 25;
            // 
            // rbtnFem
            // 
            this.rbtnFem.AutoSize = true;
            this.rbtnFem.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rbtnFem.Location = new System.Drawing.Point(263, 82);
            this.rbtnFem.Name = "rbtnFem";
            this.rbtnFem.Size = new System.Drawing.Size(87, 25);
            this.rbtnFem.TabIndex = 24;
            this.rbtnFem.TabStop = true;
            this.rbtnFem.Text = "Féminin";
            this.rbtnFem.UseVisualStyleBackColor = true;
            this.rbtnFem.CheckedChanged += new System.EventHandler(this.rbtnFem_CheckedChanged);
            // 
            // rbtnMasc
            // 
            this.rbtnMasc.AutoSize = true;
            this.rbtnMasc.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rbtnMasc.Location = new System.Drawing.Point(166, 82);
            this.rbtnMasc.Name = "rbtnMasc";
            this.rbtnMasc.Size = new System.Drawing.Size(96, 25);
            this.rbtnMasc.TabIndex = 23;
            this.rbtnMasc.TabStop = true;
            this.rbtnMasc.Text = "Masculin";
            this.rbtnMasc.UseVisualStyleBackColor = true;
            this.rbtnMasc.CheckedChanged += new System.EventHandler(this.rbtnMasc_CheckedChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label11.Location = new System.Drawing.Point(18, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "E-mail";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(150, 572);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(208, 44);
            this.btnSave.TabIndex = 107;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.passConfTxt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.passTxt);
            this.groupBox2.Controls.Add(this.userTxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(110, 416);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 150);
            this.groupBox2.TabIndex = 106;
            this.groupBox2.TabStop = false;
            // 
            // passConfTxt
            // 
            this.passConfTxt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.passConfTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.passConfTxt.Location = new System.Drawing.Point(127, 101);
            this.passConfTxt.Name = "passConfTxt";
            this.passConfTxt.Size = new System.Drawing.Size(328, 27);
            this.passConfTxt.TabIndex = 28;
            this.passConfTxt.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label8.Location = new System.Drawing.Point(12, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 21);
            this.label8.TabIndex = 27;
            this.label8.Text = "Confirmer";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Informations de connexion";
            // 
            // passTxt
            // 
            this.passTxt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.passTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.passTxt.Location = new System.Drawing.Point(127, 60);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(328, 27);
            this.passTxt.TabIndex = 25;
            this.passTxt.UseSystemPasswordChar = true;
            // 
            // userTxt
            // 
            this.userTxt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.userTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.userTxt.Location = new System.Drawing.Point(126, 24);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(329, 27);
            this.userTxt.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(12, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "User name";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mot de passe";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label10.Location = new System.Drawing.Point(18, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "Phone";
            // 
            // adresseTxt
            // 
            this.adresseTxt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.adresseTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.adresseTxt.Location = new System.Drawing.Point(166, 113);
            this.adresseTxt.Multiline = true;
            this.adresseTxt.Name = "adresseTxt";
            this.adresseTxt.Size = new System.Drawing.Size(279, 95);
            this.adresseTxt.TabIndex = 15;
            // 
            // fonctionTxt
            // 
            this.fonctionTxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fonctionTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.fonctionTxt.Location = new System.Drawing.Point(166, 214);
            this.fonctionTxt.Name = "fonctionTxt";
            this.fonctionTxt.Size = new System.Drawing.Size(279, 27);
            this.fonctionTxt.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label9.Location = new System.Drawing.Point(18, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Fonction";
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.emailTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.emailTxt.Location = new System.Drawing.Point(166, 279);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(279, 27);
            this.emailTxt.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(18, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Adresse";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(18, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sexe";
            // 
            // nomsTxt
            // 
            this.nomsTxt.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.nomsTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.nomsTxt.Location = new System.Drawing.Point(166, 46);
            this.nomsTxt.Name = "nomsTxt";
            this.nomsTxt.Size = new System.Drawing.Size(279, 27);
            this.nomsTxt.TabIndex = 7;
            // 
            // gbAgent
            // 
            this.gbAgent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAgent.Controls.Add(this.label12);
            this.gbAgent.Controls.Add(this.phoneTxt);
            this.gbAgent.Controls.Add(this.rbtnFem);
            this.gbAgent.Controls.Add(this.rbtnMasc);
            this.gbAgent.Controls.Add(this.label11);
            this.gbAgent.Controls.Add(this.label10);
            this.gbAgent.Controls.Add(this.adresseTxt);
            this.gbAgent.Controls.Add(this.fonctionTxt);
            this.gbAgent.Controls.Add(this.label9);
            this.gbAgent.Controls.Add(this.emailTxt);
            this.gbAgent.Controls.Add(this.label5);
            this.gbAgent.Controls.Add(this.label4);
            this.gbAgent.Controls.Add(this.label3);
            this.gbAgent.Controls.Add(this.nomsTxt);
            this.gbAgent.Location = new System.Drawing.Point(262, 86);
            this.gbAgent.Name = "gbAgent";
            this.gbAgent.Size = new System.Drawing.Size(459, 324);
            this.gbAgent.TabIndex = 105;
            this.gbAgent.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nom complet";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(364, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 44);
            this.button1.TabIndex = 108;
            this.button1.Text = "Effacer";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CEPGUI.Properties.Resources.Add_User_Group_Woman_Man_40px;
            this.pictureBox1.Location = new System.Drawing.Point(20, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(-87, 16);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(53, 64);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 110;
            this.pictureBox6.TabStop = false;
            // 
            // photo
            // 
            this.photo.Image = ((System.Drawing.Image)(resources.GetObject("photo.Image")));
            this.photo.Location = new System.Drawing.Point(7, 12);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(230, 267);
            this.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photo.TabIndex = 36;
            this.photo.TabStop = false;
            // 
            // btnParc
            // 
            this.btnParc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnParc.BackColor = System.Drawing.SystemColors.Control;
            this.btnParc.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParc.ForeColor = System.Drawing.Color.Black;
            this.btnParc.Image = ((System.Drawing.Image)(resources.GetObject("btnParc.Image")));
            this.btnParc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParc.Location = new System.Drawing.Point(63, 285);
            this.btnParc.Name = "btnParc";
            this.btnParc.Size = new System.Drawing.Size(107, 35);
            this.btnParc.TabIndex = 84;
            this.btnParc.Text = "Parcourrir";
            this.btnParc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnParc.UseVisualStyleBackColor = false;
            this.btnParc.Click += new System.EventHandler(this.btnParc_Click);
            // 
            // FrmAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 622);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbAgent);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmAgent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgent";
            this.Load += new System.EventHandler(this.FrmAgent_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbAgent.ResumeLayout(false);
            this.gbAgent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox6;
        public System.Windows.Forms.PictureBox photo;
        public System.Windows.Forms.Button btnParc;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.MaskedTextBox phoneTxt;
        public System.Windows.Forms.RadioButton rbtnFem;
        public System.Windows.Forms.RadioButton rbtnMasc;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox passConfTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox passTxt;
        public System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox adresseTxt;
        public System.Windows.Forms.TextBox fonctionTxt;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox nomsTxt;
        public System.Windows.Forms.GroupBox gbAgent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}