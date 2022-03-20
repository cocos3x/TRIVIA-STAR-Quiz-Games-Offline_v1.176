using UnityEngine;
public class VerticalRecyclingSystem : RecyclingSystem
{
    // Fields
    private readonly IRecyclableScrollRectDataSource _dataSource;
    private readonly int _coloumns;
    private System.Collections.Generic.List<UnityEngine.RectTransform> _cellPool;
    private System.Collections.Generic.List<ICell> _cachedCells;
    private UnityEngine.Bounds _recyclableViewBounds;
    private readonly UnityEngine.Vector3[] _corners;
    private bool _recycling;
    private int startPos;
    private int currentItemCount;
    private int topMostCellIndex;
    private int bottomMostCellIndex;
    private int _topMostCellColoumn;
    private int _bottomMostCellColoumn;
    private UnityEngine.Vector2 zeroVector;
    
    // Methods
    public VerticalRecyclingSystem(UnityEngine.RectTransform prototypeCell, UnityEngine.RectTransform viewport, UnityEngine.RectTransform content, IRecyclableScrollRectDataSource dataSource, bool isGrid, int coloumns)
    {
        this._corners = null;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        this.zeroVector = new UnityEngine.Vector2();
        mem[1152921512550694424] = ???;
        mem[1152921512550694312] = viewport;
        mem[1152921512550694316] = content;
        if(isGrid == false)
        {
                coloumns = 1;
        }
        
        mem[1152921512550694320] = prototypeCell;
        mem[1152921512550694324] = isGrid;
        this._dataSource = dataSource;
        this._coloumns = coloumns;
        mem[1152921512550694384] = 0;
        mem[1152921512550694380] = 0;
    }
    public override System.Collections.IEnumerator InitCoroutine(System.Action onInitialized, int m_startPos, bool centered = False)
    {
        typeof(VerticalRecyclingSystem.<InitCoroutine>d__15).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(VerticalRecyclingSystem.<InitCoroutine>d__15).__il2cppRuntimeField_1C = onInitialized;
            typeof(VerticalRecyclingSystem.<InitCoroutine>d__15).__il2cppRuntimeField_10 = this;
            typeof(VerticalRecyclingSystem.<InitCoroutine>d__15).__il2cppRuntimeField_14 = m_startPos;
        }
        else
        {
                mem[16] = this;
            mem[28] = onInitialized;
            mem[20] = m_startPos;
        }
        
        typeof(VerticalRecyclingSystem.<InitCoroutine>d__15).__il2cppRuntimeField_18 = centered;
    }
    private void SetRecyclingBounds()
    {
        R5.GetWorldCorners(fourCornersArray:  this._corners);
        UnityEngine.Vector3 val_5 = this._corners[0];
        val_5 = this._corners[2] - val_5;
        UnityEngine.Vector3 val_6 = this._corners[0];
        UnityEngine.Vector3 val_1 = S16 * val_5;
        UnityEngine.Vector3 val_7 = this._corners[0];
        val_7 = val_7 - val_1;
        UnityEngine.Vector3 val_2 = new UnityEngine.Vector3(x:  val_7, y:  null);
        this._recyclableViewBounds.min = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        UnityEngine.Vector3 val_8 = this._corners[2];
        UnityEngine.Vector3 val_9 = this._corners[2];
        val_9 = val_1 + val_9;
        UnityEngine.Vector3 val_3 = new UnityEngine.Vector3(x:  val_9, y:  null);
        this._recyclableViewBounds.max = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
    }
    private void CreateCellPool()
    {
        var val_8;
        float val_10;
        var val_28;
        VerticalRecyclingSystem.<>c val_46;
        var val_47;
        IRecyclableScrollRectDataSource val_48;
        var val_49;
        int val_50;
        var val_51;
        var val_52;
        var val_54;
        var val_55;
        var val_56;
        int val_57;
        var val_58;
        var val_59;
        if(this._cellPool != 0)
        {
                if((VerticalRecyclingSystem.<>c.<>9__17_0) == 0)
        {
                val_46 = VerticalRecyclingSystem.<>c.<>9;
            System.Action<twelvegigs.storage.JsonDictionary> val_1 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  val_46, method:  new IntPtr(3649736800));
            VerticalRecyclingSystem.<>c.<>9__17_0 = null;
        }
        
            this._cellPool.ForEach(action:  7401472);
            this._cellPool.Clear();
            this._cachedCells.Clear();
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
        if(null != 0)
        {
                SetTopLeftAnchor(rectTransform:  1);
        }
        else
        {
                SetTopAnchor(rectTransform:  1);
        }
        
        UnityEngine.Rect val_5 = rect;
        float val_6 = width;
        float val_46 = (float)this._coloumns;
        val_46 = 3649798920 / val_46;
        mem[1152921512551625284] = val_46;
        UnityEngine.Vector2 val_7 = sizeDelta;
        var val_49 = val_8;
        UnityEngine.Vector2 val_9 = sizeDelta;
        float val_47 = val_10;
        val_47 = val_49 / val_47;
        val_47 = val_47 * 3649798920;
        mem[1152921512551625288] = val_47;
        UnityEngine.Rect val_11 = rect;
        float val_12 = height;
        val_46 = 0;
        val_46 = val_46 + 1;
        val_47 = this._dataSource;
        int val_14 = System.Math.Min(val1:  SL, val2:  this._dataSource);
        val_48 = this._dataSource;
        val_46 = 0;
        val_46 = val_46 + 1;
        val_49 = val_48;
        val_50 = val_14;
        if((this.currentItemCount + val_14) > val_48)
        {
                val_46 = 0;
            val_48 = 0;
            val_46 = val_46 + 1;
            val_48 = (uint)val_46 & 65535;
            val_51 = this._dataSource;
            IRecyclableScrollRectDataSource val_48 = this._dataSource;
            val_48 = val_48 - val_50;
            this.currentItemCount = val_48;
        }
        
        val_49 = val_49 * 3649798920;
        if(val_50 <= 0)
        {
            goto label_42;
        }
        
        float val_53 = 0f;
        uint val_51 = 0;
        label_71:
        val_46 = 0;
        val_48 = 0;
        val_46 = val_46 + 1;
        val_48 = (uint)val_46 & 65535;
        val_52 = this._dataSource;
        if(0 >= this._dataSource)
        {
            goto label_42;
        }
        
        UnityEngine.GameObject val_19 = this._dataSource.gameObject;
        object val_20 = UnityEngine.Object.Instantiate<System.Object>(original:  this._dataSource);
        object val_21 = this._dataSource.GetComponent<System.Object>();
        if(this._dataSource != 0)
        {
                this._dataSource.name = -651396720;
            UnityEngine.Vector2 val_22 = new UnityEngine.Vector2(x:  val_12, y:  val_11.m_YMin);
        }
        else
        {
                0.name = -651396720;
            UnityEngine.Vector2 val_23 = new UnityEngine.Vector2(x:  val_12, y:  val_11.m_YMin);
        }
        
        this._dataSource.sizeDelta = new UnityEngine.Vector2() {x = val_23.x, y = val_23.y};
        this._cellPool.Add(item:  this._dataSource);
        this._dataSource.SetParent(parent:  this._cellPool, worldPositionStays:  false);
        if(this._dataSource == 0)
        {
            goto label_51;
        }
        
        UnityEngine.Vector2 val_24;
        val_12 = val_12 * (float)this._bottomMostCellColoumn;
        val_24 = new UnityEngine.Vector2(x:  val_12, y:  val_11.m_YMin);
        this._dataSource.anchoredPosition = new UnityEngine.Vector2() {x = val_24.x, y = val_24.y};
        int val_50 = this._bottomMostCellColoumn;
        val_50 = val_50 + 1;
        this._bottomMostCellColoumn = val_50;
        if(val_50 < this._coloumns)
        {
            goto label_53;
        }
        
        this._bottomMostCellColoumn = 0;
        val_51 = val_51 - S22;
        UnityEngine.Rect val_25 = val_24.x.rect;
        goto label_55;
        label_51:
        val_8 = 0;
        UnityEngine.Vector2 val_26 = new UnityEngine.Vector2(x:  val_12, y:  val_11.m_YMin);
        if(this._dataSource != 0)
        {
                this._dataSource.anchoredPosition = new UnityEngine.Vector2() {x = val_26.x, y = val_26.y};
        }
        else
        {
                this._dataSource.anchoredPosition = new UnityEngine.Vector2() {x = val_26.x, y = val_26.y};
        }
        
        UnityEngine.Vector2 val_27 = anchoredPosition;
        var val_52 = val_28;
        UnityEngine.Rect val_29 = val_24.x.rect;
        float val_30 = height;
        val_52 = val_52 - 3649798920;
        UnityEngine.Rect val_31 = rect;
        label_55:
        float val_32 = height;
        val_53 = val_53 + 3649798920;
        label_53:
        object val_33 = this._dataSource.GetComponent<System.Object>();
        this._cachedCells.Add(item:  this._dataSource);
        val_48 = this._cachedCells;
        if(val_48 != 0)
        {
                val_55 = this._cachedCells;
        }
        else
        {
                val_55 = 0;
            val_54 = 0;
        }
        
        if(val_54 <= (-1))
        {
                var val_54 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_54 = val_54 + 4294967292;
        var val_55 = 0;
        val_48 = 0;
        val_55 = val_55 + 1;
        val_48 = (uint)val_55 & 65535;
        val_56 = this._dataSource;
        val_50 = val_14;
        int val_56 = this.currentItemCount;
        val_56 = val_56 + 1;
        this.currentItemCount = val_56;
        if((1 < val_50) || (1 < 0))
        {
            goto label_71;
        }
        
        label_42:
        if(val_56 != 0)
        {
                int val_57 = this._bottomMostCellColoumn;
            val_57 = val_57 + this._coloumns;
            val_57 = val_57 - 1;
            this._bottomMostCellColoumn = this._coloumns;
        }
        
        UnityEngine.GameObject val_35 = this._dataSource.gameObject;
        UnityEngine.SceneManagement.Scene val_36 = this._dataSource.scene;
        if(val_36.m_Handle.IsValid() != false)
        {
                UnityEngine.GameObject val_38 = this._dataSource.gameObject;
            this._dataSource.SetActive(value:  false);
        }
        
        val_57 = this.startPos;
        val_46 = 0;
        val_46 = val_46 + 1;
        val_58 = this._dataSource;
        if((val_57 + val_50) <= this._dataSource)
        {
                return;
        }
        
        val_57 = this.startPos;
        val_46 = 0;
        val_46 = val_46 + 1;
        val_59 = this._dataSource;
        IRecyclableScrollRectDataSource val_58 = this._dataSource;
        val_58 = (val_57 + val_50) - val_58;
        val_48 = 0;
        UnityEngine.Vector2 val_43 = val_24.x.anchoredPosition;
        val_43.x = val_43.x * (float)val_58;
        UnityEngine.Vector2 val_44 = new UnityEngine.Vector2(x:  val_43.x, y:  val_43.y);
        UnityEngine.Vector2 val_45 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = -4.908619E+15f, y = val_24.x}, b:  new UnityEngine.Vector2() {x = val_24.y, y = val_44.x});
        this._dataSource.anchoredPosition = new UnityEngine.Vector2() {x = val_26.x, y = val_26.y};
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
        this = direction.x + 116;
        mem[1152921512551790500] = direction.x + 120;
        return new UnityEngine.Vector2();
        label_2:
        direction.x.SetRecyclingBounds();
        if((direction.x + 52) > 0)
        {
                if((direction.x + 52 + 12) <= (direction.x + 104))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_10 = direction.x + 52 + 8;
            val_10 = val_10 + ((direction.x + 104) << 2);
            float val_1 = UIExtension.MaxY(rectTransform:  (direction.x + 52 + 8 + (direction.x + 104) << 2) + 16);
            float val_2 = direction.x + 60;
            UnityEngine.Vector3 val_3 = min;
            if((direction.x + 52 + 12) > (direction.x + 104))
        {
                UnityEngine.Vector2 val_5 = this.RecycleTopToBottom();
            return new UnityEngine.Vector2();
        }
        
        }
        
        if((direction.x + 52) >= 0)
        {
            goto label_11;
        }
        
        if((direction.x + 52 + 12) <= (direction.x + 100))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_11 = direction.x + 52 + 8;
        val_11 = val_11 + ((direction.x + 100) << 2);
        float val_6 = UIExtension.MinY(rectTransform:  (direction.x + 52 + 8 + (direction.x + 100) << 2) + 16);
        float val_7 = direction.x + 60;
        UnityEngine.Vector3 val_8 = max;
        if((direction.x + 52 + 12) >= 0)
        {
            goto label_11;
        }
        
        UnityEngine.Vector2 val_9 = this.RecycleBottomToTop();
        return new UnityEngine.Vector2();
    }
    private UnityEngine.Vector2 RecycleTopToBottom()
    {
        var val_3;
        var val_8;
        var val_10;
        float val_25;
        float val_26;
        float val_35;
        float val_36;
        var val_38;
        var val_40;
        var val_41;
        var val_42;
        float val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        object val_1 = null;
        val_40 = val_1;
        val_1 = new System.Object();
        if(val_40 != 0)
        {
                typeof(VerticalRecyclingSystem.<>c__DisplayClass19_0).__il2cppRuntimeField_C = R1;
            mem2[0] = 1;
        }
        else
        {
                mem[12] = R1;
            mem2[0] = 1;
        }
        
        typeof(VerticalRecyclingSystem.<>c__DisplayClass19_0).__il2cppRuntimeField_8 = 0;
        if((R1 + 20) != 0)
        {
                if((R1 + 52 + 12) <= (R1 + 104))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_41 = R1 + 52 + 8;
            val_41 = val_41 + ((R1 + 104) << 2);
            UnityEngine.Vector2 val_2 = anchoredPosition;
        }
        
        var val_4 = R1 + 60;
        goto label_47;
        label_52:
        val_41 = mem[R1 + 96];
        val_41 = R1 + 96;
        var val_43 = R1 + 44;
        if((R1 + 44 + 178) == 0)
        {
            goto label_10;
        }
        
        var val_42 = 0;
        label_12:
        if((R1 + 44 + 88 + 0) == null)
        {
            goto label_11;
        }
        
        val_42 = val_42 + 1;
        if(((uint)val_42 & 65535) < (R1 + 44 + 178))
        {
            goto label_12;
        }
        
        label_10:
        val_42 = R1 + 44;
        goto label_13;
        label_11:
        var val_5 = (R1 + 44 + 88) + 0;
        val_43 = val_43 + (((R1 + 44 + 88 + 0) + 4) << 3);
        val_42 = val_43 + 188;
        label_13:
        if(val_41 >= (R1 + 44))
        {
            goto label_14;
        }
        
        if((R1 + 20) == 0)
        {
            goto label_15;
        }
        
        val_43 = (R1 + 112) + 1;
        mem2[0] = val_43;
        if(val_43 < (R1 + 48))
        {
            goto label_16;
        }
        
        if(val_40 == 0)
        {
            goto label_17;
        }
        
        val_44 = typeof(VerticalRecyclingSystem.<>c__DisplayClass19_0).__il2cppRuntimeField_8;
        goto label_18;
        label_15:
        if((R1 + 52 + 12) <= (R1 + 104))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_44 = R1 + 52 + 8;
        val_44 = val_44 + ((R1 + 104) << 2);
        UnityEngine.Vector2 val_6 = anchoredPosition;
        var val_47 = val_3;
        if((R1 + 52 + 12) <= (R1 + 104))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_45 = R1 + 52 + 8;
        val_45 = val_45 + ((R1 + 104) << 2);
        UnityEngine.Vector2 val_7 = sizeDelta;
        if((R1 + 52 + 12) <= (R1 + 100))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_46 = R1 + 52 + 8;
        val_46 = val_46 + ((R1 + 100) << 2);
        if((R1 + 52 + 12) <= (R1 + 100))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_48 = R1 + 52 + 8;
        val_47 = val_47 - val_8;
        val_48 = val_48 + ((R1 + 100) << 2);
        UnityEngine.Vector2 val_9 = anchoredPosition;
        UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  val_9.x, y:  val_9.y);
        (R1 + 52 + 8 + (R1 + 100) << 2) + 16.anchoredPosition = new UnityEngine.Vector2() {x = val_11.x, y = val_11.y};
        goto label_38;
        label_17:
        val_44 = typeof(VerticalRecyclingSystem.<>c__DisplayClass19_0).__il2cppRuntimeField_8;
        label_18:
        typeof(VerticalRecyclingSystem.<>c__DisplayClass19_0).__il2cppRuntimeField_8 = 1;
        mem2[0] = 0;
        if((R1 + 52 + 12) <= (R1 + 104))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_49 = R1 + 52 + 8;
        val_49 = val_49 + ((R1 + 104) << 2);
        UnityEngine.Vector2 val_12 = anchoredPosition;
        val_43 = mem[R1 + 112];
        val_43 = R1 + 112;
        float val_13 = val_3 - (R1 + 40);
        label_16:
        float val_50 = val_43;
        val_50 = (R1 + 36) * val_50;
        if((R1 + 52 + 12) <= (R1 + 100))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_51 = R1 + 52 + 8;
        val_51 = val_51 + ((R1 + 100) << 2);
        val_3 = 0;
        val_10 = 0;
        UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  val_43, y:  val_12.y);
        (R1 + 52 + 8 + (R1 + 100) << 2) + 16.anchoredPosition = new UnityEngine.Vector2() {x = val_14.x, y = val_14.y};
        var val_52 = R1 + 108;
        val_52 = val_52 + 1;
        mem2[0] = val_52;
        if(val_52 >= (R1 + 48))
        {
                mem2[0] = 0;
        }
        
        label_38:
        val_41 = mem[R1 + 44];
        val_41 = R1 + 44;
        if((R1 + 56 + 12) <= (R1 + 100))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_53 = R1 + 56 + 8;
        val_53 = val_53 + ((R1 + 100) << 2);
        var val_55 = val_41;
        if((R1 + 44 + 178) == 0)
        {
            goto label_42;
        }
        
        var val_54 = 0;
        label_44:
        if((R1 + 44 + 88 + 0) == null)
        {
            goto label_43;
        }
        
        val_54 = val_54 + 1;
        if(((uint)val_54 & 65535) < (R1 + 44 + 178))
        {
            goto label_44;
        }
        
        label_42:
        val_45 = val_41;
        goto label_45;
        label_43:
        var val_15 = (R1 + 44 + 88) + 0;
        val_55 = val_55 + (((R1 + 44 + 88 + 0) + 4) << 3);
        val_45 = val_55 + 196;
        label_45:
        mem2[0] = R1 + 100;
        var val_16 = (R1 + 100) + 1;
        val_40 = val_40;
        var val_56 = R1 + 96;
        val_56 = val_56 + 1;
        mem2[0] = val_56;
        mem2[0] = R1 + 52 + 12;
        if((R1 + 20) == 0)
        {
                if(val_40 != 0)
        {
                val_46 = typeof(VerticalRecyclingSystem.<>c__DisplayClass19_0).__il2cppRuntimeField_8;
        }
        else
        {
                val_46 = typeof(VerticalRecyclingSystem.<>c__DisplayClass19_0).__il2cppRuntimeField_8;
        }
        
            typeof(VerticalRecyclingSystem.<>c__DisplayClass19_0).__il2cppRuntimeField_8 = 2;
        }
        
        label_47:
        if((R1 + 52 + 12) <= (R1 + 100))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_57 = R1 + 52 + 8;
        val_57 = val_57 + ((R1 + 100) << 2);
        float val_17 = UIExtension.MinY(rectTransform:  (R1 + 52 + 8 + (R1 + 100) << 2) + 16);
        UnityEngine.Vector3 val_18 = val_14.x.max;
        if((R1 + 52 + 12) > (R1 + 100))
        {
            goto label_52;
        }
        
        label_14:
        if((R1 + 20) != 0)
        {
                UnityEngine.Vector2 val_19 = val_14.x.sizeDelta;
            UnityEngine.Vector2 val_20 = UnityEngine.Vector2.up;
            UnityEngine.Vector2 val_22 = UnityEngine.Vector2.op_Multiply(d:  0f, a:  new UnityEngine.Vector2() {x = -5.05802E+15f, y = 0f});
            UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = -5.058028E+15f, y = val_14.x}, d:  val_22.x);
            UnityEngine.Vector2 val_24 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = -5.058015E+15f, y = val_14.x}, b:  new UnityEngine.Vector2() {x = val_14.y, y = val_11.x});
            R1 + 12.sizeDelta = new UnityEngine.Vector2() {x = val_25, y = val_26};
            if(0 >= 1)
        {
                if(val_40 != 0)
        {
                val_47 = typeof(VerticalRecyclingSystem.<>c__DisplayClass19_0).__il2cppRuntimeField_8;
        }
        else
        {
                val_47 = typeof(VerticalRecyclingSystem.<>c__DisplayClass19_0).__il2cppRuntimeField_8;
        }
        
            typeof(VerticalRecyclingSystem.<>c__DisplayClass19_0).__il2cppRuntimeField_8 = val_47 - 0;
        }
        
        }
        
        System.Action<twelvegigs.storage.JsonDictionary> val_28 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  349413376, method:  new IntPtr(3650064224));
        R1 + 52.ForEach(action:  7401472);
        UnityEngine.Vector2 val_29 = val_14.x.anchoredPosition;
        UnityEngine.Vector2 val_30 = UnityEngine.Vector2.up;
        UnityEngine.Vector2 val_31 = UnityEngine.Vector2.op_Multiply(d:  (float)typeof(VerticalRecyclingSystem.<>c__DisplayClass19_0).__il2cppRuntimeField_8, a:  new UnityEngine.Vector2() {x = -5.05802E+15f, y = (float)typeof(VerticalRecyclingSystem.<>c__DisplayClass19_0).__il2cppRuntimeField_8});
        if((R1 + 52 + 12) <= (R1 + 100))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_58 = R1 + 52 + 8;
        val_58 = val_58 + ((R1 + 100) << 2);
        UnityEngine.Vector2 val_32 = val_11.x.sizeDelta;
        UnityEngine.Vector2 val_33 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = -5.058015E+15f, y = val_14.x}, d:  val_32.x);
        UnityEngine.Vector2 val_34 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = -5.058011E+15f, y = val_14.x}, b:  new UnityEngine.Vector2() {x = val_14.y, y = val_25});
        R1 + 12.anchoredPosition = new UnityEngine.Vector2() {x = val_35, y = val_36};
        mem2[0] = 0;
        if((R1 + 52 + 12) <= (R1 + 100))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_59 = R1 + 52 + 8;
        val_59 = val_59 + ((R1 + 100) << 2);
        UnityEngine.Vector2 val_37 = sizeDelta;
        float val_60 = (float)typeof(VerticalRecyclingSystem.<>c__DisplayClass19_0).__il2cppRuntimeField_8;
        val_60 = val_38 * val_60;
        UnityEngine.Vector2 val_39 = new UnityEngine.Vector2(x:  val_60, y:  val_37.y);
        UnityEngine.Vector2 val_40 = UnityEngine.Vector2.op_UnaryNegation(a:  new UnityEngine.Vector2() {x = -5.064505E+15f, y = val_39.x});
        return new UnityEngine.Vector2() {x = val_40.x, y = val_40.y};
    }
    private UnityEngine.Vector2 RecycleBottomToTop()
    {
        var val_3;
        var val_7;
        float val_9;
        float val_26;
        float val_27;
        float val_36;
        float val_37;
        var val_39;
        float val_40;
        var val_41;
        float val_43;
        float val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        object val_1 = null;
        val_40 = val_1;
        val_1 = new System.Object();
        if(val_40 != 0)
        {
                typeof(VerticalRecyclingSystem.<>c__DisplayClass20_0).__il2cppRuntimeField_C = R1;
            mem2[0] = 1;
        }
        else
        {
                mem[12] = R1;
            mem2[0] = 1;
        }
        
        typeof(VerticalRecyclingSystem.<>c__DisplayClass20_0).__il2cppRuntimeField_8 = 0;
        if((R1 + 20) != 0)
        {
                if((R1 + 52 + 12) <= (R1 + 100))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_41 = R1 + 52 + 8;
            val_41 = val_41 + ((R1 + 100) << 2);
            UnityEngine.Vector2 val_2 = anchoredPosition;
        }
        
        var val_4 = R1 + 60;
        val_41 = mem[R1 + 104];
        val_41 = R1 + 104;
        val_43 = 0;
        goto label_8;
        label_49:
        if((R1 + 96) <= (R1 + 52 + 12))
        {
            goto label_10;
        }
        
        if((R1 + 20) == 0)
        {
            goto label_11;
        }
        
        val_44 = (R1 + 108) - 1;
        mem2[0] = val_44;
        if(val_44 > 1)
        {
            goto label_12;
        }
        
        if(val_40 == 0)
        {
            goto label_13;
        }
        
        val_45 = typeof(VerticalRecyclingSystem.<>c__DisplayClass20_0).__il2cppRuntimeField_8;
        goto label_14;
        label_11:
        if((R1 + 52 + 12) <= (R1 + 100))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_42 = R1 + 52 + 8;
        val_42 = val_42 + ((R1 + 100) << 2);
        UnityEngine.Vector2 val_5 = anchoredPosition;
        var val_45 = val_3;
        if((R1 + 52 + 12) <= (R1 + 100))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_43 = R1 + 52 + 8;
        val_43 = val_43 + ((R1 + 100) << 2);
        UnityEngine.Vector2 val_6 = sizeDelta;
        if((R1 + 52 + 12) <= (R1 + 104))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_44 = R1 + 52 + 8;
        val_44 = val_44 + ((R1 + 104) << 2);
        if((R1 + 52 + 12) <= (R1 + 104))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_46 = R1 + 52 + 8;
        val_45 = val_45 + val_7;
        val_46 = val_46 + ((R1 + 104) << 2);
        UnityEngine.Vector2 val_8 = anchoredPosition;
        UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_8.x, y:  val_8.y);
        (R1 + 52 + 8 + (R1 + 104) << 2) + 16.anchoredPosition = new UnityEngine.Vector2() {x = val_10.x, y = val_10.y};
        if(val_40 != 0)
        {
                val_46 = typeof(VerticalRecyclingSystem.<>c__DisplayClass20_0).__il2cppRuntimeField_8;
        }
        else
        {
                val_46 = typeof(VerticalRecyclingSystem.<>c__DisplayClass20_0).__il2cppRuntimeField_8;
        }
        
        typeof(VerticalRecyclingSystem.<>c__DisplayClass20_0).__il2cppRuntimeField_8 = 1;
        goto label_29;
        label_13:
        val_45 = typeof(VerticalRecyclingSystem.<>c__DisplayClass20_0).__il2cppRuntimeField_8;
        label_14:
        typeof(VerticalRecyclingSystem.<>c__DisplayClass20_0).__il2cppRuntimeField_8 = 2;
        var val_47 = R1 + 48;
        val_47 = val_47 - 1;
        mem2[0] = val_47;
        if((R1 + 52 + 12) <= (R1 + 100))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_48 = R1 + 52 + 8;
        val_48 = val_48 + ((R1 + 100) << 2);
        UnityEngine.Vector2 val_11 = anchoredPosition;
        val_47 = 1;
        val_44 = mem[R1 + 108];
        val_44 = R1 + 108;
        float val_12 = val_3 + (R1 + 40);
        label_12:
        float val_49 = val_44;
        val_49 = (R1 + 36) * val_49;
        if((R1 + 52 + 12) <= (R1 + 104))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_50 = R1 + 52 + 8;
        val_50 = val_50 + ((R1 + 104) << 2);
        val_3 = 0;
        UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  val_44, y:  val_11.y);
        (R1 + 52 + 8 + (R1 + 104) << 2) + 16.anchoredPosition = new UnityEngine.Vector2() {x = val_13.x, y = val_13.y};
        var val_51 = R1 + 112;
        val_51 = val_51 - 1;
        mem2[0] = val_51;
        if(val_51 <= 1)
        {
                var val_52 = R1 + 48;
            val_47 = val_47 - 1;
            val_52 = val_52 - 1;
            mem2[0] = val_52;
        }
        
        label_29:
        var val_53 = R1 + 96;
        val_53 = val_53 - 1;
        mem2[0] = val_53;
        if((R1 + 56 + 12) <= (R1 + 104))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_54 = R1 + 56 + 8;
        val_54 = val_54 + ((R1 + 104) << 2);
        val_48 = mem[R1 + 44];
        val_48 = R1 + 44;
        var val_14 = (R1 + 96) - (R1 + 52 + 12);
        if((R1 + 44 + 178) == 0)
        {
            goto label_41;
        }
        
        var val_55 = 0;
        label_43:
        if((R1 + 44 + 88 + 0) == null)
        {
            goto label_42;
        }
        
        val_55 = val_55 + 1;
        if(((uint)val_55 & 65535) < (R1 + 44 + 178))
        {
            goto label_43;
        }
        
        label_41:
        val_49 = R1 + 44;
        goto label_44;
        label_42:
        var val_15 = (R1 + 44 + 88) + 0;
        val_48 = val_48 + (((R1 + 44 + 88 + 0) + 4) << 3);
        val_49 = val_48 + 196;
        label_44:
        mem2[0] = R1 + 104;
        val_50 = R1 + 52;
        if((R1 + 52) != 0)
        {
            goto label_45;
        }
        
        val_50 = mem[R1 + 52];
        val_50 = R1 + 52;
        if(val_50 == 0)
        {
            goto label_46;
        }
        
        label_45:
        var val_16 = (R1 + 104) + (R1 + 52 + 12);
        val_16 = val_16 - 1;
        val_40 = val_40;
        val_43 = val_47;
        val_41 = R1 + 52 + 12;
        mem2[0] = R1 + 52 + 12;
        label_8:
        if((R1 + 52 + 12) <= val_41)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_56 = R1 + 52 + 8;
        val_56 = val_56 + (val_41 << 2);
        float val_17 = UIExtension.MaxY(rectTransform:  (R1 + 52 + 8 + (R1 + 52 + 12) << 2) + 16);
        UnityEngine.Vector3 val_18 = val_13.x.min;
        if((R1 + 52 + 12) < 0)
        {
            goto label_49;
        }
        
        label_10:
        if((R1 + 20) != 0)
        {
                UnityEngine.Vector2 val_19 = val_13.x.sizeDelta;
            UnityEngine.Vector2 val_20 = UnityEngine.Vector2.up;
            UnityEngine.Vector2 val_22 = UnityEngine.Vector2.op_Multiply(d:  val_43, a:  new UnityEngine.Vector2() {x = -5.118712E+15f, y = val_43});
            UnityEngine.Vector2 val_24 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = -5.118708E+15f, y = val_9}, d:  val_22.x);
            UnityEngine.Vector2 val_25 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = -5.118695E+15f, y = val_13.x}, b:  new UnityEngine.Vector2() {x = val_13.y, y = val_10.x});
            R1 + 12.sizeDelta = new UnityEngine.Vector2() {x = val_26, y = val_27};
            if(val_43 >= 1)
        {
                if(val_40 != 0)
        {
                val_51 = typeof(VerticalRecyclingSystem.<>c__DisplayClass20_0).__il2cppRuntimeField_8;
        }
        else
        {
                val_51 = typeof(VerticalRecyclingSystem.<>c__DisplayClass20_0).__il2cppRuntimeField_8;
        }
        
            typeof(VerticalRecyclingSystem.<>c__DisplayClass20_0).__il2cppRuntimeField_8 = val_51 - val_43;
        }
        
        }
        
        System.Action<twelvegigs.storage.JsonDictionary> val_29 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  349466624, method:  new IntPtr(3650177248));
        R1 + 52.ForEach(action:  7401472);
        UnityEngine.Vector2 val_30 = val_13.x.anchoredPosition;
        UnityEngine.Vector2 val_31 = UnityEngine.Vector2.up;
        UnityEngine.Vector2 val_32 = UnityEngine.Vector2.op_Multiply(d:  (float)typeof(VerticalRecyclingSystem.<>c__DisplayClass20_0).__il2cppRuntimeField_8, a:  new UnityEngine.Vector2() {x = -5.118712E+15f, y = (float)typeof(VerticalRecyclingSystem.<>c__DisplayClass20_0).__il2cppRuntimeField_8});
        if((R1 + 52 + 12) <= (R1 + 100))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_57 = R1 + 52 + 8;
        val_57 = val_57 + ((R1 + 100) << 2);
        UnityEngine.Vector2 val_33 = val_10.x.sizeDelta;
        UnityEngine.Vector2 val_34 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = -5.118695E+15f, y = val_9}, d:  val_33.x);
        UnityEngine.Vector2 val_35 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = -5.11869E+15f, y = val_13.x}, b:  new UnityEngine.Vector2() {x = val_13.y, y = val_26});
        R1 + 12.anchoredPosition = new UnityEngine.Vector2() {x = val_36, y = val_37};
        mem2[0] = 0;
        if((R1 + 52 + 12) <= (R1 + 100))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_58 = R1 + 52 + 8;
        val_58 = val_58 + ((R1 + 100) << 2);
        UnityEngine.Vector2 val_38 = sizeDelta;
        float val_59 = (float)typeof(VerticalRecyclingSystem.<>c__DisplayClass20_0).__il2cppRuntimeField_8;
        this = 0;
        mem[1152921512552016548] = 0;
        val_59 = val_39 * val_59;
        this = new UnityEngine.Vector2(x:  val_59, y:  val_38.y);
        return new UnityEngine.Vector2() {x = val_59, y = val_38.y};
        label_46:
    }
    public override DG.Tweening.Tween ScrollByAmountCell(float amountCell, float duration)
    {
        var val_5 = R1;
        if(new System.Object() != 0)
        {
                typeof(VerticalRecyclingSystem.<>c__DisplayClass21_0).__il2cppRuntimeField_C = this;
        }
        else
        {
                mem[12] = this;
        }
        
        typeof(VerticalRecyclingSystem.<>c__DisplayClass21_0).__il2cppRuntimeField_8 = 0;
        DG.Tweening.Core.DOGetter<System.Single> val_2 = new DG.Tweening.Core.DOGetter<System.Single>(object:  349519872, method:  new IntPtr(3650290272));
        DG.Tweening.Core.DOSetter<System.Single> val_3 = new DG.Tweening.Core.DOSetter<System.Single>(object:  349519872, method:  new IntPtr(3650291296));
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
    private void SetTopAnchor(UnityEngine.RectTransform rectTransform)
    {
        UnityEngine.Rect val_1 = rect;
        float val_2 = width;
        UnityEngine.Rect val_3 = rect;
        float val_4 = height;
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_4, y:  val_3.m_YMin);
        rectTransform.anchorMin = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_4, y:  val_3.m_YMin);
        rectTransform.anchorMax = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
        UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_4, y:  val_3.m_YMin);
        rectTransform.pivot = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
        UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_4, y:  val_3.m_YMin);
        rectTransform.sizeDelta = new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
    }
    private void SetTopLeftAnchor(UnityEngine.RectTransform rectTransform)
    {
        UnityEngine.Rect val_1 = rect;
        float val_2 = width;
        UnityEngine.Rect val_3 = rect;
        float val_4 = height;
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_4, y:  val_3.m_YMin);
        rectTransform.anchorMin = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_4, y:  val_3.m_YMin);
        rectTransform.anchorMax = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
        UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_4, y:  val_3.m_YMin);
        rectTransform.pivot = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
        UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_4, y:  val_3.m_YMin);
        rectTransform.sizeDelta = new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
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
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -5.442434E+15f}, b:  new UnityEngine.Vector3() {y = val_3.x, z = val_3.y});
        UnityEngine.Vector3 val_5 = min;
        UnityEngine.Vector3 val_6 = new UnityEngine.Vector3(x:  val_5.x, y:  val_5.y);
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -5.442413E+15f}, b:  new UnityEngine.Vector3() {y = val_6.x, z = val_6.y});
        UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3(), to:  new UnityEngine.Vector3() {x = val_8, y = val_10, z = val_9});
        UnityEngine.Color val_11 = UnityEngine.Color.red;
        UnityEngine.Gizmos.color = new UnityEngine.Color();
        UnityEngine.Vector3 val_12 = max;
        UnityEngine.Vector3 val_13 = new UnityEngine.Vector3(x:  val_12.x, y:  val_12.y);
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -5.442383E+15f}, b:  new UnityEngine.Vector3() {y = val_13.x, z = val_13.y});
        UnityEngine.Vector3 val_15 = max;
        UnityEngine.Vector3 val_16 = new UnityEngine.Vector3(x:  val_15.x, y:  val_15.y);
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -5.442361E+15f}, b:  new UnityEngine.Vector3() {y = val_16.x, z = val_16.y});
        UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3(), to:  new UnityEngine.Vector3() {x = val_18, y = val_20, z = val_19});
    }

}
