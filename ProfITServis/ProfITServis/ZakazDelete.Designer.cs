
namespace ProfITServis
{
    partial class ZakazDelete
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
            this.TB1 = new System.Windows.Forms.TextBox();
            this.BTDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBNomer
            // 
            this.LBNomer.AutoSize = true;
            this.LBNomer.Location = new System.Drawing.Point(24, 18);
            this.LBNomer.Name = "LBNomer";
            this.LBNomer.Size = new System.Drawing.Size(80, 13);
            this.LBNomer.TabIndex = 6;
            this.LBNomer.Text = "Номер заказа";
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(27, 34);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(141, 20);
            this.TB1.TabIndex = 7;
            // 
            // BTDelete
            // 
            this.BTDelete.Location = new System.Drawing.Point(27, 60);
            this.BTDelete.Name = "BTDelete";
            this.BTDelete.Size = new System.Drawing.Size(141, 40);
            this.BTDelete.TabIndex = 8;
            this.BTDelete.Text = "Удалить";
            this.BTDelete.UseVisualStyleBackColor = true;
            this.BTDelete.Click += new System.EventHandler(this.BTDelete_Click);
            // 
            // ZakazDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(207, 108);
            this.Controls.Add(this.BTDelete);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.LBNomer);
            this.Name = "ZakazDelete";
            this.Text = "ZakazDelete";
            this.Load += new System.EventHandler(this.ZakazDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBNomer;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.Button BTDelete;
    }
}