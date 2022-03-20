using UnityEngine;
public class UGUIPageDisplay : MonoBehaviour
{
    // Fields
    public int maxPageDots;
    private UnityEngine.GameObject pageDotPrefab;
    private UnityEngine.Transform dotGridTransform;
    private UnityEngine.UI.HorizontalLayoutGroup dotControlGroup;
    private UnityEngine.UI.Button button_left;
    private UnityEngine.UI.Button button_right;
    private UnityEngine.GameObject[] pages;
    private UnityEngine.UI.Text pageNumbering;
    private bool refreshOnEnable;
    private bool hideControlls;
    private int currentPageIndex;
    private System.Collections.Generic.List<UnityEngine.UI.Button> pageDots;
    public System.Action<int> PageIndexChanged;
    private int numPages;
    
    // Properties
    public int NumPages { get; set; }
    
    // Methods
    public int get_NumPages()
    {
        if(this.numPages != 1)
        {
                return (int)this.numPages;
        }
        
        if(this.pages != null)
        {
                return (int)this.numPages;
        }
        
        return (int)this.numPages;
    }
    public void set_NumPages(int value)
    {
        this.numPages = value;
    }
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_5;
        if(this.button_left != 0)
        {
                val_5 = null;
            val_5 = new UnityEngine.Events.UnityAction(object:  -177892624, method:  new IntPtr(4117036336));
            this.button_left.m_OnClick.AddListener(call:  162246656);
        }
        
        if(this.button_right != 0)
        {
                val_5 = null;
            val_5 = new UnityEngine.Events.UnityAction(object:  -177892624, method:  new IntPtr(4117049648));
            this.button_right.m_OnClick.AddListener(call:  162246656);
        }
        
        this.CreatePageDots();
    }
    public void Load(System.Collections.Generic.List<UnityEngine.GameObject> pages)
    {
        T[] val_1 = pages.ToArray();
        this.pages = pages;
        this.CreatePageDots();
        goto typeof(UGUIPageDisplay).__il2cppRuntimeField_DC;
    }
    private void CreatePageDots()
    {
    
    }
    private void OnEnable()
    {
        UnityEngine.GameObject val_1 = this.dotControlGroup.gameObject;
        if(this.dotControlGroup.activeSelf == true)
        {
                return;
        }
        
        System.Collections.IEnumerator val_3 = R4.EnableControlsGroupAfterFrame();
        UnityEngine.Coroutine val_4 = R4.StartCoroutine(routine:  R4);
    }
    private System.Collections.IEnumerator EnableControlsGroupAfterFrame()
    {
        object val_1 = new System.Object();
        typeof(UGUIPageDisplay.<EnableControlsGroupAfterFrame>d__21).__il2cppRuntimeField_8 = 0;
        typeof(UGUIPageDisplay.<EnableControlsGroupAfterFrame>d__21).__il2cppRuntimeField_10 = this;
    }
    public void PageLeft()
    {
        int val_1 = this.currentPageIndex;
        val_1 = val_1 - 1;
        goto typeof(UGUIPageDisplay).__il2cppRuntimeField_DC;
    }
    public void PageRight()
    {
        int val_1 = this.currentPageIndex;
        val_1 = val_1 + 1;
        goto typeof(UGUIPageDisplay).__il2cppRuntimeField_DC;
    }
    public void SetToPage(int index, bool force = False)
    {
        goto typeof(UGUIPageDisplay).__il2cppRuntimeField_DC;
    }
    protected virtual void SetPage(int index, bool force = False)
    {
        UnityEngine.GameObject[] val_14;
        int val_15;
        int val_16;
        int val_17;
        int val_18;
        int val_19;
        var val_20;
        int val_21;
        val_14 = index;
        this.CreatePageDots();
        val_15 = this.numPages;
        val_16 = val_14 & (~(val_14 >> 31));
        if(val_15 == 1)
        {
                val_14 = this.pages;
        }
        
        val_15 = val_15 - 1;
        if(val_16 > val_15)
        {
                val_17 = this.numPages;
            if(val_17 == 1)
        {
                val_14 = this.pages;
        }
        
            val_16 = val_17 - 1;
        }
        
        if(force == false)
        {
                return;
        }
        
        val_18 = this.numPages;
        if((val_18 <= this.maxPageDots) || (this.pageNumbering == 0))
        {
            goto label_12;
        }
        
        string val_3 = val_16 + 1.ToString(format:  -1827641632);
        val_19 = this.numPages;
        string val_4 = val_19.ToString(format:  -1827641632);
        string val_5 = System.String.Format(format:  1629069648, arg0:  -176101396, arg1:  -176101396);
        if(this.pageNumbering != 0)
        {
            goto label_16;
        }
        
        goto label_16;
        label_12:
        val_20 = 0;
        goto label_17;
        label_28:
        if(val_18 > val_20)
        {
                UnityEngine.GameObject val_12 = this.pages[val_20];
            val_12.SetActive(value:  (val_16 - val_20) >> 5);
        }
        
        if(val_12 <= val_20)
        {
                var val_13 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_13 = val_13 + 0;
        if(((0 + 0) + 16) != 0)
        {
                val_16 - val_20 = 1;
        }
        
        (0 + 0) + 16.interactable = true;
        val_20 = 1;
        label_17:
        val_21 = this.numPages;
        if(val_20 < val_21)
        {
            goto label_28;
        }
        
        label_16:
        this.currentPageIndex = val_16;
        val_14 = 1152921504765685760;
        if((UnityEngine.Object.op_Implicit(exists:  this.button_left)) != false)
        {
                val_16 = this.currentPageIndex;
            if(val_16 > 0)
        {
                0 = 1;
        }
        
            this.button_left.interactable = true;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.button_right)) != false)
        {
                val_16 = this.numPages;
            val_14 = this.currentPageIndex;
            if(val_14 < (this.pages - 1))
        {
                0 = 1;
        }
        
            this.button_right.interactable = true;
        }
        
        if(this.PageIndexChanged == 0)
        {
                return;
        }
        
        this.PageIndexChanged.Invoke(obj:  this.currentPageIndex);
    }
    public UGUIPageDisplay()
    {
        this.refreshOnEnable = true;
        this.maxPageDots = 4;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.numPages = 0;
        this.pageDots = null;
    }

}
