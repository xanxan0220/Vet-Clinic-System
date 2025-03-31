namespace PetHavenManagementSystem.Components
{
    partial class AdminRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRegisterForm));
            this.label6 = new System.Windows.Forms.Label();
            this.cbxusertype = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnregister = new Guna.UI.WinForms.GunaGradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtadress = new Guna.UI.WinForms.GunaTextBox();
            this.txtpassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtusername = new Guna.UI.WinForms.GunaTextBox();
            this.linklbalreadyhaveanaccount = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtphone = new Guna.UI.WinForms.GunaTextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 54;
            this.label6.Text = "User Type:";
            // 
            // cbxusertype
            // 
            this.cbxusertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxusertype.FormattingEnabled = true;
            this.cbxusertype.Location = new System.Drawing.Point(127, 364);
            this.cbxusertype.Name = "cbxusertype";
            this.cbxusertype.Size = new System.Drawing.Size(143, 23);
            this.cbxusertype.TabIndex = 53;
            this.cbxusertype.SelectedIndexChanged += new System.EventHandler(this.cbxusertype_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(367, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 26);
            this.label5.TabIndex = 52;
            this.label5.Text = "Email:";
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.Transparent;
            this.txtemail.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtemail.BorderColor = System.Drawing.Color.Silver;
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtemail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtemail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(367, 236);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.Radius = 15;
            this.txtemail.SelectedText = "";
            this.txtemail.Size = new System.Drawing.Size(246, 33);
            this.txtemail.TabIndex = 51;
            this.txtemail.TextOffsetX = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(367, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 26);
            this.label4.TabIndex = 50;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 26);
            this.label3.TabIndex = 49;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 48;
            this.label2.Text = "Username:";
            // 
            // btnregister
            // 
            this.btnregister.AnimationHoverSpeed = 0.07F;
            this.btnregister.AnimationSpeed = 0.03F;
            this.btnregister.BackColor = System.Drawing.Color.Transparent;
            this.btnregister.BaseColor1 = System.Drawing.Color.Blue;
            this.btnregister.BaseColor2 = System.Drawing.Color.LightBlue;
            this.btnregister.BorderColor = System.Drawing.Color.Black;
            this.btnregister.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnregister.FocusedColor = System.Drawing.Color.Empty;
            this.btnregister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnregister.ForeColor = System.Drawing.Color.White;
            this.btnregister.Image = null;
            this.btnregister.ImageSize = new System.Drawing.Size(20, 20);
            this.btnregister.Location = new System.Drawing.Point(273, 453);
            this.btnregister.Name = "btnregister";
            this.btnregister.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnregister.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnregister.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnregister.OnHoverForeColor = System.Drawing.Color.White;
            this.btnregister.OnHoverImage = null;
            this.btnregister.OnPressedColor = System.Drawing.Color.Black;
            this.btnregister.Radius = 15;
            this.btnregister.Size = new System.Drawing.Size(161, 45);
            this.btnregister.TabIndex = 47;
            this.btnregister.Text = "Register";
            this.btnregister.TextOffsetX = 50;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "Registration Form";
            // 
            // txtadress
            // 
            this.txtadress.BackColor = System.Drawing.Color.Transparent;
            this.txtadress.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtadress.BorderColor = System.Drawing.Color.Silver;
            this.txtadress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtadress.FocusedBaseColor = System.Drawing.Color.White;
            this.txtadress.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtadress.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtadress.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadress.Location = new System.Drawing.Point(367, 312);
            this.txtadress.Name = "txtadress";
            this.txtadress.PasswordChar = '\0';
            this.txtadress.Radius = 15;
            this.txtadress.SelectedText = "";
            this.txtadress.Size = new System.Drawing.Size(246, 34);
            this.txtadress.TabIndex = 45;
            this.txtadress.TextOffsetX = 12;
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.Transparent;
            this.txtpassword.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtpassword.BorderColor = System.Drawing.Color.Silver;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtpassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtpassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(371, 162);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '\0';
            this.txtpassword.Radius = 15;
            this.txtpassword.SelectedText = "";
            this.txtpassword.Size = new System.Drawing.Size(242, 33);
            this.txtpassword.TabIndex = 44;
            this.txtpassword.TextOffsetX = 12;
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
            this.txtusername.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(371, 94);
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.Radius = 15;
            this.txtusername.SelectedText = "";
            this.txtusername.Size = new System.Drawing.Size(242, 33);
            this.txtusername.TabIndex = 43;
            this.txtusername.TextOffsetX = 12;
            // 
            // linklbalreadyhaveanaccount
            // 
            this.linklbalreadyhaveanaccount.AutoSize = true;
            this.linklbalreadyhaveanaccount.Location = new System.Drawing.Point(535, 511);
            this.linklbalreadyhaveanaccount.Name = "linklbalreadyhaveanaccount";
            this.linklbalreadyhaveanaccount.Size = new System.Drawing.Size(132, 13);
            this.linklbalreadyhaveanaccount.TabIndex = 42;
            this.linklbalreadyhaveanaccount.TabStop = true;
            this.linklbalreadyhaveanaccount.Text = "Already have an account?";
            this.linklbalreadyhaveanaccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbalreadyhaveanaccount_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(37, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 270);
            this.panel1.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(367, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 26);
            this.label7.TabIndex = 56;
            this.label7.Text = "Contact No.";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtphone
            // 
            this.txtphone.BackColor = System.Drawing.Color.Transparent;
            this.txtphone.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtphone.BorderColor = System.Drawing.Color.Silver;
            this.txtphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtphone.FocusedBaseColor = System.Drawing.Color.White;
            this.txtphone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtphone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtphone.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.Location = new System.Drawing.Point(367, 390);
            this.txtphone.Name = "txtphone";
            this.txtphone.PasswordChar = '\0';
            this.txtphone.Radius = 15;
            this.txtphone.SelectedText = "";
            this.txtphone.Size = new System.Drawing.Size(246, 34);
            this.txtphone.TabIndex = 55;
            this.txtphone.TextOffsetX = 12;
            // 
            // AdminRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(693, 536);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxusertype);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtadress);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.linklbalreadyhaveanaccount);
            this.Controls.Add(this.panel1);
            this.Name = "AdminRegisterForm";
            this.Text = "Admin Registration Form";
            this.Load += new System.EventHandler(this.AdminRegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxusertype;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaGradientButton btnregister;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtadress;
        private Guna.UI.WinForms.GunaTextBox txtpassword;
        private Guna.UI.WinForms.GunaTextBox txtusername;
        private System.Windows.Forms.LinkLabel linklbalreadyhaveanaccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaTextBox txtphone;
    }
}