
namespace palyazatCucc
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvAllapot = new System.Windows.Forms.DataGridView();
            this.BtnUj = new System.Windows.Forms.Button();
            this.BtnKilep = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keretosszeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szamlakSzama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szamlakOsszege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllapot)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvAllapot
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAllapot.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DgvAllapot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAllapot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.keretosszeg,
            this.szamlakSzama,
            this.szamlakOsszege});
            this.DgvAllapot.Location = new System.Drawing.Point(12, 12);
            this.DgvAllapot.Name = "DgvAllapot";
            this.DgvAllapot.RowHeadersVisible = false;
            this.DgvAllapot.Size = new System.Drawing.Size(594, 316);
            this.DgvAllapot.TabIndex = 0;
            // 
            // BtnUj
            // 
            this.BtnUj.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnUj.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnUj.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnUj.Location = new System.Drawing.Point(12, 334);
            this.BtnUj.Name = "BtnUj";
            this.BtnUj.Size = new System.Drawing.Size(293, 104);
            this.BtnUj.TabIndex = 1;
            this.BtnUj.Text = "Új pályázat";
            this.BtnUj.UseVisualStyleBackColor = false;
            this.BtnUj.Click += new System.EventHandler(this.BtnUj_Click);
            // 
            // BtnKilep
            // 
            this.BtnKilep.BackColor = System.Drawing.Color.Red;
            this.BtnKilep.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnKilep.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnKilep.Location = new System.Drawing.Point(311, 334);
            this.BtnKilep.Name = "BtnKilep";
            this.BtnKilep.Size = new System.Drawing.Size(293, 104);
            this.BtnKilep.TabIndex = 1;
            this.BtnKilep.Text = "Kilépés";
            this.BtnKilep.UseVisualStyleBackColor = false;
            this.BtnKilep.Click += new System.EventHandler(this.BtnKilep_Click);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "id";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ID.DefaultCellStyle = dataGridViewCellStyle12;
            this.ID.FillWeight = 30.45685F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // keretosszeg
            // 
            this.keretosszeg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.keretosszeg.DataPropertyName = "keretosszeg";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "### ### ### ### Ft";
            dataGridViewCellStyle13.NullValue = " ";
            this.keretosszeg.DefaultCellStyle = dataGridViewCellStyle13;
            this.keretosszeg.FillWeight = 123.181F;
            this.keretosszeg.HeaderText = "keretösszeg";
            this.keretosszeg.Name = "keretosszeg";
            // 
            // szamlakSzama
            // 
            this.szamlakSzama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.szamlakSzama.DataPropertyName = "szamlakSzama";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "### db";
            dataGridViewCellStyle14.NullValue = " ";
            this.szamlakSzama.DefaultCellStyle = dataGridViewCellStyle14;
            this.szamlakSzama.FillWeight = 123.181F;
            this.szamlakSzama.HeaderText = "Számlák száma";
            this.szamlakSzama.Name = "szamlakSzama";
            // 
            // szamlakOsszege
            // 
            this.szamlakOsszege.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.szamlakOsszege.DataPropertyName = "szamlakOsszege";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "### ### ### ### Ft";
            dataGridViewCellStyle15.NullValue = " ";
            this.szamlakOsszege.DefaultCellStyle = dataGridViewCellStyle15;
            this.szamlakOsszege.FillWeight = 123.181F;
            this.szamlakOsszege.HeaderText = "Számlák összege";
            this.szamlakOsszege.Name = "szamlakOsszege";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.BtnKilep);
            this.Controls.Add(this.BtnUj);
            this.Controls.Add(this.DgvAllapot);
            this.Name = "FrmMain";
            this.Text = "Pályázatok állapota";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAllapot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAllapot;
        private System.Windows.Forms.Button BtnUj;
        private System.Windows.Forms.Button BtnKilep;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn keretosszeg;
        private System.Windows.Forms.DataGridViewTextBoxColumn szamlakSzama;
        private System.Windows.Forms.DataGridViewTextBoxColumn szamlakOsszege;
    }
}

