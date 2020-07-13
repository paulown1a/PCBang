namespace loginform
{
    partial class NewAccountForm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.txbPasswordConfirm = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.이름 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.비밀번호 = new DevExpress.XtraLayout.LayoutControlItem();
            this.비밀번호확인 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblNewAccount = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.이름)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.비밀번호)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.비밀번호확인)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNewAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.btnCreate);
            this.layoutControl1.Controls.Add(this.txbPasswordConfirm);
            this.layoutControl1.Controls.Add(this.txbPassword);
            this.layoutControl1.Controls.Add(this.txbId);
            this.layoutControl1.Controls.Add(this.txbName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(797, 212, 812, 500);
            this.layoutControl1.OptionsView.UseSkinIndents = false;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(352, 519);
            this.layoutControl1.TabIndex = 7;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Location = new System.Drawing.Point(5, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(342, 31);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "회원가입";
            // 
            // btnCreate
            // 
            this.btnCreate.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCreate.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Appearance.Options.UseBackColor = true;
            this.btnCreate.Appearance.Options.UseFont = true;
            this.btnCreate.Appearance.Options.UseForeColor = true;
            this.btnCreate.AutoWidthInLayoutControl = true;
            this.btnCreate.Location = new System.Drawing.Point(6, 466);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(341, 48);
            this.btnCreate.StyleController = this.layoutControl1;
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "가입하기";
            this.btnCreate.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txbPasswordConfirm
            // 
            this.txbPasswordConfirm.Font = new System.Drawing.Font("Gulim", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txbPasswordConfirm.Location = new System.Drawing.Point(106, 151);
            this.txbPasswordConfirm.Name = "txbPasswordConfirm";
            this.txbPasswordConfirm.Size = new System.Drawing.Size(241, 25);
            this.txbPasswordConfirm.TabIndex = 6;
            this.txbPasswordConfirm.TextChanged += new System.EventHandler(this.txbPasswordConfirm_TextChanged);
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Gulim", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txbPassword.Location = new System.Drawing.Point(106, 116);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(241, 25);
            this.txbPassword.TabIndex = 4;
            this.txbPassword.TextChanged += new System.EventHandler(this.txbPassword_TextChanged);
            // 
            // txbId
            // 
            this.txbId.Font = new System.Drawing.Font("Gulim", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txbId.Location = new System.Drawing.Point(106, 81);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(241, 25);
            this.txbId.TabIndex = 3;
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Gulim", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txbName.Location = new System.Drawing.Point(106, 46);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(241, 25);
            this.txbName.TabIndex = 1;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.이름,
            this.layoutControlItem2,
            this.비밀번호,
            this.비밀번호확인,
            this.simpleSeparator1,
            this.emptySpaceItem1,
            this.layoutControlItem5,
            this.lblNewAccount});
            this.Root.Name = "Root";
            this.Root.OptionsItemText.TextToControlDistance = 5;
            this.Root.Size = new System.Drawing.Size(352, 519);
            this.Root.TextVisible = false;
            // 
            // 이름
            // 
            this.이름.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.이름.AppearanceItemCaption.Options.UseFont = true;
            this.이름.Control = this.txbName;
            this.이름.Location = new System.Drawing.Point(0, 41);
            this.이름.Name = "이름";
            this.이름.Size = new System.Drawing.Size(352, 35);
            this.이름.TextSize = new System.Drawing.Size(96, 24);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.txbId;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 76);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(352, 35);
            this.layoutControlItem2.Text = "ID";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(96, 24);
            // 
            // 비밀번호
            // 
            this.비밀번호.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.비밀번호.AppearanceItemCaption.Options.UseFont = true;
            this.비밀번호.Control = this.txbPassword;
            this.비밀번호.Location = new System.Drawing.Point(0, 111);
            this.비밀번호.Name = "비밀번호";
            this.비밀번호.Size = new System.Drawing.Size(352, 35);
            this.비밀번호.TextSize = new System.Drawing.Size(96, 24);
            // 
            // 비밀번호확인
            // 
            this.비밀번호확인.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.비밀번호확인.AppearanceItemCaption.Options.UseFont = true;
            this.비밀번호확인.Control = this.txbPasswordConfirm;
            this.비밀번호확인.Location = new System.Drawing.Point(0, 146);
            this.비밀번호확인.Name = "비밀번호확인";
            this.비밀번호확인.Size = new System.Drawing.Size(352, 35);
            this.비밀번호확인.TextSize = new System.Drawing.Size(96, 24);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 181);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(1, 338);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(1, 181);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(351, 280);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnCreate;
            this.layoutControlItem5.Location = new System.Drawing.Point(1, 461);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(101, 44);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(351, 58);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // lblNewAccount
            // 
            this.lblNewAccount.Control = this.labelControl1;
            this.lblNewAccount.Location = new System.Drawing.Point(0, 0);
            this.lblNewAccount.MinSize = new System.Drawing.Size(94, 39);
            this.lblNewAccount.Name = "lblNewAccount";
            this.lblNewAccount.Size = new System.Drawing.Size(352, 41);
            this.lblNewAccount.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lblNewAccount.TextSize = new System.Drawing.Size(0, 0);
            this.lblNewAccount.TextVisible = false;
            // 
            // NewAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 519);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewAccountForm";
            this.Text = "회원가입";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.이름)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.비밀번호)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.비밀번호확인)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNewAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.TextBox txbPassword;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private System.Windows.Forms.TextBox txbPasswordConfirm;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem 비밀번호;
        private DevExpress.XtraLayout.LayoutControlItem 비밀번호확인;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.LayoutControlItem 이름;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControlItem lblNewAccount;
    }
}

