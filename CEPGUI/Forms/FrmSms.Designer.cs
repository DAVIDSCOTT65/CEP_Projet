namespace CEPGUI.Forms
{
    partial class FrmSms
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgMembre = new System.Windows.Forms.DataGridView();
            this.ColNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNaiss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBapt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTerr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioNone = new System.Windows.Forms.RadioButton();
            this.lblContact = new System.Windows.Forms.Label();
            this.departCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioActivite = new System.Windows.Forms.RadioButton();
            this.radioAnnonce = new System.Windows.Forms.RadioButton();
            this.statusTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPort = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSms = new System.Windows.Forms.Label();
            this.dgMessage = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMembre)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(438, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(382, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cliquez pour démarrer l\'envoie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgMembre);
            this.groupBox1.Controls.Add(this.radioNone);
            this.groupBox1.Controls.Add(this.lblContact);
            this.groupBox1.Controls.Add(this.departCombo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radioActivite);
            this.groupBox1.Controls.Add(this.radioAnnonce);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 368);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // dgMembre
            // 
            this.dgMembre.AllowUserToAddRows = false;
            this.dgMembre.AllowUserToDeleteRows = false;
            this.dgMembre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgMembre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMembre.BackgroundColor = System.Drawing.Color.White;
            this.dgMembre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMembre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgMembre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMembre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNum,
            this.Column1,
            this.ColNom,
            this.ColSexe,
            this.ColLieu,
            this.ColNaiss,
            this.ColBapt,
            this.ColPere,
            this.ColMere,
            this.ColProv,
            this.ColTerr,
            this.ColPhone,
            this.ColPast,
            this.Column12,
            this.ColId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMembre.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgMembre.Location = new System.Drawing.Point(6, 106);
            this.dgMembre.Name = "dgMembre";
            this.dgMembre.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMembre.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgMembre.RowHeadersVisible = false;
            this.dgMembre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMembre.Size = new System.Drawing.Size(326, 224);
            this.dgMembre.TabIndex = 209;
            // 
            // ColNum
            // 
            this.ColNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColNum.DataPropertyName = "Num";
            this.ColNum.HeaderText = "N°";
            this.ColNum.Name = "ColNum";
            this.ColNum.ReadOnly = true;
            this.ColNum.Width = 52;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "Pasteur";
            this.Column1.HeaderText = "Département";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // ColNom
            // 
            this.ColNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColNom.DataPropertyName = "Noms";
            this.ColNom.HeaderText = "Noms & Postnom";
            this.ColNom.Name = "ColNom";
            this.ColNom.ReadOnly = true;
            this.ColNom.Visible = false;
            // 
            // ColSexe
            // 
            this.ColSexe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColSexe.DataPropertyName = "Sexe";
            this.ColSexe.HeaderText = "Sexe";
            this.ColSexe.Name = "ColSexe";
            this.ColSexe.ReadOnly = true;
            this.ColSexe.Visible = false;
            // 
            // ColLieu
            // 
            this.ColLieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColLieu.DataPropertyName = "LieuNaissance";
            this.ColLieu.HeaderText = "Lieu de Naissance";
            this.ColLieu.Name = "ColLieu";
            this.ColLieu.ReadOnly = true;
            this.ColLieu.Visible = false;
            // 
            // ColNaiss
            // 
            this.ColNaiss.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColNaiss.DataPropertyName = "DateNaissance";
            this.ColNaiss.HeaderText = "Date de naissance";
            this.ColNaiss.Name = "ColNaiss";
            this.ColNaiss.ReadOnly = true;
            this.ColNaiss.Visible = false;
            // 
            // ColBapt
            // 
            this.ColBapt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColBapt.DataPropertyName = "DateBapteme";
            this.ColBapt.HeaderText = "Date de Bapteme";
            this.ColBapt.Name = "ColBapt";
            this.ColBapt.ReadOnly = true;
            this.ColBapt.Visible = false;
            // 
            // ColPere
            // 
            this.ColPere.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColPere.DataPropertyName = "Pere";
            this.ColPere.HeaderText = "Nom du père";
            this.ColPere.Name = "ColPere";
            this.ColPere.ReadOnly = true;
            this.ColPere.Visible = false;
            // 
            // ColMere
            // 
            this.ColMere.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColMere.DataPropertyName = "Mere";
            this.ColMere.HeaderText = "Nom de la mère";
            this.ColMere.Name = "ColMere";
            this.ColMere.ReadOnly = true;
            this.ColMere.Visible = false;
            // 
            // ColProv
            // 
            this.ColProv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColProv.DataPropertyName = "ProvOrigine";
            this.ColProv.HeaderText = "Province d\'origine";
            this.ColProv.Name = "ColProv";
            this.ColProv.ReadOnly = true;
            this.ColProv.Visible = false;
            // 
            // ColTerr
            // 
            this.ColTerr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColTerr.DataPropertyName = "TerrOrigine";
            this.ColTerr.HeaderText = "Terr. Origine";
            this.ColTerr.Name = "ColTerr";
            this.ColTerr.ReadOnly = true;
            this.ColTerr.Visible = false;
            // 
            // ColPhone
            // 
            this.ColPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColPhone.DataPropertyName = "Telephone";
            this.ColPhone.HeaderText = "Téléphone";
            this.ColPhone.Name = "ColPhone";
            this.ColPhone.ReadOnly = true;
            // 
            // ColPast
            // 
            this.ColPast.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColPast.DataPropertyName = "Pasteur";
            this.ColPast.HeaderText = "Pasteur";
            this.ColPast.Name = "ColPast";
            this.ColPast.ReadOnly = true;
            this.ColPast.Visible = false;
            this.ColPast.Width = 93;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column12.DataPropertyName = "DateEnregistrement";
            this.Column12.HeaderText = "Membre dépuis le";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Visible = false;
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "Id";
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
            // 
            // radioNone
            // 
            this.radioNone.AutoSize = true;
            this.radioNone.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNone.ForeColor = System.Drawing.Color.Black;
            this.radioNone.Location = new System.Drawing.Point(245, 34);
            this.radioNone.Name = "radioNone";
            this.radioNone.Size = new System.Drawing.Size(60, 22);
            this.radioNone.TabIndex = 208;
            this.radioNone.TabStop = true;
            this.radioNone.Text = "None";
            this.radioNone.UseVisualStyleBackColor = true;
            this.radioNone.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(241, 333);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(89, 19);
            this.lblContact.TabIndex = 207;
            this.lblContact.Text = "0 Contacts";
            // 
            // departCombo
            // 
            this.departCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.departCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.departCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departCombo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departCombo.FormattingEnabled = true;
            this.departCombo.Location = new System.Drawing.Point(8, 71);
            this.departCombo.Name = "departCombo";
            this.departCombo.Size = new System.Drawing.Size(324, 29);
            this.departCombo.TabIndex = 206;
            this.departCombo.SelectedIndexChanged += new System.EventHandler(this.departCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "Contactes";
            // 
            // radioActivite
            // 
            this.radioActivite.AutoSize = true;
            this.radioActivite.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioActivite.ForeColor = System.Drawing.Color.Black;
            this.radioActivite.Location = new System.Drawing.Point(132, 34);
            this.radioActivite.Name = "radioActivite";
            this.radioActivite.Size = new System.Drawing.Size(79, 22);
            this.radioActivite.TabIndex = 10;
            this.radioActivite.TabStop = true;
            this.radioActivite.Text = "Activités";
            this.radioActivite.UseVisualStyleBackColor = true;
            this.radioActivite.CheckedChanged += new System.EventHandler(this.radioActivite_CheckedChanged);
            // 
            // radioAnnonce
            // 
            this.radioAnnonce.AutoSize = true;
            this.radioAnnonce.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAnnonce.ForeColor = System.Drawing.Color.Black;
            this.radioAnnonce.Location = new System.Drawing.Point(25, 34);
            this.radioAnnonce.Name = "radioAnnonce";
            this.radioAnnonce.Size = new System.Drawing.Size(89, 22);
            this.radioAnnonce.TabIndex = 9;
            this.radioAnnonce.TabStop = true;
            this.radioAnnonce.Text = "Annonces";
            this.radioAnnonce.UseVisualStyleBackColor = true;
            this.radioAnnonce.CheckedChanged += new System.EventHandler(this.radioAnnonce_CheckedChanged);
            // 
            // statusTxt
            // 
            this.statusTxt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTxt.Location = new System.Drawing.Point(363, 579);
            this.statusTxt.Multiline = true;
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.ReadOnly = true;
            this.statusTxt.Size = new System.Drawing.Size(516, 57);
            this.statusTxt.TabIndex = 212;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPort);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMessage);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(363, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 476);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtPort
            // 
            this.txtPort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtPort.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPort.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.FormattingEnabled = true;
            this.txtPort.Location = new System.Drawing.Point(332, 49);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(178, 29);
            this.txtPort.TabIndex = 209;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 19);
            this.label6.TabIndex = 208;
            this.label6.Text = "Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(285, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Port";
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(11, 122);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(499, 339);
            this.txtMessage.TabIndex = 10;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(86, 49);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(183, 27);
            this.txtPhone.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Message :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSms);
            this.groupBox3.Controls.Add(this.dgMessage);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 380);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 264);
            this.groupBox3.TabIndex = 210;
            this.groupBox3.TabStop = false;
            // 
            // lblSms
            // 
            this.lblSms.AutoSize = true;
            this.lblSms.Location = new System.Drawing.Point(241, 239);
            this.lblSms.Name = "lblSms";
            this.lblSms.Size = new System.Drawing.Size(96, 19);
            this.lblSms.TabIndex = 210;
            this.lblSms.Text = "0 Messages";
            // 
            // dgMessage
            // 
            this.dgMessage.AllowUserToAddRows = false;
            this.dgMessage.AllowUserToDeleteRows = false;
            this.dgMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgMessage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMessage.BackgroundColor = System.Drawing.Color.White;
            this.dgMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMessage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMessage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ColSms,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMessage.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgMessage.Location = new System.Drawing.Point(8, 26);
            this.dgMessage.Name = "dgMessage";
            this.dgMessage.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMessage.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgMessage.RowHeadersVisible = false;
            this.dgMessage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMessage.Size = new System.Drawing.Size(326, 210);
            this.dgMessage.TabIndex = 209;
            this.dgMessage.SelectionChanged += new System.EventHandler(this.dgMessage_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Num";
            this.dataGridViewTextBoxColumn1.HeaderText = "N°";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // ColSms
            // 
            this.ColSms.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColSms.DataPropertyName = "Activite";
            this.ColSms.HeaderText = "Messages";
            this.ColSms.Name = "ColSms";
            this.ColSms.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Id";
            this.Column2.HeaderText = "Id";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DateCreation";
            this.Column3.HeaderText = "DateCreation";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DetailsComm";
            this.Column4.HeaderText = "Communique";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DatePublication";
            this.Column5.HeaderText = "DatePublication";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 207;
            this.label5.Text = "0 Contacts";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 19);
            this.label7.TabIndex = 36;
            this.label7.Text = "Tous les messages";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmSms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(891, 648);
            this.Controls.Add(this.statusTxt);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS";
            this.Load += new System.EventHandler(this.FrmSms_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMembre)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.RadioButton radioActivite;
        public System.Windows.Forms.RadioButton radioAnnonce;
        private System.Windows.Forms.Label lblContact;
        public System.Windows.Forms.ComboBox departCombo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox txtPort;
        private System.Windows.Forms.RadioButton radioNone;
        public System.Windows.Forms.DataGridView dgMembre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNaiss;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBapt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPere;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMere;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTerr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPast;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.TextBox statusTxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSms;
        public System.Windows.Forms.DataGridView dgMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSms;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}