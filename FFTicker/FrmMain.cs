using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;

namespace FFTicker
{
    public partial class FrmMain : Form
    {
        private readonly FrmControls _frmControls;
        private readonly FrmSettings _frmSettings;
        private readonly string _rootDir;
        private readonly string _saveFile;
        private Settings _settings;
        private bool _snapshotsEnabled;
        private DateTime _lastSnapshot;

        public FrmMain()
        {
            InitializeComponent();
            _frmControls = new FrmControls(this);
            _frmSettings = new FrmSettings(this);
            _rootDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            _saveFile = "FFTicker.json";
        }

        public FrmControls ControlsForm => _frmControls;

        public FrmSettings SettingsForm => _frmSettings;

        public Settings Settings => _settings;

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var file = Path.Combine(_rootDir, _saveFile);
            if (File.Exists(file))
            {
                _settings = LoadFile(Path.Combine(_rootDir, _saveFile));
            }
            else
            {
                _settings = new Settings();                
                _settings.SnapshotsInterval = 1000*60*5; // 5 min
                _settings.SnapshotsEnabled = false;
                _settings.SnapshotsDir = Path.Combine(_rootDir, "Snapshots");
            }

            if (_settings.SnapshotsEnabled)
                StartSnapshots();
        }

        private void tmrHide_Tick(object sender, EventArgs e)
        {
            tmrHide.Enabled = false;
            Hide();
            tmrShowControlsForm.Enabled = true;
        }

        private void tmrShowControlsForm_Tick(object sender, EventArgs e)
        {
            tmrShowControlsForm.Enabled = false;
            _frmControls.Show();
        }        

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tmrSnapshot_Tick(object sender, EventArgs e)
        {
            var diff = (DateTime.Now - _lastSnapshot).TotalMinutes;
            if (diff >= _settings.SnapshotsInterval)
            {
                tmrSnapshot.Enabled = false;
                TakeSnapshot();
                _lastSnapshot = DateTime.Now;
                tmrSnapshot.Enabled = _snapshotsEnabled;
            }
        }

        public void StartSnapshots()
        {
            _snapshotsEnabled = true;
            TakeSnapshot();
            _lastSnapshot = DateTime.Now;
            tmrSnapshot.Enabled = _snapshotsEnabled;
        }

        public void StopSnapshots()
        {
            _snapshotsEnabled = false;
        }

        private void TakeSnapshot()
        {
            if (!_snapshotsEnabled)
                return;

            var screen = Screen.FromControl(_frmControls);
            Bitmap bmp = new Bitmap(screen.Bounds.Width, screen.Bounds.Height, PixelFormat.Format32bppArgb);
            Graphics.FromImage(bmp).CopyFromScreen(0, 0, 0, 0, bmp.Size);

            var stamp = DateTime.Now.ToString("yyyy-MM-dd-HH-mm");
            var file = Path.Combine(_settings.SnapshotsDir, $"{stamp}.jpg");

            if (!Directory.Exists(_settings.SnapshotsDir))
                Directory.CreateDirectory(_settings.SnapshotsDir);

            bmp.Save(file, ImageFormat.Jpeg);
        }

        public void UpdateSettings(Settings settings)
        {
            SaveFile(Path.Combine(_rootDir, _saveFile), settings);
            _settings = settings;
        }

        private void SaveFile(string file, Settings settings)
        {
            var ms = new MemoryStream();
            var ser = new DataContractJsonSerializer(typeof(Settings));
            ser.WriteObject(ms, settings);
            ms.Position = 0;
            var r = new StreamReader(ms);
            File.WriteAllText(file, r.ReadToEnd());
        }

        private Settings LoadFile(string file)
        {
            var ser = new DataContractJsonSerializer(typeof (Settings));
            var settings = (Settings) ser.ReadObject(File.Open(file, FileMode.Open));
            return settings;
        }
    }
}
