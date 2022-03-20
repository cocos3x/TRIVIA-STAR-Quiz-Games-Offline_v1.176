using UnityEngine;

namespace BlockPuzzleMagic
{
    public class GoalDisplayUI : MonoSingleton<BlockPuzzleMagic.GoalDisplayUI>
    {
        // Fields
        private BlockPuzzleMagic.GoalDisplayIcon goalDisplayIconPrefab;
        private UnityEngine.RectTransform displayContainer;
        private System.Collections.Generic.List<BlockPuzzleMagic.GoalDisplayIcon> goalDisplayIconList;
        
        // Properties
        public System.Collections.Generic.List<BlockPuzzleMagic.GoalDisplayIcon> GoalDisplayIconList { get; }
        
        // Methods
        public System.Collections.Generic.List<BlockPuzzleMagic.GoalDisplayIcon> get_GoalDisplayIconList()
        {
        
        }
        private void Start()
        {
            var val_4;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  1254945296, method:  new IntPtr(1254920272));
            System.Delegate val_3 = System.Delegate.Combine(a:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_18, b:  7401472);
            val_4 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_18;
            if(val_4 != 0)
            {
                    if(val_4 == null)
            {
                goto label_6;
            }
            
            }
            
            val_4 = 0;
            label_6:
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_18 = val_4;
        }
        private void OnDestroy()
        {
            var val_6;
            System.Action<twelvegigs.storage.JsonDictionary> val_7;
            var val_8;
            val_6 = 1152921504901095424;
            val_7 = 1152921511020107712;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(2118293440 == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_7 = null;
            val_7 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  1255057296, method:  new IntPtr(1254920272));
            System.Delegate val_5 = System.Delegate.Remove(source:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_18, value:  7401472);
            val_8 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_18;
            if(val_8 != 0)
            {
                    if(val_8 == null)
            {
                goto label_11;
            }
            
            }
            
            val_8 = 0;
            label_11:
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_18 = val_8;
        }
        private void OnLevelDataInitialized(BlockPuzzleMagic.Level currLevel)
        {
            System.Collections.Generic.List<BlockPuzzleMagic.GoalDisplayIcon> val_4;
            var val_5;
            System.Collections.Generic.List<BlockPuzzleMagic.GoalDisplayIcon> val_6;
            var val_7;
            val_4 = this.goalDisplayIconList;
            if(val_4 == 0)
            {
                goto label_1;
            }
            
            val_5 = 0;
            val_6 = 1152921504765685760;
            goto label_2;
            label_9:
            if(true <= val_5)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + 0;
            UnityEngine.GameObject val_1 = (0 + 0) + 16.gameObject;
            UnityEngine.Object.Destroy(obj:  (0 + 0) + 16);
            val_4 = this.goalDisplayIconList;
            val_5 = 1;
            label_2:
            if(val_5 < ((0 + 0) + 16))
            {
                goto label_9;
            }
            
            label_1:
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.goalDisplayIconList = null;
            val_7 = 0;
            goto label_10;
            label_20:
            object val_3 = UnityEngine.Object.Instantiate<System.Object>(original:  this.goalDisplayIconPrefab, parent:  this.displayContainer);
            if(this.goalDisplayIconPrefab <= val_7)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + 0;
            if(this.goalDisplayIconPrefab != 0)
            {
                    this.goalDisplayIconPrefab.Initialize(_goal:  (0 + 0) + 16);
            }
            else
            {
                    this.goalDisplayIconPrefab.Initialize(_goal:  (0 + 0) + 16);
            }
            
            this.goalDisplayIconPrefab.EnableButton();
            val_6 = this.goalDisplayIconList;
            val_6.Add(item:  this.goalDisplayIconPrefab);
            val_7 = 1;
            label_10:
            if(val_7 < val_6)
            {
                goto label_20;
            }
        
        }
        public GoalDisplayUI()
        {
        
        }
    
    }

}
