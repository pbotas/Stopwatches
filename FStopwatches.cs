using System.Text.Json;

namespace Stopwatches
{
    public partial class FStopwatches : Form
    {
        private const string SETTINGS_FILENAME = "settings.json";
        private Dictionary<int, DateTime> _elapsedTimes = new Dictionary<int, DateTime>();
        public FStopwatches()
        {
            InitializeComponent();
        }

        private void setTopMost(bool v)
        {
            menuItemAlwaysOnTop.Checked = TopMost = v;
        }

        private void menuItemAlwaysOnTop_Click(object sender, EventArgs e)
        {
            setTopMost(!TopMost);
        }

        private void menuItemComboBoxOpacity_SelectedIndexChanged(object sender, EventArgs e)
        {
            setOpacity((10 - menuItemComboBoxOpacity.SelectedIndex) / 10.0);
        }

        private void setOpacity(double v)
        {
            Opacity = Math.Max(v, 0.1);
            menuItemComboBoxOpacity.SelectedIndex = (int)(10 - (Opacity * 10));
        }

        private void startStop(object sender, EventArgs e)
        {
            startStop(int.Parse((string)((Control)sender).Tag!));
        }

        private void startStop(int n)
        {
            if (menuItemExclusiveMode.Checked)
            {
                for (int i = 1; i <= 10; i++)
                {
                    if (i != n && _elapsedTimes.ContainsKey(i))
                        startStop(i);
                }
            }

            var maskedTextBox = (MaskedTextBox)Controls["maskedTextBox" + n]!;

            if (!_elapsedTimes.Remove(n))
                _elapsedTimes[n] = DateTime.Now - (TimeSpan.TryParse(maskedTextBox.Text, out TimeSpan ts) ? ts : TimeSpan.Zero);

            maskedTextBox.Enabled = !_elapsedTimes.ContainsKey(n);
        }

        private void reset(object sender, EventArgs e)
        {
            var n = int.Parse((string)((Control)sender).Tag!);
            var maskedTextBox = (MaskedTextBox)Controls["maskedTextBox" + n]!;

            if (_elapsedTimes.ContainsKey(n))
                startStop(sender, e);
            maskedTextBox.Text = TimeSpan.Zero.ToString();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            for (var i = 1; i <= 10; i++)
            {
                var maskedTextBox = (MaskedTextBox)Controls["maskedTextBox" + i]!;

                if (_elapsedTimes.ContainsKey(i))
                {
                    var elapsed = DateTime.Now - _elapsedTimes[i];
                    maskedTextBox.Text = elapsed.ToString();
                }
            }
        }

        private void calcTotal(object sender, EventArgs e)
        {
            var totalTime = TimeSpan.Zero;
            for (var i = 1; i <= 10; i++)
            {
                if(TimeSpan.TryParse(Controls["maskedTextBox" + i]!.Text, out var ts))
                    totalTime += ts;                
            }
            notifyIcon1.Text = Text = totalTime.ToString("hh':'mm':'ss") + " - Stopwatches";
        }


        private void FStopwatches_FormClosing(object sender, FormClosingEventArgs e)
        {
            var settings = new StopwatchesSettings
            {
                ExclusiveMode = menuItemExclusiveMode.Checked,
                TopMost = TopMost,
                Opacity = Opacity,
                HideTitleWhenInactive = menuItemHideTitleWhenInactive.Checked,
                Size = Size,
                Location = Location,
                Items = new int[10][].Select((v, i) => new string[] {
                            ((TextBox)Controls["textBox" + (i + 1)]!).Text,
                            ((MaskedTextBox)Controls["maskedTextBox" + (i + 1)]!).Text
                        }).ToArray()
            };
            var settingsJson = JsonSerializer.Serialize(settings);
            File.WriteAllText(SETTINGS_FILENAME, settingsJson);
        }

        private void FStopwatches_Load(object sender, EventArgs e)
        {
            if (File.Exists(SETTINGS_FILENAME))
            {
                try
                {
                    // read and parse settings from file
                    var settingsJson = File.ReadAllText(SETTINGS_FILENAME);
                    var settings = JsonSerializer.Deserialize<StopwatchesSettings>(settingsJson) ?? new StopwatchesSettings();

                    // apply settings
                    menuItemExclusiveMode.Checked = settings.ExclusiveMode;
                    setTopMost(settings.TopMost);
                    setOpacity(settings.Opacity);
                    menuItemHideTitleWhenInactive.Checked = settings.HideTitleWhenInactive;
                    if (settings.Items != null)
                    {
                        for (var i = 1; i <= Math.Min(10, settings.Items.Length); i++)
                        {
                            ((TextBox)Controls["textBox" + i]!).Text = settings.Items[i - 1][0];
                            ((MaskedTextBox)Controls["maskedTextBox" + i]!).Text = settings.Items[i - 1][1];
                        }
                    }
                    Size = settings.Size ?? Size;
                    Location = settings.Location ?? Location;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error loading settings", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            calcTotal(sender, e);
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                startStop(sender, e);
            }
        }

        private void FStopwatches_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.D1)
                    startStop(1);
                else if (e.KeyCode == Keys.D2)
                    startStop(2);
                else if (e.KeyCode == Keys.D3)
                    startStop(3);
                else if (e.KeyCode == Keys.D4)
                    startStop(4);
                else if (e.KeyCode == Keys.D5)
                    startStop(5);
                else if (e.KeyCode == Keys.D6)
                    startStop(6);
                else if (e.KeyCode == Keys.D7)
                    startStop(7);
                else if (e.KeyCode == Keys.D8)
                    startStop(8);
                else if (e.KeyCode == Keys.D9)
                    startStop(9);
                else if (e.KeyCode == Keys.D0)
                    startStop(10);
            }
        }

        private void menuItemClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FStopwatches_Activated(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void FStopwatches_Deactivate(object sender, EventArgs e)
        {
            if (menuItemHideTitleWhenInactive.Checked)
                FormBorderStyle = FormBorderStyle.None;
        }

        private void menuItemHideTitleWhenInactive_Click(object sender, EventArgs e)
        {
            FormBorderStyle = menuItemHideTitleWhenInactive.Checked ? FormBorderStyle.None : FormBorderStyle.Sizable;
        }
    }

    public class StopwatchesSettings
    {
        public bool ExclusiveMode { get; set; } = true;
        public bool TopMost { get; set; }
        public double Opacity { get; set; } = 1;
        public bool HideTitleWhenInactive { get; set; }
        public Size? Size { get; set; }
        public Point? Location { get; set; }
        public string[][]? Items { get; set; }
    }
}
