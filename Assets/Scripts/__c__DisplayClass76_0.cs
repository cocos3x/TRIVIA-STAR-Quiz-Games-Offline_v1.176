using UnityEngine;
private sealed class MainController.<>c__DisplayClass76_0
{
    // Fields
    public System.Action<SceneType> onSceneLoaded;
    
    // Methods
    public MainController.<>c__DisplayClass76_0()
    {
    
    }
    internal void <OnCategoryPackCompletedClosed>b__0(SceneType s)
    {
        var val_3;
        CategoryPacksMenuUI.ShowMainScreen();
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Delegate val_2 = System.Delegate.Remove(source:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, value:  this.onSceneLoaded);
        val_3 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_3 != 0)
        {
                if(val_3 == null)
        {
            goto label_6;
        }
        
        }
        
        val_3 = 0;
        label_6:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_3;
    }

}
