using UnityEngine;
public class BingoEventPopup : MonoBehaviour
{
    // Fields
    private const float AUTO_CLOSE_SEC = 3;
    private bool isNewCard;
    private UnityEngine.GameObject cardPopup;
    private UnityEngine.GameObject infoPopup;
    private UnityEngine.UI.Text prizeTitle;
    private TweenCoinsText prizeText;
    private UnityEngine.UI.Text prizePerBall;
    private UnityEngine.GameObject newCardText;
    private UnityEngine.GameObject bingoCard;
    private UnityEngine.GameObject prizePerBallGroup;
    private UnityEngine.GameObject bingoCompletedGroup;
    private UnityEngine.Transform ballsParent;
    private UnityEngine.UI.Button collectButton;
    private UnityEngine.UI.Button continueButton;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Button infoButton;
    private UnityEngine.GameObject ball;
    private UnityEngine.Sprite bingoBaubSprite;
    private UnityEngine.Sprite[] ballsSprites;
    private UnityEngine.Gradient[] trailColor;
    private UnityEngine.UI.Text timerText;
    private UnityEngine.GameObject timerGroup;
    private GridCoinCollectAnimationInstantiator coinsAnimation;
    private BingoCell[] bingoCells;
    private BingoEventHandler eventHandler;
    private System.Collections.Generic.List<int> collectedBalls;
    private System.Collections.Generic.List<int> combinationCompleted;
    private System.Collections.Generic.Dictionary<int, BingoCell> cellPos;
    private int prizePerBallReward;
    private int reward;
    private const float BALL_PUNCH_DURATION = 0.3;
    private const float BALL_MOVE_DURATION = 0.8;
    private const float BALL_MOVE_DELAY = 0.7;
    private const float BALL_SHOW_DELAY = 0.6;
    private const float COMBINATION_DURATION = 3;
    
    // Methods
    public void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1529178608, method:  new IntPtr(2765749328));
        this.collectButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1529178608, method:  new IntPtr(2765758544));
        this.continueButton.m_OnClick.AddListener(call:  162246656);
        T[] val_3 = this.bingoCard.GetComponentsInChildren<System.Object>();
        this.bingoCells = this.bingoCard;
    }
    public void Start()
    {
        if(true <= 0)
        {
                if(this.combinationCompleted == 0)
        {
            goto label_8;
        }
        
        }
        
        label_8:
        var val_4 = 25312223;
        val_4 = 10317328 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        this.eventHandler = BingoEventHandler.<Instance>k__BackingField;
        if((BingoEventHandler.<Instance>k__BackingField) == 0)
        {
            goto label_5;
        }
        
        this.PopulateCard();
        this.UpdateUI(state:  1);
        if(1 == 0)
        {
            goto label_6;
        }
        
        System.Collections.IEnumerator val_1 = this.CollectBallsAnimation();
        goto label_7;
        label_5:
        this.Close();
        return;
        label_6:
        System.Collections.IEnumerator val_2 = this.CombinationsAnimation();
        label_7:
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  -1529037936);
    }
    public void LoadCollectedBalls(System.Collections.Generic.List<int> balls, System.Collections.Generic.List<int> bingoCombination)
    {
        this.collectedBalls.AddRange(collection:  balls);
        this.combinationCompleted = bingoCombination;
    }
    public void Close()
    {
        this.CancelInvoke();
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1528781168, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void UpdateUI(BingoEventPopup.State state)
    {
        int val_6;
        int val_23;
        var val_24;
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.UI.LayoutElement val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -1528544800);
        System.Action val_3 = new System.Action(object:  -1528544800, method:  new IntPtr(2766278224));
        this.prizeTitle = null;
        this.reward = this.eventHandler.GetCurrentReward();
        this.prizePerBallReward = this.eventHandler.econ.prizePerBall;
        val_23 = this.reward;
        if(this.eventHandler.econ.prizePerBall >= 1)
        {
                this.reward = val_23;
        }
        
        decimal val_5 = System.Decimal.op_Implicit(value:  -1528556848);
        this.prizeText.Set(instantValue:  new System.Decimal() {mid = val_6});
        int val_23 = this.prizePerBallReward;
        val_23 = val_23 - 1;
        val_23 = val_23 >> 5;
        if(val_23 > 1)
        {
                "COIN" = "COINS";
        }
        
        string val_7 = Localization.Localize(key:  -1528659216, defaultValue:  -1528659376, useSingularKey:  val_23);
        string val_8 = System.String.Format(format:  1592589744, arg0:  13152256, arg1:  -1528659216);
        string val_9 = Localization.Localize(key:  -1528654928, defaultValue:  -1528655024, useSingularKey:  false);
        this.cardPopup.SetActive(value:  true);
        this.infoPopup.SetActive(value:  false);
        this.prizePerBallGroup.SetActive(value:  true);
        UnityEngine.GameObject val_10 = this.collectButton.gameObject;
        this.collectButton.SetActive(value:  false);
        UnityEngine.GameObject val_11 = this.continueButton.gameObject;
        this.continueButton.SetActive(value:  false);
        if(state == 2)
        {
            goto label_20;
        }
        
        if(state == 1)
        {
            goto label_21;
        }
        
        if(state != 0)
        {
            goto label_22;
        }
        
        UnityEngine.GameObject val_12 = this.ballsParent.gameObject;
        this.ballsParent.SetActive(value:  false);
        UnityEngine.GameObject val_13 = this.closeButton.gameObject;
        this.closeButton.SetActive(value:  true);
        UnityEngine.GameObject val_14 = this.infoButton.gameObject;
        this.infoButton.SetActive(value:  true);
        val_24 = 1;
        goto label_30;
        label_20:
        UnityEngine.GameObject val_15 = this.ballsParent.gameObject;
        this.ballsParent.SetActive(value:  false);
        UnityEngine.GameObject val_16 = this.closeButton.gameObject;
        this.closeButton.SetActive(value:  false);
        UnityEngine.GameObject val_17 = this.infoButton.gameObject;
        this.infoButton.SetActive(value:  false);
        UnityEngine.GameObject val_18 = this.continueButton.gameObject;
        this.continueButton.SetActive(value:  true);
        if(this.prizePerBallGroup != 0)
        {
            goto label_50;
        }
        
        label_51:
        label_50:
        this.prizePerBallGroup.SetActive(value:  false);
        val_24 = 0;
        label_30:
        this.timerGroup.SetActive(value:  false);
        label_22:
        if(this.isNewCard == true)
        {
                this.isNewCard = 1;
        }
        
        this.newCardText.SetActive(value:  true);
        this.bingoCompletedGroup.SetActive(value:  false);
        UnityEngine.GameObject val_19 = this.coinsAnimation.gameObject;
        this.coinsAnimation.SetActive(value:  false);
        return;
        label_21:
        UnityEngine.GameObject val_20 = this.ballsParent.gameObject;
        this.ballsParent.SetActive(value:  true);
        UnityEngine.GameObject val_21 = this.closeButton.gameObject;
        this.closeButton.SetActive(value:  false);
        UnityEngine.GameObject val_22 = this.infoButton.gameObject;
        if(this.infoButton != 0)
        {
            goto label_50;
        }
        
        goto label_51;
    }
    private void PopulateCard()
    {
        int val_4;
        System.Collections.Generic.Dictionary<System.Int32, BingoCell> val_12;
        System.Collections.Generic.HashSet<System.Int32> val_1 = new System.Collections.Generic.HashSet<System.Int32>();
        List.Enumerator<T> val_2 = GetEnumerator();
        label_6:
        if(MoveNext() == false)
        {
            goto label_4;
        }
        
        bool val_5 = Add(item:  val_4);
        goto label_6;
        label_4:
        Dispose();
        System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_6 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
        this.cellPos = null;
        var val_18 = 0;
        label_37:
        var val_17 = 0;
        label_36:
        val_12 = 0 + val_17;
        int val_12 = this.eventHandler.<progression>k__BackingField.currentCard[this.bingoCells[16]];
        if(val_12 == 0)
        {
            goto label_32;
        }
        
        string val_7 = this.eventHandler.<progression>k__BackingField.currentCard[val_12][16].ToString();
        var val_13 = this.eventHandler.<progression>k__BackingField.currentCard[val_12][16];
        val_12 = this.cellPos;
        val_12.Add(key:  this.eventHandler.<progression>k__BackingField.currentCard[BingoCell[].__il2cppRuntimeField_namespaze], value:  -1594174384);
        bool val_8 = Contains(item:  this.eventHandler.<progression>k__BackingField.currentCard[val_12]);
        if(val_8 == false)
        {
            goto label_25;
        }
        
        val_12 = this.collectedBalls;
        if((val_12.Contains(item:  this.eventHandler.<progression>k__BackingField.currentCard[val_8])) == false)
        {
            goto label_29;
        }
        
        label_25:
        UnityEngine.GameObject val_10 = typeof(BingoCell[]).__il2cppRuntimeField_14.gameObject;
        typeof(BingoCell[]).__il2cppRuntimeField_14.SetActive(value:  false);
        goto label_32;
        label_29:
        UnityEngine.GameObject val_11 = typeof(BingoCell[]).__il2cppRuntimeField_14.gameObject;
        typeof(BingoCell[]).__il2cppRuntimeField_14.SetActive(value:  true);
        typeof(BingoCell[]).__il2cppRuntimeField_14.sprite = this.bingoBaubSprite;
        label_32:
        val_17 = val_17 + 1;
        if(val_17 != 5)
        {
            goto label_36;
        }
        
        val_18 = val_18 + 1;
        if(val_18 != 5)
        {
            goto label_37;
        }
    
    }
    private System.Collections.IEnumerator CollectBallsAnimation()
    {
        object val_1 = new System.Object();
        typeof(BingoEventPopup.<CollectBallsAnimation>d__42).__il2cppRuntimeField_8 = 0;
        typeof(BingoEventPopup.<CollectBallsAnimation>d__42).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator CombinationsAnimation()
    {
        object val_1 = new System.Object();
        typeof(BingoEventPopup.<CombinationsAnimation>d__43).__il2cppRuntimeField_8 = 0;
        typeof(BingoEventPopup.<CombinationsAnimation>d__43).__il2cppRuntimeField_10 = this;
    }
    private void ShowBingoCompleted()
    {
        var val_11;
        System.Collections.Generic.Dictionary<System.Int32, BingoCell> val_12;
        val_11 = 4;
        goto label_1;
        label_14:
        val_12 = this.cellPos;
        if(true <= SB)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        bool val_1 = val_12.ContainsKey(key:  2621443);
        if(val_1 != false)
        {
                if(val_1 <= SB)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            BingoCell val_2 = this.cellPos.Item[2621443];
            UnityEngine.Transform val_3 = this.cellPos.transform;
            val_12 = this.cellPos;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -1.04397E-16f}, d:  val_4.x);
            DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions.DOScale(target:  val_12, endValue:  new UnityEngine.Vector3(), duration:  val_5.x);
            object val_7 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  val_12, loops:  0, loopType:  1);
        }
        
        val_11 = 5;
        label_1:
        if((val_11 - 4) < val_12)
        {
            goto label_14;
        }
        
        UnityEngine.GameObject val_9 = this.coinsAnimation.gameObject;
        this.coinsAnimation.SetActive(value:  true);
        this.prizePerBallGroup.SetActive(value:  false);
        UnityEngine.GameObject val_10 = this.collectButton.gameObject;
        this.collectButton.SetActive(value:  true);
        this.bingoCompletedGroup.SetActive(value:  true);
        string val_11 = Localization.Localize(key:  -1527739872, defaultValue:  1098586544, useSingularKey:  false);
        if(this.prizeTitle != 0)
        {
                return;
        }
    
    }
    private void UpdateTimerText()
    {
        ulong val_5;
        var val_8;
        if(this.timerGroup.activeSelf == false)
        {
                return;
        }
        
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        System.TimeSpan val_7 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511669223072}, d2:  new System.DateTime() {dateData = val_5});
        int val_10 = val_8.Days;
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        int val_11 = val_8.Hours;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        int val_12 = val_8.Minutes;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        int val_13 = val_8.Seconds;
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        string val_14 = System.String.Format(format:  -1536980304, args:  472754880);
        double val_15 = val_8.TotalSeconds;
        if(this.timerText >= 0)
        {
                return;
        }
        
        if(this.combinationCompleted == 0)
        {
                this.combinationCompleted = this;
            this.Close();
        }
    
    }
    private UnityEngine.GameObject GenerateBall(int number)
    {
        UnityEngine.Sprite[] val_9;
        object val_1 = UnityEngine.Object.Instantiate<System.Object>(original:  this.ball, parent:  this.ballsParent);
        this.ball.SetActive(value:  true);
        int val_2 = number - 1;
        val_2 = (val_2 >> 3) + (val_2 >> 31);
        int val_4 = UnityEngine.Mathf.FloorToInt(f:  (float)val_2);
        val_9 = this.ballsSprites;
        if(this.ballsSprites != null)
        {
            goto label_6;
        }
        
        val_9 = this.ballsSprites;
        if(val_9 == null)
        {
            goto label_7;
        }
        
        label_6:
        object val_5 = this.ball.GetComponent<System.Object>();
        this.ball.sprite = val_9[0];
        object val_6 = this.ball.GetComponentInChildren<System.Object>();
        string val_7 = number.ToString();
        object val_8 = this.ball.GetComponentInChildren<System.Object>();
        this.ball.colorGradient = this.trailColor[0];
        return;
        label_7:
    }
    private void OnCollectClick()
    {
        int val_7;
        this.collectButton.interactable = false;
        int val_1 = this.eventHandler.GetCurrentReward();
        this.eventHandler.CollectRewardAndNewCard();
        this.isNewCard = true;
        System.Action val_2 = new System.Action(object:  -1527028544, method:  new IntPtr(2767909632));
        this.coinsAnimation.OnCompleteCallback = null;
        Player val_3 = App.Player;
        decimal val_4 = System.Decimal.op_Implicit(value:  -1527040596);
        decimal val_5 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1527040612, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
        Player val_6 = App.Player;
        this.coinsAnimation.Play(fromValue:  new System.Decimal() {mid = val_7}, toValue:  new System.Decimal() {}, textTickTime:  null, delayBeforeComplete:  null);
    }
    private void OnCoinsAnimFinished()
    {
        if(this.eventHandler != 0)
        {
                this.Close();
            return;
        }
        
        this.PopulateCard();
        this.UpdateUI(state:  2);
    }
    public BingoEventPopup()
    {
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        this.collectedBalls = null;
    }

}
