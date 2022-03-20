using UnityEngine;

namespace SLC.Minigames.WordFill
{
    public class WFLShape
    {
        // Fields
        public char[,] grid;
        public int width;
        public int height;
        
        // Methods
        public virtual void HFlip()
        {
            int val_3;
            SLC.Minigames.WordFill.WFLShape val_4;
            val_3 = this.height;
            if(val_3 < 1)
            {
                    return;
            }
            
            val_4 = this;
            var val_8 = 0;
            do
            {
                if(this.width >= 2)
            {
                    var val_7 = 0;
                var val_6 = 0;
                do
            {
                char val_3 = this.grid[this.width];
                int val_1 = val_6 + this.width;
                this.grid[val_3] = this.grid[0];
                val_4 = val_4;
                int val_5 = this.width;
                val_5 = val_6 + val_5;
                val_6 = val_6 - 1;
                val_7 = val_7 + 1;
                this.grid[this.grid[val_3]] = val_3;
            }
            while(val_7 < ((this.width + (this.width >> 31)) >> 1));
            
                val_3 = val_3;
            }
            
                val_8 = val_8 + 1;
            }
            while(val_8 < val_3);
        
        }
        public virtual void VFlip()
        {
            int val_4;
            var val_5;
            val_4 = this.width;
            if(val_4 < 1)
            {
                    return;
            }
            
            val_5 = 0;
            do
            {
                if(this.height >= 2)
            {
                    var val_7 = 0;
                do
            {
                char val_4 = this.grid[this.height];
                int val_1 = 0 + this.height;
                var val_8 = 0;
                int val_5 = this.height;
                val_5 = val_8 + val_5;
                this.grid[val_4] = this.grid[val_5];
                int val_2 = val_8 + this.height;
                val_7 = val_7 + 1;
                val_5 = val_5;
                this.grid[val_4] = val_8 + this.grid[val_4];
                val_8 = val_8 - 1;
                this.grid[this.grid[val_4]] = val_4;
            }
            while(val_7 < ((this.height + (this.height >> 31)) >> 1));
            
                val_4 = this.width;
            }
            
                val_5 = val_5 + 1;
            }
            while(val_5 < val_4);
        
        }
        public virtual void Rot()
        {
            var val_1;
            int val_2;
            int val_3;
            System.Char[,] val_4;
            var val_5;
            var val_6;
            val_1 = null;
            val_2 = this.height;
            if(val_2 > 0)
            {
                    val_3 = this.width;
                val_4 = this.grid;
                val_5 = 0;
                do
            {
                if(val_3 >= 1)
            {
                    var val_3 = 0;
                do
            {
                val_6 = mem[mem[this.grid] + 8];
                val_6 = mem[this.grid] + 8;
                if(val_6 <= val_3)
            {
                    val_6 = mem[mem[this.grid] + 8];
                val_6 = mem[this.grid] + 8;
            }
            
                val_6 = mem[this.grid] + (val_6 << 1);
                var val_1 = val_5;
                val_1 = val_2 + val_1;
                var val_2 = 0;
                val_4 = val_4;
                val_2 = val_2 + val_2;
                val_3 = val_3 + 1;
                val_2 = val_1 + (val_2 << 1);
                val_5 = val_5;
                mem2[0] = (mem[this.grid] + (mem[this.grid] + 8) << 1) + 16;
                val_3 = this.width;
                val_2 = this.height;
            }
            while(val_3 < val_3);
            
            }
            
                var val_4 = 0;
                val_5 = val_5 + 1;
                val_4 = val_4 - 1;
            }
            while(val_5 < val_2);
            
                val_1 = val_1;
            }
            else
            {
                    val_3 = this.width;
                val_4 = this.grid;
            }
            
            this.width = val_2;
            this.height = val_3;
            mem2[0] = val_1;
        }
        public void DebugPrint()
        {
            var val_5;
            var val_6;
            val_5 = 0;
            string val_1 = 1098586544 + 952744112;
            val_6 = "";
            if(this.height >= 1)
            {
                    do
            {
                string val_2 = 1098586544 + 1269544832;
                val_6 = val_6;
                if(this.width >= 1)
            {
                    var val_6 = 0;
                do
            {
                string val_3 = this.grid[this.width][16].ToString();
                string val_4 = 1098586544 + this.grid[this.width][16] + -295306272(-295306272);
                val_6 = val_6;
                val_6 = val_6 + 1;
            }
            while(val_6 < this.width);
            
            }
            
                val_5 = val_5 + 1;
            }
            while(val_5 < this.height);
            
            }
            
            UnityEngine.Debug.LogError(message:  1098586544);
        }
        public WFLShape()
        {
        
        }
    
    }

}
