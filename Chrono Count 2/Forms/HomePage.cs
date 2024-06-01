using ChronoCount2.CodeFiles;

namespace ChronoCount2
{
    public partial class HomePage : HomeFormCommon
    {
        // Constructer
        public HomePage(Settings settings, StartUp startUp,string dataPath) : base(settings, startUp, dataPath) 
        {
            InitializeComponent();
            formItems = GetFormItems();
            defaultHight = formItems.thisForm.Height;

            SetColours();
            Reset();
        }
        private FormItems GetFormItems() // Assigns the form items to the relative items 
        {
            return new FormItems
            {
                thisForm = this,
                SettingsBTN = SettingsBTN,
                CreateBTN = CreateBTN,
                RemoveBTN = RemoveBTN,
                TurnLeftBTN = TurnLeftBTN,
                TurnRightBTN = TurnRightBTN,
                Display = Display,
                NowDisplay = NowDisplay,
                NowLabel = NowLabel,
                PageDisplay = PageDisplay,
                GameTime = GameTime
            };
        }
        internal override void DisplayPage() // displays selected page 
        {
            Display.Items.Clear();
            foreach (TimeStamp entries in pages[pageIndex])
            {
                    Display.Items.Add(entries.ToLongDisplay());
            }
        }

        // Assigns Controls
        internal void SettingsBTN_Click(object sender, EventArgs e) { ClickSettingsBTN(); }
        internal void CreateBTN_Click(object sender, EventArgs e) { CreateFormClick(); }
        internal void RemoveBTN_Click(object sender, EventArgs e) { RemoveFormClick(); }
        
        internal void TurnLeftBTN_Click(object sender, EventArgs e) { TurnPageLeft(); }
        internal void TurnRightBTN_Click(object sender, EventArgs e) { TurnPageRight(); }

        internal void GameTime_Tick(object sender, EventArgs e) { OnTick(); }
    }
}
