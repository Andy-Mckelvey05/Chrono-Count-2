using ChronoCount2.CodeFiles;
using ChronoCount2.Forms;

namespace ChronoCount2
{
    public partial class RemovePage : Form
    {
        // Constructer:
        readonly Settings settings;
        readonly HomeFormCommon mainForm;
        readonly string dataPath;
        readonly List<TimeStamp[]> pages;
        private List<TimeStamp> entries;
        public RemovePage(Settings settings, HomeFormCommon mainForm, string dataPath, List<TimeStamp> entries, List<TimeStamp[]> pages) // Constucter and setup 
        {
            this.settings = settings;
            this.mainForm = mainForm;
            this.dataPath = dataPath;
            this.entries = entries;
            this.pages = pages;

            InitializeComponent();
            SetColours();

            PopulatePageDrop();
            PageDropDown.SelectedIndex = 0;
            DataDropDown.SelectedIndex = 0;
        }
        private void SetColours() // Sets the colour of the form 
        {
            Control[] foreColour = [RemoveBTN];
            Control[] midColour = [PageDropDown, DataDropDown];
            Control[] backColour = [this];

            ColourSetter colourSetter = new(settings, backColour, midColour, foreColour);
        }

        // Dropdown page Menus:
        private void PopulatePageDrop() // Populates the pages dropdown menu 
        {
            PageDropDown.Items.Add("All");
            for (int i = 0; i < pages.Count; i++) 
            {
                PageDropDown.Items.Add(i + 1);
            }
        }
        private void PopulateItemsDrop(int i) // Populates the content table 
        {
            DataDropDown.Items.Clear();
            if (PageDropDown.SelectedIndex == 0) // Adds all the values if the index is set to zero
            {
                DataDropDown.Items.Add("Remove 'Done'");
                foreach (TimeStamp x in entries)
                {
                    DataDropDown.Items.Add(x.ToString());
                }
            }
            else
            {
                foreach (var x in pages[i - 1])
                {
                    DataDropDown.Items.Add(x.ToString()); // Adds only the selected pages contents
                }
            }
            DataDropDown.SelectedIndex = 0;

        }
        private void PageDropDown_SelectedIndexChanged(object sender, EventArgs e) // Event for when you change the selected index 
        {
            PopulateItemsDrop(PageDropDown.SelectedIndex);
        }

        // Remove entire functionality:
        private void RemoveDone() // Removes objects that have finished from the list  
        {
            List<TimeStamp> toRemoveList = [];
            for (int i = 0; i < entries.Count; i++)
            {
                if (entries[i].GetSpan().TotalSeconds < 0)
                {
                    toRemoveList.Add(entries[i]);
                }
            }
            foreach (TimeStamp item in toRemoveList)
            {
                entries.Remove(item);
            }
        }
        private void RewriteFile() // Rewrites the file with the new list 
        {
            using var writeFile = new StreamWriter(dataPath);
            foreach (var entry in entries)
            {
                string line = $"{entry.GetName()},{entry.GetDate()}";
                writeFile.WriteLine(line);
            }

        }
        private void RemoveBTN_Click(object sender, EventArgs e) // lets user decide what to remove 
        {
            int pageIndex = PageDropDown.SelectedIndex;
            int dataIndex = DataDropDown.SelectedIndex;

            if (pageIndex == 0 && dataIndex == 0)
            {
                RemoveDone();
            }
            else if (PageDropDown.SelectedIndex == 0) // removes the object from the entire list
            {
                TimeStamp selected = entries[dataIndex - 1];
                entries.Remove(selected);
            }
            else // Removed the object from selected page
            {
                int index = ((pageIndex - 1) * settings.maxPerPage) + dataIndex;
                TimeStamp selected = entries[index];
                entries.Remove(selected);
            }
            RewriteFile();

            mainForm.pageIndex = 0;
            mainForm.Reset();
            this.Close();
            this.Dispose();
        }
    }
}

