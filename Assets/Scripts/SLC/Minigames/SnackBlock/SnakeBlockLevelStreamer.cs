using UnityEngine;

namespace SLC.Minigames.SnackBlock
{
    public class SnakeBlockLevelStreamer : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject blockerObject;
        private UnityEngine.GameObject blockerObject2;
        private UnityEngine.GameObject correctWord;
        private UnityEngine.GameObject correctWordFtux;
        private UnityEngine.GameObject incorrectWord;
        private UnityEngine.GameObject incorrectWordFtux;
        private UnityEngine.GameObject foodObject;
        private UnityEngine.GameObject finishLinePart;
        private UnityEngine.GameObject ftuxMessageBlank;
        private float spriteWidth;
        private int lastRowSpawned;
        private System.Collections.Generic.Queue<UnityEngine.GameObject> sectionHolders;
        
        // Properties
        public UnityEngine.GameObject getSnakeLevel { get; }
        
        // Methods
        public UnityEngine.GameObject get_getSnakeLevel()
        {
            if(this.sectionHolders != 0)
            {
                    return this.sectionHolders.Peek();
            }
            
            return this.sectionHolders.Peek();
        }
        public void Spawnlevel()
        {
            System.Collections.Generic.Queue<UnityEngine.GameObject> val_22;
            var val_23;
            SLC.Minigames.SnackBlock.SnakeBlockLevelStreamer val_24;
            float val_25;
            this.lastRowSpawned = 0;
            val_22 = this.sectionHolders;
            if(val_22 == 0)
            {
                goto label_1;
            }
            
            goto label_2;
            label_7:
            UnityEngine.GameObject val_1 = val_22.Dequeue();
            UnityEngine.Object.Destroy(obj:  val_22);
            val_22 = val_22;
            label_2:
            if(this > 0)
            {
                goto label_7;
            }
            
            label_1:
            string val_2 = 0.ToString();
            string val_3 = 1027163024 + null;
            UnityEngine.GameObject val_4 = new UnityEngine.GameObject(name:  1027163024);
            UnityEngine.Transform val_5 = transform;
            UnityEngine.Transform val_6 = this.transform;
            val_23 = this;
            val_24 = 0;
            SetParent(p:  1027187216);
            val_22.Enqueue(item:  157720576);
            val_25 = 1152921504901095424;
            twelvegigs.Autopilot.AutopilotManager val_21 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        }
        public void SpawnNextSections()
        {
            System.Collections.IEnumerator val_1 = this.SpawnNext();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  1027303312);
        }
        private System.Collections.IEnumerator SpawnNext()
        {
            object val_1 = new System.Object();
            typeof(SnakeBlockLevelStreamer.<SpawnNext>d__16).__il2cppRuntimeField_8 = 0;
            typeof(SnakeBlockLevelStreamer.<SpawnNext>d__16).__il2cppRuntimeField_10 = this;
        }
        private UnityEngine.GameObject SpawnThing(SLC.Minigames.SnackBlock.SnakeGridSpaceType type, float x, int y)
        {
            float val_9;
            float val_10;
            float val_11;
            float val_12;
            var val_15;
            UnityEngine.Transform val_16;
            float val_17;
            UnityEngine.GameObject val_18;
            UnityEngine.Object val_19;
            float val_20;
            var val_21;
            val_15 = R3;
            val_16 = y;
            SLC.Minigames.SnackBlock.SnakeGridSpaceType val_1 = type - 1;
            if(val_1 > 7)
            {
                goto label_1;
            }
            
            var val_2 = 12406688 + (12406688 + ((type - 1)) << 2);
            if(val_1 == 7)
            {
                    12406688 + ((type - 1)) << 2 = (12406688 + ((type - 1)) << 2) & ((12406688 + ((type - 1)) << 2) >> 32);
                12406688 + ((type - 1)) << 2 = (12406688 + ((type - 1)) << 2) & ((12406688 + ((type - 1)) << 2) >> (12406688 + ((type - 1)) << 2));
                12406688 + ((type - 1)) << 2 = (12406688 + ((type - 1)) << 2) & (val_16 >> (12406688 + ((type - 1)) << 2));
                12406688 + ((type - 1)) << 2 = (12406688 + ((type - 1)) << 2) & ((((((12406688 + ((type - 1)) << 2 & (12406688 + ((type - 1)) << 2) >> 32) & ((int)(12406688 + ((type - 1)) << 2 & (12406688 + ((type - 1)) << 2) >> 32)) >> (12406688 + ((type - 1)) << 2 & (12406688 + (() << (32-as. 
                
            
            
            
            
            
               
            )) | (((((12406688 + ((type - 1)) << 2 & (12406688 + ((type - 1)) << 2) >> 32) & ((int)(12406688 + ((type - 1)) << 2 & (12406688 + ((type - 1)) << 2) >> 32)) >> (12406688 + ((type - 1)) << 2 & (12406688 + (() << as. 
                
            
            
            
            
            
               
            ));
                12406688 + ((type - 1)) << 2 = (12406688 + ((type - 1)) << 2) & (((y) << (32-as. 
                
            
            
            
            
            
               
            )) | ((y) << as. 
                
            
            
            
            
            
               
            ));
                12406688 + ((type - 1)) << 2 = (12406688 + ((type - 1)) << 2) & ((((((((12406688 + ((type - 1)) << 2 & (12406688 + ((type - 1)) << 2) >> 32) & ((int)(12406688 + ((type - 1)) << 2 & (12406688 + ((type - 1)) << 2) >> 32)) >> (12406688 + ((type - 1)) << 2 & (12406688 + ) << (32-(((((12406688 + ((type - 1)) << 2 & (12406688 + ((type - 1)) << 2) >> 32) & ((int)(12406688 + ((type - 1)) << 2 & (12406688 + ((type - 1)) << 2) >> 32)) >> (12406688 + ((type - 1)) << 2 & (12406688 + )) | (((((((12406688 + ((type - 1)) << 2 & (12406688 + ((type - 1)) << 2) >> 32) & ((int)(12406688 + ((type - 1)) << 2 & (12406688 + ((type - 1)) << 2) >> 32)) >> (12406688 + ((type - 1)) << 2 & (12406688 + ) << (((((12406688 + ((type - 1)) << 2 & (12406688 + ((type - 1)) << 2) >> 32) & ((int)(12406688 + ((type - 1)) << 2 & (12406688 + ((type - 1)) << 2) >> 32)) >> (12406688 + ((type - 1)) << 2 & (12406688 + ));
                12406688 + ((type - 1)) << 2 = (12406688 + ((type - 1)) << 2) & (((y) << (32-((((((12406688 + ((type - 1)) << 2 & (12406688 + ((type - 1)) << 2) >> 32) & ((int)(12406688 + ((type - 1)) << 2 & (12406688 + ((type - 1)) << 2) >> 32)) >> (12406688 + ((type - 1)) << 2 & (12406688 +)) | ((y) << ((((((12406688 + ((type - 1)) << 2 & (12406688 + ((type - 1)) << 2) >> 32) & ((int)(12406688 + ((type - 1)) << 2 & (12406688 + ((type - 1)) << 2) >> 32)) >> (12406688 + ((type - 1)) << 2 & (12406688 +));
                12406688 + ((type - 1)) << 2 = (12406688 + ((type - 1)) << 2) & (this >> y);
            }
            
            val_17 = 0;
            int val_3 = UnityEngine.Random.Range(min:  0, max:  2);
            if(val_3 == 0)
            {
                    val_3 = this.blockerObject;
            }
            
            if(val_3 != 0)
            {
                    val_18 = this.blockerObject2;
            }
            
            goto label_22;
            label_1:
            val_17 = 0;
            val_19 = 0;
            goto label_3;
            label_22:
            val_19 = mem[this.incorrectWordFtux];
            label_3:
            val_20 = 1152921504765685760;
            val_21 = 0;
            if(val_19 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_5 = new UnityEngine.Vector3(x:  (float)val_15, y:  null, z:  null);
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.identity;
            UnityEngine.GameObject val_7 = this.sectionHolders.Peek();
            val_15 = ;
            UnityEngine.Transform val_8 = this.sectionHolders.transform;
            val_16 = this.sectionHolders;
            val_20 = val_10;
            val_17 = val_12;
            UnityEngine.GameObject val_13 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_19, position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, rotation:  new UnityEngine.Quaternion() {x = val_9, y = val_20, z = val_11, w = val_17}, parent:  val_16);
            val_21 = val_19;
            if(val_15 == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static SLC.Minigames.SnackBlock.SnakeBlockManager MonoSingleton<SLC.Minigames.SnackBlock.SnakeBlockManager>::get_Instance().__il2cppRuntimeField_44 = val_21;
        }
        public SnakeBlockLevelStreamer()
        {
            this.spriteWidth = 1.5f;
            System.Collections.Generic.Queue<twelvegigs.net.JsonRequest> val_1 = new System.Collections.Generic.Queue<twelvegigs.net.JsonRequest>();
            this.sectionHolders = null;
        }
    
    }

}
