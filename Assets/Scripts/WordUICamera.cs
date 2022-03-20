using UnityEngine;
public class WordUICamera : CCamera
{
    // Fields
    public static WordUICamera instance;
    
    // Methods
    protected override void Awake()
    {
        WordUICamera.instance = this;
        this.Awake();
    }
    public WordUICamera()
    {
    
    }

}
