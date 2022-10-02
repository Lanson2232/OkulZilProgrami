namespace OkulZil
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saatAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pazartesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sarlıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çarşambaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perşembeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cumartesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pazarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.studentAlertTrigger = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem,
            this.saatAyarlarıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            this.ayarlarToolStripMenuItem.Click += new System.EventHandler(this.ayarlarToolStripMenuItem_Click);
            // 
            // saatAyarlarıToolStripMenuItem
            // 
            this.saatAyarlarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pazartesiToolStripMenuItem,
            this.sarlıToolStripMenuItem,
            this.çarşambaToolStripMenuItem,
            this.perşembeToolStripMenuItem,
            this.cumaToolStripMenuItem,
            this.cumartesiToolStripMenuItem,
            this.pazarToolStripMenuItem});
            this.saatAyarlarıToolStripMenuItem.Name = "saatAyarlarıToolStripMenuItem";
            this.saatAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.saatAyarlarıToolStripMenuItem.Text = "Saat Ayarları";
            // 
            // pazartesiToolStripMenuItem
            // 
            this.pazartesiToolStripMenuItem.Name = "pazartesiToolStripMenuItem";
            this.pazartesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pazartesiToolStripMenuItem.Text = "Pazartesi";
            this.pazartesiToolStripMenuItem.Click += new System.EventHandler(this.pazartesiToolStripMenuItem_Click);
            // 
            // sarlıToolStripMenuItem
            // 
            this.sarlıToolStripMenuItem.Name = "sarlıToolStripMenuItem";
            this.sarlıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sarlıToolStripMenuItem.Text = "Salı";
            this.sarlıToolStripMenuItem.Click += new System.EventHandler(this.sarlıToolStripMenuItem_Click);
            // 
            // çarşambaToolStripMenuItem
            // 
            this.çarşambaToolStripMenuItem.Name = "çarşambaToolStripMenuItem";
            this.çarşambaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çarşambaToolStripMenuItem.Text = "Çarşamba";
            // 
            // perşembeToolStripMenuItem
            // 
            this.perşembeToolStripMenuItem.Name = "perşembeToolStripMenuItem";
            this.perşembeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.perşembeToolStripMenuItem.Text = "Perşembe";
            // 
            // cumaToolStripMenuItem
            // 
            this.cumaToolStripMenuItem.Name = "cumaToolStripMenuItem";
            this.cumaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cumaToolStripMenuItem.Text = "Cuma";
            // 
            // cumartesiToolStripMenuItem
            // 
            this.cumartesiToolStripMenuItem.Name = "cumartesiToolStripMenuItem";
            this.cumartesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cumartesiToolStripMenuItem.Text = "Cumartesi";
            // 
            // pazarToolStripMenuItem
            // 
            this.pazarToolStripMenuItem.Name = "pazarToolStripMenuItem";
            this.pazarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pazarToolStripMenuItem.Text = "Pazar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Durdur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // studentAlertTrigger
            // 
            this.studentAlertTrigger.Location = new System.Drawing.Point(6, 19);
            this.studentAlertTrigger.Name = "studentAlertTrigger";
            this.studentAlertTrigger.Size = new System.Drawing.Size(248, 23);
            this.studentAlertTrigger.TabIndex = 3;
            this.studentAlertTrigger.Text = "Öğrenci Zili Çal";
            this.studentAlertTrigger.UseVisualStyleBackColor = true;
            this.studentAlertTrigger.Click += new System.EventHandler(this.studentAlertTrigger_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.studentAlertTrigger);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 111);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ziller";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(248, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Çıkış Zili Çal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Öğretmen Zili Çal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(-1, 316);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(287, 45);
            this.Player.TabIndex = 0;
            this.Player.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Okul Zil Programı";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saatAyarlarıToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem pazartesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sarlıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çarşambaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perşembeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cumartesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pazarToolStripMenuItem;
        private System.Windows.Forms.Button studentAlertTrigger;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

