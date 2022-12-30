
namespace Project_SMS.GUI
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.accounttype = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.back = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.reset = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.password = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.password2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.id = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.fullname = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.suname = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.studentlogout = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.createac = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.accounttype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // accounttype
            // 
            this.accounttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accounttype.DropDownWidth = 211;
            this.accounttype.Items.AddRange(new object[] {
            "Teacher",
            "Student"});
            this.accounttype.Location = new System.Drawing.Point(190, 56);
            this.accounttype.Name = "accounttype";
            this.accounttype.Size = new System.Drawing.Size(187, 23);
            this.accounttype.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.accounttype.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.accounttype.StateCommon.ComboBox.Border.Rounding = 4;
            this.accounttype.StateCommon.Item.Border.Color1 = System.Drawing.Color.Transparent;
            this.accounttype.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.accounttype.TabIndex = 120;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(50, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 21);
            this.label5.TabIndex = 119;
            this.label5.Text = "Account Type :";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(8, 374);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(56, 29);
            this.back.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.back.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.back.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.back.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.back.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.back.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.back.StateCommon.Border.Rounding = 8;
            this.back.StateCommon.Content.LongText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.TabIndex = 118;
            this.back.Values.Text = "Back";
            this.back.Click += new System.EventHandler(this.back_Click_1);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(249, 307);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(128, 45);
            this.reset.StateCommon.Back.Color1 = System.Drawing.Color.Pink;
            this.reset.StateCommon.Back.Color2 = System.Drawing.Color.Crimson;
            this.reset.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.reset.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.reset.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.reset.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.reset.StateCommon.Border.Rounding = 8;
            this.reset.StateCommon.Content.LongText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.reset.TabIndex = 43;
            this.reset.Values.Text = "Reset";
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(413, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(386, 337);
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(190, 200);
            this.password.Name = "password";
            this.password.PasswordChar = '●';
            this.password.Size = new System.Drawing.Size(187, 29);
            this.password.StateCommon.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.password.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.password.StateCommon.Border.Rounding = 8;
            this.password.TabIndex = 41;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(81, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 21);
            this.label6.TabIndex = 40;
            this.label6.Text = "Password :";
            // 
            // password2
            // 
            this.password2.Location = new System.Drawing.Point(190, 248);
            this.password2.Name = "password2";
            this.password2.PasswordChar = '●';
            this.password2.Size = new System.Drawing.Size(187, 29);
            this.password2.StateCommon.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.password2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.password2.StateCommon.Border.Rounding = 8;
            this.password2.TabIndex = 39;
            this.password2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password2.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(15, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 21);
            this.label7.TabIndex = 38;
            this.label7.Text = "Confirm Password :";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(190, 103);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(187, 29);
            this.id.StateCommon.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.id.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.id.StateCommon.Border.Rounding = 8;
            this.id.TabIndex = 34;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // fullname
            // 
            this.fullname.Location = new System.Drawing.Point(190, 151);
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            this.fullname.Size = new System.Drawing.Size(187, 29);
            this.fullname.StateCommon.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.fullname.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.fullname.StateCommon.Border.Rounding = 8;
            this.fullname.TabIndex = 33;
            this.fullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(138, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Full Name :";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(837, 10);
            this.panel6.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Yellow;
            this.panel5.Location = new System.Drawing.Point(1, 409);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(837, 10);
            this.panel5.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Location = new System.Drawing.Point(1, 421);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(837, 10);
            this.panel4.TabIndex = 20;
            // 
            // suname
            // 
            this.suname.AcceptsTab = true;
            this.suname.Location = new System.Drawing.Point(648, 3);
            this.suname.Name = "suname";
            this.suname.ReadOnly = true;
            this.suname.Size = new System.Drawing.Size(146, 36);
            this.suname.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.suname.StateCommon.Border.Rounding = 8;
            this.suname.StateCommon.Content.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suname.TabIndex = 31;
            this.suname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(606, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 38);
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(48, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Staff Dashboard";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.suname);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.studentlogout);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 41);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(338, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Create Accounts";
            // 
            // studentlogout
            // 
            this.studentlogout.Location = new System.Drawing.Point(796, 7);
            this.studentlogout.Name = "studentlogout";
            this.studentlogout.Size = new System.Drawing.Size(27, 28);
            this.studentlogout.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.studentlogout.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.studentlogout.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("studentlogout.StateCommon.Back.Image")));
            this.studentlogout.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.studentlogout.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.studentlogout.StateCommon.Border.ColorAngle = 0F;
            this.studentlogout.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.studentlogout.StateCommon.Border.Rounding = 0;
            this.studentlogout.StateCommon.Border.Width = 0;
            this.studentlogout.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentlogout.StatePressed.Back.Color1 = System.Drawing.Color.DimGray;
            this.studentlogout.StatePressed.Back.Color2 = System.Drawing.Color.DimGray;
            this.studentlogout.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.studentlogout.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.studentlogout.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.studentlogout.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.studentlogout.StatePressed.Border.Rounding = 4;
            this.studentlogout.StatePressed.Border.Width = 1;
            this.studentlogout.TabIndex = 1;
            this.studentlogout.Values.Text = "";
            this.studentlogout.Click += new System.EventHandler(this.studentlogout_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(8, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 30);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // createac
            // 
            this.createac.Location = new System.Drawing.Point(94, 307);
            this.createac.Name = "createac";
            this.createac.Size = new System.Drawing.Size(149, 45);
            this.createac.StateCommon.Back.Color1 = System.Drawing.Color.Cyan;
            this.createac.StateCommon.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.createac.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.createac.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.createac.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.createac.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.createac.StateCommon.Border.Rounding = 8;
            this.createac.StateCommon.Content.LongText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createac.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.createac.TabIndex = 27;
            this.createac.Values.Text = "Create Account";
            this.createac.Click += new System.EventHandler(this.createac_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel3.Controls.Add(this.accounttype);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.back);
            this.panel3.Controls.Add(this.reset);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.password);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.password2);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.id);
            this.panel3.Controls.Add(this.fullname);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.createac);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(831, 430);
            this.panel3.TabIndex = 9;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 474);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "CreateAccount";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BCC Student Management System";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accounttype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonComboBox accounttype;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton back;
        private ComponentFactory.Krypton.Toolkit.KryptonButton reset;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox password;
        private System.Windows.Forms.Label label6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox password2;
        private System.Windows.Forms.Label label7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox id;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox fullname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox suname;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton studentlogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton createac;
        private System.Windows.Forms.Panel panel3;
    }
}