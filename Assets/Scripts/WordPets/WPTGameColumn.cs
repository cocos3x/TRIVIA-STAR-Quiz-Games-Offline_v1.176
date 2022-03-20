using UnityEngine;

namespace WordPets
{
    public class WPTGameColumn : MonoBehaviour
    {
        // Fields
        private float pixelsPerTile;
        private System.Collections.Generic.List<WordPets.WPTGameTile> <myTiles>k__BackingField;
        private WordPets.ColData <myData>k__BackingField;
        
        // Properties
        public float PixelsPerTile { get; set; }
        public System.Collections.Generic.List<WordPets.WPTGameTile> myTiles { get; set; }
        public int Id { get; }
        public WordPets.ColData myData { get; set; }
        
        // Methods
        public float get_PixelsPerTile()
        {
            return (float)S0;
        }
        public void set_PixelsPerTile(float value)
        {
            this.pixelsPerTile = ;
        }
        public System.Collections.Generic.List<WordPets.WPTGameTile> get_myTiles()
        {
        
        }
        protected void set_myTiles(System.Collections.Generic.List<WordPets.WPTGameTile> value)
        {
            this.<myTiles>k__BackingField = value;
        }
        public int get_Id()
        {
            if((this.<myData>k__BackingField) != 0)
            {
                    return (int)this.<myData>k__BackingField.<Id>k__BackingField;
            }
            
            return (int)this.<myData>k__BackingField.<Id>k__BackingField;
        }
        public WordPets.ColData get_myData()
        {
        
        }
        private void set_myData(WordPets.ColData value)
        {
            this.<myData>k__BackingField = value;
        }
        public void Init(int tileHeight, WordPets.ColData data)
        {
            this.<myData>k__BackingField = data;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.<myTiles>k__BackingField = null;
        }
        public int GetLetterHeight()
        {
            var val_2;
            var val_3;
            if(true < 1)
            {
                    return 0;
            }
            
            if((this.<myTiles>k__BackingField) != 0)
            {
                    val_3 = true;
            }
            else
            {
                    val_3 = 0;
                val_2 = 0;
            }
            
            if(val_2 <= (-1))
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 4294967292;
            var val_3 = (0 + 4294967292) + 16;
            val_3 = val_3 - val_3 ^ 1;
            return (int)val_3;
        }
        public bool HasPet()
        {
            var val_1;
            var val_2;
            if(true < 1)
            {
                    return false;
            }
            
            if((this.<myTiles>k__BackingField) != 0)
            {
                    val_2 = true;
            }
            else
            {
                    val_2 = 0;
                val_1 = 0;
            }
            
            if(val_1 <= (-1))
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 4294967292;
            var val_2 = (0 + 4294967292) + 16;
            val_2 = val_2 ^ 1;
            return (bool)val_2;
        }
        public void AddTile(WordPets.WPTGameTile newTile, bool dontUpdateData = False)
        {
            var val_4;
            this.<myTiles>k__BackingField.Add(item:  newTile);
            if(dontUpdateData == false)
            {
                goto label_2;
            }
            
            val_4 = 0;
            if(newTile != 0)
            {
                goto label_6;
            }
            
            val_4 = 1;
            goto label_6;
            label_2:
            val_4 = 0;
            if(newTile != 0)
            {
                    val_4 = 0;
                this.<myData>k__BackingField.AddTile(letter:  newTile, fromBottom:  false);
            }
            
            label_6:
            UnityEngine.Transform val_1 = newTile.transform;
            float val_4 = 10f;
            val_4 = this.pixelsPerTile * val_4;
            UnityEngine.Vector3 val_2 = new UnityEngine.Vector3(x:  val_4, y:  null, z:  this.pixelsPerTile);
            newTile.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            float val_5 = val_4;
            val_5 = val_5 + (-0.5f);
            newTile.Init(startingHeight:  val_5, myColumn:  this.pixelsPerTile * val_5, initial:  true, moveUp:  true);
        }
        public void AddTileBottom(WordPets.WPTGameTile newTile)
        {
            UnityEngine.Transform val_1 = newTile.transform;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            newTile.localPosition = new UnityEngine.Vector3();
            this.<myTiles>k__BackingField.Insert(index:  0, item:  newTile);
            this.<myData>k__BackingField.AddTile(letter:  newTile, fromBottom:  true);
            newTile.InitBottom(myColumn:  159564832);
            this.RefreshTiles(moveUp:  true);
        }
        public void DestroyPet()
        {
            if(this.HasPet() == false)
            {
                    return;
            }
            
            WordPets.WPTPetTile val_2 = R4.GetPetTile();
            UnityEngine.Object.Destroy(obj:  R4);
            WordPets.WPTPetTile val_3 = R4.GetPetTile();
            R4.RemoveTile(removeTile:  R4);
        }
        public void RemoveTile(WordPets.WPTGameTile removeTile)
        {
            object val_1 = new System.Object();
            typeof(WPTGameColumn.<>c__DisplayClass20_0).__il2cppRuntimeField_8 = removeTile;
            System.Predicate<ZooTile> val_2 = new System.Predicate<ZooTile>(object:  398508032, method:  new IntPtr(159785312));
            int val_3 = this.<myTiles>k__BackingField.FindIndex(match:  8040448);
            this.<myTiles>k__BackingField.RemoveAt(index:  val_3);
            this.<myData>k__BackingField.RemoveTile(rowIndex:  val_3);
        }
        public void RefreshTiles(bool moveUp = False)
        {
            goto label_1;
            label_11:
            if(true <= R6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            UnityEngine.Transform val_1 = 2621443.transform;
            UnityEngine.Vector3 val_2 = localPosition;
            float val_4 = (float)R6 + 0.5f;
            float val_7 = this.pixelsPerTile;
            val_7 = val_4 * val_7;
            if(2621443 != 0)
            {
                    if( <= R6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                float val_5 = val_4 * this.pixelsPerTile;
                2621443.Init(startingHeight:  val_5, myColumn:  val_5, initial:  true, moveUp:  false);
            }
            
            4 = 5;
            label_1:
            if((4 - 4) < 2621443)
            {
                goto label_11;
            }
        
        }
        public System.Collections.Generic.List<WordPets.WPTLetterTile> GetLetterTiles()
        {
            var val_3;
            var val_4;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            int val_2 = this.GetLetterHeight();
            if(val_2 < 1)
            {
                    return;
            }
            
            var val_4 = 0;
            do
            {
                if(val_2 <= val_4)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_3 = val_3 + 0;
                val_3 = mem[(0 + 0) + 16];
                val_3 = (0 + 0) + 16;
                val_4 = 0;
                if(val_3 != 0)
            {
                    if((((0 + 0) + 16 + 100 + (WordPets.WPTLetterTile.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    val_3 = 0;
            }
            
                val_4 = val_3;
            }
            
                Add(item:  0);
                val_4 = val_4 + 1;
            }
            while(val_2 != val_4);
        
        }
        public WordPets.WPTPetTile GetPetTile()
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            bool val_1 = this.HasPet();
            val_2 = 0;
            if(val_1 == false)
            {
                    return;
            }
            
            if((this.<myTiles>k__BackingField) != 0)
            {
                    val_4 = val_1;
            }
            else
            {
                    val_5 = 12;
                val_4 = 0;
                val_3 = 0;
            }
            
            if(val_3 <= (-1))
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 4294967292;
            if(((0 + 4294967292) + 16) == 0)
            {
                    return;
            }
            
            val_5 = mem[(0 + 4294967292) + 16 + 180];
            val_5 = (0 + 4294967292) + 16 + 180;
            if((((0 + 4294967292) + 16 + 100 + (WordPets.WPTPetTile.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    (0 + 4294967292) + 16 = 0;
            }
            
            val_2 = (0 + 4294967292) + 16;
        }
        public WPTGameColumn()
        {
            this.pixelsPerTile = 100f;
        }
    
    }

}
