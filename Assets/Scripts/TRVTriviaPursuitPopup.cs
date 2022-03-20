using UnityEngine;
public class TRVTriviaPursuitPopup : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<TRVTriviaPursuitCategoryDisplay> categories;
    private UnityEngine.UI.Text description;
    private UnityEngine.UI.Text reward;
    private UnityEngine.UI.Text rerollCost;
    private UnityEngine.GameObject regularButtonsBottom;
    private UnityEngine.UI.Button rerollButton;
    private UnityEngine.UI.Button continueButton;
    private UnityEngine.UI.Button collectButton;
    private UnityEngine.UI.Button closeButton;
    private GemsCollectAnimationInstantiator gemAnim;
    
    // Methods
    public void ShowEventPopup(TRVTriviaPursuitPopupGeneralDisplayInfo info)
    {
        var val_8;
        var val_9;
        this.rerollButton.m_OnClick.RemoveAllListeners();
        this.continueButton.m_OnClick.RemoveAllListeners();
        this.closeButton.m_OnClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -397742000, method:  new IntPtr(3897149072));
        this.rerollButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -397742000, method:  new IntPtr(3897158288));
        this.continueButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -397742000, method:  new IntPtr(3897167504));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        this.regularButtonsBottom.SetActive(value:  true);
        UnityEngine.GameObject val_4 = this.collectButton.gameObject;
        this.collectButton.SetActive(value:  false);
        string val_6 = info + 16.ToString();
        string val_7 = info.rerollCost.ToString();
        if(info.isEligibleToReroll == true)
        {
                val_8 = 1;
        }
        
        this.rerollButton.interactable = true;
        if(info.shouldAnimateCategories != false)
        {
                this.AnimateCategoryReroll(finalDisplayInfo:  1);
            return;
        }
        
        val_9 = 4;
        goto label_22;
        label_29:
        if(info.shouldAnimateCategories <= this.rerollButton)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_8 = 2621443;
        if(0 <= this.rerollButton)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_8.Setup(info:  2621443);
        val_9 = 5;
        label_22:
        if((val_9 - 4) < val_8)
        {
            goto label_29;
        }
    
    }
    public void ShowRewardPopup(TRVTriviaPursuitPopupRewardDisplayInfo info)
    {
        var val_7;
        if(new System.Object() != 0)
        {
                typeof(TRVTriviaPursuitPopup.<>c__DisplayClass11_0).__il2cppRuntimeField_8 = this;
        }
        else
        {
                mem[8] = this;
        }
        
        typeof(TRVTriviaPursuitPopup.<>c__DisplayClass11_0).__il2cppRuntimeField_C = info;
        this.regularButtonsBottom.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.closeButton.gameObject;
        this.closeButton.SetActive(value:  false);
        val_7 = 4;
        goto label_6;
        label_14:
        if(this.closeButton <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((info + 8 + 12) <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        2621443.Setup(info:  info + 8 + 8 + 16);
        val_7 = 5;
        label_6:
        if((val_7 - 4) < 2621443)
        {
            goto label_14;
        }
        
        this.description.resizeTextForBestFit = false;
        string val_5 = (info + 16).ToString();
        UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  366346240, method:  new IntPtr(3897440272));
        this.collectButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.GameObject val_7 = this.collectButton.gameObject;
        this.collectButton.SetActive(value:  true);
    }
    private void AnimateCategoryReroll(System.Collections.Generic.List<TRVTriviaPursuitCategoryDisplayInfo> finalDisplayInfo)
    {
        var val_4;
        var val_5;
        val_4 = 4;
        goto label_1;
        label_16:
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_2 = getAvailableSubCategories;
        val_5 = null;
        val_5 = null;
        if((TRVDataParser.categoryNames + 12) <= SL)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        string val_3 = Item[TRVDataParser.categoryNames + 8 + 16];
        if((public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance()) <= SL)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(0 <= SL)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        2621443.AnimateCategory(incCats:  -1484293744, finalInfo:  2621443);
        val_4 = 5;
        label_1:
        if((val_4 - 4) < 2621443)
        {
            goto label_16;
        }
    
    }
    private void OnClick_Reroll()
    {
        TRVTriviaPursuitEventHandler.<Instance>k__BackingField.RerollAnimateCategories();
    }
    private void OnClick_Continue()
    {
        this.Close();
    }
    private void OnClick_Collect(int reward)
    {
        int val_5;
        int val_6;
        int val_7;
        int val_8;
        var val_10 = 27320547;
        val_10 = 8309708 + val_10;
        if(val_10 == 0)
        {
                mem2[0] = 1;
        }
        
        TRVTriviaPursuitEventHandler.<Instance>k__BackingField.CollectReward();
        System.Action val_1 = new System.Action(object:  -396972080, method:  new IntPtr(3897149072));
        mem2[0] = null;
        Player val_2 = App.Player;
        Player val_3 = App.Player;
        decimal val_4 = System.Decimal.op_Implicit(value:  -396984128);
        this.gemAnim.Play(fromValue:  0 - reward, toValue:  new System.Decimal() {flags = val_7, hi = val_8, lo = val_6, mid = val_5}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    private void OnDisable()
    {
        if((TRVTriviaPursuitEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        TRVTriviaPursuitEventHandler.<Instance>k__BackingField.OnMyEventPopupClosed();
    }
    public TRVTriviaPursuitPopup()
    {
    
    }

}
