using UnityEngine;
public interface PluginObserver
{
    // Methods
    public abstract PluginObserverManager.ObserverType getType(); // 0
    public abstract string pluginName(); // 0
    public abstract string errorMessage(); // 0
    public abstract bool isWorking(); // 0
    public abstract bool isInitialized(); // 0

}
