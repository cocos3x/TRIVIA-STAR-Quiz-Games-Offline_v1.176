using UnityEngine;

namespace WordPets
{
    public class WPTGameUIResizer : MonoSingleton<WordPets.WPTGameUIResizer>
    {
        // Fields
        private UnityEngine.RectTransform contentSafeAreaTransform;
        private UnityEngine.UI.HorizontalOrVerticalLayoutGroup columnLayoutGroup;
        private bool isLevelInitialized;
        private UnityEngine.Vector2 tilePadding;
        private UnityEngine.Vector2 maxTileSize;
        private System.Nullable<UnityEngine.Vector2> currentTileSize;
        public System.Action OnResized;
        
        // Properties
        public UnityEngine.Vector2 MaxTileSize { get; }
        public UnityEngine.Vector2 CurrentTileSize { get; }
        
        // Methods
        public UnityEngine.Vector2 get_MaxTileSize()
        {
            this = R1 + 32;
            mem[1152921513386683764] = R1 + 36;
            return new UnityEngine.Vector2();
        }
        public UnityEngine.Vector2 get_CurrentTileSize()
        {
            if((R1 + 48) == 0)
            {
                    return new UnityEngine.Vector2();
            }
            
            var val_1 = R1 + 40;
            UnityEngine.Vector2 val_2 = this.Value;
            return new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
        }
        private void Start()
        {
            var val_4;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_2 = new System.Action(object:  190128240, method:  new IntPtr(190103216));
            System.Delegate val_3 = System.Delegate.Combine(a:  public static WordPets.WPTGameUIController MonoSingleton<WordPets.WPTGameUIController>::get_Instance().__il2cppRuntimeField_E4, b:  7454720);
            val_4 = public static WordPets.WPTGameUIController MonoSingleton<WordPets.WPTGameUIController>::get_Instance().__il2cppRuntimeField_E4;
            if(val_4 != 0)
            {
                    if(val_4 == null)
            {
                goto label_6;
            }
            
            }
            
            val_4 = 0;
            label_6:
            public static WordPets.WPTGameUIController MonoSingleton<WordPets.WPTGameUIController>::get_Instance().__il2cppRuntimeField_E4 = val_4;
        }
        private void OnDestroy()
        {
            var val_4;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_2 = new System.Action(object:  190240240, method:  new IntPtr(190103216));
            System.Delegate val_3 = System.Delegate.Remove(source:  public static WordPets.WPTGameUIController MonoSingleton<WordPets.WPTGameUIController>::get_Instance().__il2cppRuntimeField_E4, value:  7454720);
            val_4 = public static WordPets.WPTGameUIController MonoSingleton<WordPets.WPTGameUIController>::get_Instance().__il2cppRuntimeField_E4;
            if(val_4 != 0)
            {
                    if(val_4 == null)
            {
                goto label_6;
            }
            
            }
            
            val_4 = 0;
            label_6:
            public static WordPets.WPTGameUIController MonoSingleton<WordPets.WPTGameUIController>::get_Instance().__il2cppRuntimeField_E4 = val_4;
        }
        private void OnLevelCreated()
        {
            this.isLevelInitialized = true;
            this.Recalculate();
        }
        private void OnRectTransformDimensionsChange()
        {
            if(this.isLevelInitialized == false)
            {
                    return;
            }
            
            this.Recalculate();
        }
        public void Recalculate()
        {
            var val_10;
            var val_11;
            float val_14;
            float val_15;
            object val_1 = null;
            val_10 = val_1;
            val_1 = new System.Object();
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            typeof(WPTGameUIResizer.<>c__DisplayClass15_0).__il2cppRuntimeField_8 = 0;
            System.Action<twelvegigs.storage.JsonDictionary> val_3 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  399998976, method:  new IntPtr(190552240));
            public static WordPets.WPTGameUIController MonoSingleton<WordPets.WPTGameUIController>::get_Instance().__il2cppRuntimeField_C4 + 8.ForEach(action:  7401472);
            val_11 = 0;
            UnityEngine.Rect val_4 = rect;
            float val_5 = height;
            float val_10 = 0f;
            val_14 = mem[1152921513387360912];
            val_15 = mem[1152921513387360916];
            val_10 = 190567256 / val_10;
            if(mem[1152921513387360892] < 0)
            {
                    float val_11 = val_15;
                val_11 = val_10 / val_11;
                val_11 = val_11 * val_14;
                val_15 = val_10;
                val_14 = val_11;
            }
            
            System.Nullable<UnityEngine.Vector2> val_6 = new System.Nullable<UnityEngine.Vector2>(value:  new UnityEngine.Vector2() {x = val_14, y = val_15});
            val_10 = mem[1152921513387360904] + val_14;
            mem[1152921513387360896].spacing = val_10;
            val_11 = 0;
            if(mem[1152921513387360932] == 0)
            {
                    return;
            }
            
            mem[1152921513387360932].Invoke();
        }
        public WPTGameUIResizer()
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  null, y:  null);
            this.maxTileSize = val_1.x;
            mem[1152921513387473940] = val_1.y;
        }
    
    }

}
