
namespace BDO_Project
{
    partial class formSantral
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
            this.btn_EfelerJeo = new System.Windows.Forms.Button();
            this.btn_Dora3Jeo = new System.Windows.Forms.Button();
            this.btn_BuharkentJeo = new System.Windows.Forms.Button();
            this.lbl_santral = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_EfelerJeo
            // 
            this.btn_EfelerJeo.Location = new System.Drawing.Point(80, 140);
            this.btn_EfelerJeo.Name = "btn_EfelerJeo";
            this.btn_EfelerJeo.Size = new System.Drawing.Size(266, 42);
            this.btn_EfelerJeo.TabIndex = 0;
            this.btn_EfelerJeo.Text = "EFELER JEOTERMAL";
            this.btn_EfelerJeo.UseVisualStyleBackColor = true;
            this.btn_EfelerJeo.Click += new System.EventHandler(this.btn_EfelerJeo_Click);
            // 
            // btn_Dora3Jeo
            // 
            this.btn_Dora3Jeo.Location = new System.Drawing.Point(80, 212);
            this.btn_Dora3Jeo.Name = "btn_Dora3Jeo";
            this.btn_Dora3Jeo.Size = new System.Drawing.Size(266, 42);
            this.btn_Dora3Jeo.TabIndex = 3;
            this.btn_Dora3Jeo.Text = "DORA 3 JEOTERMAL";
            this.btn_Dora3Jeo.UseVisualStyleBackColor = true;
            this.btn_Dora3Jeo.Click += new System.EventHandler(this.btn_Dora3Jeo_Click);
            // 
            // btn_BuharkentJeo
            // 
            this.btn_BuharkentJeo.Location = new System.Drawing.Point(80, 284);
            this.btn_BuharkentJeo.Name = "btn_BuharkentJeo";
            this.btn_BuharkentJeo.Size = new System.Drawing.Size(266, 42);
            this.btn_BuharkentJeo.TabIndex = 4;
            this.btn_BuharkentJeo.Text = "BUHARKENT JEOTERMAL";
            this.btn_BuharkentJeo.UseVisualStyleBackColor = true;
            this.btn_BuharkentJeo.Click += new System.EventHandler(this.btn_BuharkentJeo_Click);
            // 
            // lbl_santral
            // 
            this.lbl_santral.AutoSize = true;
            this.lbl_santral.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_santral.Location = new System.Drawing.Point(124, 81);
            this.lbl_santral.Name = "lbl_santral";
            this.lbl_santral.Size = new System.Drawing.Size(179, 29);
            this.lbl_santral.TabIndex = 5;
            this.lbl_santral.Text = "SANTRALLER";
            // 
            // formSantral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 384);
            this.Controls.Add(this.lbl_santral);
            this.Controls.Add(this.btn_BuharkentJeo);
            this.Controls.Add(this.btn_Dora3Jeo);
            this.Controls.Add(this.btn_EfelerJeo);
            this.Name = "formSantral";
            this.Text = "Santraller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formSantral_FormClosing);
            this.Load += new System.EventHandler(this.formSantral_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_EfelerJeo;
        private System.Windows.Forms.Button btn_Dora3Jeo;
        private System.Windows.Forms.Button btn_BuharkentJeo;
        private System.Windows.Forms.Label lbl_santral;
    }
}

