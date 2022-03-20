using UnityEngine;

namespace BlockPuzzleMagic
{
    public class BBLGoalTooltipPopup : MonoBehaviour
    {
        // Fields
        private const string horizontalGoalText = "Clear {0} horizontal line{1}";
        private const string verticalGoalText = "Clear {0} vertical line{1}";
        private const string blocksGoalText = "Clear {0} {1} block{2} by using them to clear lines";
        private const string stonesGoalText = "Clear all {0} stone{1} by using them twice to clear lines";
        private const string dotsGoalText = "Clear all {0} dot{1} by clearing lines where the dots are";
        private UnityEngine.UI.Button closeButton;
        private UnityEngine.Transform arrow;
        private UnityEngine.GameObject[] pages;
        private UnityEngine.UI.Text titleText;
        private UnityEngine.UI.Text infoText;
        private System.Collections.Generic.Dictionary<BlockPuzzleMagic.BlockColorType, string> colorNames;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  1216388080, method:  new IntPtr(1216363056));
            this.closeButton.m_OnClick.AddListener(call:  162246656);
        }
        public void Initialize(UnityEngine.Transform goalTransform, BlockPuzzleMagic.Goal.GoalType goalType, BlockPuzzleMagic.BlockColorType goalColor)
        {
            var val_8;
            UnityEngine.Color val_1 = UnityEngine.Color.clear;
            val_8 = 0;
            typeof(UnityEngine.Transform[]).__il2cppRuntimeField_10 = goalTransform;
            UnityEngine.Transform val_2 = goalTransform.transform;
            if(this != 0)
            {
                    val_8 = mem[null + 32];
                if(this == 0)
            {
                    val_8 = 0;
            }
            
            }
            
            val_8 = 0;
            typeof(UnityEngine.Transform[]).__il2cppRuntimeField_14 = this;
            BlockPuzzleMagic.BBLGameplayUIHelper.ShowGameplayOverlay(bgColor:  new UnityEngine.Color(), setBgColorInstantly:  false, contentToShow:  null);
            UnityEngine.Vector3 val_3 = localPosition;
            UnityEngine.Vector3 val_5 = localPosition;
            UnityEngine.Vector3 val_7 = new UnityEngine.Vector3(x:  val_5.x, y:  val_5.y, z:  val_5.z);
            this.arrow.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            this.DisplayContent(goalType:  goalType, goalColor:  goalColor);
        }
        private void DisplayContent(BlockPuzzleMagic.Goal.GoalType goalType, BlockPuzzleMagic.BlockColorType goalColor)
        {
            GoalType val_16;
            var val_17;
            var val_18;
            System.Predicate<ZooTile> val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            object val_1 = new System.Object();
            if(val_1 != 0)
            {
                    val_16 = val_1;
                typeof(BBLGoalTooltipPopup.<>c__DisplayClass13_0).__il2cppRuntimeField_8 = goalType;
            }
            else
            {
                    val_16 = 8;
                mem[8] = goalType;
            }
            
            typeof(BBLGoalTooltipPopup.<>c__DisplayClass13_0).__il2cppRuntimeField_C = goalColor;
            val_17 = 0;
            goto label_3;
            label_9:
            UnityEngine.GameObject val_16 = this.pages[val_17];
            val_16.SetActive(value:  (val_17 - mem[8]) >> 5);
            val_17 = 1;
            label_3:
            if(val_17 < val_16)
            {
                goto label_9;
            }
            
            if((BlockPuzzleMagic.Goal.IsGoalColorBased(goalType:  val_16)) != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_18 = mem[public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14 + 16];
                val_18 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14 + 16;
                val_19 = null;
                val_20 = 1152921514413504816;
            }
            else
            {
                    twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_18 = mem[public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14 + 16];
                val_18 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14 + 16;
                val_19 = null;
                val_20 = 1152921514413505840;
            }
            
            val_19 = new System.Predicate<ZooTile>(object:  462725120, method:  new IntPtr(1216724272));
            object val_9 = val_18.Find(match:  8040448);
            if(val_18 != 0)
            {
                    val_21 = mem[public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14 + 16 + 12];
                val_21 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14 + 16 + 12;
            }
            else
            {
                    val_21 = 0;
            }
            
            val_22 = "";
            GoalType val_17 = mem[8];
            val_17 = val_17 - 1;
            if(val_17 <= 4)
            {
                    var val_12 = 10369304 + (10369304 + ((goalType - 1)) << 2);
                if(val_17 == 4)
            {
                    10369304 + ((goalType - 1)) << 2 = (10369304 + ((goalType - 1)) << 2) & (this << (10369304 + ((goalType - 1)) << 2));
                10369304 + ((goalType - 1)) << 2 = (10369304 + ((goalType - 1)) << 2) & ((IP) >> (10369304 + ((goalType - 1)) << 2 & (this) << 10369304 + ((goalType - 1)) << 2));
                10369304 + ((goalType - 1)) << 2 = (10369304 + ((goalType - 1)) << 2) & (((this) << (32-as. 
                
            
            
            
            
            
               
            )) | ((this) << as. 
                
            
            
            
            
            
               
            ));
                mem2[0] = (((10369304 + ((goalType - 1)) << 2 & (this) << 10369304 + ((goalType - 1)) << 2) & (IP) >> (10369304 + ((goalType - 1)) << 2 & (this) << 10369304 + ((goalType - 1)) << 2)) & ((this) << (32-as. 
                
             + (((10369304 + ((goalType - 1)) << 2 & (this) << 10369304 + ((goalType - 1)) << 2) & (IP) >> (10369304 + ((goalType - 1)) << 2 & (this) << 10369304 + ((goalType - 1)) << 2)) & ((this) << (32-as. 
                
            ;
            }
            
                val_23 = null;
                val_24 = "Clear {0} vertical line{1}";
                if((UnityEngine.Mathf.Max(a:  0, b:  (val_21 - public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14 + 16 + 16))) == 1)
            {
                    "s" = "";
            }
            
                string val_15 = System.String.Format(format:  1216733088, arg0:  13152256, arg1:  1098586544);
                val_22 = ;
            }
            
            if(this.infoText != 0)
            {
                    return;
            }
        
        }
        private void OnCloseButtonClicked()
        {
            BlockPuzzleMagic.BBLGameplayUIHelper.CloseGameplayOverlay(immediate:  false, onOverlayClosed:  0);
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  1216967584, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        public BBLGoalTooltipPopup()
        {
            System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_1 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
            if(null != 0)
            {
                    Add(key:  2, value:  2120853776);
            }
            else
            {
                    Add(key:  2, value:  2120853776);
            }
            
            Add(key:  3, value:  2120853856);
            if(null != 0)
            {
                    Add(key:  4, value:  2120853936);
            }
            else
            {
                    Add(key:  4, value:  2120853936);
            }
            
            Add(key:  5, value:  2120854016);
            if(null != 0)
            {
                    Add(key:  6, value:  2120854096);
            }
            else
            {
                    Add(key:  6, value:  2120854096);
            }
            
            Add(key:  7, value:  2120854176);
            this.colorNames = null;
        }
    
    }

}
