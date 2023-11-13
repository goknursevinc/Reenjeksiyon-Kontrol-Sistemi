
namespace BDO_Project
{
    partial class Dora3Santral
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
            this.dgw_dora3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_referans = new System.Windows.Forms.Label();
            this.lbl_kuyu1ps = new System.Windows.Forms.Label();
            this.lbl_kuyu1debi = new System.Windows.Forms.Label();
            this.lbl_kuyu2debi = new System.Windows.Forms.Label();
            this.lbl_kuyu2ps = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_dora3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_dora3
            // 
            this.dgw_dora3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_dora3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_dora3.Location = new System.Drawing.Point(12, 12);
            this.dgw_dora3.Name = "dgw_dora3";
            this.dgw_dora3.RowHeadersWidth = 51;
            this.dgw_dora3.RowTemplate.Height = 24;
            this.dgw_dora3.Size = new System.Drawing.Size(776, 150);
            this.dgw_dora3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Basınç referans değer aralığı: 58 - 67 Pa\r\n\r\n";
            // 
            // lbl_referans
            // 
            this.lbl_referans.AutoSize = true;
            this.lbl_referans.Location = new System.Drawing.Point(9, 209);
            this.lbl_referans.Name = "lbl_referans";
            this.lbl_referans.Size = new System.Drawing.Size(345, 17);
            this.lbl_referans.TabIndex = 7;
            this.lbl_referans.Text = "Debi referans değer aralığı:  531.000 - 605.000 t/saat";
            // 
            // lbl_kuyu1ps
            // 
            this.lbl_kuyu1ps.AutoSize = true;
            this.lbl_kuyu1ps.Location = new System.Drawing.Point(9, 378);
            this.lbl_kuyu1ps.Name = "lbl_kuyu1ps";
            this.lbl_kuyu1ps.Size = new System.Drawing.Size(0, 17);
            this.lbl_kuyu1ps.TabIndex = 9;
            // 
            // lbl_kuyu1debi
            // 
            this.lbl_kuyu1debi.AutoSize = true;
            this.lbl_kuyu1debi.Location = new System.Drawing.Point(9, 337);
            this.lbl_kuyu1debi.Name = "lbl_kuyu1debi";
            this.lbl_kuyu1debi.Size = new System.Drawing.Size(0, 17);
            this.lbl_kuyu1debi.TabIndex = 10;
            // 
            // lbl_kuyu2debi
            // 
            this.lbl_kuyu2debi.AutoSize = true;
            this.lbl_kuyu2debi.Location = new System.Drawing.Point(403, 337);
            this.lbl_kuyu2debi.Name = "lbl_kuyu2debi";
            this.lbl_kuyu2debi.Size = new System.Drawing.Size(0, 17);
            this.lbl_kuyu2debi.TabIndex = 12;
            // 
            // lbl_kuyu2ps
            // 
            this.lbl_kuyu2ps.AutoSize = true;
            this.lbl_kuyu2ps.Location = new System.Drawing.Point(403, 378);
            this.lbl_kuyu2ps.Name = "lbl_kuyu2ps";
            this.lbl_kuyu2ps.Size = new System.Drawing.Size(0, 17);
            this.lbl_kuyu2ps.TabIndex = 11;
            // 
            // Dora3Santral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_kuyu2debi);
            this.Controls.Add(this.lbl_kuyu2ps);
            this.Controls.Add(this.lbl_kuyu1debi);
            this.Controls.Add(this.lbl_kuyu1ps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_referans);
            this.Controls.Add(this.dgw_dora3);
            this.Name = "Dora3Santral";
            this.Text = "Dora 3 Santral";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dora3Santral_FormClosing);
            this.Load += new System.EventHandler(this.Dora3Santral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_dora3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_dora3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_referans;
        private System.Windows.Forms.Label lbl_kuyu1ps;
        private System.Windows.Forms.Label lbl_kuyu1debi;
        private System.Windows.Forms.Label lbl_kuyu2debi;
        private System.Windows.Forms.Label lbl_kuyu2ps;
    }
}