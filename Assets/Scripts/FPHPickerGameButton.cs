using UnityEngine;
public class FPHPickerGameButton : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image myImage;
    public System.Action onClickAction;
    public System.Action onAnimationComplete;
    private int myMulti;
    private UnityEngine.Sprite defaultSprite;
    private UnityEngine.Sprite specificSprite;
    private UnityEngine.UI.Image chosenOutline;
    
    // Properties
    public UnityEngine.UI.Button myButton { get; }
    public UnityEngine.Sprite SetSpecificSprite { set; }
    
    // Methods
    public UnityEngine.UI.Button get_myButton()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(this != 0)
        {
                return this.GetComponent<System.Object>();
        }
        
        return this.GetComponent<System.Object>();
    }
    public void set_SetSpecificSprite(UnityEngine.Sprite value)
    {
        this.specificSprite = value;
    }
    private void Start()
    {
        UnityEngine.UI.Button val_1 = this.myButton;
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1623424464, method:  new IntPtr(2671509616));
        this.AddListener(call:  162246656);
        twelvegigs.Autopilot.WUTAutopilotGameplay val_3 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  this.myImage);
        this.myImage.alpha = null;
        UnityEngine.GameObject val_4 = this.chosenOutline.gameObject;
        this.chosenOutline.SetActive(value:  false);
    }
    public void OnClick()
    {
        if(this.onClickAction == 0)
        {
                return;
        }
        
        this.onClickAction.Invoke();
    }
    public void RevealMe(bool selected)
    {
        System.Collections.IEnumerator val_1 = this.doReveal(selected:  selected);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -1623184080);
    }
    private System.Collections.IEnumerator doReveal(bool selected)
    {
        typeof(FPHPickerGameButton.<doReveal>d__14).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(FPHPickerGameButton.<doReveal>d__14).__il2cppRuntimeField_10 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        typeof(FPHPickerGameButton.<doReveal>d__14).__il2cppRuntimeField_14 = selected;
    }
    public void SetImageLocation(UnityEngine.Transform pos)
    {
        UnityEngine.GameObject val_1 = this.chosenOutline.gameObject;
        this.chosenOutline.SetActive(value:  false);
        this.myImage.sprite = this.defaultSprite;
        UnityEngine.Transform val_2 = this.myImage.transform;
        UnityEngine.Vector3 val_3 = position;
        this.myImage.position = new UnityEngine.Vector3();
        twelvegigs.Autopilot.WUTAutopilotGameplay val_4 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  this.myImage);
        this.myImage.alpha = val_3.x;
    }
    public void TweenImageHome(float duration)
    {
        twelvegigs.Autopilot.WUTAutopilotGameplay val_1 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  this.myImage);
        float val_6 = 0.4f;
        val_6 = R1 * val_6;
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.myImage, endValue:  val_6, duration:  null);
        UnityEngine.Transform val_3 = this.myImage.transform;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.myImage, endValue:  new UnityEngine.Vector3(), duration:  val_4.x, snapping:  R1);
    }
    public FPHPickerGameButton()
    {
    
    }

}
