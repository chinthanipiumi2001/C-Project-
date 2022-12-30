
namespace Project_SMS
{
    partial class notices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(notices));
            this.panel3 = new System.Windows.Forms.Panel();
            this.reset = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.grade = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.search = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.section = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.upload = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.img1 = new System.Windows.Forms.PictureBox();
            this.back = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.add = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.delete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.suname = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.studentlogout = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.section)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel3.Controls.Add(this.reset);
            this.panel3.Controls.Add(this.grade);
            this.panel3.Controls.Add(this.search);
            this.panel3.Controls.Add(this.section);
            this.panel3.Controls.Add(this.upload);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.back);
            this.panel3.Controls.Add(this.add);
            this.panel3.Controls.Add(this.delete);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(831, 430);
            this.panel3.TabIndex = 9;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(574, 374);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(108, 29);
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
            this.reset.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.TabIndex = 135;
            this.reset.Values.Text = "Reset";
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // grade
            // 
            this.grade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grade.DropDownWidth = 211;
            this.grade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.grade.Location = new System.Drawing.Point(74, 16);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(102, 23);
            this.grade.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.grade.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grade.StateCommon.ComboBox.Border.Rounding = 4;
            this.grade.StateCommon.Item.Border.Color1 = System.Drawing.Color.Transparent;
            this.grade.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grade.TabIndex = 134;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(186, 374);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(108, 29);
            this.search.StateCommon.Back.Color1 = System.Drawing.Color.SpringGreen;
            this.search.StateCommon.Back.Color2 = System.Drawing.Color.LimeGreen;
            this.search.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.search.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.search.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.search.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.search.StateCommon.Border.Rounding = 8;
            this.search.StateCommon.Content.LongText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.TabIndex = 133;
            this.search.Values.Text = "Search";
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // section
            // 
            this.section.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.section.DropDownWidth = 211;
            this.section.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.section.Location = new System.Drawing.Point(262, 16);
            this.section.Name = "section";
            this.section.Size = new System.Drawing.Size(102, 23);
            this.section.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.section.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.section.StateCommon.ComboBox.Border.Rounding = 4;
            this.section.StateCommon.Item.Border.Color1 = System.Drawing.Color.Transparent;
            this.section.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.section.TabIndex = 132;
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(313, 374);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(108, 29);
            this.upload.StateCommon.Back.Color1 = System.Drawing.Color.Cyan;
            this.upload.StateCommon.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.upload.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.upload.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.upload.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.upload.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.upload.StateCommon.Border.Rounding = 8;
            this.upload.StateCommon.Content.LongText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload.TabIndex = 130;
            this.upload.Values.Text = "Upload";
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.img1);
            this.panel1.Location = new System.Drawing.Point(14, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 299);
            this.panel1.TabIndex = 129;
            // 
            // img1
            // 
            this.img1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.img1.Location = new System.Drawing.Point(3, 3);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(429, 293);
            this.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img1.TabIndex = 130;
            this.img1.TabStop = false;
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
            this.back.TabIndex = 127;
            this.back.Values.Text = "Back";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(74, 374);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(90, 29);
            this.add.StateCommon.Back.Color1 = System.Drawing.Color.DarkOrange;
            this.add.StateCommon.Back.Color2 = System.Drawing.Color.Chocolate;
            this.add.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.add.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.add.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.add.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.add.StateCommon.Border.Rounding = 8;
            this.add.StateCommon.Content.LongText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.TabIndex = 126;
            this.add.Values.Text = "Add ";
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(445, 374);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(108, 29);
            this.delete.StateCommon.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.delete.StateCommon.Back.Color2 = System.Drawing.Color.SlateBlue;
            this.delete.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.delete.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.delete.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.delete.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.delete.StateCommon.Border.Rounding = 8;
            this.delete.StateCommon.Content.LongText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.TabIndex = 125;
            this.delete.Values.Text = "Delete";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(182, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 122;
            this.label3.Text = "Section :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(10, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 21);
            this.label12.TabIndex = 120;
            this.label12.Text = "Grade :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(474, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(344, 335);
            this.pictureBox2.TabIndex = 115;
            this.pictureBox2.TabStop = false;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.suname);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.studentlogout);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 41);
            this.panel2.TabIndex = 8;
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
            this.suname.TabIndex = 32;
            this.suname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(606, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 38);
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(365, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Notices";
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
            // notices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 474);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(846, 513);
            this.Name = "notices";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BCC Student Management System";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.section)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton studentlogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton back;
        private ComponentFactory.Krypton.Toolkit.KryptonButton add;
        private ComponentFactory.Krypton.Toolkit.KryptonButton delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private ComponentFactory.Krypton.Toolkit.KryptonButton upload;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox img1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox suname;
        private System.Windows.Forms.PictureBox pictureBox4;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox section;
        private ComponentFactory.Krypton.Toolkit.KryptonButton search;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox grade;
        private ComponentFactory.Krypton.Toolkit.KryptonButton reset;
    }
}