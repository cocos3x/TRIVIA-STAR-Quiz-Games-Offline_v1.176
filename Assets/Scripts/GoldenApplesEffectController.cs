using UnityEngine;
public class GoldenApplesEffectController : MonoSingleton<GoldenApplesEffectController>
{
    // Fields
    private UnityEngine.GameObject effectParent;
    private float tweeningDuration;
    private UnityEngine.UI.Image borderGlow;
    private UnityEngine.ParticleSystem borderParticles;
    private UnityEngine.UI.Image starTexture;
    private CRotate starRotation;
    private const int effectLevelCount = 11;
    private float[] borderAlphaValues;
    private int[] particleRateOverTimeValues;
    private float[] starRotationSpeedValues;
    private UnityEngine.ParticleSystem.EmissionModule emissionModule;
    private DG.Tweening.Sequence mySequence;
    
    // Methods
    public override void InitMonoSingleton()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_8 = 29104823;
        val_8 = 6520964 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_8 = null;
        val_8 = null;
        if(App.game == 18)
        {
                UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Object.Destroy(obj:  -1243871120);
        }
        
        WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_3 = new System.Action<Result>(object:  -1243871120, method:  new IntPtr(3051070128));
        System.Delegate val_4 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
        val_9 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_9 != 0)
        {
                if(val_9 == null)
        {
            goto label_14;
        }
        
        }
        
        val_9 = 0;
        label_14:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_9;
        WordPets.WPTDataParser val_5 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_6 = new System.Action<Result>(object:  -1243871120, method:  new IntPtr(3051071152));
        System.Delegate val_7 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10, b:  7401472);
        val_10 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10;
        if(val_10 != 0)
        {
                if(val_10 == null)
        {
            goto label_18;
        }
        
        }
        
        val_10 = 0;
        label_18:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10 = val_10;
    }
    private void Start()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1243754000, method:  new IntPtr(3051184176));
        public static AdsUIController MonoSingleton<AdsUIController>::get_Instance().__il2cppRuntimeField_1C.AddListener(call:  162246656);
        EmissionModule val_3 = this.borderParticles.emission;
        this.emissionModule = val_3.m_ParticleSystem;
        this.StopEffects();
        this.InitializeGameObjectStates();
        this.ResizeParticleSystem(adsHeight:  null);
    }
    private void OnDestroy()
    {
        var val_7;
        var val_8;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_2 = new System.Action<Result>(object:  -1243637904, method:  new IntPtr(3051070128));
        System.Delegate val_3 = System.Delegate.Remove(source:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, value:  7401472);
        val_7 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_7 != 0)
        {
                if(val_7 == null)
        {
            goto label_6;
        }
        
        }
        
        val_7 = 0;
        label_6:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_7;
        WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_5 = new System.Action<Result>(object:  -1243637904, method:  new IntPtr(3051071152));
        System.Delegate val_6 = System.Delegate.Remove(source:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10, value:  7401472);
        val_8 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10;
        if(val_8 != 0)
        {
                if(val_8 == null)
        {
            goto label_10;
        }
        
        }
        
        val_8 = 0;
        label_10:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10 = val_8;
    }
    private void Instance_OnSceneLoaded(SceneType obj)
    {
        if((obj | 2) != 6)
        {
                return;
        }
        
        this.effectParent.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.borderParticles.gameObject;
        this.borderParticles.SetActive(value:  false);
    }
    private void Instance_OnSceneUnloaded(SceneType obj)
    {
        if((obj | 2) != 6)
        {
                return;
        }
        
        this.effectParent.SetActive(value:  true);
        UnityEngine.GameObject val_2 = this.borderParticles.gameObject;
        this.borderParticles.SetActive(value:  true);
    }
    public void StopEffects()
    {
        float val_2;
        UnityEngine.AnimationCurve val_3;
        float val_4;
        MinMaxCurve val_1 = ParticleSystem.MinMaxCurve.op_Implicit(constant:  (float)this.particleRateOverTimeValues[0]);
        val_1.m_ConstantMax.rateOverTime = new MinMaxCurve() {m_CurveMax = val_3, m_ConstantMin = val_2, m_ConstantMax = val_4};
        val_1.m_ConstantMin + 12.SetActive(value:  false);
        DG.Tweening.Sequence val_5 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Core.DOGetter<System.Single> val_6 = new DG.Tweening.Core.DOGetter<System.Single>(object:  val_1.m_ConstantMin, method:  new IntPtr(3051727408));
        DG.Tweening.Core.DOSetter<System.Single> val_7 = new DG.Tweening.Core.DOSetter<System.Single>(object:  val_1.m_ConstantMin, method:  new IntPtr(3051728432));
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_8 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  (float)this.particleRateOverTimeValues[0], duration:  null);
        DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  198828032);
        DG.Tweening.Core.DOGetter<System.Single> val_10 = new DG.Tweening.Core.DOGetter<System.Single>(object:  val_1.m_ConstantMin, method:  new IntPtr(3051729456));
        DG.Tweening.Core.DOSetter<System.Single> val_11 = new DG.Tweening.Core.DOSetter<System.Single>(object:  val_1.m_ConstantMin, method:  new IntPtr(3051730480));
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_12 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  (float)this.particleRateOverTimeValues[0], duration:  null);
        DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  198828032);
        DG.Tweening.Core.DOGetter<System.Single> val_14 = new DG.Tweening.Core.DOGetter<System.Single>(object:  val_1.m_ConstantMin, method:  new IntPtr(3051731504));
        DG.Tweening.Core.DOSetter<System.Single> val_15 = new DG.Tweening.Core.DOSetter<System.Single>(object:  val_1.m_ConstantMin, method:  new IntPtr(3051732528));
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_16 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  (float)this.particleRateOverTimeValues[0], duration:  null);
        DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  198828032);
        mem2[0] = 0;
    }
    private void InitializeGameObjectStates()
    {
        goto label_0;
        label_6:
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Transform val_2 = this.GetChild(index:  0);
        UnityEngine.GameObject val_3 = this.gameObject;
        this.SetActive(value:  true);
        0 = 1;
        label_0:
        UnityEngine.Transform val_4 = this.effectParent.transform;
        if(0 < this.effectParent.childCount)
        {
            goto label_6;
        }
        
        this.effectParent.SetActive(value:  false);
    }
    private void ResizeParticleSystem(float adsHeight = 0)
    {
        float val_14;
        var val_16;
        var val_17;
        val_16 = 0;
        ShapeModule val_1 = this.borderParticles.shape;
        object val_2 = this.borderParticles.GetComponentInParent<System.Object>();
        if(this != 0)
        {
                object val_3 = this.borderParticles.GetComponent<System.Object>();
            val_17 = this;
            val_16 = this;
        }
        else
        {
                object val_4 = 0.GetComponent<System.Object>();
            val_17 = 0;
        }
        
        UnityEngine.Transform val_5 = val_16.transform;
        UnityEngine.Vector3 val_6 = localScale;
        UnityEngine.Vector2 val_8 = sizeDelta;
        UnityEngine.Transform val_10 = val_16.transform;
        UnityEngine.Vector3 val_11 = localScale;
        UnityEngine.Vector2 val_13 = sizeDelta;
        float val_16 = val_14;
        val_16 = val_16 - R1;
        UnityEngine.Vector3 val_15 = new UnityEngine.Vector3(x:  val_16, y:  val_13.y, z:  -0.2f);
        val_1.m_ParticleSystem.scale = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
    }
    private void OnAdToggled()
    {
        this.OnCanvasResized();
    }
    private void OnCanvasResized()
    {
        float val_9;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(2124183120 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            float val_4 = GetBannerAdHeight();
            val_9 = 2124183120;
        }
        else
        {
                val_9 = 0f;
        }
        
        object val_5 = this.GetComponent<System.Object>();
        UnityEngine.Vector2 val_6 = offsetMin;
        UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_6.x, y:  val_6.y);
        this.offsetMin = new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
        this.ResizeParticleSystem(adsHeight:  val_6.x);
    }
    public void PlayEffects(int streak)
    {
        float val_18;
        UnityEngine.AnimationCurve val_19;
        float val_20;
        DG.Tweening.Core.DOGetter<System.Single> val_21;
        DG.Tweening.Core.DOSetter<System.Single> val_22;
        DG.Tweening.Core.DOGetter<System.Single> val_23;
        DG.Tweening.Sequence val_24;
        int val_21 = streak;
        val_21 = 1152921504892043264;
        GameBehavior val_1 = App.getBehavior;
        if(0 > val_21)
        {
                this.StopEffects();
            return;
        }
        
        GameBehavior val_2 = App.getBehavior;
        val_22 = 0;
        if(0 >= val_21)
        {
                val_23 = 0;
            this.effectParent.SetActive(value:  true);
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            val_24 = 0;
            val_21 = null;
            val_21 = new DG.Tweening.Core.DOGetter<System.Single>(object:  -1242466448, method:  new IntPtr(3052360112));
            val_22 = null;
            val_22 = new DG.Tweening.Core.DOSetter<System.Single>(object:  -1242466448, method:  new IntPtr(3052361136));
            DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_6 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  null, duration:  null);
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  198828032);
            this.mySequence = val_24;
        }
        
        if(val_21 > 11)
        {
                return;
        }
        
        DG.Tweening.Sequence val_8 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Core.DOGetter<System.Single> val_9 = new DG.Tweening.Core.DOGetter<System.Single>(object:  -1242466448, method:  new IntPtr(3052362160));
        DG.Tweening.Core.DOSetter<System.Single> val_10 = new DG.Tweening.Core.DOSetter<System.Single>(object:  -1242466448, method:  new IntPtr(3052363184));
        val_21 = val_21 - 1;
        float val_22 = this.borderAlphaValues[val_21];
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_11 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  null, duration:  null);
        DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  198828032);
        val_24 = 0;
        val_23 = null;
        val_23 = new DG.Tweening.Core.DOGetter<System.Single>(object:  -1242466448, method:  new IntPtr(3052401072));
        DG.Tweening.Core.DOSetter<System.Single> val_14 = new DG.Tweening.Core.DOSetter<System.Single>(object:  -1242466448, method:  new IntPtr(3052402096));
        float val_23 = this.starRotationSpeedValues[val_21];
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_15 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  null, duration:  null);
        DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  198828032);
        this.mySequence = val_24;
        MinMaxCurve val_17 = ParticleSystem.MinMaxCurve.op_Implicit(constant:  (float)this.particleRateOverTimeValues[val_21]);
        val_21 = val_18;
        val_22 = val_20;
        val_17.m_ConstantMin.rateOverTime = new MinMaxCurve() {m_CurveMax = val_19, m_ConstantMin = val_21, m_ConstantMax = val_22};
    }
    public GoldenApplesEffectController()
    {
        this.tweeningDuration = 0.5f;
        this.borderAlphaValues = null;
        this.particleRateOverTimeValues = null;
        this.starRotationSpeedValues = null;
    }
    private float <StopEffects>b__17_0()
    {
        UnityEngine.Color val_1 = color;
        return (float)val_1.r;
    }
    private void <StopEffects>b__17_1(float x)
    {
        PluginExtension.SetColorAlpha(graphic:  this.borderGlow, a:  x);
    }
    private float <StopEffects>b__17_2()
    {
        if(this.starRotation != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    private void <StopEffects>b__17_3(float x)
    {
        this.starRotation.speed = R1;
    }
    private float <StopEffects>b__17_4()
    {
        UnityEngine.Color val_1 = color;
        return (float)val_1.r;
    }
    private void <StopEffects>b__17_5(float x)
    {
        PluginExtension.SetColorAlpha(graphic:  this.starTexture, a:  x);
    }
    private float <PlayEffects>b__22_0()
    {
        UnityEngine.Color val_1 = color;
        return (float)val_1.r;
    }
    private void <PlayEffects>b__22_1(float x)
    {
        PluginExtension.SetColorAlpha(graphic:  this.starTexture, a:  x);
    }
    private float <PlayEffects>b__22_2()
    {
        UnityEngine.Color val_1 = color;
        return (float)val_1.r;
    }
    private void <PlayEffects>b__22_3(float x)
    {
        PluginExtension.SetColorAlpha(graphic:  this.borderGlow, a:  x);
    }
    private float <PlayEffects>b__22_4()
    {
        if(this.starRotation != 0)
        {
                return (float)S0;
        }
        
        return (float)S0;
    }
    private void <PlayEffects>b__22_5(float x)
    {
        this.starRotation.speed = R1;
    }

}
