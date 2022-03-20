using UnityEngine;
private sealed class IslandParadiseEventHandler.<>c__DisplayClass80_1
{
    // Fields
    public UnityEngine.GameObject point;
    public IslandParadiseEventHandler.<>c__DisplayClass80_0 CS$<>8__locals1;
    
    // Methods
    public IslandParadiseEventHandler.<>c__DisplayClass80_1()
    {
    
    }
    internal void <PlayPointCollectionSequence>b__3()
    {
        UnityEngine.Object.Destroy(obj:  this.point);
        this.CS$<>8__locals1.islandParadiseButton.Play();
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -1541987328, clipIndex:  0);
    }

}
