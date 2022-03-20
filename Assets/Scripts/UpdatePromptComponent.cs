using UnityEngine;
public class UpdatePromptComponent : AppComponent
{
    // Properties
    public virtual twelvegigs.storage.JsonDictionary UpdatePromptConfig { get; }
    
    // Methods
    public UpdatePromptComponent(string gameName, string gameObjectName)
    {
        mem[1152921511250899952] = "UpdatePromptComponent";
    }
    public override void onStartApp()
    {
    
    }
    public override void onInitialServerUpdate()
    {
        UpdatePrompt.Init(serverConfiguration:  -1945649440);
    }
    public override void onServerUpdate()
    {
        UpdatePrompt.Init(serverConfiguration:  -1945537440);
    }
    private void ShowUpdatePrompt()
    {
        UpdatePrompt.Init(serverConfiguration:  -1945425440);
    }
    public virtual twelvegigs.storage.JsonDictionary get_UpdatePromptConfig()
    {
        var val_1;
        var val_1 = 27998075;
        val_1 = 7629340 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        if(App.storageManager.knobsModel != 0)
        {
                return getUpdatePromptConfiguration();
        }
        
        return getUpdatePromptConfiguration();
    }

}
