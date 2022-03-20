using UnityEngine;
public class WGMysteryGiftPopup : MonoBehaviour
{
    // Fields
    protected UnityEngine.UI.Button collectButton;
    protected UnityEngine.UI.Text coinAmountText;
    protected GridCoinCollectAnimationInstantiator coinsAnim;
    
    // Methods
    protected virtual void Awake()
    {
        System.Action val_1 = new System.Action(object:  -1147889424, method:  typeof(WGMysteryGiftPopup).__il2cppRuntimeField_100);
        this.coinsAnim.OnCompleteCallback = null;
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1147889424, method:  typeof(WGMysteryGiftPopup).__il2cppRuntimeField_F0);
        this.collectButton.m_OnClick.AddListener(call:  162246656);
    }
    protected virtual void OnEnable()
    {
        UnityEngine.Debug.LogError(message:  -1147789136);
        GameEcon val_1 = App.getGameEcon;
        string val_2 = 792.ToString();
        if(this.coinAmountText == 0)
        {
            
        }
    
    }
    protected virtual void OnCollect()
    {
        int val_4;
        UnityEngine.Debug.LogError(message:  -1147789136);
        Player val_1 = App.Player;
        GameEcon val_2 = App.getGameEcon;
        decimal val_3 = System.Decimal.op_Implicit(value:  -1147656672);
        0.AddCredits(amount:  new System.Decimal() {mid = val_4}, source:  "Mystery Gift", subSource:  0, externalParams:  0, doTrack:  true);
        Player val_5 = App.Player;
        Player val_6 = App.Player;
        2621448.Save(writePrefs:  true);
        this.Invoke(methodName:  -1147668720, time:  null);
    }
    protected virtual void PlayCoinsAnim()
    {
        int val_6;
        Player val_1 = App.Player;
        GameEcon val_2 = App.getGameEcon;
        decimal val_3 = System.Decimal.op_Implicit(value:  -1147540580);
        decimal val_4 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1147540596, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
        Player val_5 = App.Player;
        this.coinsAnim.Play(fromValue:  new System.Decimal() {mid = val_6}, toValue:  new System.Decimal() {}, textTickTime:  null, delayBeforeComplete:  null);
    }
    protected virtual void OnCoinsAnimFinished()
    {
        CurrencyController.HandleBalanceChanged(type:  0);
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1147412432, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGMysteryGiftPopup()
    {
    
    }

}
