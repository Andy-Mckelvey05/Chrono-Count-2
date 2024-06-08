using Chrono_Count_2.Properties;
using ChronoCount2.CodeFiles;
using System.Text.Json;


namespace ChronoCount2
{
    public class Settings // contains the attributes for settings
    {
        public bool liteMode { get; set; }
        public int maxPerPage { get; set; }
        public required int[] foreColour { get; set; }
        public required int[] midColour { get; set; }
        public required int[] backColour { get; set; }
    }
    public class StartUp
    {
        // Runs at the beginning of the programme and determines what form to display:
        private string dataPath = $@"{Environment.CurrentDirectory}\ChronoCount2.csv";
        private string settingsPath = $@"{Environment.CurrentDirectory}\Settings.json";
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
            return JsonSerializer.Serialize(defaultSetting);
        }
        private void VerifyFilePath() // Create file if it does not exist yet 
        {
            if (!File.Exists(dataPath) || !File.Exists(settingsPath))
            {
                using (var makeFile = new StreamWriter(dataPath, true)) { }; // Append set to true so user can keep data
                using (var makeFile = new StreamWriter(settingsPath))
                {
                    string defaultJson = SetUpDefaultJSON();
                    makeFile.Write(defaultJson);
                };

                VerifyFilePath(); // Recurs is the user fails to select a file
            }
        }

        // Json Verification
        public bool InvalidColours(Settings settings) // Returns True if the Jsons colours are INvalid
        {
            try 
            {
                int[][] colours = [settings.foreColour, settings.midColour, settings.backColour];
                foreach (var colour in colours)
                {
                    if (colour.Length != 3) { return true; }
                    foreach (int RGB in colour)
                    {
                        if (RGB < 0 || RGB > 255) { return true; }
                    }
                }
                return false;
            }
            catch 
            { 
                return true;
            }
        }
        public bool ValidateSettings(string json, Settings settings)  // Returns true if the json has valid data 
        {
            bool lightModeInvalid;
            bool maxPerPageInvalid;
            bool coloursInvalid;
            try 
            {
                lightModeInvalid = json.Substring(2, 8) != "liteMode";
                maxPerPageInvalid = (settings.maxPerPage < 1 || settings.maxPerPage > 99);
                coloursInvalid = InvalidColours(settings);
            }
            catch 
            {
                return false;
            }

            if (lightModeInvalid || maxPerPageInvalid || coloursInvalid)
            {
                return false;
            }
            return true;
        }

        // Getters and Setters:
        public Settings GetSettingsJSON() // Gets the Current settings for the JSON 
        {
            string json;
            using (var readSettings = new StreamReader(settingsPath))
            {
                json = readSettings.ReadToEnd() ?? SetUpDefaultJSON();
            };

            Settings settings;
            try
            {
                settings = JsonSerializer.Deserialize<Settings>(json)!;
                if (!ValidateSettings(json, settings)) { throw new Exception("Invalid JSON Error"); }
            }
            catch // Returns the default settings if it cant read the Json
            {
                MessageBox.Show("Cannot Read Settings, Restoring to Default Settings", "Invalid JSON Error");
                SetSettingsJSON(SetUpDefaultJSON()); // retuns the file to default settings
                settings = JsonSerializer.Deserialize<Settings>(SetUpDefaultJSON())!; // Sets the current runtime to default
            }
            return settings;
        }
        public void SetSettingsJSON(string newSettings) // Sets the JSON to have custom inputted questions 
        {
            using StreamWriter writeSettings = new(settingsPath);
            writeSettings.WriteLine(newSettings);
        }
        public Form GetForm() { return form; } // returns the form that should be loaded by program.cs 
    }
}
