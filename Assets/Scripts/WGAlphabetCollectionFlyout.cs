using UnityEngine;
public class WGAlphabetCollectionFlyout : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject progress;
    private UnityEngine.GameObject complete;
    private UnityEngine.UI.Slider progressSlider;
    private UnityEngine.UI.Text sliderLabel;
    private UnityEngine.RectTransform flyToPos;
    private UnityEngine.UI.Button completeButton;
    public bool PlayAnimation;
    private float delayBeforeClose;
    
    // Methods
    private void Awake()
    {
        var val_8;
        MainController val_1 = MainController.instance;
        if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
        {
                MainController val_3 = MainController.instance;
            UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -1562218272, method:  new IntPtr(2732722976));
            1.AddListener(call:  162246656);
        }
        
        WordPets.WPTDataParser val_5 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_6 = new System.Action<Result>(object:  -1562218272, method:  new IntPtr(2732724000));
        System.Delegate val_7 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
        val_8 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_8 != 0)
        {
                if(val_8 == null)
        {
            goto label_15;
        }
        
        }
        
        val_8 = 0;
        label_15:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_8;
    }
    private void onAnotherSceneLoaded(SceneType scene)
    {
        if(scene == 2)
        {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(IsCollectionBoxFull() == false)
        {
                return;
        }
        
        }
        
        this.delayBeforeClose = 0.1f;
        System.Collections.IEnumerator val_3 = this.CloseAfterDelay();
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  -1562102176);
    }
    private void Start()
    {
        DG.Tweening.TweenCallback val_16;
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Transform val_2 = this.transform;
        DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  -1561968672, endValue:  null, duration:  null, snapping:  false);
        val_16 = null;
        val_16 = new DG.Tweening.TweenCallback(object:  -1561968672, method:  new IntPtr(2732957216));
        object val_5 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  -1561968672, action:  190734336);
        if(this.PlayAnimation != false)
        {
                this.progress.SetActive(value:  true);
            this.complete.SetActive(value:  false);
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<System.String> val_7 = GetCurrentCollectionBox;
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            float val_16 = -1f;
            val_16 = ((float)public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_C) + val_16;
            val_16 = val_16 / ((float)public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_C);
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<System.String> val_10 = GetCurrentCollectionBox;
            string val_12 = (public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_C - 1).ToString();
            twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_16 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance();
            string val_14 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_C.ToString();
            string val_15 = System.String.Format(format:  1629069648, arg0:  -1561980708, arg1:  -1561980708);
            if(this.sliderLabel != 0)
        {
                return;
        }
        
            return;
        }
        
        this.UpdateUI();
    }
    private void onLevelComplete()
    {
        UnityEngine.Events.UnityAction val_11;
        this.delayBeforeClose = 1.25f;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(IsCollectionBoxFull() != false)
        {
                this.completeButton.interactable = false;
            System.Collections.IEnumerator val_3 = this.completeButton.ShowPopupAfterDelay();
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.completeButton);
        }
        
        val_11 = 1152921504885600256;
        MainController val_5 = MainController.instance;
        if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
        {
                MainController val_7 = MainController.instance;
            val_11 = null;
            val_11 = new UnityEngine.Events.UnityAction(object:  -1561836192, method:  new IntPtr(2732722976));
            1.RemoveListener(call:  162246656);
        }
        
        System.Collections.IEnumerator val_9 = this.CloseAfterDelay();
        UnityEngine.Coroutine val_10 = this.StartCoroutine(routine:  -1561836192);
    }
    private System.Collections.IEnumerator ShowPopupAfterDelay()
    {
        object val_1 = new System.Object();
        typeof(WGAlphabetCollectionFlyout.<ShowPopupAfterDelay>d__12).__il2cppRuntimeField_8 = 0;
    }
    private void UpdateUI()
    {
        var val_15;
        UnityEngine.Events.UnityAction val_16;
        val_15 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(IsCollectionBoxFull() != false)
        {
                this.progress.SetActive(value:  false);
            this.complete.SetActive(value:  true);
            val_16 = null;
            val_16 = new UnityEngine.Events.UnityAction(object:  -1561578400, method:  new IntPtr(2733351584));
            this.completeButton.m_OnClick.AddListener(call:  162246656);
            return;
        }
        
        this.progress.SetActive(value:  true);
        this.complete.SetActive(value:  false);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<System.String> val_5 = GetCurrentCollectionBox;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        float val_15 = (float)public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_C;
        val_15 = ((float)public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_C) / val_15;
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<System.String> val_8 = GetCurrentCollectionBox;
        string val_9 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_C.ToString();
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_15 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance();
        string val_11 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_C.ToString();
        string val_12 = System.String.Format(format:  1629069648, arg0:  -1561590436, arg1:  -1561590436);
        val_16 = "{0}/{1}";
        System.Collections.IEnumerator val_13 = this.CloseAfterDelay();
        UnityEngine.Coroutine val_14 = this.StartCoroutine(routine:  -1561578400);
    }
    private System.Collections.IEnumerator CloseAfterDelay()
    {
        object val_1 = new System.Object();
        typeof(WGAlphabetCollectionFlyout.<CloseAfterDelay>d__14).__il2cppRuntimeField_8 = 0;
        typeof(WGAlphabetCollectionFlyout.<CloseAfterDelay>d__14).__il2cppRuntimeField_10 = this;
    }
    private void OnDestroy()
    {
        var val_4;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_2 = new System.Action<Result>(object:  -1561325728, method:  new IntPtr(2732724000));
        System.Delegate val_3 = System.Delegate.Remove(source:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, value:  7401472);
        val_4 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_4 != 0)
        {
                if(val_4 == null)
        {
            goto label_6;
        }
        
        }
        
        val_4 = 0;
        label_6:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_4;
    }
    public WGAlphabetCollectionFlyout()
    {
        this.delayBeforeClose = 4f;
        this.PlayAnimation = true;
    }
    private void <Start>b__10_0()
    {
        float val_10;
        float val_11;
        float val_13;
        float val_14;
        float val_20;
        float val_21;
        float val_22;
        var val_28;
        var val_29;
        var val_30;
        DG.Tweening.TweenCallback val_35;
        if(this.PlayAnimation == false)
        {
                return;
        }
        
        object val_1 = new System.Object();
        typeof(WGAlphabetCollectionFlyout.<>c__DisplayClass10_0).__il2cppRuntimeField_C = this;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        typeof(WGAlphabetCollectionFlyout.<>c__DisplayClass10_0).__il2cppRuntimeField_8 = public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_6C;
        if((public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance().__il2cppRuntimeField_6C) == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_4 = typeof(WGAlphabetCollectionFlyout.<>c__DisplayClass10_0).__il2cppRuntimeField_8.transform;
        UnityEngine.Transform val_5 = typeof(WGAlphabetCollectionFlyout.<>c__DisplayClass10_0).__il2cppRuntimeField_8.root;
        object val_6 = typeof(WGAlphabetCollectionFlyout.<>c__DisplayClass10_0).__il2cppRuntimeField_8.GetComponentInChildren<System.Object>();
        UnityEngine.Transform val_7 = typeof(WGAlphabetCollectionFlyout.<>c__DisplayClass10_0).__il2cppRuntimeField_8.transform;
        UnityEngine.Vector3 val_8 = position;
        UnityEngine.Vector3 val_12 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = typeof(WGAlphabetCollectionFlyout.<>c__DisplayClass10_0).__il2cppRuntimeField_8, y = val_10, z = val_11});
        UnityEngine.Transform val_16 = this.transform;
        UnityEngine.Transform val_17 = this.root;
        object val_18 = this.GetComponentInChildren<System.Object>();
        UnityEngine.Vector3 val_19 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = -6.602026E-18f, y = val_13, z = val_14});
        UnityEngine.Transform val_23 = typeof(WGAlphabetCollectionFlyout.<>c__DisplayClass10_0).__il2cppRuntimeField_8.transform;
        typeof(WGAlphabetCollectionFlyout.<>c__DisplayClass10_0).__il2cppRuntimeField_8.SetParent(p:  this.flyToPos);
        UnityEngine.Transform val_24 = typeof(WGAlphabetCollectionFlyout.<>c__DisplayClass10_0).__il2cppRuntimeField_8.transform;
        typeof(WGAlphabetCollectionFlyout.<>c__DisplayClass10_0).__il2cppRuntimeField_8.position = new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_22};
        UnityEngine.Transform val_25 = typeof(WGAlphabetCollectionFlyout.<>c__DisplayClass10_0).__il2cppRuntimeField_8.transform;
        typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_10 = val_20;
        typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_14 = val_21;
        typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_18 = val_22;
        UnityEngine.Vector3 val_26 = position;
        UnityEngine.Vector3 val_27 = CUtils.GetMiddlePoint(begin:  new UnityEngine.Vector3() {x = -6.597023E-18f, y = val_20, z = val_21}, end:  new UnityEngine.Vector3() {x = val_22}, delta:  val_26.x);
        typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_1C = val_28;
        typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20 = val_29;
        typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24 = val_30;
        UnityEngine.Vector3 val_31 = position;
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> val_32 = DG.Tweening.ShortcutExtensions.DOPath(target:  typeof(WGAlphabetCollectionFlyout.<>c__DisplayClass10_0).__il2cppRuntimeField_8, path:  533912224, duration:  val_31.x, pathType:  1056964608, pathMode:  0, resolution:  1, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
        val_35 = null;
        val_35 = new DG.Tweening.TweenCallback(object:  307879936, method:  new IntPtr(2733846688));
        object val_34 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  typeof(WGAlphabetCollectionFlyout.<>c__DisplayClass10_0).__il2cppRuntimeField_8, action:  190734336);
    }
    private void <UpdateUI>b__13_0()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
        UnityEngine.GameObject val_3 = this.gameObject;
        this.SetActive(value:  false);
    }
    private void <CloseAfterDelay>b__14_0()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }

}
