using UnityEngine;
public class CUtils
{
    // Fields
    private static UnityEngine.AndroidJavaClass cls_UnityPlayer;
    private static UnityEngine.AndroidJavaObject obj_Activity;
    private static System.Collections.Generic.List<string> validContactPoints;
    private static System.Collections.Generic.List<string> invalidSceneIndeces;
    
    // Methods
    private static CUtils()
    {
        Add(item:  2137900160);
        CUtils.validContactPoints = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  2137900272);
        CUtils.invalidSceneIndeces = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
    }
    public static string ReadFileContent(string path)
    {
        UnityEngine.Object val_1 = UnityEngine.Resources.Load(path:  path);
        if(path != null)
        {
                if(((System.String.__il2cppRuntimeField_typeHierarchy + (UnityEngine.TextAsset.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                path = 0;
        }
        
            0 = path;
        }
        
        if(0 == 0)
        {
                return;
        }
        
        if(0 != 0)
        {
                return val_3.text;
        }
        
        return val_3.text;
    }
    public static UnityEngine.Vector3 CopyVector3(UnityEngine.Vector3 ori)
    {
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        val_1 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
        return new UnityEngine.Vector3();
    }
    public static bool EqualVector3(UnityEngine.Vector3 v1, UnityEngine.Vector3 v2)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 3.23275E+38f, y = v1.x, z = v1.y}, b:  new UnityEngine.Vector3() {x = v1.z, y = v2.x, z = v2.y});
        float val_2 = UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3());
        if(UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished <= 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public static float GetSign(UnityEngine.Vector3 A, UnityEngine.Vector3 B, UnityEngine.Vector3 M)
    {
        float val_1 = M.y - A.y;
        float val_3 = M.x - A.x;
        float val_4 = B.y - A.y;
        val_1 = (B.x - A.x) * val_1;
        return UnityEngine.Mathf.Sign(f:  val_1);
    }
    public static UnityEngine.Vector3 RotatePointAroundPivot(UnityEngine.Vector3 point, UnityEngine.Vector3 pivot, UnityEngine.Vector3 angles)
    {
        float val_3;
        float val_6 = pivot.z;
        val_6 = val_6;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 3.278183E+38f, y = point.y, z = point.z}, b:  new UnityEngine.Vector3() {x = pivot.x, y = pivot.y, z = val_6});
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 3.278179E+38f, y = angles.y, z = angles.z});
        UnityEngine.Vector3 val_4 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = 3.278177E+38f}, point:  new UnityEngine.Vector3() {x = val_3});
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 3.278174E+38f}, b:  new UnityEngine.Vector3() {y = pivot.y, z = pivot.z});
        return new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
    }
    public static void Shuffle<T>(T[] array)
    {
        var val_2;
        val_2 = 0;
        goto label_0;
        label_6:
        mem2[0] = array[UnityEngine.Random.Range(min:  0, max:  0)];
        val_2 = 1;
        mem2[0] = null;
        label_0:
        if(val_2 < 0)
        {
            goto label_6;
        }
    
    }
    public static string[] SeparateLines(string lines)
    {
        string val_1 = lines.Replace(oldValue:  2138770384, newValue:  1269544832);
        string val_2 = lines.Replace(oldValue:  1975550000, newValue:  1269544832);
        typeof(System.Char[]).__il2cppRuntimeField_10 = Chars[0];
        if(lines != null)
        {
                return lines.Split(separator:  478563824);
        }
        
        return lines.Split(separator:  478563824);
    }
    public static void ChangeSortingLayerRecursively(UnityEngine.Transform root, string sortingLayerName, int offsetOrder = 0)
    {
        string val_12;
        UnityEngine.Object val_13;
        var val_14;
        var val_15;
        float val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        val_12 = sortingLayerName;
        object val_1 = root.GetComponent<System.Object>();
        val_13 = root;
        if(val_13 != 0)
        {
                if(val_13 != 0)
        {
                val_13.sortingLayerName = val_12;
            val_14 = val_13.sortingOrder;
        }
        else
        {
                val_13 = 0;
            0.sortingLayerName = val_12;
            val_14 = 0.sortingOrder;
        }
        
            val_13.sortingOrder = val_14 + offsetOrder;
        }
        
        System.Collections.IEnumerator val_6 = root.GetEnumerator();
        val_15 = root;
        val_16 = 1152921504683417600;
        label_25:
        var val_11 = 0;
        val_11 = val_11 + 1;
        val_17 = val_15;
        if(val_15 == 0)
        {
            goto label_13;
        }
        
        var val_12 = 0;
        val_12 = val_12 + 1;
        val_18 = val_15;
        if(val_15 == 0)
        {
            goto label_25;
        }
        
        goto label_25;
        label_13:
        val_19 = 0;
        val_20 = 1152921504619679744;
        if(val_15 != 0)
        {
                val_20 = 0;
            val_15 = 0;
            val_20 = val_20 + 1;
            val_15 = (uint)val_20 & 65535;
            val_21 = val_15;
        }
        
        var val_10 = FP - 28;
    }
    public static void ChangeRendererColorRecursively(UnityEngine.Transform root, UnityEngine.Color color)
    {
        float val_9;
        var val_10;
        float val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_9 = color.r;
        object val_1 = root.GetComponent<System.Object>();
        if(root != 0)
        {
                root.color = new UnityEngine.Color() {r = val_9, g = color.g, b = color.b, a = color.a};
        }
        
        System.Collections.IEnumerator val_3 = root.GetEnumerator();
        val_10 = root;
        val_11 = 1152921504683417600;
        label_24:
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_12 = val_10;
        if(val_10 == 0)
        {
            goto label_12;
        }
        
        var val_9 = 0;
        val_9 = val_9 + 1;
        val_13 = val_10;
        if(val_10 == 0)
        {
            goto label_24;
        }
        
        goto label_24;
        label_12:
        val_14 = 0;
        val_15 = 1152921504619679744;
        if(val_10 != 0)
        {
                val_10 = 0;
            val_15 = 0;
            val_10 = val_10 + 1;
            val_15 = (uint)val_10 & 65535;
            val_16 = val_10;
        }
        
        var val_7 = FP - 28;
    }
    public static void ChangeImageColorRecursively(UnityEngine.Transform root, UnityEngine.Color color)
    {
        var val_9;
        var val_10;
        float val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_9 = color.r;
        object val_1 = root.GetComponent<System.Object>();
        bool val_2 = UnityEngine.Object.op_Inequality(x:  root, y:  0);
        System.Collections.IEnumerator val_3 = root.GetEnumerator();
        val_10 = root;
        val_11 = 1152921504683417600;
        label_24:
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_12 = val_10;
        if(val_10 == 0)
        {
            goto label_12;
        }
        
        var val_9 = 0;
        val_9 = val_9 + 1;
        val_13 = val_10;
        if(val_10 == 0)
        {
            goto label_24;
        }
        
        goto label_24;
        label_12:
        val_14 = 0;
        val_15 = 1152921504619679744;
        if(val_10 != 0)
        {
                val_10 = 0;
            val_15 = 0;
            val_10 = val_10 + 1;
            val_15 = (uint)val_10 & 65535;
            val_16 = val_10;
        }
        
        var val_7 = FP - 28;
    }
    public static string GetFacePictureURL(string facebookID, System.Nullable<int> width, System.Nullable<int> height, string type)
    {
        var val_1;
        string val_5;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        val_14 = val_1;
        string val_2 = System.String.Format(format:  2139263520, arg0:  facebookID);
        val_15 = "/{0}/picture";
        if((height.HasValue & true) == 0)
        {
                string val_3 = width.HasValue.ToString();
            string val_4 = 2139264640 + 2139277072;
            val_14 = val_14;
            val_16 = "&width=";
        }
        else
        {
                val_16 = "";
        }
        
        if((val_14 & 255) == 0)
        {
                string val_6 = type.ToString();
            string val_7 = 2139264736 + 2139277064;
            val_17 = "&height=";
        }
        else
        {
                val_17 = "";
        }
        
        string val_8 = 1098586544 + 1098586544;
        if(val_5 != 0)
        {
                string val_9 = 2139264832 + val_5;
            val_18 = "&type=";
        }
        else
        {
                val_18 = "";
        }
        
        string val_10 = 1098586544 + 1098586544;
        string val_11 = 1098586544 + 2139264912;
        if((System.String.op_Inequality(a:  1098586544, b:  1098586544)) == false)
        {
                return;
        }
        
        string val_13 = 2139263520 + 2139265024 + 1098586544;
        val_15 = val_15;
    }
    public static double GetCurrentTime()
    {
        var val_6;
        System.DateTime val_1 = System.DateTime.Now;
        System.DateTime val_4 = new System.DateTime(year:  1970, month:  1, day:  1, hour:  0, minute:  0, second:  0);
        System.TimeSpan val_5 = Subtract(value:  new System.DateTime() {dateData = 1152921511041211536});
        return (double)val_6.TotalSeconds;
    }
    public static double GetCurrentTimeInDays()
    {
        var val_6;
        System.DateTime val_1 = System.DateTime.Now;
        System.DateTime val_4 = new System.DateTime(year:  1970, month:  1, day:  1, hour:  0, minute:  0, second:  0);
        System.TimeSpan val_5 = Subtract(value:  new System.DateTime() {dateData = 1152921511041323536});
        return (double)val_6.TotalDays;
    }
    public static double GetCurrentTimeInMills()
    {
        var val_6;
        System.DateTime val_1 = System.DateTime.Now;
        System.DateTime val_4 = new System.DateTime(year:  1970, month:  1, day:  1, hour:  0, minute:  0, second:  0);
        System.TimeSpan val_5 = Subtract(value:  new System.DateTime() {dateData = 1152921511041435536});
        return (double)val_6.TotalMilliseconds;
    }
    public static T GetRandom<T>(T[] arr)
    {
        var val_3;
        var val_4;
        if(arr != null)
        {
                val_3 = arr;
            val_4 = UnityEngine.Random.Range(min:  0, max:  __RuntimeMethodHiddenParam);
        }
        else
        {
                val_3 = 12;
            val_4 = UnityEngine.Random.Range(min:  0, max:  0);
        }
        
        T val_3 = arr[val_4];
    }
    public static bool IsActionAvailable(string action, int time, bool availableFirstTime = True)
    {
        string val_1 = action + 2139911120;
        if((CPlayerPrefs.HasKey(key:  action)) != false)
        {
                double val_3 = CUtils.GetCurrentTime();
            double val_4 = CUtils.GetActionTime(action:  action);
            long val_5 = 275664896;
            val_5 = val_5 - action;
            if(CUtils.__il2cppRuntimeField_cctor_finished == 0)
        {
                val_5 = -val_5;
        }
        
            if(S0 >= time)
        {
                0 = 1;
        }
        
            return true;
        }
        
        if(availableFirstTime != false)
        {
                return true;
        }
        
        CUtils.SetActionTime(action:  action);
        return false;
    }
    public static double GetActionDeltaTime(string action)
    {
        var val_6;
        double val_1 = CUtils.GetActionTime(action:  action);
        double val_2 = CUtils.GetCurrentTime();
        val_6 = 275664896 - action;
        return (double)CUtils.GetActionTime(action:  action);
    }
    public static void SetActionTime(string action)
    {
        string val_1 = action + 2139911120;
        CPlayerPrefs.SetDouble(key:  action, value:  CUtils.GetCurrentTime());
    }
    public static void SetActionTime(string action, double time)
    {
        string val_1 = action + 2139911120;
        CPlayerPrefs.SetDouble(key:  action, value:  time);
    }
    public static double GetActionTime(string action)
    {
        string val_1 = action + 2139911120;
        return CPlayerPrefs.GetDouble(key:  action);
    }
    public static void SetLoggedInFb()
    {
        CPlayerPrefs.SetBool(key:  2140508064, value:  true);
    }
    public static bool IsLoggedInFb()
    {
        return CPlayerPrefs.GetBool(key:  2140508064, defaultValue:  false);
    }
    public static void SetBuyItem()
    {
        CPlayerPrefs.SetBool(key:  2140732160, value:  true);
    }
    public static void SetRemoveAds(bool value)
    {
        CPlayerPrefs.SetBool(key:  2140844256, value:  value);
    }
    public static bool IsAdsRemoved()
    {
        return CPlayerPrefs.GetBool(key:  2140844256, defaultValue:  false);
    }
    public static bool IsBuyItem()
    {
        return CPlayerPrefs.GetBool(key:  2140732160, defaultValue:  false);
    }
    public static void SetRateGame()
    {
        CPlayerPrefs.SetBool(key:  2141180352, value:  true);
    }
    public static bool IsGameRated()
    {
        return CPlayerPrefs.GetBool(key:  2141180352, defaultValue:  false);
    }
    public static void SetLikeFbPage(string id)
    {
        string val_1 = 2141408544 + id;
        CPlayerPrefs.SetBool(key:  2141408544, value:  true);
    }
    public static bool IsLikedFbPage(string id)
    {
        string val_1 = 2141408544 + id;
        return CPlayerPrefs.GetBool(key:  2141408544, defaultValue:  false);
    }
    public static void SetInitGame()
    {
        CPlayerPrefs.SetBool(key:  2141644928, value:  true);
    }
    public static bool IsGameInitialzied()
    {
        return CPlayerPrefs.GetBool(key:  2141644928, defaultValue:  false);
    }
    public static void SetAndroidVersion(string version)
    {
        CPlayerPrefs.SetString(key:  2141873120, val:  version);
    }
    public static void SetIOSVersion(string version)
    {
        CPlayerPrefs.SetString(key:  2141993424, val:  version);
    }
    public static void SetWindowsPhoneVersion(string version)
    {
        CPlayerPrefs.SetString(key:  2142113712, val:  version);
    }
    public static string GetAndroidVersion()
    {
        return CPlayerPrefs.GetString(key:  2141873120, defaultValue:  1470926448);
    }
    public static string GetIOSVersion()
    {
        return CPlayerPrefs.GetString(key:  2141993424, defaultValue:  1470926448);
    }
    public static string GetWindowsPhoneVersion()
    {
        return CPlayerPrefs.GetString(key:  2142113712, defaultValue:  1470926448);
    }
    public static void SetVersionCode(int versionCode)
    {
        CPlayerPrefs.SetInt(key:  2142565904, val:  versionCode);
    }
    public static int GetVersionCode()
    {
        return CPlayerPrefs.GetInt(key:  2142565904);
    }
    public static string BuildStringFromCollection(System.Collections.ICollection values, char split = '\x7c')
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_9 = 0;
        val_9 = val_9 + 1;
        val_10 = values;
        val_11 = "";
        goto label_6;
        label_24:
        var val_9 = 0;
        val_9 = 0;
        val_9 = val_9 + 1;
        val_9 = (uint)val_9 & 65535;
        val_12 = values;
        string val_3 = 1098586544 + values;
        val_9 = 0;
        val_9 = val_9 + 1;
        val_13 = values;
        System.Collections.ICollection val_10 = values;
        val_10 = val_10 - 1;
        if(0 == val_10)
        {
                val_11 = val_11;
        }
        else
        {
                string val_5 = split.ToString();
            string val_6 = 1098586544 + 2142806074;
            val_11 = val_11;
        }
        
        label_6:
        val_9 = 0;
        val_9 = val_9 + 1;
        val_14 = values;
        if(values != 0)
        {
            goto label_24;
        }
        
        val_15 = 1152921504619679744;
        if(values != 0)
        {
                val_9 = 0;
            val_15 = 0;
            val_9 = val_9 + 1;
            val_15 = (uint)val_9 & 65535;
            val_16 = values;
        }
        
        if(0 == 0)
        {
                return;
        }
    
    }
    public static System.Collections.Generic.List<T> BuildListFromString<T>(string values, char split = '\x7c')
    {
        string val_7;
        char val_8;
        var val_9;
        var val_10;
        val_7 = values;
        val_8 = split;
        if((System.String.IsNullOrEmpty(value:  val_7)) == true)
        {
                return;
        }
        
        val_9 = null;
        typeof(System.Char[]).__il2cppRuntimeField_10 = val_8;
        val_10 = 0;
        System.String[] val_2 = val_7.Split(separator:  478563824);
        val_7 = val_7;
        val_8 = val_7 + 16;
        goto label_6;
        label_18:
        if((System.String.IsNullOrEmpty(value:  15388672)) == true)
        {
            goto label_8;
        }
        
        System.Type val_4 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 8});
        object val_5 = System.Convert.ChangeType(value:  15388672, conversionType:  __RuntimeMethodHiddenParam + 24 + 8);
        val_9 = 1152921504622235648;
        if((mem[null + 32]) != (__RuntimeMethodHiddenParam + 24 + 12 + 32))
        {
            goto label_15;
        }
        
        val_9.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        label_8:
        val_10 = 1;
        label_6:
        if(val_10 < values.m_firstChar)
        {
            goto label_18;
        }
        
        return;
        label_15:
    }
    public static bool IsOutOfScreen(UnityEngine.Vector3 pos, float padding = 0)
    {
        if(WordUICamera.instance != 0)
        {
            goto label_1;
        }
        
        WordUICamera.instance = WordUICamera.instance;
        if(WordUICamera.instance == 0)
        {
            goto label_2;
        }
        
        label_1:
        var val_2 = R3;
        var val_1 = WordUICamera.instance + 60;
        val_1 = val_1 + val_2;
        if(WordUICamera.instance < 0)
        {
                return true;
        }
        
        val_2 = (WordUICamera.instance + 64) + val_2;
        if(WordUICamera.instance < 0)
        {
                0 = 1;
        }
        
        if(WordUICamera.instance < 0)
        {
                0 = 1;
        }
        
        return true;
        label_2:
    }
    public static void SetNumofEnterScene(string sceneName, int value)
    {
        string val_1 = 2143146496 + sceneName;
        CPlayerPrefs.SetInt(key:  2143146496, val:  value);
    }
    public static int GetNumofEnterScene(string sceneName)
    {
        string val_1 = 2143146496 + sceneName;
        return CPlayerPrefs.GetInt(key:  2143146496, defaultValue:  0);
    }
    public static int IncreaseNumofEnterScene(string sceneName)
    {
        int val_2 = (CUtils.GetNumofEnterScene(sceneName:  sceneName)) + 1;
        CUtils.SetNumofEnterScene(sceneName:  sceneName, value:  val_2);
        return val_2;
    }
    public static System.Collections.Generic.List<T> GetObjectInRange<T>(UnityEngine.Vector3 position, float radius, int layerMask = -5)
    {
        float val_3;
        float val_4;
        var val_9;
        float val_10;
        var val_11;
        float val_12;
        val_9 = position.z;
        val_10 = position.y;
        val_11 = 0;
        val_12 = __RuntimeMethodHiddenParam;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 0f, y = position.x, z = val_10});
        float val_9 = val_3;
        UnityEngine.Collider2D[] val_5 = UnityEngine.Physics2D.OverlapCircleAll(point:  new UnityEngine.Vector2() {x = val_9, y = val_4}, radius:  val_2.x, layerMask:  layerMask);
        val_9 = val_9 + 16;
        goto label_6;
        label_18:
        UnityEngine.GameObject val_6 = (val_3 + 16) + 0.gameObject;
        System.Type val_7 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = val_1 + 24 + 8});
        UnityEngine.Component val_8 = (val_3 + 16) + 0.GetComponent(type:  val_1 + 24 + 8);
        val_9 = (val_3 + 16) + 0;
        val_10 = mem[val_1 + 24 + 12];
        val_10 = val_1 + 24 + 12;
        val_11 = 1;
        label_6:
        if(val_11 < (val_3 + 12))
        {
            goto label_18;
        }
    
    }
    public static UnityEngine.Sprite GetSprite(string textureName, string spriteName)
    {
        var val_5;
        T[] val_1 = UnityEngine.Resources.LoadAll<System.Object>(path:  textureName);
        string val_2 = textureName + 16;
        var val_5 = 0;
        label_5:
        if(val_5 >= textureName.m_firstChar)
        {
            goto label_2;
        }
        
        string val_3 = 1152921504622235648.name;
        val_5 = val_5 + 1;
        if((System.String.op_Equality(a:  15388672, b:  spriteName)) == false)
        {
            goto label_5;
        }
        
        return;
        label_2:
        val_5 = 0;
    }
    public static System.Collections.Generic.List<UnityEngine.Transform> GetActiveChildren(UnityEngine.Transform parent)
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.IEnumerator val_2 = parent.GetEnumerator();
        label_19:
        val_8 = 0;
        val_9 = 0;
        val_8 = val_8 + 1;
        val_9 = (uint)val_8 & 65535;
        val_10 = parent;
        if(parent == 0)
        {
            goto label_7;
        }
        
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_11 = parent;
        val_12 = parent;
        val_12 = 0;
        UnityEngine.GameObject val_5 = val_12.gameObject;
        if(val_12.activeSelf == false)
        {
            goto label_19;
        }
        
        Add(item:  0);
        goto label_19;
        label_7:
        if(parent != 0)
        {
                val_8 = 0;
            val_8 = val_8 + 1;
            val_13 = parent;
        }
        
        if(0 == 0)
        {
                return;
        }
    
    }
    public static System.Collections.Generic.List<UnityEngine.Transform> GetChildren(UnityEngine.Transform parent)
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.IEnumerator val_2 = parent.GetEnumerator();
        label_17:
        val_6 = 0;
        val_6 = val_6 + 1;
        val_7 = parent;
        if(parent == 0)
        {
            goto label_7;
        }
        
        var val_6 = 0;
        val_6 = val_6 + 1;
        val_8 = parent;
        Add(item:  0);
        goto label_17;
        label_7:
        val_9 = 1152921504619679744;
        if(parent != 0)
        {
                val_9 = 0;
            val_6 = 0;
            val_9 = val_9 + 1;
            val_6 = (uint)val_9 & 65535;
            val_10 = parent;
        }
        
        if(0 == 0)
        {
                return;
        }
    
    }
    public static bool IsLoadingScene()
    {
        var val_2 = 0;
        if(ScreenFaderV2.fadeInTime == 0)
        {
                return true;
        }
        
        val_2 = 1;
        if((ScreenFaderV2.fadeInTime + 12) != 0)
        {
                return true;
        }
        
        if((ScreenFaderV2.fadeInTime + 13) != 0)
        {
                val_2 = 1;
        }
        
        return true;
    }
    public static void FadeAndLoadScene(string sceneName)
    {
        var val_7;
        var val_8;
        float val_9;
        var val_10;
        var val_8 = 0;
        label_10:
        val_7 = null;
        val_7 = null;
        if(val_8 >= (CUtils.invalidSceneIndeces + 12))
        {
            goto label_4;
        }
        
        val_8 = null;
        val_8 = null;
        if((CUtils.invalidSceneIndeces + 12) <= val_8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_7 = CUtils.invalidSceneIndeces + 8;
        val_7 = val_7 + 0;
        val_8 = val_8 + 1;
        if((sceneName.Contains(value:  (CUtils.invalidSceneIndeces + 8 + 0) + 16)) == false)
        {
            goto label_10;
        }
        
        string val_2 = 2144103168 + sceneName + 2144103024;
        UnityEngine.Debug.LogError(message:  2144103168);
        return;
        label_4:
        if(ScreenFaderV2.fadeInTime != 0)
        {
                if((ScreenFaderV2.fadeInTime + 12) == 0)
        {
                if((ScreenFaderV2.fadeInTime + 13) == 0)
        {
            goto label_19;
        }
        
        }
        
            val_9 = ScreenFaderV2.fadeInTime;
            if(ScreenFaderV2.fadeInTime == 0f)
        {
                val_9 = ScreenFaderV2.fadeInTime;
        }
        
            if((ScreenFaderV2.fadeInTime + 12) == 0)
        {
                "is fading" = "";
        }
        
            val_10 = "";
            if((ScreenFaderV2.fadeInTime + 13) == 0)
        {
                return;
        }
        
            if((System.String.IsNullOrEmpty(value:  1098586544)) != true)
        {
                string val_5 = 1098586544 + 2144103472;
            val_10 = val_10;
        }
        
            string val_6 = 1098586544 + 2144103552;
            return;
        }
        
        CUtils.LoadSceneImmediate(sceneName:  sceneName);
        return;
        label_19:
        ScreenFaderV2.fadeInTime.GotoScene(sceneName:  sceneName);
    }
    public static void LoadSceneImmediate(string sceneName)
    {
        App.StartSceneLoadingTimer();
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  sceneName, mode:  0);
    }
    public static void ReloadScene(bool useScreenFader = False)
    {
        string val_5;
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        string val_2 = val_1.m_Handle.name;
        typeof(System.Char[]).__il2cppRuntimeField_10 = 95;
        System.String[] val_3 = val_1.m_Handle.Split(separator:  478563824);
        ThemesHandler val_6 = App.ThemesHandler;
        string val_7 = 0.CurrentThemeName;
        string val_8 = val_5 + 2144339952 + null;
        if(useScreenFader != false)
        {
                CUtils.FadeAndLoadScene(sceneName:  val_5);
            return;
        }
        
        CUtils.LoadSceneImmediate(sceneName:  val_5);
    }
    public static void CheckConnection(UnityEngine.MonoBehaviour behaviour, System.Action<int> connectionListener)
    {
        System.Collections.IEnumerator val_1 = CUtils.ConnectUrl(url:  2144460224, connectionListener:  connectionListener);
        UnityEngine.Coroutine val_2 = behaviour.StartCoroutine(routine:  2144460224);
    }
    private static System.Collections.IEnumerator ConnectUrl(string url, System.Action<int> connectionListener)
    {
        typeof(CUtils.<ConnectUrl>d__60).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(CUtils.<ConnectUrl>d__60).__il2cppRuntimeField_10 = url;
        }
        else
        {
                mem[16] = url;
        }
        
        typeof(CUtils.<ConnectUrl>d__60).__il2cppRuntimeField_14 = connectionListener;
    }
    public static void CheckDisconnection(UnityEngine.MonoBehaviour behaviour, System.Action onDisconnected)
    {
        System.Collections.IEnumerator val_1 = CUtils.ConnectUrl(url:  2144460224, onDisconnected:  onDisconnected);
        UnityEngine.Coroutine val_2 = behaviour.StartCoroutine(routine:  2144460224);
    }
    private static System.Collections.IEnumerator ConnectUrl(string url, System.Action onDisconnected)
    {
        typeof(CUtils.<ConnectUrl>d__62).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(CUtils.<ConnectUrl>d__62).__il2cppRuntimeField_10 = url;
        }
        else
        {
                mem[16] = url;
        }
        
        typeof(CUtils.<ConnectUrl>d__62).__il2cppRuntimeField_14 = onDisconnected;
    }
    public static void SetAutoSigninGPS(int value)
    {
        CPlayerPrefs.SetInt(key:  2144965680, val:  value);
    }
    public static int GetAutoSigninGPS()
    {
        return CPlayerPrefs.GetInt(key:  2144965680);
    }
    public static System.Collections.IEnumerator LoadPicture(string url, System.Action<UnityEngine.Texture2D> callback, int width, int height, bool useCached = True)
    {
        typeof(CUtils.<LoadPicture>d__65).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(CUtils.<LoadPicture>d__65).__il2cppRuntimeField_10 = url;
            typeof(CUtils.<LoadPicture>d__65).__il2cppRuntimeField_18 = callback;
            typeof(CUtils.<LoadPicture>d__65).__il2cppRuntimeField_1C = width;
            typeof(CUtils.<LoadPicture>d__65).__il2cppRuntimeField_20 = height;
        }
        else
        {
                mem[16] = url;
            mem[24] = callback;
            mem[28] = width;
            mem[32] = height;
        }
        
        typeof(CUtils.<LoadPicture>d__65).__il2cppRuntimeField_14 = useCached;
    }
    private static string GetLocalPath(string url)
    {
        System.Uri val_1 = new System.Uri(uriString:  url);
        string val_2 = LocalPath;
        string val_3 = System.IO.Path.GetFileName(path:  103514112);
        string val_4 = UnityEngine.Application.persistentDataPath;
        return null + 1115175264 + 103514112;
    }
    public static System.Collections.IEnumerator CachePicture(string url, System.Action<bool> result)
    {
        typeof(CUtils.<CachePicture>d__67).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(CUtils.<CachePicture>d__67).__il2cppRuntimeField_10 = url;
        }
        else
        {
                mem[16] = url;
        }
        
        typeof(CUtils.<CachePicture>d__67).__il2cppRuntimeField_14 = result;
    }
    public static bool IsCacheExists(string url)
    {
        string val_1 = CUtils.GetLocalPath(url:  url);
        return System.IO.File.Exists(path:  url);
    }
    private static bool LoadFromLocal(System.Action<UnityEngine.Texture2D> callback, string localPath, int width, int height)
    {
        string val_6;
        var val_7;
        val_6 = localPath;
        val_7 = 0;
        if((System.IO.File.Exists(path:  val_6)) == false)
        {
                return (bool)val_7;
        }
        
        val_7 = 0;
        System.Byte[] val_2 = System.IO.File.ReadAllBytes(path:  val_6);
        UnityEngine.Texture2D val_3 = null;
        val_6 = val_3;
        val_3 = new UnityEngine.Texture2D(width:  width, height:  height, textureFormat:  3, mipChain:  false);
        bool val_4 = UnityEngine.ImageConversion.LoadImage(tex:  154206208, data:  val_6);
        if(154206208 == 0)
        {
                return (bool)val_7;
        }
        
        callback.Invoke(obj:  154206208);
        val_7 = 1;
        return (bool)val_7;
    }
    public static UnityEngine.Sprite CreateSprite(UnityEngine.Texture2D texture, int width, int height)
    {
        UnityEngine.Rect val_1 = new UnityEngine.Rect(x:  (float)height, y:  null, width:  null, height:  null);
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  (float)height, y:  null);
        UnityEngine.Sprite val_3 = UnityEngine.Sprite.Create(texture:  texture, rect:  new UnityEngine.Rect() {m_XMin = val_1.m_XMin, m_YMin = val_1.m_YMin, m_Width = val_1.m_Width, m_Height = val_1.m_XMin}, pivot:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, pixelsPerUnit:  (float)height);
    }
    public static System.Collections.Generic.List<System.Collections.Generic.List<T>> Split<T>(System.Collections.Generic.List<T> source, System.Predicate<T> split)
    {
        System.Predicate<T> val_2;
        var val_3;
        var val_4;
        var val_5;
        val_2 = split;
        val_3 = 0;
        val_4 = 0;
        goto label_1;
        label_12:
        val_5 = 0;
        if(val_2 == 0)
        {
                if(val_4 == 1)
        {
                val_2 = val_2;
        }
        
            var val_1 = (__RuntimeMethodHiddenParam + 24) - 1;
            val_5 = 1;
        }
        
        val_3 = 1;
        val_4 = val_5;
        label_1:
        if(val_3 < source)
        {
            goto label_12;
        }
    
    }
    public static System.Collections.Generic.List<System.Collections.Generic.List<T>> GetArrList<T>(System.Collections.Generic.List<T> source, System.Predicate<T> take)
    {
        var val_5;
        var val_6;
        label_12:
        if(MoveNext() == false)
        {
            goto label_3;
        }
        
        if(take == 0)
        {
            goto label_12;
        }
        
        var val_3 = (__RuntimeMethodHiddenParam + 24) - 1;
        if((__RuntimeMethodHiddenParam + 24) != 0)
        {
            goto label_12;
        }
        
        goto label_12;
        label_3:
        if((__RuntimeMethodHiddenParam + 24 + 48 + 178) == 0)
        {
            goto label_14;
        }
        
        var val_5 = 0;
        label_16:
        val_5 = 0;
        if((__RuntimeMethodHiddenParam + 24 + 48 + 88 + 0) == null)
        {
            goto label_15;
        }
        
        val_5 = val_5 + 1;
        val_5 = (uint)val_5 & 65535;
        if(val_5 < (__RuntimeMethodHiddenParam + 24 + 48 + 178))
        {
            goto label_16;
        }
        
        label_14:
        val_6;
        goto label_17;
        label_15:
        var val_4 = (__RuntimeMethodHiddenParam + 24 + 48 + 88) + 0;
        var val_6 = (__RuntimeMethodHiddenParam + 24 + 48 + 88 + 0) + 4;
        val_6 = (__RuntimeMethodHiddenParam + 24 + 48) + (val_6 << 3);
        val_6 = val_6 + 188;
        label_17:
        if(0 == 0)
        {
                return;
        }
    
    }
    public static System.Collections.Generic.List<T> ToList<T>(T obj)
    {
        if((__RuntimeMethodHiddenParam + 24) != 0)
        {
                return;
        }
    
    }
    public static int ChooseRandomWithProbs(float[] probs)
    {
        float val_2;
        var val_3;
        var val_4;
        val_2 = 0f;
        val_3 = 0;
        goto label_0;
        label_3:
        val_3 = 1;
        val_2 = val_2 + 1152921505140742816;
        label_0:
        if(val_3 < probs)
        {
            goto label_3;
        }
        
        val_4 = 0;
        float val_1 = UnityEngine.Random.value;
        if(0 >= 1)
        {
                val_2 = val_2 * 0;
            do
        {
            if(0 < 0)
        {
                return (int)val_4;
        }
        
            val_2 = val_2 - 1152921505140742816;
            val_4 = val_4 + 1;
        }
        while(val_4 < 0);
        
        }
        
        val_4 = 0 - 1;
        return (int)val_4;
    }
    public static bool IsObjectSeenByCamera(UnityEngine.Camera camera, UnityEngine.GameObject gameObj, float delta = 0)
    {
        float val_4;
        float val_5;
        UnityEngine.Transform val_1 = gameObj.transform;
        UnityEngine.Vector3 val_2 = position;
        UnityEngine.Vector3 val_6 = WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = camera, y = val_4, z = val_5});
        if(camera <= 0)
        {
                return false;
        }
        
        var val_10 = R2;
        if(camera <= 0)
        {
                return false;
        }
        
        val_10 = val_10 + 1f;
        if(camera > 0)
        {
                0 = 1;
        }
        
        if(camera < 0)
        {
                0 = 1;
        }
        
        if(camera < 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public static UnityEngine.Vector3 GetMiddlePoint(UnityEngine.Vector3 begin, UnityEngine.Vector3 end, float delta = 0)
    {
        float val_1;
        var val_5;
        float val_11;
        float val_12;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = 0f, y = begin.y, z = begin.z}, b:  new UnityEngine.Vector3() {x = end.x, y = end.y, z = end.z}, t:  delta);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 0f, y = end.y, z = end.z}, b:  new UnityEngine.Vector3() {x = val_1, y = begin.y, z = begin.z});
        var val_7 = val_5 ^ 2147483648;
        UnityEngine.Vector3 val_8 = new UnityEngine.Vector3(x:  val_4.x, y:  val_4.y, z:  val_4.z);
        UnityEngine.Vector3 val_9 = normalized;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 0f}, d:  val_9.x);
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = begin.x}, b:  new UnityEngine.Vector3() {y = val_12, z = val_11});
        return new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
    }
    public static UnityEngine.AnimationClip GetAnimationClip(UnityEngine.Animator anim, string name)
    {
        var val_7;
        UnityEngine.RuntimeAnimatorController val_1 = anim.runtimeAnimatorController;
        val_7 = 4;
        goto label_1;
        label_9:
        UnityEngine.AnimationClip[] val_2 = anim.animationClips;
        string val_3 = anim.name;
        if((System.String.op_Equality(a:  anim, b:  name)) == true)
        {
            goto label_6;
        }
        
        val_7 = 5;
        label_1:
        UnityEngine.AnimationClip[] val_6 = anim.animationClips;
        if((val_7 - 4) < anim)
        {
            goto label_9;
        }
        
        return;
        label_6:
        UnityEngine.AnimationClip[] val_7 = anim.animationClips;
        if(anim > R4)
        {
                return;
        }
    
    }
    public static void Swap<T>(ref T lhs, ref T rhs)
    {
        lhs = rhs;
        rhs = lhs;
    }
    public static void Pause()
    {
    
    }
    public CUtils()
    {
    
    }

}
