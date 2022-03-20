using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPILevelFailPopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Text title;
        private UnityEngine.UI.Text text;
        private UnityEngine.UI.Button extraTimeButton;
        private UnityEngine.UI.Button noBombsButton;
        private UnityEngine.GameObject bombIcon;
        private UnityEngine.GameObject timeIcon;
        private UnityEngine.UI.Text noBombsCoinCostText;
        private UnityEngine.UI.Text extraTimeCoinCostText;
        private UnityEngine.UI.Button freeCoinsButton;
        private UnityEngine.UI.Text starText;
        private UnityEngine.UI.Text timerText;
        private StatViewInstantiatior cstats;
        private SLC.MatchyPics.MPIGameplayController.State currentState;
        private int imageSet;
        
        // Methods
        public void Start()
        {
            UnityEngine.UI.Text val_27;
            bool val_28;
            UnityEngine.UI.Text val_29;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.currentState = public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance().__il2cppRuntimeField_14;
            val_27 = this.starText;
            this.imageSet = public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance().__il2cppRuntimeField_10 + 56;
            string val_4 = (public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance().__il2cppRuntimeField_10 + 32).ToString();
            var val_5 = ((public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance().__il2cppRuntimeField_10 + 32)) >> 5;
            val_5 = (val_5 >> 5) + (val_5 >> 31);
            val_5 = (val_5 << 4) - val_5;
            string val_7 = System.String.Format(format:  -1120761280, arg0:  13152256, arg1:  13152256);
            UnityEngine.GameObject val_8 = this.freeCoinsButton.gameObject;
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_28 = VideoAdsAllowed;
            this.freeCoinsButton.SetActive(value:  val_28);
            if(this.currentState == 3)
            {
                goto label_16;
            }
            
            if(this.currentState != 2)
            {
                goto label_17;
            }
            
            string val_11 = Localization.Localize(key:  785545232, defaultValue:  785545136, useSingularKey:  false);
            string val_12 = Localization.Localize(key:  785553664, defaultValue:  785553520, useSingularKey:  false);
            var val_13 = ((public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance().__il2cppRuntimeField_10 + 12 + 20 + (public static SLC.MatchyPics.MPIGameplayCon) >> 1;
            string val_14 = System.String.Format(format:  785553664, arg0:  13152256);
            val_28 = "timeout_level_fail";
            UnityEngine.GameObject val_15 = this.extraTimeButton.gameObject;
            this.extraTimeButton.SetActive(value:  true);
            UnityEngine.GameObject val_16 = this.noBombsButton.gameObject;
            this.noBombsButton.SetActive(value:  false);
            this.bombIcon.SetActive(value:  false);
            this.timeIcon.SetActive(value:  true);
            val_29 = this.extraTimeCoinCostText;
            twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            goto label_32;
            label_16:
            string val_18 = Localization.Localize(key:  785574352, defaultValue:  785574256, useSingularKey:  false);
            string val_19 = Localization.Localize(key:  785582768, defaultValue:  785582640, useSingularKey:  false);
            val_28 = "bombs_level_fail";
            UnityEngine.GameObject val_20 = this.extraTimeButton.gameObject;
            this.extraTimeButton.SetActive(value:  false);
            UnityEngine.GameObject val_21 = this.noBombsButton.gameObject;
            this.noBombsButton.SetActive(value:  true);
            this.bombIcon.SetActive(value:  true);
            this.timeIcon.SetActive(value:  false);
            val_29 = this.noBombsCoinCostText;
            twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            label_32:
            string val_23 = (public static SLC.MatchyPics.MPIDataController MonoSingleton<SLC.MatchyPics.MPIDataController>::get_Instance().__il2cppRuntimeField_C + 12 + 28).ToString();
            if(val_29 != 0)
            {
                    return;
            }
            
            return;
            label_17:
            UnityEngine.GameObject val_24 = this.gameObject;
            SLCWindow.CloseWindow(window:  785627360, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void Awake()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  785849952, method:  new IntPtr(785801376));
            this.extraTimeButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  785849952, method:  new IntPtr(785810592));
            this.noBombsButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  785849952, method:  new IntPtr(785819808));
            this.freeCoinsButton.m_OnClick.AddListener(call:  162246656);
            System.Action val_4 = new System.Action(object:  785849952, method:  new IntPtr(785824928));
            this.cstats.onCreated = null;
        }
        public void OnExtraTimeClick()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ExtraTimeSave();
            UnityEngine.GameObject val_2 = this.gameObject;
            SLCWindow.CloseWindow(window:  785990624, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        public void OnNoBombsClick()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            NoBombsSave();
            UnityEngine.GameObject val_2 = this.gameObject;
            SLCWindow.CloseWindow(window:  786102624, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        public void OnWatchVideoClick()
        {
            var val_6;
            System.Action val_8;
            GameBehavior val_1 = App.getBehavior;
            object val_3 = 0.GetComponent<System.Object>();
            val_6 = null;
            val_6 = null;
            val_8 = MPILevelFailPopup.<>c.<>9__18_0;
            if(val_8 == 0)
            {
                    val_8 = null;
                val_8 = new System.Action(object:  MPILevelFailPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(786190624));
                MPILevelFailPopup.<>c.<>9__18_0 = val_8;
            }
            
            mem[20] = val_8;
            UnityEngine.GameObject val_5 = this.gameObject;
            SLCWindow.CloseWindow(window:  786215776, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        public void OnCloseButton()
        {
            int val_11;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_11 = this.imageSet;
            if((ShowLossProgress(setIndex:  val_11)) != false)
            {
                    GameBehavior val_4 = App.getBehavior;
                if(0 != 0)
            {
                goto label_9;
            }
            
            }
            else
            {
                    GameBehavior val_6 = App.getBehavior;
                twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_11 = mem[public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance().__il2cppRuntimeField_10 + 32];
                val_11 = public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance().__il2cppRuntimeField_10 + 32;
                0.SetupStars(gainedStars:  val_11);
                twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                LevelFailed();
            }
            
            label_9:
            UnityEngine.GameObject val_10 = this.gameObject;
            SLCWindow.CloseWindow(window:  786328800, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void OnStoreButtonClicked()
        {
            var val_5;
            var val_6;
            System.Action val_8;
            var val_5 = 23097037;
            val_5 = 12529024 + val_5;
            if(val_5 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_5 = null;
            val_5 = null;
            PurchaseProxy.currentPurchasePoint = 125;
            GameBehavior val_1 = App.getBehavior;
            val_6 = null;
            val_6 = null;
            val_8 = MPILevelFailPopup.<>c.<>9__20_0;
            if(val_8 == 0)
            {
                    val_8 = null;
                val_8 = new System.Action(object:  MPILevelFailPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(786416800));
                MPILevelFailPopup.<>c.<>9__20_0 = val_8;
            }
            
            0.Init(outOfCredits:  false, onCloseAction:  7454720);
            UnityEngine.GameObject val_4 = this.gameObject;
            SLCWindow.CloseWindow(window:  786441824, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        public MPILevelFailPopup()
        {
        
        }
        private void <Awake>b__15_0()
        {
            object val_1 = this.cstats.<StatView>k__BackingField.storeButton.GetComponent<System.Object>();
            if((this.cstats.<StatView>k__BackingField.storeButton) != 0)
            {
                    object val_3 = this.cstats.<StatView>k__BackingField.storeButton.GetComponent<System.Object>();
                UnityEngine.Object.Destroy(obj:  this.cstats.<StatView>k__BackingField.storeButton);
            }
            
            this.cstats.<StatView>k__BackingField.storeButton.m_OnClick.RemoveAllListeners();
            UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  786687328, method:  new IntPtr(786662304));
            this.cstats.<StatView>k__BackingField.storeButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.GameObject val_5 = this.cstats.<StatView>k__BackingField.storeButton.gameObject;
            this.cstats.<StatView>k__BackingField.storeButton.SetActive(value:  true);
        }
    
    }

}
