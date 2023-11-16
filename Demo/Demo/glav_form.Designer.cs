namespace Demo
{
    partial class glav_form
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
            this.vixod = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bitovaya_texnikaDataSet = new Demo.bitovaya_texnikaDataSet();
            this.tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tovarTableAdapter = new Demo.bitovaya_texnikaDataSetTableAdapters.tovarTableAdapter();
            this.idtovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xaracteristDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitovaya_texnikaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vixod
            // 
            this.vixod.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vixod.Location = new System.Drawing.Point(400, 309);
            this.vixod.Name = "vixod";
            this.vixod.Size = new System.Drawing.Size(86, 34);
            this.vixod.TabIndex = 1;
            this.vixod.Text = "Выход";
            this.vixod.UseVisualStyleBackColor = true;
            this.vixod.Click += new System.EventHandler(this.vixod_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtovarDataGridViewTextBoxColumn,
            this.nametovarDataGridViewTextBoxColumn,
            this.xaracteristDataGridViewTextBoxColumn,
            this.senaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tovarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(451, 181);
            this.dataGridView1.TabIndex = 2;
            // 
            // bitovaya_texnikaDataSet
            // 
            this.bitovaya_texnikaDataSet.DataSetName = "bitovaya_texnikaDataSet";
            this.bitovaya_texnikaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tovarBindingSource
            // 
            this.tovarBindingSource.DataMember = "tovar";
            this.tovarBindingSource.DataSource = this.bitovaya_texnikaDataSet;
            // 
            // tovarTableAdapter
            // 
            this.tovarTableAdapter.ClearBeforeFill = true;
            // 
            // idtovarDataGridViewTextBoxColumn
            // 
            this.idtovarDataGridViewTextBoxColumn.DataPropertyName = "id_tovar";
            this.idtovarDataGridViewTextBoxColumn.HeaderText = "Код товара";
            this.idtovarDataGridViewTextBoxColumn.Name = "idtovarDataGridViewTextBoxColumn";
            this.idtovarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nametovarDataGridViewTextBoxColumn
            // 
            this.nametovarDataGridViewTextBoxColumn.DataPropertyName = "name_tovar";
            this.nametovarDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nametovarDataGridViewTextBoxColumn.Name = "nametovarDataGridViewTextBoxColumn";
            // 
            // xaracteristDataGridViewTextBoxColumn
            // 
            this.xaracteristDataGridViewTextBoxColumn.DataPropertyName = "xaracterist";
            this.xaracteristDataGridViewTextBoxColumn.HeaderText = "Характеристики";
            this.xaracteristDataGridViewTextBoxColumn.Name = "xaracteristDataGridViewTextBoxColumn";
            // 
            // senaDataGridViewTextBoxColumn
            // 
            this.senaDataGridViewTextBoxColumn.DataPropertyName = "sena";
            this.senaDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.senaDataGridViewTextBoxColumn.Name = "senaDataGridViewTextBoxColumn";
            // 
            // glav_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 382);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.vixod);
            this.Name = "glav_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.glav_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitovaya_texnikaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vixod;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bitovaya_texnikaDataSet bitovaya_texnikaDataSet;
        private System.Windows.Forms.BindingSource tovarBindingSource;
        private bitovaya_texnikaDataSetTableAdapters.tovarTableAdapter tovarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xaracteristDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senaDataGridViewTextBoxColumn;
    }
}