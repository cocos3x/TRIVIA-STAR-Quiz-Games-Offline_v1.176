using UnityEngine;
private sealed class AttackScreenMain.<>c__DisplayClass43_0
{
    // Fields
    public WordForest.AttackScreenMain <>4__this;
    public WordForest.WFOTree attackedTree;
    
    // Methods
    public AttackScreenMain.<>c__DisplayClass43_0()
    {
    
    }
    internal void <EndAttack>b__0()
    {
        UnityEngine.GameObject val_1 = this.<>4__this.efxChopAction.gameObject;
        this.<>4__this.efxChopAction.SetActive(value:  true);
        this.<>4__this.efxChopAction.Play();
        if((this.<>4__this.isSuccessful) != false)
        {
                DG.Tweening.Sequence val_2 = this.attackedTree.SetGrowthState(state:  2, instant:  true, delayGrowth:  false, shadowParent:  0);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  247779888, clipIndex:  0);
            return;
        }
        
        UnityEngine.Transform val_4 = this.<>4__this.blockShieldImage.transform;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        this.<>4__this.blockShieldImage.localScale = new UnityEngine.Vector3();
        UnityEngine.GameObject val_6 = this.<>4__this.blockShieldImage.gameObject;
        this.<>4__this.blockShieldImage.SetActive(value:  true);
        UnityEngine.Transform val_7 = this.<>4__this.blockShieldImage.transform;
        DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.blockShieldImage, endValue:  val_5.x, duration:  val_5.y);
        object val_9 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.<>4__this.blockShieldImage, ease:  6);
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  247804560, clipIndex:  0);
    }

}
