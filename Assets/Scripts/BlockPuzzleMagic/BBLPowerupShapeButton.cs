using UnityEngine;

namespace BlockPuzzleMagic
{
    public class BBLPowerupShapeButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler, IBeginDragHandler, IDragHandler
    {
        // Fields
        protected BlockPuzzleMagic.PowerUpType powerupType;
        protected float startShapeSize;
        protected UnityEngine.UI.Button myButton;
        protected UnityEngine.UI.Image icon;
        protected UnityEngine.UI.Text priceLabel;
        protected UnityEngine.UI.Image priceIcon;
        protected UnityEngine.GameObject lockOverlay;
        protected bool isModeOn;
        protected BlockPuzzleMagic.ShapeInfo shapePiece;
        protected bool isPowerupUsed;
        protected bool isUnlocked;
        protected bool isInputInterrupted;
        
        // Properties
        public UnityEngine.UI.Image Icon { get; }
        public bool BlockRaycasts { get; set; }
        public bool Interactable { get; set; }
        
        // Methods
        public UnityEngine.UI.Image get_Icon()
        {
        
        }
        public bool get_BlockRaycasts()
        {
            if(this.myButton == 0)
            {
                
            }
        
        }
        public void set_BlockRaycasts(bool value)
        {
            if(this.myButton == 0)
            {
                
            }
        
        }
        public bool get_Interactable()
        {
            if(this.myButton != 0)
            {
                    return (bool)this;
            }
            
            return (bool)this;
        }
        public void set_Interactable(bool value)
        {
            this.myButton.interactable = value;
        }
        protected virtual void Start()
        {
            System.Delegate val_10;
            var val_11;
            var val_12;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  1220521040, method:  typeof(BlockPuzzleMagic.BBLPowerupShapeButton).__il2cppRuntimeField_128);
            val_10 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_18;
            System.Delegate val_3 = System.Delegate.Combine(a:  val_10, b:  7401472);
            if(val_10 != 0)
            {
                    if(val_10 == null)
            {
                goto label_6;
            }
            
            }
            
            val_10 = 0;
            label_6:
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_18 = val_10;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<System.Boolean> val_5 = new System.Action<System.Boolean>(object:  1220521040, method:  new IntPtr(1220494992));
            System.Delegate val_6 = System.Delegate.Combine(a:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_30, b:  7401472);
            val_11 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_30;
            if(val_11 != 0)
            {
                    if(val_11 == null)
            {
                goto label_10;
            }
            
            }
            
            val_11 = 0;
            label_10:
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_30 = val_11;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<Result> val_8 = new System.Action<Result>(object:  1220521040, method:  new IntPtr(1220496016));
            System.Delegate val_9 = System.Delegate.Combine(a:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_34, b:  7401472);
            val_12 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_34;
            if(val_12 != 0)
            {
                    if(val_12 == null)
            {
                goto label_14;
            }
            
            }
            
            val_12 = 0;
            label_14:
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_34 = val_12;
        }
        protected virtual void OnDestroy()
        {
            var val_12;
            var val_13;
            System.Delegate val_14;
            var val_15;
            var val_16;
            val_12 = 1152921504901095424;
            val_13 = 1152921511020107712;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(2118293440 == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<twelvegigs.storage.JsonDictionary> val_4 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  1220633040, method:  typeof(BlockPuzzleMagic.BBLPowerupShapeButton).__il2cppRuntimeField_128);
            val_14 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_18;
            System.Delegate val_5 = System.Delegate.Remove(source:  val_14, value:  7401472);
            if(val_14 != 0)
            {
                    if(val_14 == null)
            {
                goto label_11;
            }
            
            }
            
            val_14 = 0;
            label_11:
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_18 = val_14;
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<System.Boolean> val_7 = new System.Action<System.Boolean>(object:  1220633040, method:  new IntPtr(1220494992));
            System.Delegate val_8 = System.Delegate.Remove(source:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_30, value:  7401472);
            val_15 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_30;
            if(val_15 != 0)
            {
                    if(val_15 == null)
            {
                goto label_15;
            }
            
            }
            
            val_15 = 0;
            label_15:
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_30 = val_15;
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_13 = 1152921504614248448;
            System.Action<Result> val_10 = new System.Action<Result>(object:  1220633040, method:  new IntPtr(1220496016));
            System.Delegate val_11 = System.Delegate.Remove(source:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_34, value:  7401472);
            val_16 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_34;
            if(val_16 != 0)
            {
                    if(val_16 == null)
            {
                goto label_19;
            }
            
            }
            
            val_16 = 0;
            label_19:
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_34 = val_16;
        }
        protected virtual void OnEnable()
        {
            this.RefreshPriceLabel();
        }
        protected virtual void ToggleLock(bool isUnlocked)
        {
            UnityEngine.GameObject val_3 = this.lockOverlay;
            if(val_3 != 0)
            {
                    val_3 = this.lockOverlay;
                val_3.SetActive(value:  isUnlocked ^ 1);
            }
            
            this.myButton.interactable = isUnlocked;
        }
        protected virtual void OnLevelInitialized(BlockPuzzleMagic.Level level)
        {
            bool val_5;
            var val_6;
            int val_7;
            val_5 = static_value_021FBBCC;
            if(val_5 != true)
            {
                    val_5 = true;
            }
            
            BlockPuzzleMagic.BestBlocksGameEcon val_1 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
            if(this.powerupType == 2)
            {
                goto label_3;
            }
            
            if(this.powerupType == 1)
            {
                goto label_4;
            }
            
            if(this.powerupType == 0)
            {
                    val_6 = 0;
            }
            
            goto label_6;
            label_3:
            val_6 = 301989888;
            goto label_6;
            label_4:
            val_6 = 268435456;
            label_6:
            if(level.levelId >= 268435456)
            {
                    0 = 1;
            }
            
            this.isUnlocked = true;
            val_7 = level.levelId;
            BlockPuzzleMagic.BestBlocksGameEcon val_2 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
            if(this.powerupType != 2)
            {
                    if(this.powerupType != 1)
            {
                
            }
            
            }
            
            if(val_7 > this)
            {
                    BestBlocksPlayer val_3 = BestBlocksPlayer.Instance;
            }
            
            this.RefreshPriceLabel();
            System.Action val_4 = new System.Action(object:  1221011024, method:  new IntPtr(1220986000));
            MonoExtensions.DelayedCallEndOfFrame(monoBehaviour:  1221011024, callback:  7454720);
        }
        public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
        {
        
        }
        public void OnPointerClick(UnityEngine.EventSystems.PointerEventData pointerEventData)
        {
            this.OnButtonClicked();
        }
        public void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this.isUnlocked == false)
            {
                    return;
            }
            
            this.shapePiece.OnPointerUp(eventData:  eventData);
            if(this.isModeOn == true)
            {
                    this.isModeOn = this;
                bool val_1 = this.ToggleMode();
            }
        
        }
        public void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this.isUnlocked == false)
            {
                    return;
            }
            
            if(this.ToggleMode() == false)
            {
                    return;
            }
            
            this.shapePiece.OnPointerDown(eventData:  eventData);
            this.shapePiece.OnBeginDrag(eventData:  eventData);
        }
        public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this.isUnlocked == true)
            {
                    this.isUnlocked = this.isModeOn;
                goto label_0;
            }
            
            return;
            label_0:
            if(this.shapePiece == 0)
            {
                
            }
        
        }
        protected virtual void OnApplicationFocus(bool hasFocus)
        {
            bool val_2;
            if(hasFocus != false)
            {
                    if(this.isInputInterrupted == false)
            {
                    return;
            }
            
                if(this.isModeOn == true)
            {
                    this.isModeOn = this;
                bool val_1 = this.ToggleMode();
            }
            
                val_2 = 0;
            }
            else
            {
                    if(this.isModeOn == false)
            {
                    return;
            }
            
                val_2 = true;
            }
            
            this.isInputInterrupted = val_2;
        }
        protected void OnButtonClicked()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
            Initialize(powerupType:  this.powerupType);
        }
        private void OnPowerupMode(bool isEntered)
        {
            if(isEntered != false)
            {
                    if(this.isModeOn == false)
            {
                goto label_1;
            }
            
            }
            
            if(this.isUnlocked == true)
            {
                    this.isUnlocked = 1;
            }
            
            this.myButton.interactable = true;
            this.RefreshPriceLabel();
            return;
            label_1:
            this.myButton.interactable = false;
        }
        private void OnPowerupUsed(BlockPuzzleMagic.PowerUpType powerupUsed)
        {
            System.Action val_1 = new System.Action(object:  1222143952, method:  new IntPtr(1222114832));
            MonoExtensions.DelayedCallEndOfFrame(monoBehaviour:  1222143952, callback:  7454720);
            BlockPuzzleMagic.PowerUpType val_2 = this.powerupType;
            val_2 = val_2 - powerupUsed;
            val_2 = val_2 >> 5;
            this.isPowerupUsed = val_2;
        }
        private bool ToggleMode()
        {
            var val_8;
            BlockPuzzleMagic.PowerUpType val_9;
            var val_10;
            bool val_8 = this.isModeOn;
            if(val_8 == false)
            {
                goto label_1;
            }
            
            val_8 = val_8 ^ 1;
            this.isModeOn = val_8;
            label_15:
            val_8 = 1152921504901095424;
            val_9 = 1152921511020107712;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_10 = 1;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_30.Invoke(obj:  false);
            return (bool)val_10;
            label_1:
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_9 = this.powerupType;
            val_8 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance();
            val_10 = 0;
            if((CanUsePowerup(powerupType:  val_9, showStoreIfOOC:  true, oocDelay:  null)) == false)
            {
                    return (bool)val_10;
            }
            
            this.isModeOn = this.isModeOn ^ 1;
            if(this.isModeOn == true)
            {
                goto label_15;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_30.Invoke(obj:  true);
            val_10 = 1;
            return (bool)val_10;
        }
        protected virtual void OnModeEntered()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Transform val_2 = public static BlockPuzzleMagic.GameBoardGenerator MonoSingleton<BlockPuzzleMagic.GameBoardGenerator>::get_Instance().__il2cppRuntimeField_1C.transform;
            typeof(UnityEngine.Transform[]).__il2cppRuntimeField_10 = public static BlockPuzzleMagic.GameBoardGenerator MonoSingleton<BlockPuzzleMagic.GameBoardGenerator>::get_Instance().__il2cppRuntimeField_1C;
            UnityEngine.GameObject val_3 = this.gameObject;
            UnityEngine.Transform val_4 = this.transform;
            typeof(UnityEngine.Transform[]).__il2cppRuntimeField_14 = this;
            BlockPuzzleMagic.BBLGameplayUIHelper.ShowGameplayOverlay(contentToShow:  -2028557104);
        }
        protected virtual void OnModeExit()
        {
            if(this.isPowerupUsed == true)
            {
                    this.isPowerupUsed = this;
                this.CreatePowerupShapeObject();
            }
            
            this.isPowerupUsed = false;
            BlockPuzzleMagic.BBLGameplayUIHelper.CloseGameplayOverlay(immediate:  false, onOverlayClosed:  0);
        }
        public void RefreshPriceLabel()
        {
            UnityEngine.UI.Text val_13;
            var val_14;
            BlockPuzzleMagic.PowerUpType val_15;
            var val_16;
            UnityEngine.UI.Text val_17;
            var val_18;
            if(this.isUnlocked == false)
            {
                goto label_1;
            }
            
            BestBlocksPlayer val_1 = BestBlocksPlayer.Instance;
            if(this.powerupType == 0)
            {
                    if((this.isUnlocked.GetPowerupAmountUsedThisLevel(powerupType:  0)) < 1)
            {
                goto label_4;
            }
            
            }
            
            bool val_3 = BlockPuzzleMagic.BBLFtuxData.IsFreeTutorialPowerupAvailable(powerupType:  this.powerupType);
            if(val_3 == false)
            {
                goto label_7;
            }
            
            label_4:
            val_13 = this.priceLabel;
            val_14 = "free_upper";
            string val_4 = Localization.Localize(key:  -1510799952, defaultValue:  -1510800032, useSingularKey:  false);
            goto label_8;
            label_1:
            val_13 = this.priceLabel;
            BlockPuzzleMagic.BestBlocksGameEcon val_5 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
            val_15 = this.powerupType;
            if(val_15 == 2)
            {
                goto label_10;
            }
            
            if(val_15 == 1)
            {
                goto label_11;
            }
            
            if(val_15 == 0)
            {
                    val_16 = mem[this.isUnlocked + 1348];
                val_16 = this.isUnlocked + 1348;
            }
            
            goto label_18;
            label_7:
            val_17 = this.priceLabel;
            BlockPuzzleMagic.BestBlocksGameEcon val_6 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
            val_15 = val_3;
            decimal val_7 = GetPowerupCost(_type:  val_15);
            string val_8 = ToString();
            UnityEngine.GameObject val_9 = this.priceIcon.gameObject;
            val_18 = 1;
            goto label_17;
            label_10:
            val_16 = mem[this.isUnlocked + 1352];
            val_16 = this.isUnlocked + 1352;
            goto label_18;
            label_11:
            val_16 = mem[this.isUnlocked + 1356];
            val_16 = this.isUnlocked + 1356;
            label_18:
            val_14 = "LEVEL {0}";
            string val_10 = System.String.Format(format:  2127161280, arg0:  13152256);
            label_8:
            val_17 = val_14;
            UnityEngine.GameObject val_11 = this.priceIcon.gameObject;
            val_18 = 0;
            label_17:
            this.priceIcon.SetActive(value:  false);
        }
        protected void CreatePowerupShapeObject()
        {
            var val_16;
            if(this.shapePiece != 0)
            {
                    UnityEngine.GameObject val_2 = this.shapePiece.gameObject;
                UnityEngine.Object.Destroy(obj:  this.shapePiece);
            }
            
            BlockPuzzleMagic.GameReferenceData val_3 = BlockPuzzleMagic.GameReferenceData.Instance;
            BlockPuzzleMagic.ShapeInfo val_4 = 0.GetShapePrefabForPowerup(powerupType:  this.powerupType);
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Transform val_6 = public static BlockPuzzleMagic.GameBoardGenerator MonoSingleton<BlockPuzzleMagic.GameBoardGenerator>::get_Instance().__il2cppRuntimeField_1C.transform;
            object val_7 = UnityEngine.Object.Instantiate<System.Object>(original:  0, parent:  public static BlockPuzzleMagic.GameBoardGenerator MonoSingleton<BlockPuzzleMagic.GameBoardGenerator>::get_Instance().__il2cppRuntimeField_1C);
            this.shapePiece = 0;
            UnityEngine.GameObject val_8 = this.gameObject;
            UnityEngine.Transform val_9 = this.transform;
            UnityEngine.Transform val_10 = this.transform;
            val_16 = this;
            UnityEngine.Vector3 val_11 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            if(val_16 != 0)
            {
                    if(null == null)
            {
                goto label_16;
            }
            
            }
            
            if(val_16 == 0)
            {
                goto label_17;
            }
            
            label_16:
            if(null == null)
            {
                goto label_18;
            }
            
            label_17:
            val_16 = 0;
            label_18:
            UnityEngine.Vector3 val_12 = TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_11.x, z = val_11.y});
            this.shapePiece.Interactable = false;
            if(this.shapePiece != 0)
            {
                    return;
            }
        
        }
        public BBLPowerupShapeButton()
        {
            this.isUnlocked = true;
            this.startShapeSize = 1.5f;
        }
    
    }

}
