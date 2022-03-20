using UnityEngine;
public class ForestMasterRewardPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text coinsRewardText;
    private UnityEngine.UI.Text acornsRewardText;
    private UnityEngine.UI.Button collectButton;
    private GridCoinCollectAnimationInstantiator coinsAnim;
    private GoldenCurrencyCollectAnimationInstantiator acornsAnim;
    
    // Methods
    private void Start()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1419891536, method:  new IntPtr(2875042544));
        this.collectButton.m_OnClick.AddListener(call:  162246656);
        decimal val_2 = GetCoinReward(showCurrentLevel:  ForestMasterEventHandler.<Instance>k__BackingField);
        GameEcon val_3 = App.getGameEcon;
        string val_4 = ToString(format:  null);
        GameEcon val_6 = App.getGameEcon;
        string val_7 = ForestMasterEventHandler.<Instance>k__BackingField.GetAcornReward(showCurrentLevel:  false).ToString(format:  null);
        if(this.acornsRewardText != 0)
        {
                return;
        }
    
    }
    private void OnCollectClicked()
    {
        int val_2;
        int val_3;
        int val_4;
        int val_5;
        int val_13;
        int val_17;
        int val_18;
        int val_19;
        int val_20;
        System.Action val_23;
        this.collectButton.interactable = false;
        decimal val_1 = GetCoinReward(showCurrentLevel:  ForestMasterEventHandler.<Instance>k__BackingField);
        Player val_7 = App.Player;
        0.AddCredits(amount:  new System.Decimal() {flags = val_4, hi = val_5, lo = val_2, mid = val_3}, source:  "Forest Master Reward", subSource:  0, externalParams:  0, doTrack:  true);
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Player val_9 = App.Player;
        var val_10 = 0 + 60;
        decimal val_11 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1419761796, hi = mem[(0 + 60) + (0)], lo = mem[(0 + 60) + (4)], mid = mem[(0 + 60) + (8)]}, d2:  new System.Decimal() {flags = 256, hi = val_4, lo = val_5, mid = val_2});
        Player val_12 = App.Player;
        this.coinsAnim.Play(fromValue:  new System.Decimal() {mid = val_13}, toValue:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, textTickTime:  null, delayBeforeComplete:  null);
        Player val_14 = App.Player;
        Player val_15 = App.Player;
        decimal val_16 = System.Decimal.op_Implicit(value:  -1419761812);
        mem[1152921511777031868].Play(fromValue:  4 - (ForestMasterEventHandler.<Instance>k__BackingField.GetAcornReward(showCurrentLevel:  false)), toValue:  new System.Decimal() {flags = val_19, hi = val_20, lo = val_18, mid = val_17}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
        System.Action val_22 = new System.Action(object:  -1419749728, method:  new IntPtr(2875192544));
        System.Delegate val_23 = System.Delegate.Combine(a:  this.coinsAnim.OnCompleteCallback, b:  7454720);
        val_23 = this.coinsAnim.OnCompleteCallback;
        if(val_23 != 0)
        {
                if(null == null)
        {
            goto label_23;
        }
        
        }
        
        val_23 = 0;
        label_23:
        this.coinsAnim.OnCompleteCallback = val_23;
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1419625440, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        if((ForestMasterEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        if((ForestMasterEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  R4, aName:  -1649709760);
    }
    public ForestMasterRewardPopup()
    {
    
    }

}
