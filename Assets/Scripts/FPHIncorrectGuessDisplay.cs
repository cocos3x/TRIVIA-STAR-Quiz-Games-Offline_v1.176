using UnityEngine;
public class FPHIncorrectGuessDisplay : MonoBehaviour
{
    // Fields
    private UnityEngine.CanvasGroup canvasGroup;
    private UnityEngine.UI.Button buttonGuessAgain;
    private UnityEngine.UI.Button buttonRevealAnswer;
    private bool isShown;
    
    // Methods
    private void Start()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1635599376, method:  new IntPtr(2659325488));
        this.buttonGuessAgain.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1635599376, method:  new IntPtr(2659334704));
        this.buttonRevealAnswer.m_OnClick.AddListener(call:  162246656);
        if(this.canvasGroup != 0)
        {
                this.canvasGroup.blocksRaycasts = false;
        }
        else
        {
                0.blocksRaycasts = false;
        }
        
        this.canvasGroup.interactable = false;
        this.canvasGroup.alpha = null;
    }
    public void Show()
    {
        if(this.isShown == true)
        {
                return;
        }
        
        UnityEngine.GameObject val_1 = R4.gameObject;
        R4.SetActive(value:  true);
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  R4, name:  2128120864);
        mem2[0] = 1;
        if((R4 + 12) != 0)
        {
                R4 + 12.blocksRaycasts = true;
        }
        else
        {
                0.blocksRaycasts = true;
        }
        
        R4 + 12.interactable = true;
        R4 + 12.alpha = null;
        DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOFade(target:  R4 + 12, endValue:  null, duration:  null);
    }
    public void Hide()
    {
        if(this.isShown == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.RemoveObserver(observer:  -1635350800, name:  2128120864);
        this.isShown = false;
    }
    public void OnButtonGuessAgain()
    {
        var val_8;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((ShowIncentivizedVideo(tag:  0, adCapExempt:  false)) == true)
        {
                return;
        }
        
        GameBehavior val_3 = App.getBehavior;
        string val_5 = Localization.Localize(key:  2129276784, defaultValue:  2129276896, useSingularKey:  false);
        string val_6 = Localization.Localize(key:  2129276992, defaultValue:  2129277104, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_7 = Localization.Localize(key:  2129277264, defaultValue:  2129277376, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "try_again_later_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_8 = null;
        val_8 = null;
        0.SetupMessage(titleTxt:  2129276784, messageTxt:  2129276992, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
    }
    private void OnVideoResponse(Notification notif)
    {
        string val_1 = notif.data.ToString();
        if((System.Boolean.Parse(value:  notif.data)) == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        GuessAgain();
    }
    public void OnButtonRevealAnswer()
    {
        this.Hide();
        FPHGameplayController val_1 = FPHGameplayController.Instance;
        if(null == 0)
        {
            
        }
    
    }
    public FPHIncorrectGuessDisplay()
    {
    
    }

}
