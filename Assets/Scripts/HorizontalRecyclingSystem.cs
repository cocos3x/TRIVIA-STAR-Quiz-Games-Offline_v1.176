using UnityEngine;
public class HorizontalRecyclingSystem : RecyclingSystem
{
    // Fields
    private readonly IRecyclableScrollRectDataSource _dataSource;
    private readonly int _rows;
    private System.Collections.Generic.List<UnityEngine.RectTransform> _cellPool;
    private System.Collections.Generic.List<ICell> _cachedCells;
    private UnityEngine.Bounds _recyclableViewBounds;
    private readonly UnityEngine.Vector3[] _corners;
    private bool _recycling;
    private int currentItemCount;
    private int leftMostCellIndex;
    private int rightMostCellIndex;
    private int _leftMostCellRow;
    private int _RightMostCellRow;
    private UnityEngine.Vector2 zeroVector;
    
    // Methods
    public HorizontalRecyclingSystem(UnityEngine.RectTransform prototypeCell, UnityEngine.RectTransform viewport, UnityEngine.RectTransform content, IRecyclableScrollRectDataSource dataSource, bool isGrid, int rows)
    {
        this._corners = null;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.zeroVector = new UnityEngine.Vector2();
        mem[1152921512544517956] = ???;
        mem[1152921512544517848] = viewport;
        mem[1152921512544517852] = content;
        if(isGrid == false)
        {
                rows = 1;
        }
        
        mem[1152921512544517856] = prototypeCell;
        mem[1152921512544517860] = isGrid;
        this._dataSource = dataSource;
        this._rows = rows;
        mem[1152921512544517920] = 0;
        mem[1152921512544517916] = 0;
    }
    public override System.Collections.IEnumerator InitCoroutine(System.Action onInitialized, int startPos, bool centered = False)
    {
        typeof(HorizontalRecyclingSystem.<InitCoroutine>d__14).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(HorizontalRecyclingSystem.<InitCoroutine>d__14).__il2cppRuntimeField_1C = onInitialized;
            typeof(HorizontalRecyclingSystem.<InitCoroutine>d__14).__il2cppRuntimeField_10 = this;
            typeof(HorizontalRecyclingSystem.<InitCoroutine>d__14).__il2cppRuntimeField_14 = startPos;
        }
        else
        {
                mem[16] = this;
            mem[28] = onInitialized;
            mem[20] = startPos;
        }
        
        typeof(HorizontalRecyclingSystem.<InitCoroutine>d__14).__il2cppRuntimeField_18 = centered;
    }
    private void SetRecyclingBounds()
    {
        R5.GetWorldCorners(fourCornersArray:  this._corners);
        UnityEngine.Vector3 val_7 = this._corners[0];
        val_7 = this._corners[2] - val_7;
        UnityEngine.Vector3 val_1 = S16 * val_7;
        UnityEngine.Vector3 val_9 = this._corners[0];
        UnityEngine.Vector3 val_3 = new UnityEngine.Vector3(x:  this._corners[0] - val_1, y:  null);
        this._recyclableViewBounds.min = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        UnityEngine.Vector3 val_11 = this._corners[2];
        UnityEngine.Vector3 val_5 = new UnityEngine.Vector3(x:  val_1 + this._corners[2], y:  null);
        this._recyclableViewBounds.max = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
    }
    private void CreateCellPool()
    {
        var val_8;
        float val_10;
        var val_28;
        HorizontalRecyclingSystem val_39;
        var val_40;
        System.Action<UnityEngine.RectTransform> val_42;
        var val_43;
        IRecyclableScrollRectDataSource val_44;
        var val_45;
        var val_46;
        HorizontalRecyclingSystem val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_53;
        var val_54;
        var val_55;
        val_39 = this;
        if(this._cellPool != 0)
        {
                val_40 = null;
            val_40 = null;
            val_42 = HorizontalRecyclingSystem.<>c.<>9__16_0;
            if(val_42 == 0)
        {
                val_42 = null;
            val_42 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  HorizontalRecyclingSystem.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3643560336));
            val_39 = val_39;
            HorizontalRecyclingSystem.<>c.<>9__16_0 = val_42;
        }
        
            this._cellPool.ForEach(action:  7401472);
            this._cellPool.Clear();
            mem[1152921512545411032].Clear();
        }
        else
        {
                System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this._cachedCells = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this._cellPool = null;
        }
        
        UnityEngine.GameObject val_4 = gameObject;
        SetActive(value:  true);
        this.SetLeftAnchor(rectTransform:  1);
        UnityEngine.Rect val_5 = rect;
        float val_6 = height;
        float val_39 = (float)this._rows;
        val_39 = 3643584648 / val_39;
        mem[1152921512545411016] = val_39;
        UnityEngine.Vector2 val_7 = sizeDelta;
        var val_45 = val_8;
        UnityEngine.Vector2 val_9 = sizeDelta;
        float val_40 = val_10;
        val_40 = val_45 / val_40;
        val_40 = val_40 * 3643584648;
        mem[1152921512545411012] = val_40;
        UnityEngine.Rect val_11 = rect;
        float val_12 = width;
        var val_41 = 0;
        val_41 = val_41 + 1;
        val_43 = this._dataSource;
        int val_14 = System.Math.Min(val1:  SB, val2:  this._dataSource);
        val_44 = this._dataSource;
        val_45 = mem[1152921512545411068];
        var val_42 = 0;
        val_42 = val_42 + 1;
        val_46 = val_44;
        val_47 = val_39;
        if((val_45 + val_14) > val_44)
        {
                var val_43 = 0;
            val_44 = 0;
            val_43 = val_43 + 1;
            val_44 = (uint)val_43 & 65535;
            val_48 = this._dataSource;
            IRecyclableScrollRectDataSource val_44 = this._dataSource;
            val_47 = val_39;
            val_44 = val_44 - val_14;
            mem[1152921512545411068] = val_44;
        }
        
        val_45 = val_45 * 3643584648;
        if(val_14 <= 0)
        {
            goto label_34;
        }
        
        float val_52 = 0f;
        val_49 = 1152921512545410996;
        val_50 = 0;
        val_45 = 0;
        uint val_50 = 0;
        label_69:
        var val_46 = 0;
        val_46 = val_46 + 1;
        val_51 = this._dataSource;
        val_47 = val_39;
        if(val_45 >= this._dataSource)
        {
            goto label_70;
        }
        
        UnityEngine.GameObject val_19 = mem[1152921512545410992].gameObject;
        object val_20 = UnityEngine.Object.Instantiate<System.Object>(original:  mem[1152921512545410992]);
        object val_21 = mem[1152921512545410992].GetComponent<System.Object>();
        if(mem[1152921512545410992] != 0)
        {
                mem[1152921512545410992].name = -651396720;
            UnityEngine.Vector2 val_22 = new UnityEngine.Vector2(x:  val_12, y:  val_11.m_YMin);
        }
        else
        {
                0.name = -651396720;
            UnityEngine.Vector2 val_23 = new UnityEngine.Vector2(x:  val_12, y:  val_11.m_YMin);
        }
        
        mem[1152921512545410992].sizeDelta = new UnityEngine.Vector2() {x = val_23.x, y = val_23.y};
        Add(item:  mem[1152921512545410992]);
        mem[1152921512545410992].SetParent(parent:  mem[1152921512545410988], worldPositionStays:  false);
        if(mem[1152921512545410992] == 0)
        {
            goto label_49;
        }
        
        var val_47 = mem[1152921512545411084];
        val_47 = 0 - val_47;
        UnityEngine.Vector2 val_24;
        float val_48 = (float)val_47;
        val_48 = mem[1152921512545411016] * val_48;
        val_24 = new UnityEngine.Vector2(x:  val_48, y:  val_11.m_YMin);
        mem[1152921512545410992].anchoredPosition = new UnityEngine.Vector2() {x = val_24.x, y = val_24.y};
        var val_49 = mem[1152921512545411084];
        val_49 = val_49 + 1;
        mem[1152921512545411084] = val_49;
        if(val_49 < this._rows)
        {
            goto label_51;
        }
        
        mem[1152921512545411084] = val_50;
        val_50 = val_50 + mem[1152921512545411012];
        UnityEngine.Rect val_25 = val_24.x.rect;
        goto label_53;
        label_49:
        val_8 = val_50;
        UnityEngine.Vector2 val_26 = new UnityEngine.Vector2(x:  val_12, y:  val_11.m_YMin);
        if(mem[1152921512545410992] != 0)
        {
                mem[1152921512545410992].anchoredPosition = new UnityEngine.Vector2() {x = val_26.x, y = val_26.y};
        }
        else
        {
                mem[1152921512545410992].anchoredPosition = new UnityEngine.Vector2() {x = val_26.x, y = val_26.y};
        }
        
        UnityEngine.Vector2 val_27 = anchoredPosition;
        var val_51 = val_28;
        UnityEngine.Rect val_29 = val_24.x.rect;
        float val_30 = width;
        val_51 = val_51 + 3643584648;
        UnityEngine.Rect val_31 = rect;
        label_53:
        float val_32 = width;
        val_52 = val_52 + 3643584648;
        label_51:
        object val_33 = mem[1152921512545410992].GetComponent<System.Object>();
        Add(item:  mem[1152921512545410992]);
        val_44 = this._cachedCells;
        if(val_44 != 0)
        {
                val_54 = System.Collections.Generic.List<T>.__il2cppRuntimeField_namespaze;
        }
        else
        {
                val_54 = 0;
            val_53 = 0;
        }
        
        if(val_53 <= (-1))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_53 = 0;
        val_44 = 0;
        val_53 = val_53 + 1;
        val_44 = (uint)val_53 & 65535;
        val_55 = this._dataSource;
        val_47 = val_39;
        val_49 = val_49;
        val_50 = 0;
        IRecyclableScrollRectDataSource val_54 = mem[1152921512545411068];
        val_45 = 1;
        val_54 = val_54 + 1;
        mem[1152921512545411068] = val_54;
        if((val_45 < val_14) || (val_45 < 0))
        {
            goto label_69;
        }
        
        goto label_70;
        label_34:
        val_49 = 1152921512545410996;
        label_70:
        if(val_44 != 0)
        {
                var val_55 = mem[1152921512545411084];
            val_55 = val_55 + this._rows;
            val_55 = val_55 - 1;
            mem[1152921512545411084] = this._rows;
        }
        
        UnityEngine.GameObject val_35 = mem[1152921512545410992].gameObject;
        UnityEngine.SceneManagement.Scene val_36 = mem[1152921512545410992].scene;
        if(val_36.m_Handle.IsValid() == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_38 = mem[1152921512545410992].gameObject;
        mem[1152921512545410992].SetActive(value:  false);
    }
    public override UnityEngine.Vector2 OnValueChangedListener(UnityEngine.Vector2 direction)
    {
        if((direction.x + 88) == 0)
        {
                if((direction.x + 52) != 0)
        {
                direction.x + 52 = mem[direction.x + 52 + 12];
            direction.x + 52 = direction.x + 52 + 12;
            goto label_2;
        }
        
        }
        
        label_11:
        this = direction.x + 112;
        mem[1152921512545531172] = direction.x + 116;
        return new UnityEngine.Vector2();
        label_2:
        direction.x.SetRecyclingBounds();
        if((direction.x + 52) < 0)
        {
                if((direction.x + 52 + 12) <= (direction.x + 100))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_10 = direction.x + 52 + 8;
            val_10 = val_10 + ((direction.x + 100) << 2);
            float val_1 = UIExtension.MinX(rectTransform:  (direction.x + 52 + 8 + (direction.x + 100) << 2) + 16);
            float val_2 = direction.x + 60;
            UnityEngine.Vector3 val_3 = max;
            if((direction.x + 52 + 12) < 0)
        {
                UnityEngine.Vector2 val_5 = this.RecycleLeftToRight();
            return new UnityEngine.Vector2();
        }
        
        }
        
        if((direction.x + 52) <= 0)
        {
            goto label_11;
        }
        
        if((direction.x + 52 + 12) <= (direction.x + 96))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_11 = direction.x + 52 + 8;
        val_11 = val_11 + ((direction.x + 96) << 2);
        float val_6 = UIExtension.MaxX(rectTransform:  (direction.x + 52 + 8 + (direction.x + 96) << 2) + 16);
        float val_7 = direction.x + 60;
        UnityEngine.Vector3 val_8 = min;
        if((direction.x + 52 + 12) <= (direction.x + 96))
        {
            goto label_11;
        }
        
        UnityEngine.Vector2 val_9 = this.RecycleRightToleft();
        return new UnityEngine.Vector2();
    }
    private UnityEngine.Vector2 RecycleLeftToRight()
    {
        var val_3;
        var val_8;
        var val_10;
        float val_25;
        float val_26;
        float val_35;
        float val_36;
        float val_42;
        var val_45;
        var val_46;
        var val_47;
        float val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        object val_1 = null;
        val_45 = val_1;
        val_1 = new System.Object();
        if(val_45 != 0)
        {
                typeof(HorizontalRecyclingSystem.<>c__DisplayClass18_0).__il2cppRuntimeField_C = R1;
            mem2[0] = 1;
        }
        else
        {
                mem[12] = R1;
            mem2[0] = 1;
        }
        
        typeof(HorizontalRecyclingSystem.<>c__DisplayClass18_0).__il2cppRuntimeField_8 = 0;
        if((R1 + 20) != 0)
        {
                if((R1 + 52 + 12) <= (R1 + 100))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_46 = R1 + 52 + 8;
            val_46 = val_46 + ((R1 + 100) << 2);
            UnityEngine.Vector2 val_2 = anchoredPosition;
        }
        
        var val_4 = R1 + 60;
        goto label_47;
        label_52:
        val_46 = mem[R1 + 92];
        val_46 = R1 + 92;
        var val_48 = R1 + 44;
        if((R1 + 44 + 178) == 0)
        {
            goto label_10;
        }
        
        var val_47 = 0;
        label_12:
        if((R1 + 44 + 88 + 0) == null)
        {
            goto label_11;
        }
        
        val_47 = val_47 + 1;
        if(((uint)val_47 & 65535) < (R1 + 44 + 178))
        {
            goto label_12;
        }
        
        label_10:
        val_47 = R1 + 44;
        goto label_13;
        label_11:
        var val_5 = (R1 + 44 + 88) + 0;
        val_48 = val_48 + (((R1 + 44 + 88 + 0) + 4) << 3);
        val_47 = val_48 + 188;
        label_13:
        if(val_46 >= (R1 + 44))
        {
            goto label_14;
        }
        
        if((R1 + 20) == 0)
        {
            goto label_15;
        }
        
        val_48 = (R1 + 108) + 1;
        mem2[0] = val_48;
        if(val_48 < (R1 + 48))
        {
            goto label_16;
        }
        
        if(val_45 == 0)
        {
            goto label_17;
        }
        
        val_49 = typeof(HorizontalRecyclingSystem.<>c__DisplayClass18_0).__il2cppRuntimeField_8;
        goto label_18;
        label_15:
        if((R1 + 52 + 12) <= (R1 + 100))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_49 = R1 + 52 + 8;
        val_49 = val_49 + ((R1 + 100) << 2);
        UnityEngine.Vector2 val_6 = anchoredPosition;
        var val_52 = val_3;
        if((R1 + 52 + 12) <= (R1 + 100))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_50 = R1 + 52 + 8;
        val_50 = val_50 + ((R1 + 100) << 2);
        UnityEngine.Vector2 val_7 = sizeDelta;
        if((R1 + 52 + 12) <= (R1 + 96))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_51 = R1 + 52 + 8;
        val_51 = val_51 + ((R1 + 96) << 2);
        if((R1 + 52 + 12) <= (R1 + 96))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_53 = R1 + 52 + 8;
        val_52 = val_52 + val_8;
        val_53 = val_53 + ((R1 + 96) << 2);
        UnityEngine.Vector2 val_9 = anchoredPosition;
        UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  val_9.x, y:  val_9.y);
        (R1 + 52 + 8 + (R1 + 96) << 2) + 16.anchoredPosition = new UnityEngine.Vector2() {x = val_11.x, y = val_11.y};
        goto label_38;
        label_17:
        val_49 = typeof(HorizontalRecyclingSystem.<>c__DisplayClass18_0).__il2cppRuntimeField_8;
        label_18:
        typeof(HorizontalRecyclingSystem.<>c__DisplayClass18_0).__il2cppRuntimeField_8 = 1;
        mem2[0] = 0;
        if((R1 + 52 + 12) <= (R1 + 100))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_54 = R1 + 52 + 8;
        val_54 = val_54 + ((R1 + 100) << 2);
        UnityEngine.Vector2 val_12 = anchoredPosition;
        val_48 = mem[R1 + 108];
        val_48 = R1 + 108;
        float val_13 = val_3 + (R1 + 36);
        label_16:
        val_48 = 0 - val_48;
        float val_55 = val_48;
        val_55 = (R1 + 40) * val_55;
        if((R1 + 52 + 12) <= (R1 + 96))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_56 = R1 + 52 + 8;
        val_56 = val_56 + ((R1 + 96) << 2);
        val_10 = 0;
        val_3 = 0;
        UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  val_48, y:  val_12.y);
        (R1 + 52 + 8 + (R1 + 96) << 2) + 16.anchoredPosition = new UnityEngine.Vector2() {x = val_14.x, y = val_14.y};
        var val_57 = R1 + 104;
        val_57 = val_57 + 1;
        mem2[0] = val_57;
        if(val_57 >= (R1 + 48))
        {
                mem2[0] = 0;
        }
        
        label_38:
        val_46 = mem[R1 + 44];
        val_46 = R1 + 44;
        if((R1 + 56 + 12) <= (R1 + 96))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_58 = R1 + 56 + 8;
        val_58 = val_58 + ((R1 + 96) << 2);
        var val_60 = val_46;
        if((R1 + 44 + 178) == 0)
        {
            goto label_42;
        }
        
        var val_59 = 0;
        label_44:
        if((R1 + 44 + 88 + 0) == null)
        {
            goto label_43;
        }
        
        val_59 = val_59 + 1;
        if(((uint)val_59 & 65535) < (R1 + 44 + 178))
        {
            goto label_44;
        }
        
        label_42:
        val_50 = val_46;
        goto label_45;
        label_43:
        var val_15 = (R1 + 44 + 88) + 0;
        val_60 = val_60 + (((R1 + 44 + 88 + 0) + 4) << 3);
        val_50 = val_60 + 196;
        label_45:
        mem2[0] = R1 + 96;
        var val_16 = (R1 + 96) + 1;
        val_45 = val_45;
        var val_61 = R1 + 92;
        val_61 = val_61 + 1;
        mem2[0] = val_61;
        mem2[0] = R1 + 52 + 12;
        if((R1 + 20) == 0)
        {
                if(val_45 != 0)
        {
                val_51 = typeof(HorizontalRecyclingSystem.<>c__DisplayClass18_0).__il2cppRuntimeField_8;
        }
        else
        {
                val_51 = typeof(HorizontalRecyclingSystem.<>c__DisplayClass18_0).__il2cppRuntimeField_8;
        }
        
            typeof(HorizontalRecyclingSystem.<>c__DisplayClass18_0).__il2cppRuntimeField_8 = 2;
        }
        
        label_47:
        if((R1 + 52 + 12) <= (R1 + 96))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_62 = R1 + 52 + 8;
        val_62 = val_62 + ((R1 + 96) << 2);
        float val_17 = UIExtension.MaxX(rectTransform:  (R1 + 52 + 8 + (R1 + 96) << 2) + 16);
        UnityEngine.Vector3 val_18 = val_14.x.min;
        if((R1 + 52 + 12) < 0)
        {
            goto label_52;
        }
        
        label_14:
        if((R1 + 20) != 0)
        {
                UnityEngine.Vector2 val_19 = val_14.x.sizeDelta;
            UnityEngine.Vector2 val_20 = UnityEngine.Vector2.right;
            UnityEngine.Vector2 val_22 = UnityEngine.Vector2.op_Multiply(d:  0f, a:  new UnityEngine.Vector2() {x = -3.100584E+15f, y = 0f});
            UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = -3.100588E+15f, y = val_14.x}, d:  val_22.x);
            UnityEngine.Vector2 val_24 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = -3.100582E+15f, y = val_14.x}, b:  new UnityEngine.Vector2() {x = val_14.y, y = val_11.x});
            R1 + 12.sizeDelta = new UnityEngine.Vector2() {x = val_25, y = val_26};
            if(0 >= 1)
        {
                if(val_45 != 0)
        {
                val_52 = typeof(HorizontalRecyclingSystem.<>c__DisplayClass18_0).__il2cppRuntimeField_8;
        }
        else
        {
                val_52 = typeof(HorizontalRecyclingSystem.<>c__DisplayClass18_0).__il2cppRuntimeField_8;
        }
        
            typeof(HorizontalRecyclingSystem.<>c__DisplayClass18_0).__il2cppRuntimeField_8 = val_52 - 0;
        }
        
        }
        
        System.Action<twelvegigs.storage.JsonDictionary> val_28 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  348721152, method:  new IntPtr(3643804896));
        R1 + 52.ForEach(action:  7401472);
        UnityEngine.Vector2 val_29 = val_14.x.anchoredPosition;
        UnityEngine.Vector2 val_30 = UnityEngine.Vector2.right;
        UnityEngine.Vector2 val_31 = UnityEngine.Vector2.op_Multiply(d:  (float)typeof(HorizontalRecyclingSystem.<>c__DisplayClass18_0).__il2cppRuntimeField_8, a:  new UnityEngine.Vector2() {x = -3.100584E+15f, y = (float)typeof(HorizontalRecyclingSystem.<>c__DisplayClass18_0).__il2cppRuntimeField_8});
        if((R1 + 52 + 12) <= (R1 + 96))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_63 = R1 + 52 + 8;
        val_63 = val_63 + ((R1 + 96) << 2);
        UnityEngine.Vector2 val_32 = val_11.x.sizeDelta;
        UnityEngine.Vector2 val_33 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = -3.100582E+15f, y = val_14.x}, d:  val_32.x);
        UnityEngine.Vector2 val_34 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = -3.10058E+15f, y = val_14.x}, b:  new UnityEngine.Vector2() {x = val_14.y, y = val_25});
        R1 + 12.anchoredPosition = new UnityEngine.Vector2() {x = val_35, y = val_36};
        mem2[0] = 0;
        UnityEngine.Vector2 val_37 = UnityEngine.Vector2.right;
        UnityEngine.Vector2 val_40 = UnityEngine.Vector2.op_Multiply(d:  val_37.x, a:  new UnityEngine.Vector2() {x = -3.100576E+15f, y = (float)typeof(HorizontalRecyclingSystem.<>c__DisplayClass18_0).__il2cppRuntimeField_8});
        if((R1 + 52 + 12) <= (R1 + 96))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_64 = R1 + 52 + 8;
        val_64 = val_64 + ((R1 + 96) << 2);
        UnityEngine.Vector2 val_41 = sizeDelta;
        UnityEngine.Vector2 val_45 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = -3.103827E+15f, y = val_42}, d:  val_41.x);
        return new UnityEngine.Vector2() {x = val_45.x, y = val_45.y};
    }
    private UnityEngine.Vector2 RecycleRightToleft()
    {
        var val_3;
        var val_7;
        var val_9;
        float val_25;
        float val_26;
        float val_35;
        float val_36;
        float val_43;
        float val_45;
        var val_46;
        float val_48;
        float val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        object val_1 = null;
        val_45 = val_1;
        val_1 = new System.Object();
        if(val_45 != 0)
        {
                typeof(HorizontalRecyclingSystem.<>c__DisplayClass19_0).__il2cppRuntimeField_C = R1;
            mem2[0] = 1;
        }
        else
        {
                mem[12] = R1;
            mem2[0] = 1;
        }
        
        typeof(HorizontalRecyclingSystem.<>c__DisplayClass19_0).__il2cppRuntimeField_8 = 0;
        if((R1 + 20) != 0)
        {
                if((R1 + 52 + 12) <= (R1 + 96))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_47 = R1 + 52 + 8;
            val_47 = val_47 + ((R1 + 96) << 2);
            UnityEngine.Vector2 val_2 = anchoredPosition;
        }
        
        var val_4 = R1 + 60;
        val_46 = mem[R1 + 100];
        val_46 = R1 + 100;
        val_48 = 0;
        goto label_8;
        label_49:
        if((R1 + 92) <= (R1 + 52 + 12))
        {
            goto label_10;
        }
        
        if((R1 + 20) == 0)
        {
            goto label_11;
        }
        
        val_49 = (R1 + 104) - 1;
        mem2[0] = val_49;
        if(val_49 > 1)
        {
            goto label_12;
        }
        
        if(val_45 == 0)
        {
            goto label_13;
        }
        
        val_50 = typeof(HorizontalRecyclingSystem.<>c__DisplayClass19_0).__il2cppRuntimeField_8;
        goto label_14;
        label_11:
        if((R1 + 52 + 12) <= (R1 + 96))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_48 = R1 + 52 + 8;
        val_48 = val_48 + ((R1 + 96) << 2);
        UnityEngine.Vector2 val_5 = anchoredPosition;
        var val_51 = val_3;
        if((R1 + 52 + 12) <= (R1 + 96))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_49 = R1 + 52 + 8;
        val_49 = val_49 + ((R1 + 96) << 2);
        UnityEngine.Vector2 val_6 = sizeDelta;
        if((R1 + 52 + 12) <= (R1 + 100))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_50 = R1 + 52 + 8;
        val_50 = val_50 + ((R1 + 100) << 2);
        if((R1 + 52 + 12) <= (R1 + 100))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_52 = R1 + 52 + 8;
        val_51 = val_51 - val_7;
        val_52 = val_52 + ((R1 + 100) << 2);
        UnityEngine.Vector2 val_8 = anchoredPosition;
        UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_8.x, y:  val_8.y);
        (R1 + 52 + 8 + (R1 + 100) << 2) + 16.anchoredPosition = new UnityEngine.Vector2() {x = val_10.x, y = val_10.y};
        if(val_45 != 0)
        {
                val_51 = typeof(HorizontalRecyclingSystem.<>c__DisplayClass19_0).__il2cppRuntimeField_8;
        }
        else
        {
                val_51 = typeof(HorizontalRecyclingSystem.<>c__DisplayClass19_0).__il2cppRuntimeField_8;
        }
        
        typeof(HorizontalRecyclingSystem.<>c__DisplayClass19_0).__il2cppRuntimeField_8 = 1;
        goto label_29;
        label_13:
        val_50 = typeof(HorizontalRecyclingSystem.<>c__DisplayClass19_0).__il2cppRuntimeField_8;
        label_14:
        typeof(HorizontalRecyclingSystem.<>c__DisplayClass19_0).__il2cppRuntimeField_8 = 2;
        var val_53 = R1 + 48;
        val_53 = val_53 - 1;
        mem2[0] = val_53;
        if((R1 + 52 + 12) <= (R1 + 96))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_54 = R1 + 52 + 8;
        val_54 = val_54 + ((R1 + 96) << 2);
        UnityEngine.Vector2 val_11 = anchoredPosition;
        val_52 = 1;
        val_49 = mem[R1 + 104];
        val_49 = R1 + 104;
        float val_12 = val_3 - (R1 + 36);
        label_12:
        val_49 = 0 - val_49;
        float val_55 = val_49;
        val_55 = (R1 + 40) * val_55;
        if((R1 + 52 + 12) <= (R1 + 100))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_56 = R1 + 52 + 8;
        val_56 = val_56 + ((R1 + 100) << 2);
        val_9 = 0;
        val_3 = 0;
        UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  val_49, y:  val_11.y);
        (R1 + 52 + 8 + (R1 + 100) << 2) + 16.anchoredPosition = new UnityEngine.Vector2() {x = val_13.x, y = val_13.y};
        var val_57 = R1 + 108;
        val_57 = val_57 - 1;
        mem2[0] = val_57;
        if(val_57 <= 1)
        {
                var val_58 = R1 + 48;
            val_52 = val_52 - 1;
            val_58 = val_58 - 1;
            mem2[0] = val_58;
        }
        
        label_29:
        var val_59 = R1 + 92;
        val_59 = val_59 - 1;
        mem2[0] = val_59;
        if((R1 + 56 + 12) <= (R1 + 100))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_60 = R1 + 56 + 8;
        val_60 = val_60 + ((R1 + 100) << 2);
        val_53 = mem[R1 + 44];
        val_53 = R1 + 44;
        var val_14 = (R1 + 92) - (R1 + 52 + 12);
        if((R1 + 44 + 178) == 0)
        {
            goto label_41;
        }
        
        var val_61 = 0;
        label_43:
        if((R1 + 44 + 88 + 0) == null)
        {
            goto label_42;
        }
        
        val_61 = val_61 + 1;
        if(((uint)val_61 & 65535) < (R1 + 44 + 178))
        {
            goto label_43;
        }
        
        label_41:
        val_54 = R1 + 44;
        goto label_44;
        label_42:
        var val_15 = (R1 + 44 + 88) + 0;
        val_53 = val_53 + (((R1 + 44 + 88 + 0) + 4) << 3);
        val_54 = val_53 + 196;
        label_44:
        mem2[0] = R1 + 100;
        val_55 = R1 + 52;
        if((R1 + 52) != 0)
        {
            goto label_45;
        }
        
        val_55 = mem[R1 + 52];
        val_55 = R1 + 52;
        if(val_55 == 0)
        {
            goto label_46;
        }
        
        label_45:
        var val_16 = (R1 + 100) + (R1 + 52 + 12);
        val_16 = val_16 - 1;
        val_45 = val_45;
        val_48 = val_52;
        val_46 = R1 + 52 + 12;
        mem2[0] = R1 + 52 + 12;
        label_8:
        if((R1 + 52 + 12) <= val_46)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_62 = R1 + 52 + 8;
        val_62 = val_62 + (val_46 << 2);
        float val_17 = UIExtension.MinX(rectTransform:  (R1 + 52 + 8 + (R1 + 52 + 12) << 2) + 16);
        UnityEngine.Vector3 val_18 = val_13.x.max;
        if((R1 + 52 + 12) > val_46)
        {
            goto label_49;
        }
        
        label_10:
        if((R1 + 20) != 0)
        {
                UnityEngine.Vector2 val_19 = val_13.x.sizeDelta;
            UnityEngine.Vector2 val_20 = UnityEngine.Vector2.right;
            UnityEngine.Vector2 val_22 = UnityEngine.Vector2.op_Multiply(d:  val_48, a:  new UnityEngine.Vector2() {x = -3.130924E+15f, y = val_48});
            UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = -3.130928E+15f, y = val_13.x}, d:  val_22.x);
            UnityEngine.Vector2 val_24 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = -3.130922E+15f, y = val_13.x}, b:  new UnityEngine.Vector2() {x = val_13.y, y = val_10.x});
            R1 + 12.sizeDelta = new UnityEngine.Vector2() {x = val_25, y = val_26};
            if(val_48 >= 1)
        {
                if(val_45 != 0)
        {
                val_56 = typeof(HorizontalRecyclingSystem.<>c__DisplayClass19_0).__il2cppRuntimeField_8;
        }
        else
        {
                val_56 = typeof(HorizontalRecyclingSystem.<>c__DisplayClass19_0).__il2cppRuntimeField_8;
        }
        
            typeof(HorizontalRecyclingSystem.<>c__DisplayClass19_0).__il2cppRuntimeField_8 = val_56 - val_48;
        }
        
        }
        
        System.Action<twelvegigs.storage.JsonDictionary> val_28 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  348774400, method:  new IntPtr(3643917920));
        R1 + 52.ForEach(action:  7401472);
        UnityEngine.Vector2 val_29 = val_13.x.anchoredPosition;
        UnityEngine.Vector2 val_30 = UnityEngine.Vector2.right;
        UnityEngine.Vector2 val_31 = UnityEngine.Vector2.op_Multiply(d:  (float)typeof(HorizontalRecyclingSystem.<>c__DisplayClass19_0).__il2cppRuntimeField_8, a:  new UnityEngine.Vector2() {x = -3.130924E+15f, y = (float)typeof(HorizontalRecyclingSystem.<>c__DisplayClass19_0).__il2cppRuntimeField_8});
        if((R1 + 52 + 12) <= (R1 + 96))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_63 = R1 + 52 + 8;
        val_63 = val_63 + ((R1 + 96) << 2);
        UnityEngine.Vector2 val_32 = val_10.x.sizeDelta;
        UnityEngine.Vector2 val_33 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = -3.130922E+15f, y = val_13.x}, d:  val_32.x);
        UnityEngine.Vector2 val_34 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = -3.130919E+15f, y = val_13.x}, b:  new UnityEngine.Vector2() {x = val_13.y, y = val_25});
        R1 + 12.anchoredPosition = new UnityEngine.Vector2() {x = val_35, y = val_36};
        mem2[0] = 0;
        UnityEngine.Vector2 val_37 = UnityEngine.Vector2.right;
        UnityEngine.Vector2 val_41 = UnityEngine.Vector2.op_Multiply(d:  (float)(0 - (val_56 - (val_52 - 1))), a:  new UnityEngine.Vector2() {x = -3.130915E+15f, y = (float)(0 - (val_56 - (val_52 - 1)))});
        if((R1 + 52 + 12) <= (R1 + 96))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_64 = R1 + 52 + 8;
        val_64 = val_64 + ((R1 + 96) << 2);
        UnityEngine.Vector2 val_42 = sizeDelta;
        UnityEngine.Vector2 val_46 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = -3.134166E+15f, y = val_43}, d:  val_42.x);
        return new UnityEngine.Vector2() {x = val_46.x, y = val_46.y};
        label_46:
    }
    public override DG.Tweening.Tween ScrollByAmountCell(float amountCell, float duration)
    {
        var val_5 = R1;
        if(new System.Object() != 0)
        {
                typeof(HorizontalRecyclingSystem.<>c__DisplayClass20_0).__il2cppRuntimeField_C = this;
        }
        else
        {
                mem[12] = this;
        }
        
        typeof(HorizontalRecyclingSystem.<>c__DisplayClass20_0).__il2cppRuntimeField_8 = 0;
        DG.Tweening.Core.DOGetter<System.Single> val_2 = new DG.Tweening.Core.DOGetter<System.Single>(object:  348827648, method:  new IntPtr(3644030944));
        DG.Tweening.Core.DOSetter<System.Single> val_3 = new DG.Tweening.Core.DOSetter<System.Single>(object:  348827648, method:  new IntPtr(3644031968));
        val_5 = S18 * val_5;
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_4 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  amountCell, duration:  duration);
    }
    public override ICell FindCellByIndex(int Id)
    {
        var val_2;
        var val_3;
        val_2 = 0;
        goto label_1;
        label_11:
        if(true <= val_2)
        {
                var val_2 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_2 = val_2 + 0;
        var val_4 = (0 + 0) + 16;
        if(((0 + 0) + 16 + 178) == 0)
        {
            goto label_5;
        }
        
        var val_3 = 0;
        label_7:
        if(((0 + 0) + 16 + 88 + 0) == null)
        {
            goto label_6;
        }
        
        val_3 = val_3 + 1;
        if(((uint)val_3 & 65535) < ((0 + 0) + 16 + 178))
        {
            goto label_7;
        }
        
        label_5:
        val_3 = (0 + 0) + 16;
        goto label_8;
        label_6:
        var val_1 = ((0 + 0) + 16 + 88) + 0;
        val_4 = val_4 + ((((0 + 0) + 16 + 88 + 0) + 4) << 3);
        val_3 = val_4 + 188;
        label_8:
        if(((0 + 0) + 16) == Id)
        {
            goto label_9;
        }
        
        val_2 = 1;
        label_1:
        if(val_2 < ((0 + 0) + 16))
        {
            goto label_11;
        }
        
        return;
        label_9:
        if(((0 + 0) + 16) <= val_2)
        {
                var val_5 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_5 = val_5 + 0;
    }
    private void SetLeftAnchor(UnityEngine.RectTransform rectTransform)
    {
        UnityEngine.Rect val_1 = rect;
        float val_2 = width;
        UnityEngine.Rect val_3 = rect;
        float val_4 = height;
        if( != 0)
        {
                0 = 1065353216;
        }
        
        if( == 0)
        {
                0 = 1056964608;
        }
        
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_4, y:  val_3.m_YMin);
        if(rectTransform != 0)
        {
                rectTransform.anchorMin = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
            rectTransform.anchorMax = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
        }
        else
        {
                0.anchorMin = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
            0.anchorMax = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
        }
        
        rectTransform.pivot = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_4, y:  val_3.m_YMin);
        rectTransform.sizeDelta = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
    }
    public void OnDrawGizmos()
    {
        float val_8;
        float val_9;
        float val_10;
        float val_18;
        float val_19;
        float val_20;
        UnityEngine.Color val_1 = UnityEngine.Color.green;
        UnityEngine.Gizmos.color = new UnityEngine.Color();
        UnityEngine.Vector3 val_2 = min;
        UnityEngine.Vector3 val_3 = new UnityEngine.Vector3(x:  val_2.x, y:  val_2.y);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -3.260528E+15f}, b:  new UnityEngine.Vector3() {y = val_3.x, z = val_3.y});
        UnityEngine.Vector3 val_5 = min;
        UnityEngine.Vector3 val_6 = new UnityEngine.Vector3(x:  val_5.x, y:  val_5.y);
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -3.260517E+15f}, b:  new UnityEngine.Vector3() {y = val_6.x, z = val_6.y});
        UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3(), to:  new UnityEngine.Vector3() {x = val_8, y = val_10, z = val_9});
        UnityEngine.Color val_11 = UnityEngine.Color.red;
        UnityEngine.Gizmos.color = new UnityEngine.Color();
        UnityEngine.Vector3 val_12 = max;
        UnityEngine.Vector3 val_13 = new UnityEngine.Vector3(x:  val_12.x, y:  val_12.y);
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -3.260502E+15f}, b:  new UnityEngine.Vector3() {y = val_13.x, z = val_13.y});
        UnityEngine.Vector3 val_15 = max;
        UnityEngine.Vector3 val_16 = new UnityEngine.Vector3(x:  val_15.x, y:  val_15.y);
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -3.260491E+15f}, b:  new UnityEngine.Vector3() {y = val_16.x, z = val_16.y});
        UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3(), to:  new UnityEngine.Vector3() {x = val_18, y = val_20, z = val_19});
    }

}
