using UnityEngine;
public class LocalNotificationsComponent : AppComponent
{
    // Properties
    public override bool RunInMainThread { get; }
    
    // Methods
    public override bool get_RunInMainThread()
    {
        return true;
    }
    public LocalNotificationsComponent(string gameName, string gameObjectName)
    {
        mem[1152921511246132256] = "LocalNotificationsComponent";
    }
    public override void initializeOnMainThread()
    {
        AppConfigs val_1 = App.Configuration;
        twelvegigs.plugins.LocalNotificationsPlugin.Initialize(gameName:  null, available:  true);
        twelvegigs.plugins.LocalNotificationsPlugin.Clear();
        WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action val_3 = new System.Action(object:  -1950527088, method:  new IntPtr(2344415184));
        Async(callback:  7454720, when:  null);
    }
    private void ScheduleNotifications()
    {
    
    }
    public override void onInitialServerUpdate()
    {
    
    }
    public override void onServerUpdate()
    {
    
    }

}
