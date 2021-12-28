
namespace ProfITServis
{
    partial class SotrDelete
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
            this.BT1 = new System.Windows.Forms.Button();
            this.LB1 = new System.Windows.Forms.Label();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BT1
            // 
            this.BT1.Location = new System.Drawing.Point(35, 60);
            this.BT1.Name = "BT1";
            this.BT1.Size = new System.Drawing.Size(139, 42);
            this.BT1.TabIndex = 0;
            this.BT1.Text = "Удалить";
            this.BT1.UseVisualStyleBackColor = true;
            this.BT1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LB1
            // 
            this.LB1.AutoSize = true;
            this.LB1.Location = new System.Drawing.Point(32, 18);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(96, 13);
            this.LB1.TabIndex = 1;
            this.LB1.Text = "ФИО Сотрудника";
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(35, 34);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(139, 20);
            this.TB1.TabIndex = 2;
            // 
            // SotrDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(215, 133);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.LB1);
            this.Controls.Add(this.BT1);
            this.Name = "SotrDelete";
            this.Text = "Удалить сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT1;
        private System.Windows.Forms.Label LB1;
        private System.Windows.Forms.TextBox TB1;
    }
}