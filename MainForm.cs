using System.Windows.Forms;
using System.Text.Json;
using Microsoft.VisualBasic;

namespace krCrosshair
{
    public partial class MainForm : Form
    {
        // global variables
        private string? currentPngPath;

        private List<CrosshairProfile> profiles = new List<CrosshairProfile>();

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadProfilesList();
            UpdateListBox();

            string activeCrosshairPath = Path.Combine(GetAppStoragePath(), "active.png");
            if(File.Exists(activeCrosshairPath))
            {
                pictureBox_CrPreview.Image = new Bitmap(activeCrosshairPath);
                numericSize.Value = Settings.Default.ActiveSize;
                ApplyCrosshairSize();
            }
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_addCr_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set filter for image files
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string imagePath = openFileDialog.FileName;
                        // Load the selected image into the PictureBox

                        pictureBox_CrPreview.Image?.Dispose(); // Dispose of the old image if it exists
                        pictureBox_CrPreview.Image = new Bitmap(imagePath);
                        this.currentPngPath = imagePath; // Store the path for future use
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void numericSize_ValueChanged(object sender, EventArgs e)
        {
            if (numericSize.Value < 0)
            {
                numericSize.Value = 1;
                MessageBox.Show("Size must be a positive value.", "Invalid Size",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            ApplyCrosshairSize();
        }
        private void button_saveCr_Click(object sender, EventArgs e)
        {
            if(pictureBox_CrPreview == null)
            {
                MessageBox.Show("First, load the crosshair.");
                return;
            }

            string profileName = Interaction.InputBox("Enter a name for this profile", "Save profile");

            if(string.IsNullOrWhiteSpace(profileName))
            {
                return;
            }

            try
            {
                string uniqueFileName = Guid.NewGuid().ToString() + ".png";
                string fullSavePath = Path.Combine(GetAppStoragePath(), uniqueFileName);

                pictureBox_CrPreview.Image.Save(fullSavePath, System.Drawing.Imaging.ImageFormat.Png);

                var newProfile = new CrosshairProfile
                {
                    Name = profileName,
                    FilePath = fullSavePath,
                    Size = (int)numericSize.Value
                };

                profiles.Add(newProfile);
                SaveProfilesList();
                UpdateListBox();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Save error: {ex.Message}");
            }
        }
        private void button_deleteCr_Click(object sender, EventArgs e)
        {
            if (listBox_profiles == null || listBox_profiles.SelectedItem == null)
            {
                MessageBox.Show("First, select a profile from the list.");
                return;
            }

            var selectedProfile = (CrosshairProfile)listBox_profiles.SelectedItem;
            var result = MessageBox.Show($"Are you sure you want to delete '{selectedProfile.Name}'?",
                                            "Delete", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                profiles.Remove(selectedProfile);
                SaveProfilesList();
                UpdateListBox();

                try
                {
                    File.Delete(selectedProfile.FilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to delete file: {ex.Message}");
                }
            }

        }
        private void listBox_profiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_profiles.SelectedItem == null)
                return;

            var selectedProfile = (CrosshairProfile)listBox_profiles.SelectedItem;

            try
            {
                pictureBox_CrPreview.Image?.Dispose();
                if (!string.IsNullOrEmpty(selectedProfile.FilePath) && File.Exists(selectedProfile.FilePath))
                {
                    pictureBox_CrPreview.Image = new Bitmap(selectedProfile.FilePath);
                    numericSize.Value = selectedProfile.Size;
                    ApplyCrosshairSize();
                }
                else
                {
                    MessageBox.Show($"Profile image file not found: {selectedProfile.FilePath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load profile: {selectedProfile}\nerror: {ex.Message}");
            }
        }
        private void button_setCr_Click(object sender, EventArgs e)
        {
            if (pictureBox_CrPreview.Image == null)
            {
                MessageBox.Show("Превью пустое.");
                return;
            }

            try
            {
                string activeCrosshairPath = Path.Combine(GetAppStoragePath(), "active.png");
                pictureBox_CrPreview.Image.Save
                    (
                    activeCrosshairPath,
                    System.Drawing.Imaging.ImageFormat.Png
                    );

                Settings.Default.ActiveSize = (int)numericSize.Value;
                Settings.Default.Save();

                MessageBox.Show("the crosshair has been installed successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Failed to set cosshair: {ex.Message}");
            }
        }
        private void ApplyCrosshairSize()
        {
            int newSize = (int)numericSize.Value;

            if (newSize < 0)
            {
                pictureBox_CrPreview.Width = newSize;
                pictureBox_CrPreview.Height = newSize;
            }
        }
        private string GetAppStoragePath()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string appFolder = Path.Combine(appDataPath, "krCrosshair");
            // Create the directory if it doesn't exist
            if (!Directory.Exists(appFolder))
            {
                Directory.CreateDirectory(appFolder);
            }
            return appFolder;
        }
        private void UpdateListBox()
        {
            listBox_profiles.DataSource = null;
            listBox_profiles.DataSource = profiles;
            listBox_profiles.DisplayMember = "Name";
        }
        private void LoadProfilesList()
        {
            string json = Settings.Default.SavedProfilesJson;
            if (!string.IsNullOrEmpty(json))
            {
                try
                {
                    var deserialized = JsonSerializer.Deserialize<List<CrosshairProfile>>(json);
                    profiles = deserialized ?? new List<CrosshairProfile>();
                }
                catch
                {
                    profiles = new List<CrosshairProfile>();
                }
            }
        }
        private void SaveProfilesList()
        {
            string json = JsonSerializer.Serialize(profiles);


            Settings.Default.SavedProfilesJson = json;
            Settings.Default.Save();
        }
       

    }
}
