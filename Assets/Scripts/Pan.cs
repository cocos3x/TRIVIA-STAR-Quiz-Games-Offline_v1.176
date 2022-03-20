using UnityEngine;
public class Pan : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler, IPointerDownHandler, IPointerUpHandler
{
    // Fields
    private string word;
    private System.Collections.Generic.List<string> tileStrings;
    private System.Collections.Generic.List<UnityEngine.Vector3> letterPositions;
    private System.Collections.Generic.List<UnityEngine.Vector3> letterLocalPositions;
    private System.Collections.Generic.List<int> indexes;
    private bool hasInitialized;
    private int level;
    public UnityEngine.Transform centerPoint;
    public TextPreview textPreview;
    public static Pan instance;
    public System.Collections.Generic.List<LetterTile> letterTexts;
    private bool isShuffling;
    private UnityEngine.RectTransform SelectableLetters;
    private WGGameplayMessage swipeLettersMessage;
    private UnityEngine.CanvasGroup canvasGroup;
    private UGUIFadeCanvasGroup myFader;
    private int wrongClickCount;
    private const bool tappingAllowed = False;
    private bool didDrag;
    
    // Properties
    public System.Collections.Generic.List<string> getTileStrings { get; }
    public int numberOfLetters { get; }
    private int WrongClickCounter { get; set; }
    
    // Methods
    public System.Collections.Generic.List<string> get_getTileStrings()
    {
    
    }
    public int get_numberOfLetters()
    {
        if(this.tileStrings != 0)
        {
                return (int)true;
        }
        
        return (int)true;
    }
    private int get_WrongClickCounter()
    {
        return (int)this.wrongClickCount;
    }
    private void set_WrongClickCounter(int value)
    {
        this.wrongClickCount = value;
        if(value < 3)
        {
                return;
        }
        
        this.wrongClickCount = 0;
        if(this.swipeLettersMessage == 0)
        {
                return;
        }
        
        35638607 = 0;
        string val_2 = Localization.Localize(key:  -2076753664, defaultValue:  -2076753776, useSingularKey:  false);
        bool val_3 = this.swipeLettersMessage.ShowMessage(message:  -2076753664, showLetterNo:  false, letterCount:  0);
    }
    private void Awake()
    {
        Pan.tappingAllowed = this;
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.UI.LayoutElement val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -2076601152);
        this.canvasGroup = this;
        this.interactable = false;
        this.canvasGroup.blocksRaycasts = false;
    }
    private void Start()
    {
        this.level = Prefs.currentLevel;
        MainController val_2 = MainController.instance;
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -2076483008, method:  new IntPtr(2218458240));
        4.AddListener(call:  162246656);
        WordRegion val_4 = WordRegion.instance;
        UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  -2076483008, method:  new IntPtr(2218459264));
        2.AddListener(call:  162246656);
    }
    private void RecalculatePanPositions()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(this.activeInHierarchy == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_3 = this.gameObject;
        if(this.activeSelf == false)
        {
                return;
        }
        
        this.letterLocalPositions.Clear();
        this.letterPositions.Clear();
        this.CalculatePostions();
        System.Collections.IEnumerator val_5 = this.SetLettersPositions();
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  -2076362816);
        this.RecalculateLetterPositions();
    }
    private void CalculatePostions()
    {
        Pan val_8;
        var val_9;
        float val_10;
        UnityEngine.Transform val_11;
        val_8 = this;
        float val_8 = (float)S0;
        GameBehavior val_1 = App.getBehavior;
        val_8 = 360f / val_8;
        float val_11 = 90f;
        val_9 = 0;
        val_10 = 1152921511060987696;
        goto label_6;
        label_23:
        float val_2 = val_11 * 3.141593f;
        float val_3 = val_2 / 180f;
        var val_9 = val_3;
        var val_10 = val_3;
        GameBehavior val_4 = App.getBehavior;
        val_9 = val_9 / 0;
        val_10 = 0 * val_10;
        UnityEngine.Vector3 val_5 = new UnityEngine.Vector3(x:  val_2, y:  null, z:  null);
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(d:  0f, a:  new UnityEngine.Vector3() {x = -2.246577E-36f, y = 0f, z = val_5.x});
        this.letterLocalPositions.Add(item:  new UnityEngine.Vector3() {x = R5, y = R6, z = R8});
        val_11 = this.centerPoint;
        if(val_11 == 0)
        {
            goto label_16;
        }
        
        if(null != null)
        {
                if(val_11 == 0)
        {
            goto label_20;
        }
        
        }
        
        if(null == null)
        {
            goto label_19;
        }
        
        goto label_20;
        label_16:
        label_20:
        val_11 = 0;
        label_19:
        UnityEngine.Vector3 val_7 = TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = R5, z = R6});
        val_10 = val_10;
        this.letterPositions.Add(item:  new UnityEngine.Vector3());
        val_11 = val_8 + val_11;
        val_8 = val_8;
        val_9 = 1;
        label_6:
        if(val_9 < this.letterPositions)
        {
            goto label_23;
        }
        
        LineDrawer.instance.letterPositions = this.letterPositions;
    }
    public void Load(GameLevel gameLevel)
    {
        float val_18;
        LetterTile val_44;
        float val_45;
        System.Collections.Generic.List<System.String> val_46;
        var val_47;
        var val_48;
        var val_49;
        System.Func<System.String, System.Int32> val_51;
        var val_52;
        System.Collections.Generic.List<System.Int32> val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        bool val_62;
        System.Collections.Generic.List<System.Int32> val_63;
        string val_2 = gameLevel.word.Trim();
        System.Collections.Generic.List<T> val_3 = CUtils.BuildListFromString<System.String>(values:  gameLevel.word, split:  '|');
        this.tileStrings = gameLevel.word;
        if(gameLevel.word.m_firstChar <= '')
        {
                this.tileStrings.Clear();
            string val_4 = gameLevel.word.Trim();
            if(gameLevel.word.m_stringLength >= 1)
        {
                var val_46 = 0;
            val_45 = 1152921510046813136;
            do
        {
            string val_6 = gameLevel.word.Chars[0].ToString();
            this.tileStrings.Add(item:  -2076002374);
            val_46 = val_46 + 1;
        }
        while(gameLevel.word.m_stringLength != val_46);
        
        }
        
        }
        
        this.CalculatePostions();
        val_46 = 0;
        val_47 = 0;
        goto label_14;
        label_36:
        LetterTile val_7 = MonoUtils.instance.letterTile;
        object val_8 = UnityEngine.Object.Instantiate<System.Object>(original:  MonoUtils.instance);
        val_44 = MonoUtils.instance;
        UnityEngine.Transform val_9 = val_44.transform;
        val_44.SetParent(p:  this.centerPoint);
        UnityEngine.Transform val_10 = val_44.transform;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -2.288891E-36f}, d:  GetScaleMultBasedOnCount(count:  0));
        val_44.localScale = new UnityEngine.Vector3();
        UnityEngine.Transform val_14 = val_44.transform;
        UnityEngine.Vector3 val_16 = new UnityEngine.Vector3(x:  (float)UnityEngine.Random.Range(min:  9, max:  10), y:  val_13.y, z:  val_13.z);
        UnityEngine.Quaternion val_17 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = -2.288885E-36f, y = val_16.x, z = val_16.y});
        val_44.localRotation = new UnityEngine.Quaternion() {w = val_18};
        if(val_44 <= val_47)
        {
                var val_47 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_47 = val_47 + 0;
        string val_19 = (0 + 0) + 16.ToUpper();
        val_45 = (0 + 0) + 16;
        this.letterTexts.Add(item:  val_44);
        val_47 = 1;
        label_14:
        if(val_47 < this.letterTexts)
        {
            goto label_36;
        }
        
        System.Collections.Generic.IEnumerable<System.Int32> val_20 = System.Linq.Enumerable.Range(start:  0, count:  val_44);
        System.Collections.Generic.List<TSource> val_21 = System.Linq.Enumerable.ToList<System.Int32>(source:  0);
        this.indexes = 0;
        System.Nullable<System.Int32> val_22 = new System.Nullable<System.Int32>(value:  this.level);
        PluginExtension.Shuffle<System.Int32>(list:  0, seed:  new System.Nullable<System.Int32>() {HasValue = val_22.HasValue});
        val_48 = 1152921504892043264;
        GameBehavior val_23 = App.getBehavior;
        GameEcon val_24 = App.getGameEcon;
        if(0 > 1507345)
        {
            goto label_47;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_25 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
            goto label_47;
        }
        
        typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
        System.String[] val_27 = gameLevel + 52.Split(separator:  478563824);
        System.Collections.Generic.List<ZooTile> val_28 = new System.Collections.Generic.List<ZooTile>(collection:  gameLevel + 52);
        val_49 = null;
        val_49 = null;
        val_51 = Pan.<>c.<>9__28_0;
        if(val_51 == 0)
        {
                val_51 = null;
            val_51 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  Pan.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2218900736));
            Pan.<>c.<>9__28_0 = val_51;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_30 = System.Linq.Enumerable.OrderByDescending<System.Object, System.Int32>(source:  80883712, keySelector:  7720960);
        System.Collections.Generic.List<TSource> val_31 = System.Linq.Enumerable.ToList<System.Object>(source:  80883712);
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        System.Collections.Generic.List<System.Int32> val_32 = new System.Collections.Generic.List<System.Int32>();
        this.indexes.Clear();
        val_45 = 0;
        val_52 = 0;
        goto label_73;
        label_78:
        if((Contains(item:  0)) != true)
        {
                Add(item:  0);
        }
        
        val_52 = 1;
        label_73:
        if(val_52 < this.tileStrings)
        {
            goto label_78;
        }
        
        val_54 = this.indexes;
        if(1152921505700909039 < 0)
        {
            goto label_79;
        }
        
        val_55 = 1152921505700909043;
        goto label_80;
        label_83:
        val_55 = 1152921505700909042;
        label_80:
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_54.Add(item:  mem[1152921505782185912]);
        val_54 = this.indexes;
        if(1152921505700909037 >= 0)
        {
            goto label_83;
        }
        
        label_79:
        if(val_54 != 0)
        {
                val_57 = 1152921505700909037;
        }
        else
        {
                val_57 = 0;
            val_56 = 0;
        }
        
        if(val_56 <= (-1))
        {
                var val_50 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_50 = val_50 + 4294967292;
        val_44 = 1152921511120737536;
        val_54.Insert(index:  0, item:  (0 + 4294967292) + 16);
        if(this.indexes != 0)
        {
            
        }
        else
        {
                val_58 = 0;
        }
        
        val_46 = 1152921511112785536;
        this.indexes.RemoveAt(index:  val_58 - 1);
        if(this.indexes != 0)
        {
                val_60 = this.indexes;
        }
        else
        {
                val_60 = 0;
            val_59 = 0;
        }
        
        if(val_59 <= (-1))
        {
                var val_51 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_51 = val_51 + 4294967292;
        this.indexes.Insert(index:  0, item:  (0 + 4294967292) + 16);
        if(this.indexes != 0)
        {
            
        }
        else
        {
                val_61 = 0;
        }
        
        val_48 = 1152921504892043264;
        this.indexes.RemoveAt(index:  val_61 - 1);
        label_47:
        val_62 = WGFTUXManager.CanShow;
        if(val_62 != false)
        {
                WordPets.WPTDataParser val_39 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            GameBehavior val_40 = App.getBehavior;
            val_46 = this.tileStrings;
            val_62 = public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance();
            System.Collections.Generic.List<System.Int32> val_41 = GetIndexesForTutorialLevel(level:  0, lettersSize:  this.indexes, lettersArray:  val_46);
            val_63 = val_62;
            this.indexes = val_62;
        }
        else
        {
                val_63 = this.indexes;
        }
        
        System.Collections.IEnumerator val_42 = val_62.EnableLetters(tileStrings:  this.tileStrings, indexes:  val_63);
        UnityEngine.Coroutine val_43 = this.StartCoroutine(routine:  val_62);
        this.hasInitialized = true;
        this.GetPanWord();
        System.Collections.IEnumerator val_44 = this.SetLettersPositions();
        UnityEngine.Coroutine val_45 = this.StartCoroutine(routine:  -2075990336);
        this.RecalculateLetterPositions();
    }
    private System.Collections.IEnumerator EnableLetters(System.Collections.Generic.List<string> tileStrings, System.Collections.Generic.List<int> indexes)
    {
        typeof(Pan.<EnableLetters>d__29).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(Pan.<EnableLetters>d__29).__il2cppRuntimeField_10 = tileStrings;
        }
        else
        {
                mem[16] = tileStrings;
        }
        
        typeof(Pan.<EnableLetters>d__29).__il2cppRuntimeField_14 = indexes;
    }
    public void EnablePan()
    {
        this.canvasGroup.interactable = true;
        this.canvasGroup.blocksRaycasts = true;
        this.myFader.Execute();
    }
    private System.Collections.IEnumerator SetLettersPositions()
    {
        object val_1 = new System.Object();
        typeof(Pan.<SetLettersPositions>d__31).__il2cppRuntimeField_8 = 0;
        typeof(Pan.<SetLettersPositions>d__31).__il2cppRuntimeField_10 = this;
    }
    private float GetScaleMultBasedOnCount(int count)
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    private void RecalculateLetterPositions()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(this.activeInHierarchy == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_3 = R4.gameObject;
        if(R4.activeSelf == false)
        {
                return;
        }
        
        System.Collections.IEnumerator val_5 = R4.RecalculateSize();
        UnityEngine.Coroutine val_6 = R4.StartCoroutine(routine:  R4);
    }
    private System.Collections.IEnumerator RecalculateSize()
    {
        object val_1 = new System.Object();
        typeof(Pan.<RecalculateSize>d__34).__il2cppRuntimeField_8 = 0;
        typeof(Pan.<RecalculateSize>d__34).__il2cppRuntimeField_10 = this;
    }
    private void OnRectTransformDimensionsChange()
    {
        if((UnityEngine.Object.op_Implicit(exists:  LineDrawer.instance)) == false)
        {
                return;
        }
        
        R4.RecalculatePanPositions();
    }
    private void GetShuffeWord()
    {
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        AddRange(collection:  this.indexes);
        do
        {
            PluginExtension.Shuffle<System.Int32>(list:  this.indexes, seed:  new System.Nullable<System.Int32>() {HasValue = false});
        }
        while((System.Linq.Enumerable.SequenceEqual<System.Int32>(first:  80883712, second:  this.indexes)) == true);
        
        this.GetPanWord();
    }
    private void GetPanWord()
    {
        var val_2 = 0;
        goto label_1;
        label_8:
        if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) <= val_2)
        {
                var val_2 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_2 = val_2 + 0;
        if(val_2 <= ((0 + 0) + 16))
        {
                var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = val_3 + (((0 + 0) + 16) << 2);
        Add(item:  (0 + ((0 + 0) + 16) << 2) + 16);
        val_2 = 1;
        label_1:
        if(val_2 < null)
        {
            goto label_8;
        }
        
        this.textPreview.tileStrings = null;
    }
    public string GetLetter(int i)
    {
        if(true <= i)
        {
                var val_1 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_1 = val_1 + (i << 2);
        if(val_1 <= ((0 + (i) << 2) + 16))
        {
                var val_2 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_2 = val_2 + (((0 + (i) << 2) + 16) << 2);
    }
    public void HighlightLetter(int i, bool state)
    {
        var val_2;
        var val_3;
        val_2 = this;
        val_3 = 35638621;
        if(this.hasInitialized == false)
        {
                return;
        }
        
        if(this.hasInitialized <= i)
        {
                var val_1 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_1 = val_1 + (i << 2);
        if(val_1 <= ((0 + (i) << 2) + 16))
        {
                var val_2 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_2 = val_2 + (((0 + (i) << 2) + 16) << 2);
        if(((0 + ((0 + (i) << 2) + 16) << 2) + 16) == 0)
        {
            
        }
    
    }
    public void UnhighlightAllLetters()
    {
        var val_1;
        if(this.hasInitialized == false)
        {
                return;
        }
        
        val_1 = 0;
        goto label_2;
        label_9:
        if(this.hasInitialized <= val_1)
        {
                var val_1 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_1 = val_1 + 0;
        if(val_1 <= ((0 + 0) + 16))
        {
                var val_2 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_2 = val_2 + (((0 + 0) + 16) << 2);
        val_1 = 1;
        label_2:
        if(val_1 < ((0 + ((0 + 0) + 16) << 2) + 16))
        {
            goto label_9;
        }
    
    }
    public int IsInRectofAnyTile(UnityEngine.Vector2 mousePos)
    {
        var val_3 = 0;
        goto label_1;
        label_11:
        if(true <= val_3)
        {
                var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = val_3 + 0;
        if(val_3 <= ((0 + 0) + 16))
        {
                var val_4 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4 = val_4 + (((0 + 0) + 16) << 2);
        UnityEngine.Camera val_1 = UnityEngine.Camera.main;
        bool val_2 = UnityEngine.RectTransformUtility.RectangleContainsScreenPoint(rect:  (0 + ((0 + 0) + 16) << 2) + 16 + 20, screenPoint:  new UnityEngine.Vector2() {x = mousePos.x, y = mousePos.y}, cam:  0);
        if(val_2 == true)
        {
                return 0;
        }
        
        val_3 = 1;
        label_1:
        if(val_3 < val_2)
        {
            goto label_11;
        }
        
        return 0;
    }
    public bool IsInRectofTile(int index, UnityEngine.Vector2 mousePos)
    {
        if(true <= index)
        {
                var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = val_3 + (index << 2);
        if(val_3 <= ((0 + (index) << 2) + 16))
        {
                var val_4 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4 = val_4 + (((0 + (index) << 2) + 16) << 2);
        UnityEngine.Camera val_1 = UnityEngine.Camera.main;
        return (bool)UnityEngine.RectTransformUtility.RectangleContainsScreenPoint(rect:  (0 + ((0 + (index) << 2) + 16) << 2) + 16 + 20, screenPoint:  new UnityEngine.Vector2() {x = mousePos.x, y = mousePos.y}, cam:  0);
    }
    public void Shuffle()
    {
        var val_7;
        bool val_1 = WGFTUXManager.IsShowing;
        if(val_1 == false)
        {
                val_1 = this.isShuffling;
            goto label_1;
        }
        
        return;
        label_1:
        this.isShuffling = true;
        this.GetShuffeWord();
        this.MoveLettersToCenter();
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayButtonSound(type:  0, pitch:  null, vol:  null);
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  10, oneshot:  true, pitch:  null, vol:  null);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                return;
        }
        
        MainController val_6 = MainController.instance;
        if(0 != 0)
        {
                val_7 = 33446072;
        }
        else
        {
                val_7 = 33446072;
        }
        
        0.ShufflesUsed = 33446073;
    }
    private void MoveLettersToCenter()
    {
        System.Collections.Generic.List<System.Int32> val_17;
        var val_18;
        val_17 = this.indexes;
        if(this.letterTexts != true)
        {
            goto label_3;
        }
        
        val_18 = 4;
        goto label_4;
        label_16:
        if(1039516303 <= val_17)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.GameObject val_2 = 2621443.gameObject;
        UnityEngine.Transform val_3 = 2621443.transform;
        float val_5 = UnityEngine.Random.Range(min:  UnityEngine.Random.Range(min:  UnityEngine.Random.Range(min:  null, max:  null), max:  null), max:  null);
        UnityEngine.Vector3 val_6 = new UnityEngine.Vector3(x:  val_5, y:  null, z:  null);
        var val_17 = 2621443;
        DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  2621443, endValue:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, duration:  val_5, snapping:  true);
        object val_8 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  2621443, ease:  5);
        val_17 = val_17 - 1;
        if(val_17 == val_17)
        {
                DG.Tweening.TweenCallback val_9 = new DG.Tweening.TweenCallback(object:  -2073875776, method:  new IntPtr(2221058304));
            object val_10 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  2621443, action:  190734336);
        }
        
        if(val_17 <= val_17)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.GameObject val_11 = 2621443.gameObject;
        UnityEngine.Transform val_12 = 2621443.transform;
        UnityEngine.Vector3 val_14 = new UnityEngine.Vector3(x:  (float)UnityEngine.Random.Range(min:  -720, max:  720), y:  null, z:  null);
        DG.Tweening.Tweener val_15 = DG.Tweening.ShortcutExtensions.DORotate(target:  2621443, endValue:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, duration:  (float)UnityEngine.Random.Range(min:  -720, max:  720), mode:  1039516303);
        object val_16 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  2621443, ease:  5);
        val_18 = val_18 + 1;
        label_4:
        val_17 = val_18 - 4;
        if(val_17 < 2621443)
        {
            goto label_16;
        }
        
        return;
        label_3:
        this.isShuffling = false;
    }
    private void MoveLettersToPositions()
    {
        System.Collections.Generic.List<System.Int32> val_17;
        var val_18;
        val_17 = this.indexes;
        if(this.letterTexts != true)
        {
            goto label_3;
        }
        
        val_18 = 4;
        goto label_4;
        label_19:
        float val_2 = UnityEngine.Random.Range(min:  UnityEngine.Random.Range(min:  null, max:  null), max:  null);
        if(0 <= this.letterTexts)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.GameObject val_3 = 2621443.gameObject;
        UnityEngine.Transform val_4 = 2621443.transform;
        System.Collections.Generic.List<LetterTile> val_19 = this.letterTexts;
        uint val_18 = 1039516303;
        int val_5 = this.indexes.IndexOf(item:  val_19);
        val_18 = val_18 + 0;
        if(val_5 <= val_5)
        {
                var val_20 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_19 = val_5 + (val_5 << 1);
        val_20 = val_20 + (val_19 << 2);
        var val_6 = val_20 + 16;
        var val_21 = 2621443;
        DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  2621443, endValue:  new UnityEngine.Vector3() {x = mem[((0 + ((val_5 + (val_5) << 1)) << 2) + 16) + (0)], y = mem[((0 + ((val_5 + (val_5) << 1)) << 2) + 16) + (4)], z = mem[((0 + ((val_5 + (val_5) << 1)) << 2) + 16) + (8)]}, duration:  val_2, snapping:  val_18);
        object val_8 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  2621443, ease:  6);
        val_21 = val_21 - 1;
        if(this.letterTexts == val_21)
        {
                DG.Tweening.TweenCallback val_9 = new DG.Tweening.TweenCallback(object:  -2073705408, method:  new IntPtr(2221228672));
            object val_10 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  2621443, action:  190734336);
        }
        
        if(val_21 <= this.letterTexts)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.GameObject val_11 = 2621443.gameObject;
        UnityEngine.Transform val_12 = 2621443.transform;
        float val_13 = UnityEngine.Random.Range(min:  val_2, max:  null);
        UnityEngine.Vector3 val_14 = new UnityEngine.Vector3(x:  val_13, y:  null, z:  null);
        DG.Tweening.Tweener val_15 = DG.Tweening.ShortcutExtensions.DORotate(target:  2621443, endValue:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, duration:  val_13, mode:  val_18);
        object val_16 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  2621443, ease:  6);
        val_18 = val_18 + 1;
        label_4:
        val_17 = this.letterTexts;
        if((val_18 - 4) < 2621443)
        {
            goto label_19;
        }
        
        return;
        label_3:
        this.isShuffling = false;
    }
    private void ShuffleComplete()
    {
        this.isShuffling = false;
    }
    private void OnLevelComplete()
    {
        var val_1 = 0;
        goto label_1;
        label_7:
        if(true <= val_1)
        {
                var val_1 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_1 = val_1 + 0;
        val_1 = 1;
        label_1:
        if(val_1 < ((0 + 0) + 16 + 12))
        {
            goto label_7;
        }
    
    }
    public void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
    {
        this.didDrag = true;
        LineDrawer.instance.BeginDrag();
    }
    public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
    {
        LineDrawer.instance.DoDrag(mousePos:  new UnityEngine.Vector2() {x = eventData.<position>k__BackingField, y = eventData});
    }
    public void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
    {
        this.didDrag = false;
        LineDrawer.instance.EndDrag(checkAnswer:  true);
    }
    public void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
    {
        LineDrawer.instance.DoPointerDown(mousePos:  new UnityEngine.Vector2() {x = eventData.<position>k__BackingField, y = eventData});
    }
    public void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
    {
        if(this.didDrag != false)
        {
                this.wrongClickCount = 0;
        }
        else
        {
                this.WrongClickCounter = this.wrongClickCount + 1;
        }
        
        LineDrawer.instance.EndDrag(checkAnswer:  true);
    }
    public void OnWordFound()
    {
        System.Collections.IEnumerator val_1 = this.EnableLetters(tileStrings:  this.tileStrings, indexes:  this.indexes);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -2072711104);
    }
    public Pan()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.tileStrings = null;
        this.letterPositions = new System.Collections.Generic.List<UnityEngine.Vector3>();
        this.letterLocalPositions = new System.Collections.Generic.List<UnityEngine.Vector3>();
        System.Collections.Generic.List<System.Int32> val_4 = new System.Collections.Generic.List<System.Int32>();
        this.indexes = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_5 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.letterTexts = null;
    }

}
