using UnityEngine;
public class BBLFTUXDemoWindow : FTUXDemoWindow
{
    // Fields
    private UnityEngine.UI.Image handCursor;
    private UnityEngine.GameObject bubbleObject;
    private UnityEngine.UI.Image bubbleTipImageDown;
    private UnityEngine.UI.Image bubbleTipImageUp;
    private UnityEngine.UI.Text bubbleHeader;
    private UnityEngine.UI.Text[] bubbleLabel;
    private UnityEngine.UI.Button bubbleButton;
    private UnityEngine.GameObject groupButton;
    private UnityEngine.GameObject groupNoButton;
    private UnityEngine.GameObject actedObject;
    private UnityEngine.GameObject tutorialTitle;
    private static BlockPuzzleMagic.FtuxId currentFtuxFlag;
    private bool stepCompletedByPlayer;
    private DG.Tweening.Sequence pointerMoveSeq;
    private System.Collections.Generic.Dictionary<BlockPuzzleMagic.BlockColorType, string> colorNames;
    
    // Properties
    public static BlockPuzzleMagic.FtuxId CurrentFtux { get; }
    
    // Methods
    public static BlockPuzzleMagic.FtuxId get_CurrentFtux()
    {
        null = null;
    }
    private void Start()
    {
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  2118338944, method:  new IntPtr(2118294464));
        System.Delegate val_3 = System.Delegate.Combine(a:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_1C, b:  7401472);
        val_15 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_1C;
        if(val_15 != 0)
        {
                if(val_15 == null)
        {
            goto label_6;
        }
        
        }
        
        val_15 = 0;
        label_6:
        public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_1C = val_15;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<twelvegigs.storage.JsonDictionary> val_5 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  2118338944, method:  new IntPtr(2118296512));
        System.Delegate val_6 = System.Delegate.Combine(a:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_20, b:  7401472);
        val_16 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_20;
        if(val_16 != 0)
        {
                if(val_16 == null)
        {
            goto label_10;
        }
        
        }
        
        val_16 = 0;
        label_10:
        public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_20 = val_16;
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<Result> val_8 = new System.Action<Result>(object:  2118338944, method:  new IntPtr(2118297536));
        System.Delegate val_9 = System.Delegate.Combine(a:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_34, b:  7401472);
        val_17 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_34;
        if(val_17 != 0)
        {
                if(val_17 == null)
        {
            goto label_14;
        }
        
        }
        
        val_17 = 0;
        label_14:
        public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_34 = val_17;
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean> val_11 = new System.Action<System.Boolean>(object:  2118338944, method:  new IntPtr(2118299584));
        System.Delegate val_12 = System.Delegate.Combine(a:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_30, b:  7401472);
        val_18 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_30;
        if(val_18 != 0)
        {
                if(val_18 == null)
        {
            goto label_18;
        }
        
        }
        
        val_18 = 0;
        label_18:
        public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_30 = val_18;
        UnityEngine.Events.UnityAction val_13 = new UnityEngine.Events.UnityAction(object:  2118338944, method:  new IntPtr(2118309824));
        this.bubbleButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.GameObject val_14 = this.handCursor.gameObject;
        this.handCursor.SetActive(value:  false);
    }
    private void OnDestroy()
    {
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        val_16 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_17 = 1152921504765685760;
        if((UnityEngine.Object.op_Implicit(exists:  2118293440)) == false)
        {
            goto label_5;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<twelvegigs.storage.JsonDictionary> val_4 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  2118471424, method:  new IntPtr(2118294464));
        System.Delegate val_5 = System.Delegate.Remove(source:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_1C, value:  7401472);
        val_18 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_1C;
        if(val_18 != 0)
        {
                if(val_18 == null)
        {
            goto label_11;
        }
        
        }
        
        val_18 = 0;
        label_11:
        public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_1C = val_18;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<twelvegigs.storage.JsonDictionary> val_7 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  2118471424, method:  new IntPtr(2118296512));
        System.Delegate val_8 = System.Delegate.Remove(source:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_20, value:  7401472);
        val_19 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_20;
        if(val_19 != 0)
        {
                if(val_19 == null)
        {
            goto label_15;
        }
        
        }
        
        val_19 = 0;
        label_15:
        public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_20 = val_19;
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<Result> val_10 = new System.Action<Result>(object:  2118471424, method:  new IntPtr(2118297536));
        System.Delegate val_11 = System.Delegate.Remove(source:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_34, value:  7401472);
        val_20 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_34;
        if(val_20 != 0)
        {
                if(val_20 == null)
        {
            goto label_19;
        }
        
        }
        
        val_20 = 0;
        label_19:
        public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_34 = val_20;
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean> val_13 = new System.Action<System.Boolean>(object:  2118471424, method:  new IntPtr(2118299584));
        System.Delegate val_14 = System.Delegate.Remove(source:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_30, value:  7401472);
        val_16 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_30;
        val_17 = 1152921504765685760;
        if(val_16 != 0)
        {
                if(val_16 == null)
        {
            goto label_23;
        }
        
        }
        
        val_16 = 0;
        label_23:
        public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_30 = val_16;
        label_5:
        UnityEngine.GameObject val_15 = this.handCursor.gameObject;
        UnityEngine.Object.Destroy(obj:  this.handCursor);
        UnityEngine.Object.Destroy(obj:  this.bubbleObject);
    }
    private void OnSpeechBubbleButtonClicked()
    {
        this.stepCompletedByPlayer = true;
        this.CloseWindow(immediate:  false);
    }
    private void OnShapePlaced(BlockPuzzleMagic.ShapeInfo shape)
    {
        var val_2;
        var val_3;
        BlockPuzzleMagic.FtuxId val_4;
        val_2 = this;
        val_3 = null;
        val_3 = null;
        val_4 = BBLFTUXDemoWindow.currentFtuxFlag;
        if(val_4 != 1)
        {
                val_3 = null;
            val_4 = BBLFTUXDemoWindow.currentFtuxFlag;
            if(val_4 != 2)
        {
                val_4 = BBLFTUXDemoWindow.currentFtuxFlag;
            if(val_4 != 3)
        {
                return;
        }
        
        }
        
        }
        
        mem2[0] = 1;
        R4.CloseWindow(immediate:  false);
    }
    private void OnShapeRotated(BlockPuzzleMagic.ShapeInfo shape)
    {
        null = null;
        if(BBLFTUXDemoWindow.currentFtuxFlag != 14)
        {
                return;
        }
        
        object val_1 = R4 + 48.GetComponent<System.Object>();
        if((R4 + 48) != 0)
        {
                mem2[0] = 1;
        }
        
        mem2[0] = 1;
        R4.CloseWindow(immediate:  false);
    }
    private void OnPowerupUsed(BlockPuzzleMagic.PowerUpType pType)
    {
        var val_2;
        var val_3;
        BlockPuzzleMagic.FtuxId val_4;
        val_2 = this;
        val_3 = null;
        val_3 = null;
        val_4 = BBLFTUXDemoWindow.currentFtuxFlag;
        if(val_4 != 4)
        {
                val_3 = null;
            val_4 = BBLFTUXDemoWindow.currentFtuxFlag;
            if(val_4 != 5)
        {
                val_4 = BBLFTUXDemoWindow.currentFtuxFlag;
            if(val_4 != 6)
        {
                return;
        }
        
        }
        
        }
        
        mem2[0] = 0;
        mem2[0] = 1;
        R4.CloseWindow(immediate:  false);
    }
    private void OnPowerupMode(bool isOn)
    {
        var val_1;
        BlockPuzzleMagic.FtuxId val_2;
        val_1 = null;
        val_1 = null;
        val_2 = BBLFTUXDemoWindow.currentFtuxFlag;
        if(val_2 != 6)
        {
                val_1 = null;
            val_2 = BBLFTUXDemoWindow.currentFtuxFlag;
            if(val_2 != 5)
        {
                val_1 = null;
            val_2 = BBLFTUXDemoWindow.currentFtuxFlag;
            if(val_2 != 4)
        {
                return;
        }
        
        }
        
        }
        
        if(isOn != false)
        {
                this.HideSpeechBubble();
            return;
        }
        
        if(this.stepCompletedByPlayer == true)
        {
                return;
        }
        
        val_1 = mem[R6];
        val_1 = R6;
        R4.DisplayFTUXStep(stage:  R6 + 92, targetGO:  R4 + 48);
    }
    public void ShowFTUXStep(BlockPuzzleMagic.FtuxId stage, UnityEngine.GameObject targetGO)
    {
        BlockPuzzleMagic.FtuxId val_3;
        var val_4;
        val_3 = stage;
        if(new System.Object() != 0)
        {
            
        }
        else
        {
                mem[8] = this;
            mem[12] = val_3;
            mem[16] = targetGO;
            val_3 = mem[12];
        }
        
        val_4 = null;
        val_4 = null;
        BBLFTUXDemoWindow.currentFtuxFlag = val_3;
        System.Action val_2 = new System.Action(object:  274440192, method:  new IntPtr(2119161408));
        MonoExtensions.DelayedCallEndOfFrame(monoBehaviour:  2119186432, callback:  7454720);
    }
    private void DisplayFTUXStep(BlockPuzzleMagic.FtuxId stage, UnityEngine.GameObject targetGO)
    {
        var val_45;
        var val_46;
        val_45 = null;
        val_45 = null;
        BBLFTUXDemoWindow.currentFtuxFlag = stage;
        BlockPuzzleMagic.FtuxId val_2 = stage - 1;
        if(targetGO != 0)
        {
                this.actedObject = targetGO;
        }
        
        if(val_2 > 13)
        {
            goto label_5;
        }
        
        var val_3 = 14716224 + (14716224 + ((stage - 1)) << 2);
        if(val_2 == 13)
        {
                14716224 + ((stage - 1)) << 2 = (14716224 + ((stage - 1)) << 2) & ((R8) >> 14716224 + ((stage - 1)) << 2);
            14716224 + ((stage - 1)) << 2 = (14716224 + ((stage - 1)) << 2) & ((R8) >> (14716224 + ((stage - 1)) << 2 & (R8) >> 14716224 + ((stage - 1)) << 2));
            14716224 + ((stage - 1)) << 2 = (14716224 + ((stage - 1)) << 2) & ((R8) >> ((14716224 + ((stage - 1)) << 2 & (R8) >> 14716224 + ((stage - 1)) << 2) & (R8) >> (14716224 + ((stage - 1)) << 2 & (R8) >> 14716224 + ((stage - 1)) << 2)));
            14716224 + ((stage - 1)) << 2 = (14716224 + ((stage - 1)) << 2) & ((14716224 + ((stage - 1)) << 2) >> targetGO);
            14716224 + ((stage - 1)) << 2 = (14716224 + ((stage - 1)) << 2) & ((14716224 + ((stage - 1)) << 2) >> targetGO);
            14716224 + ((stage - 1)) << 2 = (14716224 + ((stage - 1)) << 2) & ((14716224 + ((stage - 1)) << 2) >> targetGO);
            14716224 + ((stage - 1)) << 2 = (14716224 + ((stage - 1)) << 2) & (((int)IP) >> stage);
            14716224 + ((stage - 1)) << 2 = (14716224 + ((stage - 1)) << 2) & (((R8) << (32-14)) | ((R8) << 14));
            14716224 + ((stage - 1)) << 2 = (14716224 + ((stage - 1)) << 2) & ((R8) >> IP);
            14716224 + ((stage - 1)) << 2 = (14716224 + ((stage - 1)) << 2) & (((1152921504765685760) << (32-R8)) | ((1152921504765685760) << R8));
            14716224 + ((stage - 1)) << 2 = (14716224 + ((stage - 1)) << 2) & ((14716224 + ((stage - 1)) << 2) << 19);
            14716224 + ((stage - 1)) << 2 = (14716224 + ((stage - 1)) << 2) & ((IP) << 21);
            14716224 + ((stage - 1)) << 2 = (14716224 + ((stage - 1)) << 2) & (((((((((((((((14716224 + ((stage - 1)) << 2 & (R8) >> 14716224 + ((stage - 1)) << 2) & (R8) >> (14716224 + ((stage - 1)) << 2 & (R8) >> 14716224 + ((stage - 1)) << 2)) & (R8) >> ((14716224 + ((stage - 1) << (32-24)) | ((((((((((((((14716224 + ((stage - 1)) << 2 & (R8) >> 14716224 + ((stage - 1)) << 2) & (R8) >> (14716224 + ((stage - 1)) << 2 & (R8) >> 14716224 + ((stage - 1)) << 2)) & (R8) >> ((14716224 + ((stage - 1) << 24));
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Transform val_5 = public static BlockPuzzleMagic.GameBoardGenerator MonoSingleton<BlockPuzzleMagic.GameBoardGenerator>::get_Instance().__il2cppRuntimeField_1C.transform;
        typeof(UnityEngine.Transform[]).__il2cppRuntimeField_10 = public static BlockPuzzleMagic.GameBoardGenerator MonoSingleton<BlockPuzzleMagic.GameBoardGenerator>::get_Instance().__il2cppRuntimeField_1C;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.GameObject val_7 = gameObject;
        UnityEngine.Transform val_8 = transform;
        typeof(UnityEngine.Transform[]).__il2cppRuntimeField_14 = public static BlockPuzzleMagic.BlockShapeSpawner MonoSingleton<BlockPuzzleMagic.BlockShapeSpawner>::get_Instance();
        UnityEngine.Transform val_9 = this.handCursor.transform;
        typeof(UnityEngine.Transform[]).__il2cppRuntimeField_18 = this.handCursor;
        UnityEngine.Transform val_10 = this.tutorialTitle.transform;
        typeof(UnityEngine.Transform[]).__il2cppRuntimeField_1C = this.tutorialTitle;
        BlockPuzzleMagic.BBLGameplayUIHelper.ShowGameplayOverlay(contentToShow:  -2028557104);
        UnityEngine.GameObject val_11 = this.tutorialTitle.gameObject;
        val_46 = 0;
        this.tutorialTitle.SetActive(value:  true);
        UnityEngine.Transform val_12 = this.tutorialTitle.transform;
        UnityEngine.Vector3 val_13 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
        if(this.tutorialTitle != 0)
        {
                if(null != null)
        {
                this.tutorialTitle = 0;
        }
        
            val_46 = this.tutorialTitle;
        }
        
        PluginExtension.SetPosition2D(transform:  0, target:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        this.HideSpeechBubble();
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.zero;
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.zero;
        if(stage == 3)
        {
            goto label_35;
        }
        
        if(stage != 1)
        {
            goto label_51;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_21 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Vector3 val_22 = val_13.x.position;
        twelvegigs.Autopilot.AutopilotManager val_23 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        UnityEngine.GameObject val_24 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_C + 8 + 176.gameObject;
        UnityEngine.Transform val_25 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_C + 8 + 176.transform;
        UnityEngine.Vector3 val_26 = position;
        goto label_51;
        label_5:
        this.stepCompletedByPlayer = true;
        this.CloseWindow(immediate:  false);
        goto label_113;
    }
    private void ShowSpeechBubble(string header, string body, System.Nullable<UnityEngine.Vector3> worldPos, bool tipFaceUp = False, bool noButton = False, System.Nullable<UnityEngine.Color> maskBgColor)
    {
        var val_1;
        float val_2;
        bool val_4;
        var val_21;
        var val_22;
        float val_24;
        float val_29;
        float val_30;
        var val_32;
        var val_36;
        var val_37;
        float val_50;
        float val_51;
        var val_53;
        var val_54;
        var val_56;
        var val_57;
        var val_73;
        var val_74;
        var val_75;
        var val_76;
        var val_77;
        float val_78;
        var val_79;
        var val_80;
        var val_81;
        UnityEngine.UI.Image val_84;
        float val_85;
        float val_86;
        float val_87;
        UnityEngine.RectOffset val_3 = new UnityEngine.RectOffset(left:  30, right:  30, top:  10, bottom:  10);
        this.bubbleObject.SetActive(value:  true);
        this.groupNoButton.SetActive(value:  val_4);
        this.groupButton.SetActive(value:  val_4 ^ 1);
        if((System.String.IsNullOrEmpty(value:  header)) != false)
        {
                UnityEngine.GameObject val_7 = this.bubbleHeader.gameObject;
            this.bubbleHeader.SetActive(value:  false);
        }
        
        if((System.String.IsNullOrEmpty(value:  body)) == false)
        {
            goto label_8;
        }
        
        val_73 = 0;
        goto label_9;
        label_14:
        label_8:
        if(1 < this.bubbleLabel[0])
        {
            goto label_14;
        }
        
        goto label_15;
        label_21:
        UnityEngine.UI.Text val_74 = this.bubbleLabel[val_73];
        UnityEngine.GameObject val_9 = val_74.gameObject;
        val_74.SetActive(value:  false);
        val_73 = 1;
        label_9:
        if(val_73 < val_74)
        {
            goto label_21;
        }
        
        label_15:
        if((val_1 & 255) == 0)
        {
                UnityEngine.Color val_10 = val_2.Value;
            val_74 = 0;
            UnityEngine.Transform val_11 = this.bubbleObject.transform;
            if(this.bubbleObject != 0)
        {
                val_74 = mem[null + 32];
            if(this.bubbleObject == 0)
        {
                val_74 = 0;
        }
        
        }
        
            val_74 = 0;
            typeof(UnityEngine.Transform[]).__il2cppRuntimeField_10 = this.bubbleObject;
            BlockPuzzleMagic.BBLGameplayUIHelper.ShowGameplayOverlay(bgColor:  new UnityEngine.Color() {r = val_2}, contentToShow:  null);
        }
        else
        {
                UnityEngine.Transform val_12 = this.bubbleObject.transform;
            typeof(UnityEngine.Transform[]).__il2cppRuntimeField_10 = this.bubbleObject;
            BlockPuzzleMagic.BBLGameplayUIHelper.ShowGameplayOverlay(contentToShow:  -2028557104);
        }
        
        object val_13 = this.bubbleObject.GetComponentInChildren<System.Object>();
        UnityEngine.Canvas val_14 = this.bubbleObject.canvas;
        UnityEngine.Transform val_15 = this.bubbleObject.transform;
        if(this.bubbleObject == 0)
        {
            goto label_37;
        }
        
        val_75 = this.bubbleObject;
        if(null == null)
        {
            goto label_38;
        }
        
        label_37:
        val_75 = 0;
        label_38:
        if(maskBgColor.HasValue == false)
        {
            goto label_39;
        }
        
        UnityEngine.GameObject val_16 = this.bubbleObject.gameObject;
        UnityEngine.Transform val_17 = this.bubbleObject.transform;
        val_76 = this.bubbleObject;
        UnityEngine.Camera val_18 = this.bubbleObject.worldCamera;
        UnityEngine.Vector3 val_19 = val_2.Value;
        if(val_76 == 0)
        {
            goto label_43;
        }
        
        val_77 = null;
        if(null == val_77)
        {
            goto label_44;
        }
        
        label_43:
        val_76 = 0;
        label_44:
        UnityEngine.Vector2 val_20 = WorldToCanvasPosition(canvasRect:  null, canvasCamera:  0, position:  new UnityEngine.Vector3() {x = this.bubbleObject, y = val_2});
        val_78 = val_21;
        goto label_45;
        label_39:
        UnityEngine.Vector2 val_23 = UnityEngine.Vector2.zero;
        val_78 = val_24;
        label_45:
        UnityEngine.GameObject val_25 = this.bubbleObject.gameObject;
        val_79 = 0;
        UnityEngine.Transform val_26 = this.bubbleObject.transform;
        if(this.bubbleObject != 0)
        {
                if(null == null)
        {
            goto label_51;
        }
        
        }
        
        val_80 = 1152921504767283200;
        if(this.bubbleObject != 0)
        {
            goto label_52;
        }
        
        goto label_55;
        label_51:
        val_80 = 1152921504767283200;
        label_52:
        if(null != val_80)
        {
                val_79 = 0;
        }
        else
        {
                val_79 = this.bubbleObject;
        }
        
        label_55:
        UnityEngine.Rect val_27 = val_2.rect;
        UnityEngine.Vector2 val_28 = min;
        UnityEngine.GameObject val_31 = this.bubbleObject.gameObject;
        val_81 = 0;
        UnityEngine.Transform val_33 = this.bubbleObject.transform;
        if(this.bubbleObject != 0)
        {
                if(null == null)
        {
            goto label_59;
        }
        
        }
        
        if(this.bubbleObject != 0)
        {
            goto label_60;
        }
        
        goto label_63;
        label_59:
        label_60:
        if(null != null)
        {
                val_81 = 0;
        }
        else
        {
                val_81 = this.bubbleObject;
        }
        
        label_63:
        UnityEngine.Rect val_34 = rect;
        UnityEngine.Vector2 val_35 = max;
        if(val_32 != 0)
        {
            goto label_66;
        }
        
        UnityEngine.Vector2 val_38 = val_2.sizeDelta;
        float val_75 = val_24;
        val_75 = val_37 - val_75;
        if(val_75 <= 0)
        {
            goto label_66;
        }
        
        val_24 = 0;
        UnityEngine.Vector2 val_39 = new UnityEngine.Vector2(x:  val_75, y:  val_38.y);
        val_75.pivot = new UnityEngine.Vector2() {x = val_39.x, y = val_39.y};
        UnityEngine.GameObject val_40 = this.bubbleTipImageUp.gameObject;
        this.bubbleTipImageUp.SetActive(value:  false);
        UnityEngine.GameObject val_41 = this.bubbleTipImageDown.gameObject;
        this.bubbleTipImageDown.SetActive(value:  true);
        val_84 = this.bubbleTipImageDown;
        goto label_72;
        label_66:
        val_24 = 0;
        UnityEngine.Vector2 val_42 = new UnityEngine.Vector2(x:  val_35.x, y:  val_35.y);
        val_75.pivot = new UnityEngine.Vector2() {x = val_42.x, y = val_42.y};
        UnityEngine.GameObject val_43 = this.bubbleTipImageUp.gameObject;
        this.bubbleTipImageUp.SetActive(value:  true);
        UnityEngine.GameObject val_44 = this.bubbleTipImageDown.gameObject;
        this.bubbleTipImageDown.SetActive(value:  false);
        val_84 = this.bubbleTipImageUp;
        label_72:
        UnityEngine.Rect val_45 = val_42.x.rect;
        UnityEngine.Vector2 val_46 = min;
        UnityEngine.Vector2 val_47 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 7.179502E+37f, y = val_29}, b:  new UnityEngine.Vector2() {x = val_30, y = val_2});
        UnityEngine.Rect val_48 = rect;
        UnityEngine.Vector2 val_49 = max;
        UnityEngine.Vector2 val_52 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 7.179494E+37f, y = val_50}, b:  new UnityEngine.Vector2() {x = val_51, y = val_2});
        UnityEngine.Vector2 val_55 = UnityEngine.Vector2.zero;
        val_86 = val_56;
        val_87 = val_57;
        float val_76 = (float)left;
        val_76 = val_29 + val_76;
        if(val_3 > 0)
        {
                val_85 = val_86;
            float val_77 = (float)left;
            val_77 = val_29 + val_77;
            val_77 = val_77 - val_36;
            val_77 = val_77 + val_85;
            val_86 = val_77;
        }
        
        float val_78 = (float)right;
        val_78 = val_36 - val_78;
        if(val_3 < 0)
        {
                val_85 = val_86;
            float val_79 = (float)right;
            val_79 = val_36 - val_79;
            val_79 = val_54 - val_79;
            val_79 = val_85 - val_79;
            val_86 = val_79;
        }
        
        float val_80 = (float)bottom;
        val_80 = val_30 + val_80;
        if(val_3 > 0)
        {
                val_85 = val_87;
            float val_81 = (float)bottom;
            val_81 = val_30 + val_81;
            val_81 = val_81 - val_37;
            val_81 = val_81 + val_85;
            val_87 = val_81;
        }
        
        float val_82 = (float)top;
        val_82 = val_37 - val_82;
        if(val_3 < 0)
        {
                val_85 = val_87;
            float val_83 = (float)top;
            val_83 = val_37 - val_83;
            val_83 = val_53 - val_83;
            val_83 = val_85 - val_83;
            val_87 = val_83;
        }
        
        UnityEngine.Vector2 val_66 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 7.179519E+37f, y = val_2}, b:  new UnityEngine.Vector2() {x = val_78, y = val_86});
        if(val_75 != 0)
        {
                val_75.anchoredPosition = new UnityEngine.Vector2() {x = val_42.x, y = val_42.y};
        }
        else
        {
                val_75.anchoredPosition = new UnityEngine.Vector2() {x = val_42.x, y = val_42.y};
        }
        
        UnityEngine.Vector2 val_67 = sizeDelta;
        float val_84 = 0.8f;
        var val_86 = val_2;
        float val_85 = 0.5f;
        val_84 = val_22 * val_84;
        UnityEngine.Vector2 val_68 = anchoredPosition;
        val_85 = val_84 * val_85;
        val_86 = val_86 - val_29;
        UnityEngine.RectTransform val_69 = val_84.rectTransform;
        float val_70 = val_85 ^ 2147483648;
        val_37 = 0;
        val_36 = 0;
        UnityEngine.Vector2 val_72 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Clamp(value:  val_68.x, min:  val_68.y, max:  val_85), y:  val_68.y);
        val_84.anchoredPosition = new UnityEngine.Vector2() {x = val_72.x, y = val_72.y};
    }
    private void HideSpeechBubble()
    {
        this.bubbleObject.SetActive(value:  false);
    }
    private UnityEngine.Vector2 WorldToCanvasPosition(UnityEngine.RectTransform canvasRect, UnityEngine.Camera canvasCamera, UnityEngine.Vector3 position)
    {
        BBLFTUXDemoWindow val_4;
        float val_5;
        var val_7;
        var val_9;
        float val_17;
        UnityEngine.Vector3 val_2 = WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 7.413586E+37f});
        BBLFTUXDemoWindow val_18 = val_4;
        float val_19 = val_5;
        UnityEngine.Vector2 val_6 = sizeDelta;
        UnityEngine.Vector2 val_8 = sizeDelta;
        UnityEngine.Vector2 val_10 = sizeDelta;
        val_18 = val_18 * val_7;
        UnityEngine.Vector2 val_12 = pivot;
        val_19 = val_19 * val_9;
        UnityEngine.Vector2 val_14 = sizeDelta;
        UnityEngine.Vector2 val_16 = pivot;
        this = val_18;
        mem[1152921511021987668] = val_19;
        return new UnityEngine.Vector2() {x = val_17, y = val_16.y};
    }
    private void CloseWindow()
    {
        this.CloseWindow(immediate:  false);
    }
    private void CloseWindow(bool immediate)
    {
        var val_7;
        BlockPuzzleMagic.FtuxId val_8;
        var val_9;
        var val_10;
        val_7 = null;
        val_7 = null;
        val_8 = BBLFTUXDemoWindow.currentFtuxFlag;
        if(this.stepCompletedByPlayer == true)
        {
            goto label_3;
        }
        
        label_30:
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_40 = 1;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(2119313344 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static BlockPuzzleMagic.BBLGameplayUIController MonoSingleton<BlockPuzzleMagic.BBLGameplayUIController>::get_Instance().__il2cppRuntimeField_20.BlockRaycasts = true;
        }
        
        val_9 = null;
        val_9 = null;
        BBLFTUXDemoWindow.currentFtuxFlag = 0;
        System.Action val_5 = new System.Action(object:  2120406608, method:  new IntPtr(2120381584));
        BlockPuzzleMagic.BBLGameplayUIHelper.CloseGameplayOverlay(immediate:  immediate, onOverlayClosed:  7454720);
        return;
        label_3:
        val_7 = null;
        val_8 = BBLFTUXDemoWindow.currentFtuxFlag;
        if(val_8 == 1)
        {
            goto label_30;
        }
        
        val_7 = null;
        val_8 = BBLFTUXDemoWindow.currentFtuxFlag;
        if(val_8 == 2)
        {
            goto label_30;
        }
        
        val_8 = BBLFTUXDemoWindow.currentFtuxFlag;
        if(val_8 == 3)
        {
            goto label_30;
        }
        
        BestBlocksPlayer val_6 = BestBlocksPlayer.Instance;
        val_10 = null;
        val_10 = null;
        0.SetFtuxStatus(ftuxId:  0, completed:  true);
        goto label_30;
    }
    private void MovePointerAlong(UnityEngine.Vector3 startPos, UnityEngine.Vector3 endPos, float moveAlongDuration, DG.Tweening.LoopType moveAlongLoopType = 0, DG.Tweening.Ease moveAlongEaseType = 1)
    {
        DG.Tweening.Ease val_19;
        if(this.pointerMoveSeq != 0)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.pointerMoveSeq, complete:  false);
        }
        
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Transform val_2 = this.transform;
        UnityEngine.Vector3 val_3 = 0.position;
        UnityEngine.Vector3 val_5 = new UnityEngine.Vector3(x:  val_3.x, y:  val_3.y, z:  val_3.z);
        UnityEngine.GameObject val_6 = this.gameObject;
        UnityEngine.Transform val_7 = this.transform;
        UnityEngine.Vector3 val_8 = position;
        UnityEngine.Vector3 val_9 = new UnityEngine.Vector3(x:  val_8.x, y:  val_8.y, z:  val_8.z);
        UnityEngine.Transform val_10 = this.handCursor.transform;
        this.handCursor.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        UnityEngine.Color val_11 = color;
        UnityEngine.Color val_13 = color;
        UnityEngine.Color val_15 = color;
        UnityEngine.Color val_17 = new UnityEngine.Color(r:  val_15.r, g:  val_15.g, b:  val_15.b, a:  val_15.a);
        this.handCursor.color = new UnityEngine.Color() {r = val_17.r, g = val_17.g, b = val_17.b, a = val_17.r};
        UnityEngine.GameObject val_18 = this.handCursor.gameObject;
        this.handCursor.SetActive(value:  true);
        DG.Tweening.Sequence val_20 = DG.Tweening.DOTween.Sequence();
        this.pointerMoveSeq = 0;
        object val_21 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<System.Object>(t:  0, autoKillOnCompletion:  false);
        object val_22 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  this.pointerMoveSeq, loops:  0, loopType:  moveAlongEaseType);
        DG.Tweening.Tweener val_23 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.handCursor, endValue:  val_15.r, duration:  val_15.g);
        DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.pointerMoveSeq, t:  this.handCursor);
        UnityEngine.Transform val_25 = this.handCursor.transform;
        DG.Tweening.Tweener val_26 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.handCursor, endValue:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, duration:  val_15.r, snapping:  moveAlongLoopType);
        object val_27 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.handCursor, ease:  val_19);
        DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.pointerMoveSeq, t:  this.handCursor);
        DG.Tweening.Tweener val_29 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.handCursor, endValue:  val_15.r, duration:  val_15.g);
        DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.pointerMoveSeq, t:  this.handCursor);
        DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.pointerMoveSeq, interval:  val_15.r);
    }
    public void OnSkipTutorialClick()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SkipTutorial();
        this.CloseWindow(immediate:  false);
    }
    public BBLFTUXDemoWindow()
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
    private static BBLFTUXDemoWindow()
    {
    
    }
    private void <CloseWindow>b__30_0()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  2121102256, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }

}
