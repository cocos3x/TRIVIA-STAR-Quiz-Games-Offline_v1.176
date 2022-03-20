using UnityEngine;
public class FPHAnswerDisplay : MonoBehaviour
{
    // Fields
    private int maxSlotsPerRow;
    private float maxWidthPerSlot;
    private FPHAnswerTile tilePrefab;
    private UnityEngine.UI.HorizontalLayoutGroup wordRowPrefab;
    private UnityEngine.RectTransform wordRowParent;
    private UnityEngine.UI.Text labelClue;
    private System.Collections.Generic.List<FPHAnswerTile> <spawnedTiles>k__BackingField;
    private System.Collections.Generic.List<UnityEngine.UI.HorizontalLayoutGroup> spawnedWordRows;
    private System.Collections.Generic.List<FPHAnswerTile> spawnedSpacingTiles;
    private UnityEngine.UI.HorizontalOrVerticalLayoutGroup wordRowParentLayoutGroup;
    private int widestRowSlotCount;
    
    // Properties
    public System.Collections.Generic.List<FPHAnswerTile> spawnedTiles { get; set; }
    
    // Methods
    public System.Collections.Generic.List<FPHAnswerTile> get_spawnedTiles()
    {
    
    }
    private void set_spawnedTiles(System.Collections.Generic.List<FPHAnswerTile> value)
    {
        this.<spawnedTiles>k__BackingField = value;
    }
    private void Start()
    {
        var val_6;
        FPHGameplayController val_1 = FPHGameplayController.Instance;
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -1658721792, method:  new IntPtr(2636215360));
        System.Delegate val_3 = System.Delegate.Combine(a:  typeof(FPHGameplayController).__il2cppRuntimeField_14, b:  7401472);
        val_6 = typeof(FPHGameplayController).__il2cppRuntimeField_14;
        if(val_6 != 0)
        {
                if(val_6 == null)
        {
            goto label_6;
        }
        
        }
        
        val_6 = 0;
        label_6:
        typeof(FPHGameplayController).__il2cppRuntimeField_14 = val_6;
        UnityEngine.GameObject val_4 = this.wordRowParent.gameObject;
        object val_5 = this.wordRowParent.GetComponent<System.Object>();
        this.wordRowParentLayoutGroup = this.wordRowParent;
    }
    private void OnDestroy()
    {
        var val_6;
        var val_7;
        val_6 = 1152921504909881344;
        FPHGameplayController val_1 = FPHGameplayController.Instance;
        if(303034368 == 0)
        {
                return;
        }
        
        FPHGameplayController val_3 = FPHGameplayController.Instance;
        System.Action<System.Boolean> val_4 = new System.Action<System.Boolean>(object:  -1658605696, method:  new IntPtr(2636215360));
        System.Delegate val_5 = System.Delegate.Remove(source:  typeof(FPHGameplayController).__il2cppRuntimeField_14, value:  7401472);
        val_7 = typeof(FPHGameplayController).__il2cppRuntimeField_14;
        if(val_7 != 0)
        {
                if(val_7 == null)
        {
            goto label_11;
        }
        
        }
        
        val_7 = 0;
        label_11:
        typeof(FPHGameplayController).__il2cppRuntimeField_14 = val_7;
    }
    public void Setup(FPHGameplayState state)
    {
        this.CreateAnswerDisplay(state:  state);
    }
    private void OnRectTransformDimensionsChange()
    {
        var val_3;
        var val_10;
        var val_17;
        FPHAnswerDisplay val_28;
        float val_29;
        int val_30;
        var val_31;
        var val_32;
        val_28 = this;
        if((this.<spawnedTiles>k__BackingField) == 0)
        {
                return;
        }
        
        if((this.<spawnedTiles>k__BackingField) < 1)
        {
                return;
        }
        
        UnityEngine.Rect val_1 = rect;
        UnityEngine.Vector2 val_2 = size;
        var val_29 = val_3;
        val_30 = this.widestRowSlotCount;
        if(this.wordRowPrefab == 0)
        {
                val_30 = this.widestRowSlotCount;
        }
        
        int val_6 = this.widestRowSlotCount - 1;
        float val_28 = (float)this.wordRowParentLayoutGroup.left;
        val_28 = val_29 - val_28;
        val_28 = val_28 - (float)this.wordRowParentLayoutGroup.right;
        val_29 = val_28 / (float)val_30;
        float val_7 = UnityEngine.Mathf.Min(a:  val_28, b:  val_2.y);
        UnityEngine.Rect val_8 = rect;
        UnityEngine.Vector2 val_9 = size;
        var val_13 = (mem[1152921511538468520] + 12) - 1;
        float val_30 = (float)this.wordRowParentLayoutGroup.top;
        val_30 = val_10 - val_30;
        val_30 = val_30 - (float)this.wordRowParentLayoutGroup.bottom;
        val_30 = val_30 / ((float)mem[1152921511538468520] + 12);
        float val_14 = UnityEngine.Mathf.Min(a:  val_30, b:  val_9.y);
        val_28 = this.maxWidthPerSlot;
        List.Enumerator<T> val_15 = GetEnumerator();
        val_29 = 1152921511538442432;
        label_30:
        if(MoveNext() == false)
        {
            goto label_20;
        }
        
        UnityEngine.GameObject val_18 = val_17.gameObject;
        UnityEngine.Transform val_19 = val_17.transform;
        val_31 = 0;
        if(val_17 != 0)
        {
                if(val_17 != null)
        {
            
        }
        else
        {
                val_31 = val_17;
        }
        
        }
        
        float val_20 = UnityEngine.Mathf.Min(a:  val_14, b:  val_9.y);
        val_31.SetSizeWithCurrentAnchors(axis:  0, size:  val_20);
        val_31.SetSizeWithCurrentAnchors(axis:  1, size:  UnityEngine.Mathf.Min(a:  val_20, b:  val_9.y));
        goto label_30;
        label_20:
        Dispose();
        List.Enumerator<T> val_22 = GetEnumerator();
        label_42:
        if(MoveNext() == false)
        {
            goto label_32;
        }
        
        UnityEngine.GameObject val_24 = val_17.gameObject;
        UnityEngine.Transform val_25 = val_17.transform;
        val_32 = 0;
        if(val_17 != 0)
        {
                if(val_17 != null)
        {
            
        }
        else
        {
                val_32 = val_17;
        }
        
        }
        
        float val_26 = UnityEngine.Mathf.Min(a:  val_14, b:  val_9.y);
        val_32.SetSizeWithCurrentAnchors(axis:  0, size:  val_26);
        val_32.SetSizeWithCurrentAnchors(axis:  1, size:  UnityEngine.Mathf.Min(a:  val_26, b:  val_9.y));
        goto label_42;
        label_32:
        Dispose();
    }
    private void CreateAnswerDisplay(FPHGameplayState state)
    {
        UnityEngine.Object val_3;
        UnityEngine.Object val_10;
        var val_19;
        FPHAnswerDisplay val_34;
        var val_35;
        System.Collections.Generic.IEnumerable<T> val_36;
        var val_37;
        int val_38;
        var val_40;
        UnityEngine.UI.HorizontalLayoutGroup val_41;
        var val_42;
        val_34 = this;
        if((this.<spawnedTiles>k__BackingField) == 0)
        {
            goto label_1;
        }
        
        List.Enumerator<T> val_1 = GetEnumerator();
        label_6:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        UnityEngine.GameObject val_4 = val_3.gameObject;
        UnityEngine.Object.Destroy(obj:  val_3);
        goto label_6;
        label_2:
        Dispose();
        label_1:
        if(this.spawnedSpacingTiles == 0)
        {
            goto label_7;
        }
        
        List.Enumerator<T> val_5 = GetEnumerator();
        label_12:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        UnityEngine.GameObject val_7 = val_3.gameObject;
        UnityEngine.Object.Destroy(obj:  val_3);
        goto label_12;
        label_8:
        Dispose();
        label_7:
        if(this.spawnedWordRows == 0)
        {
            goto label_13;
        }
        
        List.Enumerator<T> val_8 = GetEnumerator();
        label_18:
        if(MoveNext() == false)
        {
            goto label_14;
        }
        
        UnityEngine.GameObject val_11 = val_10.gameObject;
        UnityEngine.Object.Destroy(obj:  val_10);
        goto label_18;
        label_14:
        Dispose();
        if(0 == 1)
        {
            goto label_19;
        }
        
        if(0 > 1)
        {
                0 = 1;
        }
        
        var val_34 = 0;
        val_34 = 0 - val_34;
        val_35 = val_34 + 1;
        goto label_21;
        label_13:
        val_35 = 0;
        goto label_21;
        label_19:
        val_35 = 0;
        label_21:
        this.<spawnedTiles>k__BackingField = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_13 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.spawnedWordRows = null;
        this.spawnedSpacingTiles = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_15 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        typeof(System.Char[]).__il2cppRuntimeField_10 = 32;
        System.String[] val_16 = state + 8 + 16.Split(separator:  478563824);
        val_36 = state + 8 + 16;
        AddRange(collection:  val_36);
        string val_17 = -1658170816(-1658170816) + state + 8 + 16(state + 8 + 16);
        val_37 = 0;
        UnityEngine.Debug.Log(message:  -1658170816);
        List.Enumerator<T> val_18 = GetEnumerator();
        val_38 = 0;
        goto label_48;
        label_58:
        val_40 = val_19;
        if(val_38 > 0)
        {
                0 = 1;
        }
        
        if(val_40 == 0)
        {
                val_40 = val_40;
        }
        
        var val_35 = val_19 + 8;
        val_35 = (val_38 + 1) + val_35;
        if(val_35 > this.maxSlotsPerRow)
        {
                val_38 = 0;
            val_41 = 0;
        }
        
        if(0 == 0)
        {
                object val_22 = UnityEngine.Object.Instantiate<System.Object>(original:  this.wordRowPrefab, parent:  this.wordRowParent);
            val_41 = this.wordRowPrefab;
            this.spawnedWordRows.Add(item:  val_41);
        }
        
        if(0 != 0)
        {
                UnityEngine.Transform val_23 = val_41.transform;
            object val_24 = UnityEngine.Object.Instantiate<System.Object>(original:  this.tilePrefab, parent:  val_41);
            this.tilePrefab.Setup(myLetter:  ' ', revealed:  false);
            this.spawnedSpacingTiles.Add(item:  this.tilePrefab);
            val_42 = 0 + 1;
        }
        else
        {
                val_42 = 0;
        }
        
        val_36 = mem[val_19 + 8];
        val_36 = val_19 + 8;
        val_38 = val_36 + val_42;
        this.widestRowSlotCount = UnityEngine.Mathf.Max(a:  this.widestRowSlotCount, b:  val_38);
        if((val_19 + 8) >= 1)
        {
                var val_37 = 0;
            do
        {
            UnityEngine.Transform val_27 = val_41.transform;
            val_36 = val_41;
            object val_28 = UnityEngine.Object.Instantiate<System.Object>(original:  this.tilePrefab, parent:  val_36);
            if((state + 76 + 12) <= val_37)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_36 = state + 76 + 8;
            val_36 = val_36 + 0;
            this.tilePrefab.Setup(myLetter:  val_40.Chars[0], revealed:  (((state + 76 + 8 + 0) + 16) - 1) >> 5);
            Add(item:  this.tilePrefab);
            val_37 = val_37 + 1;
            val_34 = val_34;
            val_37 = 1;
        }
        while(val_37 < (val_19 + 8));
        
        }
        
        label_48:
        if(MoveNext() == true)
        {
            goto label_58;
        }
        
        Dispose();
        System.Action val_32 = new System.Action(object:  -1658116000, method:  new IntPtr(2636825248));
        MonoExtensions.DelayedCallEndOfFrame(monoBehaviour:  -1658116000, callback:  7454720);
        System.Action val_33 = new System.Action(object:  -1658116000, method:  new IntPtr(2636826272));
        MonoExtensions.DelayedCallEndOfFrame(monoBehaviour:  -1658116000, callback:  7454720);
    }
    public void UpdateState(FPHGameplayState state)
    {
        var val_3;
        var val_4;
        val_3 = 0;
        val_4 = 16;
        goto label_1;
        label_26:
        if(true <= val_3)
        {
                var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = val_3 + 0;
        if(((0 + 0) + 16) == 1)
        {
                if(((0 + 0) + 16) <= val_3)
        {
                var val_4 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_4 = val_4 + 0;
            (0 + 0) + 16.DisplayLetter();
        }
        else
        {
                if(((0 + 0) + 16) <= val_3)
        {
                var val_5 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_5 = val_5 + 0;
            if(((0 + 0) + 16) == 2)
        {
                if(((0 + 0) + 16) <= val_3)
        {
                var val_6 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_6 = val_6 + 0;
            if(val_6 <= val_3)
        {
                char val_7 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_7 = val_7 + val_4;
            (0 + 0) + 16.DisplayUnconfirmedLetter(value:  val_7);
        }
        else
        {
                if(((0 + 0) + 16) <= val_3)
        {
                var val_8 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_8 = val_8 + 0;
            if(((0 + 0) + 16) == 0)
        {
                if(((0 + 0) + 16) <= val_3)
        {
                var val_9 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_9 = val_9 + 0;
            (0 + 0) + 16.RemoveLetter();
        }
        
        }
        
        }
        
        val_4 = 18;
        val_3 = 1;
        label_1:
        if(val_3 < ((0 + 0) + 16))
        {
            goto label_26;
        }
        
        FPHGameplayController val_1 = FPHGameplayController.Instance;
        FPHGameplayController val_2 = FPHGameplayController.Instance;
        this.HighlightTile(index:  FPHGameplayController.__il2cppRuntimeField_castClass);
    }
    public void DoStartAnimation()
    {
        var val_8;
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_2 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
        val_8 = 4;
        goto label_3;
        label_12:
        if(0 <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Transform val_3 = 2621443.transform;
        if(2621443 <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Transform val_4 = 2621443.transform;
        UnityEngine.Vector3 val_5 = localPosition;
        DG.Tweening.Sequence val_6 = DG.Tweening.ShortcutExtensions.DOLocalJump(target:  2621443, endValue:  new UnityEngine.Vector3(), jumpPower:  val_5.x, numJumps:  1094713344, duration:  val_5.y, snapping:  true);
        float val_9 = (float)R8;
        val_9 = val_9 * 0.06f;
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  val_9, t:  val_9);
        val_8 = 5;
        label_3:
        if((val_8 - 4) < 0)
        {
            goto label_12;
        }
    
    }
    public void DoLevelCompleteAnimation()
    {
        goto label_1;
        label_10:
        if(true <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Transform val_1 = 2621443.transform;
        if(2621443 <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Transform val_2 = 2621443.transform;
        UnityEngine.Vector3 val_3 = localPosition;
        DG.Tweening.Sequence val_4 = DG.Tweening.ShortcutExtensions.DOLocalJump(target:  2621443, endValue:  new UnityEngine.Vector3(), jumpPower:  val_3.x, numJumps:  1101004800, duration:  val_3.y, snapping:  true);
        4 = 5;
        label_1:
        if((4 - 4) < 2621443)
        {
            goto label_10;
        }
    
    }
    public void DoLevelFailAnimation()
    {
        var val_3;
        val_3 = 0;
        goto label_1;
        label_6:
        if(true <= val_3)
        {
                var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = val_3 + 0;
        UnityEngine.Transform val_1 = (0 + 0) + 16.transform;
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOShakePosition(target:  (0 + 0) + 16, duration:  null, strength:  null, vibrato:  1050253722, randomness:  null, snapping:  false, fadeOut:  true);
        val_3 = 1;
        label_1:
        if(val_3 < ((0 + 0) + 16))
        {
            goto label_6;
        }
    
    }
    private void OnSolveModeToggled(bool isOn)
    {
        if(isOn == false)
        {
                return;
        }
        
        FPHGameplayController val_1 = FPHGameplayController.Instance;
        this.HighlightTile(index:  FPHGameplayController.__il2cppRuntimeField_castClass);
    }
    private void HighlightTile(int index)
    {
        this.RemoveAllHighlights();
        if(index < 0)
        {
                return;
        }
        
        35639191 = this.<spawnedTiles>k__BackingField;
        if(this <= index)
        {
                return;
        }
        
        if(this <= index)
        {
                var val_1 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_1 = val_1 + (index << 2);
        (0 + (index) << 2) + 16.Highlight(isVisible:  true);
    }
    private void RemoveAllHighlights()
    {
        var val_3;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_4:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        val_3.Highlight(isVisible:  false);
        goto label_4;
        label_2:
        Dispose();
    }
    public FPHAnswerDisplay()
    {
        this.maxSlotsPerRow = 10;
        this.maxWidthPerSlot = 108f;
    }

}
