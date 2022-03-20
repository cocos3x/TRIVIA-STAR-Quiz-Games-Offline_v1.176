using UnityEngine;
public class FacebookEditorController : MonoBehaviour
{
    // Fields
    public static System.Action doFBEditorLogin;
    public static System.Action loginPressed;
    public static System.Action cancelPressed;
    public static System.Action<string, string> loginComplete;
    public UnityEngine.GameObject wholeScreenBlocker;
    public static string userId;
    public static string token;
    
    // Methods
    public FacebookEditorController()
    {
    
    }
    private static FacebookEditorController()
    {
        null = null;
        System.Action val_1 = new System.Action(object:  FacebookEditorController.<>c.<>9, method:  new IntPtr(2438845072));
        FacebookEditorController.doFBEditorLogin = null;
        System.Action val_2 = new System.Action(object:  FacebookEditorController.<>c.<>9, method:  new IntPtr(2438846096));
        FacebookEditorController.loginPressed = null;
        System.Action val_3 = new System.Action(object:  FacebookEditorController.<>c.<>9, method:  new IntPtr(2438847120));
        FacebookEditorController.cancelPressed = null;
        System.Action<System.Threading.Tasks.Task, System.Object> val_4 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  FacebookEditorController.<>c.<>9, method:  new IntPtr(2438848144));
        FacebookEditorController.loginComplete = null;
        FacebookEditorController.userId = "";
        FacebookEditorController.token = "";
    }

}
