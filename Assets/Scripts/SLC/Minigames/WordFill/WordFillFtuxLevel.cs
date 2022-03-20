using UnityEngine;

namespace SLC.Minigames.WordFill
{
    public class WordFillFtuxLevel : WordFillLevel
    {
        // Methods
        public WordFillFtuxLevel(int lev)
        {
            if(lev != 1)
            {
                    if(lev != 0)
            {
                    return;
            }
            
                R4.CreateFtuxLevel0();
                return;
            }
            
            this.CreateFtuxLevel1();
        }
        private void CreateFtuxLevel0()
        {
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            val_16 = mem[35639511];
            if(val_16 == 0)
            {
                    val_16 = mem[35639511];
            }
            
            val_17 = mem[35639511];
            if(val_17 <= 1)
            {
                    val_17 = mem[35639511];
            }
            
            var val_1 = 35639503 + ((mem[35639511] + 8) << 1);
            mem2[0] = 82;
            val_18 = mem[35639511];
            if(val_18 <= 2)
            {
                    val_18 = mem[35639511];
            }
            
            var val_2 = 35639503 + ((mem[35639511] + 8) << 2);
            mem2[0] = 84;
            val_19 = mem[35639511];
            if(val_19 == 0)
            {
                    val_19 = mem[35639511];
            }
            
            val_20 = mem[35639511];
            if(val_20 <= 1)
            {
                    val_20 = mem[35639511];
            }
            
            var val_3 = 35639503 + ((mem[35639511] + 8) << 1);
            mem2[0] = 78;
            val_21 = mem[35639511];
            if(val_21 <= 2)
            {
                    val_21 = mem[35639511];
            }
            
            var val_16 = 2;
            val_16 = val_16 | ((mem[35639511] + 8) << 2);
            val_16 = 35639503 + val_16;
            mem2[0] = 65;
            static_value_021FD0CF.Add(item:  -1729501776);
            static_value_021FD0CF.Add(item:  -1729501696);
            if((new System.Collections.Generic.HashSet<System.Int32>()) != 0)
            {
                    bool val_5 = Add(item:  1);
                bool val_6 = Add(item:  0);
            }
            else
            {
                    bool val_7 = Add(item:  1);
                bool val_8 = Add(item:  0);
            }
            
            bool val_9 = Add(item:  3);
            Add(item:  146378752);
            if((new System.Collections.Generic.HashSet<System.Int32>()) != 0)
            {
                    bool val_11 = Add(item:  2);
                bool val_12 = Add(item:  5);
            }
            else
            {
                    bool val_13 = Add(item:  2);
                bool val_14 = Add(item:  5);
            }
            
            bool val_15 = Add(item:  4);
            this.Add(item:  146378752);
        }
        private void CreateFtuxLevel1()
        {
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            val_16 = mem[35639512];
            if(val_16 == 0)
            {
                    val_16 = mem[35639512];
            }
            
            val_17 = mem[35639512];
            if(val_17 <= 1)
            {
                    val_17 = mem[35639512];
            }
            
            var val_1 = 35639504 + ((mem[35639512] + 8) << 1);
            mem2[0] = 72;
            val_18 = mem[35639512];
            if(val_18 <= 2)
            {
                    val_18 = mem[35639512];
            }
            
            var val_2 = 35639504 + ((mem[35639512] + 8) << 2);
            mem2[0] = 69;
            val_19 = mem[35639512];
            if(val_19 == 0)
            {
                    val_19 = mem[35639512];
            }
            
            val_20 = mem[35639512];
            if(val_20 <= 1)
            {
                    val_20 = mem[35639512];
            }
            
            var val_3 = 35639504 + ((mem[35639512] + 8) << 1);
            mem2[0] = 79;
            val_21 = mem[35639512];
            if(val_21 <= 2)
            {
                    val_21 = mem[35639512];
            }
            
            var val_16 = 2;
            val_16 = val_16 | ((mem[35639512] + 8) << 2);
            val_16 = 35639504 + val_16;
            mem2[0] = 78;
            static_value_021FD0D0.Add(item:  955067200);
            static_value_021FD0D0.Add(item:  955067280);
            if((new System.Collections.Generic.HashSet<System.Int32>()) != 0)
            {
                    bool val_5 = Add(item:  4);
                bool val_6 = Add(item:  3);
            }
            else
            {
                    bool val_7 = Add(item:  4);
                bool val_8 = Add(item:  3);
            }
            
            bool val_9 = Add(item:  0);
            Add(item:  146378752);
            if((new System.Collections.Generic.HashSet<System.Int32>()) != 0)
            {
                    bool val_11 = Add(item:  1);
                bool val_12 = Add(item:  2);
            }
            else
            {
                    bool val_13 = Add(item:  1);
                bool val_14 = Add(item:  2);
            }
            
            bool val_15 = Add(item:  5);
            this.Add(item:  146378752);
        }
    
    }

}
