
namespace ProfITServis
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BTIzmen = new System.Windows.Forms.Button();
            this.BTSotr = new System.Windows.Forms.Button();
            this.BTYsl = new System.Windows.Forms.Button();
            this.BTExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BRDelet = new System.Windows.Forms.Button();
            this.LBZakaz = new System.Windows.Forms.Label();
            this.prifITServisDataSet = new ProfITServis.PrifITServisDataSet();
            this.zakazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zakazTableAdapter = new ProfITServis.PrifITServisDataSetTableAdapters.ZakazTableAdapter();
            this.номерЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеУслDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОСотрDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВзятияЗDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.общЦенаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prifITServisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BTIzmen
            // 
            this.BTIzmen.Location = new System.Drawing.Point(37, 249);
            this.BTIzmen.Name = "BTIzmen";
            this.BTIzmen.Size = new System.Drawing.Size(157, 43);
            this.BTIzmen.TabIndex = 0;
            this.BTIzmen.Text = "Изменить";
            this.BTIzmen.UseVisualStyleBackColor = true;
            this.BTIzmen.Click += new System.EventHandler(this.BTIzmen_Click);
            // 
            // BTSotr
            // 
            this.BTSotr.Location = new System.Drawing.Point(363, 30);
            this.BTSotr.Name = "BTSotr";
            this.BTSotr.Size = new System.Drawing.Size(157, 43);
            this.BTSotr.TabIndex = 1;
            this.BTSotr.Text = "Сотрудники";
            this.BTSotr.UseVisualStyleBackColor = true;
            this.BTSotr.Click += new System.EventHandler(this.BTSotr_Click);
            // 
            // BTYsl
            // 
            this.BTYsl.Location = new System.Drawing.Point(200, 30);
            this.BTYsl.Name = "BTYsl";
            this.BTYsl.Size = new System.Drawing.Size(157, 43);
            this.BTYsl.TabIndex = 2;
            this.BTYsl.Text = "Услуга";
            this.BTYsl.UseVisualStyleBackColor = true;
            this.BTYsl.Click += new System.EventHandler(this.BTYsl_Click);
            // 
            // BTExit
            // 
            this.BTExit.Location = new System.Drawing.Point(363, 249);
            this.BTExit.Name = "BTExit";
            this.BTExit.Size = new System.Drawing.Size(157, 43);
            this.BTExit.TabIndex = 3;
            this.BTExit.Text = "Выйти";
            this.BTExit.UseVisualStyleBackColor = true;
            this.BTExit.Click += new System.EventHandler(this.BTExit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Оформить заказ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерЗаказаDataGridViewTextBoxColumn,
            this.названиеУслDataGridViewTextBoxColumn,
            this.фИОСотрDataGridViewTextBoxColumn,
            this.датаВзятияЗDataGridViewTextBoxColumn,
            this.общЦенаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zakazBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(483, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // BRDelet
            // 
            this.BRDelet.Location = new System.Drawing.Point(200, 249);
            this.BRDelet.Name = "BRDelet";
            this.BRDelet.Size = new System.Drawing.Size(157, 43);
            this.BRDelet.TabIndex = 6;
            this.BRDelet.Text = "Удалить";
            this.BRDelet.UseVisualStyleBackColor = true;
            this.BRDelet.Click += new System.EventHandler(this.BRDelet_Click);
            // 
            // LBZakaz
            // 
            this.LBZakaz.AutoSize = true;
            this.LBZakaz.Location = new System.Drawing.Point(34, 76);
            this.LBZakaz.Name = "LBZakaz";
            this.LBZakaz.Size = new System.Drawing.Size(41, 13);
            this.LBZakaz.TabIndex = 7;
            this.LBZakaz.Text = "Заказ:";
            // 
            // prifITServisDataSet
            // 
            this.prifITServisDataSet.DataSetName = "PrifITServisDataSet";
            this.prifITServisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zakazBindingSource
            // 
            this.zakazBindingSource.DataMember = "Zakaz";
            this.zakazBindingSource.DataSource = this.prifITServisDataSet;
            // 
            // zakazTableAdapter
            // 
            this.zakazTableAdapter.ClearBeforeFill = true;
            // 
            // номерЗаказаDataGridViewTextBoxColumn
            // 
            this.номерЗаказаDataGridViewTextBoxColumn.DataPropertyName = "НомерЗаказа";
            this.номерЗаказаDataGridViewTextBoxColumn.HeaderText = "НомерЗаказа";
            this.номерЗаказаDataGridViewTextBoxColumn.Name = "номерЗаказаDataGridViewTextBoxColumn";
            // 
            // названиеУслDataGridViewTextBoxColumn
            // 
            this.названиеУслDataGridViewTextBoxColumn.DataPropertyName = "НазваниеУсл";
            this.названиеУслDataGridViewTextBoxColumn.HeaderText = "НазваниеУсл";
            this.названиеУслDataGridViewTextBoxColumn.Name = "названиеУслDataGridViewTextBoxColumn";
            // 
            // фИОСотрDataGridViewTextBoxColumn
            // 
            this.фИОСотрDataGridViewTextBoxColumn.DataPropertyName = "ФИОСотр";
            this.фИОСотрDataGridViewTextBoxColumn.HeaderText = "ФИОСотр";
            this.фИОСотрDataGridViewTextBoxColumn.Name = "фИОСотрDataGridViewTextBoxColumn";
            // 
            // датаВзятияЗDataGridViewTextBoxColumn
            // 
            this.датаВзятияЗDataGridViewTextBoxColumn.DataPropertyName = "ДатаВзятияЗ";
            this.датаВзятияЗDataGridViewTextBoxColumn.HeaderText = "ДатаВзятияЗ";
            this.датаВзятияЗDataGridViewTextBoxColumn.Name = "датаВзятияЗDataGridViewTextBoxColumn";
            // 
            // общЦенаDataGridViewTextBoxColumn
            // 
            this.общЦенаDataGridViewTextBoxColumn.DataPropertyName = "ОбщЦена";
            this.общЦенаDataGridViewTextBoxColumn.HeaderText = "ОбщЦена";
            this.общЦенаDataGridViewTextBoxColumn.Name = "общЦенаDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(562, 320);
            this.Controls.Add(this.LBZakaz);
            this.Controls.Add(this.BRDelet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTExit);
            this.Controls.Add(this.BTYsl);
            this.Controls.Add(this.BTSotr);
            this.Controls.Add(this.BTIzmen);
            this.Name = "Form1";
            this.Text = "ProfITServis";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prifITServisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTIzmen;
        private System.Windows.Forms.Button BTSotr;
        private System.Windows.Forms.Button BTYsl;
        private System.Windows.Forms.Button BTExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BRDelet;
        private System.Windows.Forms.Label LBZakaz;
        private PrifITServisDataSet prifITServisDataSet;
        private System.Windows.Forms.BindingSource zakazBindingSource;
        private PrifITServisDataSetTableAdapters.ZakazTableAdapter zakazTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеУслDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОСотрDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВзятияЗDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn общЦенаDataGridViewTextBoxColumn;
    }
}

