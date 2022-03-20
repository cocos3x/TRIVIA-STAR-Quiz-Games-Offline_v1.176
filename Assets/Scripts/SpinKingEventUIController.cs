using UnityEngine;
public class SpinKingEventUIController : MonoSingleton<SpinKingEventUIController>
{
    // Fields
    private UnityEngine.Transform eventButton;
    private UnityEngine.Transform eventButtonMiddleRoot;
    private UnityEngine.GameObject spinPiecePrefab;
    private SpinKingEventButtonTag eventBtnTagPrefab;
    private float spinPieceMoveDuration;
    private const string SPIN_WORD_INDEX_KEY = "spin_word_index";
    private const string SPIN_LETTER_INDEX_KEY = "spin_letter_index";
    private const string SPIN_PIECE_OBTAINED_KEY = "spin_piece_obtained";
    private const string SAVED_LANGUAGE_KEY = "spin_saved_lang";
    private const string SPIN_PIECE_AVAILABLE_KEY = "spin_piece_lost";
    private const int DEFAULT_SPIN_WORD_INDEX = -1;
    private const int DEFAULT_SPIN_LETTER_INDEX = -1;
    private const bool DEFAULT_OBTAINED_SPIN_PIECE = False;
    private const bool DEFAULT_IS_SPIN_PIECE_AVAILABLE = True;
    public UnityEngine.GameObject spinPiece;
    private LineWord word;
    private Cell letter;
    private SpinKingEventButtonTag eventBtnTag;
    private bool hasLevelFinishedLoading;
    
    // Properties
    private int spinWordIndex { get; set; }
    private int spinLetterIndex { get; set; }
    private bool obtainedSpinPiece { get; set; }
    private string SavedLanguage { get; set; }
    private bool IsSpinPieceAvailable { get; set; }
    public int GetSpinWordIndex { get; }
    
    // Methods
    private int get_spinWordIndex()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -193892816, defaultValue:  0);
    }
    private void set_spinWordIndex(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -193892816, value:  value);
        Player val_1 = App.Player;
        0.SaveState();
    }
    private int get_spinLetterIndex()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -193668704, defaultValue:  0);
    }
    private void set_spinLetterIndex(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -193668704, value:  value);
        Player val_1 = App.Player;
        0.SaveState();
    }
    private bool get_obtainedSpinPiece()
    {
        return PlayerPrefsX.GetBool(name:  -193444592, defaultValue:  false);
    }
    private void set_obtainedSpinPiece(bool value)
    {
        bool val_1 = PlayerPrefsX.SetBool(name:  -193444592, value:  value);
        Player val_2 = App.Player;
        0.SaveState();
    }
    private string get_SavedLanguage()
    {
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.GetCurrentLanguage();
        return UnityEngine.PlayerPrefs.GetString(key:  -193220480, defaultValue:  null);
    }
    private void set_SavedLanguage(string value)
    {
        UnityEngine.PlayerPrefs.SetString(key:  -193220480, value:  value);
    }
    private bool get_IsSpinPieceAvailable()
    {
        return PlayerPrefsX.GetBool(name:  -192988176, defaultValue:  true);
    }
    private void set_IsSpinPieceAvailable(bool value)
    {
        bool val_1 = PlayerPrefsX.SetBool(name:  -192988176, value:  value);
        Player val_2 = App.Player;
        0.SaveState();
    }
    public int get_GetSpinWordIndex()
    {
        return this.spinWordIndex;
    }
    public override void InitMonoSingleton()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -192628064, name:  -1649709760);
    }
    private void Start()
    {
        WordRegion val_1 = WordRegion.instance;
        if(0 == 0)
        {
                return;
        }
        
        WordRegion val_3 = WordRegion.instance;
        System.Action<System.Boolean, System.String, LineWord, Cell> val_4 = new System.Action<System.Boolean, System.String, LineWord, Cell>(object:  -192515040, method:  new IntPtr(4102427232));
        0.addOnPreprocessPlayerTurnAction(callback:  7614464);
    }
    public void LevelFinishedLoading()
    {
        this.hasLevelFinishedLoading = true;
        this.UpdateSpinCollectionUI();
    }
    public void UpdateSpinCollectionUI()
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        bool val_15;
        var val_16;
        val_10 = this;
        if(this.hasLevelFinishedLoading == false)
        {
            goto label_23;
        }
        
        val_11 = 35627674;
        val_12 = 1152921504986451968;
        if(SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY == null)
        {
            goto label_23;
        }
        
        if(SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY.IsEventExpired() == false)
        {
            goto label_4;
        }
        
        this.DestroySpinPiece();
        if(SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY != null)
        {
            goto typeof(System.String).__il2cppRuntimeField_17C;
        }
        
        goto typeof(System.String).__il2cppRuntimeField_17C;
        label_4:
        object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  R4 + 24, parent:  R4 + 16);
        object val_3 = R4 + 24.GetComponent<System.Object>();
        mem2[0] = R4 + 24;
        if(SB == 0)
        {
                mem2[0] = 1;
        }
        
        if((R8 + 92 + 32) >= (R8 + 92 + 28 + 12))
        {
                0 = 1;
        }
        
        R4 + 24 + 20.SetActive(value:  true);
        val_13 = mem[R4 + 44];
        val_13 = R4 + 44;
        if(SB == 0)
        {
                mem2[0] = 1;
        }
        
        val_14 = mem[R8 + 92 + 32];
        val_14 = R8 + 92 + 32;
        val_15 = 0;
        if(val_14 >= (R8 + 92 + 28 + 12))
        {
                val_15 = (R8 + 92 + 28 + 12.obtainedSpinPiece) ^ 1;
        }
        
        val_16 = mem[R4 + 44 + 16];
        val_16 = R4 + 44 + 16;
        val_16.SetActive(value:  val_15);
        if(SB == 0)
        {
                mem2[0] = 1;
        }
        
        if((R8 + 92.PlayingChallenge) != false)
        {
                var val_6 = FP - 28;
        }
        
        label_23:
        var val_7 = (mem[(FP - 28) + (28)]) - 28;
    }
    private void OnWordRegionPreprocessPlayerTurn(bool hintUsage, string wordEntered, LineWord lineWord, Cell cell)
    {
        var val_9;
        var val_9 = 19683054;
        val_9 = 15944620 + val_9;
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = 1152921504986451968;
        if(SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY == null)
        {
                return;
        }
        
        if(SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY.IsEventExpired() == true)
        {
                return;
        }
        
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        bool val_2 = SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY.PlayingChallenge;
        if(val_2 == false)
        {
                return;
        }
        
        if(val_2.IsSpinPlacementDataValid() == false)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  wordEntered)) == true)
        {
                return;
        }
        
        val_9 = 1152921504886931456;
        WordRegion val_5 = WordRegion.instance;
        int val_6 = this.spinWordIndex;
        if(0 <= val_6)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_10 = 0;
        val_10 = val_10 + (val_6 << 2);
        if(((0 + (val_6) << 2) + 16 + 12.Equals(value:  wordEntered)) == false)
        {
                return;
        }
        
        WordRegion val_8 = WordRegion.instance;
        mem[20] = 1;
    }
    public void DestroySpinPiece()
    {
        if(this.spinPiece == 0)
        {
                return;
        }
        
        1152921504765685760 = 0;
        UnityEngine.Object.Destroy(obj:  this.spinPiece);
        this.spinPiece = 1152921504765685760;
    }
    private void CollectSpinPiece()
    {
        bool val_1 = UnityEngine.Object.op_Equality(x:  this.spinPiece, y:  0);
        if(val_1 == true)
        {
                return;
        }
        
        if(val_1.obtainedSpinPiece == true)
        {
                return;
        }
        
        this.ShowSpinPiece();
        WordRegion val_3 = WordRegion.instance;
        mem[20] = true;
        this.obtainedSpinPiece = true;
        SpinKingEventHandler.EarnedSpinPiece = true;
        SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY.HandleSpinPieceCollected();
        UnityEngine.Transform val_4 = this.spinPiece.transform;
        this.spinPiece.parent = this.eventButton;
        UnityEngine.Transform val_5 = this.spinPiece.transform;
        UnityEngine.Vector3 val_6 = position;
        DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.spinPiece, endValue:  new UnityEngine.Vector3(), duration:  this.spinPieceMoveDuration, snapping:  this.spinPieceMoveDuration);
        DG.Tweening.TweenCallback val_8 = new DG.Tweening.TweenCallback(object:  -191882336, method:  new IntPtr(4103051744));
        object val_9 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.spinPiece, action:  190734336);
        UnityEngine.Transform val_10 = this.spinPiece.transform;
        UnityEngine.Vector3 val_12 = new UnityEngine.Vector3(x:  (float)UnityEngine.Random.Range(min:  -720, max:  720), y:  val_6.y, z:  val_6.z);
        DG.Tweening.Tweener val_13 = DG.Tweening.ShortcutExtensions.DORotate(target:  this.spinPiece, endValue:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, duration:  this.spinPieceMoveDuration, mode:  this.spinPieceMoveDuration);
        object val_14 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.spinPiece, ease:  5);
        UnityEngine.Transform val_15 = this.spinPiece.transform;
        UnityEngine.Vector3 val_16 = new UnityEngine.Vector3(x:  this.spinPieceMoveDuration, y:  val_6.y, z:  val_6.z);
        DG.Tweening.Tweener val_17 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.spinPiece, endValue:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, duration:  this.spinPieceMoveDuration);
    }
    public void ShiftSpinPiece()
    {
        var val_11;
        WordRegion val_1 = WordRegion.instance;
        if(1 != 0)
        {
                return;
        }
        
        bool val_2 = UnityEngine.Object.op_Equality(x:  R4 + 32, y:  0);
        if(val_2 == true)
        {
                return;
        }
        
        if(val_2.obtainedSpinPiece != false)
        {
                return;
        }
        
        R4.ShowSpinPiece();
        if((R4 + 36 + 32) != 0)
        {
                R4.CollectSpinPiece();
            return;
        }
        
        int val_4 = R4 + 36 + 32.spinLetterIndex;
        val_4.spinLetterIndex = val_4 + 1;
        val_11 = mem[R4 + 36 + 20];
        val_11 = R4 + 36 + 20;
        if(val_4.spinLetterIndex >= (R4 + 36 + 20 + 12))
        {
            goto label_12;
        }
        
        label_20:
        int val_7 = R4 + 36 + 20 + 12.spinLetterIndex;
        if((R4 + 36 + 20 + 12) <= val_7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_11 = R4 + 36 + 20 + 8;
        val_11 = val_11 + (val_7 << 2);
        if(((R4 + 36 + 20 + 8 + (val_7) << 2) + 16 + 36) == 0)
        {
            goto label_17;
        }
        
        int val_8 = (R4 + 36 + 20 + 8 + (val_7) << 2) + 16 + 36.spinLetterIndex;
        val_8.spinLetterIndex = val_8 + 1;
        val_11 = mem[R4 + 36 + 20];
        val_11 = R4 + 36 + 20;
        if(val_8.spinLetterIndex < (R4 + 36 + 20 + 12))
        {
            goto label_20;
        }
        
        R4.DestroySpinPiece();
        goto label_21;
        label_12:
        R4.DestroySpinPiece();
        R4.FixStarredCoinUI();
        label_21:
        R4.IsSpinPieceAvailable = false;
        SpinKingEventHandler.EarnedSpinPiece = false;
        return;
        label_17:
        mem2[0] = (R4 + 36 + 20 + 8 + (val_7) << 2) + 16;
        R4.AdjustSpinPieceUI();
        R4.FixStarredCoinUI();
    }
    private bool IsSpinPlacementDataValid()
    {
        int val_1 = this.spinWordIndex;
        if(val_1 < 0)
        {
                return false;
        }
        
        WordRegion val_3 = WordRegion.instance;
        if(val_1.spinWordIndex >= 0)
        {
                return false;
        }
        
        int val_4 = this.spinLetterIndex;
        val_4 = val_4 >> 5;
        return (bool)val_4;
    }
    public void InitializeSpinPiece()
    {
        SpinKingEventUIController val_29;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        val_29 = this;
        var val_30 = 19684974;
        val_30 = 15942700 + val_30;
        if(val_30 == 0)
        {
                mem2[0] = 1;
        }
        
        if(SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY.PlayingChallenge == false)
        {
                return;
        }
        
        if(val_30 == 0)
        {
                mem2[0] = 1;
        }
        
        bool val_2 = SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY.IsSolvingInProgress();
        if(val_2 == false)
        {
            goto label_6;
        }
        
        string val_3 = val_2.SavedLanguage;
        GameBehavior val_4 = App.getBehavior;
        val_31 = 0;
        string val_5 = val_31.GetCurrentLanguage();
        bool val_6 = System.String.op_Inequality(a:  val_2, b:  null);
        if(val_6 == false)
        {
            goto label_11;
        }
        
        label_6:
        string val_7 = val_6.SavedLanguage;
        GameBehavior val_8 = App.getBehavior;
        val_31 = 0;
        string val_9 = val_31.GetCurrentLanguage();
        if((System.String.op_Inequality(a:  val_6, b:  null)) != false)
        {
                GameBehavior val_11 = App.getBehavior;
            string val_12 = 0.GetCurrentLanguage();
            this.SavedLanguage = null;
            bool val_13 = this.obtainedSpinPiece;
            if(val_13 == true)
        {
                return;
        }
        
        }
        
        val_13.ResetSpinLevelUI();
        RandomSet val_14 = new RandomSet();
        WordRegion val_15 = WordRegion.instance;
        System.Collections.Generic.List<System.Int32> val_16 = 0.getAvailableLineIndices;
        val_31 = 0;
        val_32 = 4;
        goto label_25;
        label_48:
        WordRegion val_17 = WordRegion.instance;
        val_33 = 0;
        if(0 <= SB)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(0 <= (3.673424E-39f))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_31 = 0;
        val_31 = val_31 + 10485772;
        if(((0 + 10485772) + 16 + 32) == 0)
        {
                WordRegion val_18 = WordRegion.instance;
            val_33 = 0;
            if(0 <= SB)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(0 <= 2621443)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_32 = 0;
            val_32 = val_32 + 10485772;
            if(((0 + 10485772) + 16 + 20 + 12) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(((0 + 10485772) + 16 + 20 + 8 + 16 + 36) == 0)
        {
                if(0 <= SB)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_33 = 2621443;
            add(item:  2621443, weight:  null);
        }
        
        }
        
        val_32 = 5;
        label_25:
        if((val_32 - 4) < 0)
        {
            goto label_48;
        }
        
        val_29 = val_29;
        if(count() == 0)
        {
                return;
        }
        
        val_34 = 0;
        int val_21 = roll(unweighted:  false);
        val_21.spinWordIndex = val_21;
        goto label_52;
        label_70:
        WordRegion val_22 = WordRegion.instance;
        val_35 = 0;
        int val_23 = this.spinWordIndex;
        if(0 <= val_23)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_33 = 0;
        val_33 = val_33 + (val_23 << 2);
        if(((0 + (val_23) << 2) + 16 + 20 + 12) <= val_34)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_34 = (0 + (val_23) << 2) + 16 + 20 + 8;
        val_34 = val_34 + 0;
        if((((0 + (val_23) << 2) + 16 + 20 + 8 + 0) + 16 + 36) == 0)
        {
            goto label_62;
        }
        
        val_34 = 1;
        label_52:
        WordRegion val_24 = WordRegion.instance;
        val_35 = 0;
        int val_25 = this.spinWordIndex;
        if(0 <= val_25)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_35 = 0;
        val_35 = val_35 + (val_25 << 2);
        if(val_34 < ((0 + (val_25) << 2) + 16 + 20 + 12))
        {
            goto label_70;
        }
        
        goto label_71;
        label_11:
        bool val_26 = val_6.obtainedSpinPiece;
        if(val_26 == true)
        {
                return;
        }
        
        if(val_26.IsSpinPieceAvailable != true)
        {
                bool val_28 = UnityEngine.Object.op_Inequality(x:  this.spinPiece, y:  0);
            if(val_28 == true)
        {
                return;
        }
        
        }
        
        if(val_28.IsSpinPlacementDataValid() == false)
        {
                return;
        }
        
        this.ShowSpinPiece();
        this.FixStarredCoinUI();
        return;
        label_62:
        ((0 + (val_23) << 2) + 16 + 20 + 8 + 0) + 16 + 36.spinLetterIndex = 0;
        label_71:
        this.ShowSpinPiece();
        this.FixStarredCoinUI();
        SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY.SaveEventProgress();
    }
    public void ShowSpinPiece()
    {
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        System.Collections.Generic.List<Cell> val_19;
        UnityEngine.Transform val_20;
        WordRegion val_1 = WordRegion.instance;
        bool val_2 = UnityEngine.Object.op_Equality(x:  0, y:  0);
        if(val_2 == false)
        {
            goto label_5;
        }
        
        val_15 = "SpinKingUIController attempting to ShowSpinPiece but no WordRegion exists!";
        goto label_8;
        label_5:
        if(val_2.IsSpinPlacementDataValid() == false)
        {
            goto label_9;
        }
        
        WordRegion val_4 = WordRegion.instance;
        val_16 = 0;
        int val_5 = this.spinWordIndex;
        if(0 <= val_5)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_15 = 0;
        val_15 = val_15 + (val_5 << 2);
        this.word = (0 + (val_5) << 2) + 16;
        bool val_6 = UnityEngine.Object.op_Equality(x:  (0 + (val_5) << 2) + 16, y:  0);
        if(val_6 == false)
        {
            goto label_17;
        }
        
        int val_7 = val_6.spinWordIndex;
        val_17 = null;
        val_18 = "SpinKingUIController attempting to ShowSpinPiece but no word exists for SpinWordIndex ";
        goto label_18;
        label_9:
        val_15 = "SpinKingUIController attempting to ShowSpinPiece but associated word/letter index is outdated!";
        label_8:
        UnityEngine.Debug.LogError(message:  -191421008);
        return;
        label_17:
        val_19 = this.word.cells;
        int val_8 = val_6.spinLetterIndex;
        if(val_8 <= val_8)
        {
                var val_16 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_16 = val_16 + (val_8 << 2);
        this.letter = (0 + (val_8) << 2) + 16;
        bool val_9 = UnityEngine.Object.op_Equality(x:  (0 + (val_8) << 2) + 16, y:  0);
        if(val_9 == false)
        {
            goto label_26;
        }
        
        int val_10 = val_9.spinLetterIndex;
        val_17 = null;
        val_18 = "SpinKingUIController attempting to ShowSpinPiece but no letter exists for SpinLetterIndex ";
        label_18:
        string val_11 = -191412560(-191412560) + 13152256;
        UnityEngine.Debug.LogError(message:  -191412560);
        return;
        label_26:
        if(this.spinPiece == 0)
        {
                UnityEngine.Transform val_13 = this.letter.transform;
            val_20 = this.letter;
            object val_14 = UnityEngine.Object.Instantiate<System.Object>(original:  this.spinPiecePrefab, parent:  val_20);
            this.spinPiece = this.spinPiecePrefab;
        }
        
        this.AdjustSpinPieceUI();
    }
    public void OnWordSubmitted(string submitWord)
    {
        string val_7;
        string val_8;
        val_7 = submitWord;
        object val_1 = new System.Object();
        typeof(SpinKingEventUIController.<>c__DisplayClass47_0).__il2cppRuntimeField_8 = val_7;
        if(this.word == 0)
        {
                val_7 = typeof(SpinKingEventUIController.<>c__DisplayClass47_0).__il2cppRuntimeField_8;
        }
        
        val_8 = this.word.answer;
        if((val_8.Equals(value:  val_7)) == true)
        {
            goto label_4;
        }
        
        WordRegion val_3 = WordRegion.instance;
        val_8 = null;
        val_8 = new System.Predicate<ZooTile>(object:  379764736, method:  new IntPtr(4103712048));
        object val_5 = 0.Find(match:  8040448);
        val_7 = 1;
        if((val_7.Contains(item:  this.letter)) == false)
        {
            goto label_11;
        }
        
        label_4:
        this.CollectSpinPiece();
        return;
        label_11:
        this.ShiftSpinPiece();
    }
    private void AdjustSpinPieceUI()
    {
        float val_13;
        if(this.spinPiece == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_2 = this.spinPiece.transform;
        UnityEngine.Transform val_3 = this.spinPiece.parent;
        if(this.spinPiece == 0)
        {
                return;
        }
        
        if(this.letter == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_6 = this.spinPiece.transform;
        UnityEngine.Transform val_7 = this.letter.transform;
        this.spinPiece.parent = this.letter;
        UnityEngine.Transform val_8 = this.spinPiece.transform;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        this.spinPiece.localPosition = new UnityEngine.Vector3();
        object val_10 = this.spinPiece.GetComponent<System.Object>();
        object val_11 = this.letter.GetComponent<System.Object>();
        1152921504765685760 = 0;
        UnityEngine.Vector2 val_12 = sizeDelta;
        UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = -9.91277E+31f, y = val_13}, d:  val_12.x);
        this.spinPiece.sizeDelta = new UnityEngine.Vector2();
    }
    private void FixStarredCoinUI()
    {
        if(this.word == 0)
        {
                return;
        }
        
        if((R4 + 36 + 33) == 0)
        {
                return;
        }
        
        R4 + 40.HideStarred();
    }
    private void OnSpinPieceMoveComplete()
    {
        this.DestroySpinPiece();
        if((SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY + 32) >= (SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY + 28 + 12))
        {
                0 = 1;
        }
        
        this.eventBtnTag.max_tag.SetActive(value:  true);
        this.eventBtnTag.ShowObtainedRing();
        if(SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY == null)
        {
            
        }
    
    }
    private void ResetSpinLevelUI()
    {
        this.spinWordIndex = 0;
        this.spinLetterIndex = 0;
        this.obtainedSpinPiece = false;
        this.IsSpinPieceAvailable = true;
    }
    private void OnGameEventHandlerProgress()
    {
        if(SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY == null)
        {
                return;
        }
        
        if((SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY + 32) >= (SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY + 28 + 12))
        {
                0 = 1;
        }
        
        this.eventBtnTag.max_tag.SetActive(value:  true);
        if((SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY + 32) >= (SpinKingEventHandler.LAST_PROGRESS_STAMP_KEY + 28 + 12))
        {
                return;
        }
        
        this.eventBtnTag.no_new_spins_ring.SetActive(value:  false);
    }
    public SpinKingEventUIController()
    {
        this.spinPieceMoveDuration = 1f;
    }

}
