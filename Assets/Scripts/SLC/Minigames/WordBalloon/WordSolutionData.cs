using UnityEngine;

namespace SLC.Minigames.WordBalloon
{
    public class WordSolutionData
    {
        // Fields
        public string word;
        public System.Collections.Generic.List<int> slotSequence;
        
        // Methods
        public WordSolutionData(string _word, System.Collections.Generic.List<int> sequence)
        {
            val_1 = new System.Object();
            this.word = _word;
            this.slotSequence = val_1;
        }
        public override string ToString()
        {
            var val_5;
            var val_6;
            val_5 = 0;
            val_6 = "";
            goto label_1;
            label_7:
            if("" <= val_5)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + 0;
            string val_1 = (0 + 0) + 16.ToString();
            string val_2 = 1098586544 + 991337644;
            val_6 = val_6;
            if(val_5 < 1152921510000400815)
            {
                    string val_3 = 1098586544 + 1370307136;
                val_6 = val_6;
            }
            
            val_5 = 1;
            label_1:
            if(val_5 < val_6)
            {
                goto label_7;
            }
            
            typeof(System.String[]).__il2cppRuntimeField_10 = "{ Word: ";
            typeof(System.String[]).__il2cppRuntimeField_14 = this.word;
            typeof(System.String[]).__il2cppRuntimeField_18 = ", SlotSequence: [";
            typeof(System.String[]).__il2cppRuntimeField_1C = val_6;
            typeof(System.String[]).__il2cppRuntimeField_20 = "] }";
            string val_4 = +477709520;
        }
    
    }

}
