namespace Kitap_Kayıt_2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textucret = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textsayfa = new System.Windows.Forms.TextBox();
            this.textyazar = new System.Windows.Forms.TextBox();
            this.textadi = new System.Windows.Forms.TextBox();
            this.textnumara = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttongraf = new System.Windows.Forms.Button();
            this.buttonistat = new System.Windows.Forms.Button();
            this.buttontemiz = new System.Windows.Forms.Button();
            this.buttonguncel = new System.Windows.Forms.Button();
            this.buttonsil = new System.Windows.Forms.Button();
            this.buttonkaydet = new System.Windows.Forms.Button();
            this.buttonlist = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitYazarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitSayfaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitÜcretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitYaşamDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.KitNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KitAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KitYazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KitÜcret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KitYaşam = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kitapListesiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Kitap_Kayıt_2.DataSet1();
            this.kitapListesiTableAdapter = new Kitap_Kayıt_2.DataSet1TableAdapters.KitapListesiTableAdapter();
            this.dataSet2 = new Kitap_Kayıt_2.DataSet2();
            this.kitapListesiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kitapListesiTableAdapter1 = new Kitap_Kayıt_2.DataSet2TableAdapters.KitapListesiTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapListesiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapListesiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.textucret);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.textsayfa);
            this.groupBox1.Controls.Add(this.textyazar);
            this.groupBox1.Controls.Add(this.textadi);
            this.groupBox1.Controls.Add(this.textnumara);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Kayıt";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(184, 170);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 20);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "HAYIR";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // textucret
            // 
            this.textucret.Location = new System.Drawing.Point(125, 136);
            this.textucret.Name = "textucret";
            this.textucret.Size = new System.Drawing.Size(100, 22);
            this.textucret.TabIndex = 10;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(113, 170);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 20);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "EVET";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // textsayfa
            // 
            this.textsayfa.Location = new System.Drawing.Point(125, 108);
            this.textsayfa.Name = "textsayfa";
            this.textsayfa.Size = new System.Drawing.Size(100, 22);
            this.textsayfa.TabIndex = 9;
            // 
            // textyazar
            // 
            this.textyazar.Location = new System.Drawing.Point(125, 80);
            this.textyazar.Name = "textyazar";
            this.textyazar.Size = new System.Drawing.Size(100, 22);
            this.textyazar.TabIndex = 8;
            // 
            // textadi
            // 
            this.textadi.Location = new System.Drawing.Point(125, 52);
            this.textadi.Name = "textadi";
            this.textadi.Size = new System.Drawing.Size(100, 22);
            this.textadi.TabIndex = 7;
            // 
            // textnumara
            // 
            this.textnumara.Location = new System.Drawing.Point(125, 21);
            this.textnumara.Name = "textnumara";
            this.textnumara.Size = new System.Drawing.Size(100, 22);
            this.textnumara.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Yaşıyor mu :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ücret :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sayfa Sayısı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yazar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numarası :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.buttongraf);
            this.groupBox2.Controls.Add(this.buttonistat);
            this.groupBox2.Controls.Add(this.buttontemiz);
            this.groupBox2.Controls.Add(this.buttonguncel);
            this.groupBox2.Controls.Add(this.buttonsil);
            this.groupBox2.Controls.Add(this.buttonkaydet);
            this.groupBox2.Controls.Add(this.buttonlist);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(359, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 193);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // buttongraf
            // 
            this.buttongraf.Image = ((System.Drawing.Image)(resources.GetObject("buttongraf.Image")));
            this.buttongraf.Location = new System.Drawing.Point(131, 86);
            this.buttongraf.Name = "buttongraf";
            this.buttongraf.Size = new System.Drawing.Size(108, 23);
            this.buttongraf.TabIndex = 6;
            this.buttongraf.Text = "Grafik";
            this.buttongraf.UseVisualStyleBackColor = true;
            this.buttongraf.Click += new System.EventHandler(this.buttongraf_Click);
            // 
            // buttonistat
            // 
            this.buttonistat.Image = ((System.Drawing.Image)(resources.GetObject("buttonistat.Image")));
            this.buttonistat.Location = new System.Drawing.Point(131, 57);
            this.buttonistat.Name = "buttonistat";
            this.buttonistat.Size = new System.Drawing.Size(108, 23);
            this.buttonistat.TabIndex = 5;
            this.buttonistat.Text = "İstatistik";
            this.buttonistat.UseVisualStyleBackColor = true;
            this.buttonistat.Click += new System.EventHandler(this.buttonistat_Click);
            // 
            // buttontemiz
            // 
            this.buttontemiz.Image = ((System.Drawing.Image)(resources.GetObject("buttontemiz.Image")));
            this.buttontemiz.Location = new System.Drawing.Point(131, 28);
            this.buttontemiz.Name = "buttontemiz";
            this.buttontemiz.Size = new System.Drawing.Size(108, 23);
            this.buttontemiz.TabIndex = 4;
            this.buttontemiz.Text = "Temizle";
            this.buttontemiz.UseVisualStyleBackColor = true;
            this.buttontemiz.Click += new System.EventHandler(this.buttontemiz_Click);
            // 
            // buttonguncel
            // 
            this.buttonguncel.Image = ((System.Drawing.Image)(resources.GetObject("buttonguncel.Image")));
            this.buttonguncel.Location = new System.Drawing.Point(17, 115);
            this.buttonguncel.Name = "buttonguncel";
            this.buttonguncel.Size = new System.Drawing.Size(108, 23);
            this.buttonguncel.TabIndex = 3;
            this.buttonguncel.Text = "Güncelle";
            this.buttonguncel.UseVisualStyleBackColor = true;
            this.buttonguncel.Click += new System.EventHandler(this.buttonguncel_Click);
            // 
            // buttonsil
            // 
            this.buttonsil.Image = ((System.Drawing.Image)(resources.GetObject("buttonsil.Image")));
            this.buttonsil.Location = new System.Drawing.Point(17, 86);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(108, 23);
            this.buttonsil.TabIndex = 2;
            this.buttonsil.Text = "Sil";
            this.buttonsil.UseVisualStyleBackColor = true;
            this.buttonsil.Click += new System.EventHandler(this.buttonsil_Click);
            // 
            // buttonkaydet
            // 
            this.buttonkaydet.Image = ((System.Drawing.Image)(resources.GetObject("buttonkaydet.Image")));
            this.buttonkaydet.Location = new System.Drawing.Point(17, 57);
            this.buttonkaydet.Name = "buttonkaydet";
            this.buttonkaydet.Size = new System.Drawing.Size(108, 23);
            this.buttonkaydet.TabIndex = 1;
            this.buttonkaydet.Text = "Kaydet";
            this.buttonkaydet.UseVisualStyleBackColor = true;
            this.buttonkaydet.Click += new System.EventHandler(this.buttonkaydet_Click);
            // 
            // buttonlist
            // 
            this.buttonlist.Image = ((System.Drawing.Image)(resources.GetObject("buttonlist.Image")));
            this.buttonlist.Location = new System.Drawing.Point(17, 28);
            this.buttonlist.Name = "buttonlist";
            this.buttonlist.Size = new System.Drawing.Size(108, 23);
            this.buttonlist.TabIndex = 0;
            this.buttonlist.Text = "Listele";
            this.buttonlist.UseVisualStyleBackColor = true;
            this.buttonlist.Click += new System.EventHandler(this.buttonlist_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(649, 126);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitNoDataGridViewTextBoxColumn,
            this.kitAdDataGridViewTextBoxColumn,
            this.kitYazarDataGridViewTextBoxColumn,
            this.kitSayfaDataGridViewTextBoxColumn,
            this.kitÜcretDataGridViewTextBoxColumn,
            this.kitYaşamDataGridViewCheckBoxColumn,
            this.KitNo,
            this.KitAd,
            this.KitYazar,
            this.KitÜcret,
            this.KitYaşam});
            this.dataGridView1.DataSource = this.kitapListesiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 105);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // kitNoDataGridViewTextBoxColumn
            // 
            this.kitNoDataGridViewTextBoxColumn.DataPropertyName = "KitNo";
            this.kitNoDataGridViewTextBoxColumn.HeaderText = "KitNo";
            this.kitNoDataGridViewTextBoxColumn.Name = "kitNoDataGridViewTextBoxColumn";
            this.kitNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kitAdDataGridViewTextBoxColumn
            // 
            this.kitAdDataGridViewTextBoxColumn.DataPropertyName = "KitAd";
            this.kitAdDataGridViewTextBoxColumn.HeaderText = "KitAd";
            this.kitAdDataGridViewTextBoxColumn.Name = "kitAdDataGridViewTextBoxColumn";
            this.kitAdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kitYazarDataGridViewTextBoxColumn
            // 
            this.kitYazarDataGridViewTextBoxColumn.DataPropertyName = "KitYazar";
            this.kitYazarDataGridViewTextBoxColumn.HeaderText = "KitYazar";
            this.kitYazarDataGridViewTextBoxColumn.Name = "kitYazarDataGridViewTextBoxColumn";
            this.kitYazarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kitSayfaDataGridViewTextBoxColumn
            // 
            this.kitSayfaDataGridViewTextBoxColumn.DataPropertyName = "KitSayfa";
            this.kitSayfaDataGridViewTextBoxColumn.HeaderText = "KitSayfa";
            this.kitSayfaDataGridViewTextBoxColumn.Name = "kitSayfaDataGridViewTextBoxColumn";
            this.kitSayfaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kitÜcretDataGridViewTextBoxColumn
            // 
            this.kitÜcretDataGridViewTextBoxColumn.DataPropertyName = "KitÜcret";
            this.kitÜcretDataGridViewTextBoxColumn.HeaderText = "KitÜcret";
            this.kitÜcretDataGridViewTextBoxColumn.Name = "kitÜcretDataGridViewTextBoxColumn";
            this.kitÜcretDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kitYaşamDataGridViewCheckBoxColumn
            // 
            this.kitYaşamDataGridViewCheckBoxColumn.DataPropertyName = "KitYaşam";
            this.kitYaşamDataGridViewCheckBoxColumn.HeaderText = "KitYaşam";
            this.kitYaşamDataGridViewCheckBoxColumn.Name = "kitYaşamDataGridViewCheckBoxColumn";
            this.kitYaşamDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // KitNo
            // 
            this.KitNo.DataPropertyName = "KitNo";
            this.KitNo.HeaderText = "KitNo";
            this.KitNo.Name = "KitNo";
            this.KitNo.ReadOnly = true;
            this.KitNo.Visible = false;
            // 
            // KitAd
            // 
            this.KitAd.DataPropertyName = "KitAd";
            this.KitAd.HeaderText = "KitAd";
            this.KitAd.Name = "KitAd";
            this.KitAd.ReadOnly = true;
            this.KitAd.Visible = false;
            // 
            // KitYazar
            // 
            this.KitYazar.DataPropertyName = "KitYazar";
            this.KitYazar.HeaderText = "KitYazar";
            this.KitYazar.Name = "KitYazar";
            this.KitYazar.ReadOnly = true;
            this.KitYazar.Visible = false;
            // 
            // KitÜcret
            // 
            this.KitÜcret.DataPropertyName = "KitÜcret";
            this.KitÜcret.HeaderText = "KitÜcret";
            this.KitÜcret.Name = "KitÜcret";
            this.KitÜcret.ReadOnly = true;
            this.KitÜcret.Visible = false;
            // 
            // KitYaşam
            // 
            this.KitYaşam.DataPropertyName = "KitYaşam";
            this.KitYaşam.HeaderText = "KitYaşam";
            this.KitYaşam.Name = "KitYaşam";
            this.KitYaşam.ReadOnly = true;
            this.KitYaşam.Visible = false;
            // 
            // kitapListesiBindingSource
            // 
            this.kitapListesiBindingSource.DataMember = "KitapListesi";
            this.kitapListesiBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitapListesiTableAdapter
            // 
            this.kitapListesiTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitapListesiBindingSource1
            // 
            this.kitapListesiBindingSource1.DataMember = "KitapListesi";
            this.kitapListesiBindingSource1.DataSource = this.dataSet2;
            // 
            // kitapListesiTableAdapter1
            // 
            this.kitapListesiTableAdapter1.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(745, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            this.label7.TextChanged += new System.EventHandler(this.label7_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(933, 351);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapListesiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapListesiBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textucret;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textsayfa;
        private System.Windows.Forms.TextBox textyazar;
        private System.Windows.Forms.TextBox textadi;
        private System.Windows.Forms.TextBox textnumara;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttongraf;
        private System.Windows.Forms.Button buttonistat;
        private System.Windows.Forms.Button buttontemiz;
        private System.Windows.Forms.Button buttonguncel;
        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.Button buttonkaydet;
        private System.Windows.Forms.Button buttonlist;
        private System.Windows.Forms.GroupBox groupBox3;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource kitapListesiBindingSource;
        private DataSet1TableAdapters.KitapListesiTableAdapter kitapListesiTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource kitapListesiBindingSource1;
        private DataSet2TableAdapters.KitapListesiTableAdapter kitapListesiTableAdapter1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitYazarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitSayfaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitÜcretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn kitYaşamDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitYazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitÜcret;
        private System.Windows.Forms.DataGridViewCheckBoxColumn KitYaşam;
    }
}

