namespace PetHavenManagementSystem
{
    partial class AdminForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnimageback = new Guna.UI.WinForms.GunaImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btnLogin = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cbxshowpass = new Guna.UI.WinForms.GunaCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtusername = new Guna.UI.WinForms.GunaTextBox();
            this.btnregisteradmin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxusertype = new System.Windows.Forms.ComboBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(53, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 326);
            this.panel1.TabIndex = 0;
            // 
            // btnimageback
            // 
            this.btnimageback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnimageback.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnimageback.Image = ((System.Drawing.Image)(resources.GetObject("btnimageback.Image")));
            this.btnimageback.ImageSize = new System.Drawing.Size(30, 30);
            this.btnimageback.Location = new System.Drawing.Point(728, 0);
            this.btnimageback.Name = "btnimageback";
            this.btnimageback.OnHoverImage = null;
            this.btnimageback.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnimageback.Size = new System.Drawing.Size(34, 26);
            this.btnimageback.TabIndex = 3;
            this.btnimageback.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.btnimageback);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 29);
            this.panel2.TabIndex = 2;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 2;
            this.gunaElipse1.TargetControl = this;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLogin.AnimationHoverSpeed = 0.07F;
            this.btnLogin.AnimationSpeed = 0.03F;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BaseColor1 = System.Drawing.Color.DeepSkyBlue;
            this.btnLogin.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogin.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = null;
            this.btnLogin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogin.Location = new System.Drawing.Point(503, 357);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogin.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogin.OnHoverImage = null;
            this.btnLogin.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogin.Radius = 18;
            this.btnLogin.Size = new System.Drawing.Size(153, 41);
            this.btnLogin.TabIndex = 33;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextOffsetX = 50;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_2);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(450, 230);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(60, 15);
            this.gunaLabel2.TabIndex = 32;
            this.gunaLabel2.Text = "Password:";
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(447, 149);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(63, 15);
            this.gunaLabel1.TabIndex = 31;
            this.gunaLabel1.Text = "Username:";
            // 
            // cbxshowpass
            // 
            this.cbxshowpass.BaseColor = System.Drawing.Color.White;
            this.cbxshowpass.CheckedOffColor = System.Drawing.Color.Gray;
            this.cbxshowpass.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxshowpass.FillColor = System.Drawing.Color.White;
            this.cbxshowpass.Font = new System.Drawing.Font("Bell MT", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxshowpass.Location = new System.Drawing.Point(450, 297);
            this.cbxshowpass.Name = "cbxshowpass";
            this.cbxshowpass.Size = new System.Drawing.Size(89, 20);
            this.cbxshowpass.TabIndex = 30;
            this.cbxshowpass.Text = "Show Password";
            this.cbxshowpass.CheckedChanged += new System.EventHandler(this.cbxshowpass_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 31);
            this.label1.TabIndex = 29;
            this.label1.Text = "Welcome Admin!";
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.Transparent;
            this.txtpassword.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtpassword.BorderColor = System.Drawing.Color.Silver;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtpassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtpassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtpassword.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(450, 259);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '\0';
            this.txtpassword.Radius = 15;
            this.txtpassword.SelectedText = "";
            this.txtpassword.Size = new System.Drawing.Size(234, 36);
            this.txtpassword.TabIndex = 28;
            this.txtpassword.TextOffsetX = 12;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.Transparent;
            this.txtusername.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtusername.BorderColor = System.Drawing.Color.Silver;
            this.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusername.FocusedBaseColor = System.Drawing.Color.White;
            this.txtusername.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtusername.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtusername.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(450, 177);
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.Radius = 15;
            this.txtusername.SelectedText = "";
            this.txtusername.Size = new System.Drawing.Size(234, 36);
            this.txtusername.TabIndex = 27;
            this.txtusername.TextOffsetX = 12;
            // 
            // btnregisteradmin
            // 
            this.btnregisteradmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregisteradmin.ForeColor = System.Drawing.Color.Blue;
            this.btnregisteradmin.Location = new System.Drawing.Point(503, 452);
            this.btnregisteradmin.Name = "btnregisteradmin";
            this.btnregisteradmin.Size = new System.Drawing.Size(153, 35);
            this.btnregisteradmin.TabIndex = 35;
            this.btnregisteradmin.Text = "Register";
            this.btnregisteradmin.UseVisualStyleBackColor = true;
            this.btnregisteradmin.Click += new System.EventHandler(this.btnregisteradmin_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Or";
            // 
            // cbxusertype
            // 
            this.cbxusertype.FormattingEnabled = true;
            this.cbxusertype.Location = new System.Drawing.Point(220, 431);
            this.cbxusertype.Name = "cbxusertype";
            this.cbxusertype.Size = new System.Drawing.Size(121, 21);
            this.cbxusertype.TabIndex = 36;
            this.cbxusertype.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(145, 433);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(66, 15);
            this.gunaLabel3.TabIndex = 37;
            this.gunaLabel3.Text = "User Types:";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 525);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.cbxusertype);
            this.Controls.Add(this.btnregisteradmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.cbxshowpass);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaImageButton btnimageback;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaGradientButton btnLogin;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtpassword;
        private Guna.UI.WinForms.GunaCheckBox cbxshowpass;
        private Guna.UI.WinForms.GunaTextBox txtusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnregisteradmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxusertype;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
    }
}