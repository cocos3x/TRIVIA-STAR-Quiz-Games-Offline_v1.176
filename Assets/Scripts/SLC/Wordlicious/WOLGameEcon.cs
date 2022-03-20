using UnityEngine;

namespace SLC.Wordlicious
{
    public class WOLGameEcon : GameEcon
    {
        // Fields
        public static System.Collections.Generic.List<SLC.Wordlicious.Letter> lettersDist;
        public static System.Collections.Generic.List<char[,]> ftux;
        public static int[,] levelDefinitions;
        public static System.Collections.Generic.List<int[,]> layouts;
        public static int LetterRemoval;
        public static System.Collections.Generic.Dictionary<int, int> WordPoints;
        public static float[] requiredPorcentages;
        
        // Properties
        public static SLC.Wordlicious.WOLGameEcon Instance { get; }
        
        // Methods
        public static SLC.Wordlicious.WOLGameEcon get_Instance()
        {
            var val_2 = 0;
            GameEcon val_1 = App.getGameEcon;
            if(0 == 0)
            {
                    return;
            }
        
        }
        public WOLGameEcon()
        {
            mem[1152921513900125128] = 0;
        }
        private static WOLGameEcon()
        {
            System.Collections.Generic.List<SLC.Wordlicious.Letter> val_1 = new System.Collections.Generic.List<SLC.Wordlicious.Letter>();
            if(null != 0)
            {
                    Add(item:  new SLC.Wordlicious.Letter() {letter = 'A', dist = 8167});
                Add(item:  new SLC.Wordlicious.Letter() {letter = 'B', dist = 1492});
                Add(item:  new SLC.Wordlicious.Letter() {letter = 'C', dist = 2782});
                Add(item:  new SLC.Wordlicious.Letter() {letter = 'D', dist = 4253});
                Add(item:  new SLC.Wordlicious.Letter() {letter = 'E', dist = 12702});
                Add(item:  new SLC.Wordlicious.Letter() {letter = 'F', dist = 2228});
                Add(item:  new SLC.Wordlicious.Letter() {letter = 'G', dist = 2015});
                Add(item:  new SLC.Wordlicious.Letter() {letter = 'H', dist = 6094});
                Add(item:  new SLC.Wordlicious.Letter() {letter = 'I', dist = 6966});
                Add(item:  new SLC.Wordlicious.Letter() {letter = 'J', dist = 153});
                Add(item:  new SLC.Wordlicious.Letter() {letter = 'K', dist = 772});
                Add(item:  new SLC.Wordlicious.Letter() {letter = 'L', dist = 4025});
                Add(item:  new SLC.Wordlicious.Letter() {letter = 'M', dist = 2406});
                Add(item:  new SLC.Wordlicious.Letter() {letter = 'N', dist = 6749});
                Add(item:  new SLC.Wordlicious.Letter() {letter = 'O', dist = 7507});
                Add(item:  new SLC.Wordlicious.Letter() {letter = 'P', dist = 1929});
                Add(item:  new SLC.Wordlicious.Letter() {letter = 'Q', dist = 95});
                Add(item:  new SLC.Wordlicious.Letter() {letter = 'R', dist = 5987});
                Add(item:  new SLC.Wordlicious.Letter() {letter = 'S', dist = 6327});
                Add(item:  new SLC.Wordlicious.Letter() {letter = 'T', dist = 9056});
                Add(item:  new SLC.Wordlicious.Letter() {letter = 'U', dist = 2758});
                Add(item:  new SLC.Wordlicious.Letter() {letter = 'V', dist = 978});
                Add(item:  new SLC.Wordlicious.Letter() {letter = 'W', dist = 2360});
                Add(item:  new SLC.Wordlicious.Letter() {letter = 'X', dist = 150});
                Add(item:  new SLC.Wordlicious.Letter() {letter = 'Y', dist = 1974});
            }
        
        }
    
    }

}
