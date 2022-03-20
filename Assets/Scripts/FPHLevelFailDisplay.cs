using UnityEngine;
public class FPHLevelFailDisplay : MonoBehaviour
{
    // Fields
    private UnityEngine.CanvasGroup canvasGroup;
    private UnityEngine.UI.Text starsEarnedLabel;
    private UnityEngine.UI.Button buttonQuit;
    private UnityEngine.UI.Button buttonPlayAgain;
    
    // Properties
    private int entryCost { get; }
    
    // Methods
    private int get_entryCost()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if((public static FPHEcon App::GetGameSepeciticEcon<FPHEcon>()) != 0)
        {
                return (int)public System.Void System.Collections.Generic.List<FPHLetterSlotState>::.ctor().__il2cppRuntimeField_118;
        }
        
        return (int)public System.Void System.Collections.Generic.List<FPHLetterSlotState>::.ctor().__il2cppRuntimeField_118;
    }
    private void Start()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1624411600, method:  new IntPtr(2670521456));
        this.buttonQuit.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1624411600, method:  new IntPtr(2670530672));
        this.buttonPlayAgain.m_OnClick.AddListener(call:  162246656);
        this.Hide();
    }
    public void Show()
    {
        FPHGameplayController val_1 = FPHGameplayController.Instance;
        string val_2 = System.String.Format(format:  -1631218480, arg0:  13152256);
        UnityEngine.GameObject val_3 = this.gameObject;
        this.SetActive(value:  true);
        if(this.canvasGroup != 0)
        {
                this.canvasGroup.blocksRaycasts = true;
        }
        else
        {
                0.blocksRaycasts = true;
        }
        
        this.canvasGroup.interactable = true;
        this.canvasGroup.alpha = null;
        DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.canvasGroup, endValue:  null, duration:  null);
    }
    public void Hide()
    {
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
        UnityEngine.GameObject val_1 = this.canvasGroup.gameObject;
        this.SetActive(value:  false);
    }
    public void OnButtonQuit()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_2 = ShowInterstitial(context:  2);
        GameBehavior val_3 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public void OnButtonPlayAgain()
    {
        Player val_1 = App.Player;
        int val_2 = this.entryCost;
        decimal val_3 = System.Decimal.op_Implicit(value:  -1623906020);
        if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal())) == false)
        {
                return;
        }
        
        if(this.canvasGroup != 0)
        {
                this.canvasGroup.interactable = false;
        }
        else
        {
                0.interactable = false;
        }
        
        this.canvasGroup.blocksRaycasts = false;
    }
    public FPHLevelFailDisplay()
    {
    
    }

}
