namespace CamViewer
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            videoView1 = new LibVLCSharp.WinForms.VideoView();
            videoView2 = new LibVLCSharp.WinForms.VideoView();
            tableLayoutPanel1 = new TableLayoutPanel();
            videoView6 = new LibVLCSharp.WinForms.VideoView();
            videoView5 = new LibVLCSharp.WinForms.VideoView();
            videoView4 = new LibVLCSharp.WinForms.VideoView();
            videoView3 = new LibVLCSharp.WinForms.VideoView();
            menuStrip1 = new MenuStrip();
            editConfigToolStripMenuItem = new ToolStripMenuItem();
            restartToolStripMenuItem = new ToolStripMenuItem();
            richTextBoxCfg = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)videoView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)videoView2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)videoView6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)videoView5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)videoView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)videoView3).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // videoView1
            // 
            videoView1.BackColor = Color.Black;
            videoView1.Dock = DockStyle.Fill;
            videoView1.Location = new Point(6, 6);
            videoView1.MediaPlayer = null;
            videoView1.Name = "videoView1";
            videoView1.Size = new Size(283, 248);
            videoView1.TabIndex = 1;
            videoView1.Text = "videoView1";
            // 
            // videoView2
            // 
            videoView2.BackColor = Color.Black;
            videoView2.Dock = DockStyle.Fill;
            videoView2.Location = new Point(298, 6);
            videoView2.MediaPlayer = null;
            videoView2.Name = "videoView2";
            videoView2.Size = new Size(283, 248);
            videoView2.TabIndex = 2;
            videoView2.Text = "videoView2";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(videoView6, 2, 1);
            tableLayoutPanel1.Controls.Add(videoView5, 1, 1);
            tableLayoutPanel1.Controls.Add(videoView4, 0, 1);
            tableLayoutPanel1.Controls.Add(videoView3, 2, 0);
            tableLayoutPanel1.Controls.Add(videoView1, 0, 0);
            tableLayoutPanel1.Controls.Add(videoView2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(882, 518);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // videoView6
            // 
            videoView6.BackColor = Color.Black;
            videoView6.Dock = DockStyle.Fill;
            videoView6.Location = new Point(590, 263);
            videoView6.MediaPlayer = null;
            videoView6.Name = "videoView6";
            videoView6.Size = new Size(286, 249);
            videoView6.TabIndex = 7;
            videoView6.Text = "videoView6";
            // 
            // videoView5
            // 
            videoView5.BackColor = Color.Black;
            videoView5.Dock = DockStyle.Fill;
            videoView5.Location = new Point(298, 263);
            videoView5.MediaPlayer = null;
            videoView5.Name = "videoView5";
            videoView5.Size = new Size(283, 249);
            videoView5.TabIndex = 6;
            videoView5.Text = "videoView5";
            // 
            // videoView4
            // 
            videoView4.BackColor = Color.Black;
            videoView4.Dock = DockStyle.Fill;
            videoView4.Location = new Point(6, 263);
            videoView4.MediaPlayer = null;
            videoView4.Name = "videoView4";
            videoView4.Size = new Size(283, 249);
            videoView4.TabIndex = 5;
            videoView4.Text = "videoView4";
            // 
            // videoView3
            // 
            videoView3.BackColor = Color.Black;
            videoView3.Dock = DockStyle.Fill;
            videoView3.Location = new Point(590, 6);
            videoView3.MediaPlayer = null;
            videoView3.Name = "videoView3";
            videoView3.Size = new Size(286, 248);
            videoView3.TabIndex = 4;
            videoView3.Text = "videoView3";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { editConfigToolStripMenuItem, restartToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(882, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // editConfigToolStripMenuItem
            // 
            editConfigToolStripMenuItem.Name = "editConfigToolStripMenuItem";
            editConfigToolStripMenuItem.Size = new Size(85, 20);
            editConfigToolStripMenuItem.Text = "Edit config...";
            editConfigToolStripMenuItem.Click += editConfigToolStripMenuItem_Click;
            // 
            // restartToolStripMenuItem
            // 
            restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            restartToolStripMenuItem.Size = new Size(55, 20);
            restartToolStripMenuItem.Text = "Restart";
            restartToolStripMenuItem.Click += restartToolStripMenuItem_Click;
            // 
            // richTextBoxCfg
            // 
            richTextBoxCfg.Dock = DockStyle.Fill;
            richTextBoxCfg.Location = new Point(0, 24);
            richTextBoxCfg.Name = "richTextBoxCfg";
            richTextBoxCfg.Size = new Size(882, 518);
            richTextBoxCfg.TabIndex = 5;
            richTextBoxCfg.Text = "# Config go here";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 542);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(richTextBoxCfg);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "CamViewer";
            FormClosing += FormMain_FormClosing;
            ((System.ComponentModel.ISupportInitialize)videoView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)videoView2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)videoView6).EndInit();
            ((System.ComponentModel.ISupportInitialize)videoView5).EndInit();
            ((System.ComponentModel.ISupportInitialize)videoView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)videoView3).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LibVLCSharp.WinForms.VideoView videoView1;
        private LibVLCSharp.WinForms.VideoView videoView2;
        private TableLayoutPanel tableLayoutPanel1;
        private LibVLCSharp.WinForms.VideoView videoView6;
        private LibVLCSharp.WinForms.VideoView videoView5;
        private LibVLCSharp.WinForms.VideoView videoView4;
        private LibVLCSharp.WinForms.VideoView videoView3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem editConfigToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private RichTextBox richTextBoxCfg;
    }
}