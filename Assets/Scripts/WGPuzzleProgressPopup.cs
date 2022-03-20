using UnityEngine;
public class WGPuzzleProgressPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text puzzleTimeEnds;
    private UnityEngine.UI.Image puzzleImage;
    private UnityEngine.Transform puzzleBoard;
    private UnityEngine.UI.Text description;
    private UnityEngine.UI.Button earnPuzzlePiecesButton;
    private float revealingPuzzlePieceSpeed;
    private UnityEngine.GameObject rewardCoinObject;
    private UnityEngine.UI.Text reward;
    private UnityEngine.GameObject rewardBonusGameObject;
    private UnityEngine.UI.Text rewardBonusGameLabel;
    private UnityEngine.UI.Image rewardBonusGameIcon;
    private UnityEngine.Sprite bonusIconWheel;
    private UnityEngine.Sprite bonusIconSlots;
    private UnityEngine.UI.Text playButtonText;
    private UnityEngine.UI.Button continueButton;
    private const int TRUE = 1;
    private const int FALSE = 0;
    private UnityEngine.Sprite tempSprite;
    
    // Methods
    private void Awake()
    {
    
    }
    private void OnEnable()
    {
        this.UpdatePuzzleBoard();
        this.UpdateRewardInfo();
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  30232928, method:  new IntPtr(30187424));
        this.earnPuzzlePiecesButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.GameObject val_2 = this.earnPuzzlePiecesButton.gameObject;
        GameBehavior val_3 = App.getBehavior;
        this.earnPuzzlePiecesButton.SetActive(value:  true);
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  30232928, method:  new IntPtr(30187424));
        this.continueButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.GameObject val_5 = this.continueButton.gameObject;
        GameBehavior val_6 = App.getBehavior;
        if(this.continueButton != 0)
        {
                -1 = 1;
        }
        
        this.continueButton.SetActive(value:  true);
        string val_7 = Localization.Localize(key:  -1672741904, defaultValue:  2127161280, useSingularKey:  false);
        Player val_8 = App.Player;
        string val_9 = System.String.Format(format:  -1672741904, arg0:  13152256);
        if(this.playButtonText != 0)
        {
                return;
        }
    
    }
    private void OnDisable()
    {
        string val_1 = PuzzleCollectionHandler.CurrentPuzzleName;
        if((System.String.op_Inequality(a:  null, b:  28228128)) == false)
        {
                return;
        }
        
        UnityEngine.Object.DestroyImmediate(obj:  R4 + 72);
    }
    private void Update()
    {
        this.UpdatePuzzleEndTime();
    }
    private void UpdateRewardInfo()
    {
        object val_16;
        var val_16 = 0;
        GameEventRewardType val_1 = PuzzleCollectionHandler.RewardType;
        if(val_16 != 1)
        {
            goto label_1;
        }
        
        this.rewardCoinObject.SetActive(value:  true);
        this.rewardBonusGameObject.SetActive(value:  false);
        string val_3 = PuzzleCollectionHandler.RewardValue.ToString();
        string val_4 = Localization.Localize(key:  30590176, defaultValue:  30589984, useSingularKey:  false);
        string val_5 = PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED.GetEventExpireDayOfWeek();
        val_16 = PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED;
        string val_6 = PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED.GetEventExpireTime();
        label_22:
        string val_7 = System.String.Format(format:  30590176, arg0:  val_16, arg1:  PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED);
        label_26:
        if(this.description != 0)
        {
                return;
        }
        
        return;
        label_1:
        val_16 = val_16;
        val_16 = val_16 - 3;
        if(val_16 > 1)
        {
                return;
        }
        
        this.rewardCoinObject.SetActive(value:  false);
        this.rewardBonusGameObject.SetActive(value:  true);
        if(val_16 != 3)
        {
            goto label_14;
        }
        
        string val_8 = Localization.Localize(key:  -1505638896, defaultValue:  -1505638992, useSingularKey:  false);
        this.rewardBonusGameIcon.sprite = this.bonusIconWheel;
        string val_9 = Localization.Localize(key:  30619232, defaultValue:  30618960, useSingularKey:  false);
        GameEcon val_10 = App.getGameEcon;
        int val_11 = 0.maxBonusGameWheelAwardCoins;
        GameEcon val_12 = App.getGameEcon;
        int val_13 = 0.maxBonusGameWheelAwardGoldenCurrency;
        goto label_22;
        label_14:
        string val_14 = Localization.Localize(key:  -1505604896, defaultValue:  -1505604992, useSingularKey:  false);
        this.rewardBonusGameIcon.sprite = this.bonusIconSlots;
        string val_15 = Localization.Localize(key:  30636016, defaultValue:  30635744, useSingularKey:  false);
        goto label_26;
    }
    private void UpdatePuzzleEndTime()
    {
        var val_11 = 27034471;
        val_11 = 8595076 + val_11;
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        System.TimeSpan val_1 = GetRemainingTime();
        string val_3 = ???.Days.ToString(format:  -1827641632);
        typeof(System.String[]).__il2cppRuntimeField_10 = ;
        typeof(System.String[]).__il2cppRuntimeField_14 = ":";
        string val_5 = ???.Hours.ToString(format:  -1827641632);
        typeof(System.String[]).__il2cppRuntimeField_18 = ;
        typeof(System.String[]).__il2cppRuntimeField_1C = ":";
        string val_7 = ???.Minutes.ToString(format:  -1827641632);
        typeof(System.String[]).__il2cppRuntimeField_20 = ;
        typeof(System.String[]).__il2cppRuntimeField_24 = ":";
        string val_9 = ???.Seconds.ToString(format:  -1827641632);
        typeof(System.String[]).__il2cppRuntimeField_28 = ;
        string val_10 = +477709520;
        if(this.puzzleTimeEnds != 0)
        {
                return;
        }
    
    }
    private void UpdatePuzzleBoard()
    {
        var val_23;
        UnityEngine.Sprite val_24;
        UnityEngine.UI.Image val_25;
        UnityEngine.GameObject val_26;
        var val_27;
        val_23 = 0;
        if(this.puzzleImage != 0)
        {
                string val_2 = PuzzleCollectionHandler.CurrentPuzzleName;
            if((System.String.op_Equality(a:  null, b:  28228128)) != false)
        {
                val_24 = "game/WordAddict/Events/PuzzleCollection/academy";
            object val_4 = UnityEngine.Resources.Load<System.Object>(path:  28228224);
        }
        else
        {
                string val_5 = UnityEngine.Application.temporaryCachePath;
            string val_6 = PuzzleCollectionHandler.CurrentPuzzleName;
            val_24 = 0;
            string val_7 = null + 1115175264 + null + 1975550080;
            UnityEngine.Sprite val_8 = ImageLoadingController.GetSprite(path:  null);
        }
        
            this.tempSprite = val_24;
            val_25 = this.puzzleImage;
            val_25.sprite = 0;
        }
        
        System.Int32[] val_9 = PuzzleCollectionHandler.CurrentPuzzleProgress;
        val_26 = 0;
        val_27 = 0 + 16;
        goto label_7;
        label_13:
        UnityEngine.Transform val_10 = this.puzzleBoard.GetChild(index:  0);
        UnityEngine.GameObject val_11 = this.puzzleBoard.gameObject;
        val_25 = this.puzzleBoard;
        val_25.SetActive(value:  false);
        val_23 = 1;
        label_7:
        if(val_23 < 0)
        {
            goto label_13;
        }
        
        System.Int32[] val_12 = PuzzleCollectionHandler.NewPuzzlePieces;
        System.Collections.Generic.List<System.Int32> val_13 = new System.Collections.Generic.List<System.Int32>(collection:  0);
        var val_14 = 4 - 4;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        UnityEngine.Transform val_15 = this.puzzleBoard.GetChild(index:  List<T>.__il2cppRuntimeField_10);
        UnityEngine.GameObject val_16 = this.puzzleBoard.gameObject;
        val_26 = this.puzzleBoard;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        UnityEngine.Transform val_17 = this.puzzleBoard.GetChild(index:  List<T>.__il2cppRuntimeField_10);
        val_25 = this.puzzleBoard;
        UnityEngine.GameObject val_18 = val_25.gameObject;
        val_25.SetActive(value:  true);
        System.Collections.IEnumerator val_19 = this.FadeOutPuzzlePiece(pc:  val_26);
        UnityEngine.Coroutine val_20 = this.StartCoroutine(routine:  30974256);
        var val_22 = 4 - 3;
        val_27 = 4 + 1;
        System.Int32[] val_23 = PuzzleCollectionHandler.NewPuzzlePieces;
        if((new System.Collections.Generic.List<System.Int32>(collection:  0)) != 0)
        {
                Clear();
        }
        else
        {
                Clear();
        }
        
        T[] val_25 = ToArray();
        PuzzleCollectionHandler.NewPuzzlePieces = 80883712;
    }
    private System.Collections.IEnumerator FadeOutPuzzlePiece(UnityEngine.GameObject pc)
    {
        typeof(WGPuzzleProgressPopup.<FadeOutPuzzlePiece>d__25).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(WGPuzzleProgressPopup.<FadeOutPuzzlePiece>d__25).__il2cppRuntimeField_14 = this;
        }
        else
        {
                mem[20] = this;
        }
        
        typeof(WGPuzzleProgressPopup.<FadeOutPuzzlePiece>d__25).__il2cppRuntimeField_10 = pc;
    }
    private void OnClick_EarnPuzzlePieces()
    {
        Player val_1 = App.Player;
        if(0 == 3)
        {
            goto label_9;
        }
        
        GameBehavior val_2 = App.getBehavior;
        if(0 != 1)
        {
            goto label_9;
        }
        
        if(PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED.PlayingChallenge == false)
        {
            goto label_12;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ShowToolTip();
        label_9:
        this.Close();
        return;
        label_12:
        GameBehavior val_5 = App.getBehavior;
        UnityEngine.GameObject val_6 = this.gameObject;
        SLCWindow.CloseWindow(window:  31226928, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  31338928, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        GameBehavior val_2 = App.getBehavior;
        if(0 != 1)
        {
                return;
        }
        
        if(PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED == 0)
        {
            
        }
    
    }
    public WGPuzzleProgressPopup()
    {
        this.revealingPuzzlePieceSpeed = 0.5f;
    }

}
