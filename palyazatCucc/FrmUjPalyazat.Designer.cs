
namespace palyazatCucc
{
    partial class FrmUjPalyazat
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblAKategoria = new System.Windows.Forms.Label();
            this.lblCKategoria = new System.Windows.Forms.Label();
            this.lblHufTop = new System.Windows.Forms.Label();
            this.lblHufBottom = new System.Windows.Forms.Label();
            this.tbAKategoria = new System.Windows.Forms.TextBox();
            this.tbCKategoria = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btnUjPalyazat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 34);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // lblAKategoria
            // 
            this.lblAKategoria.AutoSize = true;
            this.lblAKategoria.Location = new System.Drawing.Point(12, 67);
            this.lblAKategoria.Name = "lblAKategoria";
            this.lblAKategoria.Size = new System.Drawing.Size(126, 13);
            this.lblAKategoria.TabIndex = 0;
            this.lblAKategoria.Text = "\"A\" Kategória értékkeret:";
            // 
            // lblCKategoria
            // 
            this.lblCKategoria.AutoSize = true;
            this.lblCKategoria.Location = new System.Drawing.Point(12, 128);
            this.lblCKategoria.Name = "lblCKategoria";
            this.lblCKategoria.Size = new System.Drawing.Size(126, 13);
            this.lblCKategoria.TabIndex = 0;
            this.lblCKategoria.Text = "\"C\" Kategória értékkeret:";
            // 
            // lblHufTop
            // 
            this.lblHufTop.AutoSize = true;
            this.lblHufTop.Location = new System.Drawing.Point(209, 86);
            this.lblHufTop.Name = "lblHufTop";
            this.lblHufTop.Size = new System.Drawing.Size(29, 13);
            this.lblHufTop.TabIndex = 0;
            this.lblHufTop.Text = "HUF";
            // 
            // lblHufBottom
            // 
            this.lblHufBottom.AutoSize = true;
            this.lblHufBottom.Location = new System.Drawing.Point(209, 147);
            this.lblHufBottom.Name = "lblHufBottom";
            this.lblHufBottom.Size = new System.Drawing.Size(29, 13);
            this.lblHufBottom.TabIndex = 0;
            this.lblHufBottom.Text = "HUF";
            // 
            // tbAKategoria
            // 
            this.tbAKategoria.Location = new System.Drawing.Point(12, 83);
            this.tbAKategoria.Name = "tbAKategoria";
            this.tbAKategoria.Size = new System.Drawing.Size(191, 20);
            this.tbAKategoria.TabIndex = 1;
            // 
            // tbCKategoria
            // 
            this.tbCKategoria.Location = new System.Drawing.Point(12, 144);
            this.tbCKategoria.Name = "tbCKategoria";
            this.tbCKategoria.Size = new System.Drawing.Size(191, 20);
            this.tbCKategoria.TabIndex = 1;
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(36, 31);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(32, 20);
            this.tbID.TabIndex = 1;
            // 
            // btnUjPalyazat
            // 
            this.btnUjPalyazat.Location = new System.Drawing.Point(12, 179);
            this.btnUjPalyazat.Name = "btnUjPalyazat";
            this.btnUjPalyazat.Size = new System.Drawing.Size(226, 40);
            this.btnUjPalyazat.TabIndex = 2;
            this.btnUjPalyazat.Text = "Új pályázat hirdetése";
            this.btnUjPalyazat.UseVisualStyleBackColor = true;
            this.btnUjPalyazat.Click += new System.EventHandler(this.btnUjPalyazat_Click);
            // 
            // FrmUjPalyazat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 234);
            this.Controls.Add(this.btnUjPalyazat);
            this.Controls.Add(this.tbCKategoria);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbAKategoria);
            this.Controls.Add(this.lblCKategoria);
            this.Controls.Add(this.lblAKategoria);
            this.Controls.Add(this.lblHufBottom);
            this.Controls.Add(this.lblHufTop);
            this.Controls.Add(this.lblID);
            this.Name = "FrmUjPalyazat";
            this.Text = "Új pályázat rögzítése";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAKategoria;
        private System.Windows.Forms.Label lblCKategoria;
        private System.Windows.Forms.Label lblHufTop;
        private System.Windows.Forms.Label lblHufBottom;
        private System.Windows.Forms.TextBox tbAKategoria;
        private System.Windows.Forms.TextBox tbCKategoria;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btnUjPalyazat;
    }
}