using UnityEngine;
public class PrefsSerializationManager : MonoSingleton<PrefsSerializationManager>
{
    // Fields
    private static bool LOGGING;
    private bool shouldSaveThisFrame;
    
    // Methods
    public static bool SavePlayerPrefs()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2014539312) == 0)
        {
                UnityEngine.Debug.LogError(message:  -2014538288);
            UnityEngine.PlayerPrefs.Save();
            return true;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        QueueSavePrefs();
        return false;
    }
    private void QueueSavePrefs()
    {
        var val_4;
        var val_5;
        var val_6;
        val_4 = null;
        if(this.shouldSaveThisFrame != false)
        {
                val_5 = null;
            if(PrefsSerializationManager.LOGGING == false)
        {
                return;
        }
        
            UnityEngine.Debug.LogError(message:  -2014426096, context:  -2014401808);
            return;
        }
        
        val_6 = null;
        if(PrefsSerializationManager.LOGGING != false)
        {
                UnityEngine.Debug.LogError(message:  -2014425952, context:  -2014401808);
        }
        
        this.shouldSaveThisFrame = true;
        System.Collections.IEnumerator val_2 = this.SaveAtEndOfFrame();
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  -2014401808);
    }
    private System.Collections.IEnumerator SaveAtEndOfFrame()
    {
        object val_1 = new System.Object();
        typeof(PrefsSerializationManager.<SaveAtEndOfFrame>d__4).__il2cppRuntimeField_8 = 0;
        typeof(PrefsSerializationManager.<SaveAtEndOfFrame>d__4).__il2cppRuntimeField_10 = this;
    }
    public PrefsSerializationManager()
    {
    
    }
    private static PrefsSerializationManager()
    {
    
    }

}
