namespace ChronoCount2
{
    public class TimeStamp(string label, DateTime date) : IComparable<TimeStamp>
    {
        // Constructer:
        readonly string name = label;
        readonly DateTime date = date;

        // Getters:
        public string GetName() { return name; } // Getter for name
        public DateTime GetDate() { return date; } // Getter for date
        public TimeSpan GetSpan() // Gets the span from now to date 
        {
            return date.Subtract(DateTime.Now);
        } 
        private string GetMessage() // returns a string to display the span 
        {
            TimeSpan span = this.GetSpan();

            int d = span.Days;
            int h = span.Hours;
            int m = span.Minutes;
            int s = span.Seconds;

            string message;

            if (d > 9999)
            {
                message = "OverLoad";
            }
            else if (d > 0)
            {
                message = $"{d}d:{h:00}h:{m:00}m:{s:00}s";
            }
            else if (h > 0)
            {
                message = $"{h:00}h:{m:00}m:{s:00}s";
            }
            else if (m > 0)
            {
                message = $"{m:00}m:{s:00}s";
            }
            else if (s > 0)
            {
                message = $"{s:00}s";
            }
            else 
            {
                message = "Done";
            }

            return message;
        }

        // Formatting:
        public int CompareTo(TimeStamp other) // Sorts a list of entries by the length of the span 
        {
            return this.GetSpan().CompareTo(other.GetSpan());
        }
        private string FormatName() // Formats the name if its too long 
        {
            int maxNameLength = 21;
            string slicedText = name;
            if (name.Length > maxNameLength)
            {
                slicedText = string.Concat(name.AsSpan(0, maxNameLength - 3), "...");
            }
            return slicedText;
        }
    
        // Display Item:
        public new string ToString() // Returns a basic string with minimal formatting 
        {
            string formattedName = FormatName();
            string space = new(' ', 22 - formattedName.Length);

            return $"{formattedName}{space}|{date}";
        }
        public string ToLongDisplay() // Returns a basic string with minimal formatting 
        {
            string spanDisplay = GetMessage();
            string dateString = date.ToString("ddd dd MMM yyyy");
            string formattedName = FormatName();

            string[] space = [
                new string (' ', 22 - formattedName.Length), 
                new string (' ', 18 - spanDisplay.Length)
                ];
            return ($"{formattedName}{space[0]}{dateString}{space[1]}{spanDisplay}");
        }
        public string ToShortDisplay() // Returns a condensed string of the formatted object 
        {
            string spanDisplay = GetMessage();
            string formattedName = FormatName();

            string[] space = [
                new string(' ', 22 - formattedName.Length), 
                new string(' ', 18 - spanDisplay.Length)
                ];
            return ($"{formattedName}{space[0]}{space[1]}{spanDisplay}");
        }
    }
}
