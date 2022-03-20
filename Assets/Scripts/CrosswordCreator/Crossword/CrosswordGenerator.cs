using UnityEngine;

namespace CrosswordCreator.Crossword
{
    public class CrosswordGenerator
    {
        // Fields
        private const float emptySquarePercentThreshold = 0.75;
        public System.Action<CrosswordCreator.Crossword.Crossword, float, System.Collections.Generic.List<string>> OnCrosswordCreated;
        private System.Collections.Generic.List<string> _words;
        private System.Collections.Generic.Queue<string> _order;
        private System.Collections.Generic.List<string> droppedWords;
        private CrosswordCreator.Crossword.Crossword _board;
        
        // Properties
        public bool usedAllWords { get; }
        
        // Methods
        public bool get_usedAllWords()
        {
            if(this.droppedWords != 0)
            {
                    return false;
            }
            
            return false;
        }
        public CrosswordCreator.Crossword.Crossword GetBoard()
        {
        
        }
        public void Generate(System.Collections.Generic.List<string> words, int maxWidth, int maxHeight)
        {
            this._words = words;
            this._board = new CrosswordCreator.Crossword.Crossword(maxWidth:  maxWidth, maxHeight:  maxHeight);
            PluginExtension.Shuffle<UnityEngine.Sprite>(list:  this._words, seed:  new System.Nullable<System.Int32>() {HasValue = false});
            System.Collections.Generic.Queue<System.String> val_2 = new System.Collections.Generic.Queue<System.String>(collection:  this._words);
            this._order = null;
            this.GenCrossword();
        }
        private void GenCrossword()
        {
            this.droppedWords.Clear();
            this._board.Reset();
            goto label_3;
            label_15:
            this.droppedWords.Add(item:  this._board);
            label_3:
            bool val_1 = this._board.HasAvailableCrosspoints();
            if(((val_1 == false) || (val_1 < true)) || (val_1 == true))
            {
                goto label_10;
            }
            
            string val_2 = this._order.Dequeue();
            bool val_3 = this._board.AddWord(word:  this._order);
            if(val_3 == true)
            {
                goto label_3;
            }
            
            if(0 > val_3)
            {
                goto label_15;
            }
            
            this._order.Enqueue(item:  this._order);
            var val_4 = 0 + 1;
            goto label_3;
            label_10:
            this._board.Trim();
        }
        public CrosswordGenerator()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.droppedWords = null;
        }
    
    }

}
