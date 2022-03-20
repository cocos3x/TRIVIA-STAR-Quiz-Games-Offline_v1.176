using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPITileData
    {
        // Fields
        public int ImageSetIndex;
        public int SpriteIndex;
        public SLC.MatchyPics.MPITileData.Type type;
        public bool IsRemoved;
        public UnityEngine.Vector2Int location;
        
        // Methods
        public System.Collections.Generic.Dictionary<string, object> Serialize()
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  775644832, value:  13152256);
            Add(key:  775644928, value:  13152256);
            Add(key:  775645024, value:  8945664);
            Add(key:  1350676976, value:  13152256);
            int val_2 = this.location.x;
            int val_3 = this.location.y;
            string val_4 = System.String.Format(format:  -1953079376, arg0:  13152256, arg1:  13152256);
            Add(key:  775649216, value:  -1953079376);
        }
        public void Deserialize(System.Collections.Generic.Dictionary<string, object> obj)
        {
            object val_1 = obj.Item[775644832];
            string val_2 = obj.ToString();
            bool val_4 = System.Int32.TryParse(s:  obj, result: out  this.ImageSetIndex);
            object val_5 = obj.Item[775644928];
            string val_6 = obj.ToString();
            bool val_8 = System.Int32.TryParse(s:  obj, result: out  this.SpriteIndex);
            object val_9 = obj.Item[775645024];
            string val_10 = obj.ToString();
            bool val_12 = System.Boolean.TryParse(value:  obj, result: out  this.IsRemoved);
            System.Type val_13 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(439029760)});
            object val_14 = obj.Item[1350676976];
            string val_15 = obj.ToString();
            object val_16 = System.Enum.Parse(enumType:  439029760, value:  obj);
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.type = ;
            object val_17 = obj.Item[775649216];
            string val_18 = obj.ToString();
            typeof(System.Char[]).__il2cppRuntimeField_10 = 44;
            System.String[] val_19 = obj.Split(separator:  478563824);
            int val_20 = System.Int32.Parse(s:  obj);
            UnityEngine.Vector2Int val_22 = new UnityEngine.Vector2Int(x:  val_20, y:  System.Int32.Parse(s:  val_20));
            this.location = val_22.m_X;
            mem[1152921513972575100] = val_22.m_Y;
        }
        public MPITileData()
        {
            UnityEngine.Vector2Int val_1 = UnityEngine.Vector2Int.zero;
            this.location = new UnityEngine.Vector2Int();
            mem[1152921513972691196] = ???;
        }
    
    }

}
