namespace CEPGUI.Forms
{
    partial class FrmBapteme
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBapteme));
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.confBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.confTxt = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.membreCombo = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgBapt = new System.Windows.Forms.DataGridView();
            this.ColNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFidele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDateNaiss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLieuNaiss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDatePrev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLieuBapt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPasteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serchTxt = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.lieuTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pastTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.recptTxt = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.lblConf = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBapt)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(101, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 303;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // confBtn
            // 
            this.confBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.confBtn.Enabled = false;
            this.confBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.confBtn.FlatAppearance.BorderSize = 0;
            this.confBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.confBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.confBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confBtn.ForeColor = System.Drawing.Color.White;
            this.confBtn.Location = new System.Drawing.Point(105, 128);
            this.confBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confBtn.Name = "confBtn";
            this.confBtn.Size = new System.Drawing.Size(180, 30);
            this.confBtn.TabIndex = 302;
            this.confBtn.Text = "Confirmer le bateme";
            this.confBtn.UseVisualStyleBackColor = false;
            this.confBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(83, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 301;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // confTxt
            // 
            this.confTxt.Location = new System.Drawing.Point(29, 88);
            this.confTxt.Mask = "00/00/0000";
            this.confTxt.Name = "confTxt";
            this.confTxt.Size = new System.Drawing.Size(300, 27);
            this.confTxt.TabIndex = 269;
            this.confTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.confTxt.ValidatingType = typeof(System.DateTime);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(123, 68);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(123, 17);
            this.label19.TabIndex = 288;
            this.label19.Text = "Confirmer la date";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(335, 64);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(16, 21);
            this.label20.TabIndex = 282;
            this.label20.Text = "*";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(101, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(222, 21);
            this.label22.TabIndex = 280;
            this.label22.Text = "Confirmation des bapteme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 315;
            this.label1.Text = "Fidèle";
            // 
            // membreCombo
            // 
            this.membreCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.membreCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.membreCombo.FormattingEnabled = true;
            this.membreCombo.Location = new System.Drawing.Point(74, 95);
            this.membreCombo.Name = "membreCombo";
            this.membreCombo.Size = new System.Drawing.Size(698, 29);
            this.membreCombo.TabIndex = 318;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblConf);
            this.groupBox3.Controls.Add(this.confBtn);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.confTxt);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Location = new System.Drawing.Point(471, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 165);
            this.groupBox3.TabIndex = 317;
            this.groupBox3.TabStop = false;
            // 
            // dgBapt
            // 
            this.dgBapt.AllowUserToAddRows = false;
            this.dgBapt.AllowUserToDeleteRows = false;
            this.dgBapt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgBapt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBapt.BackgroundColor = System.Drawing.Color.White;
            this.dgBapt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBapt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgBapt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBapt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNum,
            this.ColFidele,
            this.ColSexe,
            this.ColDateNaiss,
            this.ColLieuNaiss,
            this.ColDatePrev,
            this.ColLieuBapt,
            this.ColPasteur,
            this.ColId,
            this.Column1,
            this.Column5});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgBapt.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgBapt.Location = new System.Drawing.Point(12, 64);
            this.dgBapt.Name = "dgBapt";
            this.dgBapt.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBapt.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgBapt.RowHeadersVisible = false;
            this.dgBapt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBapt.Size = new System.Drawing.Size(790, 305);
            this.dgBapt.TabIndex = 303;
            this.dgBapt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBapt_CellContentClick);
            this.dgBapt.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgBapt_MouseDoubleClick);
            // 
            // ColNum
            // 
            this.ColNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColNum.DataPropertyName = "Num";
            this.ColNum.HeaderText = "N°";
            this.ColNum.Name = "ColNum";
            this.ColNum.ReadOnly = true;
            this.ColNum.Width = 53;
            // 
            // ColFidele
            // 
            this.ColFidele.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColFidele.DataPropertyName = "Noms";
            this.ColFidele.HeaderText = "Nom et Postnom";
            this.ColFidele.Name = "ColFidele";
            this.ColFidele.ReadOnly = true;
            this.ColFidele.Width = 150;
            // 
            // ColSexe
            // 
            this.ColSexe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColSexe.DataPropertyName = "Sexe";
            this.ColSexe.HeaderText = "Sexe";
            this.ColSexe.Name = "ColSexe";
            this.ColSexe.ReadOnly = true;
            this.ColSexe.Width = 71;
            // 
            // ColDateNaiss
            // 
            this.ColDateNaiss.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColDateNaiss.DataPropertyName = "DateNaissance";
            this.ColDateNaiss.HeaderText = "Date de Naissance";
            this.ColDateNaiss.Name = "ColDateNaiss";
            this.ColDateNaiss.ReadOnly = true;
            this.ColDateNaiss.Width = 167;
            // 
            // ColLieuNaiss
            // 
            this.ColLieuNaiss.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColLieuNaiss.DataPropertyName = "LieuNaiss";
            this.ColLieuNaiss.HeaderText = "Lieu Naissance";
            this.ColLieuNaiss.Name = "ColLieuNaiss";
            this.ColLieuNaiss.ReadOnly = true;
            this.ColLieuNaiss.Width = 135;
            // 
            // ColDatePrev
            // 
            this.ColDatePrev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColDatePrev.DataPropertyName = "DateCelebration";
            this.ColDatePrev.HeaderText = "Date prévue Bapteme";
            this.ColDatePrev.Name = "ColDatePrev";
            this.ColDatePrev.ReadOnly = true;
            this.ColDatePrev.Width = 193;
            // 
            // ColLieuBapt
            // 
            this.ColLieuBapt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColLieuBapt.DataPropertyName = "Lieu";
            this.ColLieuBapt.HeaderText = "Lieu Bapteme";
            this.ColLieuBapt.Name = "ColLieuBapt";
            this.ColLieuBapt.ReadOnly = true;
            this.ColLieuBapt.Width = 130;
            // 
            // ColPasteur
            // 
            this.ColPasteur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColPasteur.DataPropertyName = "Pasteur";
            this.ColPasteur.HeaderText = "Pasteur";
            this.ColPasteur.Name = "ColPasteur";
            this.ColPasteur.ReadOnly = true;
            this.ColPasteur.Width = 93;
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "Id";
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "RefMembre";
            this.Column1.HeaderText = "RefMembre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "RefBapteme";
            this.Column5.HeaderText = "RefBapteme";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serchTxt);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgBapt);
            this.groupBox1.Location = new System.Drawing.Point(15, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 375);
            this.groupBox1.TabIndex = 319;
            this.groupBox1.TabStop = false;
            // 
            // serchTxt
            // 
            this.serchTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serchTxt.Location = new System.Drawing.Point(173, 31);
            this.serchTxt.Name = "serchTxt";
            this.serchTxt.Size = new System.Drawing.Size(428, 27);
            this.serchTxt.TabIndex = 305;
            this.serchTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.serchTxt.TextChanged += new System.EventHandler(this.serchTxt_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(600, 31);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 27);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 306;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 304;
            this.label2.Text = "Liste des prévisions";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(90, 128);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 30);
            this.button1.TabIndex = 303;
            this.button1.Text = "Enregistrer prévision";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.lieuTxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pastTxt);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.recptTxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(17, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 165);
            this.groupBox2.TabIndex = 316;
            this.groupBox2.TabStop = false;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button6.Image = global::CEPGUI.Properties.Resources.Add_32px;
            this.button6.Location = new System.Drawing.Point(399, 27);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 28);
            this.button6.TabIndex = 321;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lieuTxt
            // 
            this.lieuTxt.Location = new System.Drawing.Point(75, 61);
            this.lieuTxt.Name = "lieuTxt";
            this.lieuTxt.ReadOnly = true;
            this.lieuTxt.Size = new System.Drawing.Size(300, 27);
            this.lieuTxt.TabIndex = 270;
            this.lieuTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 289;
            this.label3.Text = "Lieu";
            // 
            // pastTxt
            // 
            this.pastTxt.Location = new System.Drawing.Point(75, 97);
            this.pastTxt.Name = "pastTxt";
            this.pastTxt.ReadOnly = true;
            this.pastTxt.Size = new System.Drawing.Size(300, 27);
            this.pastTxt.TabIndex = 271;
            this.pastTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 21);
            this.label12.TabIndex = 290;
            this.label12.Text = "Pasteur";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(377, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 21);
            this.label17.TabIndex = 298;
            this.label17.Text = "*";
            // 
            // recptTxt
            // 
            this.recptTxt.Location = new System.Drawing.Point(75, 29);
            this.recptTxt.Mask = "00/00/0000";
            this.recptTxt.Name = "recptTxt";
            this.recptTxt.Size = new System.Drawing.Size(300, 27);
            this.recptTxt.TabIndex = 269;
            this.recptTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.recptTxt.ValidatingType = typeof(System.DateTime);
            this.recptTxt.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.recptTxt_MaskInputRejected);
            this.recptTxt.TextChanged += new System.EventHandler(this.recptTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(378, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 21);
            this.label5.TabIndex = 282;
            this.label5.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 21);
            this.label8.TabIndex = 288;
            this.label8.Text = "Date";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(378, 97);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 21);
            this.label16.TabIndex = 296;
            this.label16.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 21);
            this.label4.TabIndex = 280;
            this.label4.Text = "Détails sur le bapteme";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(774, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 21);
            this.label13.TabIndex = 314;
            this.label13.Text = "*";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 711);
            this.panel3.TabIndex = 311;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Location = new System.Drawing.Point(837, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 614);
            this.panel4.TabIndex = 312;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(79, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(362, 24);
            this.label6.TabIndex = 309;
            this.label6.Text = "Prévision et confirmation bapteme";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 712);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 1);
            this.panel2.TabIndex = 307;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(801, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 37);
            this.button2.TabIndex = 308;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 1);
            this.panel1.TabIndex = 306;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button4.Image = global::CEPGUI.Properties.Resources.Add_32px;
            this.button4.Location = new System.Drawing.Point(791, 92);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 28);
            this.button4.TabIndex = 320;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CEPGUI.Properties.Resources.Children_32px1;
            this.pictureBox1.Location = new System.Drawing.Point(15, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 310;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button5.Image = global::CEPGUI.Properties.Resources.Refresh_32px;
            this.button5.Location = new System.Drawing.Point(3, 682);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 28);
            this.button5.TabIndex = 313;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblConf
            // 
            this.lblConf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblConf.Location = new System.Drawing.Point(6, 37);
            this.lblConf.Name = "lblConf";
            this.lblConf.Size = new System.Drawing.Size(340, 19);
            this.lblConf.TabIndex = 303;
            this.lblConf.Text = "Confirmer la date";
            this.lblConf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmBapteme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 713);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.membreCombo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmBapteme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBapt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button confBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.MaskedTextBox confTxt;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox membreCombo;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.DataGridView dgBapt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox lieuTxt;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox pastTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.MaskedTextBox recptTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox serchTxt;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFidele;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDateNaiss;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLieuNaiss;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDatePrev;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLieuBapt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPasteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label lblConf;
    }
}