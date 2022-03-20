using UnityEngine;
public class WFOWordHuntEvent : WordHuntEvent
{
    // Methods
    public override bool ShowEventUI(EventButtonPanel.LayoutType layoutType, EventButtonPanel.DisplayContext context)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == false)
        {
                return this.ShowEventUI(layoutType:  layoutType, context:  context);
        }
        
        return false;
    }
    public override bool ShouldShowInDailyChallenge(bool dailyChallengeState)
    {
        return (bool)dailyChallengeState ^ 1;
    }
    public override void OnDailyChallengeInit()
    {
    
    }
    public override void OnGameSceneInit()
    {
        WFOWordHuntEvent val_13;
        var val_14;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                return;
        }
        
        this.OnGameSceneInit();
        if(this.IsLevelContainEventWord() == false)
        {
                return;
        }
        
        WordRegion val_4 = WordRegion.instance;
        List.Enumerator<T> val_5 = GetEnumerator();
        label_18:
        if(MoveNext() == false)
        {
            goto label_10;
        }
        
        object val_8 = new System.Object();
        string val_9 = this.EventWordContainedInWord(wordFound:  val_7 + 12);
        val_13 = this;
        if(val_8 != 0)
        {
                val_14 = val_8;
            typeof(WFOWordHuntEvent.<>c__DisplayClass3_0).__il2cppRuntimeField_8 = val_13;
        }
        else
        {
                mem[8] = val_13;
            val_14 = 8;
            val_13 = mem[8];
        }
        
        if((System.String.IsNullOrEmpty(value:  -951415840)) == true)
        {
            goto label_18;
        }
        
        System.Predicate<ZooTile> val_11 = new System.Predicate<ZooTile>(object:  336740352, method:  new IntPtr(3343525408));
        if(((FindIndex(match:  8040448)) != 1) || (val_8 != 0))
        {
            goto label_18;
        }
        
        goto label_18;
        label_10:
        Dispose();
    }
    protected override void OnValidWordSubmission(string word, bool isExtraWord)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge != false)
        {
                return;
        }
        
        this.OnValidWordSubmission(word:  word, isExtraWord:  isExtraWord);
    }
    public override void OnHintIncompleteWord(string word, Cell hintedCell)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge != false)
        {
                return;
        }
        
        this.OnHintIncompleteWord(word:  word, hintedCell:  hintedCell);
    }
    public override string GetGameButtonText()
    {
        string val_1 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
    }
    public override string GetMainMenuButtonText()
    {
        if((35630353 == (R6 + 12)) && (this != 0))
        {
                return Localization.Localize(key:  -1172243376, defaultValue:  -1172243456, useSingularKey:  false);
        }
        
        if(mem[35630365] >= 1)
        {
                string val_1 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        }
    
    }
    protected override void ColorAllVisibleTiles(LineWord wordLine, string eventWord)
    {
        var val_8;
        float val_20;
        float val_21;
        var val_23;
        System.Predicate<Cell> val_25;
        var val_26;
        MainController val_1 = MainController.instance;
        WGEventButtonV2 val_2 = 256.GetEventButton(eventId:  -1298909328);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_23 = null;
        val_23 = null;
        val_25 = WFOWordHuntEvent.<>c.<>9__8_0;
        if(val_25 == 0)
        {
                val_25 = null;
            val_25 = new System.Predicate<ZooTile>(object:  WFOWordHuntEvent.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3344124320));
            WFOWordHuntEvent.<>c.<>9__8_0 = val_25;
        }
        
        bool val_5 = wordLine.cells.TrueForAll(match:  8040448);
        List.Enumerator<T> val_6 = GetEnumerator();
        label_28:
        if(MoveNext() == false)
        {
            goto label_13;
        }
        
        if(((val_8 + 36) == 0) || ((eventWord.Contains(value:  val_8 + 32)) == false))
        {
            goto label_28;
        }
        
        string val_10 = this.currentColor;
        string val_11 = eventWord.ToUpper();
        UnityEngine.Color32 val_12 = mem[1152921512245969804].Item[-950811808];
        val_8.SetNewBackgroundAndColor(bgColor:  new UnityEngine.Color32() {r = val_12.r, g = val_12.g, b = val_12.b, a = val_12.a});
        val_8.HideDynamicImage();
        if(val_5 == false)
        {
            goto label_28;
        }
        
        UnityEngine.Transform val_13 = val_8.transform;
        UnityEngine.Vector3 val_14 = position;
        UnityEngine.RectTransform val_15 = val_8 + 24.rectTransform;
        UnityEngine.Rect val_16 = rect;
        UnityEngine.Vector2 val_17 = size;
        WordRegion val_18 = WordRegion.instance;
        UnityEngine.Transform val_19 = 0.transform;
        UnityEngine.UI.Image val_22 = this.CreateIconObject(worldPos:  new UnityEngine.Vector3(), size:  new UnityEngine.Vector2() {x = val_20, y = val_21}, parentTransform:  0);
        Add(item:  -950811808);
        goto label_28;
        label_13:
        Dispose();
        if(val_5 == false)
        {
                return;
        }
        
        val_26 = 256;
        if(val_26 == 0)
        {
                val_26 = 256;
        }
        
        this.DoProgressGameplayAnimation(iconList:  80883712, targetFlyToImage:  4);
    }
    protected override void PostValidWordSubmission()
    {
        bool val_1 = this.eventComplete;
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -950707424);
    }
    protected override void HighlightEventExtraWordFound(string word)
    {
        float val_14;
        float val_15;
        var val_23;
        object val_1 = new System.Object();
        typeof(WFOWordHuntEvent.<>c__DisplayClass10_0).__il2cppRuntimeField_8 = this;
        MainController val_2 = MainController.instance;
        WGEventButtonV2 val_3 = 256.GetEventButton(eventId:  -1298909328);
        typeof(WFOWordHuntEvent.<>c__DisplayClass10_0).__il2cppRuntimeField_10 = 256;
        UnityEngine.GameObject val_4 = TextPreview.instance.gameObject;
        UnityEngine.Transform val_5 = TextPreview.instance.transform;
        UnityEngine.Vector3 val_6 = position;
        UnityEngine.RectTransform val_7 = 4.rectTransform;
        UnityEngine.Rect val_8 = rect;
        UnityEngine.Vector2 val_9 = size;
        UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_9.x, y:  val_9.y);
        UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = -55123.53f}, b:  new UnityEngine.Vector2() {y = val_10.x});
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Transform val_13 = transform;
        UnityEngine.UI.Image val_16 = this.CreateIconObject(worldPos:  new UnityEngine.Vector3(), size:  new UnityEngine.Vector2() {x = val_14, y = val_15}, parentTransform:  public static ScreenOverlay MonoSingleton<ScreenOverlay>::get_Instance());
        typeof(WFOWordHuntEvent.<>c__DisplayClass10_0).__il2cppRuntimeField_C = this;
        UnityEngine.Color val_17 = new UnityEngine.Color(r:  val_11.x, g:  val_11.y, b:  val_8.m_Width, a:  val_8.m_Height);
        bool val_18 = this.IsExcludedFromGameSceneButtonOrdering();
        DG.Tweening.Sequence val_19 = DG.Tweening.DOTween.Sequence();
        UnityEngine.RectTransform val_20 = this.rectTransform;
        UnityEngine.RectTransform val_21 = this.rectTransform;
        UnityEngine.Vector2 val_22 = anchoredPosition;
        float val_32 = 120f;
        val_32 = val_23 + val_32;
        DG.Tweening.Tweener val_24 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  -950566192, endValue:  val_32, duration:  val_22.y, snapping:  val_32);
        object val_25 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  -950566192, ease:  1);
        DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  -950566192);
        DG.Tweening.Tweener val_27 = DG.Tweening.ShortcutExtensions46.DOFade(target:  -950566192, endValue:  val_32, duration:  val_22.y);
        object val_28 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  -950566192, ease:  1);
        DG.Tweening.Sequence val_29 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  -950566192);
        DG.Tweening.TweenCallback val_30 = new DG.Tweening.TweenCallback(object:  336846848, method:  new IntPtr(3344376080));
        object val_31 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
    }
    private void DoProgressGameplayAnimation(System.Collections.Generic.List<UnityEngine.UI.Image> iconList, UnityEngine.UI.Image targetFlyToImage)
    {
        bool val_6;
        bool val_7;
        var val_39;
        DG.Tweening.TweenCallback val_41;
        var val_42;
        var val_43;
        var val_44;
        DG.Tweening.TweenCallback val_46;
        var val_47;
        DG.Tweening.TweenCallback val_49;
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        val_39 = null;
        val_39 = null;
        val_41 = WFOWordHuntEvent.<>c.<>9__11_0;
        if(val_41 == 0)
        {
                val_41 = null;
            val_41 = new DG.Tweening.TweenCallback(object:  WFOWordHuntEvent.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3344501392));
            WFOWordHuntEvent.<>c.<>9__11_0 = val_41;
        }
        
        DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        UnityEngine.Transform val_4 = targetFlyToImage.transform;
        UnityEngine.Vector3 val_5 = position;
        val_42 = 0;
        goto label_10;
        label_37:
        if(new System.Object() <= val_42)
        {
                var val_39 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_39 = val_39 + 0;
        typeof(WFOWordHuntEvent.<>c__DisplayClass11_0).__il2cppRuntimeField_8 = (0 + 0) + 16;
        DG.Tweening.Sequence val_9 = DG.Tweening.DOTween.Sequence();
        val_43 = 0;
        if(val_42 != 0)
        {
                UnityEngine.Transform val_10 = typeof(WFOWordHuntEvent.<>c__DisplayClass11_0).__il2cppRuntimeField_8.transform;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            UnityEngine.Transform val_11 = 2621443.transform;
            UnityEngine.Vector3 val_12 = position;
            DG.Tweening.Tweener val_13 = DG.Tweening.ShortcutExtensions.DOMove(target:  typeof(WFOWordHuntEvent.<>c__DisplayClass11_0).__il2cppRuntimeField_8, endValue:  new UnityEngine.Vector3(), duration:  val_12.x, snapping:  true);
            object val_14 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  typeof(WFOWordHuntEvent.<>c__DisplayClass11_0).__il2cppRuntimeField_8, ease:  1);
            val_44 = null;
            val_44 = null;
            val_46 = WFOWordHuntEvent.<>c.<>9__11_3;
            if(val_46 == 0)
        {
                val_46 = null;
            val_46 = new DG.Tweening.TweenCallback(object:  WFOWordHuntEvent.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3344502416));
            WFOWordHuntEvent.<>c.<>9__11_3 = val_46;
        }
        
            object val_16 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  typeof(WFOWordHuntEvent.<>c__DisplayClass11_0).__il2cppRuntimeField_8, action:  190734336);
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  typeof(WFOWordHuntEvent.<>c__DisplayClass11_0).__il2cppRuntimeField_8);
        }
        else
        {
                DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  (float)val_6);
            UnityEngine.Transform val_19 = typeof(WFOWordHuntEvent.<>c__DisplayClass11_0).__il2cppRuntimeField_8.transform;
            DG.Tweening.Tweener val_20 = DG.Tweening.ShortcutExtensions.DOMoveX(target:  typeof(WFOWordHuntEvent.<>c__DisplayClass11_0).__il2cppRuntimeField_8, endValue:  (float)val_6, duration:  val_5.y, snapping:  val_6);
            object val_21 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  typeof(WFOWordHuntEvent.<>c__DisplayClass11_0).__il2cppRuntimeField_8, ease:  3);
            val_47 = null;
            val_47 = null;
            val_49 = WFOWordHuntEvent.<>c.<>9__11_2;
            if(val_49 == 0)
        {
                val_49 = null;
            val_49 = new DG.Tweening.TweenCallback(object:  WFOWordHuntEvent.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3344503440));
            WFOWordHuntEvent.<>c.<>9__11_2 = val_49;
        }
        
            object val_23 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  typeof(WFOWordHuntEvent.<>c__DisplayClass11_0).__il2cppRuntimeField_8, action:  190734336);
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  typeof(WFOWordHuntEvent.<>c__DisplayClass11_0).__il2cppRuntimeField_8);
            UnityEngine.Transform val_25 = typeof(WFOWordHuntEvent.<>c__DisplayClass11_0).__il2cppRuntimeField_8.transform;
            DG.Tweening.Tweener val_26 = DG.Tweening.ShortcutExtensions.DOMoveY(target:  typeof(WFOWordHuntEvent.<>c__DisplayClass11_0).__il2cppRuntimeField_8, endValue:  (float)val_6, duration:  val_5.y, snapping:  val_7);
            object val_27 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  typeof(WFOWordHuntEvent.<>c__DisplayClass11_0).__il2cppRuntimeField_8, ease:  20);
            DG.Tweening.Sequence val_28 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  typeof(WFOWordHuntEvent.<>c__DisplayClass11_0).__il2cppRuntimeField_8);
            UnityEngine.RectTransform val_29 = typeof(WFOWordHuntEvent.<>c__DisplayClass11_0).__il2cppRuntimeField_8.rectTransform;
            UnityEngine.RectTransform val_30 = targetFlyToImage.rectTransform;
            val_46 = targetFlyToImage;
            UnityEngine.Vector2 val_31 = sizeDelta;
            DG.Tweening.Tweener val_32 = DG.Tweening.ShortcutExtensions46.DOSizeDelta(target:  typeof(WFOWordHuntEvent.<>c__DisplayClass11_0).__il2cppRuntimeField_8, endValue:  new UnityEngine.Vector2() {x = val_6, y = val_7}, duration:  val_31.x, snapping:  true);
            DG.Tweening.Sequence val_33 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  typeof(WFOWordHuntEvent.<>c__DisplayClass11_0).__il2cppRuntimeField_8);
        }
        
        DG.Tweening.TweenCallback val_34 = new DG.Tweening.TweenCallback(object:  336900096, method:  new IntPtr(3344504464));
        object val_35 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
        float val_40 = 0f;
        val_40 = val_40 * 0.15f;
        DG.Tweening.Sequence val_36 = DG.Tweening.TweenSettingsExtensions.Insert(s:  0, atPosition:  val_40, t:  val_40);
        val_42 = 1;
        label_10:
        if(val_42 < 0)
        {
            goto label_37;
        }
        
        DG.Tweening.TweenCallback val_37 = new DG.Tweening.TweenCallback(object:  -950436784, method:  new IntPtr(3344505488));
        object val_38 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
    }
    public WFOWordHuntEvent()
    {
    
    }
    private void <DoProgressGameplayAnimation>b__11_1()
    {
        System.Collections.Generic.List<System.String> val_1 = this.GetEventWordsSolvedInLevel();
        mem[1152921512246577028] = 0;
        goto typeof(WFOWordHuntEvent).__il2cppRuntimeField_17C;
    }

}
