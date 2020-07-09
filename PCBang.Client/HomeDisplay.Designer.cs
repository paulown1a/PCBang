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
            this.lblExplain = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.pnHomedisplayIcon = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.PnHome.SuspendLayout();
            this.pnHomedisplayIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnHome
            // 
            this.PnHome.BackColor = System.Drawing.Color.White;
            this.PnHome.Controls.Add(this.pnHomedisplayIcon);
            this.PnHome.Controls.Add(this.lblExplain);
            this.PnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnHome.Location = new System.Drawing.Point(0, 0);
            this.PnHome.Name = "PnHome";
            this.PnHome.Size = new System.Drawing.Size(805, 463);
            this.PnHome.TabIndex = 0;
            // 
            // lblExplain
            // 
            this.lblExplain.AutoSize = true;
            this.lblExplain.Font = new System.Drawing.Font("Expo M", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblExplain.Location = new System.Drawing.Point(274, 51);
            this.lblExplain.Name = "lblExplain";
            this.lblExplain.Size = new System.Drawing.Size(391, 42);
            this.lblExplain.TabIndex = 1;
            this.lblExplain.Text = "주문하신 메뉴는 자리로 가져다 드립니다.\r\n요금은 선불입니다.";
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Hobo BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.White;
            this.lblHome.Location = new System.Drawing.Point(20, 96);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(100, 74);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "FOOD\r\nOrder";
            // 
            // pnHomedisplayIcon
            // 
            this.pnHomedisplayIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.pnHomedisplayIcon.Controls.Add(this.iconPictureBox1);
            this.pnHomedisplayIcon.Controls.Add(this.lblHome);
            this.pnHomedisplayIcon.Location = new System.Drawing.Point(65, 0);
            this.pnHomedisplayIcon.Name = "pnHomedisplayIcon";
            this.pnHomedisplayIcon.Size = new System.Drawing.Size(143, 202);
            this.pnHomedisplayIcon.TabIndex = 2;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Hamburger;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconSize = 63;
            this.iconPictureBox1.Location = new System.Drawing.Point(36, 15);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(72, 63);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
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
            this.pnHomedisplayIcon.ResumeLayout(false);
            this.pnHomedisplayIcon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnHome;
        private System.Windows.Forms.Label lblExplain;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Panel pnHomedisplayIcon;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
