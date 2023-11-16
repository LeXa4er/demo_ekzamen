namespace Demo
{
    partial class glav_form_admin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vixod = new System.Windows.Forms.Button();
            this.bitovaya_texnikaDataSet = new Demo.bitovaya_texnikaDataSet();
            this.bitovayatexnikaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitovaya_texnikaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitovayatexnikaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.bitovayatexnikaDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(451, 181);
            this.dataGridView1.TabIndex = 4;
            // 
            // vixod
            // 
            this.vixod.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vixod.Location = new System.Drawing.Point(395, 288);
            this.vixod.Name = "vixod";
            this.vixod.Size = new System.Drawing.Size(86, 34);
            this.vixod.TabIndex = 3;
            this.vixod.Text = "Выход";
            this.vixod.UseVisualStyleBackColor = true;
            // 
            // bitovaya_texnikaDataSet
            // 
            this.bitovaya_texnikaDataSet.DataSetName = "bitovaya_texnikaDataSet";
            this.bitovaya_texnikaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bitovayatexnikaDataSetBindingSource
            // 
            this.bitovayatexnikaDataSetBindingSource.DataSource = this.bitovaya_texnikaDataSet;
            this.bitovayatexnikaDataSetBindingSource.Position = 0;
            // 
            // glav_form_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.vixod);
            this.Name = "glav_form_admin";
            this.Text = "glav_form_admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitovaya_texnikaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitovayatexnikaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button vixod;
        private System.Windows.Forms.BindingSource bitovayatexnikaDataSetBindingSource;
        private bitovaya_texnikaDataSet bitovaya_texnikaDataSet;
    }
}