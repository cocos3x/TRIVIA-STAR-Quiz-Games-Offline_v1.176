using UnityEngine;
public class CameraOperatorUGUI : MonoBehaviour
{
    // Fields
    private UnityEngine.Canvas myCanvas;
    
    // Properties
    private UnityEngine.Canvas MyCanvas { get; }
    
    // Methods
    private UnityEngine.Canvas get_MyCanvas()
    {
        if(this.myCanvas != 0)
        {
                return;
        }
        
        object val_2 = this.myCanvas.GetComponent<System.Object>();
        this.myCanvas = this;
    }
    private void Start()
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  -2009665664)) == false)
        {
                return;
        }
        
        WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        AddCamera(cam:  -2009640640);
    }
    private void OnDestroy()
    {
        var val_4;
        var val_4 = 28997549;
        val_4 = 6629344 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        if(App.isQuitting == true)
        {
                return;
        }
        
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  -2009665664)) == false)
        {
                return;
        }
        
        WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        RemoveCamera(cam:  R4);
    }
    public bool IsCameraActive()
    {
        UnityEngine.Canvas val_1 = this.MyCanvas;
        if(this != 0)
        {
                return this.enabled;
        }
        
        return this.enabled;
    }
    public void SetCameraState(bool active)
    {
        UnityEngine.Canvas val_1 = this.MyCanvas;
        this.enabled = active;
    }
    public CameraOperatorUGUI()
    {
    
    }

}
