using UnityEngine;
public class DisplayWordDefinition : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text wordText;
    private UnityEngine.UI.Text wordTypeText;
    private UnityEngine.UI.Text definitionText;
    private UnityEngine.GameObject closeButton;
    private string lookup;
    private string word;
    private string category;
    private string definition;
    private string loadingText;
    private string failureMessage;
    private System.Action showLoading;
    
    // Properties
    protected virtual bool checkTouchedMe { get; }
    
    // Methods
    private void Start()
    {
        object val_1 = this.closeButton.GetComponent<System.Object>();
        if(this.closeButton == 0)
        {
                return;
        }
        
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -956513600, method:  typeof(DisplayWordDefinition).__il2cppRuntimeField_100);
        this.closeButton.AddListener(call:  162246656);
    }
    protected virtual void OnEnable()
    {
        if(this.showLoading == 0)
        {
                return;
        }
        
        this.showLoading.Invoke();
    }
    private void ShowLoading()
    {
        System.Collections.IEnumerator val_1 = this.AppendDots();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -956277312);
    }
    public virtual void OpenButLoad(string word)
    {
        System.Action val_1 = new System.Action(object:  -956147904, method:  new IntPtr(3338794368));
        this.showLoading = null;
    }
    public virtual void Init(System.Collections.Generic.Dictionary<string, object> defToDisplay)
    {
        this.DisplayText(wordData:  defToDisplay);
        this.StopAllCoroutines();
    }
    protected void DisplayText(System.Collections.Generic.Dictionary<string, object> wordData)
    {
        object val_1 = wordData.Item[this.lookup];
        string val_2 = wordData.ToString();
        object val_3 = wordData.Item[this.category];
        string val_4 = wordData.ToString();
        string val_5 = wordData.ToLower();
        object val_6 = wordData.Item[this.definition];
        string val_7 = wordData.ToString();
        if(this.definitionText == 0)
        {
            
        }
    
    }
    private System.Collections.IEnumerator AppendDots()
    {
        object val_1 = new System.Object();
        typeof(DisplayWordDefinition.<AppendDots>d__17).__il2cppRuntimeField_8 = 0;
        typeof(DisplayWordDefinition.<AppendDots>d__17).__il2cppRuntimeField_10 = this;
    }
    public void OnFailure()
    {
        this.StopAllCoroutines();
        if(this.wordTypeText == 0)
        {
            
        }
    
    }
    protected virtual bool get_checkTouchedMe()
    {
        if(UnityEngine.Input.touchCount <= 0)
        {
                if((UnityEngine.Input.GetMouseButtonDown(button:  0)) == false)
        {
                return false;
        }
        
        }
        
        UnityEngine.EventSystems.EventSystem val_3 = UnityEngine.EventSystems.EventSystem.current;
        UnityEngine.GameObject val_4 = this.gameObject;
        if(35615780 == (-955477312))
        {
                return false;
        }
        
        UnityEngine.EventSystems.EventSystem val_6 = UnityEngine.EventSystems.EventSystem.current;
        return UnityEngine.Object.op_Inequality(x:  35615780, y:  this.closeButton);
    }
    private void Update()
    {
        if(this == 0)
        {
                return;
        }
        
        R4.enabled = false;
        goto R4 + 252;
    }
    protected virtual void DisableMe()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    private void OnDisable()
    {
        if((System.String.op_Equality(a:  this.wordTypeText, b:  System.String.alignConst)) == false)
        {
                return;
        }
        
        WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        StopWaitingForRequest();
    }
    public virtual void ShowFTUXMessage()
    {
    
    }
    public DisplayWordDefinition()
    {
        this.lookup = "lookup";
        this.failureMessage = "Oops! We\'re having trouble finding this definition.";
    }

}
