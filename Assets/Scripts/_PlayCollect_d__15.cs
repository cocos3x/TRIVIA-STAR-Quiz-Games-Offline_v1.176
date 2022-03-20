using UnityEngine;
private sealed class PetCardAnimationInstantiator.<PlayCollect>d__15 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public PetCardAnimationInstantiator <>4__this;
    private int <i>5__2;
    private PetCardAnimationInstantiator.PetCardReward <rwd>5__3;
    private WADPets.WADPetUpgradeRequirement <upgradeRequirement>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PetCardAnimationInstantiator.<PlayCollect>d__15(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_12;
        int val_13;
        PetCardAnimationInstantiator.PetCardReward val_14;
        WADPets.WADPetUpgradeRequirement val_15;
        object val_17;
        int val_18;
        WADPets.WADPet val_19;
        int val_20;
        int val_21;
        val_12 = 0;
        if((this.<>1__state) > 3)
        {
                return (bool)val_12;
        }
        
        var val_1 = 12869204 + (12869204 + (this.<>1__state) << 2);
        if((this.<>1__state) == 3)
        {
                12869204 + (this.<>1__state) << 2 = (12869204 + (this.<>1__state) << 2) & ((12869204 + (this.<>1__state) << 2) << (12869204 + (this.<>1__state) << 2));
            12869204 + (this.<>1__state) << 2 = (12869204 + (this.<>1__state) << 2) & ((R8) >> 32);
            12869204 + (this.<>1__state) << 2 = (12869204 + (this.<>1__state) << 2) & (((R8) << (32-12869204)) | ((R8) << 12869204));
            12869204 + (this.<>1__state) << 2 = (12869204 + (this.<>1__state) << 2) & (((int)R8) >> R3);
        }
        
        val_13 = 0;
        val_14 = this;
        this.<i>5__2 = val_13;
        this.<>1__state = 0;
        if( < 1152921512215363384)
        {
                if(1152921512215363384 <= )
        {
                var val_13 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            int val_5 =  + ( << 3);
            val_13 = val_13 + (val_5 << 2);
            val_5 = val_13 + 16;
            mem[1152921512215363416] = (0 + (((this.<i>5__2 + 1) + ((this.<i>5__2 + 1)) << 3)) << 2) + 48;
            WADPets.WADPetUpgradeRequirement val_6 = WADPetsManager.GetUpgradeRequirement(levelIndex:  D16 + 12);
            this.<upgradeRequirement>5__4 = D16 + 12;
            if((D16 + 12) <= (this.<i>5__2))
        {
                var val_14 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_14 = val_14 + ((this.<i>5__2) << 2);
            val_15 = this.<upgradeRequirement>5__4;
            if(((0 + (this.<i>5__2) << 2) + 16) == 0)
        {
                val_21 = mem[this.<rwd>5__3 + (8)];
            val_20 = mem[this.<rwd>5__3 + (4)];
            val_19 = mem[this.<rwd>5__3 + (0)];
        }
        
            (0 + (this.<i>5__2) << 2) + 16.Setup(pet:  val_19, progressStartBalance:  new System.Decimal() {flags = val_20, hi = val_21, lo = mem[this.<rwd>5__3 + (12)], mid = mem[this.<rwd>5__3 + (16)]}, upgradeRequirement:  val_15);
            if(((0 + (this.<i>5__2) << 2) + 16) <= )
        {
                var val_15 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_15 = val_15 + ( << 2);
            object val_7 = (0 + ((this.<i>5__2 + 1)) << 2) + 16.GetComponent<System.Object>();
            DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions46.DOFade(target:  (0 + ((this.<i>5__2 + 1)) << 2) + 16, endValue:  null, duration:  null);
            UnityEngine.WaitForSeconds val_9 = null;
            val_17 = val_9;
            val_9 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_12 = 1;
            this.<>1__state = val_12;
        }
        else
        {
                UnityEngine.WaitForSeconds val_10 = null;
            val_17 = val_10;
            val_10 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_18 = 3;
            this.<>1__state = val_18;
            val_12 = 1;
        }
        
        this.<>2__current = val_17;
        return (bool)val_12;
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
