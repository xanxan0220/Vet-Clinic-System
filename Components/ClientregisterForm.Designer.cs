namespace PetHavenManagementSystem
{
    partial class ClientregisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientregisterForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linklblalreadyhaveacc = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnregister = new Guna.UI.WinForms.GunaGradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtaddress = new Guna.UI.WinForms.GunaTextBox();
            this.txtpassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtusername = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxusertype = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtphone = new Guna.UI.WinForms.GunaTextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(39, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 272);
            this.panel1.TabIndex = 0;
            // 
            // linklblalreadyhaveacc
            // 
            this.linklblalreadyhaveacc.AutoSize = true;
            this.linklblalreadyhaveacc.Location = new System.Drawing.Point(542, 499);
            this.linklblalreadyhaveacc.Name = "linklblalreadyhaveacc";
            this.linklblalreadyhaveacc.Size = new System.Drawing.Size(132, 13);
            this.linklblalreadyhaveacc.TabIndex = 34;
            this.linklblalreadyhaveacc.TabStop = true;
            this.linklblalreadyhaveacc.Text = "Already have an account?";
            this.linklblalreadyhaveacc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(356, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 26);
            this.label5.TabIndex = 44;
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
            this.txtemail.Location = new System.Drawing.Point(357, 237);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.Radius = 15;
            this.txtemail.SelectedText = "";
            this.txtemail.Size = new System.Drawing.Size(242, 33);
            this.txtemail.TabIndex = 43;
            this.txtemail.TextOffsetX = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(356, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 26);
            this.label4.TabIndex = 42;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(356, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 26);
            this.label3.TabIndex = 41;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 40;
            this.label2.Text = "Username:";
            // 
            // btnregister
            // 
            this.btnregister.AnimationHoverSpeed = 0.07F;
            this.btnregister.AnimationSpeed = 0.03F;
            this.btnregister.BackColor = System.Drawing.Color.Transparent;
            this.btnregister.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnregister.BaseColor2 = System.Drawing.Color.DeepSkyBlue;
            this.btnregister.BorderColor = System.Drawing.Color.Black;
            this.btnregister.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnregister.FocusedColor = System.Drawing.Color.Empty;
            this.btnregister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnregister.ForeColor = System.Drawing.Color.White;
            this.btnregister.Image = null;
            this.btnregister.ImageSize = new System.Drawing.Size(20, 20);
            this.btnregister.Location = new System.Drawing.Point(266, 445);
            this.btnregister.Name = "btnregister";
            this.btnregister.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnregister.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnregister.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnregister.OnHoverForeColor = System.Drawing.Color.White;
            this.btnregister.OnHoverImage = null;
            this.btnregister.OnPressedColor = System.Drawing.Color.Black;
            this.btnregister.Radius = 18;
            this.btnregister.Size = new System.Drawing.Size(158, 44);
            this.btnregister.TabIndex = 39;
            this.btnregister.Text = "Register";
            this.btnregister.TextOffsetX = 50;
            this.btnregister.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "Registration Form";
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.Color.Transparent;
            this.txtaddress.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtaddress.BorderColor = System.Drawing.Color.Silver;
            this.txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtaddress.FocusedBaseColor = System.Drawing.Color.White;
            this.txtaddress.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtaddress.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtaddress.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(353, 299);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.PasswordChar = '\0';
            this.txtaddress.Radius = 15;
            this.txtaddress.SelectedText = "";
            this.txtaddress.Size = new System.Drawing.Size(242, 34);
            this.txtaddress.TabIndex = 37;
            this.txtaddress.TextOffsetX = 12;
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
            this.txtpassword.Location = new System.Drawing.Point(357, 175);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '\0';
            this.txtpassword.Radius = 15;
            this.txtpassword.SelectedText = "";
            this.txtpassword.Size = new System.Drawing.Size(242, 33);
            this.txtpassword.TabIndex = 36;
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
            this.txtusername.Location = new System.Drawing.Point(357, 107);
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.Radius = 15;
            this.txtusername.SelectedText = "";
            this.txtusername.Size = new System.Drawing.Size(242, 33);
            this.txtusername.TabIndex = 35;
            this.txtusername.TextOffsetX = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 46;
            this.label6.Text = "User Type:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbxusertype
            // 
            this.cbxusertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxusertype.FormattingEnabled = true;
            this.cbxusertype.Items.AddRange(new object[] {
            "Veterinarian",
            "Client"});
            this.cbxusertype.Location = new System.Drawing.Point(119, 347);
            this.cbxusertype.Name = "cbxusertype";
            this.cbxusertype.Size = new System.Drawing.Size(143, 23);
            this.cbxusertype.TabIndex = 45;
            this.cbxusertype.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(363, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 26);
            this.label7.TabIndex = 48;
            this.label7.Text = "Contact No.";
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
            this.txtphone.Location = new System.Drawing.Point(353, 373);
            this.txtphone.Name = "txtphone";
            this.txtphone.PasswordChar = '\0';
            this.txtphone.Radius = 15;
            this.txtphone.SelectedText = "";
            this.txtphone.Size = new System.Drawing.Size(242, 34);
            this.txtphone.TabIndex = 47;
            this.txtphone.TextOffsetX = 12;
            // 
            // ClientregisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(686, 521);
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
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.linklblalreadyhaveacc);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClientregisterForm";
            this.Text = "Clients Application Form";
            this.Load += new System.EventHandler(this.ClientregisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linklblalreadyhaveacc;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaGradientButton btnregister;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtaddress;
        private Guna.UI.WinForms.GunaTextBox txtpassword;
        private Guna.UI.WinForms.GunaTextBox txtusername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxusertype;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaTextBox txtphone;
    }
}