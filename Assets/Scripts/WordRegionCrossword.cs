using UnityEngine;
public class WordRegionCrossword : WordRegion
{
    // Fields
    private const float CELL_SIZE = 80;
    private UnityEngine.UI.GridLayoutGroup grid;
    public int width;
    public int height;
    public UnityEngine.GameObject emptyCellPrefab;
    
    // Methods
    protected override void Awake()
    {
        this.Awake();
        object val_1 = this.GetComponent<System.Object>();
        this.grid = this;
    }
    protected override void ApplyHintToLine(LineWord line, Cell cell)
    {
        UnityEngine.Object val_3;
        line.CheckShown();
        List.Enumerator<T> val_1 = GetEnumerator();
        label_11:
        if(MoveNext() == false)
        {
            goto label_3;
        }
        
        if((val_3 == line) || ((val_3 + 20.Contains(item:  cell)) == false))
        {
            goto label_11;
        }
        
        val_3.CheckShown();
        if((val_3 + 32) == 0)
        {
            goto label_11;
        }
        
        this.ApplyHintToLine(line:  val_3, cell:  cell);
        goto label_11;
        label_3:
        Dispose();
        this.ApplyHintToLine(line:  line, cell:  cell);
    }
    public override void Load(GameLevel gameLevel, System.Action loadCompleteCallback)
    {
        var val_4;
        mem[1152921511144277084] = gameLevel;
        System.Delegate val_1 = System.Delegate.Combine(a:  1, b:  loadCompleteCallback);
        if(true != 0)
        {
                if(21384261 == null)
        {
            goto label_2;
        }
        
        }
        
        val_4 = 0;
        label_2:
        mem[1152921511144277140] = val_4;
        System.Collections.IEnumerator val_2 = this.LoadCoroutine();
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  -2052504560);
    }
    private System.Collections.IEnumerator LoadCoroutine()
    {
        object val_1 = new System.Object();
        typeof(WordRegionCrossword.<LoadCoroutine>d__8).__il2cppRuntimeField_8 = 0;
        typeof(WordRegionCrossword.<LoadCoroutine>d__8).__il2cppRuntimeField_10 = this;
    }
    private void NotifyLevelLoaded(GameLevel level)
    {
        if(true == 0)
        {
                return;
        }
        
        true.Invoke(obj:  level);
    }
    private System.Collections.IEnumerator LevelLoadCompleteActionCoroutine()
    {
        object val_1 = new System.Object();
        typeof(WordRegionCrossword.<LevelLoadCompleteActionCoroutine>d__10).__il2cppRuntimeField_8 = 0;
        typeof(WordRegionCrossword.<LevelLoadCompleteActionCoroutine>d__10).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator ScaleToFitLate()
    {
        object val_1 = new System.Object();
        typeof(WordRegionCrossword.<ScaleToFitLate>d__11).__il2cppRuntimeField_8 = 0;
        typeof(WordRegionCrossword.<ScaleToFitLate>d__11).__il2cppRuntimeField_10 = this;
    }
    private void OnRectTransformDimensionsChange()
    {
        goto typeof(WordRegionCrossword).__il2cppRuntimeField_DC;
    }
    protected override void ScaleToFit()
    {
        var val_12;
        var val_14;
        var val_15;
        UnityEngine.Rect val_1 = rect;
        float val_2 = height;
        val_14 = null;
        val_14 = null;
        float val_12 = System.Math.Abs(S18 - 2243139056);
        mem[1152921511144965408] = 2243139056;
        UnityEngine.Rect val_4 = rect;
        float val_5 = width;
        UnityEngine.Rect val_6 = rect;
        float val_7 = height;
        float val_14 = 80f;
        float val_13 = (float)this.width;
        val_12 = 0;
        val_13 = val_13 * val_14;
        val_14 = (float)this.height * val_14;
        val_13 = 2243139056 / val_13;
        val_14 = 2243139056 / val_14;
        float val_8 = UnityEngine.Mathf.Min(a:  val_13, b:  val_6.m_YMin);
        mem[1152921511144965548] = val_13;
        UnityEngine.Transform val_9 = this.transform;
        val_15 = this;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -1.68881E-35f}, d:  val_10.x);
        if(val_15 == 0)
        {
            goto label_11;
        }
        
        if(null == null)
        {
            goto label_13;
        }
        
        goto label_14;
        label_11:
        label_14:
        val_15 = 0;
        label_13:
        val_15.localScale = new UnityEngine.Vector3();
    }
    public WordRegionCrossword()
    {
        this.width = 1;
        this.height = 1;
    }

}
