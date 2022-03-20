using UnityEngine;
public class TRVFlyout : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject flyoutObject;
    private UnityEngine.UI.Text flyoutText;
    
    // Methods
    public System.Collections.IEnumerator DisplayFlyout(string text, float seconds = 3)
    {
        typeof(TRVFlyout.<DisplayFlyout>d__2).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(TRVFlyout.<DisplayFlyout>d__2).__il2cppRuntimeField_10 = this;
            typeof(TRVFlyout.<DisplayFlyout>d__2).__il2cppRuntimeField_14 = text;
        }
        else
        {
                mem[16] = this;
            mem[20] = text;
        }
        
        typeof(TRVFlyout.<DisplayFlyout>d__2).__il2cppRuntimeField_18 = R2;
    }
    public TRVFlyout()
    {
    
    }

}
