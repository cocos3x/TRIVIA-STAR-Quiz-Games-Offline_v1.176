using UnityEngine;

namespace SRF
{
    public class Hierarchy
    {
        // Fields
        private static readonly char[] Seperator;
        private static readonly System.Collections.Generic.Dictionary<string, UnityEngine.Transform> Cache;
        
        // Properties
        public UnityEngine.Transform Item { get; }
        
        // Methods
        public UnityEngine.Transform get_Item(string key)
        {
            return SRF.Hierarchy.Get(key:  key);
        }
        public static UnityEngine.Transform Get(string key)
        {
            var val_12;
            string val_13;
            var val_14;
            System.Collections.Generic.Dictionary<System.String, UnityEngine.Transform> val_15;
            var val_16;
            var val_17;
            val_12 = null;
            val_12 = null;
            if((SRF.Hierarchy.Cache.TryGetValue(key:  key, value: out  UnityEngine.Transform val_1 = 375375068)) != true)
            {
                    UnityEngine.GameObject val_3 = UnityEngine.GameObject.Find(name:  key);
                if((UnityEngine.Object.op_Implicit(exists:  key)) != false)
            {
                    UnityEngine.Transform val_5 = key.transform;
                val_13 = key;
                val_14 = null;
                val_14 = null;
                val_13 = val_13;
                val_15 = SRF.Hierarchy.Cache;
                val_15.Add(key:  key, value:  val_13);
            }
            else
            {
                    val_16 = null;
                val_16 = null;
                System.String[] val_6 = key.Split(separator:  SRF.Hierarchy.Seperator, options:  1);
                object val_7 = System.Linq.Enumerable.Last<System.Object>(source:  key);
                UnityEngine.Transform val_9 = transform;
                val_15 = new UnityEngine.GameObject(name:  key);
                SRF.Hierarchy.Cache.Add(key:  key, value:  157720576);
                val_17 = val_15;
                if(key.m_firstChar == '')
            {
                    return;
            }
            
                string val_11 = System.String.Join(separator:  1115175264, value:  key, startIndex:  0, count:  key.m_firstChar - 1);
                parent = 1115175264;
            }
            
            }
            
            val_17 = val_15;
        }
        public Hierarchy()
        {
        
        }
        private static Hierarchy()
        {
            typeof(System.Char[]).__il2cppRuntimeField_10 = 47;
            SRF.Hierarchy.Seperator = null;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            SRF.Hierarchy.Cache = null;
        }
    
    }

}
