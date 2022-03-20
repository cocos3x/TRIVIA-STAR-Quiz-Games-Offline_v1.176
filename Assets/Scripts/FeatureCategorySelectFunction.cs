using UnityEngine;
public class FeatureCategorySelectFunction
{
    // Fields
    public int priority;
    public System.Func<System.Collections.Generic.List<string>, System.Collections.Generic.List<string>> function;
    public UnityEngine.Component behaviorComponent;
    
    // Methods
    public FeatureCategorySelectFunction(int highPriority, System.Func<System.Collections.Generic.List<string>, System.Collections.Generic.List<string>> functionToDo, UnityEngine.Component owner)
    {
        this.priority = 0;
        val_1 = new System.Object();
        this.priority = highPriority;
        this.function = functionToDo;
        this.behaviorComponent = val_1;
    }

}
