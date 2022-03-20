using UnityEngine;
public class FlyoutDefinition : DisplayWordDefinition
{
    // Fields
    private float timeToDisplayDefinition;
    private float timeToDisplayInternetConnection;
    private float timeToDisplayTutorialMessage;
    private float timeToDisplay;
    private float currentDisplayTime;
    private UnityEngine.GameObject definitionGroup;
    private UnityEngine.GameObject InternetConnectionGroup;
    private UnityEngine.GameObject tutorialGroup;
    private DG.Tweening.Sequence curSeq;
    private bool setUp;
    
    // Properties
    protected override bool checkTouchedMe { get; }
    
    // Methods
    protected override void OnEnable()
    {
        var val_7;
        bool val_8;
        object val_1 = new System.Object();
        this.OnEnable();
        UnityEngine.GameObject val_2 = this.gameObject;
        UnityEngine.UI.LayoutElement val_3 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -954084640);
        if(val_1 != 0)
        {
                val_7 = val_1;
            typeof(FlyoutDefinition.<>c__DisplayClass10_0).__il2cppRuntimeField_8 = this;
            val_8 = this.setUp;
        }
        else
        {
                val_7 = 8;
            mem[8] = this;
            val_8 = this.setUp;
        }
        
        if(val_8 != false)
        {
                this.alpha = null;
            return;
        }
        
        this.alpha = null;
        DG.Tweening.Core.DOGetter<System.Single> val_4 = new DG.Tweening.Core.DOGetter<System.Single>(object:  336527360, method:  new IntPtr(3340856608));
        DG.Tweening.Core.DOSetter<System.Single> val_5 = new DG.Tweening.Core.DOSetter<System.Single>(object:  336527360, method:  new IntPtr(3340857632));
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_6 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  null, duration:  null);
        this.setUp = true;
    }
    public override void OpenButLoad(string word)
    {
        this.SetUp();
        this.OpenButLoad(word:  word);
        if((UnityEngine.Object.op_Implicit(exists:  this.tutorialGroup)) == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = this.tutorialGroup.gameObject;
        this.tutorialGroup.SetActive(value:  false);
    }
    public override void ShowFTUXMessage()
    {
        UnityEngine.GameObject val_1 = this.definitionGroup.gameObject;
        this.definitionGroup.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.InternetConnectionGroup.gameObject;
        this.InternetConnectionGroup.SetActive(value:  false);
        if((UnityEngine.Object.op_Implicit(exists:  this.tutorialGroup)) != false)
        {
                UnityEngine.GameObject val_4 = this.tutorialGroup.gameObject;
            this.tutorialGroup.SetActive(value:  true);
        }
        
        this.timeToDisplay = this.timeToDisplayTutorialMessage;
    }
    public override void Init(System.Collections.Generic.Dictionary<string, object> defToDisplay)
    {
        this.SetUp();
        this.Init(defToDisplay:  defToDisplay);
    }
    private void SetUp()
    {
        var val_5;
        float val_6;
        if(this.curSeq != 0)
        {
                if((DG.Tweening.TweenExtensions.IsPlaying(t:  this.curSeq)) != false)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.curSeq, complete:  false);
        }
        
        }
        
        this.enabled = true;
        var val_5 = 28436825;
        val_5 = 7190600 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        UnityEngine.GameObject val_2 = this.definitionGroup.gameObject;
        if(NetworkConnectivityPinger.NOTIF_NETWORK_CONNECT_RESPONSE != null)
        {
                this.definitionGroup.SetActive(value:  true);
            UnityEngine.GameObject val_3 = this.InternetConnectionGroup.gameObject;
            this.InternetConnectionGroup.SetActive(value:  false);
            val_6 = this.timeToDisplayDefinition;
        }
        else
        {
                this.definitionGroup.SetActive(value:  false);
            UnityEngine.GameObject val_4 = this.InternetConnectionGroup.gameObject;
            this.InternetConnectionGroup.SetActive(value:  true);
            val_6 = this.timeToDisplayInternetConnection;
        }
        
        this.timeToDisplay = val_6;
        this.currentDisplayTime = 0f;
    }
    private void FixedUpdate()
    {
        if(<0)
        {
                float val_1 = UnityEngine.Time.fixedDeltaTime;
            uint val_2 = 0;
            val_2 = this.currentDisplayTime + val_2;
            this.currentDisplayTime = val_2;
            return;
        }
        
        this.enabled = false;
        goto typeof(FlyoutDefinition).__il2cppRuntimeField_FC;
    }
    protected override bool get_checkTouchedMe()
    {
        int val_1 = UnityEngine.Input.touchCount;
        if(val_1 > 0)
        {
                val_1 = 1;
            return (bool)val_1;
        }
        
        return UnityEngine.Input.GetMouseButtonDown(button:  0);
    }
    protected override void DisableMe()
    {
        object val_1 = new System.Object();
        if(this.curSeq != 0)
        {
                if((DG.Tweening.TweenExtensions.IsPlaying(t:  this.curSeq)) != false)
        {
                return;
        }
        
        }
        
        UnityEngine.GameObject val_3 = this.gameObject;
        UnityEngine.UI.LayoutElement val_4 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -953176736);
        typeof(FlyoutDefinition.<>c__DisplayClass18_0).__il2cppRuntimeField_8 = this;
        DG.Tweening.Sequence val_5 = DG.Tweening.DOTween.Sequence();
        this.curSeq = 0;
        DG.Tweening.Core.DOGetter<System.Single> val_6 = new DG.Tweening.Core.DOGetter<System.Single>(object:  336580608, method:  new IntPtr(3341753248));
        DG.Tweening.Core.DOSetter<System.Single> val_7 = new DG.Tweening.Core.DOSetter<System.Single>(object:  336580608, method:  new IntPtr(3341754272));
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_8 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  null, duration:  null);
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  198828032);
        DG.Tweening.Core.DOGetter<System.Single> val_10 = new DG.Tweening.Core.DOGetter<System.Single>(object:  336580608, method:  new IntPtr(3341759392));
        DG.Tweening.Core.DOSetter<System.Single> val_11 = new DG.Tweening.Core.DOSetter<System.Single>(object:  336580608, method:  new IntPtr(3341760416));
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_12 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  null, duration:  null);
        DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.curSeq, t:  198828032);
        DG.Tweening.TweenCallback val_14 = new DG.Tweening.TweenCallback(object:  -953176736, method:  new IntPtr(3341765536));
        object val_15 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.curSeq, action:  190734336);
    }
    private void Disable()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        object val_2 = this.GetComponent<System.Object>();
        UnityEngine.GameObject val_4 = this.gameObject;
        if((-953051424) != 0)
        {
                this.SetActive(value:  false);
            return;
        }
        
        UnityEngine.Object.Destroy(obj:  -953051424);
    }
    public FlyoutDefinition()
    {
    
    }

}
