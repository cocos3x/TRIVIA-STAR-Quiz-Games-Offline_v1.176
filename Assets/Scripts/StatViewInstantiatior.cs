using UnityEngine;
public abstract class StatViewInstantiatior : MonoBehaviour
{
    // Fields
    protected UnityEngine.Transform statViewParent;
    private bool enabledByDefault;
    private bool interactableByDefault;
    private CurrencyStatView <StatView>k__BackingField;
    protected UnityEngine.GameObject statViewObject;
    protected TweenCoinsText statViewTextTween;
    protected bool hasCreated;
    protected Anchor anchorOverride;
    protected bool useNewAnchorsAndStatViews;
    public System.Action onCreated;
    
    // Properties
    public CurrencyStatView StatView { get; set; }
    public bool SetEnabledByDefault { set; }
    public bool created { get; }
    
    // Methods
    public CurrencyStatView get_StatView()
    {
    
    }
    private void set_StatView(CurrencyStatView value)
    {
        this.<StatView>k__BackingField = value;
    }
    public void set_SetEnabledByDefault(bool value)
    {
        this.enabledByDefault = value;
    }
    public bool get_created()
    {
        return (bool)this.hasCreated;
    }
    private void Awake()
    {
        this.Create();
    }
    public void Create()
    {
        float val_6;
        float val_7;
        UnityEngine.Transform val_23;
        if(this == 0)
        {
                return;
        }
        
        if(this.hasCreated == true)
        {
                return;
        }
        
        if(this.useNewAnchorsAndStatViews == true)
        {
            goto label_12;
        }
        
        if(this.anchorOverride == 0)
        {
            goto label_7;
        }
        
        object val_1 = this.GetComponent<System.Object>();
        if((-1753496512) == 0)
        {
            goto label_7;
        }
        
        object val_3 = this.GetComponent<System.Object>();
        MonoExtensions.SetUIAnchor_WRONGLY(rect:  -1753496512, anchor:  this.anchorOverride);
        object val_4 = this.GetComponent<System.Object>();
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
        this.anchoredPosition = new UnityEngine.Vector2() {x = val_6, y = val_7};
        object val_8 = this.GetComponent<System.Object>();
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.zero;
        this.sizeDelta = new UnityEngine.Vector2();
        goto label_12;
        label_7:
        object val_10 = this.GetComponent<System.Object>();
        label_12:
        if(this.statViewParent != 0)
        {
                val_23 = this.statViewParent;
        }
        else
        {
                UnityEngine.Transform val_12 = this.statViewParent.transform;
            val_23 = this;
        }
        
        object val_13 = UnityEngine.Object.Instantiate<System.Object>(original:  -1753496512, parent:  -1753496512);
        this.statViewObject = this;
        object val_14 = this.GetComponent<System.Object>();
        this.<StatView>k__BackingField = this;
        if((-1753496512) != 0)
        {
                if(this.interactableByDefault == true)
        {
                this.interactableByDefault = 1;
        }
        
            this.<StatView>k__BackingField.Interactable = true;
        }
        
        if(this.enabledByDefault == true)
        {
                this.enabledByDefault = 1;
        }
        
        this.statViewObject.SetActive(value:  true);
        if(this.useNewAnchorsAndStatViews == true)
        {
                this.useNewAnchorsAndStatViews = this.anchorOverride;
        }
        
        if(this.useNewAnchorsAndStatViews != 0)
        {
            goto label_23;
        }
        
        label_35:
        object val_16 = this.statViewObject.GetComponentInChildren<System.Object>();
        this.statViewTextTween = this.statViewObject;
        this.hasCreated = true;
        if(this.onCreated == 0)
        {
                return;
        }
        
        this.onCreated.Invoke();
        return;
        label_23:
        object val_17 = this.statViewObject.GetComponent<System.Object>();
        if(this.statViewObject == 0)
        {
            goto label_35;
        }
        
        object val_19 = this.statViewObject.GetComponent<System.Object>();
        MonoExtensions.SetUIAnchor(rect:  this.statViewObject, anchor:  this.anchorOverride);
        object val_20 = this.statViewObject.GetComponent<System.Object>();
        UnityEngine.Vector2 val_21 = UnityEngine.Vector2.zero;
        this.statViewObject.anchoredPosition = new UnityEngine.Vector2() {x = val_6, y = val_7};
        goto label_35;
    }
    public void SetStatViewValue(int instantValue)
    {
        int val_2;
        decimal val_1 = System.Decimal.op_Implicit(value:  -1753339208);
        this.statViewTextTween.Set(instantValue:  new System.Decimal() {mid = val_2});
    }
    public void SetStoreButtonAction()
    {
    
    }
    protected abstract void SetupAnimatedElements(); // 0
    protected abstract UnityEngine.GameObject GetPrefabFromTheme(); // 0
    protected virtual void OverrideStatViewPostion(UnityEngine.RectTransform rectTransform)
    {
    
    }
    protected virtual bool ShouldCreate()
    {
        return true;
    }
    protected StatViewInstantiatior()
    {
        this.anchorOverride = 1;
        this.enabledByDefault = 1;
    }

}
