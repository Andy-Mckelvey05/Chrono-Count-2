using ChronoCount2.CodeFiles;
using Newtonsoft.Json;

namespace ChronoCount2
{
    public class Settings // contains the attributes for settings
    {
        public bool liteMode;
        public int maxPerPage;
        public required int[] foreColour;
        public required int[] midColour;
        public required int[] backColour;
    }
    public class StartUp
    {
        // Runs at the beginning of the programme and determines what form to display:
        private string dictPath = Chrono_Count_2.Properties.Settings.Default.dictPath;
       
        private string dataPath = "", settingsPath = "";
        readonly Form form;
        public StartUp() // Starts up the programme and imports settings
        {
            VerifyFilePath();
            Settings settings = GetSettingsJSON();

            if (!settings.liteMode) 
            {
                form = new HomePage(settings, this, dataPath);
            }
            else 
            {
                form = new HomePageLite(settings, this, dataPath);
            }
        }

        // Verifies the File path:
        public static string SetUpDefaultJSON() // Sets Default Settings for the programme 
        {
            Settings defaultSetting = new()
            {
                liteMode = false,
                maxPerPage = 10,
                foreColour = [76, 116, 212],
                midColour = [160, 204, 250],
                backColour = [128, 128, 255]
            };

            return JsonConvert.SerializeObject(defaultSetting);
        }
        private void VerifyFilePath() // Create file if it does not exist yet 
        {
            dictPath = Chrono_Count_2.Properties.Settings.Default.dictPath;
            dataPath = dictPath + @"\ChronoCount2.csv";
            settingsPath = dictPath + @"\Settings.json";

            if (!File.Exists(dataPath) || !File.Exists(settingsPath))
            {
                MessageBox.Show("Files Not Found, Please Select a Path", "StartUp");

                FolderBrowserDialog dialog = new();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string newFilePath = dialog.SelectedPath;

                    Chrono_Count_2.Properties.Settings.Default.dictPath = newFilePath;
                    Chrono_Count_2.Properties.Settings.Default.Save();

                    using (var makeFile = new StreamWriter(newFilePath + @"\ChronoCount2.csv")) { };
                    using (var makeFile = new StreamWriter(newFilePath + @"\Settings.json")) 
                    {
                        string defaultJson = SetUpDefaultJSON();
                        makeFile.Write(defaultJson);
                    };
                }

                VerifyFilePath(); // Recurs is the user fails to select a file
            }
        }

        // Getters and Setters:
        public void ValidateSettings(Settings settings) 
        {
            try 
            {
                bool valid_maxPerPage = !(settings.maxPerPage < 1 || settings.maxPerPage > 99);
                bool valid_foreColour = settings.foreColour.Length == 3; // Ensures the element is an array with [0, 1, 2]
                bool valid_midColour = settings.midColour.Length == 3;
                bool valid_backColour = settings.backColour.Length == 3;

                bool validbools = valid_maxPerPage && valid_foreColour && valid_midColour && valid_backColour;
                if (!validbools) { throw new Exception("Invalid JSON Error"); }

                // Encures each RGB value is 
                int[][] colours = [settings.foreColour, settings.midColour, settings.backColour];
                foreach (var colour in colours) 
                {
                    foreach (var RGB in colour) 
                    {
                        if (RGB < 0 || RGB > 255) { throw new Exception("Invalid JSON Error"); }
                    }
                }
            }
            catch 
            {
                // Throws exeption if the code abouve crashes, i.e .Length == 3 will crash if its not an array
                throw new Exception("Invalid JSON Error");
            }
        }
        public Settings GetSettingsJSON() // Gets the Current settings for the JSON 
        {
            string json;
            using (var readSettings = new StreamReader(settingsPath))
            {
                json = readSettings.ReadToEnd() ?? SetUpDefaultJSON();
            };

            try
            {
                Settings settings = JsonConvert.DeserializeObject<Settings>(json)!;
                ValidateSettings(settings); //forces an Error if the JSON has incorrect values
                return settings;
            }
            catch // Returns the default settings if it cant read the Json
            {
                MessageBox.Show("Cannot Read Settings, Restoring to Default Settings", "Invalid JSON Error");
                SetSettingsJSON(SetUpDefaultJSON());
                return JsonConvert.DeserializeObject<Settings>(SetUpDefaultJSON())!;
            }
        }
        public void SetSettingsJSON(string newSettings) // Sets the JSON to have custom inputted questions 
        {
            using StreamWriter writeSettings = new(settingsPath);
            writeSettings.WriteLine(newSettings);
        }
        public Form GetForm() { return form; } // returns the form that should be loaded by program.cs 
    }
}
