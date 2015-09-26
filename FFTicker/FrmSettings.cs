using System;
using System.Windows.Forms;

namespace FFTicker
{
    public partial class FrmSettings : Form
    {
        private readonly FrmMain _frmMain;

        public FrmSettings()
        {
            InitializeComponent();
        }

        public FrmSettings(FrmMain frmMain)
            : this()
        {
            _frmMain = frmMain;
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            txtSnapshotsDir.Text = _frmMain.Settings.SnapshotsDir;
            txtSnapshotsDir.ReadOnly = true;
        }

        private void FrmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var settings = new Settings();
            settings.SnapshotsDir = txtSnapshotsDir.Text;
            _frmMain.UpdateSettings(settings);
            Close();            
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            _frmMain.Close();
        }
    }
}
