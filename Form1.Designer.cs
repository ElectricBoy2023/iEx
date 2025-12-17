namespace iEx
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.goButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.homeBtn = new System.Windows.Forms.PictureBox();
            this.stopBtn = new System.Windows.Forms.PictureBox();
            this.refreshBtn = new System.Windows.Forms.PictureBox();
            this.forwBtn = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recommendedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yahooToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duckDuckGoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.askcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aOLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duckDuckGoLiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bBCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frogFindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siteTxt = new System.Windows.Forms.TextBox();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.loadTimer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.spoofUserAgentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forwBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // goButton
            // 
            this.goButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.goButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goButton.ForeColor = System.Drawing.Color.Teal;
            this.goButton.Location = new System.Drawing.Point(779, 0);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(46, 30);
            this.goButton.TabIndex = 0;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 475);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(825, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.homeBtn);
            this.panel1.Controls.Add(this.stopBtn);
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Controls.Add(this.forwBtn);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 82);
            this.panel1.TabIndex = 2;
            // 
            // homeBtn
            // 
            this.homeBtn.Image = global::iEx.Properties.Resources.Iconshock_Super_Vista_General_Home_256;
            this.homeBtn.Location = new System.Drawing.Point(222, 27);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(48, 49);
            this.homeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeBtn.TabIndex = 7;
            this.homeBtn.TabStop = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            this.homeBtn.MouseEnter += new System.EventHandler(this.homeBtn_MouseEnter);
            this.homeBtn.MouseLeave += new System.EventHandler(this.homeBtn_MouseLeave);
            // 
            // stopBtn
            // 
            this.stopBtn.Image = global::iEx.Properties.Resources.Visualpharm_Must_Have_Remove_256;
            this.stopBtn.Location = new System.Drawing.Point(168, 27);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(48, 49);
            this.stopBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stopBtn.TabIndex = 6;
            this.stopBtn.TabStop = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            this.stopBtn.MouseEnter += new System.EventHandler(this.stopBtn_MouseEnter);
            this.stopBtn.MouseLeave += new System.EventHandler(this.stopBtn_MouseLeave);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Image = global::iEx.Properties.Resources.Visualpharm_Must_Have_Refresh_256;
            this.refreshBtn.Location = new System.Drawing.Point(114, 27);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(48, 49);
            this.refreshBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshBtn.TabIndex = 5;
            this.refreshBtn.TabStop = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            this.refreshBtn.MouseEnter += new System.EventHandler(this.refreshBtn_MouseEnter);
            this.refreshBtn.MouseLeave += new System.EventHandler(this.refreshBtn_MouseLeave);
            // 
            // forwBtn
            // 
            this.forwBtn.Image = global::iEx.Properties.Resources.Visualpharm_Must_Have_Next_256;
            this.forwBtn.Location = new System.Drawing.Point(60, 27);
            this.forwBtn.Name = "forwBtn";
            this.forwBtn.Size = new System.Drawing.Size(48, 49);
            this.forwBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.forwBtn.TabIndex = 4;
            this.forwBtn.TabStop = false;
            this.forwBtn.Click += new System.EventHandler(this.forwBtn_Click);
            this.forwBtn.MouseEnter += new System.EventHandler(this.forwBtn_MouseEnter);
            this.forwBtn.MouseLeave += new System.EventHandler(this.forwBtn_MouseLeave);
            // 
            // backBtn
            // 
            this.backBtn.Image = global::iEx.Properties.Resources.Visualpharm_Must_Have_Previous_256;
            this.backBtn.Location = new System.Drawing.Point(6, 27);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(48, 49);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backBtn.TabIndex = 3;
            this.backBtn.TabStop = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            this.backBtn.MouseEnter += new System.EventHandler(this.backBtn_MouseEnter);
            this.backBtn.MouseLeave += new System.EventHandler(this.backBtn_MouseLeave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recommendedToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem1.Text = "Actions";
            // 
            // recommendedToolStripMenuItem
            // 
            this.recommendedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.googleToolStripMenuItem,
            this.bingToolStripMenuItem,
            this.yahooToolStripMenuItem,
            this.duckDuckGoToolStripMenuItem,
            this.askcomToolStripMenuItem,
            this.aOLToolStripMenuItem,
            this.duckDuckGoLiteToolStripMenuItem,
            this.bBCToolStripMenuItem,
            this.frogFindToolStripMenuItem});
            this.recommendedToolStripMenuItem.Name = "recommendedToolStripMenuItem";
            this.recommendedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recommendedToolStripMenuItem.Text = "Recommended";
            // 
            // googleToolStripMenuItem
            // 
            this.googleToolStripMenuItem.Name = "googleToolStripMenuItem";
            this.googleToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.googleToolStripMenuItem.Text = "Google!";
            this.googleToolStripMenuItem.Click += new System.EventHandler(this.googleToolStripMenuItem_Click);
            // 
            // bingToolStripMenuItem
            // 
            this.bingToolStripMenuItem.Name = "bingToolStripMenuItem";
            this.bingToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.bingToolStripMenuItem.Text = "Bing";
            this.bingToolStripMenuItem.Click += new System.EventHandler(this.bingToolStripMenuItem_Click);
            // 
            // yahooToolStripMenuItem
            // 
            this.yahooToolStripMenuItem.Name = "yahooToolStripMenuItem";
            this.yahooToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.yahooToolStripMenuItem.Text = "Yahoo";
            this.yahooToolStripMenuItem.Click += new System.EventHandler(this.yahooToolStripMenuItem_Click);
            // 
            // duckDuckGoToolStripMenuItem
            // 
            this.duckDuckGoToolStripMenuItem.Name = "duckDuckGoToolStripMenuItem";
            this.duckDuckGoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.duckDuckGoToolStripMenuItem.Text = "DuckDuckGo";
            this.duckDuckGoToolStripMenuItem.Click += new System.EventHandler(this.duckDuckGoToolStripMenuItem_Click);
            // 
            // askcomToolStripMenuItem
            // 
            this.askcomToolStripMenuItem.Name = "askcomToolStripMenuItem";
            this.askcomToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.askcomToolStripMenuItem.Text = "Ask.com";
            this.askcomToolStripMenuItem.Click += new System.EventHandler(this.askcomToolStripMenuItem_Click);
            // 
            // aOLToolStripMenuItem
            // 
            this.aOLToolStripMenuItem.Name = "aOLToolStripMenuItem";
            this.aOLToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.aOLToolStripMenuItem.Text = "AOL";
            this.aOLToolStripMenuItem.Click += new System.EventHandler(this.aOLToolStripMenuItem_Click);
            // 
            // duckDuckGoLiteToolStripMenuItem
            // 
            this.duckDuckGoLiteToolStripMenuItem.Name = "duckDuckGoLiteToolStripMenuItem";
            this.duckDuckGoLiteToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.duckDuckGoLiteToolStripMenuItem.Text = "DuckDuckGo (Lite)";
            this.duckDuckGoLiteToolStripMenuItem.Click += new System.EventHandler(this.duckDuckGoLiteToolStripMenuItem_Click);
            // 
            // bBCToolStripMenuItem
            // 
            this.bBCToolStripMenuItem.Name = "bBCToolStripMenuItem";
            this.bBCToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.bBCToolStripMenuItem.Text = "BBC";
            this.bBCToolStripMenuItem.Click += new System.EventHandler(this.bBCToolStripMenuItem_Click);
            // 
            // frogFindToolStripMenuItem
            // 
            this.frogFindToolStripMenuItem.Name = "frogFindToolStripMenuItem";
            this.frogFindToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.frogFindToolStripMenuItem.Text = "FrogFind!";
            this.frogFindToolStripMenuItem.Click += new System.EventHandler(this.frogFindToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // siteTxt
            // 
            this.siteTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siteTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.siteTxt.Location = new System.Drawing.Point(69, 4);
            this.siteTxt.Name = "siteTxt";
            this.siteTxt.Size = new System.Drawing.Size(704, 23);
            this.siteTxt.TabIndex = 1;
            this.siteTxt.Text = "https://google.com/";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(825, 363);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            // 
            // loadTimer
            // 
            this.loadTimer.Tick += new System.EventHandler(this.loadTimer_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.goButton);
            this.panel2.Controls.Add(this.siteTxt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 30);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(66, 30);
            this.panel4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Address";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.webBrowser1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(825, 363);
            this.panel3.TabIndex = 5;
            // 
            // spoofUserAgentToolStripMenuItem
            // 
            this.spoofUserAgentToolStripMenuItem.Name = "spoofUserAgentToolStripMenuItem";
            this.spoofUserAgentToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 498);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "iEx | BIG UPDATE";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forwBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox siteTxt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem recommendedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yahooToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duckDuckGoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem askcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aOLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripMenuItem duckDuckGoLiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bBCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frogFindToolStripMenuItem;
        private System.Windows.Forms.Timer loadTimer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox backBtn;
        private System.Windows.Forms.PictureBox refreshBtn;
        private System.Windows.Forms.PictureBox forwBtn;
        private System.Windows.Forms.PictureBox homeBtn;
        private System.Windows.Forms.PictureBox stopBtn;
        private System.Windows.Forms.ToolStripMenuItem spoofUserAgentToolStripMenuItem;
    }
}

