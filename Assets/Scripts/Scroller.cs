using UnityEngine;
public class Scroller : MonoBehaviour
{
    // Fields
    public ScrollerIteam[] ScrollingItems;
    public bool isWindStart;
    public float windStart;
    public float windStartTime;
    public bool isWindEnd;
    public float windEnd;
    public float windEndTime;
    private bool scrollHorizontal;
    private bool invertScroll;
    private System.Collections.Generic.List<ScrollerIteam> <ScrollingItemsList>k__BackingField;
    private float <itemSpace>k__BackingField;
    private bool <isScrolling>k__BackingField;
    private UnityEngine.UI.HorizontalOrVerticalLayoutGroup layoutGroup;
    private float movedDistance;
    private float moveNeed;
    private UnityEngine.Vector3 moveNeedV3;
    private float movedItemSpace;
    private System.Collections.Generic.List<ScrollerIteamData> iteamsmData;
    private int iteamDataIndex;
    private System.Action<ScrollerIteam> onScrolledIteam;
    
    // Properties
    public System.Collections.Generic.List<ScrollerIteam> ScrollingItemsList { get; set; }
    public float itemSpace { get; set; }
    public int iteamCount { get; }
    public bool isScrolling { get; set; }
    
    // Methods
    public System.Collections.Generic.List<ScrollerIteam> get_ScrollingItemsList()
    {
    
    }
    private void set_ScrollingItemsList(System.Collections.Generic.List<ScrollerIteam> value)
    {
        this.<ScrollingItemsList>k__BackingField = value;
    }
    public float get_itemSpace()
    {
        return (float)S0;
    }
    private void set_itemSpace(float value)
    {
        this.<itemSpace>k__BackingField = ;
    }
    public int get_iteamCount()
    {
        if(this.ScrollingItems != null)
        {
                return (int)this;
        }
        
        return (int)this;
    }
    public bool get_isScrolling()
    {
        return (bool)this.<isScrolling>k__BackingField;
    }
    private void set_isScrolling(bool value)
    {
        this.<isScrolling>k__BackingField = value;
    }
    private void Awake()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        object val_2 = this.GetComponent<System.Object>();
        this.layoutGroup = this;
        this.<isScrolling>k__BackingField = false;
    }
    private void Start()
    {
        this.layoutGroup.enabled = false;
    }
    public void Init()
    {
        var val_3;
        var val_6;
        var val_8;
        var val_11;
        var val_13;
        var val_14;
        var val_15;
        UnityEngine.Transform val_1 = this.ScrollingItems[0].transform;
        if(this.scrollHorizontal != false)
        {
                UnityEngine.Vector3 val_2 = localPosition;
            val_13 = val_3;
            UnityEngine.Transform val_4 = this.ScrollingItems[1].transform;
            UnityEngine.Vector3 val_5 = localPosition;
            val_14 = 1152921504762277888;
            val_15 = val_6;
        }
        else
        {
                UnityEngine.Vector3 val_7 = localPosition;
            val_13 = val_8;
            UnityEngine.Transform val_9 = this.ScrollingItems[1].transform;
            UnityEngine.Vector3 val_10 = localPosition;
            val_14 = 1152921504762277888;
            val_15 = val_11;
        }
        
        this.<itemSpace>k__BackingField = System.Math.Abs(val_13 - val_15);
    }
    public void Init(System.Action<ScrollerIteam> onScrolledIteamChange)
    {
        this.onScrolledIteam = onScrolledIteamChange;
    }
    public void Init(System.Action<ScrollerIteam> onScrolledIteamChange, bool scrollDir)
    {
        this.onScrolledIteam = onScrolledIteamChange;
        this.scrollHorizontal = scrollDir;
    }
    public void Init(System.Action<ScrollerIteam> onScrolledIteamChange, bool scrollDir, bool invert)
    {
        this.scrollHorizontal = scrollDir;
        this.invertScroll = invert;
        this.onScrolledIteam = onScrolledIteamChange;
    }
    public void SetWind(float start = 0, float end = 0)
    {
        this.windEnd = ;
        this.windStart = ;
    }
    public void InitScrollerIteam<T>(System.Collections.Generic.List<T> data)
    {
        var val_1 = 0;
        goto label_0;
        label_8:
        if(val_1 < data)
        {
            
        }
        
        val_1 = 1;
        label_0:
        if(val_1 < this.ScrollingItems[val_1])
        {
            goto label_8;
        }
    
    }
    public void SetData<T>(System.Collections.Generic.List<T> data, bool invert = False, float windStartDis = -1, float windEndDis = -1)
    {
        var val_1;
        float val_2;
        ScrollerIteamData val_11;
        var val_12;
        ScrollerIteam val_13;
        val_11 = data;
        val_12 = val_1;
        this.iteamsmData.Clear();
        val_13 = 0;
        goto label_2;
        label_6:
        this.iteamsmData.Add(item:  val_11);
        val_13 = 1;
        label_2:
        if(val_13 < val_11)
        {
            goto label_6;
        }
        
        this.iteamDataIndex = 0;
        if((this.iteamsmData == 0) || (this.iteamsmData < 1))
        {
            goto label_21;
        }
        
        if(invert == false)
        {
            goto label_9;
        }
        
        val_12 = 0;
        goto label_10;
        label_18:
        val_11 = 0;
        val_13 = this.ScrollingItems[val_12];
        if(this.ScrollingItems[val_12] <= val_11)
        {
                var val_11 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_11 = val_11 + 0;
        int val_12 = this.iteamDataIndex;
        val_12 = 1;
        val_12 = val_12 + 1;
        this.iteamDataIndex = val_12;
        label_10:
        if(val_12 < val_12)
        {
            goto label_18;
        }
        
        goto label_21;
        label_9:
        System.Collections.Generic.List<ScrollerIteamData> val_3 = this.iteamsmData - 1;
        if(val_3 >= 0)
        {
                System.Collections.Generic.List<ScrollerIteamData> val_4 = this.iteamsmData + 3;
            do
        {
            System.Collections.Generic.List<ScrollerIteamData> val_5 = val_4 - 4;
            val_11 = val_3;
            if(this.iteamDataIndex <= val_11)
        {
                var val_13 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_13 = val_13 + (val_11 << 2);
            System.Collections.Generic.List<ScrollerIteamData> val_8 = val_4 - 1;
            this.iteamDataIndex = this.iteamDataIndex + 1;
        }
        while((val_4 - 5) > 1);
        
        }
        
        label_21:
        this.invertScroll = invert;
        this.layoutGroup.enabled = true;
        this.movedItemSpace = 0f;
        this.movedDistance = 0f;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        if(UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished > 0)
        {
                this.windStart = __RuntimeMethodHiddenParam;
        }
        
        if(UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished > 0)
        {
                this.windEnd = val_2;
        }
        
        System.Collections.Generic.List<ZooTile> val_10 = new System.Collections.Generic.List<ZooTile>(collection:  this.ScrollingItems);
        this.<ScrollingItemsList>k__BackingField = null;
    }
    public void StartSpin(int scrollCount, float duration = 1, DG.Tweening.TweenCallback callback)
    {
        System.Collections.IEnumerator val_1 = this.ActuallyStartSpin(scrollCount:  scrollCount, duration:  duration, callback:  callback);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -638846560);
    }
    private System.Collections.IEnumerator ActuallyStartSpin(int scrollCount, float duration = 1, DG.Tweening.TweenCallback callback)
    {
        typeof(Scroller.<ActuallyStartSpin>d__41).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(Scroller.<ActuallyStartSpin>d__41).__il2cppRuntimeField_18 = scrollCount;
            typeof(Scroller.<ActuallyStartSpin>d__41).__il2cppRuntimeField_10 = this;
            typeof(Scroller.<ActuallyStartSpin>d__41).__il2cppRuntimeField_20 = callback;
        }
        else
        {
                mem[16] = this;
            mem[24] = scrollCount;
            mem[32] = callback;
        }
        
        typeof(Scroller.<ActuallyStartSpin>d__41).__il2cppRuntimeField_14 = R3;
    }
    private void UpdatePosition(float totalDistance)
    {
        float val_11;
        var val_12;
        System.Collections.Generic.List<ScrollerIteamData> val_13;
        float val_14;
        float val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        float val_12 = this.movedDistance;
        val_11 = 4;
        val_12 = 0;
        val_12 = R1 - val_12;
        float val_13 = this.movedItemSpace;
        val_13 = val_12 + val_13;
        this.moveNeed = val_12;
        if(this.invertScroll == true)
        {
                val_12 = -val_12;
        }
        
        this.movedItemSpace = val_13;
        if(this.invertScroll == true)
        {
                this.moveNeed = val_12;
        }
        
        if(this.scrollHorizontal == false)
        {
                mem[1152921512558224616] = val_12;
        }
        
        if(this.scrollHorizontal == true)
        {
                this.moveNeedV3 = val_12;
        }
        
        goto label_1;
        label_13:
        if(1152921512558224616 <= R6)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Transform val_1 = 2621443.transform;
        val_13 = 2621443;
        if(2621443 <= R6)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Transform val_2 = 2621443.transform;
        UnityEngine.Vector3 val_3 = localPosition;
        val_14 = mem[1152921512558224616];
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -8.451602E+15f}, b:  new UnityEngine.Vector3() {y = this.moveNeedV3, z = val_14});
        val_13.localPosition = new UnityEngine.Vector3();
        val_11 = 5;
        label_1:
        val_15 = val_11 - 4;
        if(val_15 < val_13)
        {
            goto label_13;
        }
        
        if(val_15 > val_13)
        {
                val_12 = 0;
            do
        {
            float val_14 = (float)this.movedItemSpace;
            if(this.scrollHorizontal == false)
        {
                68 = 72;
        }
        
            val_14 = (this.<itemSpace>k__BackingField) * val_14;
            mem[1152921512558224616] = val_14;
            if(this.invertScroll != false)
        {
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -8.451609E+15f, y = this.moveNeedV3, z = mem[1152921512558224616]}, d:  val_14);
            this.moveNeedV3 = new UnityEngine.Vector3();
            mem[1152921512558224616] = ???;
            mem[1152921512558224620] = ???;
            if(1152921512558224616 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_11 = 3.673424E-39f;
            this.<ScrollingItemsList>k__BackingField.RemoveAt(index:  0);
            this.<ScrollingItemsList>k__BackingField.Add(item:  2621443);
        }
        else
        {
                if((this.<ScrollingItemsList>k__BackingField) != 0)
        {
                val_17 = this.invertScroll;
        }
        else
        {
                val_17 = 0;
            val_16 = 0;
        }
        
            if(val_16 <= (-1))
        {
                var val_15 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_15 = val_15 + 4294967292;
            val_11 = mem[(0 + 4294967292) + 16];
            val_11 = (0 + 4294967292) + 16;
            if((this.<ScrollingItemsList>k__BackingField) != 0)
        {
            
        }
        else
        {
                val_18 = 0;
        }
        
            this.<ScrollingItemsList>k__BackingField.RemoveAt(index:  val_18 - 1);
            this.<ScrollingItemsList>k__BackingField.Insert(index:  0, item:  val_11);
        }
        
            if(val_11 != 0)
        {
                UnityEngine.Transform val_7 = val_11.transform;
            val_14 = val_11;
            val_19 = val_11;
        }
        else
        {
                val_19 = 0;
            UnityEngine.Transform val_8 = 0.transform;
            val_14 = 0;
        }
        
            UnityEngine.Transform val_9 = val_19.transform;
            UnityEngine.Vector3 val_10 = localPosition;
            val_15 = mem[1152921512558224616];
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -8.451602E+15f}, b:  new UnityEngine.Vector3() {y = this.moveNeedV3, z = val_15});
            val_14.localPosition = new UnityEngine.Vector3();
            val_13 = this.iteamsmData;
            if((val_13 != 0) && (val_14 >= 1))
        {
                if(val_15 <= val_15)
        {
                var val_16 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_16 = val_16 + (val_15 << 2);
            int val_17 = this.iteamDataIndex;
            val_17 = val_17 + 1;
            this.iteamDataIndex = val_17;
        }
        
            if(this.onScrolledIteam != 0)
        {
                this.onScrolledIteam.Invoke(obj:  val_11);
        }
        
            float val_18 = this.movedItemSpace;
            val_18 = val_18 - (this.<itemSpace>k__BackingField);
            this.movedItemSpace = val_18;
        }
        while(this.onScrolledIteam > 0);
        
        }
        
        this.movedDistance = R1;
    }
    public Scroller()
    {
        this.windEndTime = 0.5f;
        this.windStartTime = 0.5f;
        this.scrollHorizontal = true;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.iteamsmData = null;
    }

}
