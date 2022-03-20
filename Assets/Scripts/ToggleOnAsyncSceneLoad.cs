using UnityEngine;
public class ToggleOnAsyncSceneLoad : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject[] GoToToggle;
    private System.Collections.Generic.List<bool> curState;
    private SceneType sceneToWatch;
    
    // Methods
    private void Start()
    {
        var val_8;
        var val_9;
        if(this.GoToToggle == null)
        {
                return;
        }
        
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_2 = new System.Action<Result>(object:  -183413680, method:  new IntPtr(4111527568));
        System.Delegate val_3 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
        val_8 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_8 != 0)
        {
                if(val_8 == null)
        {
            goto label_7;
        }
        
        }
        
        val_8 = 0;
        label_7:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_8;
        WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_5 = new System.Action<Result>(object:  -183413680, method:  new IntPtr(4111528592));
        System.Delegate val_6 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10, b:  7401472);
        val_9 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10;
        if(val_9 != 0)
        {
                if(val_9 == null)
        {
            goto label_11;
        }
        
        }
        
        val_9 = 0;
        label_11:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10 = val_9;
        System.Collections.Generic.List<System.Boolean> val_7 = new System.Collections.Generic.List<System.Boolean>();
        this.curState = null;
    }
    private void OnDestroy()
    {
        var val_7;
        var val_8;
        if(this.GoToToggle == null)
        {
                return;
        }
        
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_2 = new System.Action<Result>(object:  -183227952, method:  new IntPtr(4111527568));
        System.Delegate val_3 = System.Delegate.Remove(source:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, value:  7401472);
        val_7 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_7 != 0)
        {
                if(val_7 == null)
        {
            goto label_7;
        }
        
        }
        
        val_7 = 0;
        label_7:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_7;
        WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_5 = new System.Action<Result>(object:  -183227952, method:  new IntPtr(4111528592));
        System.Delegate val_6 = System.Delegate.Remove(source:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10, value:  7401472);
        val_8 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10;
        if(val_8 != 0)
        {
                if(val_8 == null)
        {
            goto label_11;
        }
        
        }
        
        val_8 = 0;
        label_11:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10 = val_8;
    }
    private void Instance_OnSceneLoaded(SceneType obj)
    {
        var val_2;
        if(this.sceneToWatch != obj)
        {
                return;
        }
        
        this.curState.Clear();
        val_2 = 4;
        goto label_3;
        label_12:
        this.curState.Add(item:  this.GoToToggle[0].activeSelf);
        UnityEngine.GameObject val_4 = this.GoToToggle[0];
        val_4.SetActive(value:  false);
        val_2 = 5;
        label_3:
        if((val_2 - 4) < val_4)
        {
            goto label_12;
        }
    
    }
    private void Instance_OnSceneUnloaded(SceneType obj)
    {
        var val_1;
        var val_2;
        val_1 = 35633853;
        if(this.sceneToWatch != obj)
        {
                return;
        }
        
        val_2 = 0;
        goto label_2;
        label_9:
        UnityEngine.GameObject val_1 = this.GoToToggle[val_2];
        if(this.GoToToggle[val_2] <= val_2)
        {
                var val_2 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_2 = val_2 + val_2;
        if(((0 + val_2) + 16) != 0)
        {
                val_1 = 1;
        }
        
        val_1.SetActive(value:  true);
        val_2 = 1;
        label_2:
        if(val_2 < val_1)
        {
            goto label_9;
        }
    
    }
    public ToggleOnAsyncSceneLoad()
    {
        this.sceneToWatch = 4;
    }

}
