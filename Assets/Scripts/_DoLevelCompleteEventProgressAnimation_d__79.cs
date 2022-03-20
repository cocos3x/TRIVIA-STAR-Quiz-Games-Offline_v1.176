using UnityEngine;
private sealed class IslandParadiseEventHandler.<DoLevelCompleteEventProgressAnimation>d__79 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGEventButtonV2 eventButton;
    public IslandParadiseEventHandler <>4__this;
    public WGEventButtonV2 eventProgressUI;
    public WGLevelClearPopup popup;
    private WGEventButtonV2_IslandParadise <islandParadiseButton>5__2;
    private int <currentPoints>5__3;
    private int <pointsToReward>5__4;
    private int <lastPointsRequired>5__5;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public IslandParadiseEventHandler.<DoLevelCompleteEventProgressAnimation>d__79(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_28;
        WGEventButtonV2_IslandParadise val_29;
        UnityEngine.UI.Text val_30;
        object val_31;
        val_28 = 0;
        if((this.<>1__state) > 6)
        {
                return (bool);
        }
        
        var val_1 = 11479000 + (11479000 + (this.<>1__state) << 2);
        if((this.<>1__state) == 6)
        {
                11479000 + (this.<>1__state) << 2 = (11479000 + (this.<>1__state) << 2) & ((IP) << 11479000 + (this.<>1__state) << 2);
            11479000 + (this.<>1__state) << 2 = (11479000 + (this.<>1__state) << 2) & 182746126;
            11479000 + (this.<>1__state) << 2 = (11479000 + (this.<>1__state) << 2) & (((int)R8) >> 4);
            11479000 + (this.<>1__state) << 2 = (11479000 + (this.<>1__state) << 2) & (((this) << (32-R2)) | ((this) << R2));
            11479000 + (this.<>1__state) << 2 = (11479000 + (this.<>1__state) << 2) & (-2101797117);
            11479000 + (this.<>1__state) << 2 = (11479000 + (this.<>1__state) << 2) & 1203822592;
            11479000 + (this.<>1__state) << 2 = (11479000 + (this.<>1__state) << 2) & ((IP) << this);
        }
        
        val_29 = 0;
        this.<>1__state = 0;
        if(this.eventButton != 0)
        {
                if(((WGEventButtonV2.__il2cppRuntimeField_typeHierarchy + (WGEventButtonV2_IslandParadise.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                this.eventButton = 0;
        }
        
            val_29 = this.eventButton;
        }
        
        this.<islandParadiseButton>5__2 = val_29;
        int val_27 = this.<>4__this.<ProgressLabelPoints>k__BackingField;
        val_27 = (this.<>4__this) - val_27;
        this.<currentPoints>5__3 = val_27;
        UnityEngine.GameObject val_2 = this.eventButton.efxUpdate.gameObject;
        this.eventButton.efxUpdate.SetActive(value:  true);
        val_30 = this.eventButton.buttonLabel;
        string val_3 = this.<currentPoints>5__3.ToString();
        string val_4 = this.<>4__this.ToString();
        string val_5 = System.String.Format(format:  1629069648, arg0:  -1371029244, arg1:  -1371041308);
        this.eventButton.canvasGroup.alpha = null;
        DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.eventButton.canvasGroup, endValue:  null, duration:  null);
        object val_7 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.eventButton.canvasGroup, delay:  null);
        UnityEngine.WaitForSeconds val_8 = null;
        val_31 = val_8;
        val_8 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_28 = 1;
        this.<>1__state = val_28;
        this.<>2__current = ;
        return (bool);
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}
