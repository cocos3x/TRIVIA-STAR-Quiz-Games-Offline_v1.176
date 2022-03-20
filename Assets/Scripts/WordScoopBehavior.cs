using UnityEngine;
public class WordScoopBehavior : MonoBehaviour
{
    // Fields
    private TMPro.TextMeshPro myText;
    private UnityEngine.SpriteRenderer sr;
    private string word;
    private bool isCorrect;
    private float mySpeed;
    private float delta;
    private UnityEngine.Transform killPos;
    
    // Properties
    public string Word { get; }
    public UnityEngine.Sprite ScoopSprite { get; }
    public bool IsCorrect { get; }
    
    // Methods
    public string get_Word()
    {
    
    }
    public UnityEngine.Sprite get_ScoopSprite()
    {
        if(this.sr != 0)
        {
                return this.sr.sprite;
        }
        
        return this.sr.sprite;
    }
    public bool get_IsCorrect()
    {
        return (bool)this.isCorrect;
    }
    private void Start()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.killPos = public static WordDropManager MonoSingleton<WordDropManager>::get_Instance().__il2cppRuntimeField_14 + 20;
    }
    public void SetScoop(float newSpeed, string newWord, bool status, UnityEngine.Sprite newSprite)
    {
        UnityEngine.Sprite val_1;
        this.word = status;
        this.mySpeed = newWord;
        this.myText.text = status;
        this.isCorrect = newSprite;
        this.sr.sprite = val_1;
    }
    private void Update()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        float val_2 = UnityEngine.Time.deltaTime;
        uint val_11 = 0;
        val_11 = this.delta + val_11;
        this.delta = val_11;
        UnityEngine.Transform val_3 = this.transform;
        UnityEngine.Vector3 val_4 = position;
        UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  UnityEngine.Mathf.Lerp(a:  this.delta / this.mySpeed, b:  val_4.y, t:  val_4.z), y:  val_4.y);
        UnityEngine.Transform val_9 = this.transform;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = -4.274673E-24f, y = val_8.x});
        this.position = new UnityEngine.Vector3();
        if(this <= 0)
        {
                this = this;
            this.DestroyAndCheck();
        }
    
    }
    private void DestroyAndCheck()
    {
        if(this.isCorrect != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HandleFail();
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Debug.Log(message:  -1733892816);
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            EndFTUX();
        }
        
        UnityEngine.GameObject val_5 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  -1733868720);
    }
    public WordScoopBehavior()
    {
    
    }

}
