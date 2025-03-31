namespace PetHavenManagementSystem
{
    partial class VetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VetForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cbxshowpass2 = new Guna.UI.WinForms.GunaCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin2 = new Guna.UI.WinForms.GunaGradientButton();
            this.txtpassword2 = new Guna.UI.WinForms.GunaTextBox();
            this.txtusername2 = new Guna.UI.WinForms.GunaTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.btnregisterdoctor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.cbxusertype = new System.Windows.Forms.ComboBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(27, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 312);
            this.panel1.TabIndex = 0;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(330, 221);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(75, 18);
            this.gunaLabel2.TabIndex = 25;
            this.gunaLabel2.Text = "Password:";
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(330, 137);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(79, 18);
            this.gunaLabel1.TabIndex = 24;
            this.gunaLabel1.Text = "Username:";
            // 
            // cbxshowpass2
            // 
            this.cbxshowpass2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbxshowpass2.BaseColor = System.Drawing.Color.White;
            this.cbxshowpass2.CheckedOffColor = System.Drawing.Color.Gray;
            this.cbxshowpass2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbxshowpass2.FillColor = System.Drawing.Color.White;
            this.cbxshowpass2.Font = new System.Drawing.Font("Bell MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxshowpass2.Location = new System.Drawing.Point(333, 283);
            this.cbxshowpass2.Name = "cbxshowpass2";
            this.cbxshowpass2.Size = new System.Drawing.Size(103, 20);
            this.cbxshowpass2.TabIndex = 20;
            this.cbxshowpass2.Text = "Show Password";
            this.cbxshowpass2.CheckedChanged += new System.EventHandler(this.cbxshowpass_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Welcome Doctor!";
            // 
            // btnLogin2
            // 
            this.btnLogin2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLogin2.AnimationHoverSpeed = 0.07F;
            this.btnLogin2.AnimationSpeed = 0.03F;
            this.btnLogin2.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin2.BaseColor1 = System.Drawing.Color.DeepSkyBlue;
            this.btnLogin2.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogin2.BorderColor = System.Drawing.Color.Black;
            this.btnLogin2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin2.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogin2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin2.ForeColor = System.Drawing.Color.White;
            this.btnLogin2.Image = null;
            this.btnLogin2.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogin2.Location = new System.Drawing.Point(372, 321);
            this.btnLogin2.Name = "btnLogin2";
            this.btnLogin2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogin2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogin2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogin2.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogin2.OnHoverImage = null;
            this.btnLogin2.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogin2.Radius = 18;
            this.btnLogin2.Size = new System.Drawing.Size(153, 35);
            this.btnLogin2.TabIndex = 18;
            this.btnLogin2.Text = "Login";
            this.btnLogin2.TextOffsetX = 50;
            this.btnLogin2.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtpassword2
            // 
            this.txtpassword2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtpassword2.BackColor = System.Drawing.Color.Transparent;
            this.txtpassword2.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtpassword2.BorderColor = System.Drawing.Color.Silver;
            this.txtpassword2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword2.FocusedBaseColor = System.Drawing.Color.White;
            this.txtpassword2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtpassword2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtpassword2.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword2.Location = new System.Drawing.Point(333, 242);
            this.txtpassword2.Name = "txtpassword2";
            this.txtpassword2.PasswordChar = '\0';
            this.txtpassword2.Radius = 15;
            this.txtpassword2.SelectedText = "";
            this.txtpassword2.Size = new System.Drawing.Size(245, 35);
            this.txtpassword2.TabIndex = 17;
            this.txtpassword2.TextOffsetX = 12;
            this.txtpassword2.TextChanged += new System.EventHandler(this.txtpassword2_TextChanged);
            // 
            // txtusername2
            // 
            this.txtusername2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtusername2.BackColor = System.Drawing.Color.Transparent;
            this.txtusername2.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.txtusername2.BorderColor = System.Drawing.Color.Silver;
            this.txtusername2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusername2.FocusedBaseColor = System.Drawing.Color.White;
            this.txtusername2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtusername2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtusername2.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername2.Location = new System.Drawing.Point(333, 169);
            this.txtusername2.Name = "txtusername2";
            this.txtusername2.PasswordChar = '\0';
            this.txtusername2.Radius = 15;
            this.txtusername2.SelectedText = "";
            this.txtusername2.Size = new System.Drawing.Size(245, 37);
            this.txtusername2.TabIndex = 16;
            this.txtusername2.TextOffsetX = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.gunaImageButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 31);
            this.panel2.TabIndex = 26;
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaImageButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.BackgroundImage")));
            this.gunaImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Image = null;
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton1.Location = new System.Drawing.Point(619, 0);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(30, 28);
            this.gunaImageButton1.TabIndex = 0;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // btnregisterdoctor
            // 
            this.btnregisterdoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregisterdoctor.ForeColor = System.Drawing.Color.Blue;
            this.btnregisterdoctor.Location = new System.Drawing.Point(372, 403);
            this.btnregisterdoctor.Name = "btnregisterdoctor";
            this.btnregisterdoctor.Size = new System.Drawing.Size(153, 35);
            this.btnregisterdoctor.TabIndex = 28;
            this.btnregisterdoctor.Text = "Register";
            this.btnregisterdoctor.UseVisualStyleBackColor = true;
            this.btnregisterdoctor.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Or";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // cbxusertype
            // 
            this.cbxusertype.FormattingEnabled = true;
            this.cbxusertype.Location = new System.Drawing.Point(155, 403);
            this.cbxusertype.Name = "cbxusertype";
            this.cbxusertype.Size = new System.Drawing.Size(121, 21);
            this.cbxusertype.TabIndex = 29;
            this.cbxusertype.SelectedIndexChanged += new System.EventHandler(this.cbxusertype_SelectedIndexChanged);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(86, 403);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(63, 15);
            this.gunaLabel3.TabIndex = 30;
            this.gunaLabel3.Text = "User type:";
            // 
            // VetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 484);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.cbxusertype);
            this.Controls.Add(this.btnregisterdoctor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.cbxshowpass2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin2);
            this.Controls.Add(this.txtpassword2);
            this.Controls.Add(this.txtusername2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VetForm";
            this.Text = "VetForm";
            this.Load += new System.EventHandler(this.VetForm_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaCheckBox cbxshowpass2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaGradientButton btnLogin2;
        private Guna.UI.WinForms.GunaTextBox txtpassword2;
        private Guna.UI.WinForms.GunaTextBox txtusername2;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private System.Windows.Forms.Button btnregisterdoctor;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.ComboBox cbxusertype;
    }
}