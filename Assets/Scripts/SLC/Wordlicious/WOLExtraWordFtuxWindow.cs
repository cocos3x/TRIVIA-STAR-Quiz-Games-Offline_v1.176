using UnityEngine;

namespace SLC.Wordlicious
{
    public class WOLExtraWordFtuxWindow : MonoBehaviour
    {
        // Fields
        public static UnityEngine.Transform TargetLetter;
        private UnityEngine.UI.Button continueButton;
        private UnityEngine.Transform ftuxCurrentWord;
        private UnityEngine.GameObject ftuxIntro;
        private UnityEngine.Transform animOrigin;
        private UnityEngine.GameObject ftuxOutro;
        private UnityEngine.Transform wordRegionMask;
        private UnityEngine.Transform arrow;
        private static bool <ShowingCurrentWordUI>k__BackingField;
        
        // Properties
        public static bool ShowingCurrentWordUI { get; set; }
        
        // Methods
        public static bool get_ShowingCurrentWordUI()
        {
            return (bool)SLC.Wordlicious.WOLExtraWordFtuxWindow.<ShowingCurrentWordUI>k__BackingField;
        }
        private static void set_ShowingCurrentWordUI(bool value)
        {
            SLC.Wordlicious.WOLExtraWordFtuxWindow.<ShowingCurrentWordUI>k__BackingField = value;
        }
        private void Awake()
        {
            SLC.Wordlicious.WOLExtraWordFtuxWindow.<ShowingCurrentWordUI>k__BackingField = true;
        }
        public void ShowFtuxIntro(string word)
        {
            float val_6;
            float val_7;
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  697942608, method:  new IntPtr(697908368));
            this.continueButton.m_OnClick.AddListener(call:  162246656);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Transform val_3 = transform;
            UnityEngine.Vector3 val_4 = position;
            UnityEngine.Vector3 val_8 = ScreenCast.GetObjectPosition(mode:  697930560, objectPosition:  new UnityEngine.Vector3() {x = 1.401298E-45f, y = val_6, z = val_7});
            this.ftuxCurrentWord.position = new UnityEngine.Vector3();
            this.ftuxIntro.SetActive(value:  true);
        }
        private void PlayExtraWordAnim()
        {
            UnityEngine.GameObject val_1 = this.continueButton.gameObject;
            this.continueButton.SetActive(value:  false);
            System.Collections.IEnumerator val_2 = this.StartExtraWordAnim();
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  698079184);
        }
        private System.Collections.IEnumerator StartExtraWordAnim()
        {
            object val_1 = new System.Object();
            typeof(WOLExtraWordFtuxWindow.<StartExtraWordAnim>d__15).__il2cppRuntimeField_8 = 0;
            typeof(WOLExtraWordFtuxWindow.<StartExtraWordAnim>d__15).__il2cppRuntimeField_10 = this;
        }
        private void ShowFtuxOutro()
        {
            float val_7;
            float val_8;
            float val_16;
            float val_17;
            this.continueButton.m_OnClick.RemoveAllListeners();
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  698350288, method:  new IntPtr(698299664));
            this.continueButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.GameObject val_2 = this.continueButton.gameObject;
            this.continueButton.SetActive(value:  true);
            UnityEngine.GameObject val_3 = this.ftuxCurrentWord.gameObject;
            this.ftuxCurrentWord.SetActive(value:  false);
            SLC.Wordlicious.WOLExtraWordFtuxWindow.<ShowingCurrentWordUI>k__BackingField = false;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            FadeOut();
            this.ftuxIntro.SetActive(value:  false);
            UnityEngine.Vector3 val_5 = position;
            UnityEngine.Vector3 val_9 = ScreenCast.GetObjectPosition(mode:  698338232, objectPosition:  new UnityEngine.Vector3() {x = 1.401298E-45f, y = val_7, z = val_8});
            UnityEngine.Vector3 val_10 = new UnityEngine.Vector3(x:  val_9.x, y:  val_9.y, z:  val_9.z);
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 7.096339E-14f}, b:  new UnityEngine.Vector3() {y = val_10.x, z = val_10.y});
            this.arrow.position = new UnityEngine.Vector3();
            twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Transform val_13 = transform;
            UnityEngine.Vector3 val_14 = position;
            UnityEngine.Vector3 val_18 = ScreenCast.GetObjectPosition(mode:  698338180, objectPosition:  new UnityEngine.Vector3() {x = 1.401298E-45f, y = val_16, z = val_17});
            this.wordRegionMask.position = new UnityEngine.Vector3();
            this.ftuxOutro.SetActive(value:  true);
        }
        private void PlayAnimation(UnityEngine.Transform origin, UnityEngine.Transform target, System.Action OnAnimFinished)
        {
            float val_10;
            float val_11;
            object val_1 = new System.Object();
            typeof(WOLExtraWordFtuxWindow.<>c__DisplayClass17_0).__il2cppRuntimeField_14 = OnAnimFinished;
            UnityEngine.Vector3 val_2 = position;
            target.position = new UnityEngine.Vector3();
            object val_3 = target.GetComponent<System.Object>();
            typeof(WOLExtraWordFtuxWindow.<>c__DisplayClass17_0).__il2cppRuntimeField_8 = UnityEngine.Object.op_Equality(x:  target, y:  0);
            typeof(WOLExtraWordFtuxWindow.<>c__DisplayClass17_0).__il2cppRuntimeField_10 = 0;
            if(184877056 != 0)
            {
                    object val_6 = UnityEngine.Object.Instantiate<System.Object>(original:  184877056, parent:  target, worldPositionStays:  false);
                typeof(WOLExtraWordFtuxWindow.<>c__DisplayClass17_0).__il2cppRuntimeField_10 = MonoUtils.instance.tileTrailEffect;
                object val_7 = GetComponent<System.Object>();
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
                UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 7.209031E-14f});
                anchoredPosition = new UnityEngine.Vector2() {x = val_10, y = val_11};
            }
            
            twelvegigs.Autopilot.WUTAutopilotGameplay val_12 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  target);
            typeof(WOLExtraWordFtuxWindow.<>c__DisplayClass17_0).__il2cppRuntimeField_C = target;
            target.overrideSorting = true;
            typeof(WOLExtraWordFtuxWindow.<>c__DisplayClass17_0).__il2cppRuntimeField_C.sortingLayerName = -2059812896;
            DG.Tweening.Sequence val_13 = DG.Tweening.DOTween.Sequence();
            object val_14 = DG.Tweening.TweenExtensions.Pause<System.Object>(t:  0);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.zero;
            DG.Tweening.Tweener val_16 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  target, endValue:  new UnityEngine.Vector3(), duration:  val_15.x, snapping:  false);
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  target);
            DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_15.x);
            DG.Tweening.TweenCallback val_19 = new DG.Tweening.TweenCallback(object:  434823168, method:  new IntPtr(698491536));
            mem[68] = null;
            object val_20 = DG.Tweening.TweenExtensions.Play<System.Object>(t:  0);
        }
        private void Close()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            CompleteExtraWordFtux();
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            CloseOverlay(onClosed:  0);
            UnityEngine.GameObject val_3 = this.gameObject;
            SLCWindow.CloseWindow(window:  698641872, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        public WOLExtraWordFtuxWindow()
        {
        
        }
    
    }

}
