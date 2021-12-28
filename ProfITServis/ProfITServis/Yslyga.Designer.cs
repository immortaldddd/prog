
namespace ProfITServis
{
    partial class Yslyga
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
            this.BTDelete2 = new System.Windows.Forms.Button();
            this.BTAdd2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prifITServisDataSet = new ProfITServis.PrifITServisDataSet();
            this.yslygaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yslygaTableAdapter = new ProfITServis.PrifITServisDataSetTableAdapters.YslygaTableAdapter();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prifITServisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yslygaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BTDelete2
            // 
            this.BTDelete2.Location = new System.Drawing.Point(175, 234);
            this.BTDelete2.Name = "BTDelete2";
            this.BTDelete2.Size = new System.Drawing.Size(157, 43);
            this.BTDelete2.TabIndex = 5;
            this.BTDelete2.Text = "Удалить";
            this.BTDelete2.UseVisualStyleBackColor = true;
            this.BTDelete2.Click += new System.EventHandler(this.BTDelete2_Click);
            // 
            // BTAdd2
            // 
            this.BTAdd2.Location = new System.Drawing.Point(12, 234);
            this.BTAdd2.Name = "BTAdd2";
            this.BTAdd2.Size = new System.Drawing.Size(157, 43);
            this.BTAdd2.TabIndex = 5;
            this.BTAdd2.Text = "Добавить";
            this.BTAdd2.UseVisualStyleBackColor = true;
            this.BTAdd2.Click += new System.EventHandler(this.BTAdd2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yslygaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(320, 216);
            this.dataGridView1.TabIndex = 6;
            // 
            // prifITServisDataSet
            // 
            this.prifITServisDataSet.DataSetName = "PrifITServisDataSet";
            this.prifITServisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yslygaBindingSource
            // 
            this.yslygaBindingSource.DataMember = "Yslyga";
            this.yslygaBindingSource.DataSource = this.prifITServisDataSet;
            // 
            // yslygaTableAdapter
            // 
            this.yslygaTableAdapter.ClearBeforeFill = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // Yslyga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(345, 286);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTAdd2);
            this.Controls.Add(this.BTDelete2);
            this.Name = "Yslyga";
            this.Text = "Услуга";
            this.Load += new System.EventHandler(this.Yslyga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prifITServisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yslygaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTDelete2;
        private System.Windows.Forms.Button BTAdd2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PrifITServisDataSet prifITServisDataSet;
        private System.Windows.Forms.BindingSource yslygaBindingSource;
        private PrifITServisDataSetTableAdapters.YslygaTableAdapter yslygaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
    }
}