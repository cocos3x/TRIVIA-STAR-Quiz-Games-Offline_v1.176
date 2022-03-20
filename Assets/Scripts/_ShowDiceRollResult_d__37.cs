using UnityEngine;
private sealed class WGSnakesAndLaddersBoardPopup.<ShowDiceRollResult>d__37 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGSnakesAndLaddersBoardPopup <>4__this;
    public SnakesAndLaddersEvent.DiceRollResult result;
    private WGSnakesAndLaddersBoardPopup.<>c__DisplayClass37_0 <>8__1;
    private UnityEngine.Vector3 <originalDiceRollPos>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGSnakesAndLaddersBoardPopup.<ShowDiceRollResult>d__37(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        WGSnakesAndLaddersBoardPopup val_29;
        UnityEngine.Transform val_30;
        var val_31;
        int val_32;
        if((this.<>1__state) <= 3)
        {
                val_29 = this.<>4__this;
            var val_1 = 7052328 + (7052328 + (this.<>1__state) << 2);
            if((this.<>1__state) == 3)
        {
                7052328 + (this.<>1__state) << 2 = (7052328 + (this.<>1__state) << 2) & ((7052328 + (this.<>1__state) << 2) << (7052328 + (this.<>1__state) << 2));
            7052328 + (this.<>1__state) << 2 = (7052328 + (this.<>1__state) << 2) & (((int)IP) >> 12);
            7052328 + (this.<>1__state) << 2 = (7052328 + (this.<>1__state) << 2) & ((IP) << 4);
            mem2[0] = (((7052328 + (this.<>1__state) << 2 & (7052328 + (this.<>1__state) << 2) << 7052328 + (this.<>1__state) << 2) & ((int)IP) >> 12) & (IP) << 4) + IP;
        }
        
            this.<>1__state = 0;
            this.<>8__1 = new System.Object();
            typeof(WGSnakesAndLaddersBoardPopup.<>c__DisplayClass37_0).__il2cppRuntimeField_8 = this.<>4__this;
            this.<>8__1.result = this.result;
            UnityEngine.Transform val_3 = this.<>4__this.diceRollAnim.transform;
            UnityEngine.Vector3 val_4 = position;
            UnityEngine.Transform val_5 = this.<>4__this.diceRollAnim.transform;
            val_30 = this.<>4__this.diceRollTarget;
            UnityEngine.Vector3 val_6 = position;
            DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.<>4__this.diceRollAnim, endValue:  new UnityEngine.Vector3(), duration:  val_6.x, snapping:  true);
            System.Collections.IEnumerator val_8 = this.<>4__this.diceRollAnim.AnimateRandomPointSp(result:  this.<>8__1.result.Point);
            UnityEngine.Coroutine val_9 = this.<>4__this.diceRollAnim.StartCoroutine(routine:  this.<>4__this.diceRollAnim);
            var val_29 = 28573080;
            val_29 = 7052712 + val_29;
            if(val_29 == 0)
        {
                mem2[0] = 1;
        }
        
            SnakesAndLaddersEvent.BoardSpaceReward val_10 = SnakesAndLaddersEventHandler.<Instance>k__BackingField.GetBoardSpaceReward();
            this.<>8__1.spaceReward = SnakesAndLaddersEventHandler.<Instance>k__BackingField;
            UnityEngine.WaitForSeconds val_11 = null;
            val_31 = val_11;
            val_11 = new UnityEngine.WaitForSeconds(seconds:  val_6.x);
            val_32 = 1;
            this.<>1__state = val_32;
            mem2[0] = ;
            return (bool)val_32;
        }
        
        val_32 = 0;
        return (bool)val_32;
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
