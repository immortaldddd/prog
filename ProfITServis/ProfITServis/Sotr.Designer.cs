
namespace ProfITServis
{
    partial class Sotr
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
            this.BTDelete3 = new System.Windows.Forms.Button();
            this.BTAdd3 = new System.Windows.Forms.Button();
            this.prifITServisDataSet = new ProfITServis.PrifITServisDataSet();
            this.sotrydnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotrydnikTableAdapter = new ProfITServis.PrifITServisDataSetTableAdapters.SotrydnikTableAdapter();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prifITServisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrydnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.датаРDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sotrydnikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(320, 176);
            this.dataGridView1.TabIndex = 0;
            // 
            // BTDelete3
            // 
            this.BTDelete3.Location = new System.Drawing.Point(175, 194);
            this.BTDelete3.Name = "BTDelete3";
            this.BTDelete3.Size = new System.Drawing.Size(157, 43);
            this.BTDelete3.TabIndex = 6;
            this.BTDelete3.Text = "Удалить";
            this.BTDelete3.UseVisualStyleBackColor = true;
            this.BTDelete3.Click += new System.EventHandler(this.BTDelete3_Click);
            // 
            // BTAdd3
            // 
            this.BTAdd3.Location = new System.Drawing.Point(12, 194);
            this.BTAdd3.Name = "BTAdd3";
            this.BTAdd3.Size = new System.Drawing.Size(157, 43);
            this.BTAdd3.TabIndex = 6;
            this.BTAdd3.Text = "Добавить";
            this.BTAdd3.UseVisualStyleBackColor = true;
            this.BTAdd3.Click += new System.EventHandler(this.BTAdd3_Click);
            // 
            // prifITServisDataSet
            // 
            this.prifITServisDataSet.DataSetName = "PrifITServisDataSet";
            this.prifITServisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sotrydnikBindingSource
            // 
            this.sotrydnikBindingSource.DataMember = "Sotrydnik";
            this.sotrydnikBindingSource.DataSource = this.prifITServisDataSet;
            // 
            // sotrydnikTableAdapter
            // 
            this.sotrydnikTableAdapter.ClearBeforeFill = true;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // датаРDataGridViewTextBoxColumn
            // 
            this.датаРDataGridViewTextBoxColumn.DataPropertyName = "ДатаР";
            this.датаРDataGridViewTextBoxColumn.HeaderText = "ДатаР";
            this.датаРDataGridViewTextBoxColumn.Name = "датаРDataGridViewTextBoxColumn";
            // 
            // Sotr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(341, 246);
            this.Controls.Add(this.BTAdd3);
            this.Controls.Add(this.BTDelete3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sotr";
            this.Text = "Сотрудник";
            this.Load += new System.EventHandler(this.Sotr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prifITServisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrydnikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTDelete3;
        private System.Windows.Forms.Button BTAdd3;
        private PrifITServisDataSet prifITServisDataSet;
        private System.Windows.Forms.BindingSource sotrydnikBindingSource;
        private PrifITServisDataSetTableAdapters.SotrydnikTableAdapter sotrydnikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРDataGridViewTextBoxColumn;
    }
}