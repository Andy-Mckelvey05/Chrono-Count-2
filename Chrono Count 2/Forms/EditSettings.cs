using ChronoCount2.Forms;
using Microsoft.VisualBasic;
using System.Text.Json;

namespace ChronoCount2
{
    public partial class EditSettings : Form
    {
        // Constructer:
        readonly Settings settings;
        readonly StartUp startUp;
        private bool editing = false;
        public EditSettings(Settings settings, StartUp startUp) // Constucter and SetUp 
        {
            this.settings = settings;
            this.startUp = startUp;

            InitializeComponent();
            SettingGB.Enabled = false;

            SetColours();

            DisplayCurrentSettings();
        }
        private void SetColours() // Sets the colour of the form 
        {
            Control[] foreColourItems = [ForeColourEdit, MidColourEdit, BackColourEdit, EditSetting, RestoreDefaults];
            Control[] midColourItems = [FilePathDisplay, MaxPerPageDisplay, ForeColourBorder, MidColourBorder, BackColourBorder];
            Control[] backColourItems = [this];

            ColourSetter colourSetter = new(settings, backColourItems, midColourItems, foreColourItems);
        }

        // Displays current settings:
        private static void DisplayRGB(int[] RGB, TextBox tb) // Displays a RGB value in a readable context 
        {
            string message = "";
            foreach (int i in RGB) 
            {
                message += i.ToString() + ",";
            }
            tb.Text = message[..^1];
        }
        private static int[] GetRGB(Color RGB) { return [RGB.R, RGB.G, RGB.B]; } // Returns a RGB value from a colour
        private static Color GetColour(int[] RGB) // gets a colour from an RGB value 
        {
            return Color.FromArgb(RGB[0], RGB[1], RGB[2]);
        }
        private void DisplayCurrentSettings() // Displays the users current settings 
        {
            FilePathDisplay.Text = Chrono_Count_2.Properties.Settings.Default.dictPath;
            LightModeToggle.Checked = settings.liteMode;
            MaxPerPageDisplay.Text = settings.maxPerPage.ToString();

            int[][] colours = [settings.foreColour, settings.midColour, settings.backColour];
            TextBox[] textBoxes = [ForeColourDisplay, MidColourDisplay, BackColourDisplay];
            for (int i = 0; i < colours.Length; i++) 
            {
                DisplayRGB(colours[i], textBoxes[i]);
                textBoxes[i].BackColor = GetColour(colours[i]);
            }
        }

        // Editing colours functionality:
        private static void EditColour(TextBox tb) // Lets the user select a new colour and displays it 
        {
            ColorDialog changeColour = new();
            if (changeColour.ShowDialog() == DialogResult.OK) 
            {
                Color selected = changeColour.Color;
                int[] RGB = [selected.R, selected.G, selected.B];

                tb.BackColor = selected;
                DisplayRGB(RGB, tb);
            }

        }
        private void ForeColourEdit_Click(object sender, EventArgs e) // Trigger event for a colour display  
        {
            EditColour(ForeColourDisplay);
        }
        private void MidColourEdit_Click(object sender, EventArgs e) // Trigger event for a colour display 
        {
            EditColour(MidColourDisplay);
        }
        private void BackColourEdit_Click(object sender, EventArgs e) // Trigger event for a colour display 
        {
            EditColour(BackColourDisplay);
        }

        private static int ValidateMaxPerPage(string input) // ensures the user inputs a valid item in the textbox 
        {
            while (true) 
            {
                if (int.TryParse(input, out _))
                {
                    int numInput = Convert.ToInt32(input);
                    if (numInput <= 99 && numInput >= 1)
                    {
                        return Convert.ToInt32(input);
                    }
                }
                input = Interaction.InputBox("Entries/Page Must be a Number Between 1 and 99", "Error");
            }
            
        }

        // Saving setting functionality:
        private void SaveSettings(string newSettings) // sets Json with imported settings 
        {
            string message = "Are you sure? This will close the programme";
            DialogResult dialogResult = MessageBox.Show(message, "WARNING!", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                startUp.SetSettingsJSON(newSettings);
                Environment.Exit(0);
            }
            else
            {
                SettingGB.Enabled = false;
                DisplayCurrentSettings();
            }
        }
        private void EditSetting_Click(object sender, EventArgs e) // sets Json to custom settings 
        {
            if (!editing) 
            {
                editing = true;
                EditSetting.Text = "Confirm?";
                SettingGB.Enabled = true;
            }
            else // plays on a 2nd click of the button 
            {
                editing = false;

                Settings newSetting = new()
                {
                    liteMode = LightModeToggle.Checked,
                    maxPerPage = ValidateMaxPerPage(MaxPerPageDisplay.Text),
                    foreColour = GetRGB(ForeColourDisplay.BackColor),
                    midColour = GetRGB(MidColourDisplay.BackColor),
                    backColour = GetRGB(BackColourDisplay.BackColor)
                };

                string newSettings = JsonSerializer.Serialize(newSetting);

                SaveSettings(newSettings);
                EditSetting.Text = "Click to Edit Settings";
            }
        }
        private void RestoreDefaults_Click(object sender, EventArgs e) // sets Json to default settings 
        {
            SaveSettings(StartUp.SetUpDefaultJSON());
        }
    }
}
