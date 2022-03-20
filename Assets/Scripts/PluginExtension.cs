using UnityEngine;
public static class PluginExtension
{
    // Methods
    public static void SetX(UnityEngine.Transform transform, float x)
    {
        UnityEngine.Vector3 val_1 = position;
        UnityEngine.Vector3 val_3 = position;
        UnityEngine.Vector3 val_5 = new UnityEngine.Vector3(x:  val_3.x, y:  val_3.y, z:  val_3.z);
        transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
    }
    public static void SetY(UnityEngine.Transform transform, float y)
    {
        UnityEngine.Vector3 val_1 = position;
        UnityEngine.Vector3 val_3 = position;
        UnityEngine.Vector3 val_5 = new UnityEngine.Vector3(x:  val_3.x, y:  val_3.y, z:  val_3.z);
        transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
    }
    public static void SetZ(UnityEngine.Transform transform, float z)
    {
        UnityEngine.Vector3 val_1 = position;
        UnityEngine.Vector3 val_3 = position;
        UnityEngine.Vector3 val_5 = new UnityEngine.Vector3(x:  val_3.x, y:  val_3.y, z:  val_3.z);
        transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
    }
    public static void SetPosition2D(UnityEngine.Transform transform, UnityEngine.Vector3 target)
    {
        UnityEngine.Vector3 val_1 = position;
        UnityEngine.Vector3 val_3 = new UnityEngine.Vector3(x:  val_1.x, y:  val_1.y, z:  val_1.z);
        transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
    }
    public static void SetLocalX(UnityEngine.Transform transform, float x)
    {
        UnityEngine.Vector3 val_1 = localPosition;
        UnityEngine.Vector3 val_3 = localPosition;
        UnityEngine.Vector3 val_5 = new UnityEngine.Vector3(x:  val_3.x, y:  val_3.y, z:  val_3.z);
        transform.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
    }
    public static void SetLocalY(UnityEngine.Transform transform, float y)
    {
        UnityEngine.Vector3 val_1 = localPosition;
        UnityEngine.Vector3 val_3 = localPosition;
        UnityEngine.Vector3 val_5 = new UnityEngine.Vector3(x:  val_3.x, y:  val_3.y, z:  val_3.z);
        transform.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
    }
    public static void SetLocalZ(UnityEngine.Transform transform, float z)
    {
        UnityEngine.Vector3 val_1 = localPosition;
        UnityEngine.Vector3 val_3 = localPosition;
        UnityEngine.Vector3 val_5 = new UnityEngine.Vector3(x:  val_3.x, y:  val_3.y, z:  val_3.z);
        transform.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
    }
    public static void MoveLocalX(UnityEngine.Transform transform, float deltaX)
    {
        var val_2;
        UnityEngine.Vector3 val_1 = localPosition;
        UnityEngine.Vector3 val_3 = localPosition;
        UnityEngine.Vector3 val_5 = localPosition;
        UnityEngine.Vector3 val_8 = new UnityEngine.Vector3(x:  val_2 + R1, y:  val_5.y, z:  val_5.z);
        transform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
    }
    public static void MoveLocalY(UnityEngine.Transform transform, float deltaY)
    {
        var val_4;
        UnityEngine.Vector3 val_1 = localPosition;
        UnityEngine.Vector3 val_3 = localPosition;
        UnityEngine.Vector3 val_5 = localPosition;
        UnityEngine.Vector3 val_8 = new UnityEngine.Vector3(x:  val_4 + R1, y:  val_5.y, z:  val_5.z);
        transform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
    }
    public static void MoveLocalZ(UnityEngine.Transform transform, float deltaZ)
    {
        float val_6;
        UnityEngine.Vector3 val_1 = localPosition;
        UnityEngine.Vector3 val_3 = localPosition;
        UnityEngine.Vector3 val_5 = localPosition;
        float val_8 = val_6;
        val_8 = val_8 + R1;
        UnityEngine.Vector3 val_7 = new UnityEngine.Vector3(x:  val_8, y:  val_5.y, z:  val_5.z);
        transform.localPosition = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
    }
    public static void MoveLocalXYZ(UnityEngine.Transform transform, float deltaX, float deltaY, float deltaZ)
    {
        var val_2;
        var val_4;
        float val_6;
        UnityEngine.Vector3 val_1 = localPosition;
        UnityEngine.Vector3 val_3 = localPosition;
        UnityEngine.Vector3 val_5 = localPosition;
        float val_10 = val_6;
        float val_8 = val_4 + R2;
        val_10 = val_10 + R3;
        UnityEngine.Vector3 val_9 = new UnityEngine.Vector3(x:  val_2 + R1, y:  val_5.y, z:  val_10);
        transform.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
    }
    public static void SetLocalScaleX(UnityEngine.Transform transform, float x)
    {
        UnityEngine.Vector3 val_1 = localScale;
        UnityEngine.Vector3 val_3 = localScale;
        UnityEngine.Vector3 val_5 = new UnityEngine.Vector3(x:  val_3.x, y:  val_3.y, z:  val_3.z);
        transform.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
    }
    public static void SetLocalScaleY(UnityEngine.Transform transform, float y)
    {
        UnityEngine.Vector3 val_1 = localScale;
        UnityEngine.Vector3 val_3 = localScale;
        UnityEngine.Vector3 val_5 = new UnityEngine.Vector3(x:  val_3.x, y:  val_3.y, z:  val_3.z);
        transform.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
    }
    public static void SetLocalScaleZ(UnityEngine.Transform transform, float z)
    {
        UnityEngine.Vector3 val_1 = localScale;
        UnityEngine.Vector3 val_3 = localScale;
        UnityEngine.Vector3 val_5 = new UnityEngine.Vector3(x:  val_3.x, y:  val_3.y, z:  val_3.z);
        transform.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
    }
    public static void Times(int count, System.Action action)
    {
        if(count < 1)
        {
                return;
        }
        
        int val_1 = count;
        do
        {
            action.Invoke();
            val_1 = val_1 - 1;
        }
        while(action != 0);
    
    }
    public static void SetColorAlpha(UnityEngine.UI.MaskableGraphic graphic, float a)
    {
        UnityEngine.Color val_1 = color;
        graphic.color = new UnityEngine.Color() {r = R6, g = R7, b = SB, a = R1};
    }
    public static void LookAt2D(UnityEngine.Transform transform, UnityEngine.Vector3 target, float angle = 0)
    {
        var val_2;
        float val_5;
        float val_7;
        UnityEngine.Vector3 val_1 = position;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = -2.341014E-37f, y = target.x, z = target.y}, b:  new UnityEngine.Vector3() {x = target.z});
        float val_8 = -90f;
        val_8 = val_2 + val_8;
        UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Euler(x:  val_8, y:  val_3.y, z:  val_5);
        transform.rotation = new UnityEngine.Quaternion() {w = val_7};
    }
    public static void LookAt2D(UnityEngine.Transform transform, UnityEngine.Transform target, float angle = 0)
    {
        UnityEngine.Vector3 val_1 = position;
        PluginExtension.LookAt2D(transform:  transform, target:  new UnityEngine.Vector3(), angle:  val_1.x);
    }
    public static float Delta(float number, float delta)
    {
        float val_2 = UnityEngine.Random.Range(min:  number, max:  delta);
        uint val_3 = 0;
        val_3 = R1 ^ 2147483648 + val_3;
        return (float)val_3;
    }
    public static float DeltaPercent(float number, float percent)
    {
        float val_3 = R1;
        val_3 = 0 * val_3;
        float val_2 = UnityEngine.Random.Range(min:  val_3, max:  percent);
        var val_4 = val_3 ^ 2147483648;
        val_4 = val_4 + 0;
        return (float)val_4;
    }
    public static void Shuffle<T>(System.Collections.Generic.IList<T> list, System.Nullable<int> seed)
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        val_9 = R3;
        val_10 = 35643295;
        if((__RuntimeMethodHiddenParam & 255) == 0)
        {
                System.Random val_2 = null;
            val_11 = val_2;
            val_2 = new System.Random(Seed:  seed.HasValue.Value);
        }
        else
        {
                System.Random val_3 = null;
            val_11 = val_3;
            val_3 = new System.Random();
        }
        
        var val_9 = 0;
        val_12 = 0;
        val_9 = val_9 + 1;
        val_12 = (uint)val_9 & 65535;
        val_13 = list;
        if(list < 2)
        {
                return;
        }
        
        System.Collections.Generic.IList<T> val_11 = list;
        do
        {
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_14 = list;
            val_11 = val_11 - 1;
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_15 = list;
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_16 = list;
            val_9 = val_9;
            val_10 = mem[R3 + 24 + 4];
            val_10 = R3 + 24 + 4;
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_17 = list;
        }
        while(val_11 > 2);
    
    }

}
