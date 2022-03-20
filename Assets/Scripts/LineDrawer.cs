using UnityEngine;
public class LineDrawer : MonoBehaviour
{
    // Fields
    public const string Event_OnEnableAllLetters = "OnEnableAllLetters";
    public System.Collections.Generic.List<UnityEngine.Vector3> letterPositions;
    public System.Collections.Generic.List<bool> allowedPositions;
    public System.Collections.Generic.List<int> currentIndexes;
    public System.Collections.Generic.List<UnityEngine.Vector3> points;
    public System.Collections.Generic.List<UnityEngine.Vector3> positions;
    public TextPreview textPreview;
    private UnityEngine.LineRenderer lineRenderer;
    private UnityEngine.Vector2 mousePoint;
    public static LineDrawer instance;
    private bool isDragging;
    private int downOnIndex;
    public LineDrawerParticles lineDrawerParticles;
    
    // Methods
    private void Awake()
    {
        LineDrawer.instance = this;
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -2084734432, name:  -2084758544);
    }
    private void OnEnableAllLetters()
    {
        this.AllowAll();
    }
    private void Start()
    {
        object val_1 = this.GetComponent<System.Object>();
        this.lineRenderer = this;
        this.sortingLayerName = -2084533408;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2084533312) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.lineRenderer.startColor = new UnityEngine.Color() {r = public static ThemesHandler MonoSingleton<ThemesHandler>::get_Instance().__il2cppRuntimeField_10 + 16 + 8, g = public static ThemesHandler MonoSingleton<ThemesHandler>::get_Instance().__il2cppRuntimeField_10 + 16 + 12, b = public static ThemesHandler MonoSingleton<ThemesHandler>::get_Instance().__il2cppRuntimeField_10 + 16 + 16, a = public static ThemesHandler MonoSingleton<ThemesHandler>::get_Instance().__il2cppRuntimeField_10 + 16 + 20};
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.lineRenderer.endColor = new UnityEngine.Color() {r = public static ThemesHandler MonoSingleton<ThemesHandler>::get_Instance().__il2cppRuntimeField_10 + 16 + 8, g = public static ThemesHandler MonoSingleton<ThemesHandler>::get_Instance().__il2cppRuntimeField_10 + 16 + 12, b = public static ThemesHandler MonoSingleton<ThemesHandler>::get_Instance().__il2cppRuntimeField_10 + 16 + 16, a = public static ThemesHandler MonoSingleton<ThemesHandler>::get_Instance().__il2cppRuntimeField_10 + 16 + 20};
        }
        
        WordRegion val_6 = WordRegion.instance;
        UnityEngine.Events.UnityAction val_7 = new UnityEngine.Events.UnityAction(object:  -2084499072, method:  new IntPtr(2210443200));
        2.AddListener(call:  162246656);
    }
    private bool NearestEnabled(int letterIndex)
    {
        if(true < 1)
        {
                return false;
        }
        
        if(true <= letterIndex)
        {
                var val_1 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_1 = val_1 + letterIndex;
        if(((0 + letterIndex) + 16) != 0)
        {
                (0 + letterIndex) + 16 = 1;
        }
        
        return true;
    }
    private void AllowAll()
    {
        goto label_1;
        label_4:
        this.allowedPositions.set_Item(index:  0, value:  true);
        0 = 1;
        label_1:
        if(0 < this.allowedPositions)
        {
            goto label_4;
        }
    
    }
    public void BeginDrag()
    {
        MainController val_1 = MainController.instance;
        if(3 != 0)
        {
                return;
        }
        
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -2084145088);
        mem2[0] = 1;
    }
    public void DoDrag(UnityEngine.Vector2 mousePos)
    {
        float val_10;
        bool val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        val_10 = mousePos.x;
        MainController val_1 = MainController.instance;
        val_11 = 0;
        if(3 != 0)
        {
                return;
        }
        
        this.mousePoint = mousePos;
        mem[1152921511112851564] = mousePos.y;
        val_12 = 1152921504886505472;
        val_11 = Pan.tappingAllowed;
        int val_2 = val_11.IsInRectofAnyTile(mousePos:  new UnityEngine.Vector2() {x = val_10, y = mousePos.y});
        if(val_2 == 1)
        {
            goto label_36;
        }
        
        bool val_3 = this.NearestEnabled(letterIndex:  val_2);
        if(val_3 == false)
        {
            goto label_36;
        }
        
        if(val_3 < true)
        {
            goto label_13;
        }
        
        if(this.currentIndexes != 0)
        {
                val_14 = val_3;
        }
        else
        {
                val_14 = 0;
            val_13 = 0;
        }
        
        val_11 = -2;
        if(val_13 <= val_11)
        {
                var val_11 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_11 = val_11 + 4294967288;
        if(((0 + 4294967288) + 16) != val_2)
        {
            goto label_13;
        }
        
        if(this.currentIndexes == 0)
        {
            goto label_14;
        }
        
        val_16 = Pan.__il2cppRuntimeField_static_fields;
        goto label_15;
        label_13:
        if((this.currentIndexes.Contains(item:  val_2)) == true)
        {
            goto label_26;
        }
        
        Pan.tappingAllowed.HighlightLetter(i:  val_2, state:  true);
        this.currentIndexes.Add(item:  val_2);
        this.textPreview.SetIndexes(indexes:  this.currentIndexes);
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -2084000224, clipIndex:  this.currentIndexes - 1);
        goto label_26;
        label_14:
        val_12 = 12;
        val_16 = 0;
        val_15 = 0;
        label_15:
        val_11 = -1;
        if(val_15 <= val_11)
        {
                var val_12 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_12 = val_12 + 4294967292;
        Pan.tappingAllowed.HighlightLetter(i:  (0 + 4294967292) + 16, state:  false);
        if(this.currentIndexes != 0)
        {
            
        }
        else
        {
                val_17 = 0;
        }
        
        this.currentIndexes.RemoveAt(index:  val_17 - 1);
        this.textPreview.SetIndexes(indexes:  this.currentIndexes);
        label_26:
        if(this.currentIndexes >= 1)
        {
                this.textPreview.SetActive(isActive:  true, useButtons:  false);
            this.textPreview.FadeIn();
        }
        else
        {
                this.textPreview.SetActive(isActive:  false, useButtons:  false);
        }
        
        label_36:
        this.BuildPoints(includeMousePoint:  true);
        if(this < 2)
        {
                return;
        }
        
        if(this.isDragging == false)
        {
                return;
        }
        
        T[] val_8 = this.points.ToArray();
        System.Collections.Generic.List<UnityEngine.Vector3> val_9 = iTween.GetSmoothPoints(points:  this.points, smooth:  8);
        this.positions = this.points;
        this.lineRenderer.positionCount = this.points;
        T[] val_10 = this.positions.ToArray();
        this.lineRenderer.SetPositions(positions:  this.positions);
    }
    public void EndDrag(bool checkAnswer = True)
    {
        TextPreview val_4 = this.textPreview;
        if(val_4.IsInvisibleOrFading() != false)
        {
                return;
        }
        
        if(checkAnswer != false)
        {
                WordRegion val_2 = WordRegion.instance;
            string val_3 = this.textPreview.GetText();
            val_4 = this.textPreview;
            if(0 != 0)
        {
            goto label_8;
        }
        
        }
        else
        {
                this.textPreview.FadeOut();
        }
        
        label_8:
        this.isDragging = false;
        this.currentIndexes.Clear();
        this.lineRenderer.positionCount = 0;
        Pan.tappingAllowed.UnhighlightAllLetters();
    }
    public void DoPointerDown(UnityEngine.Vector2 mousePos)
    {
        float val_9;
        bool val_10;
        val_9 = mousePos.x;
        MainController val_1 = MainController.instance;
        if(true == 0)
        {
                true = this.isDragging;
        }
        
        if(true != false)
        {
                return;
        }
        
        this.downOnIndex = 0;
        this.mousePoint = mousePos;
        mem[1152921511113252716] = mousePos.y;
        val_10 = Pan.tappingAllowed;
        int val_2 = val_10.IsInRectofAnyTile(mousePos:  new UnityEngine.Vector2() {x = val_9, y = mousePos.y});
        if(val_2 != 1)
        {
                bool val_3 = this.NearestEnabled(letterIndex:  val_2);
            if(val_3 != false)
        {
                if(val_3 != true)
        {
                Pan.tappingAllowed.HighlightLetter(i:  val_2, state:  true);
            this.currentIndexes.Add(item:  val_2);
            this.textPreview.SetIndexes(indexes:  this.currentIndexes);
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -2084000224, clipIndex:  this.currentIndexes - 1);
            this.downOnIndex = val_2;
        }
        
            if(this.currentIndexes >= 1)
        {
                this.textPreview.SetActive(isActive:  true, useButtons:  false);
            this.textPreview.FadeIn();
        }
        else
        {
                this.textPreview.SetActive(isActive:  false, useButtons:  false);
        }
        
        }
        
        }
        
        this.BuildPoints(includeMousePoint:  false);
        if(this < 2)
        {
                this.lineRenderer.positionCount = 0;
            return;
        }
        
        T[] val_6 = this.points.ToArray();
        System.Collections.Generic.List<UnityEngine.Vector3> val_7 = iTween.GetSmoothPoints(points:  this.points, smooth:  8);
        this.positions = this.points;
        this.lineRenderer.positionCount = this.points;
        T[] val_8 = this.positions.ToArray();
        this.lineRenderer.SetPositions(positions:  this.positions);
    }
    public void DoPointerUp(UnityEngine.Vector2 mousePos)
    {
        float val_14;
        var val_15;
        bool val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        val_14 = mousePos.x;
        MainController val_1 = MainController.instance;
        if(true == 0)
        {
                true = this.isDragging;
        }
        
        if(true != false)
        {
                return;
        }
        
        this.mousePoint = mousePos;
        mem[1152921511113530604] = mousePos.y;
        val_15 = 1152921504886505472;
        val_16 = Pan.tappingAllowed;
        int val_2 = val_16.IsInRectofAnyTile(mousePos:  new UnityEngine.Vector2() {x = val_14, y = mousePos.y});
        if(val_2 == 1)
        {
            goto label_51;
        }
        
        bool val_3 = this.NearestEnabled(letterIndex:  val_2);
        if(val_3 == false)
        {
            goto label_51;
        }
        
        if(val_3 >= true)
        {
                if(this.currentIndexes != 0)
        {
                val_18 = val_3;
        }
        else
        {
                val_19 = 12;
            val_18 = 0;
            val_17 = 0;
        }
        
            val_16 = -1;
            if(val_17 <= val_16)
        {
                var val_15 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_15 = val_15 + 4294967292;
            if(((0 + 4294967292) + 16) == val_2)
        {
                if(this.downOnIndex != val_2)
        {
            goto label_14;
        }
        
        }
        
        }
        
        if((this.downOnIndex < 2) || ((this.currentIndexes.Contains(item:  val_2)) == false))
        {
            goto label_18;
        }
        
        val_19 = this.currentIndexes.IndexOf(item:  val_2);
        val_20 = 0;
        goto label_20;
        label_25:
        var val_16 = 0;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_16 = val_16 + 0;
        val_16 = mem[(0 + 0) + 16];
        val_16 = (0 + 0) + 16;
        if(val_20 <= val_19)
        {
                0 = 1;
        }
        
        Pan.tappingAllowed.HighlightLetter(i:  val_16, state:  true);
        val_20 = 1;
        label_20:
        if(val_20 < Pan.tappingAllowed)
        {
            goto label_25;
        }
        
        if(this.currentIndexes == 0)
        {
            goto label_26;
        }
        
        goto label_27;
        label_18:
        if((this.currentIndexes.Contains(item:  val_2)) == true)
        {
            goto label_38;
        }
        
        Pan.tappingAllowed.HighlightLetter(i:  val_2, state:  true);
        this.currentIndexes.Add(item:  val_2);
        this.textPreview.SetIndexes(indexes:  this.currentIndexes);
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -2084000224, clipIndex:  this.currentIndexes - 1);
        goto label_38;
        label_14:
        if(this.currentIndexes == 0)
        {
            goto label_39;
        }
        
        val_23 = Pan.__il2cppRuntimeField_static_fields;
        goto label_40;
        label_26:
        val_21 = 0;
        label_27:
        this.currentIndexes.RemoveRange(index:  val_19 + 1, count:  val_21 + (~val_19));
        goto label_41;
        label_39:
        val_15 = 12;
        val_23 = 0;
        val_22 = 0;
        label_40:
        val_16 = -1;
        if(val_22 <= val_16)
        {
                var val_17 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_17 = val_17 + 4294967292;
        Pan.tappingAllowed.HighlightLetter(i:  (0 + 4294967292) + 16, state:  false);
        if(this.currentIndexes != 0)
        {
            
        }
        else
        {
                val_24 = 0;
        }
        
        this.currentIndexes.RemoveAt(index:  val_24 - 1);
        label_41:
        this.textPreview.SetIndexes(indexes:  this.currentIndexes);
        label_38:
        if(this.currentIndexes >= 1)
        {
                this.textPreview.SetActive(isActive:  true, useButtons:  true);
            this.textPreview.FadeIn();
        }
        else
        {
                this.textPreview.SetActive(isActive:  false, useButtons:  false);
        }
        
        label_51:
        this.BuildPoints(includeMousePoint:  false);
        if(this < 2)
        {
                this.lineRenderer.positionCount = 0;
            return;
        }
        
        T[] val_12 = this.points.ToArray();
        System.Collections.Generic.List<UnityEngine.Vector3> val_13 = iTween.GetSmoothPoints(points:  this.points, smooth:  8);
        this.positions = this.points;
        this.lineRenderer.positionCount = this.points;
        T[] val_14 = this.positions.ToArray();
        this.lineRenderer.SetPositions(positions:  this.positions);
    }
    private void BuildPoints(bool includeMousePoint = True)
    {
        var val_3;
        float val_8;
        float val_9;
        float val_11;
        float val_12;
        var val_14;
        System.Collections.Generic.List<UnityEngine.Vector3> val_15;
        this.points.Clear();
        List.Enumerator<T> val_1 = GetEnumerator();
        label_7:
        bool val_2 = MoveNext();
        if(val_2 == false)
        {
            goto label_3;
        }
        
        if(val_2 <= val_3)
        {
                var val_14 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_14 = val_14 + ((val_3 + (val_3 << 1)) << 2);
        this.points.Add(item:  new UnityEngine.Vector3() {x = (0 + ((val_3 + (val_3) << 1)) << 2) + 16, y = (0 + ((val_3 + (val_3) << 1)) << 2) + 20, z = (0 + ((val_3 + (val_3) << 1)) << 2) + 24});
        goto label_7;
        label_3:
        Dispose();
        if(includeMousePoint == false)
        {
                return;
        }
        
        if(includeMousePoint != true)
        {
            goto label_10;
        }
        
        label_19:
        UnityEngine.Camera val_5 = UnityEngine.Camera.main;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = -1.268136E-36f, y = mem[this.mousePoint + (0)]});
        UnityEngine.Vector3 val_10 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_8, z = val_9});
        val_15 = this.points;
        val_15.Add(item:  new UnityEngine.Vector3() {x = val_11, y = val_12, z = 90f});
        return;
        label_10:
        if(includeMousePoint < true)
        {
                return;
        }
        
        val_14 = this;
        val_15 = Pan.tappingAllowed;
        if((val_15.IsInRectofAnyTile(mousePos:  new UnityEngine.Vector2() {x = this.mousePoint, y = -1.268136E-36f})) == 1)
        {
            goto label_19;
        }
    
    }
    public bool IsDragging()
    {
        return (bool)this.isDragging;
    }
    public void MakeParticles()
    {
        var val_5 = 0;
        goto label_1;
        label_8:
        if((new System.Collections.Generic.List<UnityEngine.Vector3>()) <= val_5)
        {
                var val_6 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_6 = val_6 + 0;
        if(val_6 <= ((0 + 0) + 16))
        {
                var val_7 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_7 = val_7 + ((((0 + 0) + 16) + (((0 + 0) + 16) << 1)) << 2);
        Add(item:  new UnityEngine.Vector3() {x = (0 + (((0 + 0) + 16 + ((0 + 0) + 16) << 1)) << 2) + 16, y = (0 + (((0 + 0) + 16 + ((0 + 0) + 16) << 1)) << 2) + 20, z = (0 + (((0 + 0) + 16 + ((0 + 0) + 16) << 1)) << 2) + 24});
        val_5 = 1;
        label_1:
        if(val_5 < null)
        {
            goto label_8;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.lineDrawerParticles)) == false)
        {
                return;
        }
        
        System.Collections.IEnumerator val_4 = this.lineDrawerParticles.PlayInSequence(selectedPositions:  80883712);
        UnityEngine.Coroutine val_5 = this.lineDrawerParticles.StartCoroutine(routine:  this.lineDrawerParticles);
    }
    public void OnWordFound()
    {
        if(true == 0)
        {
                return;
        }
        
        this.MakeParticles();
    }
    public LineDrawer()
    {
        this.letterPositions = new System.Collections.Generic.List<UnityEngine.Vector3>();
        System.Collections.Generic.List<System.Boolean> val_2 = new System.Collections.Generic.List<System.Boolean>();
        this.allowedPositions = null;
        System.Collections.Generic.List<System.Int32> val_3 = new System.Collections.Generic.List<System.Int32>();
        this.currentIndexes = null;
        this.points = new System.Collections.Generic.List<UnityEngine.Vector3>();
        this.downOnIndex = 0;
        this.positions = new System.Collections.Generic.List<UnityEngine.Vector3>();
    }

}
