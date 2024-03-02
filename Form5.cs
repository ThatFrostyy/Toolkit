using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace VideoConverter
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private async void Convert()
        {
            try
            {
                var youtube = new YoutubeClient();
                var video = await youtube.Videos.GetAsync(youtubeLink.Text);
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);

                var videoStreamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
                var audioStreamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();

                var progressHandler = new Progress<double>(percent =>
                {
                    downloadBar.Value = (int)(percent * 100);
                });

                if (mp3Box.Checked == false)
                {
                    try
                    {
                        if (videoStreamInfo != null)
                        {
                            await youtube.Videos.Streams.DownloadAsync(videoStreamInfo, $"{downloadPath.Text}\\{video.Title}.mp4", progressHandler);
                            MessageBox.Show($"Video successfully saved at: {downloadPath.Text}\\{video.Title}.mp4");
                            ClearBoxes();
                        }
                        else
                        {
                            MessageBox.Show("This video is not available for download.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error downloading video: {ex.Message}");
                    }
                }
                else
                {
                    try
                    {
                        if (audioStreamInfo != null)
                        {
                            await youtube.Videos.Streams.DownloadAsync(audioStreamInfo, $"{downloadPath.Text}\\{video.Title}.mp3", progressHandler);
                            MessageBox.Show($"Audio sucessfully saved at: {downloadPath.Text}\\{video.Title}.mp3");
                            ClearBoxes();
                        }
                        else
                        {
                            MessageBox.Show("This audio is not available for download.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error downloading audio: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(youtubeLink.Text) && !string.IsNullOrEmpty(downloadPath.Text))
                {
                    MessageBox.Show($"Error downloading from link: {ex.Message}");
                }
                else
                {
                    MessageBox.Show("You must fill in all the fields!");
                }
            }
            downloadBar.Value = 0;
        }

        private void ClearBoxes()
        {
            youtubeLink.Clear();
            downloadPath.Clear();
            mp3Box.Checked = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    downloadPath.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Convert();
        }

        private void downlaodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Convert();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
