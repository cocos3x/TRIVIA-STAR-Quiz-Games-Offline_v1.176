using UnityEngine;

namespace SLC.Wordlicious
{
    public class WOLNode
    {
        // Fields
        public SLC.Wordlicious.Tile tile;
        public SLC.Wordlicious.WOLNode parent;
        public bool isValidWord;
        public System.Collections.Generic.List<SLC.Wordlicious.WOLNode> children;
        
        // Methods
        public WOLNode(SLC.Wordlicious.Tile tile, SLC.Wordlicious.WOLNode parent)
        {
            val_1 = new System.Object();
            this.tile = tile;
            this.parent = val_1;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.children = null;
        }
        public bool IsSameTile(SLC.Wordlicious.WOLNode node)
        {
            int val_1;
            var val_2;
            val_1 = this.tile.x;
            val_2 = 0;
            if(val_1 != node.tile.x)
            {
                    return (bool)val_2;
            }
            
            val_1 = node.tile;
            int val_1 = node.tile.y;
            val_1 = this.tile.y - val_1;
            val_2 = val_1 >> 5;
            return (bool)val_2;
        }
        public string GetStringPath()
        {
            if(this.parent != 0)
            {
                    string val_1 = this.tile.letter.ToString();
                return this.parent + this.tile.letter;
            }
            
            if(this.tile != 0)
            {
                    return this.tile.letter.ToString();
            }
            
            return this.tile.letter.ToString();
        }
        public System.Collections.Generic.List<SLC.Wordlicious.Tile> GetTilesPath()
        {
            if(this.parent == 0)
            {
                goto label_1;
            }
            
            if(this.parent != 0)
            {
                goto label_4;
            }
            
            label_5:
            label_4:
            this.parent.Add(item:  this.tile);
            return;
            label_1:
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            if(null != 0)
            {
                goto label_4;
            }
            
            goto label_5;
        }
    
    }

}
