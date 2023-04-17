using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;

namespace CamViewer
{
    public partial class FormMain : Form
    {
        public LibVLC _libVLC = new LibVLC();
        List<VideoView> _videoViews = new List<VideoView>();

        public FormMain()
        {
            InitializeComponent();

            this.richTextBoxCfg.Text = Settings.Default.ConfigText;

            _videoViews.Add(videoView1);
            _videoViews.Add(videoView2);
            _videoViews.Add(videoView3);
            _videoViews.Add(videoView4);
            _videoViews.Add(videoView5);
            _videoViews.Add(videoView6);

            foreach (VideoView v in _videoViews)
                v.MediaPlayer = new MediaPlayer(_libVLC);

            StartAll();
        }

        private void StartAll()
        {
            int count = 0;
            string line = "";
            StringReader reader = new StringReader(this.richTextBoxCfg.Text);
            while ((line = reader.ReadLine()) != null)
            {
                if (count >= _videoViews.Count) break;

                // Skip empty lines and comments
                if (line.StartsWith("#")) continue;
                if (line.Trim().Length == 0) continue;

                _videoViews[count].MediaPlayer.Play(new Media(_libVLC, line));

                count++;
            }
        }

        private void StopAll()
        {
            foreach (VideoView v in _videoViews)
                if (v.MediaPlayer != null) v.MediaPlayer.Stop();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopAll();
            Settings.Default.ConfigText = this.richTextBoxCfg.Text;
            Settings.Default.Save();
        }

        private void editConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tableLayoutPanel1.Visible = !this.tableLayoutPanel1.Visible;
            this.richTextBoxCfg.Visible = this.richTextBoxCfg.Enabled = !this.tableLayoutPanel1.Visible;
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopAll();
            StartAll();
        }
    }
}