using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Common;
using NReco.VideoConverter;

namespace YoutubePlaylistDownloader
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async Task DownloadPlaylistVideosAsync(string playlistUrl)
        {
            try
            {
                var youtubeClient = new YoutubeClient();
                var playlist = await youtubeClient.Playlists.GetAsync(playlistUrl);

                if (playlist != null)
                {
                    var videos = await youtubeClient.Playlists.GetVideosAsync(playlist.Id);

                    var folderBrowserDialog = new FolderBrowserDialog();
                    folderBrowserDialog.Description = "Select a folder to save downloaded audio";
                    DialogResult result = folderBrowserDialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        string selectedFolder = folderBrowserDialog.SelectedPath;

                        foreach (var video in videos)
                        {
                            var streamInfoSet = await youtubeClient.Videos.Streams.GetManifestAsync(video.Id);
                            var audioStreamInfo = streamInfoSet.GetAudioOnlyStreams().FirstOrDefault();

                            if (audioStreamInfo != null)
                            {
                                string videoTitle = string.Join("_", video.Title.Split(Path.GetInvalidFileNameChars()));
                                var fileName = $"{videoTitle}.wav";
                                var filePath = Path.Combine(selectedFolder, fileName);

                                StatusLabel.Text = $"Downloading: {fileName}";

                                var ffMpeg = new FFMpegConverter();
                                ffMpeg.ConvertMedia(audioStreamInfo.Url, filePath, "wav");

                                StatusLabel.Text = string.Empty;
                            }

                        }

                        MessageBox.Show("Download completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Playlist not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                SubmitButton.Enabled = true;
            }

        }


        private async void SubmitButton_Click_1(object sender, EventArgs e)
        {
            string playlistLink = URLTextbox.Text;
            string regexPattern = @"^(?:https?:\/\/)?(?:www\.)?youtube\.com\/playlist\?list=([A-Za-z0-9_\-]+)(?:&[^&]+)*$";
            if (!Regex.IsMatch(playlistLink, regexPattern))
            {
                MessageBox.Show("Invalid youtube playlist URL");
                return;
            }
            else
            {
                await DownloadPlaylistVideosAsync(playlistLink);
            }
        }
    }
}


    