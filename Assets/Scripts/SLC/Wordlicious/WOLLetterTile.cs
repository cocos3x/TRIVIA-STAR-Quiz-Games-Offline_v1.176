using UnityEngine;

namespace SLC.Wordlicious
{
    public class WOLLetterTile : LetterTile
    {
        // Fields
        private const string STATUS_KEY = "status";
        private const string TILE_KEY = "tile";
        private SLC.Wordlicious.Tile <tile>k__BackingField;
        private SLC.Wordlicious.WOLLetterTile.Status <status>k__BackingField;
        private UnityEngine.UI.Image background;
        private UnityEngine.Color hintColor;
        private UnityEngine.GameObject grid;
        private System.Collections.Generic.List<UnityEngine.GameObject> counterObjects;
        
        // Properties
        public SLC.Wordlicious.Tile tile { get; set; }
        public SLC.Wordlicious.WOLLetterTile.Status status { get; set; }
        
        // Methods
        public SLC.Wordlicious.Tile get_tile()
        {
        
        }
        public void set_tile(SLC.Wordlicious.Tile value)
        {
            this.<tile>k__BackingField = value;
        }
        public SLC.Wordlicious.WOLLetterTile.Status get_status()
        {
        
        }
        private void set_status(SLC.Wordlicious.WOLLetterTile.Status value)
        {
            this.<status>k__BackingField = value;
        }
        private void Awake()
        {
            this.<status>k__BackingField = 0;
        }
        protected override void Start()
        {
            UnityEngine.GameObject val_7;
            this.Start();
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.counterObjects = null;
            UnityEngine.Transform val_2 = this.grid.transform;
            val_7 = this.grid;
            var val_7 = 0;
            int val_3 = val_7.childCount;
            if(val_3 >= 1)
            {
                    do
            {
                UnityEngine.Transform val_4 = this.grid.transform;
                UnityEngine.Transform val_5 = this.grid.GetChild(index:  0);
                UnityEngine.GameObject val_6 = this.grid.gameObject;
                val_7 = this.grid;
                this.counterObjects.Add(item:  val_7);
                val_7 = val_7 + 1;
            }
            while(val_3 != val_7);
            
            }
            
            this.SetStatus(status:  this.<status>k__BackingField);
        }
        public void SetStatus(SLC.Wordlicious.WOLLetterTile.Status status)
        {
            UnityEngine.UI.Image val_3;
            this.<status>k__BackingField = status;
            if(status == 0)
            {
                goto label_0;
            }
            
            if(status == 1)
            {
                goto label_1;
            }
            
            if(status != 2)
            {
                    return;
            }
            
            val_3 = this.background;
            return;
            label_0:
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.background.color = new UnityEngine.Color() {a = ???};
            UnityEngine.Color val_2 = UnityEngine.Color.white;
            if(this != 0)
            {
                    return;
            }
            
            return;
            label_1:
        }
        public void UpdateTile()
        {
            var val_1;
            if((R6 != 0) && (R6 <= true))
            {
                    if((this.<tile>k__BackingField.removedRepeated) == false)
            {
                goto label_7;
            }
            
            }
            
            this.grid.SetActive(value:  false);
            return;
            label_7:
            val_1 = 0;
            this.grid.SetActive(value:  true);
            goto label_10;
            label_15:
            if(this.grid <= val_1)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            if(val_1 < R6)
            {
                    0 = 1;
            }
            
            (0 + 0) + 16.SetActive(value:  true);
            val_1 = 1;
            label_10:
            if(val_1 < ((0 + 0) + 16))
            {
                goto label_15;
            }
        
        }
        public string Serialize()
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            Add(key:  1658601040, value:  435302400);
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = this.<tile>k__BackingField.Serialize();
            Add(key:  705742192, value:  this.<tile>k__BackingField);
            string val_3 = MiniJSON.Json.Serialize(obj:  78753792);
        }
        public void Deserialize(string savedInfo)
        {
            bool val_8;
            var val_9;
            object val_1 = MiniJSON.Json.Deserialize(json:  savedInfo);
            val_8 = "status";
            if((0.ContainsKey(key:  1658601040)) != false)
            {
                    System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(435302400)});
                string val_4 = 0.Item[1658601040];
                object val_5 = System.Enum.Parse(enumType:  435302400, value:  null);
                val_8 = null;
                UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
                this.<status>k__BackingField = ;
            }
            
            if((0.ContainsKey(key:  705742192)) == false)
            {
                    return;
            }
            
            string val_7 = 0.Item[705742192];
            val_9 = 0;
            if(0 != 0)
            {
                    val_8 = mem[1179403827];
                if(((mem[1179403747] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    0 = 0;
            }
            
                val_9 = 0;
            }
            
            this.<tile>k__BackingField.Deserialize(info:  0);
        }
        public override void SetHighlight(bool state)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            UnityEngine.Color val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            mem[1152921513902800536] = state;
            if((this.<status>k__BackingField) == 0)
            {
                goto label_0;
            }
            
            if((this.<status>k__BackingField) != 1)
            {
                goto label_1;
            }
            
            if(state == false)
            {
                goto label_2;
            }
            
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            val_7 = val_2;
            val_8 = val_3;
            val_9 = val_4;
            val_10 = val_5;
            goto label_3;
            label_0:
            if(state == true)
            {
                    0f = 1f;
            }
            
            val_11 = mem[R4];
            val_11 = R4;
            return;
            label_1:
            val_11 = mem[R4];
            val_11 = R4;
            return;
            label_2:
            val_7 = this.hintColor;
            label_3:
        }
        public WOLLetterTile()
        {
        
        }
    
    }

}
