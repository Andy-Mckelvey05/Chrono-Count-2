namespace ChronoCount2.CodeFiles
{
    public partial class HomePageLite : HomeFormCommon
    {
        // Constructer
        public HomePageLite(Settings settings, StartUp startUp, string dataPath) : base(settings, startUp, dataPath)
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
            Display.BeginUpdate();
            Display.SuspendLayout();

            Display.Items.Clear();
            foreach (TimeStamp entries in pages[pageIndex])
            {
                Display.Items.Add(entries.ToShortDisplay());
            }

            Display.ResumeLayout(true);
            Display.EndUpdate();
        }

        // Assigns Controls
        private void SettingsBTN_Click(object sender, EventArgs e) { ClickSettingsBTN(); }
        private void CreateBTN_Click(object sender, EventArgs e) { CreateFormClick(); }
        private void RemoveBTN_Click(object sender, EventArgs e) { RemoveFormClick(); }

        private void TurnLeftBTN_Click(object sender, EventArgs e) { TurnPageLeft(); }
        private void TurnRightBTN_Click(object sender, EventArgs e) { TurnPageRight(); }

        private void GameTime_Tick(object sender, EventArgs e) { OnTick(); }
    }
}
