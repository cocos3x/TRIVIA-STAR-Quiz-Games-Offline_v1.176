using UnityEngine;

namespace SLC.Minigames.WordFill
{
    public class WordFillLevel : WFLShape
    {
        // Fields
        public System.Collections.Generic.List<string> answers;
        public System.Collections.Generic.List<System.Collections.Generic.HashSet<int>> answerPaths;
        
        // Methods
        public WordFillLevel(int size)
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.answers = null;
            val_4 = null;
            val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.answerPaths = val_4;
            this = new System.Object();
            if(size <= 9)
            {
                goto label_1;
            }
            
            if(size == 12)
            {
                goto label_2;
            }
            
            if(size != 16)
            {
                goto label_6;
            }
            
            val_5 = 4;
            val_6 = this;
            mem[1152921514149848524] = val_5;
            mem[1152921514149848528] = val_5;
            val_7 = 4;
            goto label_7;
            label_1:
            if(size == 6)
            {
                goto label_5;
            }
            
            if(size != 9)
            {
                goto label_6;
            }
            
            val_5 = 3;
            val_6 = this;
            mem[1152921514149848524] = val_5;
            mem[1152921514149848528] = val_5;
            val_7 = 3;
            goto label_7;
            label_6:
            val_7 = 4;
            val_6 = this;
            mem[1152921514149848524] = val_7;
            val_5 = 5;
            goto label_9;
            label_2:
            val_7 = 3;
            val_6 = this;
            mem[1152921514149848524] = val_7;
            val_5 = 4;
            goto label_9;
            label_5:
            val_7 = 3;
            val_6 = this;
            mem[1152921514149848524] = val_7;
            val_5 = 2;
            label_9:
            mem[1152921514149848528] = val_5;
            label_7:
            mem[1152921514149848520] = null;
            if(953054900 < 1)
            {
                    return;
            }
            
            var val_5 = 0;
            do
            {
                if(mem[1152921514149848524] >= 1)
            {
                    var val_4 = 0;
                do
            {
                val_4 = val_4 + 1;
                mem[1152921506875846640] = 32;
            }
            while(val_4 < mem[1152921514149848524]);
            
                val_8 = 16860748;
            }
            
                val_5 = val_5 + 1;
            }
            while(val_5 < val_8);
        
        }
        public void AddShape(SLC.Minigames.WordFill.WFLShape shape)
        {
            SLC.Minigames.WordFill.WordFillLevel val_7;
            SLC.Minigames.WordFill.WFLShape val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            int val_14;
            var val_19;
            val_7 = this;
            val_8 = shape;
            System.Collections.Generic.HashSet<System.Int32> val_1 = new System.Collections.Generic.HashSet<System.Int32>();
            val_9 = 0;
            val_10 = 0;
            val_11 = 0;
            val_1 = (public System.Void System.Collections.Generic.HashSet<System.Int32>::.ctor()) * val_1;
            if(val_1 < 1)
            {
                goto label_7;
            }
            
            val_11 = 0;
            val_10 = 0;
            label_6:
            val_12 = mem[R5 + 8];
            val_12 = R5 + 8;
            if(val_12 <= val_11)
            {
                    val_12 = mem[R5 + 8];
                val_12 = R5 + 8;
            }
            
            val_13 = mem[R5 + 8 + 8];
            val_13 = R5 + 8 + 8;
            if(val_13 <= val_10)
            {
                    var val_8 = 0;
            }
            
            val_12 = R5 + (val_12 << 1);
            if(((R5 + (R5 + 8) << 1) + 16) == 32)
            {
                goto label_7;
            }
            
            val_11 = val_11 + 1;
            if(val_11 == ((R5 + (R5 + 8) << 1) + 16))
            {
                    val_10 = val_10 + 1;
                val_11 = val_11 - ((R5 + (R5 + 8) << 1) + 16);
            }
            
            val_8 = val_8 * ((R5 + (R5 + 8) << 1) + 16);
            if(((R5 + (R5 + 8) << 1) + 16) < val_8)
            {
                goto label_6;
            }
            
            goto label_7;
            label_13:
            val_9 = 1;
            label_7:
            val_14 = shape.width;
            if(val_9 >= (val_14 - 1))
            {
                goto label_9;
            }
            
            val_13 = mem[shape.width + 8];
            val_13 = shape.width + 8;
            if((shape.grid[val_13 * val_9]) == ('-'))
            {
                goto label_13;
            }
            
            val_14 = shape.width;
            label_9:
            val_14 = shape.height * val_14;
            if(val_9 < val_14)
            {
                    int val_4 = val_11 - val_9;
                do
            {
                val_13 = mem[(((val_11 + 1) - (R5 + (R5 + 8) << 1) + 16) - val_9) + 8];
                val_13 = (((val_11 + 1) - (R5 + (R5 + 8) << 1) + 16) - val_9) + 8;
                char val_10 = shape.grid[val_4];
                if(val_10 != ('-'))
            {
                    char val_11 = shape.grid[val_10];
                var val_5 = 0 + val_10;
                var val_6 = val_4 + val_9;
                val_13 = val_1;
                val_11 = val_7 + (val_11 << 1);
                val_7 = val_7;
                mem2[0] = val_11;
                int val_12 = val_4;
                val_12 = val_12 + val_11;
                bool val_7 = Add(item:  val_12);
                val_8 = val_8;
            }
            
                val_9 = val_9 + 1;
                var val_13 = shape + 16;
                if(val_9 == (shape + 12))
            {
                    0 = 0 + 1;
                val_9 = val_9 - (shape + 12);
            }
            
                val_13 = val_13 * (shape + 12);
            }
            while((shape + 12) < val_13);
            
            }
            
            val_19 = val_1;
            if(mem[1152921514150076248] == 0)
            {
                    val_19 = val_1;
            }
            
            mem[1152921514150076248].Add(item:  146378752);
        }
        public override void HFlip()
        {
            this.HFlip();
            this.PathMod(type:  0);
        }
        public override void VFlip()
        {
            this.VFlip();
            this.PathMod(type:  1);
        }
        public override void Rot()
        {
            this.Rot();
            this.PathMod(type:  2);
        }
        public void PathMod(int type)
        {
            var val_8;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            List.Enumerator<T> val_2 = GetEnumerator();
            label_18:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            System.Collections.Generic.HashSet<System.Int32> val_5 = new System.Collections.Generic.HashSet<System.Int32>();
            HashSet.Enumerator<T> val_6 = GetEnumerator();
            label_13:
            if(MoveNext() == false)
            {
                goto label_4;
            }
            
            if(type == 2)
            {
                goto label_5;
            }
            
            if(type == 1)
            {
                goto label_6;
            }
            
            if(type != 0)
            {
                goto label_13;
            }
            
            var val_9 = mem[1152921514150645068] + val_8;
            int val_14 = ~mem[1152921514150645068];
            val_9 = val_9 + val_14;
            val_14 = val_9 - mem[1152921514150645068];
            bool val_10 = Add(item:  val_14);
            goto label_13;
            label_5:
            int val_15 = ~val_8;
            val_15 = mem[1152921514150645068] + val_15;
            bool val_11 = Add(item:  val_15);
            goto label_13;
            label_6:
            int val_16 = ~val_8;
            val_16 = mem[1152921514150645072] + val_16;
            bool val_12 = Add(item:  val_16);
            goto label_13;
            label_4:
            var val_17 = 0;
            val_17 = val_17 + 1;
            mem2[0] = 131;
            Dispose();
            var val_19 = val_17;
            if(val_19 != 1)
            {
                    if(val_19 > 1)
            {
                    0 = 1;
            }
            
                var val_18 = 953851376 + ((0 + 1)) << 2;
                val_18 = val_18 - 131;
                val_18 = val_18 >> 5;
                val_18 = 1 & val_18;
                val_19 = val_19 - val_18;
            }
            
            Add(item:  146378752);
            goto label_18;
            label_2:
            Dispose();
            mem[1152921514150645080] = null;
        }
        public int PathHFlip(int i)
        {
            int val_1 = R5 + i;
            val_1 = val_1 + (~R5);
            val_1 = val_1 - R5;
            return (int)val_1;
        }
        public int PathVFlip(int i)
        {
            var val_1 = ~i;
            val_1 = R6 + val_1;
            return (int)val_1;
        }
        public int PathRot(int i)
        {
            var val_1 = ~i;
            val_1 = R6 + val_1;
            return (int)val_1;
        }
        public void DebugPrintLevel()
        {
            System.Collections.Generic.List<System.String> val_6;
            var val_7;
            var val_8;
            string val_9;
            val_6 = this.answers;
            val_7 = 0;
            string val_1 = PrettyPrint.printJSON(obj:  val_6, types:  false, singleLineOutput:  false);
            string val_2 = 1098586544 + 954291584 + val_6 + 954291680;
            val_8 = "";
            if("" >= 1)
            {
                    do
            {
                string val_3 = 1098586544 + 1269544832;
                val_8 = val_8;
                if(val_8 >= 1)
            {
                    do
            {
                val_9 = mem[35639516];
                if(val_9 <= 0)
            {
                    val_9 = mem[35639516];
            }
            
                val_9 = 35639508 + (val_9 << 1);
                val_9 = val_9 + 16;
                string val_4 = val_9.ToString();
                string val_5 = 1098586544 + val_9 + -295306272(-295306272);
                val_8 = val_8;
                val_6 = 0 + 1;
            }
            while(val_6 < val_8);
            
            }
            
                val_7 = val_7 + 1;
            }
            while(val_7 < val_8);
            
            }
            
            UnityEngine.Debug.LogError(message:  1098586544);
        }
    
    }

}
