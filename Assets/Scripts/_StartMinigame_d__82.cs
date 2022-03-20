using UnityEngine;
private sealed class TRVLevelComplete.<StartMinigame>d__82 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TRVLevelComplete <>4__this;
    private System.Collections.Generic.Dictionary<TRVPickerGameButton, int> <instaCards>5__2;
    private System.Collections.Generic.Dictionary.KeyCollection.Enumerator<TRVPickerGameButton, int> <>7__wrap2;
    private TRVPickerGameButton <newMulti>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVLevelComplete.<StartMinigame>d__82(int <>1__state)
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
        int val_46;
        var val_66;
        var val_67;
        System.Action<UnityEngine.GameObject> val_69;
        object val_70;
        int val_76;
        var val_77;
        if((this.<>1__state) > 6)
        {
            goto label_71;
        }
        
        var val_1 = 10793596 + (10793596 + (this.<>1__state) << 2);
        if((this.<>1__state) == 6)
        {
                0 = 0 & ((IP) << 0);
            0 = 0 & (0 >> 12);
            0 = 0 & ((IP) << 6);
            0 = 0 & (0 << 7);
            0 = IP * (10793596 + (this.<>1__state) << 2);
            0 = 0 & (0 >> 15);
            mem2[0] = ((IP * 10793596 + (this.<>1__state) << 2) & ((int)(IP * 10793596 + (this.<>1__state) << 2)) >> 15) + 35635046;
        }
        
        val_66 = this;
        this.<>1__state = 0;
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        this.<>4__this.openChestImage.color = new UnityEngine.Color() {a = ???};
        val_67 = null;
        val_67 = null;
        val_69 = TRVLevelComplete.<>c.<>9__82_0;
        if(val_69 == 0)
        {
                val_69 = null;
            val_69 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  TRVLevelComplete.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3789322512));
            TRVLevelComplete.<>c.<>9__82_0 = val_69;
        }
        
        this.<>4__this.statViews.ForEach(action:  7401472);
        this.<>4__this.pregameOpenButton.interactable = false;
        UnityEngine.UI.LayoutElement val_4 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  this.<>4__this.levelCompleteBanner);
        DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>4__this.levelCompleteBanner, endValue:  val_2.r, duration:  val_2.g);
        UnityEngine.UI.LayoutElement val_6 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  this.<>4__this.preminigameRewardGroup);
        DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>4__this.preminigameRewardGroup, endValue:  val_2.r, duration:  val_2.g);
        UnityEngine.UI.LayoutElement val_8 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  this.<>4__this.preminigameTapContinueObject);
        DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>4__this.preminigameTapContinueObject, endValue:  val_2.r, duration:  val_2.g);
        UnityEngine.GameObject val_10 = this.<>4__this.preCrazyCategoriesPointParent.gameObject;
        this.<>4__this.preCrazyCategoriesPointParent.SetActive(value:  false);
        PluginExtension.SetColorAlpha(graphic:  this.<>4__this.minigameBackdrop, a:  val_2.r);
        UnityEngine.GameObject val_11 = this.<>4__this.minigameBackdrop.gameObject;
        this.<>4__this.minigameBackdrop.SetActive(value:  true);
        DG.Tweening.Tweener val_12 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>4__this.minigameBackdrop, endValue:  val_2.r, duration:  val_2.g);
        UnityEngine.WaitForSeconds val_13 = null;
        val_70 = val_13;
        val_13 = new UnityEngine.WaitForSeconds(seconds:  val_2.r);
        this.<>1__state = 1;
        this.<>2__current = ;
        goto label_71;
        label_99:
        if(MoveNext() == false)
        {
            goto label_73;
        }
        
        object val_45 = new System.Object();
        if(val_45 != 0)
        {
                typeof(TRVLevelComplete.<>c__DisplayClass82_0).__il2cppRuntimeField_C = this.<>4__this;
            val_76 = val_46;
        }
        else
        {
                mem[12] = this.<>4__this;
            val_76 = val_46;
        }
        
        typeof(TRVLevelComplete.<>c__DisplayClass82_0).__il2cppRuntimeField_8 = val_76;
        object val_47 = new System.Object();
        typeof(TRVLevelComplete.<>c__DisplayClass82_1).__il2cppRuntimeField_C = val_45;
        UnityEngine.Transform val_48 = this.<>4__this.chestRewardMultiParent.transform;
        object val_49 = UnityEngine.Object.Instantiate<System.Object>(original:  this.<>4__this.minigameButtonPrefab, parent:  this.<>4__this.chestRewardMultiParent);
        typeof(TRVLevelComplete.<>c__DisplayClass82_1).__il2cppRuntimeField_8 = this.<>4__this.minigameButtonPrefab;
        UnityEngine.GameObject val_50 = this.<>4__this.minigameButtonPrefab.gameObject;
        string val_51 = -1626838416(-1626838416) + 13152256;
        this.<>4__this.minigameButtonPrefab.name = -1626838416;
        System.Action val_52 = new System.Action(object:  359796736, method:  new IntPtr(3789457680));
        mem2[0] = null;
        val_77 = 0;
        var val_66 = 0;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_66 = val_66 + (((val_46 - 1)) << 2);
        val_77 = mem[(0 + ((val_46 - 1)) << 2) + 16];
        val_77 = (0 + ((val_46 - 1)) << 2) + 16;
        mem2[0] = val_77;
        this.<instaCards>5__2.Add(key:  typeof(TRVLevelComplete.<>c__DisplayClass82_1).__il2cppRuntimeField_8, value:  typeof(TRVLevelComplete.<>c__DisplayClass82_0).__il2cppRuntimeField_8);
        CompanyDevices val_53 = CompanyDevices.Instance;
        if((0.CompanyDevice() == false) || ((CPlayerPrefs.GetBool(key:  -1626825024, defaultValue:  false)) == false))
        {
            goto label_99;
        }
        
        System.Type val_56 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(160436224)});
        typeof(System.Type[]).__il2cppRuntimeField_10 = null;
        UnityEngine.GameObject val_57 = new UnityEngine.GameObject(name:  -1626824912, components:  473824320);
        UnityEngine.Transform val_58 = transform;
        UnityEngine.Transform val_59 = typeof(TRVLevelComplete.<>c__DisplayClass82_1).__il2cppRuntimeField_8.transform;
        SetParent(p:  typeof(TRVLevelComplete.<>c__DisplayClass82_1).__il2cppRuntimeField_8);
        UnityEngine.Transform val_60 = transform;
        MonoExtensions.ResetLocal(trans:  157720576);
        object val_61 = AddComponent<System.Object>();
        string val_62 = typeof(TRVLevelComplete.<>c__DisplayClass82_0).__il2cppRuntimeField_8.ToString();
        object val_63 = GetComponent<System.Object>();
        System.Type val_64 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(178008064)});
        UnityEngine.Object val_65 = UnityEngine.Resources.GetBuiltinResource(type:  178008064, path:  -1626823792);
        if(null != 0)
        {
                if(null != null)
        {
                null = 0;
        }
        
        }
    
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
