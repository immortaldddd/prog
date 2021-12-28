
namespace ProfITServis
{
    partial class SotrAdd
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
            this.TB1 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.TB3 = new System.Windows.Forms.TextBox();
            this.LB1 = new System.Windows.Forms.Label();
            this.LB2 = new System.Windows.Forms.Label();
            this.LB3 = new System.Windows.Forms.Label();
            this.BT1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(70, 34);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(140, 20);
            this.TB1.TabIndex = 4;
            // 
            // TB2
            // 
            this.TB2.Location = new System.Drawing.Point(70, 73);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(140, 20);
            this.TB2.TabIndex = 5;
            // 
            // TB3
            // 
            this.TB3.Location = new System.Drawing.Point(70, 114);
            this.TB3.Name = "TB3";
            this.TB3.Size = new System.Drawing.Size(140, 20);
            this.TB3.TabIndex = 6;
            // 
            // LB1
            // 
            this.LB1.AutoSize = true;
            this.LB1.Location = new System.Drawing.Point(67, 18);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(34, 13);
            this.LB1.TabIndex = 7;
            this.LB1.Text = "ФИО";
            // 
            // LB2
            // 
            this.LB2.AutoSize = true;
            this.LB2.Location = new System.Drawing.Point(67, 57);
            this.LB2.Name = "LB2";
            this.LB2.Size = new System.Drawing.Size(38, 13);
            this.LB2.TabIndex = 8;
            this.LB2.Text = "Адрес";
            // 
            // LB3
            // 
            this.LB3.AutoSize = true;
            this.LB3.Location = new System.Drawing.Point(67, 98);
            this.LB3.Name = "LB3";
            this.LB3.Size = new System.Drawing.Size(87, 13);
            this.LB3.TabIndex = 9;
            this.LB3.Text = "ДатаРождения ";
            // 
            // BT1
            // 
            this.BT1.Location = new System.Drawing.Point(70, 140);
            this.BT1.Name = "BT1";
            this.BT1.Size = new System.Drawing.Size(140, 40);
            this.BT1.TabIndex = 10;
            this.BT1.Text = "Добавить";
            this.BT1.UseVisualStyleBackColor = true;
            this.BT1.Click += new System.EventHandler(this.BT1_Click);
            // 
            // SotrAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(280, 207);
            this.Controls.Add(this.BT1);
            this.Controls.Add(this.LB3);
            this.Controls.Add(this.LB2);
            this.Controls.Add(this.LB1);
            this.Controls.Add(this.TB3);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.TB1);
            this.Name = "SotrAdd";
            this.Text = "Добавить сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.TextBox TB3;
        private System.Windows.Forms.Label LB1;
        private System.Windows.Forms.Label LB2;
        private System.Windows.Forms.Label LB3;
        private System.Windows.Forms.Button BT1;
    }
}