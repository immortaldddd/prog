
namespace ProfITServis
{
    partial class Zakaz
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
            this.BTOform = new System.Windows.Forms.Button();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.TB3 = new System.Windows.Forms.TextBox();
            this.TB4 = new System.Windows.Forms.TextBox();
            this.LBNomer = new System.Windows.Forms.Label();
            this.LBNazv = new System.Windows.Forms.Label();
            this.LBFIO = new System.Windows.Forms.Label();
            this.LBData = new System.Windows.Forms.Label();
            this.LBCena = new System.Windows.Forms.Label();
            this.TB5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTOform
            // 
            this.BTOform.Location = new System.Drawing.Point(50, 211);
            this.BTOform.Name = "BTOform";
            this.BTOform.Size = new System.Drawing.Size(141, 40);
            this.BTOform.TabIndex = 0;
            this.BTOform.Text = "Оформить";
            this.BTOform.UseVisualStyleBackColor = true;
            this.BTOform.Click += new System.EventHandler(this.BTOform_Click);
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(50, 29);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(141, 20);
            this.TB1.TabIndex = 1;
            // 
            // TB2
            // 
            this.TB2.Location = new System.Drawing.Point(50, 68);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(141, 20);
            this.TB2.TabIndex = 2;
            // 
            // TB3
            // 
            this.TB3.Location = new System.Drawing.Point(50, 107);
            this.TB3.Name = "TB3";
            this.TB3.Size = new System.Drawing.Size(141, 20);
            this.TB3.TabIndex = 3;
            // 
            // TB4
            // 
            this.TB4.Location = new System.Drawing.Point(50, 146);
            this.TB4.Name = "TB4";
            this.TB4.Size = new System.Drawing.Size(141, 20);
            this.TB4.TabIndex = 4;
            // 
            // LBNomer
            // 
            this.LBNomer.AutoSize = true;
            this.LBNomer.Location = new System.Drawing.Point(47, 13);
            this.LBNomer.Name = "LBNomer";
            this.LBNomer.Size = new System.Drawing.Size(80, 13);
            this.LBNomer.TabIndex = 5;
            this.LBNomer.Text = "Номер заказа";
            // 
            // LBNazv
            // 
            this.LBNazv.AutoSize = true;
            this.LBNazv.Location = new System.Drawing.Point(47, 52);
            this.LBNazv.Name = "LBNazv";
            this.LBNazv.Size = new System.Drawing.Size(93, 13);
            this.LBNazv.TabIndex = 6;
            this.LBNazv.Text = "Название услуги";
            // 
            // LBFIO
            // 
            this.LBFIO.AutoSize = true;
            this.LBFIO.Location = new System.Drawing.Point(47, 91);
            this.LBFIO.Name = "LBFIO";
            this.LBFIO.Size = new System.Drawing.Size(96, 13);
            this.LBFIO.TabIndex = 7;
            this.LBFIO.Text = "ФИО Сотрудника";
            // 
            // LBData
            // 
            this.LBData.AutoSize = true;
            this.LBData.Location = new System.Drawing.Point(47, 130);
            this.LBData.Name = "LBData";
            this.LBData.Size = new System.Drawing.Size(110, 13);
            this.LBData.TabIndex = 8;
            this.LBData.Text = "Дата взятия заказа";
            // 
            // LBCena
            // 
            this.LBCena.AutoSize = true;
            this.LBCena.Location = new System.Drawing.Point(47, 169);
            this.LBCena.Name = "LBCena";
            this.LBCena.Size = new System.Drawing.Size(33, 13);
            this.LBCena.TabIndex = 9;
            this.LBCena.Text = "Цена";
            // 
            // TB5
            // 
            this.TB5.Location = new System.Drawing.Point(50, 185);
            this.TB5.Name = "TB5";
            this.TB5.Size = new System.Drawing.Size(141, 20);
            this.TB5.TabIndex = 10;
            // 
            // Zakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(245, 259);
            this.Controls.Add(this.TB5);
            this.Controls.Add(this.LBCena);
            this.Controls.Add(this.LBData);
            this.Controls.Add(this.LBFIO);
            this.Controls.Add(this.LBNazv);
            this.Controls.Add(this.LBNomer);
            this.Controls.Add(this.TB4);
            this.Controls.Add(this.TB3);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.BTOform);
            this.Name = "Zakaz";
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.Zakaz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTOform;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.TextBox TB3;
        private System.Windows.Forms.TextBox TB4;
        private System.Windows.Forms.Label LBNomer;
        private System.Windows.Forms.Label LBNazv;
        private System.Windows.Forms.Label LBFIO;
        private System.Windows.Forms.Label LBData;
        private System.Windows.Forms.Label LBCena;
        private System.Windows.Forms.TextBox TB5;
    }
}