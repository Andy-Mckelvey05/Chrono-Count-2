using ChronoCount2.CodeFiles;
using ChronoCount2.Forms;

namespace ChronoCount2
{
    public partial class CreatePage : Form
    {
        // Constructer:
        readonly Settings settings;
        readonly HomeFormCommon mainForm;
        readonly string dataPath;
        public CreatePage(Settings settings, HomeFormCommon mainForm, string dataPath) // Constructer and set up 
        {
            this.settings = settings;
            this.mainForm = mainForm;
            this.dataPath = dataPath;
            InitializeComponent();
            SetColours();

            DateInput.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }
        private void SetColours() // Sets the colour of the form 
        {
            Control[] foreColour = [BTNCreate];
            Control[] midColour = [NameInput, DateInput];
            Control[] backColour = [this];

            ColourSetter colourSetter = new(settings, backColour, midColour, foreColour);
        }

        // Input Validation:
        private static string ValidName(string text) // Converts "," to "." to circumvent reading errors 
        {
            string name = text;
            return name.Replace(',', '.');
        }
        private bool IsValidateDate(string text) // Checks if the inputted date is valid 
        {
            if (!DateTime.TryParse(text, out _))
            {
                MessageBox.Show("Input must be a valid date", "Error");
                DateInput.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                return false;
            }
            return true;
        }

        // Adds data to the file:
        private void BTNCreate_Click(object sender, EventArgs e) // Wrights the new entire to the file and updates the form 
        {
            if (IsValidateDate(DateInput.Text) )
            {
                string line = $"{ValidName(NameInput.Text)},{DateInput.Text}";

                using (var readFile = new StreamWriter(dataPath, true)) 
                {
                    readFile.WriteLine(line);
                }

                mainForm.Reset();
                this.Close();
                this.Dispose();
            }
            return; //Skips Code if not valid date
        }
    }
}
