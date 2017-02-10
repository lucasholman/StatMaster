namespace StatMaster
{
    partial class NewGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.championNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.championImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.championsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statMasterDBDataSet = new StatMaster.StatMasterDBDataSet();
            this.championsTableAdapter = new StatMaster.StatMasterDBDataSetTableAdapters.ChampionsTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.ChampImage = new System.Windows.Forms.DataGridView();
            this.championImageDataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.championsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statMasterDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChampImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select A Champion:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.championNameDataGridViewTextBoxColumn,
            this.championImageDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.championsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 42);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 120;
            this.dataGridView1.Size = new System.Drawing.Size(253, 457);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // championNameDataGridViewTextBoxColumn
            // 
            this.championNameDataGridViewTextBoxColumn.DataPropertyName = "ChampionName";
            this.championNameDataGridViewTextBoxColumn.HeaderText = "ChampionName";
            this.championNameDataGridViewTextBoxColumn.Name = "championNameDataGridViewTextBoxColumn";
            this.championNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // championImageDataGridViewImageColumn
            // 
            this.championImageDataGridViewImageColumn.DataPropertyName = "ChampionImage";
            this.championImageDataGridViewImageColumn.HeaderText = "ChampionImage";
            this.championImageDataGridViewImageColumn.Name = "championImageDataGridViewImageColumn";
            this.championImageDataGridViewImageColumn.ReadOnly = true;
            // 
            // championsBindingSource
            // 
            this.championsBindingSource.DataMember = "Champions";
            this.championsBindingSource.DataSource = this.statMasterDBDataSet;
            // 
            // statMasterDBDataSet
            // 
            this.statMasterDBDataSet.DataSetName = "StatMasterDBDataSet";
            this.statMasterDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // championsTableAdapter
            // 
            this.championsTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selected Champion:";
            // 
            // ChampImage
            // 
            this.ChampImage.AllowUserToAddRows = false;
            this.ChampImage.AllowUserToDeleteRows = false;
            this.ChampImage.AutoGenerateColumns = false;
            this.ChampImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChampImage.ColumnHeadersVisible = false;
            this.ChampImage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.championImageDataGridViewImageColumn1});
            this.ChampImage.DataSource = this.championsBindingSource;
            this.ChampImage.Location = new System.Drawing.Point(300, 70);
            this.ChampImage.MultiSelect = false;
            this.ChampImage.Name = "ChampImage";
            this.ChampImage.ReadOnly = true;
            this.ChampImage.RowHeadersVisible = false;
            this.ChampImage.RowTemplate.Height = 120;
            this.ChampImage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ChampImage.Size = new System.Drawing.Size(101, 120);
            this.ChampImage.TabIndex = 4;
            // 
            // championImageDataGridViewImageColumn1
            // 
            this.championImageDataGridViewImageColumn1.DataPropertyName = "ChampionImage";
            this.championImageDataGridViewImageColumn1.HeaderText = "ChampionImage";
            this.championImageDataGridViewImageColumn1.Name = "championImageDataGridViewImageColumn1";
            this.championImageDataGridViewImageColumn1.ReadOnly = true;
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.ChampImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "NewGame";
            this.Text = "NewGame";
            this.Load += new System.EventHandler(this.NewGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.championsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statMasterDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChampImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private StatMasterDBDataSet statMasterDBDataSet;
        private System.Windows.Forms.BindingSource championsBindingSource;
        private StatMasterDBDataSetTableAdapters.ChampionsTableAdapter championsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn championNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn championImageDataGridViewImageColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ChampImage;
        private System.Windows.Forms.DataGridViewImageColumn championImageDataGridViewImageColumn1;
    }
}