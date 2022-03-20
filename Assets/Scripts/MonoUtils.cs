using UnityEngine;
public class MonoUtils : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Text letter;
    public LineWord lineWord;
    public UnityEngine.Transform textFlyTransform;
    public UnityEngine.GameObject rubyFly;
    public UnityEngine.GameObject levelButton;
    public UnityEngine.ParticleSystem tileTrailEffect;
    public static MonoUtils instance;
    
    // Properties
    public LetterTile letterTile { get; }
    public Cell cell { get; }
    
    // Methods
    public LetterTile get_letterTile()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
    }
    public Cell get_cell()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
    }
    private void Awake()
    {
        MonoUtils.instance = this;
    }
    public MonoUtils()
    {
    
    }

}
