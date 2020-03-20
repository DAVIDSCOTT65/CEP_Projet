namespace CEPGUI.Forms
{
    partial class FrmEglise
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEglise));
            this.btnSave = new System.Windows.Forms.Button();
            this.dgMaison = new System.Windows.Forms.DataGridView();
            this.phone3 = new System.Windows.Forms.MaskedTextBox();
            this.phone2 = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.accroTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.siteTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mailTxt = new System.Windows.Forms.TextBox();
            this.commTxt = new System.Windows.Forms.TextBox();
            this.nomTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnParc = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgMaison)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(270, 458);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(208, 44);
            this.btnSave.TabIndex = 172;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgMaison
            // 
            this.dgMaison.AllowUserToAddRows = false;
            this.dgMaison.AllowUserToDeleteRows = false;
            this.dgMaison.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgMaison.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMaison.BackgroundColor = System.Drawing.Color.White;
            this.dgMaison.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMaison.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgMaison.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMaison.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColNom,
            this.ColCom,
            this.ColAcro,
            this.ColAdd,
            this.ColPhone,
            this.ColPhone2,
            this.ColEmail,
            this.ColSite,
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMaison.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgMaison.Location = new System.Drawing.Point(13, 508);
            this.dgMaison.Name = "dgMaison";
            this.dgMaison.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMaison.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgMaison.RowHeadersVisible = false;
            this.dgMaison.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMaison.Size = new System.Drawing.Size(708, 90);
            this.dgMaison.TabIndex = 173;
            this.dgMaison.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMaison_CellContentClick);
            this.dgMaison.SelectionChanged += new System.EventHandler(this.dgMaison_SelectionChanged);
            // 
            // phone3
            // 
            this.phone3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.phone3.Location = new System.Drawing.Point(397, 214);
            this.phone3.Mask = "+256000000000";
            this.phone3.Name = "phone3";
            this.phone3.Size = new System.Drawing.Size(112, 27);
            this.phone3.TabIndex = 88;
            // 
            // phone2
            // 
            this.phone2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.phone2.Location = new System.Drawing.Point(269, 213);
            this.phone2.Mask = "+243000000000";
            this.phone2.Name = "phone2";
            this.phone2.Size = new System.Drawing.Size(122, 27);
            this.phone2.TabIndex = 87;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label12.Location = new System.Drawing.Point(6, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 21);
            this.label12.TabIndex = 86;
            this.label12.Text = "Details";
            // 
            // phoneTxt
            // 
            this.phoneTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.phoneTxt.Location = new System.Drawing.Point(141, 213);
            this.phoneTxt.Mask = "+243000000000";
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(122, 27);
            this.phoneTxt.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label11.Location = new System.Drawing.Point(29, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 21);
            this.label11.TabIndex = 35;
            this.label11.Text = "Téléphones :";
            // 
            // accroTxt
            // 
            this.accroTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accroTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.accroTxt.Location = new System.Drawing.Point(140, 101);
            this.accroTxt.Name = "accroTxt";
            this.accroTxt.Size = new System.Drawing.Size(369, 27);
            this.accroTxt.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label8.Location = new System.Drawing.Point(28, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 21);
            this.label8.TabIndex = 29;
            this.label8.Text = "Accronyme :";
            // 
            // siteTxt
            // 
            this.siteTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siteTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.siteTxt.Location = new System.Drawing.Point(140, 280);
            this.siteTxt.Name = "siteTxt";
            this.siteTxt.Size = new System.Drawing.Size(369, 27);
            this.siteTxt.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(48, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Site Web :";
            // 
            // mailTxt
            // 
            this.mailTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.mailTxt.Location = new System.Drawing.Point(140, 247);
            this.mailTxt.Name = "mailTxt";
            this.mailTxt.Size = new System.Drawing.Size(369, 27);
            this.mailTxt.TabIndex = 24;
            // 
            // commTxt
            // 
            this.commTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.commTxt.Location = new System.Drawing.Point(140, 68);
            this.commTxt.Name = "commTxt";
            this.commTxt.Size = new System.Drawing.Size(369, 27);
            this.commTxt.TabIndex = 23;
            // 
            // nomTxt
            // 
            this.nomTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.nomTxt.Location = new System.Drawing.Point(140, 37);
            this.nomTxt.Name = "nomTxt";
            this.nomTxt.Size = new System.Drawing.Size(369, 27);
            this.nomTxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(82, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nom :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label13.Location = new System.Drawing.Point(10, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "Communauté :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.phone3);
            this.groupBox1.Controls.Add(this.phone2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.phoneTxt);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.accroTxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.siteTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.mailTxt);
            this.groupBox1.Controls.Add(this.commTxt);
            this.groupBox1.Controls.Add(this.nomTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(181, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 324);
            this.groupBox1.TabIndex = 171;
            this.groupBox1.TabStop = false;
            // 
            // addTxt
            // 
            this.addTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.addTxt.Location = new System.Drawing.Point(140, 134);
            this.addTxt.Multiline = true;
            this.addTxt.Name = "addTxt";
            this.addTxt.Size = new System.Drawing.Size(369, 73);
            this.addTxt.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(56, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 89;
            this.label2.Text = "Adresse :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(85, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mail :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(6, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 85;
            this.label4.Text = "Logo";
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(7, 26);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(149, 208);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 36;
            this.logo.TabStop = false;
            // 
            // btnParc
            // 
            this.btnParc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnParc.BackColor = System.Drawing.SystemColors.Control;
            this.btnParc.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParc.ForeColor = System.Drawing.Color.Black;
            this.btnParc.Image = ((System.Drawing.Image)(resources.GetObject("btnParc.Image")));
            this.btnParc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParc.Location = new System.Drawing.Point(25, 247);
            this.btnParc.Name = "btnParc";
            this.btnParc.Size = new System.Drawing.Size(107, 35);
            this.btnParc.TabIndex = 84;
            this.btnParc.Text = "Parcourrir";
            this.btnParc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnParc.UseVisualStyleBackColor = false;
            this.btnParc.Click += new System.EventHandler(this.btnParc_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.logo);
            this.groupBox4.Controls.Add(this.btnParc);
            this.groupBox4.Location = new System.Drawing.Point(13, 88);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(162, 289);
            this.groupBox4.TabIndex = 170;
            this.groupBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 32);
            this.label1.TabIndex = 169;
            this.label1.Text = "Informations sur l\'église";
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Red;
            this.button8.Location = new System.Drawing.Point(686, 1);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 41);
            this.button8.TabIndex = 168;
            this.button8.Text = "X";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // ColId
            // 
            this.ColId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColId.DataPropertyName = "Id";
            this.ColId.HeaderText = "N°";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Width = 53;
            // 
            // ColNom
            // 
            this.ColNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColNom.DataPropertyName = "Nom";
            this.ColNom.HeaderText = "Identité";
            this.ColNom.Name = "ColNom";
            this.ColNom.ReadOnly = true;
            this.ColNom.Width = 98;
            // 
            // ColCom
            // 
            this.ColCom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColCom.DataPropertyName = "Communaute";
            this.ColCom.HeaderText = "Communauté";
            this.ColCom.Name = "ColCom";
            this.ColCom.ReadOnly = true;
            this.ColCom.Width = 146;
            // 
            // ColAcro
            // 
            this.ColAcro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColAcro.DataPropertyName = "Acronyme";
            this.ColAcro.HeaderText = "Acronyme";
            this.ColAcro.Name = "ColAcro";
            this.ColAcro.ReadOnly = true;
            this.ColAcro.Width = 116;
            // 
            // ColAdd
            // 
            this.ColAdd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColAdd.DataPropertyName = "Adresse";
            this.ColAdd.HeaderText = "Adresse";
            this.ColAdd.Name = "ColAdd";
            this.ColAdd.ReadOnly = true;
            this.ColAdd.Width = 96;
            // 
            // ColPhone
            // 
            this.ColPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColPhone.DataPropertyName = "Telephone1";
            this.ColPhone.HeaderText = "Contact1";
            this.ColPhone.Name = "ColPhone";
            this.ColPhone.ReadOnly = true;
            this.ColPhone.Width = 112;
            // 
            // ColPhone2
            // 
            this.ColPhone2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColPhone2.DataPropertyName = "Telephone2";
            this.ColPhone2.HeaderText = "Contact2";
            this.ColPhone2.Name = "ColPhone2";
            this.ColPhone2.ReadOnly = true;
            this.ColPhone2.Width = 112;
            // 
            // ColEmail
            // 
            this.ColEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColEmail.DataPropertyName = "Mail";
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.ReadOnly = true;
            this.ColEmail.Width = 76;
            // 
            // ColSite
            // 
            this.ColSite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColSite.DataPropertyName = "Siteweb";
            this.ColSite.HeaderText = "SiteWeb";
            this.ColSite.Name = "ColSite";
            this.ColSite.ReadOnly = true;
            this.ColSite.Width = 99;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Logo";
            this.Column1.HeaderText = "Logo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // FrmEglise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(732, 619);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgMaison);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmEglise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEglise";
            this.Load += new System.EventHandler(this.FrmEglise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMaison)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgMaison;
        public System.Windows.Forms.MaskedTextBox phone3;
        public System.Windows.Forms.MaskedTextBox phone2;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.MaskedTextBox phoneTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox accroTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox siteTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mailTxt;
        private System.Windows.Forms.TextBox commTxt;
        private System.Windows.Forms.TextBox nomTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.PictureBox logo;
        public System.Windows.Forms.Button btnParc;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAcro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}