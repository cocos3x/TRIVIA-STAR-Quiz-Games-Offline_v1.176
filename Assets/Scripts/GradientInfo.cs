using UnityEngine;
[Serializable]
public class GradientInfo
{
    // Fields
    public UnityEngine.Color m_color1;
    public UnityEngine.Color m_color2;
    public float m_angle;
    public bool m_ignoreRatio;
    
    // Methods
    public GradientInfo()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        this.m_ignoreRatio = true;
    }

}
