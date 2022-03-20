using UnityEngine;
public class TRVQuestionButton : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text myText;
    private string <myAnswer>k__BackingField;
    private UnityEngine.ParticleSystem questionCorrectEffect;
    private CurrencyParticles rankupEffect;
    private UnityEngine.Color defaultColor;
    private UnityEngine.Color correctColor;
    private UnityEngine.Color incorrectColor;
    private UnityEngine.UI.Image expertSprite;
    
    // Properties
    public string myAnswer { get; set; }
    
    // Methods
    public string get_myAnswer()
    {
    
    }
    private void set_myAnswer(string value)
    {
        this.<myAnswer>k__BackingField = value;
    }
    public void SetupButton(string answerToDisplay)
    {
        object val_1 = this.GetComponent<System.Object>();
        static_value_021FC8E7.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -457154336, method:  new IntPtr(3837767456));
        R7.AddListener(call:  162246656);
        UnityEngine.UI.Image val_3 = this.image;
        this.<myAnswer>k__BackingField = answerToDisplay;
        UnityEngine.Color val_4 = UnityEngine.Color.white;
        this.myText.color = new UnityEngine.Color() {a = ???};
        CompanyDevices val_5 = CompanyDevices.Instance;
        if((0.CompanyDevice() != false) && ((CPlayerPrefs.GetBool(key:  -831437248, defaultValue:  false)) != false))
        {
                twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((System.String.op_Equality(a:  this.<myAnswer>k__BackingField, b:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 20 + 24)) != false)
        {
                UnityEngine.Color val_10 = UnityEngine.Color.green;
            this.myText.color = new UnityEngine.Color() {a = ???};
        }
        
        }
        
        UnityEngine.GameObject val_11 = this.expertSprite.gameObject;
        this.expertSprite.SetActive(value:  false);
    }
    public void SetAnswerSelectedState(string correctAnswer, string selectedAnswer)
    {
        int val_10;
        var val_11;
        var val_12;
        var val_13;
        UnityEngine.Color val_14;
        if((System.String.op_Inequality(a:  this.<myAnswer>k__BackingField, b:  correctAnswer)) != false)
        {
                if((System.String.op_Inequality(a:  this.<myAnswer>k__BackingField, b:  selectedAnswer)) != false)
        {
                this.SetButtonState(state:  false, immediate:  false);
            return;
        }
        
        }
        
        object val_3 = this.GetComponent<System.Object>();
        UnityEngine.UI.Image val_4 = this.image;
        val_10 = this;
        if((System.String.op_Equality(a:  this.<myAnswer>k__BackingField, b:  correctAnswer)) != false)
        {
                val_11 = 1152921512739792536;
            val_12 = 1152921512739792532;
            val_13 = 1152921512739792528;
            val_14 = this.correctColor;
        }
        else
        {
                val_11 = 1152921512739792552;
            val_12 = 1152921512739792548;
            val_13 = 1152921512739792544;
            val_14 = this.incorrectColor;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((System.String.op_Equality(a:  selectedAnswer, b:  correctAnswer)) == false)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  this.<myAnswer>k__BackingField, b:  selectedAnswer)) == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        val_10 = 5;
        this.rankupEffect.PlayParticles(destinationPosition:  new UnityEngine.Vector3(), particleCount:  val_10, animateStatView:  true);
    }
    public void DisplayExpert(TRVExpert exp)
    {
        this.expertSprite.sprite = exp.mySprite;
        UnityEngine.GameObject val_1 = this.expertSprite.gameObject;
        this.expertSprite.SetActive(value:  true);
    }
    public void SetButtonState(bool state, bool immediate = False)
    {
        if(state == true)
        {
                0f = 1f;
        }
        
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.UI.LayoutElement val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -456703648);
        if(immediate != false)
        {
                this.alpha = 1f;
        }
        else
        {
                DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOFade(target:  -456703648, endValue:  1f, duration:  null);
        }
        
        object val_4 = this.GetComponent<System.Object>();
        this.enabled = state;
    }
    private void OnButtonClicked()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        OnAnswerClicked(selectedAnswer:  this.<myAnswer>k__BackingField);
    }
    public TRVQuestionButton()
    {
        UnityEngine.Color val_1 = new UnityEngine.Color(r:  null, g:  null, b:  null);
        UnityEngine.Color val_2 = new UnityEngine.Color(r:  null, g:  null, b:  null);
        UnityEngine.Color val_3 = new UnityEngine.Color(r:  null, g:  null, b:  null);
    }

}
