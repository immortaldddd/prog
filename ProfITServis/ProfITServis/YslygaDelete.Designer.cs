
namespace ProfITServis
{
    partial class YslygaDelete
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
            this.label1 = new System.Windows.Forms.Label();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.BT1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(42, 43);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(139, 20);
            this.TB1.TabIndex = 1;
            // 
            // BT1
            // 
            this.BT1.Location = new System.Drawing.Point(42, 69);
            this.BT1.Name = "BT1";
            this.BT1.Size = new System.Drawing.Size(139, 41);
            this.BT1.TabIndex = 2;
            this.BT1.Text = "Удалить";
            this.BT1.UseVisualStyleBackColor = true;
            this.BT1.Click += new System.EventHandler(this.BT1_Click);
            // 
            // YslygaDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(234, 137);
            this.Controls.Add(this.BT1);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.label1);
            this.Name = "YslygaDelete";
            this.Text = "Удалить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.Button BT1;
    }
}