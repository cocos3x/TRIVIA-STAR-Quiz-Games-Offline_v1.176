using UnityEngine;
public static class NGUITools
{
    // Fields
    private static UnityEngine.AudioListener mListener;
    private static bool mLoaded;
    private static float mGlobalVolume;
    private static UnityEngine.Color mInvisible;
    private static System.Reflection.PropertyInfo mSystemCopyBuffer;
    
    // Properties
    public static float soundVolume { get; set; }
    public static bool fileAccess { get; }
    public static string clipboard { get; set; }
    
    // Methods
    public static float get_soundVolume()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(NGUITools.mLoaded != true)
        {
                val_3 = 1152921504866009092;
            NGUITools.mLoaded = true;
            val_2 = null;
            NGUITools.mGlobalVolume = "Sound";
        }
        
        val_2 = null;
        return (float)UnityEngine.PlayerPrefs.GetFloat(key:  1804032016, defaultValue:  null);
    }
    public static void set_soundVolume(float value)
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        val_2 = val_1;
        val_2 = null;
        NGUITools.mLoaded = true;
        NGUITools.mGlobalVolume = 0;
        UnityEngine.PlayerPrefs.SetFloat(key:  1804032016, value:  NGUITools.mGlobalVolume);
    }
    public static bool get_fileAccess()
    {
        return true;
    }
    public static UnityEngine.AudioSource PlaySound(UnityEngine.AudioClip clip)
    {
        return NGUITools.PlaySound(clip:  clip, volume:  null, pitch:  null);
    }
    public static UnityEngine.AudioSource PlaySound(UnityEngine.AudioClip clip, float volume)
    {
        return NGUITools.PlaySound(clip:  clip, volume:  volume, pitch:  null);
    }
    public static UnityEngine.AudioSource PlaySound(UnityEngine.AudioClip clip, float volume, float pitch)
    {
        var val_22;
        var val_23;
        UnityEngine.AudioListener val_24;
        var val_25;
        UnityEngine.AudioListener val_26;
        var val_27;
        var val_28;
        UnityEngine.AudioListener val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_22 = R1;
        float val_1 = NGUITools.soundVolume;
        val_22 = 259158016 * val_22;
        val_22 = 0;
        if(clip == 0)
        {
                return;
        }
        
        val_23 = null;
        val_23 = null;
        if(NGUITools.mListener == 0)
        {
                System.Type val_4 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(176836608)});
            val_24 = 0;
            UnityEngine.Object val_5 = UnityEngine.Object.FindObjectOfType(type:  176836608);
            val_25 = null;
            val_25 = null;
            if(null != 0)
        {
                if(null != null)
        {
                null = 0;
        }
        
            val_24 = null;
        }
        
            NGUITools.mListener = val_24;
            if(0 == 0)
        {
                UnityEngine.Camera val_7 = UnityEngine.Camera.main;
            val_26 = 0;
            if(0 == 0)
        {
                val_26 = 0;
            System.Type val_9 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(151011328)});
            UnityEngine.Object val_10 = UnityEngine.Object.FindObjectOfType(type:  151011328);
            if(null != 0)
        {
                if(null != null)
        {
                null = 0;
        }
        
            val_26 = null;
        }
        
        }
        
            if(0 != 0)
        {
                UnityEngine.GameObject val_12 = val_26.gameObject;
            object val_13 = val_26.AddComponent<System.Object>();
            val_27 = null;
            val_27 = null;
            NGUITools.mListener = val_26;
        }
        
        }
        
        }
        
        val_28 = null;
        val_28 = null;
        val_29 = NGUITools.mListener;
        val_22 = 0;
        if(0 == 0)
        {
                return;
        }
        
        val_30 = null;
        val_30 = null;
        val_29 = NGUITools.mListener;
        val_22 = 0;
        if(val_29.enabled == false)
        {
                return;
        }
        
        val_31 = null;
        val_31 = null;
        val_29 = NGUITools.mListener;
        val_22 = 0;
        UnityEngine.GameObject val_16 = val_29.gameObject;
        if((NGUITools.GetActive(go:  0)) == false)
        {
                return;
        }
        
        val_32 = null;
        val_32 = null;
        object val_18 = NGUITools.mListener.GetComponent<System.Object>();
        val_22 = NGUITools.mListener;
        if(0 == 0)
        {
                val_33 = null;
            val_33 = null;
            UnityEngine.GameObject val_20 = NGUITools.mListener.gameObject;
            object val_21 = NGUITools.mListener.AddComponent<System.Object>();
            val_22 = NGUITools.mListener;
        }
        
        if(val_22 != 0)
        {
                val_22.pitch = 0.01f;
        }
        else
        {
                val_22.pitch = 0.01f;
        }
        
        val_22.PlayOneShot(clip:  clip, volumeScale:  0.01f);
    }
    public static UnityEngine.WWW OpenURL(string url)
    {
        UnityEngine.WWW val_1 = new UnityEngine.WWW(url:  url);
    }
    public static UnityEngine.WWW OpenURL(string url, UnityEngine.WWWForm form)
    {
        if(form == 0)
        {
                return NGUITools.OpenURL(url:  url);
        }
        
        UnityEngine.WWW val_1 = new UnityEngine.WWW(url:  url, form:  form);
    }
    public static int RandomRange(int min, int max)
    {
        if(min == max)
        {
                return (int)min;
        }
        
        max = max + 1;
        return UnityEngine.Random.Range(min:  min, max:  max);
    }
    public static string GetHierarchy(UnityEngine.GameObject obj)
    {
        string val_10;
        string val_11;
        val_10 = obj;
        string val_1 = val_10.name;
        val_11 = val_10;
        goto label_2;
        label_11:
        UnityEngine.Transform val_2 = val_10.transform;
        UnityEngine.Transform val_3 = val_10.parent;
        UnityEngine.GameObject val_4 = val_10.gameObject;
        val_10 = val_10;
        string val_5 = val_10.name;
        string val_6 = val_10 + 1115175264 + val_11;
        val_11 = val_10;
        label_2:
        UnityEngine.Transform val_7 = val_10.transform;
        UnityEngine.Transform val_8 = val_10.parent;
        if(val_10 != 0)
        {
            goto label_11;
        }
        
        return 1377638992 + val_11 + 1377638992;
    }
    public static UnityEngine.Color ParseColor(string text, int offset)
    {
        int val_19 = NGUIMath.HexToDecimal(ch:  offset.Chars[R2 + 1]);
        int val_20 = NGUIMath.HexToDecimal(ch:  offset.Chars[R2 + 2]);
        val_19 = val_19 | ((NGUIMath.HexToDecimal(ch:  offset.Chars[R2])) << 4);
        val_20 = (NGUIMath.HexToDecimal(ch:  offset.Chars[R2 + 3])) | (val_20 << 4);
        int val_17 = NGUIMath.HexToDecimal(ch:  offset.Chars[R2 + 5]);
        val_17 = val_17 | ((NGUIMath.HexToDecimal(ch:  offset.Chars[R2 + 4])) << 4);
        float val_21 = (float)val_19;
        float val_22 = (float)val_20;
        float val_23 = (float)val_17;
        val_21 = val_21 * 0.003921569f;
        val_22 = val_22 * 0.003921569f;
        val_23 = val_23 * 0.003921569f;
        text = new UnityEngine.Color(r:  val_21, g:  null, b:  val_22);
        return new UnityEngine.Color() {r = val_21, b = val_22};
    }
    public static string EncodeColor(UnityEngine.Color c)
    {
        int val_1 = NGUIMath.ColorToInt(c:  new UnityEngine.Color() {r = c.r, g = c.g, b = c.b, a = c.a});
        val_1 = val_1 >> 8;
        return NGUIMath.DecimalToHex(num:  val_1);
    }
    public static int ParseSymbol(string text, int index, System.Collections.Generic.List<UnityEngine.Color> colors, bool premultiply)
    {
        float val_9;
        float val_10;
        float val_11;
        float val_12;
        int val_19;
        int val_20;
        var val_21;
        float val_22;
        float val_23;
        float val_24;
        var val_25;
        val_19 = text;
        val_20 = text.m_stringLength;
        int val_1 = index + 2;
        val_21 = 0;
        if(val_1 >= val_20)
        {
                return (int)val_21;
        }
        
        int val_2 = index + 1;
        val_21 = 0;
        if(val_19.Chars[val_2] == ('-'))
        {
                val_21 = 0;
            if(val_19.Chars[val_1] != ']')
        {
                return (int)val_21;
        }
        
            val_21 = 3;
            if(colors == 0)
        {
                return (int)val_21;
        }
        
            if(premultiply < true)
        {
                return (int)val_21;
        }
        
            colors.RemoveAt(index:  premultiply - 1);
            return (int)val_21;
        }
        
        int val_6 = index + 7;
        if(val_6 >= val_20)
        {
                return (int)val_21;
        }
        
        val_21 = 0;
        if(val_19.Chars[val_6] != ']')
        {
                return (int)val_21;
        }
        
        val_21 = 8;
        if(colors == 0)
        {
                return (int)val_21;
        }
        
        UnityEngine.Color val_8 = NGUITools.ParseColor(text:  1805466888, offset:  val_19);
        val_20 = val_9;
        val_22 = val_10;
        int val_13 = NGUIMath.ColorToInt(c:  new UnityEngine.Color() {r = val_20, g = val_22, b = val_11, a = val_12});
        val_13 = val_13 >> 8;
        string val_14 = NGUIMath.DecimalToHex(num:  val_13);
        string val_19 = val_13;
        val_21 = 0;
        string val_15 = val_19.Substring(startIndex:  val_2, length:  6);
        val_19 = val_19;
        string val_16 = val_19.ToUpper();
        bool val_17 = System.String.op_Inequality(a:  val_19, b:  val_19);
        if(val_17 == true)
        {
                return (int)val_21;
        }
        
        val_19 = val_17 - 1;
        if(val_17 != true)
        {
                bool val_20 = false;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_23 = val_11;
        val_20 = val_20 + (val_19 << 4);
        val_24 = (0 + ((val_17 - 1)) << 4) + 28;
        if(val_17 == true)
        {
                val_20 = premultiply;
        }
        
        if(val_20 != false)
        {
                val_25 = null;
            val_25 = null;
            UnityEngine.Color val_18 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = 3.801791E+26f, g = NGUITools.mInvisible}, b:  new UnityEngine.Color() {r = NGUITools.mListener.__il2cppRuntimeField_18, g = val_20, b = val_22, a = val_23}, t:  1f);
            val_20 = val_9;
            val_22 = val_10;
            val_23 = val_11;
            val_24 = val_12;
        }
        
        colors.Add(item:  new UnityEngine.Color() {r = val_20, g = val_22, b = val_23, a = val_24});
        val_21 = 8;
        return (int)val_21;
    }
    public static string StripSymbols(string text)
    {
        string val_4;
        int val_5;
        val_4 = text;
        if(val_4 == null)
        {
            goto label_1;
        }
        
        val_5 = text.m_stringLength;
        if(val_5 < 1)
        {
                return;
        }
        
        var val_4 = 0;
        goto label_13;
        label_1:
        val_4 = 0;
        return;
        label_12:
        string val_1 = val_4.Remove(startIndex:  35653781, count:  1);
        val_4 = val_4;
        val_5 = 0;
        goto label_7;
        label_13:
        if(val_4.Chars[0] == '[')
        {
                if((NGUITools.ParseSymbol(text:  val_4, index:  0, colors:  0, premultiply:  false)) >= 1)
        {
            goto label_12;
        }
        
        }
        
        val_4 = val_4 + 1;
        label_7:
        if(val_4 < val_5)
        {
            goto label_13;
        }
    
    }
    public static T[] FindActive<T>()
    {
        System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24});
        UnityEngine.Object[] val_2 = UnityEngine.Object.FindObjectsOfType(type:  __RuntimeMethodHiddenParam + 24);
    }
    public static UnityEngine.Camera FindCameraForLayer(int layer)
    {
        var val_5;
        var val_6;
        T[] val_1 = NGUITools.FindActive<UnityEngine.Camera>();
        val_5 = 0;
        val_6 = public static T[] NGUITools::FindActive<UnityEngine.Camera>().__il2cppRuntimeField_C;
        goto label_5;
        label_9:
        val_5 = 1;
        label_5:
        if(((public static T[] NGUITools::FindActive<UnityEngine.Camera>().__il2cppRuntimeField_14.cullingMask) & (1 << (layer & 31))) != 0)
        {
            goto label_9;
        }
    
    }
    public static string GetName<T>()
    {
        var val_5;
        System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24});
        if((__RuntimeMethodHiddenParam + 24) == 0)
        {
            goto label_4;
        }
        
        val_5 = 2;
        if((__RuntimeMethodHiddenParam + 24.StartsWith(value:  1805920352)) == false)
        {
            goto label_5;
        }
        
        return __RuntimeMethodHiddenParam + 24.Substring(startIndex:  12);
        label_4:
        val_5 = 2;
        if((0.StartsWith(value:  1805920352)) == true)
        {
                return __RuntimeMethodHiddenParam + 24.Substring(startIndex:  12);
        }
        
        label_5:
        if((__RuntimeMethodHiddenParam + 24.StartsWith(value:  1805920432)) == false)
        {
                return;
        }
        
        val_5 = 12;
        if((__RuntimeMethodHiddenParam + 24) != 0)
        {
                return __RuntimeMethodHiddenParam + 24.Substring(startIndex:  12);
        }
        
        return __RuntimeMethodHiddenParam + 24.Substring(startIndex:  12);
    }
    public static UnityEngine.GameObject AddChild(UnityEngine.GameObject parent)
    {
        float val_7;
        UnityEngine.GameObject val_1 = new UnityEngine.GameObject();
        if(parent == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_3 = transform;
        UnityEngine.Transform val_4 = parent.transform;
        parent = parent;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        localPosition = new UnityEngine.Vector3();
        UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.identity;
        localRotation = new UnityEngine.Quaternion() {w = val_7};
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
        localScale = new UnityEngine.Vector3();
        layer = parent.layer;
    }
    public static UnityEngine.GameObject AddChild(UnityEngine.GameObject parent, UnityEngine.GameObject prefab)
    {
        return NGUITools.AddChild(parent:  parent, prefab:  prefab, pooling:  false);
    }
    public static UnityEngine.GameObject AddChild(UnityEngine.GameObject parent, UnityEngine.GameObject prefab, bool pooling)
    {
        float val_8;
        object val_1 = UnityEngine.Object.Instantiate<System.Object>(original:  prefab);
        if(prefab == 0)
        {
                return;
        }
        
        if(parent == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_4 = prefab.transform;
        1152921504765685760 = prefab;
        UnityEngine.Transform val_5 = parent.transform;
        1152921504765685760.parent = parent;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        1152921504765685760.localPosition = new UnityEngine.Vector3();
        UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.identity;
        1152921504765685760.localRotation = new UnityEngine.Quaternion() {w = val_8};
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
        1152921504765685760.localScale = new UnityEngine.Vector3();
        prefab.layer = parent.layer;
    }
    public static T AddChild<T>(UnityEngine.GameObject parent)
    {
        UnityEngine.GameObject val_1 = NGUITools.AddChild(parent:  parent);
        if(parent != 0)
        {
                parent.name = __RuntimeMethodHiddenParam + 24;
        }
        else
        {
                parent.name = __RuntimeMethodHiddenParam + 24;
        }
    
    }
    public static UnityEngine.GameObject GetRoot(UnityEngine.GameObject go)
    {
        UnityEngine.Transform val_1 = go.transform;
        do
        {
            UnityEngine.Transform val_2 = go.parent;
        }
        while(go != 0);
        
        if(go != 0)
        {
                return go.gameObject;
        }
        
        return go.gameObject;
    }
    public static T FindInParents<T>(UnityEngine.GameObject go)
    {
        UnityEngine.Object val_6;
        var val_7;
        var val_8;
        val_6 = go;
        val_7 = 0;
        if(val_6 == 0)
        {
                return;
        }
        
        val_8 = val_6;
        if(val_6 != 0)
        {
            goto label_11;
        }
        
        val_8 = 0;
        UnityEngine.Transform val_2 = val_6.transform;
        label_15:
        UnityEngine.Transform val_3 = val_6.parent;
        val_6 = val_6;
        if((val_8 != 0) || (val_6 == 0))
        {
            goto label_11;
        }
        
        UnityEngine.GameObject val_5 = val_6.gameObject;
        if(val_6 != 0)
        {
            goto label_15;
        }
        
        goto label_15;
        label_11:
        if(val_8 == 0)
        {
                return;
        }
        
        val_7 = val_8;
        if(val_8 != 0)
        {
                return;
        }
        
        val_7 = 0;
    }
    public static void Destroy(UnityEngine.Object obj)
    {
        NGUITools.Destroy(obj:  obj, withPool:  false);
    }
    public static void Destroy(UnityEngine.Object obj, bool withPool)
    {
        if(obj == 0)
        {
                return;
        }
        
        if(UnityEngine.Application.isPlaying != false)
        {
                if((obj != 0) && (null == null))
        {
                UnityEngine.Transform val_3 = obj.transform;
            obj.parent = 0;
        }
        
            UnityEngine.Object.Destroy(obj:  obj);
            return;
        }
        
        UnityEngine.Object.DestroyImmediate(obj:  obj);
    }
    public static void DestroyImmediate(UnityEngine.Object obj)
    {
        if(obj == 0)
        {
                return;
        }
        
        var val_3 = R5 + 186;
        val_3 = val_3 & 512;
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Object.DestroyImmediate(obj:  R4);
            return;
        }
        
        UnityEngine.Object.Destroy(obj:  R4);
    }
    public static void Broadcast(string funcName)
    {
        var val_4;
        System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(157720576)});
        UnityEngine.Object[] val_2 = UnityEngine.Object.FindObjectsOfType(type:  157720576);
        val_4 = 0;
        goto label_7;
        label_10:
        val_4 = 1;
        label_7:
        typeof(UnityEngine.GameObject).__il2cppRuntimeField_14.SendMessage(methodName:  funcName, options:  1);
        if(1152921506216658367 != val_4)
        {
            goto label_10;
        }
    
    }
    public static void Broadcast(string funcName, object param)
    {
        var val_4;
        System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(157720576)});
        UnityEngine.Object[] val_2 = UnityEngine.Object.FindObjectsOfType(type:  157720576);
        val_4 = 0;
        goto label_7;
        label_10:
        val_4 = 1;
        label_7:
        typeof(UnityEngine.GameObject).__il2cppRuntimeField_14.SendMessage(methodName:  funcName, value:  param, options:  1);
        if(1152921506216658367 != val_4)
        {
            goto label_10;
        }
    
    }
    public static bool IsChild(UnityEngine.Transform parent, UnityEngine.Transform child)
    {
        UnityEngine.Object val_6;
        var val_7;
        val_6 = child;
        val_7 = 0;
        if(parent == 0)
        {
                return (bool)val_7;
        }
        
        val_7 = 0;
        if(val_6 == 0)
        {
                return (bool)val_7;
        }
        
        val_7 = 0;
        goto label_7;
        label_14:
        UnityEngine.Transform val_3 = val_6.parent;
        val_6 = val_6;
        label_7:
        if(val_6 == 0)
        {
                return (bool)val_7;
        }
        
        if(val_6 != parent)
        {
            goto label_14;
        }
        
        val_7 = 1;
        return (bool)val_7;
    }
    private static void Activate(UnityEngine.Transform t)
    {
        var val_8;
        var val_9;
        UnityEngine.GameObject val_1 = t.gameObject;
        var val_8 = 0;
        t.SetActive(value:  true);
        val_8 = t.childCount;
        label_10:
        if(val_8 >= val_8)
        {
            goto label_7;
        }
        
        UnityEngine.Transform val_3 = t.GetChild(index:  0);
        UnityEngine.GameObject val_4 = t.gameObject;
        val_9 = t;
        val_8 = val_8 + 1;
        if(val_9.activeSelf == false)
        {
            goto label_10;
        }
        
        return;
        label_7:
        var val_9 = 0;
        int val_6 = t.childCount;
        if(val_6 < 1)
        {
                return;
        }
        
        val_8 = val_6;
        do
        {
            UnityEngine.Transform val_7 = t.GetChild(index:  0);
            val_9 = t;
            val_9 = val_9 + 1;
        }
        while(val_8 != val_9);
    
    }
    private static void Deactivate(UnityEngine.Transform t)
    {
        UnityEngine.GameObject val_1 = t.gameObject;
        t.SetActive(value:  false);
    }
    public static void SetActive(UnityEngine.GameObject go, bool state)
    {
        UnityEngine.Transform val_1 = go.transform;
        if(state != false)
        {
                NGUITools.Activate(t:  go);
            return;
        }
        
        NGUITools.Deactivate(t:  go);
    }
    public static void SetActiveChildren(UnityEngine.GameObject go, bool state)
    {
        var val_5;
        var val_6;
        UnityEngine.Transform val_7;
        val_5 = state;
        UnityEngine.Transform val_1 = go.transform;
        int val_2 = go.childCount;
        if(val_5 != false)
        {
                if(val_2 < 1)
        {
                return;
        }
        
            val_6 = 1152921504866004992;
            do
        {
            UnityEngine.Transform val_3 = go.GetChild(index:  0);
            val_7 = go;
            NGUITools.Activate(t:  val_7);
            val_5 = 0 + 1;
        }
        while(val_2 != val_5);
        
            return;
        }
        
        if(val_2 < 1)
        {
                return;
        }
        
        val_6 = 1152921504866004992;
        do
        {
            UnityEngine.Transform val_4 = go.GetChild(index:  0);
            val_7 = go;
            NGUITools.Deactivate(t:  val_7);
            val_5 = 0 + 1;
        }
        while(val_2 != val_5);
    
    }
    public static bool GetActive(UnityEngine.GameObject go)
    {
        if((UnityEngine.Object.op_Implicit(exists:  go)) == false)
        {
                return false;
        }
        
        if(go != 0)
        {
                return go.activeInHierarchy;
        }
        
        return go.activeInHierarchy;
    }
    public static void SetActiveSelf(UnityEngine.GameObject go, bool state)
    {
        go.SetActive(value:  state);
    }
    public static void SetLayer(UnityEngine.GameObject go, int layer)
    {
        var val_5;
        if(go != 0)
        {
                go.layer = layer;
        }
        else
        {
                0.layer = layer;
        }
        
        UnityEngine.Transform val_1 = go.transform;
        val_5 = 0;
        int val_2 = go.childCount;
        if(val_2 < 1)
        {
                return;
        }
        
        do
        {
            UnityEngine.Transform val_3 = go.GetChild(index:  0);
            UnityEngine.GameObject val_4 = go.gameObject;
            val_5 = val_5 + 1;
        }
        while(val_2 != val_5);
    
    }
    public static UnityEngine.Vector3 Round(UnityEngine.Vector3 v)
    {
        var val_1;
        var val_6;
        float val_7;
        float val_8;
        var val_10;
        float val_11;
        float val_12;
        var val_14;
        float val_15;
        float val_16;
        val_6 = val_1;
        val_7 = -1f;
        float val_2 = S18 + ;
        if((UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished & 1) != 0)
        {
                val_8 = S18;
        }
        
        val_10 = val_1;
        val_11 = -1f;
        float val_3 = S20 + ;
        if((UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished & 1) != 0)
        {
                val_12 = S20;
        }
        
        val_14 = val_1;
        val_15 = -1f;
        float val_4 = S22 + ;
        if((UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished & 1) != 0)
        {
                val_16 = S22;
        }
        
        mem2[0] = ;
        mem2[0] = ;
        mem2[0] = ;
        return new UnityEngine.Vector3() {};
    }
    public static bool Save(string fileName, byte[] bytes)
    {
        var val_5;
        var val_6;
        val_5 = 35653800;
        string val_1 = UnityEngine.Application.persistentDataPath;
        string val_2 = null + 1115175264 + fileName;
        if(bytes != null)
        {
                System.IO.FileStream val_3 = System.IO.File.Create(path:  null);
            val_6 = 1;
            return (bool)val_6;
        }
        
        val_6 = 1;
        if((System.IO.File.Exists(path:  null)) == false)
        {
                return (bool)val_6;
        }
        
        System.IO.File.Delete(path:  null);
        return (bool)val_6;
    }
    public static byte[] Load(string fileName)
    {
        string val_1 = UnityEngine.Application.persistentDataPath;
        string val_2 = null + 1115175264 + fileName;
        if((System.IO.File.Exists(path:  null)) == false)
        {
                return;
        }
        
        return System.IO.File.ReadAllBytes(path:  null);
    }
    public static UnityEngine.Color ApplyPMA(UnityEngine.Color c)
    {
        var val_1;
        float val_2;
        float val_3;
        val_2 = 1f;
        if()
        {
                return new UnityEngine.Color() {r = val_3, b = val_2};
        }
        
        float val_2 = c.a;
        val_2 = val_2 * val_1;
        val_2 = c.b * val_1;
        val_3 = c.g * val_1;
        return new UnityEngine.Color() {r = val_3, b = val_2};
    }
    private static System.Reflection.PropertyInfo GetSystemCopyBufferProperty()
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        if((System.Reflection.PropertyInfo.op_Equality(left:  NGUITools.mSystemCopyBuffer, right:  0)) != false)
        {
                System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(183386112)});
            System.Reflection.PropertyInfo val_3 = GetProperty(name:  1808888080, bindingAttr:  40);
            val_5 = null;
            val_5 = null;
            NGUITools.mSystemCopyBuffer = null;
        }
        else
        {
                val_5 = null;
        }
        
        val_5 = null;
    }
    public static string get_clipboard()
    {
        var val_3;
        System.Reflection.PropertyInfo val_1 = NGUITools.GetSystemCopyBufferProperty();
        val_3 = 0;
        if((System.Reflection.PropertyInfo.op_Inequality(left:  259158016, right:  0)) == false)
        {
                return;
        }
        
        val_3 = 0;
        if(null == 0)
        {
                return;
        }
        
        if(null != null)
        {
                return;
        }
        
        val_3 = null;
    }
    public static void set_clipboard(string value)
    {
        System.Reflection.PropertyInfo val_1 = NGUITools.GetSystemCopyBufferProperty();
        if((System.Reflection.PropertyInfo.op_Inequality(left:  259158016, right:  0)) == false)
        {
                return;
        }
    
    }
    private static NGUITools()
    {
        NGUITools.mLoaded = false;
        NGUITools.mGlobalVolume = 1f;
        UnityEngine.Color val_1 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
        NGUITools.mSystemCopyBuffer = false;
    }

}
