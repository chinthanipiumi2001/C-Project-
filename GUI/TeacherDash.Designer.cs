
namespace Project_SMS
{
    partial class TeacherDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherDash));
            this.panel3 = new System.Windows.Forms.Panel();
            this.notices = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.addmarks = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.suname = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.studentlogout = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel3.Controls.Add(this.notices);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.addmarks);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(831, 430);
            this.panel3.TabIndex = 7;
            // 
            // notices
            // 
            this.notices.Location = new System.Drawing.Point(52, 216);
            this.notices.Name = "notices";
            this.notices.Size = new System.Drawing.Size(286, 109);
            this.notices.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.notices.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.notices.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.notices.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("notices.StateCommon.Back.Image")));
            this.notices.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.notices.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.notices.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.notices.StateCommon.Border.Rounding = 8;
            this.notices.StateCommon.Content.LongText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notices.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notices.TabIndex = 25;
            this.notices.Values.Text = "";
            this.notices.Click += new System.EventHandler(this.notices_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(837, 10);
            this.panel6.TabIndex = 23;
            // 
            // addmarks
            // 
            this.addmarks.Location = new System.Drawing.Point(52, 69);
            this.addmarks.Name = "addmarks";
            this.addmarks.Size = new System.Drawing.Size(286, 109);
            this.addmarks.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.addmarks.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.addmarks.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.addmarks.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("addmarks.StateCommon.Back.Image")));
            this.addmarks.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.addmarks.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.addmarks.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.addmarks.StateCommon.Border.Rounding = 8;
            this.addmarks.StateCommon.Content.LongText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addmarks.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addmarks.TabIndex = 22;
            this.addmarks.Values.Text = "";
            this.addmarks.Click += new System.EventHandler(this.addmarks_Click);
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
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(437, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(369, 316);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.suname);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.studentlogout);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 41);
            this.panel2.TabIndex = 6;
            // 
            // suname
            // 
            this.suname.AcceptsTab = true;
            this.suname.Location = new System.Drawing.Point(648, 4);
            this.suname.Name = "suname";
            this.suname.ReadOnly = true;
            this.suname.Size = new System.Drawing.Size(146, 36);
            this.suname.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.suname.StateCommon.Border.Rounding = 8;
            this.suname.StateCommon.Content.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suname.TabIndex = 30;
            this.suname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(606, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 38);
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
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
            this.studentlogout.Click += new System.EventHandler(this.studentlogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(48, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teachers Dashboard";
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
            // TeacherDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 474);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(846, 513);
            this.Name = "TeacherDash";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BCC Student Managament System";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton notices;
        private System.Windows.Forms.Panel panel6;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addmarks;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton studentlogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox suname;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}