using UnityEngine;
public class PlayerCoinAddedBalance : MonoBehaviour
{
    // Fields
    private UnityEngine.CanvasGroup canvasGroup;
    private bool isShowing;
    private int showingValue;
    private float remainingTime;
    private float showDuration;
    private UnityEngine.RectTransform slideOut;
    private UnityEngine.Vector2 slideOutPosition;
    private UnityEngine.Vector2 slideInPosition;
    private UnityEngine.UI.Text text;
    private UnityEngine.GameObject[] opposingPartners;
    private bool bumped;
    private DG.Tweening.Tweener punchScale;
    
    // Methods
    private void Start()
    {
        UnityEngine.Vector2 val_4;
        var val_5;
        var val_10;
        UnityEngine.Vector2 val_11;
        if((UnityEngine.Object.op_Implicit(exists:  this.canvasGroup)) != false)
        {
                this.canvasGroup.alpha = null;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.slideOut)) != false)
        {
                UnityEngine.Vector2 val_3 = anchoredPosition;
            this.slideOutPosition = val_4;
            mem[1152921513305778280] = val_5;
            UnityEngine.Vector2 val_6 = anchoredPosition;
            UnityEngine.Vector3 val_8 = new UnityEngine.Vector3(x:  val_6.x, y:  val_6.y);
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 4.795512E-35f, y = val_8.x, z = val_8.y});
            mem[1152921513305778288] = val_10;
            this.slideInPosition = val_11;
            this.slideOut.anchoredPosition = new UnityEngine.Vector2() {x = this.slideInPosition, y = 0f};
        }
        
        UnityEngine.Transform val_12 = this.text.transform;
        UnityEngine.Vector3 val_13 = new UnityEngine.Vector3(x:  val_9.x, y:  val_9.y, z:  null);
        DG.Tweening.Tweener val_14 = DG.Tweening.ShortcutExtensions.DOPunchScale(target:  this.text, punch:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, duration:  val_9.x, vibrato:  1041865114, elasticity:  val_9.y);
        this.punchScale = this.text;
    }
    private void OnEnable()
    {
        this.showingValue = 0;
    }
    private void Update()
    {
        if((UnityEngine.Input.GetKeyUp(key:  98)) != false)
        {
                if(UnityEngine.Application.isEditor != false)
        {
                this.Add(addAmount:  1);
        }
        
        }
        
        if(this.isShowing == false)
        {
                return;
        }
        
        float val_3 = UnityEngine.Time.deltaTime;
        uint val_9 = 0;
        val_9 = this.remainingTime - val_9;
        this.remainingTime = val_9;
        if(this.isShowing <= false)
        {
                0 = this;
            this.Hide();
        }
        
        if(this.bumped == true)
        {
                return;
        }
        
        float val_10 = 0.8f;
        val_10 = this.showDuration * val_10;
        if(this.bumped >= 0)
        {
                return;
        }
        
        DG.Tweening.TweenExtensions.Kill(t:  this.punchScale, complete:  false);
        UnityEngine.Transform val_4 = this.text.transform;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
        this.text.localScale = new UnityEngine.Vector3();
        UnityEngine.Transform val_6 = this.text.transform;
        UnityEngine.Vector3 val_7 = new UnityEngine.Vector3(x:  val_5.x, y:  val_5.y, z:  val_5.z);
        DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions.DOPunchScale(target:  this.text, punch:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  val_5.x, vibrato:  1041865114, elasticity:  val_5.y);
        this.punchScale = this.text;
        this.bumped = true;
    }
    public void Add(int addAmount)
    {
        int val_8 = this.showingValue;
        val_8 = val_8 + addAmount;
        this.showingValue = val_8;
        string val_1 = this.showingValue.ToString(format:  109366016);
        string val_2 = -1467947360(-1467947360) + 109402404;
        DG.Tweening.TweenExtensions.Kill(t:  this.punchScale, complete:  false);
        UnityEngine.Transform val_3 = this.text.transform;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        this.text.localScale = new UnityEngine.Vector3();
        UnityEngine.Transform val_5 = this.text.transform;
        UnityEngine.Vector3 val_6 = new UnityEngine.Vector3(x:  val_4.x, y:  val_4.y, z:  val_4.z);
        DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions.DOPunchScale(target:  this.text, punch:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  val_4.x, vibrato:  1034147594, elasticity:  val_4.y);
        this.punchScale = this.text;
        if(this.isShowing == false)
        {
                this.text = this;
            this.Show();
        }
        
        this.remainingTime = this.showDuration;
    }
    public void Add(int addAmount, float delay)
    {
        System.Collections.IEnumerator val_1 = this.AddDelayed(addAmount:  addAmount, delay:  delay);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  109530768);
    }
    private System.Collections.IEnumerator AddDelayed(int addAmount, float delay)
    {
        typeof(PlayerCoinAddedBalance.<AddDelayed>d__17).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(PlayerCoinAddedBalance.<AddDelayed>d__17).__il2cppRuntimeField_14 = this;
            typeof(PlayerCoinAddedBalance.<AddDelayed>d__17).__il2cppRuntimeField_18 = addAmount;
        }
        else
        {
                mem[20] = this;
            mem[24] = addAmount;
        }
        
        typeof(PlayerCoinAddedBalance.<AddDelayed>d__17).__il2cppRuntimeField_10 = R2;
    }
    private void Show()
    {
        this.CancelInvoke(methodName:  109730768);
        this.isShowing = true;
        if((UnityEngine.Object.op_Implicit(exists:  this.slideOut)) != false)
        {
                DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  mem[this.slideOut + (0)], endValue:  new UnityEngine.Vector2() {x = mem[this.slideOut + (4)], y = mem[this.slideOut + (8)]}, duration:  null, snapping:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.canvasGroup)) != false)
        {
                DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.canvasGroup, endValue:  null, duration:  null);
        }
        
        this.ShowOpposingPartners(showThem:  false);
    }
    private void Hide()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.canvasGroup)) != false)
        {
                DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.canvasGroup, endValue:  null, duration:  null);
        }
        
        this.Invoke(methodName:  109730768, time:  null);
        if((UnityEngine.Object.op_Implicit(exists:  this.slideOut)) != false)
        {
                DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  this.slideOut, endValue:  new UnityEngine.Vector2() {x = this.slideInPosition, y = 0.5f}, duration:  null, snapping:  false);
        }
        
        this.isShowing = false;
        this.showingValue = false;
    }
    private void Invoke_ShowPartners()
    {
        this.ShowOpposingPartners(showThem:  true);
    }
    private void ShowOpposingPartners(bool showThem)
    {
        var val_1 = 0;
        goto label_0;
        label_5:
        UnityEngine.GameObject val_1 = this.opposingPartners[val_1];
        val_1.SetActive(value:  showThem);
        val_1 = 1;
        label_0:
        if(val_1 < val_1)
        {
            goto label_5;
        }
    
    }
    public PlayerCoinAddedBalance()
    {
        UnityEngine.Vector2 val_3;
        var val_4;
        UnityEngine.Vector2 val_7;
        var val_8;
        this.showDuration = 3f;
        UnityEngine.Vector3 val_1 = new UnityEngine.Vector3(x:  null, y:  null);
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 5.590793E-35f, y = val_1.x, z = val_1.y});
        this.slideOutPosition = val_3;
        mem[1152921513307197480] = val_4;
        UnityEngine.Vector3 val_5 = new UnityEngine.Vector3(x:  val_2.x, y:  val_2.y);
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 5.59078E-35f, y = val_5.x, z = val_5.y});
        this.slideInPosition = val_7;
        mem[1152921513307197488] = val_8;
    }

}
