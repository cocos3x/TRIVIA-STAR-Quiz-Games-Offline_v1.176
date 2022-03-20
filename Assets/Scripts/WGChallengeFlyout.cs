using UnityEngine;
public class WGChallengeFlyout : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
    // Fields
    private UnityEngine.RectTransform progressFlyout;
    private UnityEngine.RectTransform completeFlyout;
    private UnityEngine.UI.Text progressText;
    private UnityEngine.UI.Text completeText;
    private bool playingAnimation;
    private System.Action onStartAction;
    private UnityEngine.Camera canvasCamera;
    private WGChallengeButton uiButton;
    
    // Methods
    private void Start()
    {
        MainController val_1 = MainController.instance;
        if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
        {
                MainController val_3 = MainController.instance;
            1152921504885600256 = null;
            1152921504885600256 = new UnityEngine.Events.UnityAction(object:  -1599419568, method:  new IntPtr(2695518608));
            4.AddListener(call:  162246656);
        }
        
        if(this.onStartAction == 0)
        {
                return;
        }
        
        this.onStartAction.Invoke();
    }
    public void PlayProgressFlyout()
    {
        System.Action val_1 = new System.Action(object:  -1599302448, method:  new IntPtr(2695639824));
        this.onStartAction = null;
    }
    private void ProgressAnim()
    {
        var val_13;
        System.Func<ChallengeTask, System.Single> val_15;
        var val_16;
        if(this.playingAnimation == true)
        {
                return;
        }
        
        this.playingAnimation = true;
        UnityEngine.GameObject val_1 = this.progressFlyout.gameObject;
        this.progressFlyout.SetActive(value:  true);
        UnityEngine.GameObject val_2 = this.completeFlyout.gameObject;
        this.completeFlyout.SetActive(value:  false);
        WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Collections.Generic.List<ZooTile> val_4 = new System.Collections.Generic.List<ZooTile>(collection:  public static WGChallengeController MonoSingletonSelfGenerating<WGChallengeController>::get_Instance().__il2cppRuntimeField_14);
        PluginExtension.Shuffle<UnityEngine.Sprite>(list:  80883712, seed:  new System.Nullable<System.Int32>() {HasValue = false});
        val_13 = null;
        val_13 = null;
        val_15 = WGChallengeFlyout.<>c.<>9__8_0;
        if(val_15 == 0)
        {
                val_15 = null;
            val_15 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Single>(object:  WGChallengeFlyout.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2695763088));
            WGChallengeFlyout.<>c.<>9__8_0 = val_15;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_6 = System.Linq.Enumerable.OrderByDescending<System.Object, System.Single>(source:  80883712, keySelector:  7720960);
        object val_7 = System.Linq.Enumerable.First<System.Object>(source:  80883712);
        if(null != 0)
        {
                string val_8 = goalName(cType:  1094057968);
            val_16 = null;
        }
        else
        {
                string val_9 = this.goalName(cType:  0);
            val_16 = 8;
        }
        
        string val_10 = System.String.Format(format:  -1694782544, arg0:  8, arg1:  10170368, arg2:  10170368);
        System.Collections.IEnumerator val_11 = this.ProgressFlyout();
        UnityEngine.Coroutine val_12 = this.StartCoroutine(routine:  -1599172016);
    }
    private System.Collections.IEnumerator ProgressFlyout()
    {
        object val_1 = new System.Object();
        typeof(WGChallengeFlyout.<ProgressFlyout>d__9).__il2cppRuntimeField_8 = 0;
        typeof(WGChallengeFlyout.<ProgressFlyout>d__9).__il2cppRuntimeField_10 = this;
    }
    private string goalName(ChallengeType cType)
    {
        var val_2;
        var val_3;
        if(cType > 5)
        {
                return;
        }
        
        var val_1 = 6724096 + (6724096 + (cType) << 2);
        if(cType == 5)
        {
                6724096 = 6724096 & ((R8) << 6724096);
            6724096 = 6724096 & (6724096 >> 32);
            6724096 = 6724096 & (((int)R8) >> ((6724096 & (R8) << 6724096) & ((int)(6724096 & (R8) << 6724096)) >> 32));
            6724096 = 6724096 & ((((((6724096 & (R8) << 6724096) & ((int)(6724096 & (R8) << 6724096)) >> 32) & ((int)R8) >> ((6724096 & (R8) << 6724096) & ((int)(6724096 & (R8) << 6724096)) >> 32))) << (32-(((6724096 & (R8) << 6724096) & ((int)(6724096 & (R8) << 6724096)) >> 32) & ((int)R8) >> ((6724096 & (R8) << 6724096) & ((int)(6724096 & (R8) << 6724096)) >> 32)))) | (((((6724096 & (R8) << 6724096) & ((int)(6724096 & (R8) << 6724096)) >> 32) & ((int)R8) >> ((6724096 & (R8) << 6724096) & ((int)(6724096 & (R8) << 6724096)) >> 32))) << (((6724096 & (R8) << 6724096) & ((int)(6724096 & (R8) << 6724096)) >> 32) & ((int)R8) >> ((6724096 & (R8) << 6724096) & ((int)(6724096 & (R8) << 6724096)) >> 32))));
            6724096 = 6724096 & ((R8) << 1);
            6724096 = 6724096 & (6724096 >> 1);
        }
        
        val_2 = "Find Extra Words";
        val_3 = "find_extra_words";
        return Localization.Localize(key:  -1598954320, defaultValue:  -1598954432, useSingularKey:  false);
    }
    private void DoCompleteFlyout()
    {
        if(this.playingAnimation == true)
        {
                return;
        }
        
        this.playingAnimation = true;
        UnityEngine.Transform val_1 = this.completeFlyout.transform;
        UnityEngine.Vector3 val_2 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
        this.completeFlyout.localScale = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        UnityEngine.GameObject val_3 = this.progressFlyout.gameObject;
        this.progressFlyout.SetActive(value:  false);
        UnityEngine.GameObject val_4 = this.completeFlyout.gameObject;
        this.completeFlyout.SetActive(value:  true);
        string val_5 = Localization.Localize(key:  -1598821616, defaultValue:  -1598821728, useSingularKey:  false);
        System.Collections.IEnumerator val_6 = this.CompleteFlyout();
        UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  -1598797520);
        System.Collections.IEnumerator val_8 = this.SetCompleteFlyoutPlacement();
        UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  -1598797520);
    }
    private void OnBeforeLevelComplete()
    {
        MainController val_1 = MainController.instance;
        if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
        {
                MainController val_3 = MainController.instance;
            1152921504885600256 = null;
            1152921504885600256 = new UnityEngine.Events.UnityAction(object:  -1598669136, method:  new IntPtr(2695518608));
            4.RemoveListener(call:  162246656);
        }
        
        this.OnDisplayComplete();
    }
    public void PlayCompleteFlyout()
    {
        System.Action val_1 = new System.Action(object:  -1598556000, method:  new IntPtr(2696386160));
        this.onStartAction = null;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -1598580112, clipIndex:  0);
    }
    private System.Collections.IEnumerator CompleteFlyout()
    {
        object val_1 = new System.Object();
        typeof(WGChallengeFlyout.<CompleteFlyout>d__16).__il2cppRuntimeField_8 = 0;
        typeof(WGChallengeFlyout.<CompleteFlyout>d__16).__il2cppRuntimeField_10 = this;
    }
    private void Update()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(GetActiveAndQueuedWindowCount() < 2)
        {
                return;
        }
        
        R4.OnDisplayComplete();
    }
    private System.Collections.IEnumerator SetCompleteFlyoutPlacement()
    {
        object val_1 = new System.Object();
        typeof(WGChallengeFlyout.<SetCompleteFlyoutPlacement>d__18).__il2cppRuntimeField_8 = 0;
        typeof(WGChallengeFlyout.<SetCompleteFlyoutPlacement>d__18).__il2cppRuntimeField_10 = this;
    }
    private void OnDisplayComplete()
    {
        this.StopAllCoroutines();
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    private void OnDestroy()
    {
        this.StopAllCoroutines();
    }
    public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
    {
        this.StopAllCoroutines();
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_3 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public WGChallengeFlyout()
    {
    
    }

}
