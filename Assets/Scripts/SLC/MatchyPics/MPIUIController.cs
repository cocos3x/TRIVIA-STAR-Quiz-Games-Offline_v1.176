using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPIUIController : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject uiParent;
        private UnityEngine.GameObject ftuxGroup;
        private UnityEngine.UI.Button pauseButton;
        private StatViewInstantiatior coinStatViewInstantiator;
        private UnityEngine.GameObject powerUpsGroup;
        private UnityEngine.UI.Text levelText;
        private UnityEngine.UI.Text timer;
        private UnityEngine.GameObject powerupsTooltip;
        private UnityEngine.UI.Text powerupsTooltipText;
        private UnityEngine.UI.Text extraTimeText;
        public SLC.MatchyPics.MPICollectionUI collectionUI;
        private int currentStep;
        private SLC.MatchyPics.MPIFTUXWindow ftuxWindow;
        private int pUpReminderTime;
        private bool inFTUX;
        private bool animExtraTime;
        
        // Methods
        public void Start()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -852051584, method:  new IntPtr(798297488));
            this.pauseButton.m_OnClick.AddListener(call:  162246656);
        }
        public void Init()
        {
            var val_14;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.pUpReminderTime = public static SLC.MatchyPics.MPIDataController MonoSingleton<SLC.MatchyPics.MPIDataController>::get_Instance().__il2cppRuntimeField_C + 12 + 44;
            string val_2 = Localization.Localize(key:  798422944, defaultValue:  798422800, useSingularKey:  false);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_4 = System.String.Format(format:  798422944, arg0:  13152256);
            GameBehavior val_5 = App.getBehavior;
            string val_6 = Localization.Localize(key:  -1672741904, defaultValue:  2127161280, useSingularKey:  false);
            Player val_7 = App.Player;
            string val_8 = System.String.Format(format:  -1672741904, arg0:  13152256);
            string val_9 = System.String.Format(format:  null, arg0:  -1672741904);
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_11 = TimeFormat(seconds:  public static SLC.MatchyPics.MPIBoardController MonoSingleton<SLC.MatchyPics.MPIBoardController>::get_Instance().__il2cppRuntimeField_C + 36);
            val_14 = 0;
            Player val_12 = App.Player;
            if(0 >= 2)
            {
                    Player val_13 = App.Player;
                if(0 < 8)
            {
                    val_14 = 1;
            }
            
            }
            
            this.ftuxGroup.SetActive(value:  true);
            this.SetupCollections();
        }
        public void UpdateTimer(int remainingTime)
        {
            if(this.animExtraTime != true)
            {
                    string val_1 = this.animExtraTime.TimeFormat(seconds:  remainingTime);
            }
            
            if(this.pUpReminderTime > remainingTime)
            {
                    this.pUpReminderTime = this.inFTUX;
            }
            
            this.TooltipReminder(active:  false = this.pUpReminderTime >> 5);
        }
        public void AddExtraTime(int remainingTime, int extraTime)
        {
            this.animExtraTime = true;
            DG.Tweening.Core.DOSetter<System.Single> val_1 = new DG.Tweening.Core.DOSetter<System.Single>(object:  798727376, method:  new IntPtr(798683920));
            DG.Tweening.Tweener val_3 = DG.Tweening.DOTween.To(setter:  198881280, startValue:  (float)remainingTime, endValue:  null, duration:  (float)remainingTime - extraTime);
            DG.Tweening.TweenCallback val_4 = new DG.Tweening.TweenCallback(object:  798727376, method:  new IntPtr(798684944));
            object val_5 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  198881280, action:  190734336);
            object val_6 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<System.Object>(t:  198881280, autoKillOnCompletion:  true);
            string val_7 = -1467947360(-1467947360) + 13152256;
            UnityEngine.GameObject val_8 = this.extraTimeText.gameObject;
            this.extraTimeText.SetActive(value:  true);
            UnityEngine.Color val_9 = UnityEngine.Color.white;
            this.extraTimeText.color = new UnityEngine.Color() {a = ???};
            DG.Tweening.Tweener val_10 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.extraTimeText, endValue:  val_9.r, duration:  val_9.g);
            object val_11 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<System.Object>(t:  this.extraTimeText, autoKillOnCompletion:  true);
            object val_12 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.extraTimeText, delay:  val_9.r);
            DG.Tweening.TweenCallback val_13 = new DG.Tweening.TweenCallback(object:  798727376, method:  new IntPtr(798702352));
            object val_14 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.extraTimeText, action:  190734336);
        }
        public void SetupCollections()
        {
            var val_13;
            UnityEngine.Transform val_1 = this.collectionUI.transform;
            UnityEngine.Transform val_2 = this.collectionUI.parent;
            UnityEngine.GameObject val_3 = this.collectionUI.gameObject;
            this.collectionUI.SetActive(value:  false);
            val_13 = 1152921512345741328;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(Unlocked == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SLC.MatchyPics.MPICollection val_8 = GetCollection(imageSetIndex:  public static SLC.MatchyPics.MPIBoardController MonoSingleton<SLC.MatchyPics.MPIBoardController>::get_Instance().__il2cppRuntimeField_C + 56);
            UnityEngine.Transform val_9 = this.collectionUI.transform;
            UnityEngine.Transform val_10 = this.collectionUI.parent;
            val_13 = 0;
            UnityEngine.GameObject val_11 = this.collectionUI.gameObject;
            if(IsCompleted() != true)
            {
                    if((public static SLC.MatchyPics.MPIBoardController MonoSingleton<SLC.MatchyPics.MPIBoardController>::get_Instance().__il2cppRuntimeField_C + 76) > 0)
            {
                    val_13 = 1;
            }
            
            }
            
            this.collectionUI.SetActive(value:  true);
            this.collectionUI.UpdateCurrentCollection();
            this.collectionUI.<ShowPopupOnClick>k__BackingField = true;
        }
        public void SetActiveUI(bool value)
        {
            this.uiParent.SetActive(value:  value);
        }
        public void SetupFTUX()
        {
            var val_22;
            var val_23;
            var val_24;
            Player val_1 = App.Player;
            if(0 == 1)
            {
                    twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            }
            
            Player val_3 = App.Player;
            if(0 == 2)
            {
                    twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                ShowHint(isFtux:  true);
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_22 = mem[public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance().__il2cppRuntimeField_10 + 72];
                val_22 = public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance().__il2cppRuntimeField_10 + 72;
            }
            else
            {
                    twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                if(ShowFtux() != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                object val_9 = ShowUGUIMonolith<System.Object>(showNext:  false);
                val_23 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
                this.ftuxWindow = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
                val_24 = 1;
            }
            else
            {
                    twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                if(ShowFtux() == false)
            {
                    return;
            }
            
                twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                object val_13 = ShowUGUIMonolith<System.Object>(showNext:  false);
                val_23 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
                this.ftuxWindow = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
                val_24 = 2;
            }
            
                public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_1C = val_24;
                return;
            }
            
            mem[72] = 257;
        }
        public void OnValidMatchSubmited()
        {
            int val_5;
            var val_7;
            val_5 = this.currentStep;
            if(val_5 > 3)
            {
                    if(this.ftuxWindow == 0)
            {
                    return;
            }
            
                this.SetInteractableButtons(active:  true);
                val_5 = false;
                this.ftuxGroup.SetActive(value:  true);
                this.ftuxWindow.CloseWindow();
                this.inFTUX = val_5;
                this.ftuxWindow = val_5;
                return;
            }
            
            this.currentStep = val_5 + 1;
            this.ftuxWindow.SetupStep(step:  val_5);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowHint(isFtux:  true);
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_7 = mem[public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance().__il2cppRuntimeField_10 + 72];
            val_7 = public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance().__il2cppRuntimeField_10 + 72;
            mem[72] = 257;
        }
        private void SetInteractableButtons(bool active)
        {
            CurrencyStatView val_2;
            this.pauseButton.interactable = active;
            val_2 = this.coinStatViewInstantiator.<StatView>k__BackingField;
            if(val_2 != 0)
            {
                    val_2 = this.coinStatViewInstantiator.<StatView>k__BackingField.storeButton;
                val_2.interactable = active;
            }
            
            this.powerUpsGroup.SetActive(value:  active);
        }
        private string TimeFormat(int seconds)
        {
            seconds = (seconds >> 5) + (seconds >> 31);
            int val_3 = seconds - (((seconds << 4) - seconds) << 2);
            string val_4 = System.String.Format(format:  -1120761280, arg0:  13152256, arg1:  13152256);
        }
        private void TooltipReminder(bool active)
        {
            if(active != false)
            {
                    if(this.powerupsTooltip.activeSelf != false)
            {
                    return;
            }
            
                object val_2 = this.powerupsTooltip.GetComponent<System.Object>();
                this.powerupsTooltip.alpha = null;
                DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.powerupsTooltip, endValue:  null, duration:  null);
                object val_4 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<System.Object>(t:  this.powerupsTooltip, autoKillOnCompletion:  true);
                0 = 1;
            }
            
            this.powerupsTooltip.SetActive(value:  true);
        }
        public MPIUIController()
        {
            this.pUpReminderTime = 0;
            this.currentStep = 1;
        }
        private void <AddExtraTime>b__19_0(float x)
        {
            string val_1 = this.TimeFormat(seconds:  R1);
            if(this.timer == 0)
            {
                
            }
        
        }
        private void <AddExtraTime>b__19_1()
        {
            this.animExtraTime = false;
        }
        private void <AddExtraTime>b__19_2()
        {
            UnityEngine.GameObject val_1 = this.extraTimeText.gameObject;
            this.extraTimeText.SetActive(value:  false);
        }
    
    }

}
