using UnityEngine;

namespace SLC.Minigames.Ladder
{
    public class WordLadderLevel
    {
        // Fields
        private string startingWord;
        private string requiredWord;
        private string chosenWord;
        private System.Collections.Generic.Queue<string> ladder;
        
        // Properties
        public string StartingWord { get; set; }
        public string RequiredWord { get; set; }
        public string ChosenWord { get; set; }
        public System.Collections.Generic.Queue<string> Ladder { get; set; }
        
        // Methods
        public string get_StartingWord()
        {
        
        }
        private void set_StartingWord(string value)
        {
            this.startingWord = value;
        }
        public string get_RequiredWord()
        {
        
        }
        private void set_RequiredWord(string value)
        {
            this.requiredWord = value;
        }
        public string get_ChosenWord()
        {
        
        }
        public void set_ChosenWord(string value)
        {
            this.chosenWord = value;
        }
        public System.Collections.Generic.Queue<string> get_Ladder()
        {
        
        }
        public void set_Ladder(System.Collections.Generic.Queue<string> value)
        {
            this.ladder = value;
        }
        public WordLadderLevel(string starting, string required)
        {
            val_1 = new System.Object();
            this.startingWord = starting;
            this.requiredWord = val_1;
            System.Collections.Generic.Queue<twelvegigs.net.JsonRequest> val_2 = new System.Collections.Generic.Queue<twelvegigs.net.JsonRequest>();
            this.ladder = null;
        }
        public override string ToString()
        {
            return System.String.Format(format:  947001408, arg0:  this.startingWord, arg1:  this.requiredWord);
        }
    
    }

}
