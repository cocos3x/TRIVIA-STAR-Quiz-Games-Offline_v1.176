using UnityEngine;
public class AnimatedCoin : MonoBehaviour
{
    // Fields
    private UnityEngine.ParticleSystem particleSystem;
    private UnityEngine.ParticleSystem.MainModule particlesMainModule;
    private UnityEngine.ParticleSystem.MinMaxGradient particlesStartColor;
    private float originalLifetimeMultipler;
    private UnityEngine.Color originalParticleColor;
    private UnityEngine.Color hidingParticleColor;
    private UnityEngine.UI.Image image;
    private CollectAnimation gridCoinCollectAnimation;
    
    // Methods
    private void Awake()
    {
        float val_18;
        object val_1 = this.GetComponent<System.Object>();
        this.image = this;
        MainModule val_2 = this.particleSystem.main;
        this.particlesMainModule = val_2.m_ParticleSystem;
        MainModule val_3 = this.particleSystem.main;
        MinMaxGradient val_4 = startColor;
        float val_5 = val_4.m_ColorMin.g + 52;
        float val_6 = val_4.m_ColorMin.g + 20;
        float val_7 = val_4.m_ColorMin.g + 36;
        float val_8 = val_4.m_ColorMin.a.startLifetimeMultiplier;
        mem2[0] = val_4.m_ColorMin.a;
        UnityEngine.Color val_9 = color;
        float val_10 = val_4.m_ColorMin.g + 68;
        UnityEngine.Color val_11 = color;
        UnityEngine.Color val_13 = color;
        UnityEngine.Color val_15 = color;
        UnityEngine.Color val_17 = color;
        float val_21 = 0.5f;
        UnityEngine.Color val_19;
        val_21 = val_18 * val_21;
        val_19 = new UnityEngine.Color(r:  val_21, g:  val_17.g, b:  val_18, a:  val_17.a);
        float val_20 = val_4.m_ColorMin.g + 84;
    }
    public void Reset(CollectAnimation grid)
    {
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.localPosition = new UnityEngine.Vector3();
        this.gridCoinCollectAnimation = grid;
        if((UnityEngine.Object.op_Implicit(exists:  this.image)) == false)
        {
                return;
        }
        
        this.image.enabled = true;
    }
    private void OnDisable()
    {
        this.StopAllCoroutines();
    }
    public void PlaySparkle(float delay)
    {
        System.Collections.IEnumerator val_1 = this.PlayingSparkle(delay:  delay);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  103421120);
    }
    private System.Collections.IEnumerator PlayingSparkle(float delay)
    {
        typeof(AnimatedCoin.<PlayingSparkle>d__12).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(AnimatedCoin.<PlayingSparkle>d__12).__il2cppRuntimeField_14 = this;
        }
        else
        {
                mem[20] = this;
        }
        
        typeof(AnimatedCoin.<PlayingSparkle>d__12).__il2cppRuntimeField_10 = R1;
    }
    public void HideCoin()
    {
        var val_2;
        var val_3;
        var val_4;
        this.image.enabled = false;
        float val_2 = 0.5f;
        val_2 = this.originalLifetimeMultipler * val_2;
        this.particlesMainModule.startLifetimeMultiplier = val_2;
        this.particlesStartColor.color = new UnityEngine.Color() {r = mem[this.hidingParticleColor + (0)], g = mem[this.hidingParticleColor + (4)], b = mem[this.hidingParticleColor + (8)], a = this.particlesMainModule};
        this.particlesMainModule.startColor = new MinMaxGradient() {m_Mode = this.particlesStartColor, m_GradientMin = mem[this.hidingParticleColor + (4)], m_GradientMax = mem[this.hidingParticleColor + (8)], m_ColorMin = new UnityEngine.Color(), m_ColorMax = new UnityEngine.Color() {b = ???, a = mem[this.hidingParticleColor + (0)]}};
        this.particleSystem.Play();
        val_2 = 0;
        val_2 = val_2 + 1;
        val_3 = (uint)val_2 & 65535;
        val_4 = this.gridCoinCollectAnimation;
        goto mem[(1152921505002905600 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
    }
    public AnimatedCoin()
    {
        this.originalLifetimeMultipler = 1f;
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        UnityEngine.Color val_2 = UnityEngine.Color.gray;
    }

}
