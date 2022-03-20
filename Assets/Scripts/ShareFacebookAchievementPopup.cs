using UnityEngine;
public class ShareFacebookAchievementPopup : MonoBehaviour
{
    // Fields
    private bool fbTriggered;
    
    // Methods
    private void Awake()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -2005030512, name:  -2005054624);
    }
    private void OnDestroy()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.RemoveObserver(observer:  -2004918512, name:  -2005054624);
    }
    private void ShareClicked()
    {
        if((FacebookPlugin.TaskComplete(taskToCheck:  4)) != false)
        {
                this.ResetAndClose();
            return;
        }
        
        this.fbTriggered = true;
        if((FacebookPlugin.TaskComplete(taskToCheck:  1)) != false)
        {
                FacebookPlugin.PerformTask(task:  4);
            return;
        }
        
        FacebookPlugin.PerformFirstAvailableTask();
    }
    private void OnFacebookPluginUpdate(Notification n)
    {
        var val_1;
        var val_2;
        var val_3;
        var val_4;
        val_1 = n;
        val_2 = 35629226;
        if(this.fbTriggered == false)
        {
                return;
        }
        
        val_3 = n.data;
        val_3.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        if(null == 0)
        {
            goto label_6;
        }
        
        if(null == 4)
        {
            goto label_11;
        }
        
        return;
        label_6:
        val_1 = n.data;
        val_4 = null;
        val_1.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        if(null != 0)
        {
                FacebookPlugin.PerformTask(task:  4);
            return;
        }
        
        label_11:
        this.ResetAndClose();
    }
    private void ResetAndClose()
    {
        this.fbTriggered = false;
        UnityEngine.GameObject val_1 = this.gameObject;
        NGUITools.SetActive(go:  -2004557936, state:  false);
    }
    public ShareFacebookAchievementPopup()
    {
    
    }

}
