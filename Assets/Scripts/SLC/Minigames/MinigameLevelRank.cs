using UnityEngine;

namespace SLC.Minigames
{
    [Serializable]
    public class MinigameLevelRank
    {
        // Fields
        public static System.Collections.Generic.Dictionary<string, UnityEngine.Color32> RankColors;
        public static System.Collections.Generic.Dictionary<string, UnityEngine.Color32> TitleColors;
        public int rankLevel;
        public decimal percentPlayersComplete;
        public string rankName;
        public System.Collections.Generic.List<int> rankCheckpoints;
        
        // Properties
        public UnityEngine.Color Color { get; }
        public UnityEngine.Color TitleColor { get; }
        public int NumCheckpoints { get; }
        
        // Methods
        public static string RankIndexToName(int index)
        {
            var val_2;
            var val_3;
            val_2 = 0;
            if(index <= 5)
            {
                    var val_1 = 12338464 + (12338464 + (index) << 2);
                if(index == 5)
            {
                    12338464 = 12338464 & ((R8) << 12338464);
                12338464 = 12338464 & (index >> 12338464);
                12338464 = 12338464 & (index >> 32);
                12338464 = 12338464 & (index >> 12338464);
                12338464 = 12338464 & (((index) << (32-as. 
                
            
            
            
            
            
               
            )) | ((index) << as. 
                
            
            
            
            
            
               
            ));
                12338464 = 12338464 & (((index) << (32-(((((12338464 & (R8) << 12338464) & (index) >> (12338464 & (R8) << 12338464)) & ((int)index) >> 32) & ((int)index) >> (((12338464 & (R8) << 12338464) & (index) >> (12338464 & (R8) << 12338464)) & ((in)) | ((index) << (((((12338464 & (R8) << 12338464) & (index) >> (12338464 & (R8) << 12338464)) & ((int)index) >> 32) & ((int)index) >> (((12338464 & (R8) << 12338464) & (index) >> (12338464 & (R8) << 12338464)) & ((in));
            }
            
                val_2 = 0;
                val_3 = 1152921505053384704;
            }
            else
            {
                    val_3 = 1152921505053384704;
            }
            
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        }
        public MinigameLevelRank(int level, decimal percentage, string name, System.Collections.Generic.List<object> checkpoints)
        {
            string val_5;
            this.rankName = "None";
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            if(null != 0)
            {
                    Add(item:  5);
                Add(item:  15);
                Add(item:  25);
                Add(item:  35);
                Add(item:  50);
                Add(item:  75);
            }
            else
            {
                    Add(item:  5);
                Add(item:  15);
                Add(item:  25);
                Add(item:  35);
                Add(item:  50);
                Add(item:  75);
            }
            
            Add(item:  100);
            this.rankCheckpoints = null;
            this.rankLevel = level;
            this.percentPlayersComplete = percentage;
            mem[1152921514093904096] = percentage.hi;
            mem[1152921514093904100] = percentage.lo;
            mem[1152921514093904104] = percentage.mid;
            this.rankName = name;
            System.Collections.Generic.List<System.Int32> val_2 = new System.Collections.Generic.List<System.Int32>();
            this.rankCheckpoints = null;
            List.Enumerator<T> val_3 = GetEnumerator();
            label_7:
            if(MoveNext() == false)
            {
                goto label_4;
            }
            
            this.rankCheckpoints.Add(item:  System.Int32.Parse(s:  val_5));
            goto label_7;
            label_4:
            Dispose();
        }
        public UnityEngine.Color get_Color()
        {
            null = null;
            UnityEngine.Color32 val_1 = SLC.Minigames.MinigameLevelRank.RankColors.Item[R1 + 28];
            UnityEngine.Color val_2 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 80, g = 230, b = 122, a = 53});
            return new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        }
        public UnityEngine.Color get_TitleColor()
        {
            null = null;
            UnityEngine.Color32 val_1 = SLC.Minigames.MinigameLevelRank.TitleColors.Item[R1 + 28];
            UnityEngine.Color val_2 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 208, g = 155, b = 124, a = 53});
            return new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        }
        public int get_NumCheckpoints()
        {
            if(this.rankCheckpoints != 0)
            {
                    return (int)true;
            }
            
            return (int)true;
        }
        private static MinigameLevelRank()
        {
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            UnityEngine.Color32 val_2 = new UnityEngine.Color32(r:  98, g:  98, b:  98, a:  255);
            Add(key:  446537728, value:  new UnityEngine.Color32() {r = val_2.r, g = val_2.r, b = val_2.r, a = val_2.r});
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            UnityEngine.Color32 val_3 = new UnityEngine.Color32(r:  189, g:  156, b:  19, a:  255);
            Add(key:  446537728, value:  new UnityEngine.Color32() {r = val_3.r, g = val_3.r, b = val_3.r, a = val_3.r});
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            UnityEngine.Color32 val_4 = new UnityEngine.Color32(r:  128, g:  97, b:  183, a:  255);
            Add(key:  446537728, value:  new UnityEngine.Color32() {r = val_4.r, g = val_4.r, b = val_4.r, a = val_4.r});
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            UnityEngine.Color32 val_5 = new UnityEngine.Color32(r:  225, g:  22, b:  60, a:  255);
            Add(key:  446537728, value:  new UnityEngine.Color32() {r = val_5.r, g = val_5.r, b = val_5.r, a = val_5.r});
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            UnityEngine.Color32 val_6 = new UnityEngine.Color32(r:  98, g:  180, b:  243, a:  255);
            Add(key:  446537728, value:  new UnityEngine.Color32() {r = val_6.r, g = val_6.r, b = val_6.r, a = val_6.r});
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            UnityEngine.Color32 val_7 = new UnityEngine.Color32(r:  255, g:  175, b:  38, a:  255);
            Add(key:  446537728, value:  new UnityEngine.Color32() {r = val_7.r, g = val_7.r, b = val_7.r, a = val_7.r});
            SLC.Minigames.MinigameLevelRank.RankColors = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Color32>();
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            UnityEngine.Color32 val_9 = new UnityEngine.Color32(r:  0, g:  0, b:  0, a:  0);
            Add(key:  446537728, value:  new UnityEngine.Color32() {r = val_9.r, g = val_9.r, b = val_9.r, a = val_9.r});
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            UnityEngine.Color32 val_10 = new UnityEngine.Color32(r:  252, g:  219, b:  69, a:  255);
            Add(key:  446537728, value:  new UnityEngine.Color32() {r = val_10.r, g = val_10.r, b = val_10.r, a = val_10.r});
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            UnityEngine.Color32 val_11 = new UnityEngine.Color32(r:  180, g:  145, b:  227, a:  255);
            Add(key:  446537728, value:  new UnityEngine.Color32() {r = val_11.r, g = val_11.r, b = val_11.r, a = val_11.r});
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            UnityEngine.Color32 val_12 = new UnityEngine.Color32(r:  255, g:  26, b:  69, a:  255);
            Add(key:  446537728, value:  new UnityEngine.Color32() {r = val_12.r, g = val_12.r, b = val_12.r, a = val_12.r});
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            UnityEngine.Color32 val_13 = new UnityEngine.Color32(r:  163, g:  210, b:  253, a:  255);
            Add(key:  446537728, value:  new UnityEngine.Color32() {r = val_13.r, g = val_13.r, b = val_13.r, a = val_13.r});
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            UnityEngine.Color32 val_14 = new UnityEngine.Color32(r:  255, g:  175, b:  38, a:  255);
            Add(key:  446537728, value:  new UnityEngine.Color32() {r = val_14.r, g = val_14.r, b = val_14.r, a = val_14.r});
            SLC.Minigames.MinigameLevelRank.TitleColors = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Color32>();
        }
    
    }

}
