using UnityEngine;

namespace SLC.Minigames.ImageQuiz
{
    public class ImageQuizUIController : MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizUIController>
    {
        // Fields
        private UnityEngine.CanvasGroup gameplayUIGroup;
        private SLC.Minigames.ImageQuiz.ImageQuizClueDisplay clueImageDisplay;
        private SLC.Minigames.ImageQuiz.ImageQuizDisplayWord wordInputDisplay;
        private SLC.Minigames.ImageQuiz.ImageQuizLetterButtonGrid letterButtonGrid;
        private UnityEngine.UI.Button hintButton;
        private UnityEngine.UI.Text hintCostLabel;
        private SLC.Minigames.MinigamesCheckpointSlider checkpointSlider;
        private SLC.Minigames.ImageQuiz.ImageQuizLoadingIndicator loadingIndicator;
        private UnityEngine.GameObject pauseOverlay;
        private UnityEngine.UI.Button pauseMenuButtonQuit;
        private UnityEngine.UI.Button pauseMenuButtonResume;
        private UnityEngine.GameObject ftuxMessageBlurb;
        private SLC.Minigames.ImageQuiz.ImageQuizFTUXPointer ftuxPointerPrefab;
        private SLC.Minigames.ImageQuiz.ImageQuizFTUXPointer ftuxPointer;
        private bool <IsGameInputAllowed>k__BackingField;
        private int previousFTUXStep;
        private DG.Tweening.Tween ftuxPointerShowTween;
        
        // Properties
        public SLC.Minigames.ImageQuiz.ImageQuizDisplayWord WordInputDisplay { get; }
        public SLC.Minigames.ImageQuiz.ImageQuizLetterButtonGrid LetterButtonGrid { get; }
        public bool IsGameInputAllowed { get; set; }
        
        // Methods
        public SLC.Minigames.ImageQuiz.ImageQuizDisplayWord get_WordInputDisplay()
        {
        
        }
        public SLC.Minigames.ImageQuiz.ImageQuizLetterButtonGrid get_LetterButtonGrid()
        {
        
        }
        public bool get_IsGameInputAllowed()
        {
            return (bool)this.<IsGameInputAllowed>k__BackingField;
        }
        private void set_IsGameInputAllowed(bool value)
        {
            this.<IsGameInputAllowed>k__BackingField = value;
        }
        public override void InitMonoSingleton()
        {
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_2 = new System.Action(object:  1077139536, method:  new IntPtr(1077078672));
            System.Delegate val_3 = System.Delegate.Combine(a:  public static SLC.Minigames.ImageQuiz.ImageQuizDataManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizDataManager>::get_Instance().__il2cppRuntimeField_28, b:  7454720);
            val_30 = public static SLC.Minigames.ImageQuiz.ImageQuizDataManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizDataManager>::get_Instance().__il2cppRuntimeField_28;
            if(val_30 != 0)
            {
                    if(val_30 == null)
            {
                goto label_6;
            }
            
            }
            
            val_30 = 0;
            label_6:
            public static SLC.Minigames.ImageQuiz.ImageQuizDataManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizDataManager>::get_Instance().__il2cppRuntimeField_28 = val_30;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<System.Boolean> val_5 = new System.Action<System.Boolean>(object:  1077139536, method:  new IntPtr(1077079696));
            System.Delegate val_6 = System.Delegate.Combine(a:  public static SLC.Minigames.ImageQuiz.ImageQuizDataManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizDataManager>::get_Instance().__il2cppRuntimeField_2C, b:  7401472);
            val_31 = public static SLC.Minigames.ImageQuiz.ImageQuizDataManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizDataManager>::get_Instance().__il2cppRuntimeField_2C;
            if(val_31 != 0)
            {
                    if(val_31 == null)
            {
                goto label_10;
            }
            
            }
            
            val_31 = 0;
            label_10:
            public static SLC.Minigames.ImageQuiz.ImageQuizDataManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizDataManager>::get_Instance().__il2cppRuntimeField_2C = val_31;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_8 = new System.Action(object:  1077139536, method:  new IntPtr(1077080720));
            System.Delegate val_9 = System.Delegate.Combine(a:  public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_14, b:  7454720);
            val_32 = public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_14;
            if(val_32 != 0)
            {
                    if(val_32 == null)
            {
                goto label_16;
            }
            
            }
            
            val_32 = 0;
            label_16:
            public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_14 = val_32;
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_11 = new System.Action(object:  1077139536, method:  new IntPtr(1077081744));
            System.Delegate val_12 = System.Delegate.Combine(a:  public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_1C, b:  7454720);
            val_33 = public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_1C;
            if(val_33 != 0)
            {
                    if(val_33 == null)
            {
                goto label_20;
            }
            
            }
            
            val_33 = 0;
            label_20:
            public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_1C = val_33;
            twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_14 = new System.Action(object:  1077139536, method:  new IntPtr(1077082768));
            System.Delegate val_15 = System.Delegate.Combine(a:  public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_18, b:  7454720);
            val_34 = public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_18;
            if(val_34 != 0)
            {
                    if(val_34 == null)
            {
                goto label_24;
            }
            
            }
            
            val_34 = 0;
            label_24:
            public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_18 = val_34;
            twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_17 = new System.Action(object:  1077139536, method:  new IntPtr(1077083792));
            System.Delegate val_18 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_6C, b:  7454720);
            val_35 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_6C;
            if(val_35 != 0)
            {
                    if(val_35 == null)
            {
                goto label_30;
            }
            
            }
            
            val_35 = 0;
            label_30:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_6C = val_35;
            twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_20 = new System.Action(object:  1077139536, method:  new IntPtr(1077084816));
            System.Delegate val_21 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64, b:  7454720);
            val_36 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64;
            if(val_36 != 0)
            {
                    if(val_36 == null)
            {
                goto label_34;
            }
            
            }
            
            val_36 = 0;
            label_34:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64 = val_36;
            twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_23 = new System.Action(object:  1077139536, method:  new IntPtr(1077085840));
            System.Delegate val_24 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_70, b:  7454720);
            val_37 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_70;
            if(val_37 != 0)
            {
                    if(val_37 == null)
            {
                goto label_38;
            }
            
            }
            
            val_37 = 0;
            label_38:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_70 = val_37;
            twelvegigs.Autopilot.AutopilotManager val_25 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<System.Boolean> val_26 = new System.Action<System.Boolean>(object:  1077139536, method:  new IntPtr(1077086864));
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_78 = null;
            UnityEngine.Events.UnityAction val_27 = new UnityEngine.Events.UnityAction(object:  1077139536, method:  new IntPtr(1077096080));
            this.hintButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_28 = new UnityEngine.Events.UnityAction(object:  1077139536, method:  new IntPtr(1077105296));
            this.pauseMenuButtonResume.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_29 = new UnityEngine.Events.UnityAction(object:  1077139536, method:  new IntPtr(1077114512));
            this.pauseMenuButtonQuit.m_OnClick.AddListener(call:  162246656);
        }
        private void OnDestroy()
        {
            var val_34;
            var val_35;
            System.Action<System.Boolean> val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_34 = 1152921504765685760;
            if(1056919520 == 0)
            {
                goto label_5;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_4 = new System.Action(object:  1077276112, method:  new IntPtr(1077078672));
            System.Delegate val_5 = System.Delegate.Remove(source:  public static SLC.Minigames.ImageQuiz.ImageQuizDataManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizDataManager>::get_Instance().__il2cppRuntimeField_28, value:  7454720);
            val_35 = public static SLC.Minigames.ImageQuiz.ImageQuizDataManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizDataManager>::get_Instance().__il2cppRuntimeField_28;
            if(val_35 != 0)
            {
                    if(val_35 == null)
            {
                goto label_11;
            }
            
            }
            
            val_35 = 0;
            label_11:
            public static SLC.Minigames.ImageQuiz.ImageQuizDataManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizDataManager>::get_Instance().__il2cppRuntimeField_28 = val_35;
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_36 = null;
            val_36 = new System.Action<System.Boolean>(object:  1077276112, method:  new IntPtr(1077079696));
            System.Delegate val_8 = System.Delegate.Remove(source:  public static SLC.Minigames.ImageQuiz.ImageQuizDataManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizDataManager>::get_Instance().__il2cppRuntimeField_2C, value:  7401472);
            val_37 = public static SLC.Minigames.ImageQuiz.ImageQuizDataManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizDataManager>::get_Instance().__il2cppRuntimeField_2C;
            if(val_37 != 0)
            {
                    if(val_37 == null)
            {
                goto label_15;
            }
            
            }
            
            val_37 = 0;
            label_15:
            public static SLC.Minigames.ImageQuiz.ImageQuizDataManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizDataManager>::get_Instance().__il2cppRuntimeField_2C = val_37;
            label_5:
            val_38 = 1152921504901095424;
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(1050323136 == 0)
            {
                goto label_20;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_12 = new System.Action(object:  1077276112, method:  new IntPtr(1077080720));
            System.Delegate val_13 = System.Delegate.Remove(source:  public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_14, value:  7454720);
            val_39 = public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_14;
            if(val_39 != 0)
            {
                    if(val_39 == null)
            {
                goto label_26;
            }
            
            }
            
            val_39 = 0;
            label_26:
            public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_14 = val_39;
            twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_15 = new System.Action(object:  1077276112, method:  new IntPtr(1077081744));
            System.Delegate val_16 = System.Delegate.Remove(source:  public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_1C, value:  7454720);
            val_40 = public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_1C;
            if(val_40 != 0)
            {
                    if(val_40 == null)
            {
                goto label_30;
            }
            
            }
            
            val_40 = 0;
            label_30:
            public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_1C = val_40;
            twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_36 = null;
            val_36 = new System.Action(object:  1077276112, method:  new IntPtr(1077082768));
            System.Delegate val_19 = System.Delegate.Remove(source:  public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_18, value:  7454720);
            val_38 = public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_18;
            if(val_38 != 0)
            {
                    if(val_38 == null)
            {
                goto label_34;
            }
            
            }
            
            val_38 = 0;
            label_34:
            public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_18 = val_38;
            label_20:
            twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1745297776) == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_23 = new System.Action(object:  1077276112, method:  new IntPtr(1077083792));
            System.Delegate val_24 = System.Delegate.Remove(source:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_6C, value:  7454720);
            val_41 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_6C;
            if(val_41 != 0)
            {
                    if(val_41 == null)
            {
                goto label_45;
            }
            
            }
            
            val_41 = 0;
            label_45:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_6C = val_41;
            twelvegigs.Autopilot.AutopilotManager val_25 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_26 = new System.Action(object:  1077276112, method:  new IntPtr(1077084816));
            System.Delegate val_27 = System.Delegate.Remove(source:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64, value:  7454720);
            val_42 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64;
            if(val_42 != 0)
            {
                    if(val_42 == null)
            {
                goto label_49;
            }
            
            }
            
            val_42 = 0;
            label_49:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64 = val_42;
            twelvegigs.Autopilot.AutopilotManager val_28 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_29 = new System.Action(object:  1077276112, method:  new IntPtr(1077085840));
            System.Delegate val_30 = System.Delegate.Remove(source:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_70, value:  7454720);
            val_43 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_70;
            if(val_43 != 0)
            {
                    if(val_43 == null)
            {
                goto label_53;
            }
            
            }
            
            val_43 = 0;
            label_53:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_70 = val_43;
            twelvegigs.Autopilot.AutopilotManager val_31 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_34 = 1152921504614248448;
            val_36 = null;
            val_36 = new System.Action<System.Boolean>(object:  1077276112, method:  new IntPtr(1077086864));
            System.Delegate val_33 = System.Delegate.Remove(source:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_78, value:  7401472);
            val_44 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_78;
            if(val_44 != 0)
            {
                    if(val_44 == null)
            {
                goto label_57;
            }
            
            }
            
            val_44 = 0;
            label_57:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_78 = val_44;
        }
        private void Start()
        {
            decimal val_1 = SLC.Minigames.ImageQuiz.ImageQuizEcon.HintCost;
            GameEcon val_2 = App.getGameEcon;
            string val_3 = ToString(format:  null);
            this.checkpointSlider.UpdateUI();
        }
        private void OnMinigameDataLoadBegin()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_10) != 0)
            {
                    return;
            }
            
            R4 + 44.SetActive(value:  false);
            R4 + 40.Show(isVisible:  true);
            R4 + 12.alpha = null;
        }
        private void OnMinigameDataLoadComplete(bool isSuccess)
        {
            this.loadingIndicator.Show(isVisible:  false);
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_3 = HasLevelData();
            if(val_3 != false)
            {
                    return;
            }
            
            val_3.ShowLoadErrorMessage();
        }
        private void ShowLoadErrorMessage()
        {
            System.String[] val_5;
            var val_6;
            var val_7;
            System.Func<System.Boolean> val_9;
            val_5 = 1152921514096610704;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(899829136 == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_6 = public static SLC.Minigames.MinigamesUIController MonoSingleton<SLC.Minigames.MinigamesUIController>::get_Instance();
            typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
            val_5 = null;
            typeof(System.String[]).__il2cppRuntimeField_10 = "HOME";
            typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
            val_7 = null;
            val_7 = null;
            val_9 = ImageQuizUIController.<>c.<>9__27_0;
            if(val_9 == 0)
            {
                    val_9 = null;
                val_9 = new System.Func<System.Boolean>(object:  ImageQuizUIController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(1077732880));
                val_6 = val_6;
                ImageQuizUIController.<>c.<>9__27_0 = val_9;
            }
            
            typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_9;
            ShowMessage(titleTxt:  -1598955408, messageTxt:  1015153136, shownButtons:  1054454320, buttonTexts:  val_5, showClose:  false, buttonCallbacks:  null);
        }
        private void OnMinigameBegin()
        {
            this.DisplayLevel();
        }
        private void OnMinigameContinue()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ConsumeCurrentLevel();
            this.pauseOverlay.SetActive(value:  false);
            this.pauseOverlay.PlayMinigame();
        }
        private void OnLevelComplete()
        {
            this.<IsGameInputAllowed>k__BackingField = false;
            System.Collections.IEnumerator val_1 = this.OnLevelCompleteCoroutine();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  1078102096);
        }
        private System.Collections.IEnumerator OnLevelCompleteCoroutine()
        {
            object val_1 = new System.Object();
            typeof(ImageQuizUIController.<OnLevelCompleteCoroutine>d__31).__il2cppRuntimeField_8 = 0;
            typeof(ImageQuizUIController.<OnLevelCompleteCoroutine>d__31).__il2cppRuntimeField_10 = this;
        }
        private void OnMinigameEnd()
        {
            System.Collections.IEnumerator val_1 = this.OnMinigameEndCoroutine();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  1078326096);
        }
        private System.Collections.IEnumerator OnMinigameEndCoroutine()
        {
            object val_1 = new System.Object();
            typeof(ImageQuizUIController.<OnMinigameEndCoroutine>d__33).__il2cppRuntimeField_8 = 0;
            typeof(ImageQuizUIController.<OnMinigameEndCoroutine>d__33).__il2cppRuntimeField_10 = this;
        }
        private void OnHintButtonClicked()
        {
            int val_13;
            var val_16;
            var val_17;
            var val_18;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((this.<IsGameInputAllowed>k__BackingField) == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayButtonSound(clipIndex:  0, volumeScale:  null);
            Player val_3 = App.Player;
            decimal val_4 = SLC.Minigames.ImageQuiz.ImageQuizEcon.HintCost;
            if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal())) == false)
            {
                goto label_14;
            }
            
            Player val_6 = App.Player;
            val_16 = 2621448;
            if(val_16 == 0)
            {
                goto label_18;
            }
            
            val_17 = 35143856;
            goto label_19;
            label_14:
            var val_15 = 21825509;
            val_15 = 13800552 + val_15;
            if(val_15 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_18 = null;
            val_18 = null;
            PurchaseProxy.currentPurchasePoint = 24;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_8 = ShowUGUIMonolith<System.Object>(showNext:  true);
            Init(outOfCredits:  true, onCloseAction:  0);
            return;
            label_18:
            val_16 = 52;
            val_17 = 6;
            label_19:
            mem[52] = 7;
            decimal val_9 = SLC.Minigames.ImageQuiz.ImageQuizEcon.HintCost;
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_11 = CurrentMinigameName;
            string val_12 = System.String.Format(format:  932569136, arg0:  -1745297776);
            bool val_14 = CurrencyController.DebitBalance(value:  new System.Decimal() {flags = val_13}, source:  "MG {0} HINT", externalParams:  0, animated:  false);
            this.wordInputDisplay.GiveLetterHint();
        }
        private void OnPauseClicked()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayButtonSound(clipIndex:  0, volumeScale:  null);
            this.pauseOverlay.SetActive(value:  true);
        }
        private void OnResumeClicked()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayButtonSound(clipIndex:  0, volumeScale:  null);
            this.pauseOverlay.SetActive(value:  false);
        }
        private void OnQuitClicked()
        {
            this.gameplayUIGroup.alpha = null;
            this.pauseOverlay.SetActive(value:  false);
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayButtonSound(clipIndex:  0, volumeScale:  null);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowGameOver();
        }
        private void TogglePopup(bool windowShowing)
        {
            if(windowShowing == true)
            {
                    1f = 0;
            }
            
            this.gameplayUIGroup.alpha = 0f;
        }
        public void PlayMinigame()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(HasLevelData() != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                BeginGame();
                return;
            }
            
            UnityEngine.Debug.LogError(message:  1079135248);
        }
        private void DisplayLevel()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SLC.Minigames.ImageQuiz.ImageQuizLevelInfo val_2 = GetCurrentQuizLevel();
            this.clueImageDisplay.ToggleResultOverlay(isVisible:  false, isCorrect:  true);
            this.wordInputDisplay.Initialize(_numberOfLetters:  public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_8 + 8);
            string val_3 = LetterPool;
            this.letterButtonGrid.Initialize(letters:  1050323136);
            this.clueImageDisplay.UpdateClueDisplay();
            this.checkpointSlider.UpdateUI();
            this.gameplayUIGroup.alpha = null;
            this.<IsGameInputAllowed>k__BackingField = true;
            UnityEngine.GameObject val_4 = this.hintButton.gameObject;
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_C) > 0)
            {
                    0 = 1;
            }
            
            this.hintButton.SetActive(value:  true);
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance()) != 0)
            {
                    return;
            }
        
        }
        private void StartFTUX()
        {
            SLC.Minigames.ImageQuiz.ImageQuizFTUXPointer val_9;
            System.Action val_10;
            if(this.ftuxPointer == 0)
            {
                    UnityEngine.Transform val_2 = this.gameplayUIGroup.transform;
                object val_3 = UnityEngine.Object.Instantiate<System.Object>(original:  this.ftuxPointerPrefab, parent:  this.gameplayUIGroup);
                val_9 = this.ftuxPointerPrefab;
                this.ftuxPointer = this.ftuxPointerPrefab;
            }
            else
            {
                    val_9 = this.ftuxPointer;
            }
            
            UnityEngine.GameObject val_4 = val_9.gameObject;
            val_9.SetActive(value:  false);
            System.Action val_5 = new System.Action(object:  1079467392, method:  new IntPtr(1079442368));
            System.Delegate val_6 = System.Delegate.Combine(a:  this.wordInputDisplay.OnInputProcessed, b:  7454720);
            val_10 = this.wordInputDisplay.OnInputProcessed;
            if(val_10 != 0)
            {
                    if(null == null)
            {
                goto label_13;
            }
            
            }
            
            val_10 = 0;
            label_13:
            this.wordInputDisplay.OnInputProcessed = val_10;
            this.previousFTUXStep = 0;
            DG.Tweening.TweenCallback val_7 = new DG.Tweening.TweenCallback(object:  1079467392, method:  new IntPtr(1079442368));
            DG.Tweening.Tween val_8 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1036831949, ignoreTimeScale:  false);
        }
        public void EndFTUX()
        {
            System.Action val_5;
            System.Action val_1 = new System.Action(object:  1079628544, method:  new IntPtr(1079442368));
            System.Delegate val_2 = System.Delegate.Remove(source:  this.wordInputDisplay.OnInputProcessed, value:  7454720);
            val_5 = this.wordInputDisplay.OnInputProcessed;
            if(val_5 != 0)
            {
                    if(null == null)
            {
                goto label_4;
            }
            
            }
            
            val_5 = 0;
            label_4:
            this.wordInputDisplay.OnInputProcessed = val_5;
            UnityEngine.GameObject val_3 = this.ftuxMessageBlurb.gameObject;
            this.ftuxMessageBlurb.SetActive(value:  false);
            UnityEngine.GameObject val_4 = this.ftuxPointer.gameObject;
            this.ftuxPointer.SetActive(value:  false);
            if(this.ftuxPointer.pointerSeq == 0)
            {
                    return;
            }
            
            DG.Tweening.TweenExtensions.Kill(t:  this.ftuxPointer.pointerSeq, complete:  false);
        }
        private void ShowFTUXStep()
        {
            if(this.ftuxPointerShowTween != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.ftuxPointerShowTween, complete:  false);
            }
            
            UnityEngine.GameObject val_1 = this.ftuxMessageBlurb.gameObject;
            this.ftuxMessageBlurb.SetActive(value:  true);
            if(this.previousFTUXStep == this.wordInputDisplay.caretPosition)
            {
                    this.EndFTUX();
                return;
            }
            
            this.FtuxHighlightAction(letterIndex:  this.wordInputDisplay.caretPosition);
            this.previousFTUXStep = this.wordInputDisplay.caretPosition;
        }
        private void FtuxHighlightAction(int letterIndex)
        {
            var val_13;
            SLC.Minigames.ImageQuiz.ImageQuizFTUXPointer val_14;
            object val_1 = new System.Object();
            typeof(ImageQuizUIController.<>c__DisplayClass46_0).__il2cppRuntimeField_8 = this;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SLC.Minigames.ImageQuiz.ImageQuizLevelInfo val_3 = GetCurrentQuizLevel();
            string val_5 = public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance().__il2cppRuntimeField_8.Chars[letterIndex].ToString();
            SLC.Minigames.ImageQuiz.ImageQuizLetterButton val_6 = this.letterButtonGrid.GetButton(letter:  1079948026, getOnlyUnusedButtons:  true);
            typeof(ImageQuizUIController.<>c__DisplayClass46_0).__il2cppRuntimeField_C = this.letterButtonGrid;
            this.letterButtonGrid.SetHighlight(state:  1);
            val_13 = 0;
            this.letterButtonGrid + 12.interactable = true;
            this.wordInputDisplay.<AllowErase>k__BackingField = false;
            val_14 = this.ftuxPointer;
            UnityEngine.GameObject val_9 = val_14.gameObject;
            if(letterIndex != 0)
            {
                    val_14.SetActive(value:  false);
                val_14 = null;
                val_14 = new DG.Tweening.TweenCallback(object:  456441856, method:  new IntPtr(1079930944));
                DG.Tweening.Tween val_11 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1077936128, ignoreTimeScale:  false);
                this.ftuxPointerShowTween = 1077936128;
                return;
            }
            
            val_14.SetActive(value:  true);
            UnityEngine.GameObject val_12 = typeof(ImageQuizUIController.<>c__DisplayClass46_0).__il2cppRuntimeField_C.gameObject;
            this.ftuxPointer.PointAt(targetObj:  typeof(ImageQuizUIController.<>c__DisplayClass46_0).__il2cppRuntimeField_C, flipPointerX:  false, flipPointerY:  false);
        }
        public ImageQuizUIController()
        {
            this.previousFTUXStep = 0;
        }
    
    }

}
