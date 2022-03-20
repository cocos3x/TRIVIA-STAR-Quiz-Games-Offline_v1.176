using UnityEngine;
public class LineWord : MonoBehaviour
{
    // Fields
    public string answer;
    public float cellSize;
    public System.Collections.Generic.List<Cell> cells;
    public int numLetters;
    public float lineWidth;
    public bool isShown;
    public bool isStarred;
    
    // Properties
    public int numLettersFound { get; }
    public int numLettersRemaining { get; }
    private int _numLettersFound { get; }
    
    // Methods
    public int get_numLettersFound()
    {
        if(this.isShown == true)
        {
                this = this.numLetters;
            return this;
        }
        
        return this._numLettersFound;
    }
    public int get_numLettersRemaining()
    {
        if(this.isShown == true)
        {
                return (int)0;
        }
        
        0 = this.numLetters - this._numLettersFound;
        return (int)0;
    }
    public void MakeVisible(bool visible)
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
        (0 + 0) + 16 + 68.alpha = 0f;
        val_1 = 1;
        label_1:
        if(val_1 < ((0 + 0) + 16 + 68))
        {
            goto label_7;
        }
    
    }
    public void Build(Cell cellType, bool clickable = True)
    {
        UnityEngine.Sprite val_21;
        float val_22;
        this.numLetters = this.answer.m_stringLength;
        float val_21 = this.cellSize;
        GameBehavior val_1 = App.getBehavior;
        if(this.numLetters < 1)
        {
                return;
        }
        
        val_21 = val_21 * 0;
        var val_24 = 0;
        do
        {
            object val_2 = null;
            val_21 = val_2;
            val_2 = new System.Object();
            typeof(LineWord.<>c__DisplayClass12_0).__il2cppRuntimeField_C = this;
            object val_3 = UnityEngine.Object.Instantiate<System.Object>(original:  cellType);
            typeof(LineWord.<>c__DisplayClass12_0).__il2cppRuntimeField_8 = cellType;
            string val_5 = this.answer.Chars[0].ToString();
            mem2[0] = ;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
            float val_22 = this.cellSize;
            val_22 = val_22 / 80f;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -1.498698E-36f}, d:  val_22);
            typeof(LineWord.<>c__DisplayClass12_0).__il2cppRuntimeField_8.SetScale(newScale:  new UnityEngine.Vector3());
            object val_8 = typeof(LineWord.<>c__DisplayClass12_0).__il2cppRuntimeField_8.GetComponent<System.Object>();
            UnityEngine.Transform val_9 = this.transform;
            typeof(LineWord.<>c__DisplayClass12_0).__il2cppRuntimeField_8.SetParent(p:  -2080428896);
            UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_7.x, y:  val_7.y);
            val_22 = val_10.y;
            typeof(LineWord.<>c__DisplayClass12_0).__il2cppRuntimeField_8.sizeDelta = new UnityEngine.Vector2() {x = val_10.x, y = val_22};
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.one;
            typeof(LineWord.<>c__DisplayClass12_0).__il2cppRuntimeField_8.localScale = new UnityEngine.Vector3();
            float val_23 = this.cellSize;
            float val_13 = val_21 + val_23;
            val_23 = val_23 * 0.5f;
            UnityEngine.Vector3 val_14 = new UnityEngine.Vector3(x:  val_23, y:  val_12.y);
            typeof(LineWord.<>c__DisplayClass12_0).__il2cppRuntimeField_8.localPosition = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
            this.cells.Add(item:  typeof(LineWord.<>c__DisplayClass12_0).__il2cppRuntimeField_8);
            if(clickable != false)
        {
                UnityEngine.GameObject val_15 = typeof(LineWord.<>c__DisplayClass12_0).__il2cppRuntimeField_8.gameObject;
            UnityEngine.UI.LayoutElement val_16 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  typeof(LineWord.<>c__DisplayClass12_0).__il2cppRuntimeField_8);
            UnityEngine.Events.UnityAction val_17 = new UnityEngine.Events.UnityAction(object:  279552000, method:  new IntPtr(2214512352));
            cellType + 172.AddListener(call:  162246656);
            twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-2080453920) != 0)
        {
                typeof(LineWord.<>c__DisplayClass12_0).__il2cppRuntimeField_8.transition = 2;
            val_21 = mem[cellType + 132];
            val_21 = cellType + 132;
            twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            typeof(LineWord.<>c__DisplayClass12_0).__il2cppRuntimeField_8.spriteState = new UnityEngine.UI.SpriteState() {m_HighlightedSprite = cellType + 128, m_PressedSprite = val_21, m_SelectedSprite = cellType + 136, m_DisabledSprite = public static HintPickerController MonoSingleton<HintPickerController>::get_Instance().__il2cppRuntimeField_20};
        }
        
        }
        
            val_24 = val_24 + 1;
        }
        while(val_24 < this.numLetters);
    
    }
    public void ReBuild()
    {
        float val_13;
        this.numLetters = this.answer.m_stringLength;
        float val_13 = this.cellSize;
        GameBehavior val_1 = App.getBehavior;
        if(this.numLetters < 1)
        {
                return;
        }
        
        val_13 = val_13 * 0;
        var val_17 = 0;
        do
        {
            if(0 <= val_17)
        {
                var val_14 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_14 = val_14 + 0;
            string val_3 = this.answer.Chars[0].ToString();
            mem2[0] = ;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            float val_15 = this.cellSize;
            val_15 = val_15 / 80f;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -1.517994E-36f}, d:  val_15);
            (0 + 0) + 16.SetScale(newScale:  new UnityEngine.Vector3());
            object val_6 = (0 + 0) + 16.GetComponent<System.Object>();
            UnityEngine.Transform val_7 = this.transform;
            (0 + 0) + 16.SetParent(p:  -2080288224);
            UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_5.x, y:  val_5.y);
            if(((0 + 0) + 16) != 0)
        {
                val_13 = val_8.y;
            (0 + 0) + 16.sizeDelta = new UnityEngine.Vector2() {x = val_8.x, y = val_13};
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
        }
        else
        {
                val_13 = val_8.y;
            (0 + 0) + 16.sizeDelta = new UnityEngine.Vector2() {x = val_8.x, y = val_13};
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
        }
        
            (0 + 0) + 16.localScale = new UnityEngine.Vector3();
            float val_16 = this.cellSize;
            UnityEngine.Vector3 val_12;
            float val_11 = val_13 + val_16;
            val_16 = val_16 * 0.5f;
            val_12 = new UnityEngine.Vector3(x:  val_16, y:  val_10.y);
            (0 + 0) + 16.localPosition = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            val_17 = val_17 + 1;
        }
        while(val_17 < this.numLetters);
    
    }
    public void SetLineWidth()
    {
        object val_1 = this.GetComponent<System.Object>();
        GameBehavior val_2 = App.getBehavior;
        float val_5 = (float)this.answer.m_stringLength - 1;
        val_5 = this.cellSize * val_5;
        val_5 = val_5 * 0;
        this.lineWidth = val_5;
        UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_5, y:  null);
        this.sizeDelta = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
    }
    public void SetProgress(string progress)
    {
        var val_2;
        System.Collections.Generic.List<Cell> val_6;
        var val_7;
        val_6 = this.cells;
        if(progress.m_stringLength != )
        {
            goto label_3;
        }
        
        this.isShown = true;
        List.Enumerator<T> val_1 = GetEnumerator();
        val_7 = 0;
        val_6 = 1152921511116727136;
        goto label_5;
        label_10:
        if(progress.Chars[0] == '1')
        {
                val_2.SetAndShowText();
        }
        else
        {
                this.isShown = false;
        }
        
        val_7 = 1;
        label_5:
        if(MoveNext() == true)
        {
            goto label_10;
        }
        
        Dispose();
        return;
        label_3:
        string val_5 = -2080052384(-2080052384) + this.answer;
        UnityEngine.Debug.LogError(message:  -2080052384);
    }
    private int get__numLettersFound()
    {
        var val_4;
        List.Enumerator<T> val_1 = GetEnumerator();
        val_4 = 0;
        goto label_2;
        label_4:
        val_4 = val_4 + (val_2 + 36);
        label_2:
        if(MoveNext() == true)
        {
            goto label_4;
        }
        
        Dispose();
        return (int)val_4;
    }
    public void SetStarred()
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
        if(((0 + 0) + 16 + 36) == 0)
        {
                (0 + 0) + 16.ShowStarred();
        }
        
        val_1 = 1;
        label_1:
        if(val_1 < ((0 + 0) + 16))
        {
            goto label_7;
        }
        
        this.isStarred = true;
    }
    public void SetAnswer()
    {
        var val_3;
        this.isShown = true;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_4:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        val_3.SetAndShowText();
        goto label_4;
        label_2:
        Dispose();
    }
    public void ShowAnswer(float waitTime = 0)
    {
        this.isShown = true;
        List.Enumerator<T> val_1 = GetEnumerator();
        goto label_2;
        label_4:
        mem2[0] = true;
        label_2:
        if(MoveNext() == true)
        {
            goto label_4;
        }
        
        Dispose();
        System.Collections.IEnumerator val_4 = this.IEShowAnswer(waitBeforePlaying:  waitTime);
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  -2079522864);
    }
    public System.Collections.IEnumerator IEShowAnswer(float waitBeforePlaying)
    {
        typeof(LineWord.<IEShowAnswer>d__21).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(LineWord.<IEShowAnswer>d__21).__il2cppRuntimeField_14 = this;
        }
        else
        {
                mem[20] = this;
        }
        
        typeof(LineWord.<IEShowAnswer>d__21).__il2cppRuntimeField_10 = R1;
    }
    public Cell ShowHintGetCell(Cell cell)
    {
        UnityEngine.Object val_2;
        var val_3;
        val_2 = cell;
        val_3 = 0;
        bool val_1 = UnityEngine.Object.op_Inequality(x:  val_2, y:  0);
        if(val_1 == false)
        {
            goto label_11;
        }
        
        if(val_2 != 0)
        {
            goto label_5;
        }
        
        goto label_5;
        label_11:
        if(val_3 >= val_1)
        {
            goto label_7;
        }
        
        if(val_1 <= val_3)
        {
                var val_2 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_2 = val_2 + 0;
        val_2 = mem[(0 + 0) + 16];
        val_2 = (0 + 0) + 16;
        val_3 = val_3 + 1;
        if(((0 + 0) + 16 + 36) != 0)
        {
            goto label_11;
        }
        
        label_5:
        val_2.ShowHint();
        this.CheckShown();
        return;
        label_7:
        this.CheckShown();
        val_2 = 0;
    }
    public UnityEngine.Vector3 ShowHint(Cell cell)
    {
        Cell val_1 = cell.ShowHintGetCell(cell:  R2);
        if(cell == 0)
        {
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            return new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        
        UnityEngine.Transform val_4 = cell.transform;
        UnityEngine.Vector3 val_5 = this.position;
        return new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
    }
    public int GetHintCellIndex(Cell cell)
    {
        var val_3;
        var val_4;
        val_3 = 0;
        if(cell == 0)
        {
            goto label_3;
        }
        
        if(this.cells != 0)
        {
                return this.cells.IndexOf(item:  cell);
        }
        
        return this.cells.IndexOf(item:  cell);
        label_10:
        if((R4 + 20 + 12) <= R5)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_2 = R4 + 20 + 8;
        val_2 = val_2 + ((R5) << 2);
        val_4 = mem[(R4 + 20 + 8 + (R5) << 2) + 16];
        val_4 = (R4 + 20 + 8 + (R5) << 2) + 16;
        if(((R4 + 20 + 8 + (R5) << 2) + 16 + 36) == 0)
        {
                return 0;
        }
        
        val_3 = R5 + 1;
        label_3:
        val_4 = mem[R4 + 20];
        val_4 = R4 + 20;
        if(val_3 < (R4 + 20 + 12))
        {
            goto label_10;
        }
        
        return 0;
    }
    public void CheckShown()
    {
        List.Enumerator<T> val_1 = GetEnumerator();
        label_4:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        if((val_3 + 36) != 0)
        {
            goto label_4;
        }
        
        Dispose();
        return;
        label_2:
        Dispose();
        this.isShown = true;
    }
    public void ShowExists()
    {
        goto label_1;
        label_10:
        if(true <= 35632317)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        2621443.ShowExists();
        4 = 5;
        label_1:
        if((4 - 4) < 2621443)
        {
            goto label_10;
        }
    
    }
    public void DisplayDefiniton()
    {
        if(this.isShown == false)
        {
                return;
        }
        
        Player val_1 = App.Player;
        if(0 < 3)
        {
                return;
        }
        
        MainController val_2 = MainController.instance;
        if(3 != 0)
        {
                return;
        }
        
        WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        displayDefinition(word:  R4 + 12, flyout:  false);
    }
    public System.Collections.Generic.List<Cell> HiddenCells()
    {
        twelvegigs.sweepstakes.Distribution val_4;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        List.Enumerator<T> val_2 = GetEnumerator();
        label_6:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        if((val_4 + 36) != 0)
        {
            goto label_6;
        }
        
        Add(item:  val_4);
        goto label_6;
        label_2:
        Dispose();
    }
    public int HiddenCellsCount()
    {
        var val_4;
        List.Enumerator<T> val_1 = GetEnumerator();
        val_4 = 0;
        goto label_2;
        label_4:
        var val_4 = val_2 + 36;
        val_4 = val_4 ^ 1;
        val_4 = val_4 + val_4;
        label_2:
        if(MoveNext() == true)
        {
            goto label_4;
        }
        
        Dispose();
        return (int)val_4;
    }
    public LineWord()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.cells = null;
    }

}
