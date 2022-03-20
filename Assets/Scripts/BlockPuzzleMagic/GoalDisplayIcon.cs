using UnityEngine;

namespace BlockPuzzleMagic
{
    public class GoalDisplayIcon : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Image icon;
        private UnityEngine.UI.Text label;
        private UnityEngine.UI.Image checkmarkIcon;
        private UnityEngine.GameObject newText;
        private UnityEngine.UI.Button button;
        private float iconDesiredHeight;
        private UnityEngine.ParticleSystem particles;
        private UnityEngine.GameObject container;
        private System.Collections.Generic.List<BlockPuzzleMagic.GoalIconSprite> goalIconList;
        private BlockPuzzleMagic.Goal.GoalType <goalType>k__BackingField;
        private BlockPuzzleMagic.BlockColorType <goalColor>k__BackingField;
        
        // Properties
        public UnityEngine.GameObject Container { get; }
        public BlockPuzzleMagic.Goal.GoalType goalType { get; set; }
        public BlockPuzzleMagic.BlockColorType goalColor { get; set; }
        
        // Methods
        public UnityEngine.GameObject get_Container()
        {
        
        }
        public BlockPuzzleMagic.Goal.GoalType get_goalType()
        {
        
        }
        private void set_goalType(BlockPuzzleMagic.Goal.GoalType value)
        {
            this.<goalType>k__BackingField = value;
        }
        public BlockPuzzleMagic.BlockColorType get_goalColor()
        {
        
        }
        private void set_goalColor(BlockPuzzleMagic.BlockColorType value)
        {
            this.<goalColor>k__BackingField = value;
        }
        private void Start()
        {
            var val_8;
            var val_9;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_2 = new System.Action(object:  1252527888, method:  new IntPtr(1252492624));
            System.Delegate val_3 = System.Delegate.Combine(a:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_2C, b:  7454720);
            val_8 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_2C;
            if(val_8 != 0)
            {
                    if(val_8 == null)
            {
                goto label_6;
            }
            
            }
            
            val_8 = 0;
            label_6:
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_2C = val_8;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<System.Boolean> val_5 = new System.Action<System.Boolean>(object:  1252527888, method:  new IntPtr(1252493648));
            System.Delegate val_6 = System.Delegate.Combine(a:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_38, b:  7401472);
            val_9 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_38;
            if(val_9 != 0)
            {
                    if(val_9 == null)
            {
                goto label_10;
            }
            
            }
            
            val_9 = 0;
            label_10:
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_38 = val_9;
            UnityEngine.Events.UnityAction val_7 = new UnityEngine.Events.UnityAction(object:  1252527888, method:  new IntPtr(1252502864));
            this.button.m_OnClick.AddListener(call:  162246656);
        }
        private void OnDestroy()
        {
            var val_9;
            float val_10;
            var val_11;
            var val_12;
            val_9 = 1152921504901095424;
            val_10 = 1152921511020107712;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(2118293440 == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_4 = new System.Action(object:  1252648080, method:  new IntPtr(1252492624));
            System.Delegate val_5 = System.Delegate.Remove(source:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_2C, value:  7454720);
            val_11 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_2C;
            if(val_11 != 0)
            {
                    if(val_11 == null)
            {
                goto label_11;
            }
            
            }
            
            val_11 = 0;
            label_11:
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_2C = val_11;
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_10 = 1152921504614248448;
            System.Action<System.Boolean> val_7 = new System.Action<System.Boolean>(object:  1252648080, method:  new IntPtr(1252493648));
            System.Delegate val_8 = System.Delegate.Remove(source:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_38, value:  7401472);
            val_12 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_38;
            if(val_12 != 0)
            {
                    if(val_12 == null)
            {
                goto label_15;
            }
            
            }
            
            val_12 = 0;
            label_15:
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_38 = val_12;
        }
        public void EnableNewText()
        {
            this.newText.SetActive(value:  true);
        }
        public void EnableButton()
        {
            this.button.interactable = true;
        }
        public void Initialize(BlockPuzzleMagic.Goal _goal)
        {
            BlockPuzzleMagic.Goal val_7;
            System.Predicate<ZooTile> val_8;
            UnityEngine.UI.Image val_9;
            Goal.GoalType val_10;
            val_7 = _goal;
            this.<goalType>k__BackingField = _goal.goalType;
            val_8 = null;
            val_8 = new System.Predicate<ZooTile>(object:  1253052688, method:  new IntPtr(1252988752));
            BlockPuzzleMagic.GoalIconSprite val_2 = this.goalIconList.Find(match:  8040448);
            val_9 = this.icon;
            val_9.sprite = this.goalIconList;
            this.icon.preserveAspect = true;
            UnityEngine.RectTransform val_3 = this.icon.rectTransform;
            this.icon.SetSizeWithCurrentAnchors(axis:  1, size:  null);
            this.RefreshUIInstant(currentGoalData:  val_7);
            val_10 = this.<goalType>k__BackingField;
            if(val_10 == 3)
            {
                    val_9 = this.icon;
                BlockPuzzleMagic.GameReferenceData val_4 = BlockPuzzleMagic.GameReferenceData.Instance;
                BlockPuzzleMagic.BlockColor val_5 = val_10.GetBlockColor(colorType:  _goal.goalColorValue);
                val_9.color = new UnityEngine.Color() {r = val_7, g = SL, b = SB, a = val_10};
                val_10 = this.<goalType>k__BackingField;
                this.<goalColor>k__BackingField = _goal + 20;
            }
            
            if(val_10 != 4)
            {
                    return;
            }
            
            UnityEngine.Color val_6 = new UnityEngine.Color(r:  null, g:  null, b:  null);
            this.icon.color = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_8};
        }
        private void OnGoalProgressUpdated()
        {
            BlockPuzzleMagic.Goal val_6;
            System.Predicate<ZooTile> val_7;
            var val_8;
            if((this.<goalType>k__BackingField) == 3)
            {
                    twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_6 = mem[public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14 + 16];
                val_6 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14 + 16;
                val_7 = null;
                val_8 = 1152921514449975504;
            }
            else
            {
                    twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_6 = mem[public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14 + 16];
                val_6 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14 + 16;
                val_7 = null;
                val_8 = 1152921514449976528;
            }
            
            val_7 = new System.Predicate<ZooTile>(object:  1253219984, method:  new IntPtr(1253194960));
            object val_5 = val_6.Find(match:  8040448);
            if(val_6 == 0)
            {
                    return;
            }
            
            this.RefreshUI(currentGoalData:  val_6);
        }
        private void RefreshUI(BlockPuzzleMagic.Goal currentGoalData)
        {
            int val_10;
            object val_1 = new System.Object();
            typeof(GoalDisplayIcon.<>c__DisplayClass25_0).__il2cppRuntimeField_8 = this;
            if(currentGoalData != 0)
            {
                    val_10 = currentGoalData.targetValue;
            }
            else
            {
                    val_10 = 0;
            }
            
            typeof(GoalDisplayIcon.<>c__DisplayClass25_0).__il2cppRuntimeField_C = UnityEngine.Mathf.Max(a:  0, b:  val_10 - currentGoalData.currentValue);
            string val_4 = typeof(GoalDisplayIcon.<>c__DisplayClass25_0).__il2cppRuntimeField_C.ToString();
            if((System.String.Compare(strA:  this.label, strB:  464642060)) == 0)
            {
                    return;
            }
            
            this.particles.Play();
            UnityEngine.Transform val_6 = this.label.transform;
            DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.label, endValue:  null, duration:  null);
            DG.Tweening.TweenCallback val_8 = new DG.Tweening.TweenCallback(object:  464642048, method:  new IntPtr(1253328464));
            object val_9 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.label, action:  190734336);
        }
        private void RefreshUIInstant(BlockPuzzleMagic.Goal currentGoalData)
        {
            int val_6;
            if(currentGoalData != 0)
            {
                    val_6 = currentGoalData.targetValue;
            }
            else
            {
                    val_6 = 0;
            }
            
            int val_2 = UnityEngine.Mathf.Max(a:  0, b:  val_6 - currentGoalData.currentValue);
            string val_3 = val_2.ToString();
            UnityEngine.GameObject val_4 = this.label.gameObject;
            if(val_2 > 0)
            {
                    0 = 1;
            }
            
            this.label.SetActive(value:  true);
            UnityEngine.GameObject val_5 = this.checkmarkIcon.gameObject;
            if(val_2 < 1)
            {
                    0 = 1;
            }
            
            this.checkmarkIcon.SetActive(value:  true);
        }
        private void OnLevelCleared(bool success)
        {
            if(success == false)
            {
                    return;
            }
            
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.Transform val_2 = this.transform;
            UnityEngine.Vector3 val_3 = localPosition;
            DG.Tweening.Sequence val_4 = DG.Tweening.ShortcutExtensions.DOLocalJump(target:  1253626640, endValue:  new UnityEngine.Vector3(), jumpPower:  val_3.x, numJumps:  1097859072, duration:  val_3.y, snapping:  true);
        }
        public void OnButtonClicked()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
            UnityEngine.Transform val_3 = this.transform;
            Initialize(goalTransform:  1253747856, goalType:  this.<goalType>k__BackingField, goalColor:  this.<goalColor>k__BackingField);
        }
        public GoalDisplayIcon()
        {
            this.iconDesiredHeight = 108f;
        }
        private bool <Initialize>b__23_0(BlockPuzzleMagic.GoalIconSprite obj)
        {
            Goal.GoalType val_1 = this.<goalType>k__BackingField;
            val_1 = obj.goalType - val_1;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        private bool <OnGoalProgressUpdated>b__24_0(BlockPuzzleMagic.Goal obj)
        {
            if(obj.goalType != (this.<goalType>k__BackingField))
            {
                    return (bool)0;
            }
            
            BlockPuzzleMagic.BlockColorType val_1 = this.<goalColor>k__BackingField;
            val_1 = obj.goalColorValue - val_1;
            0 = val_1 >> 5;
            return (bool)0;
        }
        private bool <OnGoalProgressUpdated>b__24_1(BlockPuzzleMagic.Goal obj)
        {
            Goal.GoalType val_1 = this.<goalType>k__BackingField;
            val_1 = obj.goalType - val_1;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
    
    }

}
