using UnityEngine;
public static class MethodExtensionForMonoBehaviourTransform
{
    // Methods
    public static T GetOrAddComponent<T>(UnityEngine.Component child)
    {
        if(child != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = child.gameObject;
        if(child == 0)
        {
            
        }
    
    }
    public static T GetOrAddComponent<T>(UnityEngine.GameObject gameObject)
    {
        if(gameObject != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = gameObject.gameObject;
        if(gameObject == 0)
        {
            
        }
    
    }
    public static void DestroyChildren(UnityEngine.Transform t)
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        System.Action<UnityEngine.GameObject> val_15;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.IEnumerator val_2 = t.GetEnumerator();
        label_17:
        val_8 = 0;
        val_8 = val_8 + 1;
        val_9 = t;
        if(t == 0)
        {
            goto label_7;
        }
        
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_10 = t;
        val_11 = t;
        val_11 = 0;
        UnityEngine.GameObject val_5 = val_11.gameObject;
        Add(item:  0);
        goto label_17;
        label_7:
        if(t != 0)
        {
                var val_9 = 0;
            val_9 = val_9 + 1;
            val_12 = t;
        }
        
        val_13 = null;
        val_13 = null;
        val_15 = MethodExtensionForMonoBehaviourTransform.<>c.<>9__2_0;
        if(val_15 == 0)
        {
                val_15 = null;
            val_15 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  MethodExtensionForMonoBehaviourTransform.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2263298512));
            MethodExtensionForMonoBehaviourTransform.<>c.<>9__2_0 = val_15;
        }
        
        ForEach(action:  7401472);
    }
    public static void DestroyChildrenImmediate(UnityEngine.Transform t)
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        System.Action<UnityEngine.GameObject> val_15;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.IEnumerator val_2 = t.GetEnumerator();
        label_17:
        val_8 = 0;
        val_8 = val_8 + 1;
        val_9 = t;
        if(t == 0)
        {
            goto label_7;
        }
        
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_10 = t;
        val_11 = t;
        val_11 = 0;
        UnityEngine.GameObject val_5 = val_11.gameObject;
        Add(item:  0);
        goto label_17;
        label_7:
        if(t != 0)
        {
                var val_9 = 0;
            val_9 = val_9 + 1;
            val_12 = t;
        }
        
        val_13 = null;
        val_13 = null;
        val_15 = MethodExtensionForMonoBehaviourTransform.<>c.<>9__3_0;
        if(val_15 == 0)
        {
                val_15 = null;
            val_15 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  MethodExtensionForMonoBehaviourTransform.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2263421776));
            MethodExtensionForMonoBehaviourTransform.<>c.<>9__3_0 = val_15;
        }
        
        ForEach(action:  7401472);
    }
    public static void SetActiveChildren(UnityEngine.Transform t, bool state)
    {
        float val_8;
        float val_9;
        var val_10;
        var val_11;
        var val_12;
        UnityEngine.GameObject val_13;
        var val_14;
        var val_15;
        var val_16;
        System.Collections.IEnumerator val_1 = t.GetEnumerator();
        val_8 = 1152921504683417600;
        val_9 = 1152921504767496192;
        label_23:
        val_10 = 0;
        val_10 = val_10 + 1;
        val_11 = t;
        if(t == 0)
        {
            goto label_7;
        }
        
        var val_7 = 0;
        val_7 = val_7 + 1;
        val_12 = t;
        if(t != 0)
        {
                val_13 = 0;
        }
        else
        {
                val_13 = 0;
        }
        
        UnityEngine.GameObject val_4 = gameObject;
        NGUITools.SetActiveSelf(go:  null, state:  state);
        goto label_23;
        label_7:
        val_14 = 0;
        val_15 = 1152921504619679744;
        if(t != 0)
        {
                val_10 = 0;
            val_15 = 0;
            val_10 = val_10 + 1;
            val_15 = (uint)val_10 & 65535;
            val_16 = t;
        }
        
        var val_6 = FP - 28;
    }
    public static int GetChildCountRecursively(UnityEngine.Transform transform)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        if(transform != 0)
        {
                val_7 = transform.childCount;
        }
        else
        {
                val_7 = 0.childCount;
        }
        
        System.Collections.IEnumerator val_3 = transform.GetEnumerator();
        label_18:
        val_8 = 0;
        val_8 = val_8 + 1;
        val_9 = transform;
        if(transform == 0)
        {
            goto label_8;
        }
        
        var val_7 = 0;
        val_7 = val_7 + 1;
        val_10 = transform;
        val_7 = 0 + val_7;
        goto label_18;
        label_8:
        val_11 = 1152921504619679744;
        if(transform != 0)
        {
                val_11 = 0;
            val_8 = 0;
            val_11 = val_11 + 1;
            val_8 = (uint)val_11 & 65535;
            val_12 = transform;
        }
        
        if(0 == 0)
        {
                return (int)val_7;
        }
        
        return (int)val_7;
    }
    public static void SetX(UnityEngine.Vector3 v, float x)
    {
        UnityEngine.Vector3 val_1 = new UnityEngine.Vector3(x:  x, y:  null, z:  null);
    }
    public static void SetY(UnityEngine.Vector3 v, float y)
    {
        UnityEngine.Vector3 val_1 = new UnityEngine.Vector3(x:  y, y:  null, z:  null);
    }
    public static void SetZ(UnityEngine.Vector3 v, float z)
    {
        UnityEngine.Vector3 val_1 = new UnityEngine.Vector3(x:  z, y:  null, z:  null);
    }
    public static UnityEngine.Vector3 Parse(UnityEngine.Vector3 v, string s)
    {
        var val_1;
        var val_9;
        string val_2 = val_1.Remove(startIndex:  0, count:  1);
        if(val_1 != 0)
        {
                val_9 = mem[val_1 + 8];
            val_9 = val_1 + 8;
        }
        else
        {
                val_9 = 0;
        }
        
        string val_3 = val_1.Remove(startIndex:  -1, count:  1);
        typeof(System.Char[]).__il2cppRuntimeField_10 = 44;
        System.String[] val_4 = val_1.Split(separator:  478563824, options:  0);
        float val_5 = System.Single.Parse(s:  val_1 + 16);
        float val_6 = System.Single.Parse(s:  val_1 + 20);
        float val_7 = System.Single.Parse(s:  val_1 + 24);
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        val_8 = new UnityEngine.Vector3(x:  val_7, y:  null, z:  null);
        return new UnityEngine.Vector3() {x = val_7};
    }
    public static UnityEngine.Vector2 Parse(UnityEngine.Vector2 v, string s)
    {
        var val_7;
        string val_1 = R3.Remove(startIndex:  0, count:  1);
        if(R3 != 0)
        {
                val_7 = mem[R3 + 8];
            val_7 = R3 + 8;
        }
        else
        {
                val_7 = 0;
        }
        
        string val_2 = R3.Remove(startIndex:  -1, count:  1);
        typeof(System.Char[]).__il2cppRuntimeField_10 = 44;
        System.String[] val_3 = R3.Split(separator:  478563824, options:  0);
        float val_4 = System.Single.Parse(s:  R3 + 16);
        float val_5 = System.Single.Parse(s:  R3 + 20);
        mem2[0] = 0;
        mem2[0] = 0;
        val_6 = new UnityEngine.Vector2(x:  val_5, y:  null);
        return new UnityEngine.Vector2() {x = val_5};
    }
    public static UnityEngine.Vector4 Parse(UnityEngine.Vector4 v, string s)
    {
        var val_1;
        var val_10;
        string val_2 = val_1.Remove(startIndex:  0, count:  1);
        if(val_1 != 0)
        {
                val_10 = mem[val_1 + 8];
            val_10 = val_1 + 8;
        }
        else
        {
                val_10 = 0;
        }
        
        string val_3 = val_1.Remove(startIndex:  -1, count:  1);
        typeof(System.Char[]).__il2cppRuntimeField_10 = 44;
        System.String[] val_4 = val_1.Split(separator:  478563824, options:  0);
        float val_5 = System.Single.Parse(s:  val_1 + 16);
        float val_6 = System.Single.Parse(s:  val_1 + 20);
        float val_7 = System.Single.Parse(s:  val_1 + 24);
        float val_8 = System.Single.Parse(s:  val_1 + 28);
        val_9 = new UnityEngine.Vector4(x:  val_8, y:  null, z:  null, w:  null);
        return new UnityEngine.Vector4() {x = val_8};
    }
    public static UnityEngine.Color Parse(UnityEngine.Color c, string s)
    {
        var val_1;
        var val_13;
        var val_14;
        if(val_1 != 0)
        {
                val_13 = val_1.IndexOf(value:  '(');
        }
        else
        {
                val_13 = 0.IndexOf(value:  '(');
        }
        
        string val_5 = val_1.Remove(startIndex:  0, count:  val_13 + 1);
        if(val_1 != 0)
        {
                val_14 = mem[val_1 + 8];
            val_14 = val_1 + 8;
        }
        else
        {
                val_14 = 0;
        }
        
        string val_6 = val_1.Remove(startIndex:  -1, count:  1);
        typeof(System.Char[]).__il2cppRuntimeField_10 = 44;
        System.String[] val_7 = val_1.Split(separator:  478563824, options:  0);
        float val_8 = System.Single.Parse(s:  val_1 + 16);
        float val_9 = System.Single.Parse(s:  val_1 + 20);
        float val_10 = System.Single.Parse(s:  val_1 + 24);
        float val_11 = System.Single.Parse(s:  val_1 + 28);
        val_12 = new UnityEngine.Color(r:  val_11, g:  null, b:  null, a:  null);
        return new UnityEngine.Color() {r = val_11};
    }

}
