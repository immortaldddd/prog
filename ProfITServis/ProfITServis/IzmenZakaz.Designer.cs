
namespace ProfITServis
{
    partial class IzmenZakaz
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
            this.LBNomer = new System.Windows.Forms.Label();
            this.LBNazv = new System.Windows.Forms.Label();
            this.LBFIO = new System.Windows.Forms.Label();
            this.LBData = new System.Windows.Forms.Label();
            this.LBCena = new System.Windows.Forms.Label();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.TB3 = new System.Windows.Forms.TextBox();
            this.TB4 = new System.Windows.Forms.TextBox();
            this.TB5 = new System.Windows.Forms.TextBox();
            this.BTIzmen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBNomer
            // 
            this.LBNomer.AutoSize = true;
            this.LBNomer.BackColor = System.Drawing.Color.Transparent;
            this.LBNomer.Location = new System.Drawing.Point(57, 35);
            this.LBNomer.Name = "LBNomer";
            this.LBNomer.Size = new System.Drawing.Size(80, 13);
            this.LBNomer.TabIndex = 6;
            this.LBNomer.Text = "Номер заказа";
            // 
            // LBNazv
            // 
            this.LBNazv.AutoSize = true;
            this.LBNazv.Location = new System.Drawing.Point(57, 74);
            this.LBNazv.Name = "LBNazv";
            this.LBNazv.Size = new System.Drawing.Size(93, 13);
            this.LBNazv.TabIndex = 7;
            this.LBNazv.Text = "Название услуги";
            // 
            // LBFIO
            // 
            this.LBFIO.AutoSize = true;
            this.LBFIO.Location = new System.Drawing.Point(57, 113);
            this.LBFIO.Name = "LBFIO";
            this.LBFIO.Size = new System.Drawing.Size(96, 13);
            this.LBFIO.TabIndex = 8;
            this.LBFIO.Text = "ФИО Сотрудника";
            // 
            // LBData
            // 
            this.LBData.AutoSize = true;
            this.LBData.Location = new System.Drawing.Point(57, 152);
            this.LBData.Name = "LBData";
            this.LBData.Size = new System.Drawing.Size(110, 13);
            this.LBData.TabIndex = 9;
            this.LBData.Text = "Дата взятия заказа";
            // 
            // LBCena
            // 
            this.LBCena.AutoSize = true;
            this.LBCena.Location = new System.Drawing.Point(57, 191);
            this.LBCena.Name = "LBCena";
            this.LBCena.Size = new System.Drawing.Size(33, 13);
            this.LBCena.TabIndex = 10;
            this.LBCena.Text = "Цена";
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(60, 51);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(141, 20);
            this.TB1.TabIndex = 11;
            // 
            // TB2
            // 
            this.TB2.Location = new System.Drawing.Point(60, 90);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(141, 20);
            this.TB2.TabIndex = 12;
            // 
            // TB3
            // 
            this.TB3.Location = new System.Drawing.Point(60, 129);
            this.TB3.Name = "TB3";
            this.TB3.Size = new System.Drawing.Size(141, 20);
            this.TB3.TabIndex = 13;
            // 
            // TB4
            // 
            this.TB4.Location = new System.Drawing.Point(60, 168);
            this.TB4.Name = "TB4";
            this.TB4.Size = new System.Drawing.Size(141, 20);
            this.TB4.TabIndex = 14;
            // 
            // TB5
            // 
            this.TB5.Location = new System.Drawing.Point(60, 207);
            this.TB5.Name = "TB5";
            this.TB5.Size = new System.Drawing.Size(141, 20);
            this.TB5.TabIndex = 15;
            // 
            // BTIzmen
            // 
            this.BTIzmen.Location = new System.Drawing.Point(60, 233);
            this.BTIzmen.Name = "BTIzmen";
            this.BTIzmen.Size = new System.Drawing.Size(141, 40);
            this.BTIzmen.TabIndex = 16;
            this.BTIzmen.Text = "Изменить";
            this.BTIzmen.UseVisualStyleBackColor = true;
            this.BTIzmen.Click += new System.EventHandler(this.BTIzmen_Click);
            // 
            // IzmenZakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(267, 293);
            this.Controls.Add(this.BTIzmen);
            this.Controls.Add(this.TB5);
            this.Controls.Add(this.TB4);
            this.Controls.Add(this.TB3);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.LBCena);
            this.Controls.Add(this.LBData);
            this.Controls.Add(this.LBFIO);
            this.Controls.Add(this.LBNazv);
            this.Controls.Add(this.LBNomer);
            this.Name = "IzmenZakaz";
            this.Text = "Изменить заказ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBNomer;
        private System.Windows.Forms.Label LBNazv;
        private System.Windows.Forms.Label LBFIO;
        private System.Windows.Forms.Label LBData;
        private System.Windows.Forms.Label LBCena;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.TextBox TB3;
        private System.Windows.Forms.TextBox TB4;
        private System.Windows.Forms.TextBox TB5;
        private System.Windows.Forms.Button BTIzmen;
    }
}