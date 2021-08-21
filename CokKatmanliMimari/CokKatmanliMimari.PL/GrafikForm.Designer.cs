namespace CokKatmanliMimari.PL
{
    partial class GrafikForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrafikForm));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblOgrenci = new System.Windows.Forms.Label();
            this.lblOgrenciId = new System.Windows.Forms.Label();
            this.grafikKitap = new ZedGraph.ZedGraphControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1115, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 45;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.ImageKey = "reply.png";
            this.button2.Location = new System.Drawing.Point(26, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 34);
            this.button2.TabIndex = 44;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblOgrenci
            // 
            this.lblOgrenci.AutoSize = true;
            this.lblOgrenci.BackColor = System.Drawing.Color.Transparent;
            this.lblOgrenci.Font = new System.Drawing.Font("Ravie", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOgrenci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOgrenci.Location = new System.Drawing.Point(397, 21);
            this.lblOgrenci.Name = "lblOgrenci";
            this.lblOgrenci.Size = new System.Drawing.Size(424, 40);
            this.lblOgrenci.TabIndex = 43;
            this.lblOgrenci.Text = "Grafiksel Gösterim";
            // 
            // lblOgrenciId
            // 
            this.lblOgrenciId.AutoSize = true;
            this.lblOgrenciId.BackColor = System.Drawing.Color.Transparent;
            this.lblOgrenciId.Location = new System.Drawing.Point(880, 38);
            this.lblOgrenciId.Name = "lblOgrenciId";
            this.lblOgrenciId.Size = new System.Drawing.Size(0, 17);
            this.lblOgrenciId.TabIndex = 46;
            // 
            // grafikKitap
            // 
            this.grafikKitap.Location = new System.Drawing.Point(97, 79);
            this.grafikKitap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grafikKitap.Name = "grafikKitap";
            this.grafikKitap.ScrollGrace = 0D;
            this.grafikKitap.ScrollMaxX = 0D;
            this.grafikKitap.ScrollMaxY = 0D;
            this.grafikKitap.ScrollMaxY2 = 0D;
            this.grafikKitap.ScrollMinX = 0D;
            this.grafikKitap.ScrollMinY = 0D;
            this.grafikKitap.ScrollMinY2 = 0D;
            this.grafikKitap.Size = new System.Drawing.Size(1013, 441);
            this.grafikKitap.TabIndex = 47;
            this.grafikKitap.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // GrafikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.grafikKitap);
            this.Controls.Add(this.lblOgrenciId);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblOgrenci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GrafikForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GrafikForm";
            this.Load += new System.EventHandler(this.GrafikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblOgrenci;
        public System.Windows.Forms.Label lblOgrenciId;
        private ZedGraph.ZedGraphControl grafikKitap;
    }
}