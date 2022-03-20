using UnityEngine;
public class TRVBigQuizEventPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text descText;
    private UnityEngine.UI.Text progressText;
    private UnityEngine.UI.Text rewardText;
    private UnityEngine.UI.Text contineButtonText;
    private UnityEngine.UI.Image fillBar;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Button continueButton;
    private GemsCollectAnimationInstantiator gemAnim;
    
    // Methods
    private void OnEnable()
    {
        this.SetupUI();
    }
    private void SetupUI()
    {
        var val_12;
        float val_29;
        var val_30;
        UnityEngine.UI.Text val_31;
        var val_32;
        var val_33;
        var val_34;
        float val_35;
        var val_36;
        GemsCollectAnimationInstantiator val_37;
        var val_38;
        var val_39;
        UnityEngine.UI.Text val_40;
        val_29 = 1152921504769093632;
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -428550928, method:  new IntPtr(3866315600));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        string val_2 = TRVBigQuizEvent.EVENT_TRACKING_ID + 28.ToString();
        UnityEngine.GameObject val_3 = this.closeButton.gameObject;
        if(TRVBigQuizEvent.EVENT_TRACKING_ID == null)
        {
            goto label_8;
        }
        
        this.closeButton.SetActive(value:  false);
        var val_28 = 23418531;
        val_28 = 12207256 + val_28;
        if(val_28 == 0)
        {
                mem2[0] = 1;
        }
        
        val_30 = null;
        val_30 = null;
        if(App.game != 17)
        {
            goto label_14;
        }
        
        val_31 = this.rewardText;
        val_32 = null;
        val_33 = "+{0}";
        goto label_15;
        label_8:
        this.closeButton.SetActive(value:  true);
        val_29 = TRVBigQuizEvent.EVENT_TRACKING_ID.eventProgress;
        string val_5 = Localization.Localize(key:  -428634288, defaultValue:  -428634192, useSingularKey:  false);
        int val_6 = TRVBigQuizEvent.EVENT_TRACKING_ID.m_stringLength + 32;
        System.DateTime val_7 = TRVBigQuizEvent.EVENT_TRACKING_ID + 28.ToLocalTime();
        System.DayOfWeek val_9 = TRVBigQuizEvent.EVENT_TRACKING_ID + 28.DayOfWeek;
        int val_10 = TRVBigQuizEvent.EVENT_TRACKING_ID.m_stringLength + 32;
        System.DateTime val_11 = ToLocalTime();
        string val_14 = val_12.ToString(format:  -428634000);
        string val_15 = System.String.Format(format:  -428634288, arg0:  13152256, arg1:  10063872, arg2:  -428562984);
        val_34 = 1152921512768129872;
        if(val_29 == 0)
        {
            goto label_19;
        }
        
        val_35 = (float)val_29 / ((float)TRVBigQuizEvent.EVENT_TRACKING_ID + 24);
        goto label_20;
        label_14:
        if(val_28 == 0)
        {
                mem2[0] = 1;
        }
        
        val_36 = null;
        val_36 = null;
        if(App.game != 19)
        {
            goto label_26;
        }
        
        val_31 = this.rewardText;
        val_32 = null;
        val_33 = "{0}";
        label_15:
        string val_16 = System.String.Format(format:  -1225078832, arg0:  13152256);
        label_26:
        this.fillBar.fillAmount = null;
        string val_17 = Localization.Localize(key:  -1827401648, defaultValue:  -1827401552, useSingularKey:  false);
        val_34 = 1152921504619999232;
        string val_18 = System.String.Format(format:  -428613424, arg0:  13152256);
        UnityEngine.Events.UnityAction val_19 = new UnityEngine.Events.UnityAction(object:  -428550928, method:  new IntPtr(3866362160));
        this.continueButton.m_OnClick.AddListener(call:  162246656);
        val_37 = this.gemAnim;
        mem2[0] = new System.Action(object:  -428550928, method:  new IntPtr(3866315600));
        this.gemAnim.Create();
        string val_21 = Localization.Localize(key:  -428595760, defaultValue:  -428595920, useSingularKey:  false);
        val_38 = "big_quiz_reward";
        val_12 = TRVBigQuizEvent.EVENT_TRACKING_ID + 24;
        string val_22 = System.String.Format(format:  -428595760, arg0:  13152256);
        string val_23 = Localization.Localize(key:  -428595648, defaultValue:  -428595520, useSingularKey:  false);
        string val_24 = -428595760(-428595760) + 1269544832 + -428595648(-428595648);
        val_39 = val_38;
        val_40 = this.descText;
        goto label_35;
        label_19:
        val_35 = 0f;
        label_20:
        this.fillBar.fillAmount = null;
        val_37 = this.progressText;
        val_12 = TRVBigQuizEvent.EVENT_TRACKING_ID + 24;
        string val_25 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        UnityEngine.Events.UnityAction val_26 = null;
        val_38 = val_26;
        val_26 = new UnityEngine.Events.UnityAction(object:  -428550928, method:  new IntPtr(3866315600));
        this.continueButton.m_OnClick.AddListener(call:  162246656);
        val_40 = this.contineButtonText;
        string val_27 = Localization.Localize(key:  -1468908784, defaultValue:  -1621736080, useSingularKey:  false);
        val_39 = "continue_upper";
        label_35:
        if(val_40 != 0)
        {
                return;
        }
    
    }
    private void Collect()
    {
        int val_4;
        int val_5;
        int val_6;
        int val_7;
        this.continueButton.interactable = false;
        Player val_1 = App.Player;
        var val_9 = 23428707;
        val_9 = 12209180 + val_9;
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        TRVBigQuizEvent.EVENT_TRACKING_ID.OnCollect();
        Player val_2 = App.Player;
        decimal val_3 = System.Decimal.op_Implicit(value:  -428360864);
        this.gemAnim.Play(fromValue:  0, toValue:  new System.Decimal() {flags = val_5, hi = val_6, lo = val_7, mid = val_4}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
        NotificationCenter val_8 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -428348816, aName:  -1649709760);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    private void OnDisable()
    {
        if(TRVBigQuizEvent.EVENT_TRACKING_ID == null)
        {
                return;
        }
        
        goto typeof(System.String).__il2cppRuntimeField_2C4;
    }
    public TRVBigQuizEventPopup()
    {
    
    }

}
