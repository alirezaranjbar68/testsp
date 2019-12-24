namespace sepyar.program.Class
{
    partial class pic_mnu_cmd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pic_mnu_cmd));
            this.pnl_user = new System.Windows.Forms.Panel();
            this.pic_cmd = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pnl_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cmd)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_user
            // 
            this.pnl_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_user.Controls.Add(this.pic_cmd);
            this.pnl_user.Controls.Add(this.lbl_name);
            this.pnl_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_user.Font = new System.Drawing.Font("B Yekan", 9.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.pnl_user.Location = new System.Drawing.Point(1, 0);
            this.pnl_user.Name = "pnl_user";
            this.pnl_user.Size = new System.Drawing.Size(91, 72);
            this.pnl_user.TabIndex = 6;
            this.pnl_user.Click += new System.EventHandler(this.pnl_user_Click);
            // 
            // pic_cmd
            // 
            this.pic_cmd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_cmd.Image = ((System.Drawing.Image)(resources.GetObject("pic_cmd.Image")));
            this.pic_cmd.Location = new System.Drawing.Point(23, 3);
            this.pic_cmd.Name = "pic_cmd";
            this.pic_cmd.Size = new System.Drawing.Size(47, 45);
            this.pic_cmd.TabIndex = 6;
            this.pic_cmd.TabStop = false;
            this.pic_cmd.Click += new System.EventHandler(this.pic_cmd_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_name.Location = new System.Drawing.Point(3, 48);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(85, 20);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "مدیریت کاربران";
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // pic_mnu_cmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_user);
            this.Name = "pic_mnu_cmd";
            this.Size = new System.Drawing.Size(92, 71);
            this.pnl_user.ResumeLayout(false);
            this.pnl_user.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cmd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_user;
        private System.Windows.Forms.PictureBox pic_cmd;
        private System.Windows.Forms.Label lbl_name;
    }
}
