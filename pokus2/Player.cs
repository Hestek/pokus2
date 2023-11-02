using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace pokus2
{
    public class Player
    {
        private int selectedColorIndex = 0;

        public int X { get; set; }
        public int Y { get; set; }

        public int Distance { get; set; }

        public List<Brush> Colors { get; set; }
        public Brush SelectedColor { get => Colors[selectedColorIndex]; }

        public Player()
        {
            Colors = new List<Brush>()
            {
                Brushes.Green,
                Brushes.Red,
                Brushes.Orange,
                Brushes.Blue
            };
        }

        public void SelectNextColor()
        {
            selectedColorIndex++;
            if(selectedColorIndex >= Colors.Count)
            {
                selectedColorIndex = 0;
            }
        }
    }
}
