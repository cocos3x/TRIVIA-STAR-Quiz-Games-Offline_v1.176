using UnityEngine;
private sealed class TRVLevelComplete.<>c__DisplayClass83_0
{
    // Fields
    public TRVLevelComplete <>4__this;
    public int multi;
    
    // Methods
    public TRVLevelComplete.<>c__DisplayClass83_0()
    {
    
    }
    internal void <MultiplierPicked>b__0()
    {
        var val_7;
        UnityEngine.GameObject val_1 = this.<>4__this.noThanksButton.gameObject;
        this.<>4__this.noThanksButton.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.<>4__this.redrawButton.gameObject;
        this.<>4__this.redrawButton.SetActive(value:  false);
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        RewardMultiPicked(multi:  this.multi);
        if((this.<>4__this) != 0)
        {
                System.Collections.IEnumerator val_4 = this.<>4__this.SetupPostMinigameState();
            val_7 = this.<>4__this;
        }
        else
        {
                System.Collections.IEnumerator val_5 = 0.SetupPostMinigameState();
            val_7 = 0;
        }
        
        UnityEngine.Coroutine val_6 = this.<>4__this.StartCoroutine(routine:  0);
    }

}
