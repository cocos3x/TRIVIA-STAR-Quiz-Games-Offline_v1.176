using UnityEngine;
public class WordRegionBase : MonoBehaviour
{
    // Fields
    protected UnityEngine.RectTransform safeAreaWithinParent;
    protected float previousSafeHeight;
    private bool <isMovingObjectCollected>k__BackingField;
    protected System.Collections.Generic.List<LineWord> lines;
    protected int numWords;
    protected int numCol;
    protected int numRow;
    protected int maxCellInWidth;
    protected float cellSize;
    protected float startFirstColX;
    protected bool hasLongLine;
    
    // Properties
    public bool isMovingObjectCollected { get; set; }
    public UnityEngine.Rect getSafeAreaRect { get; }
    public System.Collections.Generic.List<LineWord> getLines { get; }
    public System.Collections.Generic.List<int> getAvailableLineIndices { get; }
    protected System.Collections.Generic.List<int> getUnavailableLineIndices { get; }
    public System.Collections.Generic.List<LineWord> getAvailableLineWords { get; }
    
    // Methods
    public bool get_isMovingObjectCollected()
    {
        return (bool)this.<isMovingObjectCollected>k__BackingField;
    }
    public void set_isMovingObjectCollected(bool value)
    {
        this.<isMovingObjectCollected>k__BackingField = value;
    }
    public UnityEngine.Rect get_getSafeAreaRect()
    {
        UnityEngine.Rect val_1 = this.rect;
        return new UnityEngine.Rect() {m_XMin = val_1.m_XMin, m_YMin = val_1.m_YMin, m_Width = val_1.m_Width, m_Height = val_1.m_Height};
    }
    public System.Collections.Generic.List<LineWord> get_getLines()
    {
    
    }
    public System.Collections.Generic.List<int> get_getAvailableLineIndices()
    {
        var val_4;
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        val_4 = 0;
        goto label_1;
        label_4:
        Add(item:  0);
        val_4 = 1;
        label_1:
        if(val_4 < null)
        {
            goto label_4;
        }
        
        System.Collections.Generic.List<System.Int32> val_2 = getUnavailableLineIndices;
        System.Collections.Generic.IEnumerable<TSource> val_3 = System.Linq.Enumerable.Except<System.Int32>(first:  80883712, second:  80883712);
        return System.Linq.Enumerable.ToList<System.Int32>(source:  80883712);
    }
    protected System.Collections.Generic.List<int> get_getUnavailableLineIndices()
    {
        var val_24;
        System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
        if(Alphabet2Manager.IsAvailable != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(canAddGameplayTile != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_6 = GetCurrentCollectionLetter;
            if((System.String.IsNullOrEmpty(value:  -2100700048)) != true)
        {
                twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Add(item:  GetAbWordIndex);
        }
        
        }
        
        }
        
        var val_24 = 29249287;
        val_24 = 6376500 + val_24;
        if(val_24 == 0)
        {
                mem2[0] = 1;
        }
        
        val_24 = null;
        val_24 = null;
        if(App.game == 18)
        {
                twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(WordForest.WFOMysteryChestManager.IsFeatureUnlocked != false)
        {
                if((-814084048) != 0)
        {
                System.Collections.Generic.List<System.Int32> val_13 = GetChestsWordIndexes();
            AddRange(collection:  -814084048);
        }
        
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  -2101040096)) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<System.Int32> val_17 = GetMovingItemsIndices();
            AddRange(collection:  -2101040096);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  -2100701168)) == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(IsPlaying == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Add(item:  public static WGChallengeWordsManager MonoSingleton<WGChallengeWordsManager>::get_Instance().__il2cppRuntimeField_C.WordIndex);
    }
    public System.Collections.Generic.List<LineWord> get_getAvailableLineWords()
    {
        var val_3;
        System.Collections.Generic.List<System.Int32> val_1 = this.getAvailableLineIndices;
        val_3 = 0;
        goto label_1;
        label_7:
        if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) <= val_3)
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
        Add(item:  (0 + ((0 + 0) + 16) << 2) + 16);
        val_3 = 1;
        label_1:
        if(val_3 < this.safeAreaWithinParent)
        {
            goto label_7;
        }
    
    }
    protected void RecalculateCellSize()
    {
        int val_19;
        var val_20;
        UnityEngine.Rect val_1 = rect;
        if(this.numCol < 2)
        {
                float val_2 = height;
            GameBehavior val_3 = App.getBehavior;
            int val_4 = this.numRow - 1;
            float val_19 = 0.8f;
            val_19 = (float)this.numRow + val_19;
            val_19 = 3613143976 / val_19;
            this.cellSize = val_19;
            float val_5 = width;
            val_19 = this.maxCellInWidth;
            GameBehavior val_6 = App.getBehavior;
            val_20 = 0;
            int val_7 = val_19 - 1;
            if(false < 0)
        {
                false = true;
            this.cellSize = 3613143976 / (float)val_19;
            this.hasLongLine = false;
        }
        
            return;
        }
        
        GameBehavior val_9 = App.getBehavior;
        int val_10 = this.maxCellInWidth - this.numCol;
        int val_11 = this.numCol - 1;
        float val_12 = width;
        uint val_20 = 3613143976;
        val_20 = val_20 / (float)this.maxCellInWidth;
        this.cellSize = val_20;
        float val_13 = height;
        val_19 = this.numRow;
        GameBehavior val_14 = App.getBehavior;
        val_20 = 0;
        int val_15 = val_19 + 1;
        if(0 >= 0)
        {
                return;
        }
        
        this.cellSize = 3613143976 / (float)val_19;
        float val_17 = width;
        this.startFirstColX = 3613143976 * 0.5f;
    }
    protected System.Collections.IEnumerator ScaleToPositionAndFitLate()
    {
        object val_1 = new System.Object();
        typeof(WordRegionBase.<ScaleToPositionAndFitLate>d__25).__il2cppRuntimeField_8 = 0;
        typeof(WordRegionBase.<ScaleToPositionAndFitLate>d__25).__il2cppRuntimeField_10 = this;
    }
    protected virtual void ScaleToFit()
    {
        UnityEngine.RectTransform val_5;
        var val_6;
        var val_7;
        val_5 = this.safeAreaWithinParent;
        if(val_5 == 0)
        {
                return;
        }
        
        val_5 = this.safeAreaWithinParent;
        UnityEngine.Rect val_2 = rect;
        float val_3 = height;
        val_7 = null;
        val_7 = null;
        float val_5 = System.Math.Abs(this.previousSafeHeight - 3613396640);
        this.previousSafeHeight = 3613396640;
        this.RecalculateCellSize();
        val_5 = 4;
        goto label_8;
        label_19:
        if(this <= )
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(0 <= )
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        2621443.SetLineWidth();
        if(2621443 <= )
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        2621443.ReBuild();
        val_5 = 5;
        label_8:
        val_6 = val_5 - 4;
        if(val_6 < 2621443)
        {
            goto label_19;
        }
    
    }
    protected virtual void SetLinesPosition()
    {
        float val_16;
        WordRegionBase val_29;
        var val_30;
        var val_31;
        float val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        val_29 = this;
        val_30 = 0;
        UnityEngine.Rect val_1 = rect;
        float val_2 = width;
        float val_3 = height;
        uint val_30 = 3613541400;
        float val_4 = 3613541400 * (-0.5f);
        val_30 = val_30 * (-0.5f);
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_30, y:  val_1.m_YMin);
        if(this.numCol > 1)
        {
            goto label_2;
        }
        
        val_32 = 0;
        val_33 = 4;
        goto label_3;
        label_20:
        float val_6 = width;
        val_29 = val_29;
        if((mem[1152921512515367752] + 12) <= (-681425896))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(mem[1152921512515367780] != false)
        {
                float val_7 = height;
            val_34 = mem[1152921512515367764];
            val_35 = mem[1152921512515367772] + (3613541400 / ((float)val_34 + 1));
        }
        else
        {
                GameBehavior val_10 = App.getBehavior;
            val_34 = mem[1152921512515367764];
            float val_11 = mem[1152921512515367772] * 0.4f;
        }
        
        uint val_31 = 3613541400;
        val_31 = val_31 * 0.5f;
        if((mem[1152921512515367752] + 12) <= (-681425896))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Transform val_13 = mem[1152921512515367752] + 8 + 16.transform;
        val_31 = mem[1152921512515367752] + 8 + 16;
        UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  val_34 + val_32, y:  val_1.m_YMin);
        UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = -2.487814E+14f, y = val_14.x}, b:  new UnityEngine.Vector2() {x = val_14.y, y = val_5.x});
        UnityEngine.Vector3 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = -2.487817E+14f, y = val_16});
        val_31.localPosition = new UnityEngine.Vector3();
        val_33 = 5;
        val_32 = -1;
        label_3:
        val_36 = mem[1152921512515367752];
        if((val_33 - 4) < (mem[1152921512515367752] + 12))
        {
            goto label_20;
        }
        
        return;
        label_2:
        val_30 = null;
        typeof(System.Single[]).__il2cppRuntimeField_10 = this.startFirstColX;
        if(this.numCol >= 2)
        {
                var val_34 = 1;
            do
        {
            var val_20 = val_34 - 1;
            float val_33 = typeof(System.Single[]).__il2cppRuntimeField_10;
            val_31 = (this.numRow * val_34) - 1;
            if(0 <= val_31)
        {
                var val_32 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_32 = val_32 + (val_31 << 2);
            val_33 = val_33 + ((0 + (((this.numRow * 1) - 1)) << 2) + 16 + 28);
            System.Single[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_4 = val_33;
            val_34 = val_34 + 1;
        }
        while(val_34 < this.numCol);
        
        }
        
        val_36 = 0;
        val_29 = 0;
        goto label_31;
        label_40:
        float val_23 = height;
        int val_24 = this.numRow + 1;
        float val_25 = 3613541400 / (float)val_24;
        val_25 = val_25 * (float)this.numRow;
        if(val_24 <= val_29)
        {
                var val_35 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_35 = val_35 - 0;
        UnityEngine.Transform val_26 = (0 - 0) + 16.transform;
        val_31 = 0;
        UnityEngine.Vector2 val_27 = new UnityEngine.Vector2(x:  this.numRow - 1, y:  val_1.m_YMin);
        val_32 = val_5.x;
        UnityEngine.Vector2 val_28 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = -2.487814E+14f, y = val_27.x}, b:  new UnityEngine.Vector2() {x = val_27.y, y = val_32});
        UnityEngine.Vector3 val_29 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = -2.487817E+14f, y = val_16});
        (0 - 0) + 16.localPosition = new UnityEngine.Vector3();
        val_30 = val_30;
        val_36 = val_36 - 1;
        val_29 = 1;
        label_31:
        if(val_29 < val_29)
        {
            goto label_40;
        }
    
    }
    public WordRegionBase()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.lines = null;
    }

}
