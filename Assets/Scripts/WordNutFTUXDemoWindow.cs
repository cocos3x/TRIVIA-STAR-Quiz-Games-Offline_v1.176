using UnityEngine;
public class WordNutFTUXDemoWindow : WordAddictFTUXDemoWindow
{
    // Methods
    protected override UnityEngine.Vector3 GetWordRegionPosStep1(UnityEngine.Transform letterSlot1, UnityEngine.Transform letterSlot2)
    {
        var val_4;
        var val_6;
        UnityEngine.Vector3 val_1 = position;
        UnityEngine.Vector3 val_3 = position;
        UnityEngine.Vector3 val_5 = position;
        UnityEngine.Vector3 val_7 = position;
        float val_11 = 0.5f;
        float val_9 = val_4 + val_6;
        this = 0;
        mem[1152921513310769508] = 0;
        mem[1152921513310769512] = 0;
        val_11 = val_9 * val_11;
        this = new UnityEngine.Vector3(x:  val_11, y:  val_7.y, z:  val_9);
        return new UnityEngine.Vector3() {x = val_11, y = val_7.y, z = val_9};
    }
    protected override UnityEngine.Vector2 GetWordRegionSizeStep1(float cellSize)
    {
        var val_4 = R1 + 40;
        float val_5 = R2;
        float val_1 = val_5 + val_5;
        val_4 = val_4 << 2;
        this = 0;
        mem[1152921513310889700] = 0;
        val_5 = ((float)val_4 << 1) + val_5;
        val_1 = val_1 + (float)val_4;
        val_3 = new UnityEngine.Vector2(x:  val_5, y:  null);
        return new UnityEngine.Vector2() {x = val_5};
    }
    protected override UnityEngine.Vector2 GetWordRegionSizeStep2(float cellSize)
    {
        var val_3 = R1 + 40;
        val_3 = val_3 + (val_3 << 1);
        val_3 = val_3 << 1;
        float val_4 = (float)val_3 << 1;
        this = 0;
        mem[1152921513311001700] = 0;
        val_4 = val_4 + R2;
        val_2 = new UnityEngine.Vector2(x:  3f, y:  null);
        return new UnityEngine.Vector2() {x = 3f};
    }
    public WordNutFTUXDemoWindow()
    {
    
    }

}
