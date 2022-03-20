using UnityEngine;
private sealed class WPTGameUIController.<CheckPetCapture>d__152 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordPets.WPTGameUIController <>4__this;
    private WordPets.WPTGameUIController.<>c__DisplayClass152_0 <>8__1;
    private bool <petFound>5__2;
    private int <column>5__3;
    private WordPets.WPTPetTile <tile>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WPTGameUIController.<CheckPetCapture>d__152(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_14;
        int val_15;
        System.Collections.Generic.List<WordPets.WPTGameColumn> val_16;
        val_14 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_14;
        }
        
        val_15 = 0;
        this.<column>5__3 = val_15;
        mem[1152921513384584584] = val_15;
        this.<>1__state = 0;
        goto label_3;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.gamemode.AddPetCaptured(newPet:  this.<tile>5__4.<myPet>k__BackingField.type);
        UnityEngine.GameObject val_1 = this.<tile>5__4.gameObject;
        this.<>8__1.remove = this.<tile>5__4;
        if((this.<tile>5__4) <= (this.<column>5__3))
        {
                var val_14 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_14 = val_14 + ((this.<column>5__3) << 2);
        (0 + (this.<column>5__3) << 2) + 16 + 16.RemoveAt(index:  0);
        DG.Tweening.TweenCallback val_2 = new DG.Tweening.TweenCallback(object:  this.<>8__1, method:  new IntPtr(187748272));
        DG.Tweening.Tween val_3 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1082130432, ignoreTimeScale:  false);
        this.<>4__this.UpdateProgressUI(skipAnimation:  false);
        this.<tile>5__4 = 0;
        this.<>8__1 = 0;
        goto label_19;
        label_31:
        if((this.<>4__this) <= (this.<column>5__3))
        {
                var val_15 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_15 = val_15 + 0;
        if(((0 + 0) + 16 + 16 + 12) < 1)
        {
            goto label_19;
        }
        
        if(((0 + 0) + 16 + 16 + 12) <= (this.<column>5__3))
        {
                var val_16 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_16 = val_16 + 0;
        if(((0 + 0) + 16 + 16 + 12) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        object val_4 = (0 + 0) + 16 + 16 + 8 + 16.GetComponent<System.Object>();
        if(((0 + 0) + 16 + 16 + 8 + 16) != 0)
        {
            goto label_28;
        }
        
        label_19:
        val_15 = (this.<column>5__3) + 1;
        this.<column>5__3 = val_15;
        label_3:
        val_16 = this.<>4__this.<currentColumns>k__BackingField;
        if(val_15 < (this.<column>5__3))
        {
            goto label_31;
        }
        
        if((this.<petFound>5__2) == true)
        {
                return (bool)val_14;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_14 = 0;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  4, oneshot:  true, pitch:  null, vol:  null);
        return (bool)val_14;
        label_28:
        object val_7 = new System.Object();
        this.<>8__1 = val_7;
        if(val_7 <= (this.<column>5__3))
        {
                var val_17 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_17 = val_17 + ((this.<column>5__3) << 2);
        if(((0 + (this.<column>5__3) << 2) + 16 + 16 + 12) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        object val_8 = (0 + (this.<column>5__3) << 2) + 16 + 16 + 8 + 16.GetComponent<System.Object>();
        this.<tile>5__4 = (0 + (this.<column>5__3) << 2) + 16 + 16 + 8 + 16;
        UnityEngine.Transform val_9 = (0 + (this.<column>5__3) << 2) + 16 + 16 + 8 + 16.transform;
        val_16 = this.<>4__this.petAnimationTransform;
        (0 + (this.<column>5__3) << 2) + 16 + 16 + 8 + 16.SetParent(parent:  val_16, worldPositionStays:  true);
        this.<petFound>5__2 = true;
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  7, oneshot:  true, pitch:  null, vol:  null);
        UnityEngine.Transform val_11 = this.<>4__this.levelProgressObject.transform;
        val_15 = this.<>4__this.levelProgressObject;
        UnityEngine.Vector3 val_12 = position;
        System.Collections.IEnumerator val_13 = this.<tile>5__4.AnimateCapture(targetFlyToPos:  new UnityEngine.Vector3());
        val_14 = 1;
        this.<>1__state = val_14;
        this.<>2__current = this.<tile>5__4;
        return (bool)val_14;
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
