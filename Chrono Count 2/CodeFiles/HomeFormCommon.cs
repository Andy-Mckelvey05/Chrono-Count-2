using ChronoCount2.Forms;

namespace ChronoCount2.CodeFiles
{
    public class FormItems 
    {
        public required Form thisForm;
        public required Button SettingsBTN, CreateBTN, RemoveBTN, TurnLeftBTN, TurnRightBTN;
        public required ListBox Display;
        public required TextBox NowDisplay;
        public required Label NowLabel, PageDisplay;
        public required System.Windows.Forms.Timer GameTime;
    }

    public abstract class HomeFormCommon(Settings settings, StartUp startUp, string dataPath) : Form
    {
        // Global Variables:
        internal int defaultHight;
        internal List<Form> openedForms = [];
        internal List<TimeStamp> entries = [];
        internal List<TimeStamp[]> pages = [];
        public int pageIndex = 0;

        // Constructer:
        internal Settings settings = settings;
        internal StartUp startUp = startUp;
        internal string dataPath = dataPath;
        internal FormItems formItems;

        internal void SetColours() // Sets the colour of the form 
        {
            Control[] foreColour = [formItems.SettingsBTN, formItems.CreateBTN, formItems.RemoveBTN, formItems.TurnLeftBTN, formItems.TurnRightBTN];
            Control[] midColour = [formItems.NowDisplay, formItems.Display];
            Control[] backColour = [this];

            ColourSetter colourSetter = new(settings, backColour, midColour, foreColour);
        }
        internal void Reset() // Recalibrates the homepage 
        {
            entries.Clear();
            PopulateEntries();

            if (entries.Count > 0)
            {
                MakePages();
                UpdateSize();
                formItems.GameTime.Enabled = true;

                formItems.RemoveBTN.Enabled = true;
                formItems.TurnLeftBTN.Enabled = true;
                formItems.TurnRightBTN.Enabled = true;
            }
            else // runs if the dataset has no elements 
            {
                formItems.GameTime.Enabled = false;
                formItems.PageDisplay.Text = "#/#";
                formItems.NowDisplay.Text = "Create an Event to Start";

                formItems.Display.Items.Clear();
                formItems.Display.Height = formItems.Display.PreferredHeight;
                this.Height = defaultHight;

                formItems.RemoveBTN.Enabled = false;
                formItems.TurnLeftBTN.Enabled = false;
                formItems.TurnRightBTN.Enabled = false;
            }
        }

        // Imports data and displays info:
        internal void PopulateEntries() // Put the contents of the file into the list of entries 
        {
            string data;
            using (var readFile = new StreamReader(dataPath))
            {
                data = readFile.ReadToEnd();
            }
            string[] lines = data.Split('\n');

            foreach (var line in lines)
            {
                string[] temp = line.Split(',');

                try
                {
                    var tempEntry = new TimeStamp(temp[0], Convert.ToDateTime(temp[1]));
                    entries.Add(tempEntry);
                }
                catch
                {
                    continue;
                }
            }
        }
        internal void MakePages() // Turns entries list into a sorted list of pages 
        {
            pages.Clear();
            entries.Sort();
            List<TimeStamp> currentPage = [];

            int i = 0;
            foreach (TimeStamp entry in entries)
            {
                currentPage.Add(entry);
                i++;
                if (i == settings.maxPerPage)
                {
                    pages.Add([.. currentPage]);
                    i = 0;
                    currentPage.Clear();
                }
            }
            if (currentPage.Count > 0) // adds final page
            {
                pages.Add([.. currentPage]);
                currentPage.Clear();
            }
        }
        internal abstract void DisplayPage(); // displays selected page 
        internal void UpdateSize() // formats the size of the display based on page content 
        {
            formItems.PageDisplay.Text = $"{pageIndex + 1}/{pages.Count}";

            DisplayPage();
            this.Height = defaultHight + (pages[pageIndex].Length - 1) * formItems.Display.ItemHeight;
            formItems.Display.Height = formItems.Display.PreferredHeight;
        }

        // Page display functionality:
        internal void ChangePage(bool turnRight) // flip the selected page left or right 
        {
            if (turnRight && !(pageIndex >= pages.Count - 1))
            {
                pageIndex++;
            }
            else if (!turnRight && !(pageIndex <= 0))
            {
                pageIndex--;
            }
            UpdateSize();
        }
        internal void TurnPageLeft() 
        { 
            ChangePage(false); 
        }
        internal void TurnPageRight() 
        {  
            ChangePage(true); 
        }

        // Runs every tick
        internal void OnTick() 
        {
            if (entries.Count > 0)
            {
                formItems.NowDisplay.Text = DateTime.Now.ToString();
                DisplayPage();
            }
        }

        // Make and display other forms:
        internal void MakeForm(Form form) // Generic function to make a function and ensure that only of exists 
        {
            foreach (var x in openedForms)
            {
                x.Close();
                x.Dispose();
            }
            openedForms.Add(form);
            form.Show();
        }
        internal void CreateFormClick()  // Creates an instance of the Create form 
        {
            CreatePage create = new(settings, this, dataPath);
            MakeForm(create);
        }
        internal void RemoveFormClick()  // Creates an instance of the Remove form 
        {
            RemovePage remove = new(settings, this, dataPath, entries, pages);
            MakeForm(remove);
        }
        internal void ClickSettingsBTN() // Creates an instance of the Setting form 

        {
            EditSettings editSettings = new(settings, startUp);
            MakeForm(editSettings);
        }
    }
}
