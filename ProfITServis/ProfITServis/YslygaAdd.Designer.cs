
namespace ProfITServis
{
    partial class YslygaAdd
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
            this.LB1 = new System.Windows.Forms.Label();
            this.LB2 = new System.Windows.Forms.Label();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.BTAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB1
            // 
            this.LB1.AutoSize = true;
            this.LB1.Location = new System.Drawing.Point(49, 13);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(57, 13);
            this.LB1.TabIndex = 0;
            this.LB1.Text = "Название";
            // 
            // LB2
            // 
            this.LB2.AutoSize = true;
            this.LB2.Location = new System.Drawing.Point(49, 53);
            this.LB2.Name = "LB2";
            this.LB2.Size = new System.Drawing.Size(33, 13);
            this.LB2.TabIndex = 1;
            this.LB2.Text = "Цена";
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(52, 29);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(130, 20);
            this.TB1.TabIndex = 2;
            // 
            // TB2
            // 
            this.TB2.Location = new System.Drawing.Point(52, 69);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(130, 20);
            this.TB2.TabIndex = 3;
            // 
            // BTAdd
            // 
            this.BTAdd.Location = new System.Drawing.Point(52, 95);
            this.BTAdd.Name = "BTAdd";
            this.BTAdd.Size = new System.Drawing.Size(130, 39);
            this.BTAdd.TabIndex = 4;
            this.BTAdd.Text = "Добавить";
            this.BTAdd.UseVisualStyleBackColor = true;
            this.BTAdd.Click += new System.EventHandler(this.BTAdd_Click);
            // 
            // YslygaAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(228, 155);
            this.Controls.Add(this.BTAdd);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.LB2);
            this.Controls.Add(this.LB1);
            this.Name = "YslygaAdd";
            this.Text = "Добавить услугу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB1;
        private System.Windows.Forms.Label LB2;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.Button BTAdd;
    }
}