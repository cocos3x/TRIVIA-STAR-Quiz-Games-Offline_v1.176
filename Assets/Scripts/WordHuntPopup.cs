using UnityEngine;
public class WordHuntPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.RectTransform displayWordParent;
    private Cell cellPrefab;
    private LineWord lineWordPrefab;
    private float cellSizeSmall;
    private float cellSizeLarge;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Button playButton;
    private UnityEngine.UI.Button coinCollectButton;
    private UnityEngine.UI.Button continueButton;
    private UnityEngine.GameObject spinRewardGroup;
    private UnityEngine.GameObject wheelRewardGroup;
    private UnityEngine.UI.Text themeText;
    private UnityEngine.UI.Text rewardText;
    private UnityEngine.UI.Text collectCoinValueText;
    private UnityEngine.UI.Text timerText;
    private UnityEngine.UI.Text playButtonText;
    private GridCoinCollectAnimationInstantiator gcAi;
    private UnityEngine.ParticleSystem victoryEffect;
    
    // Methods
    private void Start()
    {
        if(WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP != null)
        {
                this.Close();
            return;
        }
        
        if(WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP != null)
        {
                this.Init();
            return;
        }
        
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    private void Init()
    {
        UnityEngine.GameObject val_1 = this.victoryEffect.gameObject;
        this.victoryEffect.SetActive(value:  false);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -936689552, method:  new IntPtr(3358247600));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.GameObject val_3 = this.closeButton.gameObject;
        this.closeButton.SetActive(value:  false);
        this.BuildUI();
        this.UpdateFeaturePoint();
        UnityEngine.GameObject val_4 = this.gameObject;
        UnityEngine.UI.LayoutElement val_5 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -936689552);
        System.Action val_6 = new System.Action(object:  -936689552, method:  new IntPtr(3358252720));
        this.cellSizeSmall = null;
    }
    public void BuildUI()
    {
        ZooTile val_39;
        UnityEngine.Object val_50;
        var val_59;
        System.Func<System.String, System.String> val_61;
        var val_62;
        System.Func<System.String, System.Int32> val_64;
        UnityEngine.UI.Button val_65;
        var val_66;
        WordHuntPopup val_67;
        float val_68;
        UnityEngine.Events.UnityAction val_69;
        float val_70;
        var val_71;
        string val_72;
        var val_73;
        if(this.displayWordParent.childCount >= 1)
        {
                MethodExtensionForMonoBehaviourTransform.DestroyChildren(t:  this.displayWordParent);
        }
        
        this.coinCollectButton.m_OnClick.RemoveAllListeners();
        this.coinCollectButton.interactable = true;
        this.playButton.m_OnClick.RemoveAllListeners();
        this.playButton.interactable = true;
        val_59 = null;
        val_59 = null;
        val_61 = WordHuntPopup.<>c.<>9__20_0;
        if(val_61 == 0)
        {
                val_61 = null;
            val_61 = new System.Func<ZooTile, System.String>(object:  WordHuntPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3358410800));
            WordHuntPopup.<>c.<>9__20_0 = val_61;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_3 = System.Linq.Enumerable.OrderBy<System.Object, System.Object>(source:  WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP + 20, keySelector:  7720960);
        System.Collections.Generic.IEnumerable<TSource> val_4 = System.Linq.Enumerable.Reverse<System.Object>(source:  WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP + 20);
        val_62 = null;
        val_62 = null;
        val_64 = WordHuntPopup.<>c.<>9__20_1;
        if(val_64 == 0)
        {
                val_64 = null;
            val_64 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  WordHuntPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3358413872));
            WordHuntPopup.<>c.<>9__20_1 = val_64;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_6 = System.Linq.Enumerable.OrderByDescending<System.Object, System.Int32>(source:  WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP + 20, keySelector:  7720960);
        System.Collections.Generic.IEnumerable<TSource> val_7 = System.Linq.Enumerable.Reverse<System.Object>(source:  WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP + 20);
        System.Collections.Generic.List<TSource> val_8 = System.Linq.Enumerable.ToList<System.Object>(source:  WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP + 20);
        string val_9 = WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP.eventTheme;
        this.spinRewardGroup.SetActive(value:  false);
        this.wheelRewardGroup.SetActive(value:  false);
        UnityEngine.GameObject val_10 = this.coinCollectButton.gameObject;
        this.coinCollectButton.SetActive(value:  false);
        UnityEngine.GameObject val_11 = this.playButton.gameObject;
        GameBehavior val_12 = App.getBehavior;
        this.playButton.SetActive(value:  true);
        if(mem[1152921512260288984] == 0)
        {
                UnityEngine.Debug.LogError(message:  -936536016);
        }
        else
        {
                string val_14 = Localization.Localize(key:  -1672741904, defaultValue:  2127161280, useSingularKey:  false);
            Player val_15 = App.Player;
            string val_16 = System.String.Format(format:  -1672741904, arg0:  13152256);
        }
        
        UnityEngine.GameObject val_17 = mem[1152921512260288956].gameObject;
        GameBehavior val_18 = App.getBehavior;
        if(mem[1152921512260288956] != 0)
        {
                -1 = 1;
        }
        
        mem[1152921512260288956].SetActive(value:  true);
        UnityEngine.Events.UnityAction val_19 = new UnityEngine.Events.UnityAction(object:  -936492656, method:  new IntPtr(3358439632));
        this.continueButton.m_OnClick.AddListener(call:  162246656);
        GameBehavior val_21 = App.getBehavior;
        val_65 = this.playButton;
        val_66 = WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP + 20;
        if(WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP != null)
        {
                (WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP + 28) - 1 = val_66;
        }
        
        if(WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP != null)
        {
            goto label_53;
        }
        
        val_67 = this;
        val_68 = mem[1152921512260288940];
        if(WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP == null)
        {
            goto label_55;
        }
        
        UnityEngine.GameObject val_23 = val_65.gameObject;
        val_65.SetActive(value:  false);
        UnityEngine.GameObject val_24 = this.coinCollectButton.gameObject;
        this.coinCollectButton.SetActive(value:  true);
        val_65 = this.coinCollectButton;
        string val_25 = WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP + 32.ToString();
        if(mem[1152921512260288976] != 0)
        {
            goto label_83;
        }
        
        goto label_83;
        label_53:
        if((WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP + 28) != 4)
        {
            goto label_64;
        }
        
        val_67 = this;
        val_68 = mem[1152921512260288936];
        this.spinRewardGroup.SetActive(value:  true);
        val_69 = 1152921504769093632;
        if(WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP == null)
        {
            goto label_67;
        }
        
        if(mem[1152921512260288984] != 0)
        {
            goto label_82;
        }
        
        goto label_82;
        label_55:
        System.Text.StringBuilder val_26 = Append(value:  -936526640);
        if(new System.Text.StringBuilder() == 0)
        {
            goto label_72;
        }
        
        System.Text.StringBuilder val_27 = Append(value:  WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP + 32);
        goto label_73;
        label_64:
        if((WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP + 28) != 3)
        {
            goto label_75;
        }
        
        val_68 = mem[1152921512260288936];
        this.wheelRewardGroup.SetActive(value:  true);
        if(WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP == null)
        {
            goto label_78;
        }
        
        val_67 = this;
        val_66 = (WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP + 28) - 1;
        goto label_83;
        label_67:
        string val_28 = Localization.Localize(key:  -936526208, defaultValue:  -936526496, useSingularKey:  false);
        System.Text.StringBuilder val_29 = Append(value:  -936526208);
        goto label_82;
        label_75:
        val_68 = 0f;
        val_66 = (WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP + 28) - 1;
        val_67 = this;
        goto label_83;
        label_72:
        System.Text.StringBuilder val_30 = Append(value:  WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP + 32);
        label_73:
        System.Text.StringBuilder val_31 = Append(value:  -936526064);
        label_83:
        val_69 = 1152921504769093632;
        label_82:
        if(WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP != null)
        {
                System.Text.StringBuilder val_32 = Append(value:  -936525984);
            val_69 = new UnityEngine.Events.UnityAction(object:  -936492656, method:  new IntPtr(3358445520));
            this.playButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.GameObject val_34 = mem[1152921512260288992].gameObject;
            mem[1152921512260288992].SetActive(value:  true);
            mem[1152921512260288992].Play();
        }
        else
        {
                UnityEngine.GameObject val_35 = mem[1152921512260288944].gameObject;
            mem[1152921512260288944].SetActive(value:  true);
            UnityEngine.Events.UnityAction val_36 = new UnityEngine.Events.UnityAction(object:  -936492656, method:  new IntPtr(3358439632));
            this.playButton.m_OnClick.AddListener(call:  162246656);
        }
        
        List.Enumerator<T> val_37 = 0.GetEnumerator();
        val_70 = 1152921511082600128;
        if(MoveNext() == false)
        {
            goto label_100;
        }
        
        object val_40 = UnityEngine.Object.Instantiate<System.Object>(original:  mem[1152921512260288932]);
        string val_41 = val_39.ToUpper();
        if(mem[1152921512260288932] != 0)
        {
                mem2[0] = val_68;
            mem2[0] = val_39;
        }
        else
        {
                mem[12] = val_39;
            mem[16] = val_68;
        }
        
        mem[1152921512260288932].SetLineWidth();
        UnityEngine.GameObject val_42 = mem[1152921512260288932].gameObject;
        object val_43 = mem[1152921512260288932].AddComponent<System.Object>();
        mem[1152921512260288932].Build(cellType:  mem[1152921512260288928], clickable:  true);
        if((WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP + 24.Contains(item:  val_39)) == false)
        {
            goto label_112;
        }
        
        System.Text.StringBuilder val_45 = new System.Text.StringBuilder();
        val_71 = 0;
        goto label_113;
        label_116:
        char val_46 = val_39.Chars[WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP + 32];
        System.Text.StringBuilder val_47 = Append(value:  1);
        val_71 = (WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP + 32) + 1;
        label_113:
        if(val_71 < (val_39 + 8))
        {
            goto label_116;
        }
        
        mem[1152921512260288932].SetProgress(progress:  24121344);
        label_112:
        List.Enumerator<T> val_48 = 0.GetEnumerator();
        label_135:
        if(MoveNext() == false)
        {
            goto label_121;
        }
        
        val_72 = WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP;
        if(val_72 != null)
        {
                val_73 = mem[WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP + 44];
            val_73 = WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP + 44;
        }
        else
        {
                val_73 = mem[WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP + 44];
            val_73 = WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP + 44;
            val_72 = WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP;
            if(val_72 == null)
        {
                val_72 = 0;
        }
        
        }
        
        string val_51 = val_72.currentColor;
        string val_52 = val_72.ToUpper();
        UnityEngine.Color32 val_53 = val_73.Item[0];
        val_50.SetNewBackgroundAndColor(bgColor:  new UnityEngine.Color32() {r = val_53.r, g = val_53.g, b = val_53.b, a = val_53.a});
        object val_54 = val_50.GetComponent<System.Object>();
        if(val_50 == 0)
        {
            goto label_135;
        }
        
        object val_56 = val_50.GetComponent<System.Object>();
        val_50 + 172.RemoveAllListeners();
        goto label_135;
    }
    private void PlayButtonClick()
    {
        var val_3;
        this.UpdateFeaturePoint();
        val_3 = 1152921504892043264;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 2)
        {
                GameBehavior val_2 = App.getBehavior;
        }
        
        this.Close();
    }
    private void CollectButtonClick()
    {
        int val_6;
        mem2[0] = 0;
        this.coinCollectButton.interactable = false;
        this.playButton.interactable = false;
        if((WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP + 28) != 3)
        {
            goto label_6;
        }
        
        WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP.CollectReward();
        label_8:
        this.Close();
        return;
        label_6:
        if((WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP + 28) != 1)
        {
            goto label_8;
        }
        
        System.Action val_1 = new System.Action(object:  -936185712, method:  new IntPtr(3358752464));
        this.gcAi.OnCompleteCallback = null;
        WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP.CollectReward();
        Player val_2 = App.Player;
        decimal val_3 = System.Decimal.op_Implicit(value:  -936197764);
        decimal val_4 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -936197780, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
        Player val_5 = App.Player;
        this.gcAi.Play(fromValue:  new System.Decimal() {mid = val_6}, toValue:  new System.Decimal() {}, textTickTime:  null, delayBeforeComplete:  null);
    }
    private void UpdateTimerText()
    {
        var val_5;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512260720376}, d2:  new System.DateTime() {dateData = WordHuntEvent.SHOW_WORD_FOUND_TOOLTIP.m_stringLength + 32});
        int val_7 = val_5.Days;
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        int val_8 = val_5.Hours;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        int val_9 = val_5.Minutes;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        int val_10 = val_5.Seconds;
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        string val_11 = System.String.Format(format:  -1536980304, args:  472754880);
        double val_12 = val_5.TotalSeconds;
    }
    private void UpdateFeaturePoint()
    {
        var val_4;
        var val_5;
        FeatureAccessPoints val_6;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 1)
        {
                val_4 = 1152921504895770624;
            var val_3 = 23022615;
            val_3 = 12603176 + val_3;
            if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
            val_5 = null;
            val_6 = 50;
        }
        else
        {
                GameBehavior val_2 = App.getBehavior;
            if(0 != 2)
        {
                return;
        }
        
            val_4 = 1152921504895770624;
            var val_4 = 23022419;
            val_4 = 12603372 + val_4;
            if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
            val_5 = null;
            val_6 = 51;
        }
        
        AmplitudePluginHelper.lastFeatureAccessPoint = val_6;
    }
    public void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    public WordHuntPopup()
    {
        this.cellSizeSmall = 60f;
        this.cellSizeLarge = 70f;
    }
    private void <Init>b__19_0()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }

}
