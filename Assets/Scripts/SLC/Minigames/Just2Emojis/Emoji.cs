using UnityEngine;

namespace SLC.Minigames.Just2Emojis
{
    public class Emoji
    {
        // Fields
        private string myName;
        
        // Properties
        public string Name { get; }
        
        // Methods
        public string get_Name()
        {
        
        }
        public Emoji(string name)
        {
            string val_1 = name;
            val_1 = new System.Object();
            this.myName = val_1;
        }
        public override string ToString()
        {
            return System.String.Format(format:  1037585776, arg0:  this.myName);
        }
    
    }

}
