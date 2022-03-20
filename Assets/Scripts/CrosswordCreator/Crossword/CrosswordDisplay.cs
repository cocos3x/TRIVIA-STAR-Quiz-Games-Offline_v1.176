using UnityEngine;

namespace CrosswordCreator.Crossword
{
    public class CrosswordDisplay : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject text_prefab;
        private UnityEngine.UI.GridLayoutGroup this_grid;
        private UnityEngine.UI.Text percent_whitespace;
        private UnityEngine.UI.Text unused_words;
        
        // Methods
        public void Setup(CrosswordCreator.Crossword.Crossword _board, float pct_space, System.Collections.Generic.List<string> unusedWords)
        {
            string val_5;
            float val_18;
            float val_19;
            UnityEngine.UI.GridLayoutGroup val_20;
            int val_21;
            var val_22;
            string val_1 = unusedWords.ToString(format:  241913776);
            string val_2 = 241955796 + 241917952;
            if((R3 + 12) > 0)
            {
                    "no dropped words" = "dropped words:";
            }
            
            List.Enumerator<T> val_3 = GetEnumerator();
            val_18 = 1152921510891363008;
            val_19 = " ";
            label_6:
            if(MoveNext() == false)
            {
                goto label_4;
            }
            
            string val_6 = this.unused_words + 1297836560 + val_5;
            goto label_6;
            label_4:
            Dispose();
            this.this_grid.constraint = 1;
            val_20 = this.this_grid;
            val_21 = _board.yWindow;
            val_22 = 0;
            val_20.constraintCount = val_21;
            if(_board.yWindow < 1)
            {
                    return;
            }
            
            val_18 = 1152921513438716192;
            do
            {
                if(_board.xWindow >= 1)
            {
                    do
            {
                char val_7 = _board.Item[0, 0];
                UnityEngine.Transform val_8 = this.this_grid.transform;
                object val_9 = UnityEngine.Object.Instantiate<System.Object>(original:  this.text_prefab, parent:  this.this_grid);
                string val_10 = 0.ToString();
                string val_11 = val_22.ToString();
                string val_12 = 241955768 + 1492657312 + 241955772;
                if(this.text_prefab != 0)
            {
                    this.text_prefab.name = 241955768;
            }
            else
            {
                    0.name = 241955768;
            }
            
                UnityEngine.Transform val_13 = this.text_prefab.transform;
                object val_14 = this.text_prefab.GetComponentInChildren<System.Object>();
                string val_15 = val_7.ToString();
                val_22 = ;
                UnityEngine.Transform val_16 = this.text_prefab.transform;
                object val_17 = this.text_prefab.GetComponentInChildren<System.Object>();
                val_20 = this.text_prefab;
                if(val_7 == ' ')
            {
                    1f = 0.5f;
            }
            
            }
            while(1 < _board.xWindow);
            
            }
            
                var val_18 = val_22;
                val_18 = val_18 + 1;
            }
            while(val_18 < _board.yWindow);
        
        }
        public CrosswordDisplay()
        {
        
        }
    
    }

}
