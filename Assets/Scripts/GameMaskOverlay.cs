using UnityEngine;
public class GameMaskOverlay : MonoSingleton<GameMaskOverlay>
{
    // Fields
    private UnityEngine.Camera overlayCam;
    private UnityEngine.Canvas overlayCanvas;
    private UnityEngine.CanvasGroup overlayCanvasGroup;
    private UnityEngine.RectTransform overlayObjectContainer;
    private UnityEngine.CanvasGroup backgroundCanvasGroup;
    private UnityEngine.UI.Image backgroundImage;
    private UnityEngine.Color backgroundColor;
    private float bgFadeInDuration;
    private float bgFadeOutDuration;
    private System.Collections.Generic.Dictionary<int, OverlaidObject> overlaidObjectsDict;
    private System.Collections.Generic.Dictionary<int, UnityEngine.Transform> standInObjectsDict;
    private System.Collections.Generic.Dictionary<int, UnityEngine.Camera> overlaidObjectsParentCamera;
    private DG.Tweening.Tween backgroundTween;
    private bool blockRaycast;
    public System.Action OnOverlayOpened;
    public System.Action OnOverlayClosed;
    
    // Properties
    public bool BlockRaycasts { get; set; }
    public bool Interactable { get; set; }
    public float Alpha { get; set; }
    
    // Methods
    public bool get_BlockRaycasts()
    {
        return (bool)this.blockRaycast;
    }
    public void set_BlockRaycasts(bool value)
    {
        this.blockRaycast = value;
        this.overlayCanvasGroup.blocksRaycasts = value;
    }
    public bool get_Interactable()
    {
        if(this.overlayCanvasGroup != 0)
        {
                return this.overlayCanvasGroup.interactable;
        }
        
        return this.overlayCanvasGroup.interactable;
    }
    public void set_Interactable(bool value)
    {
        this.overlayCanvasGroup.interactable = value;
    }
    public float get_Alpha()
    {
        if(this.overlayCanvasGroup != 0)
        {
                return this.overlayCanvasGroup.alpha;
        }
        
        return this.overlayCanvasGroup.alpha;
    }
    public void set_Alpha(float value)
    {
        this.overlayCanvasGroup.alpha = value;
    }
    public override void InitMonoSingleton()
    {
        this.backgroundCanvasGroup.alpha = null;
        this.SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = false}, fadeInDuration:  null, fadeOutDuration:  null);
        this.overlayCam.enabled = false;
        this.overlayCanvas.enabled = false;
        UnityEngine.GameObject val_1 = this.overlayCanvas.gameObject;
        UnityEngine.Transform val_2 = this.transform;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        this.position = new UnityEngine.Vector3();
    }
    public void SetOptions(System.Nullable<UnityEngine.Color> bgColor, float fadeInDuration = 0.15, float fadeOutDuration = 0.15)
    {
        var val_1;
        float val_3;
        float val_4;
        if((val_1 & 255) == 0)
        {
                UnityEngine.Color val_5 = Value;
        }
        
        this.bgFadeInDuration = val_4;
        this.bgFadeOutDuration = val_3;
    }
    public void ShowOverlay(UnityEngine.Transform[] contentToOverlay)
    {
        float val_17;
        float val_18;
        float val_19;
        var val_21;
        var val_23;
        var val_25;
        UnityEngine.Transform[] val_33;
        GameMaskOverlay val_34;
        float val_35;
        var val_37;
        GameMaskOverlay val_38;
        var val_39;
        val_33 = contentToOverlay;
        if((this.backgroundTween != 0) && ((DG.Tweening.TweenExtensions.IsPlaying(t:  this.backgroundTween)) != false))
        {
                if(this.backgroundTween.onComplete != 0)
        {
                this.backgroundTween.onComplete.Invoke();
        }
        
            DG.Tweening.TweenExtensions.Kill(t:  this.backgroundTween, complete:  false);
        }
        
        this.overlayCam.enabled = true;
        this.overlayCanvas.enabled = true;
        this.overlayCanvasGroup.alpha = null;
        if(this.blockRaycast == true)
        {
                this.blockRaycast = 1;
        }
        
        this.overlayCanvasGroup.blocksRaycasts = true;
        val_34 = this;
        if((val_33 != null) && ((new System.Collections.Generic.Dictionary<System.Int32, System.Boolean>()) >= 1))
        {
                var val_33 = 0;
            val_35 = 1152921512922686624;
            do
        {
            if((-2028557104) != 0)
        {
                int val_4 = 1152921506873257168.GetInstanceID();
            if((mem[1152921512922716828].ContainsKey(key:  val_4)) != false)
        {
                Add(key:  val_4, value:  true);
        }
        else
        {
                val_37 = 1152921506873257168;
            UnityEngine.Transform val_6 = 1152921506873257168.parent;
            OverlaidObject val_8 = new OverlaidObject(_transform:  -2028557104, _parent:  -2028557104, _siblingIndex:  1152921506873257168.GetSiblingIndex());
            mem[1152921512922716828].Add(key:  val_4, value:  new OverlaidObject() {transform = val_8.transform, parent = val_8.parent, siblingIndex = val_8.siblingIndex});
            val_34 = this;
            val_33 = val_33;
            val_35 = 1152921512922686624;
        }
        
        }
        
            val_33 = val_33 + 1;
        }
        while(val_33 < (contentToOverlay + 12));
        
            if((contentToOverlay + 12) >= 1)
        {
                var val_34 = 0;
            do
        {
            if((-2028557104) != 0)
        {
                val_35 = 1152921506873257168.GetInstanceID();
            if((EnumerableExtentions.GetOrDefault<System.Int32, System.Boolean>(dic:  78753792, key:  val_35, defaultValue:  false)) != true)
        {
                if((mem[1152921512922716832].ContainsKey(key:  val_35)) != true)
        {
                OverlaidObject val_13 = val_8.transform.Item[mem[1152921512922716828]];
            UnityEngine.Transform val_14 = val_13.transform.CreateStandInGameObject(original:  val_8.transform);
            mem[1152921512922716832].Add(key:  val_35, value:  val_13.transform);
            val_38 = this;
        }
        
            OverlaidObject val_15 = val_8.transform.Item[mem[1152921512922716828]];
            UnityEngine.Vector3 val_16 = TransformPositionToOverlaySpace(objectTransform:  -274064800);
            OverlaidObject val_20 = Item[mem[1152921512922716828]];
            val_21.SetParent(p:  mem[1152921512922716792]);
            val_39 = val_38;
            OverlaidObject val_22 = Item[mem[1152921512922716828]];
            val_23.position = new UnityEngine.Vector3() {x = val_18, y = val_17, z = val_19};
            OverlaidObject val_24 = Item[mem[1152921512922716828]];
            val_33 = val_33;
            val_25.SetAsLastSibling();
        }
        
        }
        
            val_34 = val_34 + 1;
        }
        while(val_34 < (contentToOverlay + 12));
        
        }
        
        }
        
        DG.Tweening.Sequence val_26 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Tweener val_27 = DG.Tweening.ShortcutExtensions46.DOFade(target:  mem[1152921512922716796], endValue:  val_16.x, duration:  val_16.y);
        object val_28 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  mem[1152921512922716796], ease:  1);
        DG.Tweening.Sequence val_29 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  mem[1152921512922716796]);
        DG.Tweening.Tweener val_30 = DG.Tweening.ShortcutExtensions46.DOColor(target:  null, endValue:  new UnityEngine.Color() {a = ???}, duration:  mem[1152921512922716820]);
        object val_31 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  null, ease:  1);
        DG.Tweening.Sequence val_32 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  R0);
        this.backgroundTween = 0;
        if(mem[1152921512922716848] == 0)
        {
                return;
        }
        
        mem[1152921512922716848].Invoke();
    }
    public UnityEngine.Vector3 TransformPositionToOverlaySpace(UnityEngine.Transform objectTransform)
    {
        float val_4;
        float val_5;
        float val_7;
        float val_8;
        UnityEngine.Camera val_1 = objectTransform.GetParentCamera(objectTransform:  R2);
        UnityEngine.Vector3 val_2 = position;
        UnityEngine.Vector3 val_6 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = objectTransform, y = val_4, z = val_5});
        UnityEngine.Vector3 val_10 = this.ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = objectTransform, y = val_7, z = val_8});
        return new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
    }
    public void CloseOverlay(System.Action onClosed)
    {
        this.CloseOverlay(forceImmediate:  false, onClosed:  onClosed);
    }
    public void CloseOverlay(bool forceImmediate, System.Action onClosed)
    {
        if(new System.Object() != 0)
        {
                typeof(GameMaskOverlay.<>c__DisplayClass30_0).__il2cppRuntimeField_8 = this;
        }
        else
        {
                mem[8] = this;
        }
        
        typeof(GameMaskOverlay.<>c__DisplayClass30_0).__il2cppRuntimeField_C = onClosed;
        if((this.backgroundTween != 0) && ((DG.Tweening.TweenExtensions.IsPlaying(t:  this.backgroundTween)) != false))
        {
                if(this.backgroundTween.onComplete != 0)
        {
                this.backgroundTween.onComplete.Invoke();
        }
        
            DG.Tweening.TweenExtensions.Kill(t:  this.backgroundTween, complete:  false);
        }
        
        System.Action val_3 = new System.Action(object:  375078912, method:  new IntPtr(4021337376));
        typeof(GameMaskOverlay.<>c__DisplayClass30_0).__il2cppRuntimeField_10 = null;
        if(forceImmediate != false)
        {
                this.backgroundCanvasGroup.alpha = null;
            Invoke();
            return;
        }
        
        DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.backgroundCanvasGroup, endValue:  null, duration:  null);
        object val_5 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.backgroundCanvasGroup, ease:  1);
        DG.Tweening.TweenCallback val_6 = new DG.Tweening.TweenCallback(object:  375078912, method:  new IntPtr(4021342496));
        object val_7 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.backgroundCanvasGroup, action:  190734336);
        this.backgroundTween = this.backgroundCanvasGroup;
    }
    public void FlushOverlaidObjects()
    {
        var val_4;
        int val_5;
        float val_11;
        int val_32;
        var val_33;
        System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_1 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
        Dictionary.Enumerator<TKey, TValue> val_2 = GetEnumerator();
        label_9:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        int val_6 = val_4.GetInstanceID();
        if((ContainsKey(key:  val_6)) != true)
        {
                System.Collections.Generic.List<System.Int32> val_8 = new System.Collections.Generic.List<System.Int32>();
            Add(key:  val_6, value:  80883712);
        }
        
        System.TimeType val_9 = Item[val_6];
        Add(item:  val_5);
        goto label_9;
        label_2:
        Dispose();
        Dictionary.Enumerator<TKey, TValue> val_10 = GetEnumerator();
        label_13:
        if(0.MoveNext() == false)
        {
            goto label_11;
        }
        
        System.Comparison<System.Int32> val_13 = new System.Comparison<System.Int32>(object:  -273389472, method:  new IntPtr(4021497504));
        65793.Sort(comparison:  7933952);
        goto label_13;
        label_11:
        0.Dispose();
        Dictionary.Enumerator<TKey, TValue> val_14 = GetEnumerator();
        goto label_17;
        label_33:
        if(((9.219563E-41f) != 0) && (1600075380 >= 1))
        {
                do
        {
            var val_15 = 4 - 4;
            if(1600075380 <= val_15)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_32 = mem[1397643887];
            if((this.overlaidObjectsDict.ContainsKey(key:  val_32)) != false)
        {
                if(1600075380 <= val_15)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            OverlaidObject val_17 = Item[this.overlaidObjectsDict];
            if(1600075380 <= val_15)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_32 = mem[1397643887];
            UnityEngine.Transform val_19 = this.standInObjectsDict.Item[val_32];
            if(this.standInObjectsDict != 0)
        {
                if(1600075380 <= val_15)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_32 = mem[1397643887];
            UnityEngine.Transform val_21 = this.standInObjectsDict.Item[val_32];
            val_11.Restore(_siblingIndex:  this.standInObjectsDict.GetSiblingIndex());
        }
        else
        {
                val_11.Restore();
        }
        
        }
        
            var val_24 = 4 + 1;
        }
        while((4 - 3) < 1600075380);
        
        }
        
        label_17:
        if(val_11.MoveNext() == true)
        {
            goto label_33;
        }
        
        val_11.Dispose();
        if(0 != 1)
        {
                if(0 > 1)
        {
                0 = 1;
        }
        
            var val_35 = 0;
            val_35 = 0 - val_35;
            val_33 = val_35 + 1;
        }
        else
        {
                val_33 = 0;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_26 = GetEnumerator();
        label_53:
        if(0.MoveNext() == false)
        {
            goto label_37;
        }
        
        if(R7 == 0)
        {
            goto label_53;
        }
        
        if((this.overlaidObjectsDict.ContainsKey(key:  0)) != false)
        {
                OverlaidObject val_30 = Item[this.overlaidObjectsDict];
            if(val_11 != 0)
        {
                OverlaidObject val_32 = Item[this.overlaidObjectsDict];
            UnityEngine.Vector3 val_33 = position;
            val_11.position = new UnityEngine.Vector3();
        }
        
        }
        
        UnityEngine.GameObject val_34 = R7.gameObject;
        UnityEngine.Object.Destroy(obj:  R7);
        goto label_53;
        label_37:
        0.Dispose();
        this.overlaidObjectsDict.Clear();
        this.standInObjectsDict.Clear();
        this.overlaidObjectsParentCamera.Clear();
    }
    public UnityEngine.Transform GetStandInTransformForObject(UnityEngine.Transform original)
    {
        if((this.standInObjectsDict.ContainsKey(key:  original.GetInstanceID())) == false)
        {
                return;
        }
        
        UnityEngine.Transform val_4 = this.standInObjectsDict.Item[original.GetInstanceID()];
        0 = this.standInObjectsDict;
    }
    private UnityEngine.Transform CreateStandInGameObject(UnityEngine.Transform original)
    {
        float val_25;
        float val_26;
        float val_28;
        float val_29;
        float val_31;
        float val_32;
        float val_34;
        float val_35;
        var val_37;
        var val_38;
        var val_39;
        UnityEngine.Transform val_1 = original.transform;
        if(original == 0)
        {
            goto label_2;
        }
        
        val_37 = original;
        if(null == null)
        {
            goto label_3;
        }
        
        label_2:
        val_37 = 0;
        label_3:
        UnityEngine.GameObject val_2 = original.gameObject;
        object val_3 = original.GetComponent<System.Object>();
        val_38 = 0;
        if(original != 0)
        {
                val_38 = original;
        }
        
        UnityEngine.GameObject val_5 = original.gameObject;
        string val_6 = original.name;
        string val_7 = -273111648(-273111648) + original;
        UnityEngine.GameObject val_8 = new UnityEngine.GameObject(name:  -273111648);
        UnityEngine.Transform val_9 = transform;
        UnityEngine.Transform val_10 = original.parent;
        SetParent(p:  original);
        UnityEngine.Transform val_11 = transform;
        SetSiblingIndex(index:  original.GetSiblingIndex());
        UnityEngine.Transform val_13 = transform;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.one;
        localScale = new UnityEngine.Vector3();
        UnityEngine.Transform val_15 = transform;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
        localPosition = new UnityEngine.Vector3();
        if(val_8 != 0)
        {
                object val_17 = AddComponent<System.Object>();
            val_39 = val_8;
        }
        else
        {
                object val_18 = AddComponent<System.Object>();
            val_39 = val_8;
        }
        
        object val_19 = AddComponent<System.Object>();
        UnityEngine.Rect val_20 = rect;
        float val_21 = width;
        UnityEngine.Rect val_22 = rect;
        float val_23 = height;
        UnityEngine.Vector2 val_24 = anchorMin;
        anchorMin = new UnityEngine.Vector2() {x = val_25, y = val_26};
        UnityEngine.Vector2 val_27 = anchorMax;
        anchorMax = new UnityEngine.Vector2() {x = val_28, y = val_29};
        UnityEngine.Vector2 val_30 = sizeDelta;
        sizeDelta = new UnityEngine.Vector2() {x = val_31, y = val_32};
        UnityEngine.Vector2 val_33 = anchoredPosition;
        anchoredPosition = new UnityEngine.Vector2() {x = val_34, y = val_35};
        UnityEngine.Transform val_36 = transform;
    }
    private UnityEngine.Camera GetParentCamera(UnityEngine.Transform objectTransform)
    {
        float val_14;
        float val_15;
        GameMaskOverlay val_20;
        int val_21;
        UnityEngine.Object val_22;
        UnityEngine.Object val_23;
        UnityEngine.Object val_24;
        var val_25;
        val_20 = this;
        val_21 = objectTransform.GetInstanceID();
        if((this.overlaidObjectsParentCamera.ContainsKey(key:  val_21)) == true)
        {
            goto label_3;
        }
        
        object val_3 = objectTransform.GetComponentInParent<System.Object>();
        val_22 = objectTransform;
        if(val_22 != 0)
        {
                if(val_22.isRootCanvas != true)
        {
                UnityEngine.Canvas val_6 = val_22.rootCanvas;
            val_22 = val_22;
        }
        
        }
        
        if(val_22 != 0)
        {
                val_23 = val_22;
            UnityEngine.Camera val_8 = val_23.worldCamera;
        }
        else
        {
                val_23 = objectTransform;
            object val_9 = val_23.GetComponentInParent<System.Object>();
        }
        
        val_24 = val_23;
        if(val_24 != 0)
        {
            goto label_30;
        }
        
        UnityEngine.Camera[] val_11 = UnityEngine.Camera.allCameras;
        val_25 = 0;
        goto label_20;
        label_29:
        UnityEngine.Vector3 val_12 = position;
        UnityEngine.Vector3 val_16 = WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = 3.673424E-39f, y = val_14, z = val_15});
        if(((2621443 <= 0) && (2621443 >= 0)) && (2621443 <= 0))
        {
                if(2621443 >= 0)
        {
            goto label_27;
        }
        
        }
        
        val_25 = 1;
        label_20:
        if(val_25 < 0)
        {
            goto label_29;
        }
        
        val_20 = val_20;
        val_21 = val_21;
        val_24 = val_24;
        goto label_30;
        label_27:
        val_24 = 2621443;
        val_20 = val_20;
        val_21 = val_21;
        label_30:
        this.overlaidObjectsParentCamera.Add(key:  val_21, value:  2621443);
        label_3:
        UnityEngine.Camera val_19 = this.overlaidObjectsParentCamera.Item[val_21];
    }
    public GameMaskOverlay()
    {
        UnityEngine.Color val_1 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
        this.bgFadeInDuration = 0.15f;
        this.bgFadeOutDuration = 0.15f;
        System.Collections.Generic.Dictionary<System.Int32, OverlaidObject> val_2 = new System.Collections.Generic.Dictionary<System.Int32, OverlaidObject>();
        this.overlaidObjectsDict = null;
        System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_3 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
        this.standInObjectsDict = null;
        System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_4 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
        this.blockRaycast = true;
        this.overlaidObjectsParentCamera = null;
    }
    private int <FlushOverlaidObjects>b__31_0(int a, int b)
    {
        var val_3;
        int val_5;
        OverlaidObject val_1 = Item[this.overlaidObjectsDict];
        OverlaidObject val_4 = Item[this.overlaidObjectsDict];
        return (int)val_3.CompareTo(value:  val_5);
    }

}
