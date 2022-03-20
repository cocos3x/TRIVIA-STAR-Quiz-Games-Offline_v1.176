using UnityEngine;
private sealed class FPHLevelCompletePopup.<StartMinigame>d__61 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public FPHLevelCompletePopup <>4__this;
    private System.Collections.Generic.List<FPHPickerGameButton> <instaCards>5__2;
    private System.Collections.Generic.List.Enumerator<FPHPickerGameButton> <>7__wrap2;
    private FPHPickerGameButton <newMulti>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FPHLevelCompletePopup.<StartMinigame>d__61(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
        if((this.<>1__state) != 3)
        {
                return;
        }
        
        this.<>m__Finally1();
    }
    private bool MoveNext()
    {
        var val_43;
        int val_68;
        object val_70;
        int val_72;
        var val_76;
        var val_77;
        val_68 = 0;
        if((this.<>1__state) > 6)
        {
                return (bool)val_68;
        }
        
        var val_1 = 7079532 + (7079532 + (this.<>1__state) << 2);
        if((this.<>1__state) == 6)
        {
                7079532 + (this.<>1__state) << 2 = (7079532 + (this.<>1__state) << 2) & ((IP) << 7079532 + (this.<>1__state) << 2);
            7079532 + (this.<>1__state) << 2 = (7079532 + (this.<>1__state) << 2) & 35627681;
            7079532 + (this.<>1__state) << 2 = (7079532 + (this.<>1__state) << 2) & ((7079532 + (this.<>1__state) << 2) >> 3);
            7079532 + (this.<>1__state) << 2 = (7079532 + (this.<>1__state) << 2) & (35627681 >> R2);
            7079532 + (this.<>1__state) << 2 = (7079532 + (this.<>1__state) << 2) & 35627681;
            7079532 + (this.<>1__state) << 2 = (7079532 + (this.<>1__state) << 2) & ((7079532 + (this.<>1__state) << 2) >> (this.<>4__this));
            7079532 + (this.<>1__state) << 2 = (7079532 + (this.<>1__state) << 2) & 2174;
        }
        
        this.<>1__state = 0;
        this.<>4__this.pregameOpenButton.interactable = false;
        UnityEngine.UI.LayoutElement val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  this.<>4__this.levelCompleteBanner);
        DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>4__this.levelCompleteBanner, endValue:  null, duration:  null);
        twelvegigs.Autopilot.WUTAutopilotGameplay val_4 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  this.<>4__this.pregameCointext);
        DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>4__this.pregameCointext, endValue:  null, duration:  null);
        twelvegigs.Autopilot.WUTAutopilotGameplay val_6 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  this.<>4__this.pregameStarText);
        DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>4__this.pregameStarText, endValue:  null, duration:  null);
        UnityEngine.UI.LayoutElement val_8 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  this.<>4__this.preminigameTapContinueObject);
        DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>4__this.preminigameTapContinueObject, endValue:  null, duration:  null);
        PluginExtension.SetColorAlpha(graphic:  this.<>4__this.minigameBackdrop, a:  null);
        UnityEngine.GameObject val_10 = this.<>4__this.minigameBackdrop.gameObject;
        this.<>4__this.minigameBackdrop.SetActive(value:  true);
        DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>4__this.minigameBackdrop, endValue:  null, duration:  null);
        UnityEngine.WaitForSeconds val_12 = null;
        val_70 = val_12;
        val_12 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_68 = 1;
        this.<>1__state = val_68;
        goto label_6;
        label_102:
        if(MoveNext() == false)
        {
            goto label_58;
        }
        
        if(new System.Object() != 0)
        {
                typeof(FPHLevelCompletePopup.<>c__DisplayClass61_0).__il2cppRuntimeField_10 = this.<>4__this;
        }
        else
        {
                mem[16] = this.<>4__this;
        }
        
        typeof(FPHLevelCompletePopup.<>c__DisplayClass61_0).__il2cppRuntimeField_8 = val_43;
        UnityEngine.Transform val_45 = this.<>4__this.chestRewardMultiParent.transform;
        object val_46 = UnityEngine.Object.Instantiate<System.Object>(original:  this.<>4__this.minigameButtonPrefab, parent:  this.<>4__this.chestRewardMultiParent);
        typeof(FPHLevelCompletePopup.<>c__DisplayClass61_0).__il2cppRuntimeField_C = this.<>4__this.minigameButtonPrefab;
        UnityEngine.GameObject val_47 = this.<>4__this.minigameButtonPrefab.gameObject;
        string val_48 = -1626838416(-1626838416) + 13152256;
        this.<>4__this.minigameButtonPrefab.name = -1626838416;
        mem2[0] = null;
        val_76 = 0;
        if((new System.Action(object:  303992832, method:  new IntPtr(2668128960))) <= ((val_43 - 1)))
        {
                var val_68 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_68 = val_68 + (((val_43 - 1)) << 2);
        val_76 = mem[(0 + ((val_43 - 1)) << 2) + 16];
        val_76 = (0 + ((val_43 - 1)) << 2) + 16;
        mem2[0] = val_76;
        this.<instaCards>5__2.Add(item:  typeof(FPHLevelCompletePopup.<>c__DisplayClass61_0).__il2cppRuntimeField_C);
        CompanyDevices val_50 = CompanyDevices.Instance;
        if((0.CompanyDevice() == false) || ((CPlayerPrefs.GetBool(key:  -1626825024, defaultValue:  false)) == false))
        {
            goto label_102;
        }
        
        System.Type val_53 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(160436224)});
        typeof(System.Type[]).__il2cppRuntimeField_10 = null;
        UnityEngine.GameObject val_54 = new UnityEngine.GameObject(name:  -1626824912, components:  473824320);
        UnityEngine.Transform val_55 = transform;
        UnityEngine.Transform val_56 = typeof(FPHLevelCompletePopup.<>c__DisplayClass61_0).__il2cppRuntimeField_C.transform;
        SetParent(p:  typeof(FPHLevelCompletePopup.<>c__DisplayClass61_0).__il2cppRuntimeField_C);
        UnityEngine.Transform val_57 = transform;
        MonoExtensions.ResetLocal(trans:  157720576);
        object val_58 = AddComponent<System.Object>();
        string val_59 = typeof(FPHLevelCompletePopup.<>c__DisplayClass61_0).__il2cppRuntimeField_8.ToString();
        object val_60 = GetComponent<System.Object>();
        System.Type val_61 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(178008064)});
        UnityEngine.Object val_62 = UnityEngine.Resources.GetBuiltinResource(type:  178008064, path:  -1626823792);
        if(null != 0)
        {
                if(null != null)
        {
                val_77 = 0;
        }
        
        }
        else
        {
                val_77 = 0;
        }
        
        font = 0;
        object val_63 = GetComponent<System.Object>();
        resizeTextForBestFit = true;
        object val_64 = GetComponent<System.Object>();
        resizeTextMaxSize = 999;
        object val_65 = AddComponent<System.Object>();
        UnityEngine.Vector2 val_66;
        val_66 = new UnityEngine.Vector2(x:  null, y:  null);
        effectDistance = new UnityEngine.Vector2() {x = val_66.x, y = val_66.y};
        goto label_102;
        label_58:
        Dispose();
        UnityEngine.WaitForEndOfFrame val_67 = null;
        val_70 = val_67;
        val_67 = new UnityEngine.WaitForEndOfFrame();
        val_72 = 4;
        this.<>1__state = val_72;
        val_68 = 1;
        label_6:
        this.<>2__current = val_70;
        return (bool)val_68;
    }
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
        this.<>7__wrap2.Dispose();
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
