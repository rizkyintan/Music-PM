
namespace MusicPM
{
    partial class MusicPM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPM));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPlaylist = new System.Windows.Forms.ComboBox();
            this.lstDaftarLagu = new System.Windows.Forms.ListBox();
            this.txtBuatPlaylist = new System.Windows.Forms.TextBox();
            this.btnTambahkanPlaylist = new System.Windows.Forms.Button();
            this.btnSemuaLagu = new System.Windows.Forms.Button();
            this.btnTambahLagu = new System.Windows.Forms.Button();
            this.btnHapusLagu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPlaylist2 = new System.Windows.Forms.ComboBox();
            this.btnGabungPlaylist = new System.Windows.Forms.Button();
            this.txtNamaUser = new System.Windows.Forms.TextBox();
            this.txtPremium = new System.Windows.Forms.TextBox();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daftar Playlist :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Daftar Lagu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(406, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Buat Playlist :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(272, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 4;
            // 
            // cmbPlaylist
            // 
            this.cmbPlaylist.FormattingEnabled = true;
            this.cmbPlaylist.Location = new System.Drawing.Point(164, 81);
            this.cmbPlaylist.Name = "cmbPlaylist";
            this.cmbPlaylist.Size = new System.Drawing.Size(216, 24);
            this.cmbPlaylist.TabIndex = 5;
            this.cmbPlaylist.SelectedIndexChanged += new System.EventHandler(this.cmbPlaylist_SelectedIndexChanged);
            // 
            // lstDaftarLagu
            // 
            this.lstDaftarLagu.FormattingEnabled = true;
            this.lstDaftarLagu.ItemHeight = 16;
            this.lstDaftarLagu.Location = new System.Drawing.Point(164, 133);
            this.lstDaftarLagu.Name = "lstDaftarLagu";
            this.lstDaftarLagu.Size = new System.Drawing.Size(216, 212);
            this.lstDaftarLagu.TabIndex = 6;
            this.lstDaftarLagu.SelectedIndexChanged += new System.EventHandler(this.lstDaftarLagu_SelectedIndexChanged);
            // 
            // txtBuatPlaylist
            // 
            this.txtBuatPlaylist.Location = new System.Drawing.Point(536, 84);
            this.txtBuatPlaylist.Multiline = true;
            this.txtBuatPlaylist.Name = "txtBuatPlaylist";
            this.txtBuatPlaylist.Size = new System.Drawing.Size(216, 24);
            this.txtBuatPlaylist.TabIndex = 7;
            // 
            // btnTambahkanPlaylist
            // 
            this.btnTambahkanPlaylist.Location = new System.Drawing.Point(536, 130);
            this.btnTambahkanPlaylist.Name = "btnTambahkanPlaylist";
            this.btnTambahkanPlaylist.Size = new System.Drawing.Size(90, 31);
            this.btnTambahkanPlaylist.TabIndex = 8;
            this.btnTambahkanPlaylist.Text = "Create";
            this.btnTambahkanPlaylist.UseVisualStyleBackColor = true;
            this.btnTambahkanPlaylist.Click += new System.EventHandler(this.btnTambahkanPlaylist_Click);
            // 
            // btnSemuaLagu
            // 
            this.btnSemuaLagu.Location = new System.Drawing.Point(38, 261);
            this.btnSemuaLagu.Name = "btnSemuaLagu";
            this.btnSemuaLagu.Size = new System.Drawing.Size(100, 33);
            this.btnSemuaLagu.TabIndex = 9;
            this.btnSemuaLagu.Text = "Semua Lagu";
            this.btnSemuaLagu.UseVisualStyleBackColor = true;
            this.btnSemuaLagu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTambahLagu
            // 
            this.btnTambahLagu.Location = new System.Drawing.Point(38, 169);
            this.btnTambahLagu.Name = "btnTambahLagu";
            this.btnTambahLagu.Size = new System.Drawing.Size(100, 31);
            this.btnTambahLagu.TabIndex = 10;
            this.btnTambahLagu.Text = "Add Song";
            this.btnTambahLagu.UseVisualStyleBackColor = true;
            this.btnTambahLagu.Click += new System.EventHandler(this.btnTambahLagu_Click);
            // 
            // btnHapusLagu
            // 
            this.btnHapusLagu.Location = new System.Drawing.Point(38, 214);
            this.btnHapusLagu.Name = "btnHapusLagu";
            this.btnHapusLagu.Size = new System.Drawing.Size(100, 32);
            this.btnHapusLagu.TabIndex = 11;
            this.btnHapusLagu.Text = "Delete Song";
            this.btnHapusLagu.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(437, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Gabung :";
            // 
            // cmbPlaylist2
            // 
            this.cmbPlaylist2.FormattingEnabled = true;
            this.cmbPlaylist2.Location = new System.Drawing.Point(536, 241);
            this.cmbPlaylist2.Name = "cmbPlaylist2";
            this.cmbPlaylist2.Size = new System.Drawing.Size(216, 24);
            this.cmbPlaylist2.TabIndex = 13;
            // 
            // btnGabungPlaylist
            // 
            this.btnGabungPlaylist.Location = new System.Drawing.Point(536, 289);
            this.btnGabungPlaylist.Name = "btnGabungPlaylist";
            this.btnGabungPlaylist.Size = new System.Drawing.Size(126, 34);
            this.btnGabungPlaylist.TabIndex = 14;
            this.btnGabungPlaylist.Text = "Gabung Playlist";
            this.btnGabungPlaylist.UseVisualStyleBackColor = true;
            this.btnGabungPlaylist.Click += new System.EventHandler(this.btnGabungPlaylist_Click);
            // 
            // txtNamaUser
            // 
            this.txtNamaUser.Location = new System.Drawing.Point(327, 373);
            this.txtNamaUser.Multiline = true;
            this.txtNamaUser.Name = "txtNamaUser";
            this.txtNamaUser.Size = new System.Drawing.Size(151, 25);
            this.txtNamaUser.TabIndex = 15;
            // 
            // txtPremium
            // 
            this.txtPremium.Location = new System.Drawing.Point(242, 414);
            this.txtPremium.Multiline = true;
            this.txtPremium.Name = "txtPremium";
            this.txtPremium.Size = new System.Drawing.Size(151, 25);
            this.txtPremium.TabIndex = 16;
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(414, 414);
            this.txtLimit.Multiline = true;
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(142, 25);
            this.txtLimit.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 18;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 351);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(584, 351);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(203, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(397, 46);
            this.label6.TabIndex = 21;
            this.label6.Text = "Music Playlist Manager";
            // 
            // MusicPM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(774, 454);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.txtPremium);
            this.Controls.Add(this.txtNamaUser);
            this.Controls.Add(this.btnGabungPlaylist);
            this.Controls.Add(this.cmbPlaylist2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHapusLagu);
            this.Controls.Add(this.btnTambahLagu);
            this.Controls.Add(this.btnSemuaLagu);
            this.Controls.Add(this.btnTambahkanPlaylist);
            this.Controls.Add(this.txtBuatPlaylist);
            this.Controls.Add(this.lstDaftarLagu);
            this.Controls.Add(this.cmbPlaylist);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MusicPM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPM";
            this.Load += new System.EventHandler(this.MusicPM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPlaylist;
        private System.Windows.Forms.ListBox lstDaftarLagu;
        private System.Windows.Forms.TextBox txtBuatPlaylist;
        private System.Windows.Forms.Button btnTambahkanPlaylist;
        private System.Windows.Forms.Button btnSemuaLagu;
        private System.Windows.Forms.Button btnTambahLagu;
        private System.Windows.Forms.Button btnHapusLagu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPlaylist2;
        private System.Windows.Forms.Button btnGabungPlaylist;
        private System.Windows.Forms.TextBox txtNamaUser;
        private System.Windows.Forms.TextBox txtPremium;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
    }
}

