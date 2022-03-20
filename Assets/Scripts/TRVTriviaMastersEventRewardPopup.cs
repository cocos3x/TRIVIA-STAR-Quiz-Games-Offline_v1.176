using UnityEngine;
public class TRVTriviaMastersEventRewardPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button collectButton;
    private UnityEngine.UI.Text description;
    private UnityEngine.UI.Text rewardText;
    private UnityEngine.UI.Text progressText;
    private UnityEngine.UI.Image rewardIcon;
    private UnityEngine.Sprite coinSp;
    private UnityEngine.Sprite gemSp;
    private GridCoinCollectAnimationInstantiator coinAnim;
    private GemsCollectAnimationInstantiator gemAnim;
    
    // Methods
    public void SetupUI(int tokens, TRVReward reward)
    {
        UnityEngine.UI.Image val_11;
        UnityEngine.Sprite val_12;
        if(new System.Object() != 0)
        {
                typeof(TRVTriviaMastersEventRewardPopup.<>c__DisplayClass9_0).__il2cppRuntimeField_8 = this;
        }
        else
        {
                mem[8] = this;
        }
        
        typeof(TRVTriviaMastersEventRewardPopup.<>c__DisplayClass9_0).__il2cppRuntimeField_C = reward;
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  365600768, method:  new IntPtr(3887100672));
        this.collectButton.m_OnClick.AddListener(call:  162246656);
        if((reward + 8) != 0)
        {
                this.coinAnim.SetActive(value:  false);
            val_11 = this.rewardIcon;
            val_12 = this.gemSp;
        }
        else
        {
                UnityEngine.GameObject val_3 = this.gemAnim.gameObject;
            this.gemAnim.SetActive(value:  false);
            val_11 = this.rewardIcon;
            val_12 = this.coinSp;
        }
        
        val_11.sprite = val_12;
        string val_4 = Localization.Localize(key:  -407840864, defaultValue:  -407841024, useSingularKey:  false);
        string val_5 = System.String.Format(format:  -407840864, arg0:  13152256);
        string val_6 = Localization.Localize(key:  -428595648, defaultValue:  -428595520, useSingularKey:  false);
        string val_7 = -407840864(-407840864) + 1269544832 + -428595648(-428595648);
        string val_9 = (reward + 12).ToString();
        string val_10 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        if(this.progressText != 0)
        {
                return;
        }
    
    }
    private void CollectReward(TRVReward reward)
    {
        int val_5;
        int val_6;
        int val_7;
        int val_8;
        TriviaMastersEventHandler val_15;
        int val_16;
        int val_17;
        var val_16 = 27340477;
        val_16 = 8289776 + val_16;
        if(val_16 == 0)
        {
                mem2[0] = 1;
        }
        
        val_15 = TriviaMastersEventHandler.<Instance>k__BackingField;
        val_15.CollectReward();
        if(reward.rewardType != 0)
        {
                if(reward.rewardType != 1)
        {
                return;
        }
        
            System.Action val_1 = new System.Action(object:  -407617712, method:  new IntPtr(3887312272));
            mem2[0] = null;
            Player val_2 = App.Player;
            val_16 = reward.rewardAmount;
            val_15 = 0;
            Player val_3 = App.Player;
            val_17 = 0;
            decimal val_4 = System.Decimal.op_Implicit(value:  -407629764);
            this.gemAnim.Play(fromValue:  val_15 - val_16, toValue:  new System.Decimal() {flags = val_7, hi = val_8, lo = val_6, mid = val_5}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
            return;
        }
        
        System.Action val_10 = new System.Action(object:  -407617712, method:  new IntPtr(3887312272));
        this.coinAnim.OnCompleteCallback = null;
        val_16 = this.coinAnim;
        Player val_11 = App.Player;
        var val_12 = 0 + 60;
        int val_17 = reward.rewardAmount;
        val_17 = (System.Decimal.op_Explicit(value:  new System.Decimal() {flags = mem[(0 + 60) + (0)], hi = mem[(0 + 60) + (4)], lo = mem[(0 + 60) + (8)], mid = 256})) - val_17;
        decimal val_14 = System.Decimal.op_Implicit(value:  -407629764);
        Player val_15 = App.Player;
        val_16.Play(fromValue:  new System.Decimal() {mid = val_5}, toValue:  new System.Decimal() {hi = val_15, lo = val_17}, textTickTime:  null, delayBeforeComplete:  null);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
        if((TriviaMastersEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        TriviaMastersEventHandler.<Instance>k__BackingField.OnMyEventPopupClosed();
    }
    public TRVTriviaMastersEventRewardPopup()
    {
    
    }

}
