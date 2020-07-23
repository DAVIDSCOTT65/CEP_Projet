namespace CEPGUI.UserControls
{
    partial class UC_Departements
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Departements));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFidele = new System.Windows.Forms.Label();
            this.serchTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.departCombo = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dgMembre = new System.Windows.Forms.DataGridView();
            this.ColNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMembre)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(723, 53);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 25);
            this.checkBox1.TabIndex = 101;
            this.checkBox1.Text = "Non baptisés";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(689, 544);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 99;
            this.label2.Text = "Total : ";
            // 
            // lblFidele
            // 
            this.lblFidele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFidele.AutoSize = true;
            this.lblFidele.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFidele.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFidele.Location = new System.Drawing.Point(772, 544);
            this.lblFidele.Name = "lblFidele";
            this.lblFidele.Size = new System.Drawing.Size(123, 25);
            this.lblFidele.TabIndex = 100;
            this.lblFidele.Text = "800 Fidèles";
            // 
            // serchTxt
            // 
            this.serchTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serchTxt.Location = new System.Drawing.Point(27, 51);
            this.serchTxt.Name = "serchTxt";
            this.serchTxt.Size = new System.Drawing.Size(428, 27);
            this.serchTxt.TabIndex = 93;
            this.serchTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.serchTxt.TextChanged += new System.EventHandler(this.serchTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 25);
            this.label1.TabIndex = 98;
            this.label1.Text = "Membres et départements";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button3.Image = global::CEPGUI.Properties.Resources.Microsoft_Excel_32px;
            this.button3.Location = new System.Drawing.Point(906, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 28);
            this.button3.TabIndex = 97;
            this.toolTip1.SetToolTip(this.button3, "Exporter le tableau vers excel");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button1.Image = global::CEPGUI.Properties.Resources.Add_32px;
            this.button1.Location = new System.Drawing.Point(860, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 28);
            this.button1.TabIndex = 95;
            this.toolTip1.SetToolTip(this.button1, "Affecter un membre à un département");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(454, 51);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 27);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 94;
            this.pictureBox4.TabStop = false;
            // 
            // departCombo
            // 
            this.departCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.departCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.departCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.departCombo.FormattingEnabled = true;
            this.departCombo.Items.AddRange(new object[] {
            "Tout le département"});
            this.departCombo.Location = new System.Drawing.Point(488, 51);
            this.departCombo.Name = "departCombo";
            this.departCombo.Size = new System.Drawing.Size(226, 29);
            this.departCombo.TabIndex = 187;
            this.toolTip1.SetToolTip(this.departCombo, "Selectionner un département");
            this.departCombo.SelectedIndexChanged += new System.EventHandler(this.departCombo_SelectedIndexChanged);
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
            this.button5.Location = new System.Drawing.Point(6, 541);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 28);
            this.button5.TabIndex = 201;
            this.toolTip1.SetToolTip(this.button5, "Actualiser");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMembre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgMembre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMembre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNum,
            this.ColDepart,
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMembre.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgMembre.Location = new System.Drawing.Point(3, 85);
            this.dgMembre.Name = "dgMembre";
            this.dgMembre.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMembre.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgMembre.RowHeadersVisible = false;
            this.dgMembre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMembre.Size = new System.Drawing.Size(948, 438);
            this.dgMembre.TabIndex = 188;
            this.dgMembre.DoubleClick += new System.EventHandler(this.dgMembre_DoubleClick);
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
            // ColDepart
            // 
            this.ColDepart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColDepart.DataPropertyName = "Pasteur";
            this.ColDepart.HeaderText = "Département";
            this.ColDepart.Name = "ColDepart";
            this.ColDepart.ReadOnly = true;
            this.ColDepart.Width = 143;
            // 
            // ColNom
            // 
            this.ColNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColNom.DataPropertyName = "Noms";
            this.ColNom.HeaderText = "Noms & Postnom";
            this.ColNom.Name = "ColNom";
            this.ColNom.ReadOnly = true;
            this.ColNom.Width = 150;
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
            // ColLieu
            // 
            this.ColLieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColLieu.DataPropertyName = "LieuNaissance";
            this.ColLieu.HeaderText = "Lieu de Naissance";
            this.ColLieu.Name = "ColLieu";
            this.ColLieu.ReadOnly = true;
            this.ColLieu.Width = 158;
            // 
            // ColNaiss
            // 
            this.ColNaiss.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColNaiss.DataPropertyName = "DateNaissance";
            this.ColNaiss.HeaderText = "Date de naissance";
            this.ColNaiss.Name = "ColNaiss";
            this.ColNaiss.ReadOnly = true;
            this.ColNaiss.Width = 165;
            // 
            // ColBapt
            // 
            this.ColBapt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColBapt.DataPropertyName = "DateBapteme";
            this.ColBapt.HeaderText = "Date de Bapteme";
            this.ColBapt.Name = "ColBapt";
            this.ColBapt.ReadOnly = true;
            this.ColBapt.Visible = false;
            this.ColBapt.Width = 161;
            // 
            // ColPere
            // 
            this.ColPere.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColPere.DataPropertyName = "Pere";
            this.ColPere.HeaderText = "Nom du père";
            this.ColPere.Name = "ColPere";
            this.ColPere.ReadOnly = true;
            this.ColPere.Visible = false;
            this.ColPere.Width = 125;
            // 
            // ColMere
            // 
            this.ColMere.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColMere.DataPropertyName = "Mere";
            this.ColMere.HeaderText = "Nom de la mère";
            this.ColMere.Name = "ColMere";
            this.ColMere.ReadOnly = true;
            this.ColMere.Visible = false;
            this.ColMere.Width = 109;
            // 
            // ColProv
            // 
            this.ColProv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColProv.DataPropertyName = "ProvOrigine";
            this.ColProv.HeaderText = "Province d\'origine";
            this.ColProv.Name = "ColProv";
            this.ColProv.ReadOnly = true;
            this.ColProv.Visible = false;
            this.ColProv.Width = 157;
            // 
            // ColTerr
            // 
            this.ColTerr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColTerr.DataPropertyName = "TerrOrigine";
            this.ColTerr.HeaderText = "Terr. Origine";
            this.ColTerr.Name = "ColTerr";
            this.ColTerr.ReadOnly = true;
            this.ColTerr.Visible = false;
            this.ColTerr.Width = 116;
            // 
            // ColPhone
            // 
            this.ColPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColPhone.DataPropertyName = "Telephone";
            this.ColPhone.HeaderText = "Téléphone";
            this.ColPhone.Name = "ColPhone";
            this.ColPhone.ReadOnly = true;
            this.ColPhone.Width = 117;
            // 
            // ColPast
            // 
            this.ColPast.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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
            this.Column12.Width = 142;
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "Id";
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
            // 
            // UC_Departements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dgMembre);
            this.Controls.Add(this.departCombo);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFidele);
            this.Controls.Add(this.serchTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox4);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_Departements";
            this.Size = new System.Drawing.Size(957, 576);
            this.Load += new System.EventHandler(this.UC_Departements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMembre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFidele;
        private System.Windows.Forms.TextBox serchTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox departCombo;
        public System.Windows.Forms.DataGridView dgMembre;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDepart;
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
    }
}
