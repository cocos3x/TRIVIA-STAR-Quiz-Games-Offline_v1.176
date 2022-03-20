using UnityEngine;
public class LineKeyboardInput : MonoBehaviour
{
    // Fields
    public LineDrawer lineDrawer;
    public TextPreview textPreview;
    private UnityEngine.LineRenderer lineRenderer;
    private UnityEngine.Vector3 mousePoint;
    private bool didValidInput;
    private bool cancelInput;
    private string invalidInputLetters;
    
    // Properties
    public System.Collections.Generic.List<int> currentIndexes { get; }
    public System.Collections.Generic.List<UnityEngine.Vector3> points { get; }
    public System.Collections.Generic.List<UnityEngine.Vector3> positions { get; }
    public System.Collections.Generic.List<bool> allowedPositions { get; }
    private System.Collections.Generic.List<UnityEngine.Vector3> letterPositions { get; }
    
    // Methods
    public System.Collections.Generic.List<int> get_currentIndexes()
    {
        if(this.lineDrawer != 0)
        {
                return;
        }
    
    }
    public System.Collections.Generic.List<UnityEngine.Vector3> get_points()
    {
        if(this.lineDrawer != 0)
        {
                return;
        }
    
    }
    public System.Collections.Generic.List<UnityEngine.Vector3> get_positions()
    {
        if(this.lineDrawer != 0)
        {
                return;
        }
    
    }
    public System.Collections.Generic.List<bool> get_allowedPositions()
    {
        if(this.lineDrawer != 0)
        {
                return;
        }
    
    }
    private System.Collections.Generic.List<UnityEngine.Vector3> get_letterPositions()
    {
        if(this.lineDrawer != 0)
        {
                return;
        }
    
    }
    private void Awake()
    {
        if(this.lineDrawer != 0)
        {
                return;
        }
        
        object val_2 = R4.GetComponent<System.Object>();
        mem2[0] = R4;
    }
    private void Start()
    {
        object val_1 = this.GetComponent<System.Object>();
        this.lineRenderer = this;
        this.sortingLayerName = -2084533408;
    }
    private bool SelectedEnabled(int letterIndex)
    {
        if(true <= letterIndex)
        {
                var val_1 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_1 = val_1 + letterIndex;
        return (bool)(0 + letterIndex) + 16;
    }
    private void Update()
    {
    
    }
    private void BuildPoints()
    {
        var val_3;
        System.Collections.Generic.List<UnityEngine.Vector3> val_7;
        LineDrawer val_8;
        System.Collections.Generic.List<UnityEngine.Vector3> val_9;
        LineDrawer val_10;
        this.lineDrawer.points.Clear();
        List.Enumerator<T> val_1 = GetEnumerator();
        label_12:
        if(MoveNext() == false)
        {
            goto label_5;
        }
        
        val_8 = this.lineDrawer;
        if(val_8 != 0)
        {
                val_9 = this.lineDrawer.points;
        }
        else
        {
                val_8 = this.lineDrawer;
            val_9 = 0;
            if(val_8 == 0)
        {
                val_8 = 0;
        }
        
        }
        
        if(0 <= val_3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_8 = 0;
        val_8 = val_8 + ((val_3 + (val_3 << 1)) << 2);
        val_9.Add(item:  new UnityEngine.Vector3() {x = (0 + ((val_3 + (val_3) << 1)) << 2) + 16, y = (0 + ((val_3 + (val_3) << 1)) << 2) + 20, z = (0 + ((val_3 + (val_3) << 1)) << 2) + 24});
        goto label_12;
        label_5:
        Dispose();
        label_29:
        if((-2081204184) != 1)
        {
                return;
        }
        
        val_10 = this.lineDrawer;
        if(this.lineDrawer == 0)
        {
                val_10 = this.lineDrawer;
            if(val_10 == 0)
        {
            goto label_26;
        }
        
        }
        
        val_7 = this.lineDrawer.points;
        if(val_10 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_5 = 0 + 16;
        UnityEngine.Vector3 val_6 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -1.430247E-36f, y = mem[(0 + 16) + (0)], z = mem[(0 + 16) + (4)]}, b:  new UnityEngine.Vector3() {x = mem[(0 + 16) + (8)], y = val_6.x, z = val_6.y});
        val_7.Add(item:  new UnityEngine.Vector3());
        return;
        label_26:
        if((public System.Void List.Enumerator<System.Int32>::Dispose()) != 1)
        {
            goto label_27;
        }
        
        Dispose();
        if(null == 0)
        {
            goto label_29;
        }
        
        goto label_29;
        label_27:
    }
    public void CancelInput(bool force = False)
    {
        if(force == false)
        {
                return;
        }
        
        this.cancelInput = true;
    }
    public LineKeyboardInput()
    {
        this.invalidInputLetters = "àáèéìíòóùúñ";
    }

}
