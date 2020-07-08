namespace PC_Project.Client
{
    partial class HomeDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnHome = new System.Windows.Forms.Panel();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblExplain = new System.Windows.Forms.Label();
            this.PnHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnHome
            // 
            this.PnHome.Controls.Add(this.lblExplain);
            this.PnHome.Controls.Add(this.lblHome);
            this.PnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnHome.Location = new System.Drawing.Point(0, 0);
            this.PnHome.Name = "PnHome";
            this.PnHome.Size = new System.Drawing.Size(805, 463);
            this.PnHome.TabIndex = 0;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Location = new System.Drawing.Point(43, 41);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(68, 15);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "PC Order";
            // 
            // lblExplain
            // 
            this.lblExplain.AutoSize = true;
            this.lblExplain.Location = new System.Drawing.Point(264, 41);
            this.lblExplain.Name = "lblExplain";
            this.lblExplain.Size = new System.Drawing.Size(97, 15);
            this.lblExplain.TabIndex = 1;
            this.lblExplain.Text = "설명설명설명";
            // 
            // HomeDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnHome);
            this.Name = "HomeDisplay";
            this.Size = new System.Drawing.Size(805, 463);
            this.PnHome.ResumeLayout(false);
            this.PnHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnHome;
        private System.Windows.Forms.Label lblExplain;
        private System.Windows.Forms.Label lblHome;
    }
}
