using UnityEngine;
public class WGDailyChallengeWordRegion : WordRegion
{
    // Fields
    private UnityEngine.GameObject _sunPrefab;
    private UnityEngine.GameObject _moonPrefab;
    private UnityEngine.GameObject _sunParticlePrefab;
    private UnityEngine.GameObject _moonParticlePrefab;
    private UnityEngine.Transform sunMoonParticleParent;
    private WGDailyChallengeParticles sunMoonParticles;
    protected DailyChallengeDefinition dailyChallengeDefinition;
    protected System.Collections.Generic.List<string> currentLevelProgress;
    private System.Collections.Generic.Dictionary<string, string> SavedLevelProgress;
    public static System.Collections.Generic.List<UnityEngine.Transform> particleDestinations;
    private UnityEngine.UI.VerticalLayoutGroup verticalGroup;
    private UnityEngine.Vector2 regionSize;
    private float spacing;
    private int longestAnswer;
    private bool complete;
    private const float anim_delay = 0.1;
    private UnityEngine.GameObject pointer;
    private LineWord currentWord;
    private bool granting_hint;
    
    // Properties
    private UnityEngine.GameObject sunPrefab { get; }
    private UnityEngine.GameObject moonPrefab { get; }
    private UnityEngine.GameObject sunParticlePrefab { get; }
    private UnityEngine.GameObject moonParticlePrefab { get; }
    private UnityEngine.UI.VerticalLayoutGroup VerticalGroup { get; }
    public LineWord GetCurrentSunMoonWord { get; }
    private DailyChallengeGameLevel currentLevel { get; }
    
    // Methods
    private UnityEngine.GameObject get_sunPrefab()
    {
        if(this._sunPrefab != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -68924960, prefabName:  -68925040);
        this._sunPrefab = "DailyChallengeGameplay";
    }
    private UnityEngine.GameObject get_moonPrefab()
    {
        if(this._moonPrefab != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -68924960, prefabName:  -68796464);
        this._moonPrefab = "DailyChallengeGameplay";
    }
    private UnityEngine.GameObject get_sunParticlePrefab()
    {
        if(this._sunParticlePrefab != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -68924960, prefabName:  -68668000);
        this._sunParticlePrefab = "DailyChallengeGameplay";
    }
    private UnityEngine.GameObject get_moonParticlePrefab()
    {
        if(this._moonParticlePrefab != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = PrefabLoader.LoadPrefab(featureName:  -68924960, prefabName:  -68539488);
        this._moonParticlePrefab = "DailyChallengeGameplay";
    }
    private UnityEngine.UI.VerticalLayoutGroup get_VerticalGroup()
    {
        if(0 != this.verticalGroup)
        {
                return;
        }
        
        object val_2 = this.GetComponent<System.Object>();
        this.verticalGroup = this;
    }
    public LineWord get_GetCurrentSunMoonWord()
    {
    
    }
    private DailyChallengeGameLevel get_currentLevel()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance()) != 0)
        {
                return CurrentLevel;
        }
        
        return CurrentLevel;
    }
    private void OnEnable()
    {
        UnityEngine.Transform val_11;
        WGDailyChallengeParticles val_12;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_11 = 1152921504765685760;
        if((-2116505760) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(this.sunMoonParticles == 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_12 = this;
            UnityEngine.GameObject val_6 = this.sunParticlePrefab;
            val_11 = this.sunMoonParticleParent;
            object val_8 = UnityEngine.Object.Instantiate<System.Object>(original:  -68021280, parent:  val_11);
            object val_9 = this.GetComponent<System.Object>();
            this.sunMoonParticles = ;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.dailyChallengeDefinition = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_64 + 20;
    }
    private void ResetPointer(bool hintUsed)
    {
        var val_59;
        string val_60;
        UnityEngine.GameObject val_61;
        bool val_62;
        var val_63;
        int val_64;
        int val_65;
        var val_66;
        LineWord val_67;
        var val_68;
        var val_69;
        LineWord val_70;
        val_59 = 0;
        null = new RandomSet();
        goto label_1;
        label_8:
        if((R6 + 12) <= val_59)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_59 = R6 + 8;
        val_59 = val_59 + 0;
        if(((R6 + 8 + 0) + 16 + 32) == 0)
        {
                add(item:  0, weight:  null);
        }
        
        val_59 = 1;
        label_1:
        if(val_59 < ((R6 + 8 + 0) + 16 + 12))
        {
            goto label_8;
        }
        
        if((count() == 0) && (hintUsed != false))
        {
                this.PlaySunMoonParticles();
            UnityEngine.Object.DestroyImmediate(obj:  this.pointer);
            return;
        }
        
        val_61 = this.pointer;
        if(val_61 == 0)
        {
            goto label_29;
        }
        
        if(count() == 0)
        {
            goto label_18;
        }
        
        if((count() != 1) || ((this.currentWord == 0) || (this.currentWord.isShown == true)))
        {
            goto label_29;
        }
        
        DailyChallengeGameLevel val_7 = this.currentWord.isShown.currentLevel;
        val_61 = mem[this.currentWord.isShown + 44];
        val_61 = this.currentWord.isShown + 44;
        val_60 = this.currentWord.answer;
        int val_60 = this.currentWord.answer.m_stringLength;
        val_60 = val_60 - 1;
        if(val_61 != val_60)
        {
            goto label_29;
        }
        
        label_18:
        this.PlaySunMoonParticles();
        UnityEngine.Object.DestroyImmediate(obj:  this.pointer);
        DailyChallengeGameLevel val_8 = this.pointer.currentLevel;
        int val_9 = count();
        val_9 = val_9 - 1;
        val_9 = val_9 >> 5;
        mem2[0] = val_9;
        return;
        label_29:
        val_61 = this.currentWord;
        if(val_61 == 0)
        {
            goto label_37;
        }
        
        val_62 = this.currentWord.isShown;
        if(val_62 == false)
        {
            goto label_39;
        }
        
        label_37:
        DailyChallengeGameLevel val_11 = val_62.currentLevel;
        mem2[0] = val_62.GetPointerWordIndex(randomSet:  259637248);
        UnityEngine.Transform val_13 = this.transform;
        DailyChallengeGameLevel val_14 = this.currentLevel;
        UnityEngine.Transform val_15 = this.GetChild(index:  -67743392);
        object val_16 = this.GetComponent<System.Object>();
        this.currentWord = this;
        twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        DailyChallengeGameLevel val_18 = CurrentLevel;
        public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_1C = this.currentWord.answer;
        val_63 = 0;
        goto label_49;
        label_57:
        if((public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance()) <= val_63)
        {
                var val_61 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_61 = val_61 + 0;
        if(((0 + 0) + 16 + 36) == 0)
        {
            goto label_54;
        }
        
        val_63 = 1;
        label_49:
        if(val_63 < this.currentWord.answer.m_stringLength)
        {
            goto label_57;
        }
        
        goto label_58;
        label_54:
        DailyChallengeGameLevel val_19 = (0 + 0) + 16 + 36.currentLevel;
        mem2[0] = val_63;
        label_58:
        UnityEngine.Transform val_20 = this.currentWord.transform;
        DailyChallengeGameLevel val_21 = this.currentWord.currentLevel;
        UnityEngine.Transform val_22 = this.currentWord.GetChild(index:  this.currentWord);
        val_60 = this.currentWord;
        this.PlaySunMoonParticles();
        label_137:
        if(this.pointer == 0)
        {
                this.CreatePointer(parent:  val_60);
        }
        
        UnityEngine.Transform val_24 = this.pointer.transform;
        this.pointer.parent = val_60;
        UnityEngine.Transform val_25 = this.pointer.transform;
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.zero;
        this.pointer.localPosition = new UnityEngine.Vector3();
        return;
        label_39:
        if(hintUsed != false)
        {
                if(this.pointer != 0)
        {
                UnityEngine.Transform val_28 = this.pointer.transform;
            UnityEngine.Transform val_29 = this.pointer.parent;
            object val_30 = this.pointer.GetComponent<System.Object>();
            if(this.pointer == 0)
        {
                return;
        }
        
        }
        
        }
        
        UnityEngine.Transform val_31 = this.pointer.transform;
        UnityEngine.Transform val_32 = this.pointer.parent;
        val_64 = this.currentWord.answer.m_stringLength;
        DailyChallengeGameLevel val_35 = val_64.currentLevel;
        if(this.pointer.GetSiblingIndex() >= (val_64 - 1))
        {
            goto label_101;
        }
        
        UnityEngine.Transform val_36 = this.pointer.transform;
        UnityEngine.Transform val_37 = this.pointer.parent;
        int val_62 = this.pointer.GetSiblingIndex();
        label_98:
        val_62 = val_62 + 1;
        val_65 = this.currentWord.answer.m_stringLength;
        if(val_62 >= val_65)
        {
            goto label_93;
        }
        
        if(val_65 <= val_62)
        {
                var val_63 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_63 = val_63 + (val_62 << 2);
        if(((0 + (val_38) << 2) + 20 + 36) != 0)
        {
            goto label_98;
        }
        
        DailyChallengeGameLevel val_39 = (0 + (val_38) << 2) + 20 + 36.currentLevel;
        val_65 = (0 + (val_38) << 2) + 20;
        mem2[0] = val_62;
        UnityEngine.Transform val_40 = val_65.transform;
        goto label_100;
        label_104:
        DailyChallengeGameLevel val_41 = val_64.currentLevel;
        int val_42 = val_64.GetPointerWordIndex(randomSet:  259637248);
        mem2[0] = val_42;
        label_101:
        DailyChallengeGameLevel val_43 = val_42.currentLevel;
        if((val_42 + 40) == (this.currentWord.answer.m_stringLength + 40))
        {
            goto label_104;
        }
        
        UnityEngine.Transform val_44 = this.transform;
        DailyChallengeGameLevel val_45 = this.currentLevel;
        val_66 = 0;
        UnityEngine.Transform val_46 = this.GetChild(index:  -67743392);
        object val_47 = this.GetComponent<System.Object>();
        val_67 = this;
        this.currentWord = this;
        goto label_108;
        label_116:
        if(this <= val_66)
        {
                var val_64 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_64 = val_64 + 0;
        val_68 = mem[(0 + 0) + 16 + 36];
        val_68 = (0 + 0) + 16 + 36;
        if(val_68 == 0)
        {
            goto label_113;
        }
        
        val_67 = this.currentWord;
        val_66 = 1;
        label_108:
        if(val_66 < this.currentWord.answer.m_stringLength)
        {
            goto label_116;
        }
        
        goto label_127;
        label_93:
        label_100:
        DailyChallengeGameLevel val_48 = val_65.currentLevel;
        if((this.currentWord.answer.m_stringLength + 44) != (this.currentWord.answer.m_stringLength + 44))
        {
            goto label_137;
        }
        
        DailyChallengeGameLevel val_49 = this.currentWord.answer.m_stringLength + 44.currentLevel;
        mem2[0] = this.currentWord.answer.m_stringLength + 44.GetPointerWordIndex(randomSet:  259637248);
        UnityEngine.Transform val_51 = this.transform;
        DailyChallengeGameLevel val_52 = this.currentLevel;
        val_69 = 0;
        UnityEngine.Transform val_53 = this.GetChild(index:  -67743392);
        object val_54 = this.GetComponent<System.Object>();
        val_70 = this;
        this.currentWord = this;
        goto label_124;
        label_132:
        val_70 = this.currentWord;
        val_69 = 1;
        label_124:
        if(val_69 >= this.currentWord.answer.m_stringLength)
        {
            goto label_127;
        }
        
        if(this.currentWord.answer.m_stringLength <= val_69)
        {
                var val_65 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_65 = val_65 + 4;
        val_68 = mem[(0 + 4) + 16 + 36];
        val_68 = (0 + 4) + 16 + 36;
        if(val_68 != 0)
        {
            goto label_132;
        }
        
        label_113:
        DailyChallengeGameLevel val_55 = val_68.currentLevel;
        mem2[0] = val_69;
        label_127:
        UnityEngine.Transform val_56 = this.currentWord.transform;
        DailyChallengeGameLevel val_57 = this.currentWord.currentLevel;
        UnityEngine.Transform val_58 = this.currentWord.GetChild(index:  this.currentWord);
        goto label_137;
    }
    private int GetPointerWordIndex(RandomSet randomSet)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1448559232) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_5 = GetSunMoonWordIndex();
            if(val_5 != 1)
        {
                return val_5;
        }
        
        }
        
        if(randomSet != 0)
        {
                return randomSet.roll(unweighted:  false);
        }
        
        return randomSet.roll(unweighted:  false);
    }
    private void CreatePointer(UnityEngine.Transform parent)
    {
        float val_8;
        float val_9;
        UnityEngine.GameObject val_12;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_12 = this;
        UnityEngine.GameObject val_2 = this.sunPrefab;
        object val_4 = UnityEngine.Object.Instantiate<System.Object>(original:  -67347360, parent:  parent);
        this.pointer = ;
        object val_5 = this.GetComponent<System.Object>();
        object val_6 = parent.GetComponent<System.Object>();
        UnityEngine.Vector2 val_7 = sizeDelta;
        this.sizeDelta = new UnityEngine.Vector2() {x = val_8, y = val_9};
        UnityEngine.Transform val_10 = this.pointer.transform;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
        this.pointer.localPosition = new UnityEngine.Vector3();
    }
    private void LoadPointer(int wordIndex, int letterIndex)
    {
        if(mem[35631369] <= wordIndex)
        {
            goto label_2;
        }
        
        if(mem[35631369] <= wordIndex)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_2 = mem[35631365];
        val_2 = val_2 + (wordIndex << 2);
        if(((mem[35631365] + (wordIndex) << 2) + 16 + 20 + 12) <= letterIndex)
        {
            goto label_7;
        }
        
        if(((mem[35631365] + (wordIndex) << 2) + 16 + 20 + 12) <= wordIndex)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_3 = (mem[35631365] + (wordIndex) << 2) + 16 + 20 + 8;
        val_3 = val_3 + (wordIndex << 2);
        if((((mem[35631365] + (wordIndex) << 2) + 16 + 20 + 8 + (wordIndex) << 2) + 16 + 20 + 12) <= letterIndex)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_4 = ((mem[35631365] + (wordIndex) << 2) + 16 + 20 + 8 + (wordIndex) << 2) + 16 + 20 + 8;
        val_4 = val_4 + (letterIndex << 2);
        UnityEngine.Transform val_1 = (((mem[35631365] + (wordIndex) << 2) + 16 + 20 + 8 + (wordIndex) << 2) + 16 + 20 + 8 + (letterIndex) << 2) + 16.transform;
        this.CreatePointer(parent:  (((mem[35631365] + (wordIndex) << 2) + 16 + 20 + 8 + (wordIndex) << 2) + 16 + 20 + 8 + (letterIndex) << 2) + 16);
        if(((((mem[35631365] + (wordIndex) << 2) + 16 + 20 + 8 + (wordIndex) << 2) + 16 + 20 + 8 + (letterIndex) << 2) + 16 + 12) <= wordIndex)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_5 = (((mem[35631365] + (wordIndex) << 2) + 16 + 20 + 8 + (wordIndex) << 2) + 16 + 20 + 8 + (letterIndex) << 2) + 16 + 8;
        val_5 = val_5 + (wordIndex << 2);
        this.currentWord = ((((mem[35631365] + (wordIndex) << 2) + 16 + 20 + 8 + (wordIndex) << 2) + 16 + 20 + 8 + (letterIndex) << 2) + 16 + 8 + (wordIndex) << 2) + 16;
        return;
        label_2:
        UnityEngine.Debug.LogWarning(message:  -67251168);
        return;
        label_7:
        UnityEngine.Debug.LogError(message:  -67250944);
    }
    private void PlaySunMoonParticles()
    {
        var val_14 = 1152921504765685760;
        if(this.sunMoonParticles == 0)
        {
                return;
        }
        
        if(this.pointer == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_3 = this.sunMoonParticles.transform;
        UnityEngine.Transform val_4 = this.pointer.transform;
        UnityEngine.Vector3 val_5 = position;
        this.sunMoonParticles.position = new UnityEngine.Vector3();
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        DailyChallengeGameLevel val_7 = CurrentLevel;
        int val_9 = UnityEngine.Mathf.Min(a:  (WGDailyChallengeWordRegion.anim_delay + 12) - 1, b:  public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_20);
        if((WGDailyChallengeWordRegion.anim_delay + 12) <= val_9)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_14 = WGDailyChallengeWordRegion.anim_delay + 8;
        val_14 = val_14 + (val_9 << 2);
        val_14 = mem[(WGDailyChallengeWordRegion.anim_delay + 8 + (val_9) << 2) + 16];
        val_14 = (WGDailyChallengeWordRegion.anim_delay + 8 + (val_9) << 2) + 16;
        UnityEngine.Vector3 val_10 = position;
        this.sunMoonParticles.PlayParticles(destinationPosition:  new UnityEngine.Vector3());
        if((WGDailyChallengeWordRegion.anim_delay + 12) <= val_9)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_15 = WGDailyChallengeWordRegion.anim_delay + 8;
        val_15 = val_15 + (val_9 << 2);
        UnityEngine.Vector3 val_11 = new UnityEngine.Vector3(x:  val_10.x, y:  val_10.y, z:  val_10.z);
        DG.Tweening.Tweener val_12 = DG.Tweening.ShortcutExtensions.DOPunchScale(target:  (WGDailyChallengeWordRegion.anim_delay + 8 + (val_9) << 2) + 16, punch:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, duration:  val_10.x, vibrato:  1051931443, elasticity:  val_10.y);
        object val_13 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  (WGDailyChallengeWordRegion.anim_delay + 8 + (val_9) << 2) + 16, delay:  val_10.x);
    }
    private float CalculateCellSizeForLines()
    {
        var val_2;
        var val_14;
        var val_15;
        List.Enumerator<T> val_1 = GetEnumerator();
        val_14 = 0;
        goto label_2;
        label_5:
        UnityEngine.GameObject val_3 = val_2.gameObject;
        val_14 = val_14 + val_2.activeSelf;
        label_2:
        if(MoveNext() == true)
        {
            goto label_5;
        }
        
        Dispose();
        val_15 = 0;
        UnityEngine.Transform val_6 = this.transform;
        if(this != 0)
        {
                if(null != null)
        {
            
        }
        else
        {
                val_15 = this;
        }
        
        }
        
        UnityEngine.Rect val_7 = rect;
        UnityEngine.Vector2 val_8 = size;
        if(val_14 <= true)
        {
                val_14 = 1;
        }
        
        this.regionSize = new UnityEngine.Vector2();
        mem[1152921513129820052] = ???;
        UnityEngine.UI.VerticalLayoutGroup val_9 = this.VerticalGroup;
        this.spacing = ;
        UnityEngine.Vector2 val_15 = this.regionSize;
        GameBehavior val_10 = App.getBehavior;
        int val_11 = this.longestAnswer - 1;
        val_15 = val_15 / (float)this.longestAnswer;
        var val_12 = val_14 - 1;
        return (float)System.Math.Min(val1:  S18 / 1f, val2:  val_8.y);
    }
    private System.Collections.IEnumerator CalculateCellSizeNextFrame()
    {
        object val_1 = new System.Object();
        typeof(WGDailyChallengeWordRegion.<CalculateCellSizeNextFrame>d__39).__il2cppRuntimeField_8 = 0;
        typeof(WGDailyChallengeWordRegion.<CalculateCellSizeNextFrame>d__39).__il2cppRuntimeField_10 = this;
    }
    public override void UpdateOverlayUI(LineWord word, bool hintUsed)
    {
        bool val_31;
        UnityEngine.GameObject val_32;
        var val_33;
        System.Predicate<Cell> val_35;
        val_31 = static_value_021FB101;
        if(val_31 != true)
        {
                val_31 = true;
        }
        
        DailyChallengeGameLevel val_1 = this.currentLevel;
        val_32 = val_31;
        if(5 != 0)
        {
                return;
        }
        
        if(word == 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            DailyChallengeGameLevel val_4 = CurrentLevel;
            val_32 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
            DailyChallengeGameLevel val_5 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_25.currentLevel;
            DailyChallengeGameLevel val_6 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_25.currentLevel;
            this.LoadPointer(wordIndex:  public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_25 + 40, letterIndex:  public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_25 + 44);
            return;
        }
        
        if(word != 0)
        {
                val_32 = this.pointer;
            if(val_32 != 0)
        {
                UnityEngine.Transform val_9 = this.pointer.transform;
            UnityEngine.Transform val_10 = this.pointer.parent;
            UnityEngine.Transform val_11 = this.pointer.parent;
            object val_12 = this.pointer.GetComponent<System.Object>();
            val_32 = word.answer;
            if(word.isShown != false)
        {
                if((System.String.op_Equality(a:  val_32, b:  -67888224)) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_32 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
            OnPointsGained(word:  word.answer);
        }
        else
        {
                T[] val_15 = this.pointer.GetComponentsInChildren<System.Object>();
            System.Collections.Generic.List<TSource> val_16 = System.Linq.Enumerable.ToList<System.Object>(source:  this.pointer);
            val_33 = null;
            val_33 = null;
            val_35 = WGDailyChallengeWordRegion.<>c.<>9__40_0;
            if(val_35 == 0)
        {
                val_35 = null;
            val_35 = new System.Predicate<ZooTile>(object:  WGDailyChallengeWordRegion.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4228227040));
            WGDailyChallengeWordRegion.<>c.<>9__40_0 = val_35;
        }
        
            System.Collections.Generic.List<T> val_18 = this.pointer.FindAll(match:  8040448);
            UnityEngine.Transform val_19 = this.pointer.transform;
            UnityEngine.Transform val_20 = this.pointer.parent;
            UnityEngine.Transform val_22 = this.pointer.transform;
            val_32 = this.pointer;
            int val_23 = val_32.childCount;
            if(1152921504993959936 != 1)
        {
                val_23 = val_23 - 1;
        }
        
            if(this.pointer.GetSiblingIndex() == val_23)
        {
                val_32 = 1152921511080275808;
            twelvegigs.Autopilot.AutopilotManager val_24 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_25 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_58.Invoke();
        }
        
        }
        
        }
        
        }
        
        }
        
        this.ResetPointer(hintUsed:  hintUsed);
        twelvegigs.Autopilot.AutopilotManager val_26 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_27 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        DailyChallengeGameLevel val_28 = CurrentLevel;
        public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_25 = 1;
        twelvegigs.Autopilot.AutopilotManager val_29 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        DailyChallengeGameLevel val_30 = CurrentLevel;
        if((public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance()) == 0)
        {
            
        }
    
    }
    public override void UpdateProgressBar()
    {
        WGDailyChallengeMainController val_1 = WGDailyChallengeMainController.SpecificInstance;
        this.UpdateProgressBar(delay:  null);
    }
    public override void Load(GameLevel gameLevel, System.Action loadCompleteCallback)
    {
        this.Load(gameLevel:  gameLevel, loadCompleteCallback:  loadCompleteCallback);
    }
    private System.Collections.Generic.Dictionary<string, string> LoadLevelProgress()
    {
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -66357152, defaultValue:  -2040381152);
        return Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  -66357152);
    }
    private void ClearLevelProgress()
    {
        UnityEngine.PlayerPrefs.DeleteKey(key:  -66357152);
    }
    public override void SaveLevelProgress()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        GameLevel val_2 = PlayingLevel.GetLevel(currentMode:  2, parameters:  0);
        if(2 == 0)
        {
                return;
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_60 + 52);
        List.Enumerator<T> val_4 = GetEnumerator();
        this = "0";
        label_24:
        if(MoveNext() == false)
        {
            goto label_12;
        }
        
        List.Enumerator<T> val_8 = GetEnumerator();
        float val_12 = 0f;
        label_18:
        if(MoveNext() == false)
        {
            goto label_15;
        }
        
        if((val_10 + 36) == 0)
        {
                "1" = this;
        }
        
        System.Text.StringBuilder val_11 = Append(value:  1254115712);
        goto label_18;
        label_15:
        val_12 = val_12 + 1;
        mem2[0] = 151;
        Dispose();
        if(val_12 != 1)
        {
                if(val_12 > 1)
        {
                0 = 1;
        }
        
            var val_13 = -66120128 + ((0 + 1)) << 2;
            val_13 = val_13 - 151;
            val_13 = val_13 >> 5;
            val_13 = 1 & val_13;
            val_12 = val_12 - val_13;
        }
        
        Add(item:  24121344);
        goto label_24;
        label_12:
        Dispose();
        mem[10] = null;
        PlayingLevel.Save();
    }
    private string SerializeAnswer(string answer, int revealed)
    {
        var val_3;
        System.Text.StringBuilder val_1 = null;
        val_3 = 0;
        val_1 = new System.Text.StringBuilder();
        goto label_1;
        label_4:
        if(val_3 < revealed)
        {
                "0" = "1";
        }
        
        System.Text.StringBuilder val_2 = Append(value:  1633189168);
        val_3 = 1;
        label_1:
        if(val_3 < answer.m_stringLength)
        {
            goto label_4;
        }
        
        if(val_1 == 0)
        {
            
        }
    
    }
    private string SerializeAnswer(LineWord alreadyHintedLine)
    {
        List.Enumerator<T> val_2 = GetEnumerator();
        label_6:
        if(MoveNext() == false)
        {
            goto label_3;
        }
        
        if((val_4 + 36) == 0)
        {
                "1" = "0";
        }
        
        System.Text.StringBuilder val_5 = Append(value:  1254115712);
        goto label_6;
        label_3:
        Dispose();
        if(new System.Text.StringBuilder() != 0)
        {
                return;
        }
    
    }
    private void GrantHint(LineWord line)
    {
        var val_9;
        LineWord val_10;
        object val_1 = new System.Object();
        if(val_1 != 0)
        {
                val_9 = val_1;
            typeof(WGDailyChallengeWordRegion.<>c__DisplayClass49_0).__il2cppRuntimeField_8 = line;
        }
        else
        {
                val_9 = 8;
            mem[8] = line;
        }
        
        typeof(WGDailyChallengeWordRegion.<>c__DisplayClass49_0).__il2cppRuntimeField_C = this;
        if(this.complete == false)
        {
                this.complete = this.granting_hint;
            goto label_3;
        }
        
        return;
        label_3:
        this.granting_hint = true;
        UnityEngine.GameObject val_2 = mem[8].gameObject;
        val_10 = mem[8];
        if(val_10.activeSelf != true)
        {
                UnityEngine.GameObject val_4 = mem[8].gameObject;
            mem[8].SetActive(value:  true);
            mem[8].MakeVisible(visible:  false);
            val_10 = mem[8];
            if((line + 24) > this.longestAnswer)
        {
                val_10 = mem[8];
            this.longestAnswer = line + 24;
        }
        
            System.Collections.IEnumerator val_5 = this.CalculateCellSizeNextFrame();
            UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  -65742320);
        }
        
        DG.Tweening.TweenCallback val_7 = new DG.Tweening.TweenCallback(object:  387166208, method:  new IntPtr(4229199952));
        DG.Tweening.Tween val_8 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1036831949, ignoreTimeScale:  false);
    }
    public override void HintReward()
    {
        var val_4;
        System.Predicate<LineWord> val_6;
        if(this.complete == false)
        {
                this.complete = this.granting_hint;
            goto label_1;
        }
        
        return;
        label_1:
        val_4 = null;
        val_4 = null;
        val_6 = WGDailyChallengeWordRegion.<>c.<>9__50_0;
        if(val_6 == 0)
        {
                val_6 = null;
            val_6 = new System.Predicate<ZooTile>(object:  WGDailyChallengeWordRegion.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4229317072));
            WGDailyChallengeWordRegion.<>c.<>9__50_0 = val_6;
        }
        
        object val_2 = static_value_021FB108.Find(match:  8040448);
        if(static_value_021FB108 == 0)
        {
                return;
        }
        
        this.GrantHint(line:  static_value_021FB108);
    }
    public override void HintClick(bool free = False, LineWord line, Cell cell, bool isPickerHint = False)
    {
        LineWord val_3;
        bool val_4;
        var val_5;
        var val_6;
        val_3 = line;
        val_4 = static_value_021FB109;
        if(val_4 != true)
        {
                val_4 = true;
        }
        
        if(isPickerHint != true)
        {
                DailyChallengeGameLevel val_1 = this.currentLevel;
            if(5 == 0)
        {
                val_3 = this.currentWord;
        }
        
        }
        
        this.HintClick(free:  free, line:  val_3, cell:  cell, isPickerHint:  isPickerHint);
        Player val_2 = App.Player;
        val_5 = 2621448;
        if(val_5 != 0)
        {
                val_6 = 35143864;
        }
        else
        {
                val_5 = 68;
            val_6 = 256;
        }
        
        mem[68] = 257;
    }
    public override void DoFreeHint(LineWord line, Cell cell, UnityEngine.Transform hintAnimStartTransform)
    {
        DailyChallengeGameLevel val_1 = this.currentLevel;
        if(this == 0)
        {
                line = this.currentWord;
        }
        
        this.DoFreeHint(line:  line, cell:  cell, hintAnimStartTransform:  hintAnimStartTransform);
    }
    public override void CheckAnswer(string checkWord)
    {
        this.CheckAnswer(checkWord:  checkWord);
    }
    private void CheckAnswerBetter(string checkWord, bool fromHint = False)
    {
        int val_27;
        var val_32;
        string val_33;
        int val_35;
        var val_36;
        DG.Tweening.TweenCallback val_38;
        val_32 = this;
        val_33 = checkWord;
        object val_1 = new System.Object();
        typeof(WGDailyChallengeWordRegion.<>c__DisplayClass54_0).__il2cppRuntimeField_8 = val_33;
        if(this.complete == true)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  val_33)) == true)
        {
            goto label_16;
        }
        
        if((checkWord + 8) < this.dailyChallengeDefinition.MinRequiredLength)
        {
                checkWord + 8.FadeOut();
            checkWord + 8.SetWrongColor();
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  5, oneshot:  true, pitch:  null, vol:  null);
            WGDailyChallengeMainController val_4 = WGDailyChallengeMainController.SpecificInstance;
            string val_5 = Localization.Localize(key:  -65127472, defaultValue:  -65127360, useSingularKey:  false);
            string val_6 = this.dailyChallengeDefinition.MinRequiredLength.ToString();
            string val_7 = System.String.Format(format:  -65127472, arg0:  this.dailyChallengeDefinition.MinRequiredLength);
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.ShowMessage(message:  -65127472);
            return;
        }
        
        if((this.dailyChallengeDefinition.Contains(item:  typeof(WGDailyChallengeWordRegion.<>c__DisplayClass54_0).__il2cppRuntimeField_8)) == false)
        {
            goto label_16;
        }
        
        System.Predicate<ZooTile> val_9 = new System.Predicate<ZooTile>(object:  387219456, method:  new IntPtr(4229844176));
        object val_10 = this.dailyChallengeDefinition.Find(match:  8040448);
        if(this.dailyChallengeDefinition == 0)
        {
            goto label_20;
        }
        
        if((fromHint == true) || (this.dailyChallengeDefinition.MaxRequiredWordsAmount == 0))
        {
            goto label_23;
        }
        
        SetExistColor();
        this.dailyChallengeDefinition.ShowExists();
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  6, oneshot:  true, pitch:  null, vol:  null);
        goto label_36;
        label_16:
        static_value_021FB10A.FadeOut();
        this.SetWrongColor();
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  5, oneshot:  true, pitch:  null, vol:  null);
        return;
        label_20:
        val_32 = 1152921513131705160;
        goto label_36;
        label_23:
        SetAnswerColor();
        if(null != 0)
        {
                GameEcon val_14 = App.getGameEcon;
            var val_15 = 0 + 412;
            CurrencyController.CreditBalance(value:  new System.Decimal() {flags = mem[(0 + 412) + (0)], hi = mem[(0 + 412) + (4)], lo = mem[(0 + 412) + (8)], mid = mem[(0 + 412) + (12)]}, source:  "Word Coin Bonus", externalParams:  0, animated:  false);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  4, oneshot:  true, pitch:  null, vol:  null);
        bool val_17 = this.SavedLevelProgress.ContainsKey(key:  typeof(WGDailyChallengeWordRegion.<>c__DisplayClass54_0).__il2cppRuntimeField_8);
        string val_18 = val_17.SerializeAnswer(answer:  typeof(WGDailyChallengeWordRegion.<>c__DisplayClass54_0).__il2cppRuntimeField_8, revealed:  checkWord + 8);
        if(val_17 != false)
        {
                this.SavedLevelProgress.set_Item(key:  typeof(WGDailyChallengeWordRegion.<>c__DisplayClass54_0).__il2cppRuntimeField_8, value:  val_17);
        }
        else
        {
                this.SavedLevelProgress.Add(key:  typeof(WGDailyChallengeWordRegion.<>c__DisplayClass54_0).__il2cppRuntimeField_8, value:  val_17);
        }
        
        UnityEngine.GameObject val_19 = this.dailyChallengeDefinition.gameObject;
        if(this.dailyChallengeDefinition.activeSelf != true)
        {
                UnityEngine.GameObject val_21 = this.dailyChallengeDefinition.gameObject;
            this.dailyChallengeDefinition.SetActive(value:  true);
            this.dailyChallengeDefinition.MakeVisible(visible:  false);
            if((this.dailyChallengeDefinition + 24) > this.longestAnswer)
        {
                this.longestAnswer = this.dailyChallengeDefinition + 24;
        }
        
            System.Collections.IEnumerator val_22 = this.CalculateCellSizeNextFrame();
            UnityEngine.Coroutine val_23 = this.StartCoroutine(routine:  -65076464);
        }
        
        if(fromHint != true)
        {
                this.dailyChallengeDefinition.ShowAnswer(waitTime:  null);
        }
        
        val_35 = this.dailyChallengeDefinition.MinRequiredWordsAmount;
        System.Collections.Generic.List<System.String> val_24 = this.currentLevelProgress + 1;
        if(val_24 >= val_35)
        {
                0 = 1;
        }
        
        this.complete = true;
        if(val_24 >= val_35)
        {
                Player val_25 = App.Player;
            decimal val_26 = GetReward;
            val_35 = 0;
            val_35.AddCredits(amount:  new System.Decimal() {mid = val_27}, source:  "Daily Challenge Stage {0}", subSource:  0, externalParams:  0, doTrack:  true);
        }
        
        WGDailyChallengeMainController val_28 = WGDailyChallengeMainController.SpecificInstance;
        val_35.UpdateProgressBar(delay:  null);
        if(this.complete != false)
        {
                WGDailyChallengeMainController val_29 = WGDailyChallengeMainController.SpecificInstance;
            mem2[0] = 1;
            val_36 = null;
            val_36 = null;
            val_38 = WGDailyChallengeWordRegion.<>c.<>9__54_1;
            if(val_38 == 0)
        {
                val_38 = null;
            val_38 = new DG.Tweening.TweenCallback(object:  WGDailyChallengeWordRegion.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4229865808));
            WGDailyChallengeWordRegion.<>c.<>9__54_1 = val_38;
        }
        
            DG.Tweening.Tween val_31 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1045220557, ignoreTimeScale:  false);
            this.ClearLevelProgress();
            bool val_32 = PrefsSerializationManager.SavePlayerPrefs();
        }
        
        val_32 = -65076408;
        label_36:
        FadeOut();
    }
    public override void Hack_GrantWord()
    {
        var val_5;
        var val_6;
        System.Predicate<LineWord> val_8;
        val_5 = 1152921504993959936;
        val_6 = null;
        val_6 = null;
        val_8 = WGDailyChallengeWordRegion.<>c.<>9__55_0;
        if(val_8 == 0)
        {
                val_8 = null;
            val_8 = new System.Predicate<ZooTile>(object:  WGDailyChallengeWordRegion.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4230011600));
            WGDailyChallengeWordRegion.<>c.<>9__55_0 = val_8;
        }
        
        System.Collections.Generic.List<T> val_2 = static_value_021FB10B.FindAll(match:  8040448);
        if(35631371 == 0)
        {
                return;
        }
        
        if(mem[35631383] < 1)
        {
                return;
        }
        
        int val_3 = UnityEngine.Random.Range(min:  0, max:  mem[35631383]);
        if(mem[35631383] <= val_3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_4 = mem[35631379];
        val_4 = val_4 + (val_3 << 2);
        if(((mem[35631379] + (val_3) << 2) + 16) == 0)
        {
            
        }
    
    }
    public void Hack_GrantSunMoonWord()
    {
        if(this.currentWord == 0)
        {
            
        }
    
    }
    public void Hack_CompleteLevel()
    {
        var val_3 = 0;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        DailyChallengeGameLevel val_2 = CurrentLevel;
    }
    public WGDailyChallengeWordRegion()
    {
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  null, y:  null);
    }

}
