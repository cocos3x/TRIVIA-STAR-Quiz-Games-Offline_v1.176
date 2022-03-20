using UnityEngine;
public class ForestFrenzyForestCompleteRewardPopup : MonoBehaviour
{
    // Fields
    private CoinCurrencyCollectAnimationInstantiator coins_anim;
    private UnityEngine.UI.Text text_reward_amount;
    private int fromValue;
    
    // Methods
    private void Awake()
    {
        var val_3;
        System.Action val_1 = new System.Action(object:  -1396293504, method:  new IntPtr(2898648768));
        System.Delegate val_2 = System.Delegate.Combine(a:  static_value_021FCEA3, b:  7454720);
        val_3 = 35638947;
        val_3 = 0;
        mem2[0] = val_3;
    }
    private void Init()
    {
        null = null;
        string val_1 = ToString();
        Player val_2 = App.Player;
        var val_3 = 0 + 60;
        int val_9 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = mem[(0 + 60) + (0)], hi = mem[(0 + 60) + (4)], lo = mem[(0 + 60) + (8)], mid = 256});
        val_9 = val_9 - (System.Decimal.op_Explicit(value:  new System.Decimal() {flags = ForestFrenzyEcon.ForestCompleteReward}));
        this.fromValue = val_9;
        this.coins_anim.SetStatViewValue(instantValue:  val_9);
        System.Action val_6 = new System.Action(object:  -1396164096, method:  new IntPtr(2898778176));
        mem2[0] = null;
        System.Collections.IEnumerator val_7 = this.AnimateReward();
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  -1396164096);
    }
    private System.Collections.IEnumerator AnimateReward()
    {
        object val_1 = new System.Object();
        typeof(ForestFrenzyForestCompleteRewardPopup.<AnimateReward>d__5).__il2cppRuntimeField_8 = 0;
        typeof(ForestFrenzyForestCompleteRewardPopup.<AnimateReward>d__5).__il2cppRuntimeField_10 = this;
    }
    private void OnCoinsComplete()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1395927808, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public ForestFrenzyForestCompleteRewardPopup()
    {
    
    }

}
