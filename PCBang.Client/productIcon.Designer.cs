namespace loginform
{
    partial class ProductIcon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.ProductPhoto = new System.Windows.Forms.PictureBox();
            this.btnCount = new DevExpress.XtraEditors.SpinEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.OrderBtn);
            this.panel1.Controls.Add(this.ProductPhoto);
            this.panel1.Controls.Add(this.btnCount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 170);
            this.panel1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.Location = new System.Drawing.Point(178, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(121, 26);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(178, 77);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(63, 15);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "\\ 1,000";
            // 
            // OrderBtn
            // 
            this.OrderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderBtn.Location = new System.Drawing.Point(181, 113);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(118, 34);
            this.OrderBtn.TabIndex = 1;
            this.OrderBtn.Text = "Order";
            this.OrderBtn.UseVisualStyleBackColor = true;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // ProductPhoto
            // 
            this.ProductPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ProductPhoto.Location = new System.Drawing.Point(16, 12);
            this.ProductPhoto.Name = "ProductPhoto";
            this.ProductPhoto.Size = new System.Drawing.Size(140, 135);
            this.ProductPhoto.TabIndex = 0;
            this.ProductPhoto.TabStop = false;
            // 
            // btnCount
            // 
            this.btnCount.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.btnCount.Location = new System.Drawing.Point(247, 72);
            this.btnCount.Name = "btnCount";
            this.btnCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.btnCount.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.btnCount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.btnCount.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.btnCount.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.btnCount.Size = new System.Drawing.Size(52, 24);
            this.btnCount.TabIndex = 4;
            // 
            // productIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Name = "productIcon";
            this.Size = new System.Drawing.Size(328, 170);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCount.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.PictureBox ProductPhoto;
        private DevExpress.XtraEditors.SpinEdit btnCount;
    }
}
