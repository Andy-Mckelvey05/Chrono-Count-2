namespace ChronoCount2.Forms
{
    internal class ColourSetter
    {
        // Colours the items given in the forms based on settings:
        public ColourSetter(Settings settings, Control[] toForeColour, Control[] toMidColour, Control[] toBackColour) // Sets the colours of the forms 
        {
            int[][] colours = [settings.foreColour, settings.midColour, settings.backColour];
            Control[][] items = [toForeColour, toMidColour, toBackColour];

            for (int i = 0; i < items.Length; i++) 
            {
                SetColour(GetColour(colours[i]), items[i]);
            }
        }
        private static Color GetColour(int[] RGB) // gets colours from settings 
        {
            return Color.FromArgb(RGB[0], RGB[1], RGB[2]);
        }
        private static void SetColour(Color colour, Control[] formItems) // sets the form objects to the correct colour 
        {
            foreach (Control item in formItems) 
            {
                item.BackColor = colour;
            }
        }
    }
}
