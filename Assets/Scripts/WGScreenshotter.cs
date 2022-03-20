using UnityEngine;
public class WGScreenshotter : MonoSingletonSelfGenerating<WGScreenshotter>
{
    // Fields
    public UnityEngine.Texture2D tex;
    public System.Action OnScreenshotTaken;
    
    // Properties
    public static string urlShare { get; }
    
    // Methods
    public void DoTakeScreenshot(bool share = True, bool postToFacebook = False)
    {
        if(share != false)
        {
                System.Collections.IEnumerator val_1 = this.TakeScreenshot(postToFacebook:  false);
        }
        else
        {
                System.Collections.IEnumerator val_2 = this.TakeQuickScreenShot();
        }
        
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  43671312);
    }
    public void ClearScreenshot()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.tex)) == false)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  this.tex);
    }
    private System.Collections.IEnumerator TakeQuickScreenShot()
    {
        object val_1 = new System.Object();
        typeof(WGScreenshotter.<TakeQuickScreenShot>d__4).__il2cppRuntimeField_8 = 0;
        typeof(WGScreenshotter.<TakeQuickScreenShot>d__4).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator TakeScreenshot(bool postToFacebook = False)
    {
        object val_1 = new System.Object();
        typeof(WGScreenshotter.<TakeScreenshot>d__5).__il2cppRuntimeField_8 = 0;
        typeof(WGScreenshotter.<TakeScreenshot>d__5).__il2cppRuntimeField_10 = this;
    }
    public void ShareDefault()
    {
        string val_1 = UnityEngine.Application.persistentDataPath;
        string val_2 = System.IO.Path.Combine(path1:  null, path2:  44111696);
        if((System.IO.File.Exists(path:  null)) != true)
        {
                UnityEngine.Texture val_4 = WGResources.Load<UnityEngine.Texture>(fileName:  44112832, extension:  1975550080, errorLog:  true);
            if(44112832 != 0)
        {
                System.Byte[] val_6 = UnityEngine.ImageConversion.EncodeToPNG(tex:  44112832);
            System.IO.File.WriteAllBytes(path:  null, bytes:  44112832);
        }
        
        }
        
        AppConfigs val_7 = App.Configuration;
        string val_8 = 0.Replace(oldValue:  1297836560, newValue:  System.String.alignConst);
        string val_9 = System.String.Format(format:  -12048896, arg0:  0);
        GameBehavior val_10 = App.getBehavior;
        string val_11 = System.String.Format(format:  null, arg0:  -12048896);
        TrackingComponent.CurrentIntent = 7;
        string val_12 = this.CurrentLevelLink();
        twelvegigs.plugins.SharePlugin.Share(text:  null, url:  44136944, subject:  null, emailBody:  1098586544, imgPath:  0);
    }
    public string CurrentLevelLink()
    {
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        float val_27;
        System.Comparison<System.String> val_29;
        var val_30;
        var val_21 = 28630911;
        val_21 = 6994876 + val_21;
        if(val_21 == 0)
        {
                mem2[0] = 1;
        }
        
        val_20 = null;
        val_20 = null;
        if(App.game == 1)
        {
            goto label_12;
        }
        
        if(val_21 == 0)
        {
                mem2[0] = 1;
        }
        
        val_21 = null;
        val_21 = null;
        if(App.game == 4)
        {
            goto label_12;
        }
        
        if(val_21 == 0)
        {
                mem2[0] = 1;
        }
        
        val_22 = null;
        val_22 = null;
        if(App.game != 18)
        {
            goto label_18;
        }
        
        label_12:
        GameLevel val_1 = PlayingLevel.GetLevelForPlayerLevel(levelIndex:  0, checkLevelSkip:  false);
        WordRegion val_2 = WordRegion.instance;
        if(0 != 0)
        {
                WordRegion val_4 = WordRegion.instance;
            System.Collections.Generic.List<System.String> val_5 = 0.GetCompletedWords();
        }
        
        System.Collections.Generic.List<T> val_6 = CUtils.BuildListFromString<System.String>(values:  6, split:  '|');
        val_23 = 6;
        val_24 = 18;
        val_25 = 0;
        goto label_32;
        label_36:
        if(6 <= val_25)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        string val_7 = 23.Replace(oldValue:  -2063697616, newValue:  System.String.alignConst);
        val_23.set_Item(index:  0, value:  23);
        val_25 = 1;
        label_32:
        if(val_25 < 65576)
        {
            goto label_36;
        }
        
        val_26 = null;
        val_27 = 0f;
        val_29 = WGScreenshotter.<>c.<>9__7_0;
        if(val_29 == 0)
        {
                val_29 = null;
            val_29 = new System.Comparison<WordForest.NewsArticle>(object:  WGScreenshotter.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(44224944));
            WGScreenshotter.<>c.<>9__7_0 = val_29;
        }
        
        val_23.Sort(comparison:  7933952);
        if(65576 >= 9)
        {
                System.Collections.Generic.List<T> val_9 = val_23.GetRange(index:  0, count:  8);
            val_24 = 18;
            val_23 = val_23;
        }
        
        val_30 = 4;
        goto label_44;
        label_50:
        if(0 == 0)
        {
            goto label_45;
        }
        
        if(val_23 <= val_29)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((0.Contains(item:  23)) == true)
        {
            goto label_47;
        }
        
        label_45:
        if(65576 <= val_29)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        string val_11 = this.ReplaceAll(input:  23, target:  '0');
        val_23.set_Item(index:  7933952, value:  196608);
        label_47:
        val_30 = 5;
        label_44:
        if((val_30 - 4) < val_24)
        {
            goto label_50;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_13 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        string val_14 = 1835037.Replace(oldValue:  -2100450224, newValue:  1098586544);
        set_Item(key:  44226992, value:  1835037);
        set_Item(key:  -1988561632, value:  52);
        T[] val_15 = val_23.ToArray();
        string val_16 = System.String.Join(separator:  2144339952, value:  6);
        set_Item(key:  -922441872, value:  2144339952);
        string val_17 = WGScreenshotter.urlShare;
        string val_18 = ToGetParams(parameters:  78753792);
        string val_19 = 78753792 + 78753792;
        return System.Uri.EscapeUriString(stringToEscape:  78753792);
        label_18:
        string val_20 = WGScreenshotter.urlShare;
        return System.Uri.EscapeUriString(stringToEscape:  78753792);
    }
    private string ReplaceAll(string input, char target)
    {
        null = new System.Text.StringBuilder(capacity:  input.m_stringLength);
        goto label_2;
        label_4:
        System.Text.StringBuilder val_2 = Append(value:  target);
        0 = 1;
        label_2:
        if(0 < input.m_stringLength)
        {
            goto label_4;
        }
        
        goto mem[null + 212];
    }
    private string ToGetParams(System.Collections.Generic.Dictionary<string, string> parameters)
    {
        var val_4;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String> val_6;
        if(parameters == 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        val_6 = WGScreenshotter.<>c.<>9__9_0;
        if(val_6 == 0)
        {
                val_6 = null;
            val_6 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>(object:  WGScreenshotter.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(44463360));
            WGScreenshotter.<>c.<>9__9_0 = val_6;
        }
        
        System.Collections.Generic.IEnumerable<TResult> val_2 = System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.Object, System.Object>, System.Object>(source:  parameters, selector:  7720960);
        TSource[] val_3 = System.Linq.Enumerable.ToArray<System.Object>(source:  parameters);
        return System.String.Join(separator:  1466177632, value:  parameters);
    }
    public static string get_urlShare()
    {
        var val_8;
        AppConfigs val_1 = App.Configuration;
        val_8 = 603979776;
        AppConfigs val_2 = App.Configuration;
        if(0.IsProduction() != true)
        {
                typeof(System.Char[]).__il2cppRuntimeField_10 = 46;
            System.String[] val_4 = val_8.Split(separator:  478563824);
            string val_5 = System.String.Format(format:  44581504, arg0:  mem[603979792]);
            mem[603979792] = "{0}-stage";
            string val_6 = System.String.Join(separator:  1297836480, value:  603979776);
            val_8 = ".";
        }
        
        GameBehavior val_7 = App.getBehavior;
        if(0 != 0)
        {
                return System.String.Format(format:  null, arg0:  1297836480);
        }
        
        return System.String.Format(format:  null, arg0:  1297836480);
    }
    public WGScreenshotter()
    {
    
    }

}
