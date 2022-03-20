using UnityEngine;
public class AsyncExecution : MonoSingletonSelfGenerating<AsyncExecution>
{
    // Fields
    private System.Collections.Generic.Dictionary<string, System.Action> currents;
    
    // Methods
    private void Awake()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  -1790705760);
    }
    public static void StopAllExecution()
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  -1950553136)) == false)
        {
                return;
        }
        
        WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        StopAllCoroutines();
    }
    public void Async(System.Action callback, float when = 1)
    {
        System.Collections.IEnumerator val_1 = this.CallAction(current:  callback, when:  when);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -1790477664);
    }
    public System.Collections.IEnumerator MultiAsync<T>(System.Collections.Generic.IEnumerable<T> collection, System.Action<T> collectionAction, int batchSize = 1)
    {
        if((__RuntimeMethodHiddenParam + 24) != 0)
        {
                mem2[0] = collection;
            mem2[0] = this;
            mem2[0] = collectionAction;
        }
        else
        {
                mem[24] = this;
            mem[16] = collection;
            mem[28] = collectionAction;
        }
        
        mem2[0] = batchSize;
    }
    private System.Collections.IEnumerator MultiAction<T>(int framesToWait, System.Action<T> collectionAction, T actionArgument)
    {
        if((__RuntimeMethodHiddenParam + 24) != 0)
        {
                mem2[0] = framesToWait;
            mem2[0] = collectionAction;
        }
        else
        {
                mem[16] = framesToWait;
            mem[20] = collectionAction;
        }
        
        mem2[0] = actionArgument;
    }
    private System.Collections.IEnumerator CallAction(System.Action current, float when = 1)
    {
        typeof(AsyncExecution.<CallAction>d__6).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(AsyncExecution.<CallAction>d__6).__il2cppRuntimeField_14 = current;
        }
        else
        {
                mem[20] = current;
        }
        
        typeof(AsyncExecution.<CallAction>d__6).__il2cppRuntimeField_10 = R2;
    }
    public void HaltActions()
    {
        this.StopAllCoroutines();
    }
    public AsyncExecution()
    {
    
    }

}
