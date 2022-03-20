using UnityEngine;
public abstract class RecyclingSystem
{
    // Fields
    protected UnityEngine.RectTransform Viewport;
    protected UnityEngine.RectTransform Content;
    protected UnityEngine.RectTransform PrototypeCell;
    protected bool IsGrid;
    protected float MinPoolCoverage;
    protected int MinPoolSize;
    protected float RecyclingThreshold;
    private float <CellWidth>k__BackingField;
    private float <CellHeight>k__BackingField;
    
    // Properties
    public float CellWidth { get; set; }
    public float CellHeight { get; set; }
    
    // Methods
    public abstract System.Collections.IEnumerator InitCoroutine(System.Action onInitialized, int startPos, bool centered = False); // 0
    public float get_CellWidth()
    {
        return (float)S0;
    }
    protected void set_CellWidth(float value)
    {
        this.<CellWidth>k__BackingField = ;
    }
    public float get_CellHeight()
    {
        return (float)S0;
    }
    protected void set_CellHeight(float value)
    {
        this.<CellHeight>k__BackingField = ;
    }
    public abstract UnityEngine.Vector2 OnValueChangedListener(UnityEngine.Vector2 direction); // 0
    public abstract DG.Tweening.Tween ScrollByAmountCell(float amountCell, float duration); // 0
    public abstract ICell FindCellByIndex(int Id); // 0
    protected RecyclingSystem()
    {
        this.MinPoolCoverage = 1.5f;
        this.MinPoolSize = 10;
        this.RecyclingThreshold = 0.2f;
    }

}
