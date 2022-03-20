using UnityEngine;
public class RESForestChestButtonPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button chestButton;
    private UnityEngine.UI.Image bg;
    private UnityEngine.GameObject glow;
    private UnityEngine.GameObject chest;
    private UnityEngine.GameObject battery;
    private DG.Tweening.Sequence forestChestSequence;
    
    // Methods
    private void OnSceneLoaded(SceneType type)
    {
        if(type != 2)
        {
                return;
        }
        
        this.Invoke(methodName:  -658476064, time:  null);
    }
    private void Awake()
    {
        var val_4;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_2 = new System.Action<Result>(object:  -658334832, method:  new IntPtr(3636607440));
        System.Delegate val_3 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
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
    private void Start()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -658193136, method:  new IntPtr(3636728656));
        this.chestButton.m_OnClick.AddListener(call:  162246656);
        this.glow.SetActive(value:  false);
        this.battery.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.bg.gameObject;
        this.bg.SetActive(value:  false);
        UnityEngine.Transform val_3 = this.chest.transform;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        this.chest.localScale = new UnityEngine.Vector3();
        UnityEngine.Transform val_5 = this.chest.transform;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
        DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.chest, endValue:  new UnityEngine.Vector3(), duration:  val_6.x);
        object val_8 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.chest, ease:  27);
        System.Collections.IEnumerator val_9 = this.DelayOpenChest();
        UnityEngine.Coroutine val_10 = this.StartCoroutine(routine:  -658193136);
    }
    private void OnDestroy()
    {
        var val_4;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_2 = new System.Action<Result>(object:  -658052464, method:  new IntPtr(3636607440));
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
    private void OnChestClicked()
    {
        this.chestButton.interactable = false;
        UnityEngine.Transform val_1 = this.glow.transform;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.glow.localScale = new UnityEngine.Vector3();
        UnityEngine.Transform val_3 = this.battery.transform;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        this.battery.localScale = new UnityEngine.Vector3();
        PluginExtension.SetColorAlpha(graphic:  this.bg, a:  val_4.x);
        UnityEngine.GameObject val_5 = this.bg.gameObject;
        this.bg.SetActive(value:  true);
        DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
        UnityEngine.Transform val_7 = this.chest.transform;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.chest, endValue:  new UnityEngine.Vector3(), duration:  val_8.x);
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.chest);
        DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.bg, endValue:  val_8.x, duration:  val_8.y);
        DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.bg);
        DG.Tweening.TweenCallback val_13 = new DG.Tweening.TweenCallback(object:  -657901552, method:  new IntPtr(3637031504));
        DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        UnityEngine.Transform val_15 = this.glow.transform;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.one;
        DG.Tweening.Tweener val_17 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.glow, endValue:  new UnityEngine.Vector3(), duration:  val_16.x);
        DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.glow);
        UnityEngine.Transform val_19 = this.battery.transform;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.one;
        DG.Tweening.Tweener val_21 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.battery, endValue:  new UnityEngine.Vector3(), duration:  val_20.x);
        DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.battery);
        DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_20.x);
        DG.Tweening.TweenCallback val_24 = new DG.Tweening.TweenCallback(object:  -657901552, method:  new IntPtr(3637040720));
        object val_25 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
    }
    private System.Collections.IEnumerator DelayOpenChest()
    {
        object val_1 = new System.Object();
        typeof(RESForestChestButtonPopup.<DelayOpenChest>d__11).__il2cppRuntimeField_8 = 0;
        typeof(RESForestChestButtonPopup.<DelayOpenChest>d__11).__il2cppRuntimeField_10 = this;
    }
    private void OnSwiperFinished()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CollectForestChest();
        DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
        UnityEngine.Transform val_3 = this.battery.transform;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.battery, endValue:  new UnityEngine.Vector3(), duration:  val_4.x);
        DG.Tweening.Sequence val_6 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.battery);
        UnityEngine.Transform val_7 = this.glow.transform;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.glow, endValue:  new UnityEngine.Vector3(), duration:  val_8.x);
        DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.glow);
        DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.bg, endValue:  val_8.x, duration:  val_8.y);
        DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.bg);
        DG.Tweening.TweenCallback val_13 = new DG.Tweening.TweenCallback(object:  -657627376, method:  new IntPtr(3637314896));
        object val_14 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
    }
    public RESForestChestButtonPopup()
    {
    
    }
    private void <OnChestClicked>b__10_0()
    {
        this.glow.SetActive(value:  true);
        this.battery.SetActive(value:  true);
    }
    private void <OnChestClicked>b__10_1()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_2 = Spins;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(CanCollectForestChest() == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.IEnumerator val_6 = MoveAndLoadScene(callback:  0);
        UnityEngine.Coroutine val_7 = R4.StartCoroutine(routine:  -657286704);
    }
    private void <OnSwiperFinished>b__12_0()
    {
        int val_2;
        RestaurantRivals.RESLevelChestData val_1 = RestaurantRivals.RESGameEconHelper.GetCurrentLevelChestData();
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_14.StartSpinGetEffects(spins:  val_2, recharge:  true);
        UnityEngine.GameObject val_4 = this.gameObject;
        SLCWindow.CloseWindow(window:  -657149680, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }

}
