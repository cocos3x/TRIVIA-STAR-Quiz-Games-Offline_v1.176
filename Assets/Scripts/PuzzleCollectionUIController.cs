using UnityEngine;
public class PuzzleCollectionUIController : MonoSingleton<PuzzleCollectionUIController>
{
    // Fields
    private UnityEngine.Transform wordRegion;
    private UnityEngine.GameObject eventButton;
    private UnityEngine.GameObject puzzlePiecePrefab;
    private UnityEngine.GameObject toolTipPrefab;
    private UnityEngine.GameObject toolTipPickPrefab;
    private UnityEngine.GameObject glow;
    private UnityEngine.Vector3 glowEffectOffset;
    private float puzzlePieceMoveDuration;
    private float glowDuration;
    private const string PUZZLE_LAST_LEVEL_INDEX_KEY = "puzzle_last_level_inxex";
    private const string PUZZLE_WORD_INDEX_KEY = "puzzle_word_index";
    private const string PUZZLE_LETTER_INDEX_KEY = "puzzle_letter_index";
    private const string PUZZLE_PIECE_OBTAINED_KEY = "puzzle_piece_obtained";
    private const string PUZZLE_PIECE_AVAILABLE_KEY = "puzzle_piece_lost";
    private const string SAVED_LANGUAGE_KEY = "puzzle_saved_lang";
    private const int DEFAULT_PUZZLE_WORD_INDEX = -1;
    private const int DEFAULT_PUZZLE_LETTER_INDEX = 0;
    private const bool DEFAULT_OBTAINED_PUZZLE_PIECE = False;
    private const bool DEFAULT_IS_PUZZLE_PIECE_AVAILABLE = True;
    public UnityEngine.GameObject puzzlePiece;
    private LineWord word;
    private Cell letter;
    private Cell lastLetter;
    private UnityEngine.GameObject toolTipBase;
    private UnityEngine.ParticleSystem glowEffect;
    private UnityEngine.Coroutine destroyTooltipUponClick;
    private bool hasLevelFinishedLoading;
    
    // Properties
    private int PuzzleWordIndex { get; set; }
    private int PuzzleLetterIndex { get; set; }
    private bool ObtainedPuzzlePiece { get; set; }
    private bool IsPuzzlePieceAvailable { get; set; }
    private string SavedLanguage { get; set; }
    public int GetPuzzleWordIndex { get; }
    
    // Methods
    private int get_PuzzleWordIndex()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -232775120, defaultValue:  0);
    }
    private void set_PuzzleWordIndex(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -232775120, value:  value);
        Player val_1 = App.Player;
        0.SaveState();
    }
    private int get_PuzzleLetterIndex()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -232551008, defaultValue:  0);
    }
    private void set_PuzzleLetterIndex(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -232551008, value:  value);
        Player val_1 = App.Player;
        0.SaveState();
    }
    private bool get_ObtainedPuzzlePiece()
    {
        return PlayerPrefsX.GetBool(name:  -232326896, defaultValue:  false);
    }
    private void set_ObtainedPuzzlePiece(bool value)
    {
        bool val_1 = PlayerPrefsX.SetBool(name:  -232326896, value:  value);
        Player val_2 = App.Player;
        0.SaveState();
    }
    private bool get_IsPuzzlePieceAvailable()
    {
        return PlayerPrefsX.GetBool(name:  -232102784, defaultValue:  true);
    }
    private void set_IsPuzzlePieceAvailable(bool value)
    {
        bool val_1 = PlayerPrefsX.SetBool(name:  -232102784, value:  value);
        Player val_2 = App.Player;
        0.SaveState();
    }
    private string get_SavedLanguage()
    {
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.GetCurrentLanguage();
        return UnityEngine.PlayerPrefs.GetString(key:  -231878672, defaultValue:  null);
    }
    private void set_SavedLanguage(string value)
    {
        UnityEngine.PlayerPrefs.SetString(key:  -231878672, value:  value);
    }
    public int get_GetPuzzleWordIndex()
    {
        return this.PuzzleWordIndex;
    }
    private void Start()
    {
        WordRegion val_1 = WordRegion.instance;
        if(0 == 0)
        {
                return;
        }
        
        WordRegion val_3 = WordRegion.instance;
        System.Action<System.Boolean, System.String, LineWord, Cell> val_4 = new System.Action<System.Boolean, System.String, LineWord, Cell>(object:  -231507296, method:  new IntPtr(4063432928));
        0.addOnPreprocessPlayerTurnAction(callback:  7614464);
        WordRegion val_5 = WordRegion.instance;
        System.Action<twelvegigs.storage.JsonDictionary> val_6 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -231507296, method:  new IntPtr(4063433952));
        0.addOnWordFoundAction(callback:  7401472);
        WordRegion val_7 = WordRegion.instance;
        System.Action<UnityEngine.Vector3> val_8 = new System.Action<UnityEngine.Vector3>(object:  -231507296, method:  new IntPtr(4063434976));
        0.addOnHintUsedAtLocation(callback:  7401472);
    }
    public void LevelFinishedLoading()
    {
        this.hasLevelFinishedLoading = true;
        this.UpdatePuzzleCollectionUI();
    }
    public void UpdatePuzzleCollectionUI()
    {
        var val_4;
        var val_5;
        var val_6;
        val_4 = this;
        if(this.hasLevelFinishedLoading == false)
        {
                return;
        }
        
        val_5 = 35629547;
        val_6 = 1152921504927719424;
        if(PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED == 0)
        {
                return;
        }
        
        if(PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED.IsEventExpired() == false)
        {
            goto label_3;
        }
        
        this.DestroyPuzzlePiece();
        if(PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED != 0)
        {
            goto typeof(System.Int32).__il2cppRuntimeField_17C;
        }
        
        goto typeof(System.Int32).__il2cppRuntimeField_17C;
        label_3:
        if(R5 == 0)
        {
                mem2[0] = 1;
        }
        
        if((R6 + 92.PlayingChallenge) == false)
        {
                return;
        }
        
        R4.InitializePuzzlePiece();
    }
    private void OnWordRegionPreprocessPlayerTurn(bool hintUsage, string wordEntered, LineWord lineWord, Cell cell)
    {
        var val_9;
        var val_9 = 25899739;
        val_9 = 9729808 + val_9;
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = 1152921504927719424;
        if(PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED == 0)
        {
                return;
        }
        
        if(PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED.IsEventExpired() == true)
        {
                return;
        }
        
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        bool val_2 = PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED.PlayingChallenge;
        if(val_2 == false)
        {
                return;
        }
        
        if(val_2.IsPuzzlePlacementDataValid() == false)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  wordEntered)) == true)
        {
                return;
        }
        
        val_9 = 1152921504886931456;
        WordRegion val_5 = WordRegion.instance;
        int val_6 = this.PuzzleWordIndex;
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
    private void onWordRegionWordFound(string wordCompleted)
    {
        var val_4;
        var val_5;
        var val_6;
        val_4 = this;
        val_5 = 35629547;
        val_6 = 1152921504927719424;
        if(PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED == 0)
        {
                return;
        }
        
        if(PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED.IsEventExpired() == false)
        {
            goto label_2;
        }
        
        this.DestroyPuzzlePiece();
        if(PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED != 0)
        {
            goto typeof(System.Int32).__il2cppRuntimeField_17C;
        }
        
        goto typeof(System.Int32).__il2cppRuntimeField_17C;
        label_2:
        if(R5 == 0)
        {
                mem2[0] = 1;
        }
        
        if((R6 + 92.PlayingChallenge) == false)
        {
                return;
        }
        
        R4.UpdatePuzzlePiece(hackPuzzleSolution:  false);
    }
    private void onWordRegionHintUsed(UnityEngine.Vector3 location)
    {
        float val_6;
        float val_7;
        float val_8;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        val_13 = this;
        val_14 = location.z;
        val_15 = location.y;
        val_16 = location.x;
        val_17 = 9732704 + 25896843;
        if(val_17 == 0)
        {
                mem2[0] = 1;
        }
        
        val_18 = 1152921504927719424;
        if(PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED == 0)
        {
            goto label_16;
        }
        
        if(PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED.IsEventExpired() == false)
        {
            goto label_3;
        }
        
        this.DestroyPuzzlePiece();
        if(val_17 == 0)
        {
                mem2[0] = 1;
        }
        
        if(PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED != 0)
        {
            goto typeof(System.Int32).__il2cppRuntimeField_17C;
        }
        
        goto typeof(System.Int32).__il2cppRuntimeField_17C;
        label_3:
        if(R5 == 0)
        {
                mem2[0] = 1;
        }
        
        if(((R6 + 92.PlayingChallenge) != false) && ((R4 + 56) != 0))
        {
                UnityEngine.Transform val_4 = R4 + 56.transform;
            val_18 = 0;
            UnityEngine.Vector3 val_5 = position;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = R7, y = SB, z = R8}, rhs:  new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_6})) != false)
        {
                R4.UpdatePuzzlePiece(hackPuzzleSolution:  false);
        }
        
        }
        
        label_16:
        var val_10 = FP - 24;
    }
    private bool IsPuzzlePlacementDataValid()
    {
        int val_1 = this.PuzzleWordIndex;
        if(val_1 < 0)
        {
                return false;
        }
        
        WordRegion val_3 = WordRegion.instance;
        if(val_1.PuzzleWordIndex >= 0)
        {
                return false;
        }
        
        int val_4 = this.PuzzleLetterIndex;
        if(val_4 < 0)
        {
                return false;
        }
        
        WordRegion val_6 = WordRegion.instance;
        int val_7 = this.PuzzleWordIndex;
        if(0 <= val_7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_8 = 0;
        val_8 = val_8 + (val_7 << 2);
        if(val_4.PuzzleLetterIndex < ((0 + (val_7) << 2) + 16 + 20 + 12))
        {
                0 = 1;
        }
        
        return true;
    }
    private void InitializePuzzlePiece()
    {
        PuzzleCollectionUIController val_37;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        val_37 = this;
        var val_38 = 25901635;
        val_38 = 9727912 + val_38;
        if(val_38 == 0)
        {
                mem2[0] = 1;
        }
        
        if(PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED.PlayingChallenge == false)
        {
                return;
        }
        
        if(PuzzleCollectionHandler.IsNewCycle != false)
        {
                PuzzleCollectionHandler.IsNewCycle = false;
            this.DestroyPuzzlePiece();
            this.DestroyTooltip();
        }
        
        if(val_38 == 0)
        {
                mem2[0] = 1;
        }
        
        bool val_3 = PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED.IsSolvingInProgress();
        if(val_3 == false)
        {
            goto label_7;
        }
        
        string val_4 = val_3.SavedLanguage;
        GameBehavior val_5 = App.getBehavior;
        val_39 = 0;
        string val_6 = val_39.GetCurrentLanguage();
        bool val_7 = System.String.op_Inequality(a:  val_3, b:  null);
        if(val_7 == false)
        {
            goto label_12;
        }
        
        label_7:
        string val_8 = val_7.SavedLanguage;
        GameBehavior val_9 = App.getBehavior;
        val_39 = 0;
        string val_10 = val_39.GetCurrentLanguage();
        if((System.String.op_Inequality(a:  val_7, b:  null)) != false)
        {
                GameBehavior val_12 = App.getBehavior;
            string val_13 = 0.GetCurrentLanguage();
            this.SavedLanguage = null;
            bool val_14 = this.ObtainedPuzzlePiece;
            if(val_14 == true)
        {
                return;
        }
        
        }
        
        val_14.ResetPuzzleLevelUI();
        RandomSet val_15 = new RandomSet();
        WordRegion val_16 = WordRegion.instance;
        System.Collections.Generic.List<System.Int32> val_17 = 0.getAvailableLineIndices;
        val_39 = 0;
        val_40 = 4;
        goto label_26;
        label_38:
        WordRegion val_18 = WordRegion.instance;
        if(0 <= val_37)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(0 <= (3.673424E-39f))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_39 = 0;
        val_39 = val_39 + 10485772;
        val_41 = mem[(0 + 10485772) + 16];
        val_41 = (0 + 10485772) + 16;
        if(((0 + 10485772) + 16 + 32) == 0)
        {
                if(0 <= val_37)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_41 = 2621443;
            add(item:  2621443, weight:  null);
        }
        
        val_40 = 5;
        label_26:
        if((val_40 - 4) < 0)
        {
            goto label_38;
        }
        
        val_37 = val_37;
        if(count() == 0)
        {
                return;
        }
        
        val_42 = 0;
        int val_21 = roll(unweighted:  false);
        val_21.PuzzleWordIndex = val_21;
        goto label_42;
        label_60:
        WordRegion val_22 = WordRegion.instance;
        val_43 = 0;
        int val_23 = this.PuzzleWordIndex;
        if(0 <= val_23)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_40 = 0;
        val_40 = val_40 + (val_23 << 2);
        if(((0 + (val_23) << 2) + 16 + 20 + 12) <= val_42)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_41 = (0 + (val_23) << 2) + 16 + 20 + 8;
        val_41 = val_41 + 0;
        if((((0 + (val_23) << 2) + 16 + 20 + 8 + 0) + 16 + 36) == 0)
        {
            goto label_52;
        }
        
        val_42 = 1;
        label_42:
        WordRegion val_24 = WordRegion.instance;
        val_43 = 0;
        int val_25 = this.PuzzleWordIndex;
        if(0 <= val_25)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_42 = 0;
        val_42 = val_42 + (val_25 << 2);
        if(val_42 < ((0 + (val_25) << 2) + 16 + 20 + 12))
        {
            goto label_60;
        }
        
        goto label_61;
        label_12:
        bool val_26 = val_7.ObtainedPuzzlePiece;
        if(val_26 == true)
        {
                return;
        }
        
        if(val_26.IsPuzzlePieceAvailable == false)
        {
                return;
        }
        
        bool val_28 = UnityEngine.Object.op_Inequality(x:  this.puzzlePiece, y:  0);
        if(val_28 == true)
        {
                return;
        }
        
        if(val_28.IsPuzzlePlacementDataValid() == false)
        {
                return;
        }
        
        this.ShowPuzzlePiece();
        this.FixStarredCoinUI();
        if(this.IsFTUX() == false)
        {
                return;
        }
        
        System.Collections.IEnumerator val_31 = this.ShowTooltip(parent:  this.wordRegion);
        UnityEngine.Coroutine val_32 = this.StartCoroutine(routine:  -230682336);
        return;
        label_52:
        ((0 + (val_23) << 2) + 16 + 20 + 8 + 0) + 16 + 36.PuzzleLetterIndex = 0;
        label_61:
        this.ShowPuzzlePiece();
        this.FixStarredCoinUI();
        if(this.IsFTUX() != false)
        {
                WordRegion val_34 = WordRegion.instance;
            UnityEngine.Transform val_35 = 0.SafeTransform;
            System.Collections.IEnumerator val_36 = this.ShowTooltip(parent:  0);
            UnityEngine.Coroutine val_37 = this.StartCoroutine(routine:  -230682336);
        }
        
        PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED.SaveEventProgress();
    }
    public void UpdatePuzzlePiece(bool hackPuzzleSolution = False)
    {
        var val_33;
        UnityEngine.GameObject val_34;
        System.Collections.Generic.List<Cell> val_35;
        val_33 = 1152921504765685760;
        val_34 = this.puzzlePiece;
        bool val_1 = UnityEngine.Object.op_Equality(x:  val_34, y:  0);
        if(val_1 != true)
        {
                if(val_1.ObtainedPuzzlePiece == false)
        {
            goto label_4;
        }
        
        }
        
        if(this.puzzlePiece != 0)
        {
                return;
        }
        
        PuzzleCollectionHandler.IsFTUX = false;
        return;
        label_4:
        this.ShowPuzzlePiece();
        if(hackPuzzleSolution != false)
        {
                val_34 = this.word;
            if(hackPuzzleSolution == false)
        {
                return;
        }
        
            this.DestroyTooltip();
            PuzzleCollectionHandler.IsFTUX = false;
            this.ObtainedPuzzlePiece = true;
            PuzzleCollectionHandler.EarnedPuzzlePiece = true;
            if((PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED + 24) != 0)
        {
                PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED + 24.Invoke();
        }
        
            if(PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED.HandleCurrentPuzzleProgression() != false)
        {
                PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED.HandleCurrentPuzzleSolved();
        }
        
            UnityEngine.Transform val_5 = this.puzzlePiece.transform;
            UnityEngine.Transform val_6 = this.eventButton.transform;
            this.puzzlePiece.parent = this.eventButton;
            UnityEngine.Transform val_7 = this.puzzlePiece.transform;
            val_33 = 0;
            UnityEngine.Transform val_8 = this.eventButton.transform;
            UnityEngine.Vector3 val_9 = position;
            DG.Tweening.Tweener val_10 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.puzzlePiece, endValue:  new UnityEngine.Vector3(), duration:  this.puzzlePieceMoveDuration, snapping:  this.puzzlePieceMoveDuration);
            DG.Tweening.TweenCallback val_11 = new DG.Tweening.TweenCallback(object:  -230495584, method:  new IntPtr(4064413920));
            object val_12 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.puzzlePiece, action:  190734336);
            val_34 = 0;
            UnityEngine.Transform val_13 = this.puzzlePiece.transform;
            UnityEngine.Vector3 val_15 = new UnityEngine.Vector3(x:  (float)UnityEngine.Random.Range(min:  -720, max:  720), y:  val_9.y, z:  val_9.z);
            DG.Tweening.Tweener val_16 = DG.Tweening.ShortcutExtensions.DORotate(target:  this.puzzlePiece, endValue:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, duration:  this.puzzlePieceMoveDuration, mode:  this.puzzlePieceMoveDuration);
            object val_17 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.puzzlePiece, ease:  5);
            UnityEngine.Transform val_18 = this.puzzlePiece.transform;
            UnityEngine.Vector3 val_19 = new UnityEngine.Vector3(x:  this.puzzlePieceMoveDuration, y:  val_9.y, z:  val_9.z);
            DG.Tweening.Tweener val_20 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.puzzlePiece, endValue:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, duration:  this.puzzlePieceMoveDuration);
            return;
        }
        
        int val_21 = this.word.isShown.PuzzleLetterIndex;
        val_21.PuzzleLetterIndex = val_21 + 1;
        int val_23 = val_21.PuzzleLetterIndex;
        val_35 = this.word.cells;
        if(val_23 >= val_23)
        {
            goto label_33;
        }
        
        label_41:
        int val_24 = val_23.PuzzleLetterIndex;
        if(val_24 <= val_24)
        {
                var val_33 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_33 = val_33 + (val_24 << 2);
        if(((0 + (val_24) << 2) + 16 + 36) == 0)
        {
            goto label_38;
        }
        
        int val_25 = (0 + (val_24) << 2) + 16 + 36.PuzzleLetterIndex;
        val_25.PuzzleLetterIndex = val_25 + 1;
        val_35 = this.word.cells;
        if(val_25.PuzzleLetterIndex < val_25.PuzzleLetterIndex)
        {
            goto label_41;
        }
        
        this.DestroyPuzzlePiece();
        goto label_42;
        label_33:
        this.DestroyPuzzlePiece();
        this.DestroyTooltip();
        this.FixStarredCoinUI();
        label_42:
        this.IsPuzzlePieceAvailable = false;
        PuzzleCollectionHandler.EarnedPuzzlePiece = false;
        return;
        label_38:
        this.letter = (0 + (val_24) << 2) + 16;
        this.AdjustPuzzlePieceUI();
        this.FixStarredCoinUI();
        this.DestroyTooltip();
        if(this.IsFTUX() == false)
        {
                return;
        }
        
        WordRegion val_29 = WordRegion.instance;
        UnityEngine.Transform val_30 = 0.SafeTransform;
        System.Collections.IEnumerator val_31 = this.ShowTooltip(parent:  0);
        UnityEngine.Coroutine val_32 = this.StartCoroutine(routine:  -230495584);
    }
    public UnityEngine.GameObject CreatePuzzlePiece(UnityEngine.Transform parent)
    {
        if(this.puzzlePiece != 0)
        {
                return;
        }
        
        object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  this.puzzlePiecePrefab, parent:  parent);
        this.puzzlePiece = this.puzzlePiecePrefab;
    }
    public UnityEngine.Transform GetLetterTransform()
    {
        int val_1 = this.PuzzleLetterIndex;
        if(val_1 <= val_1)
        {
                var val_2 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_2 = val_2 + (val_1 << 2);
        if(((0 + (val_1) << 2) + 16) != 0)
        {
                return (0 + (val_1) << 2) + 16.transform;
        }
        
        return (0 + (val_1) << 2) + 16.transform;
    }
    public void ShowToolTip()
    {
        if(this.toolTipBase != 0)
        {
                return;
        }
        
        if(this.puzzlePiece == 0)
        {
                return;
        }
        
        WordRegion val_3 = WordRegion.instance;
        UnityEngine.Transform val_4 = 0.SafeTransform;
        System.Collections.IEnumerator val_5 = this.ShowTooltip(parent:  0);
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  -230036704);
    }
    public void DestroyTooltip()
    {
        if(this.toolTipBase == 0)
        {
                return;
        }
        
        UnityEngine.Object.DestroyImmediate(obj:  this.toolTipBase);
    }
    public void ResetUIProgress()
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  -232775120)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -232775120);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -232551008)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -232551008);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -232326896)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -232326896);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -232102784)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -232102784);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -231878672)) == false)
        {
                return;
        }
        
        UnityEngine.PlayerPrefs.DeleteKey(key:  R4);
    }
    private void DeletePlayerPref(string key)
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  key)) == false)
        {
                return;
        }
        
        UnityEngine.PlayerPrefs.DeleteKey(key:  R4);
    }
    private System.Collections.IEnumerator DestroyTooltipUponClick()
    {
        object val_1 = new System.Object();
        typeof(PuzzleCollectionUIController.<DestroyTooltipUponClick>d__59).__il2cppRuntimeField_8 = 0;
        typeof(PuzzleCollectionUIController.<DestroyTooltipUponClick>d__59).__il2cppRuntimeField_10 = this;
    }
    public void ShowPuzzlePiece()
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
        
        val_15 = "PuzzleCollectionUIController attempting to ShowPuzzlePiece but no WordRegion exists!";
        goto label_8;
        label_5:
        if(val_2.IsPuzzlePlacementDataValid() == false)
        {
            goto label_9;
        }
        
        WordRegion val_4 = WordRegion.instance;
        val_16 = 0;
        int val_5 = this.PuzzleWordIndex;
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
        
        int val_7 = val_6.PuzzleWordIndex;
        val_17 = null;
        val_18 = "PuzzleCollectionUIController attempting to ShowPuzzlePiece but no word exists for PuzzleWordIndex ";
        goto label_18;
        label_9:
        val_15 = "PuzzleCollectionUIController attempting to ShowPuzzlePiece but associated word/letter index is outdated!";
        label_8:
        UnityEngine.Debug.LogError(message:  -229467424);
        return;
        label_17:
        val_19 = this.word.cells;
        int val_8 = val_6.PuzzleLetterIndex;
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
        
        int val_10 = val_9.PuzzleLetterIndex;
        val_17 = null;
        val_18 = "PuzzleCollectionUIController attempting to ShowPuzzlePiece but no letter exists for PuzzleLetterIndex ";
        label_18:
        string val_11 = -229458944(-229458944) + 13152256;
        UnityEngine.Debug.LogError(message:  -229458944);
        return;
        label_26:
        if(this.puzzlePiece == 0)
        {
                UnityEngine.Transform val_13 = this.letter.transform;
            val_20 = this.letter;
            object val_14 = UnityEngine.Object.Instantiate<System.Object>(original:  this.puzzlePiecePrefab, parent:  val_20);
            this.puzzlePiece = this.puzzlePiecePrefab;
        }
        
        this.AdjustPuzzlePieceUI();
    }
    private void AdjustPuzzlePieceUI()
    {
        float val_13;
        if(this.puzzlePiece == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_2 = this.puzzlePiece.transform;
        UnityEngine.Transform val_3 = this.puzzlePiece.parent;
        if(this.puzzlePiece == 0)
        {
                return;
        }
        
        if(this.letter == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_6 = this.puzzlePiece.transform;
        UnityEngine.Transform val_7 = this.letter.transform;
        this.puzzlePiece.parent = this.letter;
        UnityEngine.Transform val_8 = this.puzzlePiece.transform;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        this.puzzlePiece.localPosition = new UnityEngine.Vector3();
        object val_10 = this.puzzlePiece.GetComponent<System.Object>();
        object val_11 = this.letter.GetComponent<System.Object>();
        1152921504765685760 = 0;
        UnityEngine.Vector2 val_12 = sizeDelta;
        UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = -4.231375E+30f, y = val_13}, d:  val_12.x);
        this.puzzlePiece.sizeDelta = new UnityEngine.Vector2();
    }
    private void FixStarredCoinUI()
    {
        if(this.word == 0)
        {
                return;
        }
        
        if(this.word.isStarred == false)
        {
                return;
        }
        
        if(this.puzzlePiece == 0)
        {
                this.lastLetter = this.letter;
        }
        
        this.letter.HideStarred();
        if(this.lastLetter != 0)
        {
                this.lastLetter.ShowStarred();
        }
        
        this.lastLetter = this.letter;
    }
    private void DestroyPuzzlePiece()
    {
        if(this.puzzlePiece == 0)
        {
                return;
        }
        
        1152921504765685760 = 0;
        UnityEngine.Object.Destroy(obj:  this.puzzlePiece);
        this.puzzlePiece = 1152921504765685760;
    }
    private bool IsFTUX()
    {
        var val_5 = 0;
        if(PuzzleCollectionHandler.IsFTUX == false)
        {
                return (bool)val_5;
        }
        
        int val_2 = this.PuzzleLetterIndex;
        val_5 = 1;
        if(val_2 == (val_2 - 1))
        {
                return (bool)val_5;
        }
        
        val_5 = this.PuzzleLetterIndex >> 5;
        return (bool)val_5;
    }
    private System.Collections.IEnumerator ShowTooltip(UnityEngine.Transform parent)
    {
        typeof(PuzzleCollectionUIController.<ShowTooltip>d__65).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(PuzzleCollectionUIController.<ShowTooltip>d__65).__il2cppRuntimeField_10 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        typeof(PuzzleCollectionUIController.<ShowTooltip>d__65).__il2cppRuntimeField_14 = parent;
    }
    private void OnPuzzlePieceMoveComplete()
    {
        this.DestroyPuzzlePiece();
        UnityEngine.Transform val_1 = this.eventButton.transform;
        object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  this.glow, parent:  this.eventButton);
        object val_3 = this.glow.GetComponent<System.Object>();
        this.glowEffect = this.glow;
        UnityEngine.Transform val_4 = this.glow.transform;
        this.glow.localPosition = new UnityEngine.Vector3() {x = mem[this.glowEffectOffset + (0)], y = mem[this.glowEffectOffset + (4)], z = mem[this.glowEffectOffset + (8)]};
        this.glowEffect.Play();
        this.Invoke(methodName:  -228577776, time:  null);
    }
    private void OnCollectedPuzzlePiece()
    {
        UnityEngine.Transform val_1 = this.glowEffect.transform;
        UnityEngine.GameObject val_2 = this.glowEffect.gameObject;
        UnityEngine.Object.DestroyImmediate(obj:  this.glowEffect);
        PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED.PuzzlePieceAnimationComplete();
    }
    private void ResetPuzzleLevelUI()
    {
        this.PuzzleWordIndex = 0;
        this.PuzzleLetterIndex = 0;
        this.ObtainedPuzzlePiece = false;
        this.IsPuzzlePieceAvailable = true;
    }
    private void ClearUIProgress()
    {
        this.DestroyPuzzlePiece();
        this.DestroyTooltip();
    }
    public PuzzleCollectionUIController()
    {
        UnityEngine.Vector3 val_1 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
    }

}
