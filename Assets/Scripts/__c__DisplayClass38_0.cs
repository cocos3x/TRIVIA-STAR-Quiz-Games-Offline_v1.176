using UnityEngine;
private sealed class WFOEventPointsGainAnimator.<>c__DisplayClass38_0
{
    // Fields
    public System.Action onComplete;
    
    // Methods
    public WFOEventPointsGainAnimator.<>c__DisplayClass38_0()
    {
    
    }
    internal void <MoveSymbol>b__0()
    {
        if(this.onComplete == 0)
        {
                return;
        }
        
        this.onComplete.Invoke();
    }

}
