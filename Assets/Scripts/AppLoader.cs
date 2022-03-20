using UnityEngine;
public class AppLoader : MonoBehaviour
{
    // Methods
    private void Awake()
    {
        var val_10;
        var val_11;
        object val_1 = UnityEngine.Resources.Load<System.Object>(path:  -341767936);
        string val_2 = text;
        GameNames val_3 = WordApp.GetGameEnum(game:  -341767936);
        var val_10 = 26334238;
        val_10 = 9297872 + val_10;
        if(val_10 == 0)
        {
                mem2[0] = 1;
        }
        
        val_10 = null;
        App.game = "perGameConfigs/currentGame";
        val_10 = null;
        var val_11 = 26327799;
        val_11 = 9297988 + val_11;
        App.game = "perGameConfigs/currentGame";
        if(val_11 == 0)
        {
                val_10 = null;
            mem2[0] = 1;
        }
        
        val_10 = null;
        val_11 = null;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        string val_4 = -1655690384(-1655690384) + 295313408 + -341767808(-341767808) + 295313408;
        object val_5 = UnityEngine.Resources.Load<System.Object>(path:  -1655690384);
        if((-1655690384) == 0)
        {
                string val_7 = -341766688(-341766688) + 295313408 + -2017393776(-2017393776);
            val_11 = "App.LoadNameAndConfig(): Could not load WordApp_";
            UnityEngine.Debug.LogError(message:  -341766688);
        }
        
        object val_8 = UnityEngine.Object.Instantiate<System.Object>(original:  -1655690384);
        UnityEngine.GameObject val_9 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  -341742512);
    }
    public AppLoader()
    {
    
    }

}
