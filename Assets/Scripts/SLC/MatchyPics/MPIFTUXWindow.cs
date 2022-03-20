using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPIFTUXWindow : FTUXDemoWindow
    {
        // Fields
        private UnityEngine.RectTransform boardMask;
        private UnityEngine.UI.Text stepText;
        private UnityEngine.GameObject chestTooltTip;
        private UnityEngine.UI.Button chestTooltTipButton;
        private SLC.MatchyPics.MPIFTUXWindow.Type <type>k__BackingField;
        
        // Properties
        public SLC.MatchyPics.MPIFTUXWindow.Type type { get; set; }
        
        // Methods
        public SLC.MatchyPics.MPIFTUXWindow.Type get_type()
        {
        
        }
        public void set_type(SLC.MatchyPics.MPIFTUXWindow.Type value)
        {
            this.<type>k__BackingField = value;
        }
        public void Start()
        {
            var val_4;
            var val_5;
            val_4 = this;
            UnityEngine.GameObject val_1 = this.stepText.gameObject;
            this.stepText.SetActive(value:  false);
            this.chestTooltTip.SetActive(value:  false);
            if(((this.<type>k__BackingField) - 1) < 2)
            {
                    val_5 = "InitTimedObjectFTUX";
            }
            else
            {
                    if((this.<type>k__BackingField) != 0)
            {
                    return;
            }
            
                val_5 = "InitFTUX";
            }
            
            R4.Invoke(methodName:  764828064, time:  null);
        }
        private void InitFTUX()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_3 = SetBoardMask(transform:  this.boardMask, type:  this.<type>k__BackingField);
            Add(item:  this.boardMask);
            UnityEngine.Transform val_4 = this.stepText.transform;
            Add(item:  this.stepText);
            UnityEngine.GameObject val_5 = this.stepText.gameObject;
            this.stepText.SetActive(value:  true);
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            BlockRaycasts = false;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Color val_8 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
            System.Nullable<UnityEngine.Color> val_9 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.r});
            SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_9.HasValue}, fadeInDuration:  null, fadeOutDuration:  null);
            twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            T[] val_13 = ToArray();
            ShowOverlay(contentToOverlay:  80883712);
        }
        private void InitTimedObjectFTUX()
        {
            var val_22;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_2 = SetBoardMask(transform:  this.boardMask, type:  this.<type>k__BackingField);
            if(val_2 == false)
            {
                    val_2 = this;
                this.CloseWindow();
            }
            
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            Add(item:  this.boardMask);
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Color val_5 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
            System.Nullable<UnityEngine.Color> val_6 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.r});
            SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_6.HasValue}, fadeInDuration:  null, fadeOutDuration:  null);
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            T[] val_8 = ToArray();
            ShowOverlay(contentToOverlay:  80883712);
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            BlockRaycasts = true;
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Interactable = true;
            UnityEngine.GameObject val_11 = this.gameObject;
            UnityEngine.Transform val_12 = this.transform;
            object val_13 = UnityEngine.Object.Instantiate<System.Object>(original:  mem[1152921513961923908], parent:  765142320);
            object val_14 = mem[1152921513961923908].GetComponentInChildren<System.Object>();
            if((this.<type>k__BackingField) == 1)
            {
                    "Match the collection item before it disappears!" = "Add a reward to your treasure chest before it disappears!";
            }
            
            if((this.<type>k__BackingField) == 1)
            {
                    "ftux_collection_timed_object" = "ftux_chest_timed_object";
            }
            
            string val_15 = Localization.Localize(key:  765118064, defaultValue:  765117696, useSingularKey:  false);
            UnityEngine.GameObject val_16 = mem[1152921513961923908].gameObject;
            mem[1152921513961923908].SetActive(value:  true);
            twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Transform val_18 = mem[1152921513961923908].transform;
            typeof(UnityEngine.Transform[]).__il2cppRuntimeField_10 = mem[1152921513961923908];
            ShowOverlay(contentToOverlay:  -2028557104);
            UnityEngine.Transform val_19 = mem[1152921513961923908].transform;
            UnityEngine.Vector3 val_20 = val_6.HasValue.localPosition;
            UnityEngine.Vector2 val_21 = sizeDelta;
            float val_27 = 0.5f;
            val_27 = val_22 * val_27;
            UnityEngine.Vector3 val_23 = new UnityEngine.Vector3(x:  val_27, y:  val_21.y);
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 1.761698E-11f, y = val_6.HasValue}, b:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.x, z = val_23.y});
            mem[1152921513961923908].localPosition = new UnityEngine.Vector3();
            if((this.<type>k__BackingField) != 2)
            {
                    if((this.<type>k__BackingField) != 1)
            {
                    return;
            }
            
                twelvegigs.Autopilot.AutopilotManager val_25 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                CompletedFtux();
                return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_26 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            CompletedFtux();
        }
        public void SetupStep(int step)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = 35638176;
            if(step == 3)
            {
                goto label_1;
            }
            
            if(step == 2)
            {
                goto label_2;
            }
            
            if(step != 1)
            {
                    return;
            }
            
            val_4 = "Tap a pair of matching pics to remove them.";
            val_5 = "mpi_ftux_step_1";
            goto label_5;
            label_1:
            val_4 = "To match pics, they must be connected by 3 lines or less";
            val_5 = "mpi_ftux_step_3";
            goto label_5;
            label_2:
            val_4 = "Remove all pics to clear the level!";
            val_5 = "mpi_ftux_step_2";
            label_5:
            string val_1 = Localization.Localize(key:  765243328, defaultValue:  765243184, useSingularKey:  false);
            if(this.stepText == 0)
            {
                
            }
        
        }
        public void CloseWindow()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            CloseOverlay(forceImmediate:  true, onClosed:  0);
            UnityEngine.GameObject val_2 = this.gameObject;
            SLCWindow.CloseWindow(window:  765387632, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        public MPIFTUXWindow()
        {
        
        }
    
    }

}
