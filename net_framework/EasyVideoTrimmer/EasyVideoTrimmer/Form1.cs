using LibVLCSharp.Shared;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace EasyVideoTrimmer
{
    public partial class Form1 : Form
    {
        public LibVLC _libVLC;
        public MediaPlayer _mp;
        public Media media;
        private string openFileName = "";

        private bool playing = false;

        private bool dragSliderMouseDown = false;

        private bool slideBeingHandled = false;

        private string outputFolder;

        private string defaultOpenDirectory;

        private bool playingFromSelection = false;
        private int playingFromSelectionPointBar = -1;

        public Form1()
        {
            InitializeComponent();
            LibVLCSharp.Shared.Core.Initialize();
            _libVLC = new LibVLC();
            _mp = new MediaPlayer(_libVLC);
            videoView1.MediaPlayer = _mp;
            _mp.PositionChanged += _mp_PositionChanged;
            _mp.LengthChanged += _mp_LengthChanged;
            _mp.EndReached += _mp_EndReached;
            sizeCombo.SelectedIndex = 3;
            selectionRangeSlider1.SelectionChanged += SelectionRangeSlider1_SelectionChanged;

            LoadSettingsFromXML();
        }

        private void _mp_EndReached(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(_ => 
                {
                media = new Media(_libVLC, openFileName);
                if (_mp.Play(media))
                {
                    playing = true;
                        _mp.Pause();
                }
            });
        }

        private void LoadSettingsFromXML()
        {
            try
            {
                if (File.Exists("Settings.xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(UserSettings));

                    StreamReader reader = new StreamReader("Settings.xml");
                    UserSettings settings = (UserSettings)serializer.Deserialize(reader);
                    defaultOpenDirectory = settings.DefaultDirectory;
                    outputFolder = settings.OutputFolder;
                    outputFolderLabel.Text = outputFolder;
                    defaultDirectoryLabel.Text = defaultOpenDirectory;
                    reader.Close();
                }
            }
            catch
            {

            }
        }

        private void SelectionRangeSlider1_SelectionChanged(object sender, EventArgs e)
        {
            Invoke((Action)(() =>
            {
                UpdateSelectedTimes();
            }));
        }

        public void UpdateSelectedTimes()
        {
            decimal percentageOfTimeMinSelection = selectionRangeSlider1.SelectedMin / 10M;
            decimal percentageOfTimeMaxelection = selectionRangeSlider1.SelectedMax / 10M;

            decimal onePercentMs = _mp.Length / 100 / 1000M;

            if(_mp.Length <= 0)
            {
                Thread.Sleep(500);
                onePercentMs = _mp.Length / 100 / 1000M;
            }

            decimal secondsMin = onePercentMs * percentageOfTimeMinSelection;
            decimal secondsMax = onePercentMs * percentageOfTimeMaxelection;

            decimal secondsDuration = secondsMax - secondsMin;

            startSelectionText.Text = secondsMin.ToString("0.00");
            endSelectionText.Text = secondsMax.ToString("0.00");
            selectedDurationText.Text = secondsDuration.ToString("0.00");

            UpdateExpectedSize();
        }

        private void _mp_LengthChanged(object sender, MediaPlayerLengthChangedEventArgs e)
        {
            Invoke((Action)(() =>
            {
                maxTimeLabel.Text = (_mp.Length / 1000M).ToString("#.##");
            }));
        }

        private void _mp_PositionChanged(object sender, MediaPlayerPositionChangedEventArgs e)
        {
            Invoke((Action)(() =>
            {
                
                selectionRangeSlider1.Value = Convert.ToInt32(e.Position * 1000);
                if(playingFromSelection == true && selectionRangeSlider1.Value >= playingFromSelectionPointBar)
                {
                    _mp.Pause();
                    playingFromSelection = false;
                }

                if (dragSliderMouseDown == false)
                {
                    trackBar1.Value = Convert.ToInt32(e.Position * 1000);
                }
                decimal onePercentTime = _mp.Length / 100M;
                decimal percentLength = (onePercentTime * Convert.ToDecimal(e.Position * 10))/100M;
                currentTimeLabel.Text = percentLength.ToString("#.##");
            }));
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            playingFromSelection = false;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if(String.IsNullOrEmpty(defaultOpenDirectory) == false)
                {
                    ofd.InitialDirectory = defaultOpenDirectory;
                }

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    openFileName = ofd.FileName;
                    defaultOpenDirectory = Path.GetDirectoryName(openFileName);
                    SaveSettingsToXML();
                    defaultDirectoryLabel.Text = defaultOpenDirectory;

                    ThreadPool.QueueUserWorkItem(_ => {
                        media = new Media(_libVLC, ofd.FileName);
                        if (_mp.Play(media))
                        {
                            selectionRangeSlider1.SelectedMin = 0;
                            selectionRangeSlider1.SelectedMax = 1000;
                            UpdateSelectedTimes();
                            playing = true;
                        }
                    });

                }
            }
        }

        private void SaveSettingsToXML()
        {
            UserSettings toSave = new UserSettings();
            toSave.DefaultDirectory = defaultOpenDirectory;
            toSave.OutputFolder = outputFolder;

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(toSave.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, toSave);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    xmlDocument.Save("Settings.xml");
                }
            }
            catch
            {
                // TODO Log exception here
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            _mp.Play();
            playingFromSelection = false;
            playing = true;
        }

        private void selectionRangeSlider1_ValueChangedByHand(object sender, EventArgs e)
        {
            _mp.Pause();
            _mp.Position = (float)Convert.ToDecimal(selectionRangeSlider1.Value / 1000M);
            playingFromSelection = false;

            if (playing)
            {
                _mp.Play();
            }
            else
            {
                _mp.Play();
                _mp.Pause();
            }
        }

        private void trackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            dragSliderMouseDown = true;
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            dragSliderMouseDown = false;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (dragSliderMouseDown)
            {
                while (slideBeingHandled)
                {
                    Thread.Sleep(1);
                }
                slideBeingHandled = true;

                _mp.Pause();
                _mp.Position = (float)Convert.ToDecimal(trackBar1.Value / 1000M);
                if (playing)
                {
                    _mp.Play();
                }
                else
                {
                    _mp.Play();
                    _mp.Pause();
                }
                slideBeingHandled = false;

            }
        }

        private void UpdateExpectedSize()
        {
            try
            {
                decimal durationOfSelection = Decimal.Parse(selectedDurationText.Text);
                var bitRate = bitRateNUD.Value;
                decimal projectedSize = durationOfSelection * bitRate / 10;
                expectedFileSizeLabel.Text = projectedSize.ToString("#.#");
                if(projectedSize >= 16)
                {
                    expectedFileSizeLabel.ForeColor = Color.Red;
                }
                else
                {
                    expectedFileSizeLabel.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("exc ui[date exp: " + ex.Message);
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Environment.CurrentDirectory + "\\" + "ffmpeg.exe") == false)
                {
                    MessageBox.Show("ffmpeg.exe not found in executable directory, please download from : https://www.ffmpeg.org/download.html");
                }
                else
                {
                    if (String.IsNullOrEmpty(outputFolder))
                    {
                        MessageBox.Show("No default output directory set, please set output folder");
                        setOutputFolderBUtton_Click(sender, e);
                    }

                    if (String.IsNullOrEmpty(outputFolder))
                    {
                        return;
                    }

                    string outputFileName = outputFolder + "\\" + "out-" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".mp4";
                    string ffmpegCommand = $"-i \"{openFileName}\" -t {selectedDurationText.Text} -ss {startSelectionText.Text} -b:v {bitRateNUD.Value}M -vf \"scale={sizeCombo.Text}:-2\" -pix_fmt yuv420p \"{outputFileName}\"";
                    var result = Process.Start(new ProcessStartInfo()
                    {
                        FileName = "ffmpeg.exe",
                        Arguments = ffmpegCommand
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem :  " + ex.Message);
            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            _mp.Pause();
            playingFromSelection = false;

            playing = false;
        }

        private void selectionStartPlaybackButton_Click(object sender, EventArgs e)
        {
            decimal percentageOfTimeMinSelection = selectionRangeSlider1.SelectedMin / 1000M;
            _mp.Pause();
            _mp.Position = (float)percentageOfTimeMinSelection;

            playingFromSelection = true;
            playingFromSelectionPointBar = selectionRangeSlider1.SelectedMax;

            _mp.Play();
            playing = true;
        }

        private void setInSelectButton_Click(object sender, EventArgs e)
        {
            float currentPosition = _mp.Position;
            // This current position will be decimal, max 1.00
            selectionRangeSlider1.SelectedMin = (int)(currentPosition * 1000);
        }

        private void setEditOutButton_Click(object sender, EventArgs e)
        {
            float currentPosition = _mp.Position;
            // This current position will be decimal, max 1.00
            selectionRangeSlider1.SelectedMax = (int)(currentPosition * 1000);
        }

        private void bitRateNUD_ValueChanged(object sender, EventArgs e)
        {
            UpdateSelectedTimes();
        }

        private void setOutputFolderBUtton_Click(object sender, EventArgs e)
        {
            using (var ofd = new FolderBrowserDialog())
            {
                if (String.IsNullOrEmpty(outputFolder) == false)
                {
                    ofd.SelectedPath = outputFolder;
                }

                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    outputFolderLabel.Text = ofd.SelectedPath;
                    outputFolder = ofd.SelectedPath;
                    SaveSettingsToXML();
                }
            }
        }
    }
}
