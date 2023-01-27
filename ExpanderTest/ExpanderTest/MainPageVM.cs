using System.Collections.ObjectModel;

namespace ExpanderTest
{
    public class MainPageVM
    {
        public ObservableCollection<string> Strings { get; set; }

        public MainPageVM()
        {
            Strings = new ObservableCollection<string>
            {
                "One",
                "Two",
                "Three",
                "Four",
                "Five",
                "Six",
                "Seven",
                "Eight",
            };
        }
    }
}
