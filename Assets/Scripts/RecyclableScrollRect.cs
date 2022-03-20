using UnityEngine;
public class RecyclableScrollRect : ScrollRect
{
    // Fields
    public IRecyclableScrollRectDataSource DataSource;
    public bool IsGrid;
    public UnityEngine.RectTransform PrototypeCell;
    public bool SelfInitialize;
    public RecyclableScrollRect.DirectionType Direction;
    public RecyclableScrollRect.CellPositionType CellType;
    private int _segments;
    private RecyclingSystem _recyclableScrollRect;
    private UnityEngine.Vector2 _prevAnchoredPos;
    
    // Properties
    public int Segments { get; set; }
    
    // Methods
    public void set_Segments(int value)
    {
        this._segments = System.Math.Max(val1:  value, val2:  2);
    }
    public int get_Segments()
    {
        return (int)this._segments;
    }
    protected override void Start()
    {
        mem[1152921512548500144] = 256;
        bool val_1 = UnityEngine.Application.isPlaying;
        if(val_1 == true)
        {
                val_1 = this.SelfInitialize;
        }
        
        if(val_1 == false)
        {
                return;
        }
        
        R4.Initialize();
    }
    private void Initialize()
    {
        UnityEngine.Vector2 val_4;
        var val_5;
        HorizontalRecyclingSystem val_11;
        var val_12;
        if(this.Direction == 0)
        {
            goto label_1;
        }
        
        if(this.Direction != 1)
        {
            goto label_2;
        }
        
        val_11 = null;
        val_11 = new HorizontalRecyclingSystem(prototypeCell:  this.PrototypeCell, viewport:  SB, content:  ???, dataSource:  this.DataSource, isGrid:  this.IsGrid, rows:  this._segments);
        goto label_3;
        label_1:
        val_11 = null;
        UnityEngine.RectTransform val_12 = this.PrototypeCell;
        val_11 = new VerticalRecyclingSystem(prototypeCell:  val_12, viewport:  SB, content:  ???, dataSource:  this.DataSource, isGrid:  this.IsGrid, coloumns:  this._segments);
        label_3:
        this._recyclableScrollRect = val_11;
        label_2:
        DirectionType val_11 = this.Direction;
        val_11 = val_11 - 1;
        val_12 = val_12 >> 5;
        val_11 = val_11 >> 5;
        mem[1152921512548653105] = val_12;
        mem[1152921512548653104] = val_11;
        UnityEngine.Vector2 val_3 = anchoredPosition;
        this._prevAnchoredPos = val_4;
        mem[1152921512548653364] = val_5;
        UnityEngine.Events.UnityAction<UnityEngine.Vector2> val_6 = new UnityEngine.Events.UnityAction<UnityEngine.Vector2>(object:  -648128480, method:  new IntPtr(3646798432));
        RemoveListener(call:  162353152);
        System.Action val_7 = new System.Action(object:  -648128480, method:  new IntPtr(3646809696));
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_12 = this.DataSource;
        CellPositionType val_9 = (this.CellType - 1) >> 5;
        UnityEngine.Coroutine val_10 = this.StartCoroutine(routine:  this._recyclableScrollRect);
    }
    public void Initialize(IRecyclableScrollRectDataSource dataSource)
    {
        this.DataSource = dataSource;
        this.Initialize();
    }
    public void OnValueChangedListener(UnityEngine.Vector2 normalizedPos)
    {
        float val_2;
        float val_3;
        float val_8;
        var val_10;
        var val_11;
        UnityEngine.Vector2 val_13;
        var val_14;
        UnityEngine.Vector2 val_1 = anchoredPosition;
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = -3.98161E+15f, y = val_2}, b:  new UnityEngine.Vector2() {x = val_3, y = this._prevAnchoredPos});
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = -3.981605E+15f, y = R8}, b:  new UnityEngine.Vector2() {x = SB, y = val_8});
        mem[1152921512548926320] = val_10;
        mem[1152921512548926324] = val_11;
        UnityEngine.Vector2 val_12 = anchoredPosition;
        this._prevAnchoredPos = val_13;
        mem[1152921512548926516] = val_14;
    }
    public DG.Tweening.Sequence ScrollByAmountCell(float amountCell, float duration, DG.Tweening.Ease ease = 7)
    {
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        object val_2 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this._recyclableScrollRect, ease:  R3);
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this._recyclableScrollRect);
    }
    public ICell FindCellByIndex(int Id)
    {
        if(this._recyclableScrollRect == 0)
        {
            
        }
    
    }
    public RecyclableScrollRect()
    {
        this.SelfInitialize = true;
    }
    private void <Initialize>b__15_0()
    {
        UnityEngine.Events.UnityAction<UnityEngine.Vector2> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.Vector2>(object:  -647376608, method:  new IntPtr(3646798432));
        static_value_021FAB63.AddListener(call:  162353152);
    }

}
