using UnityEngine;

namespace SLC.Wordlicious
{
    public class WOLHintButtonDemoPopup : WGHintButtonDemoPopup
    {
        // Fields
        protected UnityEngine.UI.Text messageText;
        
        // Methods
        protected virtual void OnDestroy()
        {
            System.Action val_11;
            var val_12;
            var val_13;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_11 = 1152921504765685760;
            if(2124183120 != 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  704137888, method:  new IntPtr(4170710432));
                public static AdsUIController MonoSingleton<AdsUIController>::get_Instance().__il2cppRuntimeField_1C.RemoveListener(call:  162246656);
            }
            
            val_12 = 1152921511437380768;
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1759400800) == 0)
            {
                goto label_14;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_11 = null;
            val_11 = new System.Action(object:  704137888, method:  new IntPtr(704112864));
            System.Delegate val_9 = System.Delegate.Remove(source:  public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_50, value:  7454720);
            val_12 = public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_50;
            if(val_12 != 0)
            {
                    if(val_12 == null)
            {
                goto label_20;
            }
            
            }
            
            val_12 = 0;
            label_20:
            public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_50 = val_12;
            label_14:
            val_13 = null;
            val_13 = null;
            System.Type val_10 = this.GetType();
            EnumerableExtentions.SetOrAdd<System.Type, System.Boolean>(dic:  WGHintButtonDemoPopup.shownTypeDict, key:  704137888, newValue:  false);
        }
        protected virtual void Start()
        {
            var val_15;
            var val_19;
            var val_20;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  704254256, method:  new IntPtr(4170710432));
            public static AdsUIController MonoSingleton<AdsUIController>::get_Instance().__il2cppRuntimeField_1C.AddListener(call:  162246656);
            val_19 = null;
            val_19 = null;
            System.Type val_3 = this.GetType();
            EnumerableExtentions.SetOrAdd<System.Type, System.Boolean>(dic:  WGHintButtonDemoPopup.shownTypeDict, key:  704254256, newValue:  true);
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_5 = new System.Action(object:  704254256, method:  new IntPtr(704112864));
            System.Delegate val_6 = System.Delegate.Combine(a:  public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_50, b:  7454720);
            val_20 = public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_50;
            if(val_20 != 0)
            {
                    if(val_20 == null)
            {
                goto label_12;
            }
            
            }
            
            val_20 = 0;
            label_12:
            public static SLC.Wordlicious.WOLMainController MonoSingleton<SLC.Wordlicious.WOLMainController>::get_Instance().__il2cppRuntimeField_50 = val_20;
            string val_7 = Localization.Localize(key:  704230128, defaultValue:  704229984, useSingularKey:  false);
            GameEcon val_8 = App.getGameEcon;
            string val_9 = System.String.Format(format:  704230128, arg0:  13152256);
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            BlockRaycasts = true;
            Interactable = true;
            twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Color val_13 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
            System.Nullable<UnityEngine.Color> val_14 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {r = val_13.r, g = val_13.g, b = val_13.b, a = val_13.r});
            SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_14.HasValue}, fadeInDuration:  null, fadeOutDuration:  null);
            twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Transform val_18 = val_15.transform;
            typeof(UnityEngine.Transform[]).__il2cppRuntimeField_10 = val_15;
            typeof(UnityEngine.Transform[]).__il2cppRuntimeField_14 = 1041865114;
            ShowOverlay(contentToOverlay:  -2028557104);
        }
        protected virtual void SetupButton()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.GameObject val_2 = HintButtonGroup;
            mem[1152921513901151948] = public static AdsUIController MonoSingleton<AdsUIController>::get_Instance();
        }
        protected void OnHintUsed()
        {
            this.OnClick_UseHint();
        }
        public WOLHintButtonDemoPopup()
        {
        
        }
    
    }

}
