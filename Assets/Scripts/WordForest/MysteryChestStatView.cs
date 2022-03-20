using UnityEngine;

namespace WordForest
{
    public class MysteryChestStatView : MonoBehaviour
    {
        // Fields
        private static WordForest.MysteryChestStatView <Instance>k__BackingField;
        private UnityEngine.GameObject parent;
        private UnityEngine.UI.Image[] chestIcons;
        private bool autoUpdate;
        
        // Properties
        public static WordForest.MysteryChestStatView Instance { get; set; }
        public bool SetAutoUpdate { set; }
        
        // Methods
        public static WordForest.MysteryChestStatView get_Instance()
        {
        
        }
        private static void set_Instance(WordForest.MysteryChestStatView value)
        {
            WordForest.MysteryChestStatView.<Instance>k__BackingField = value;
        }
        public void set_SetAutoUpdate(bool value)
        {
            this.autoUpdate = value;
        }
        private void Awake()
        {
            var val_2 = 25192537;
            val_2 = 10441852 + val_2;
            if(val_2 == 0)
            {
                    mem2[0] = 1;
            }
            
            WordForest.MysteryChestStatView.<Instance>k__BackingField = this;
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  280860864, name:  277172384);
        }
        private void Start()
        {
            this.UpdateMysteryChestStatView();
        }
        public void UpdateMysteryChestStatView()
        {
            float val_10;
            float val_11;
            float val_12;
            float val_13;
            WordForest.MysteryChestStatView val_18;
            var val_19;
            var val_20;
            float val_21;
            val_18 = this;
            if(this.autoUpdate == false)
            {
                    return;
            }
            
            if(WordForest.WFOMysteryChestManager.IsFeatureUnlocked == false)
            {
                goto label_2;
            }
            
            val_19 = 1152921504901095424;
            val_20 = 1152921512382810544;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_21 = 1152921504765685760;
            if((-813971024) == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_6 = UnityEngine.Object.op_Equality(x:  -814084048, y:  0);
            if(val_6 == true)
            {
                    return;
            }
            
            val_19 = 4;
            goto label_17;
            label_31:
            if(SB < val_6.GetCollectedChestCount())
            {
                    UnityEngine.Color val_8 = UnityEngine.Color.white;
            }
            else
            {
                    UnityEngine.Color val_9 = UnityEngine.Color.gray;
            }
            
            val_21 = val_10;
            this.chestIcons[0].color = new UnityEngine.Color() {r = val_21, g = val_11, b = val_12, a = val_13};
            val_18 = val_18;
            UnityEngine.UI.Image val_20 = this.chestIcons[0];
            UnityEngine.GameObject val_14 = val_20.gameObject;
            val_20 = val_20;
            twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(GetChestCount > SB)
            {
                    0 = 1;
            }
            
            val_20.SetActive(value:  true);
            val_19 = val_19 + 1;
            label_17:
            if((val_19 - 4) < val_20)
            {
                goto label_31;
            }
            
            mem[1152921513477915596].SetActive(value:  true);
            return;
            label_2:
            this.parent.SetActive(value:  WordForest.WFOMysteryChestManager.IsFeatureUnlocked);
        }
        public void SetBalanceNow(int collected, int total)
        {
            float val_3;
            float val_4;
            float val_5;
            float val_6;
            WordForest.MysteryChestStatView val_8;
            var val_9;
            val_8 = this;
            val_9 = 4;
            goto label_0;
            label_11:
            if(SL < collected)
            {
                    UnityEngine.Color val_1 = UnityEngine.Color.white;
            }
            else
            {
                    UnityEngine.Color val_2 = UnityEngine.Color.gray;
            }
            
            this.chestIcons[0].color = new UnityEngine.Color() {r = val_3, g = val_4, b = val_5, a = val_6};
            val_8 = this;
            UnityEngine.UI.Image val_10 = this.chestIcons[0];
            UnityEngine.GameObject val_7 = val_10.gameObject;
            if(SL < total)
            {
                    0 = 1;
            }
            
            val_10.SetActive(value:  true);
            val_9 = val_9 + 1;
            label_0:
            if((val_9 - 4) < val_10)
            {
                goto label_11;
            }
        
        }
        public UnityEngine.Vector3 GetNextTileIconPosition()
        {
            int val_5 = this.GetCollectedChestCount();
            val_5 = val_5 - 1;
            var val_2 = (R1 + 16) + (val_5 << 2);
            UnityEngine.Transform val_3 = (R1 + 16 + ((val_1 - 1)) << 2) + 16.transform;
            UnityEngine.Vector3 val_4 = this.position;
            return new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        }
        public UnityEngine.Transform GetTileIcon(int index)
        {
            UnityEngine.UI.Image val_1 = this.chestIcons[index];
            if(val_1 != 0)
            {
                    return val_1.transform;
            }
            
            return val_1.transform;
        }
        public void HideIcon(int index)
        {
            UnityEngine.Color val_1 = UnityEngine.Color.clear;
            this.chestIcons[index].color = new UnityEngine.Color() {a = ???};
        }
        private int GetCollectedChestCount()
        {
            var val_3;
            var val_4;
            val_3 = 0;
            val_4 = 0;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            return (int)(val_4 + (public static WordForest.WFOMysteryChestUI MonoSingleton<WordForest.WFOMysteryChestUI>::get_Instance().__il2cppRuntimeField_24 + 8 + 0) + 16 + 20);
        }
        private void OnDestroy()
        {
            WordForest.MysteryChestStatView.<Instance>k__BackingField = 0;
        }
        public MysteryChestStatView()
        {
            this.autoUpdate = true;
        }
    
    }

}
