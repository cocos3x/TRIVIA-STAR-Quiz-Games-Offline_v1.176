using UnityEngine;
public class GameOfTheDayWindowUGUI : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text gameNameLabel;
    private UnityEngine.UI.Text rewardLabel;
    private UnityEngine.UI.RawImage assetIconTexture;
    private UnityEngine.UI.Text rewardDescriptionLabel;
    private string assetName;
    private string gamePackage;
    private bool imageLoaded;
    private int ghostNumber;
    
    // Methods
    private void OnEnable()
    {
        this.Refresh();
    }
    private void Refresh()
    {
        var val_7;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        JustShown();
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.assetName = null;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.gamePackage = null;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Add(key:  -269066784, value:  public static GameOfTheDay MonoSingleton<GameOfTheDay>::get_Instance().__il2cppRuntimeField_14);
        var val_7 = 29174270;
        val_7 = 6451268 + val_7;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_7 = null;
        val_7 = null;
        App.trackerManager.track(eventName:  -269066688, data:  78753792);
        this.LoadAsset();
    }
    public void OnInstallButtonClick()
    {
        var val_6;
        var val_7;
        UnityEngine.Debug.Log(message:  -268950496);
        if(this.gamePackage == null)
        {
                return;
        }
        
        var val_6 = 29173299;
        val_6 = 6452488 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        string val_1 = -268946240(-268946240) + 295313408;
        UnityEngine.Debug.Log(message:  -268946240);
        string val_2 = -268946240(-268946240) + 295313408;
        twelvegigs.plugins.InstalledAppsPlugin.OpenApp(package:  this.gamePackage, referrerMarket:  -268946240);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Add(key:  -269066784, value:  public static GameOfTheDay MonoSingleton<GameOfTheDay>::get_Instance().__il2cppRuntimeField_14);
        val_7 = null;
        val_7 = null;
        App.trackerManager.track(eventName:  -268942016, data:  78753792);
        UnityEngine.GameObject val_5 = this.gameObject;
        SLCWindow.CloseWindow(window:  -268917920, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void LoadAsset()
    {
        var val_13;
        var val_14;
        var val_15;
        System.Action val_17;
        bool val_1 = System.String.IsNullOrEmpty(value:  this.assetName);
        if(val_1 == false)
        {
                val_1 = this.imageLoaded;
            goto label_1;
        }
        
        return;
        label_1:
        string val_2 = -268817632(-268817632) + this.assetName;
        string val_3 = -268809296(-268809296) + this.assetName;
        if((twelvegigs.net.ImageRequest.LoadFromPreCache(filename:  -268809296, textureToSet: out  UnityEngine.Texture2D val_4 = -268795176)) == false)
        {
            goto label_4;
        }
        
        string val_6 = -575106048(-575106048) + -268809296(-268809296);
        val_13 = 0;
        UnityEngine.Debug.Log(message:  -575106048);
        val_14 = 0;
        goto label_7;
        label_4:
        if((twelvegigs.net.ImageRequest.ImageInLocal(imgPath:  -268809296)) == false)
        {
            goto label_10;
        }
        
        string val_8 = -575105936(-575105936) + -268809296(-268809296);
        UnityEngine.Debug.Log(message:  -575105936);
        val_13 = "networkgameicon";
        UnityEngine.Texture2D val_9 = twelvegigs.net.ImageRequest.LoadLocally(remoteURL:  -268817632, fileName:  -268809296);
        val_14 = "https://cdn.12gigs.com/network_games/";
        label_7:
        this.OnImageLoaded(filename:  -268809296, t:  -268817632);
        return;
        label_10:
        System.Action<System.Threading.Tasks.Task, System.Object> val_10 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -268783136, method:  new IntPtr(4026158112));
        val_15 = null;
        val_15 = null;
        val_17 = GameOfTheDayWindowUGUI.<>c.<>9__11_0;
        if(val_17 == 0)
        {
                val_17 = null;
            val_17 = new System.Action(object:  GameOfTheDayWindowUGUI.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4026159136));
            GameOfTheDayWindowUGUI.<>c.<>9__11_0 = val_17;
        }
        
        twelvegigs.net.ImageRequest val_12 = new twelvegigs.net.ImageRequest(url:  -268817632, filename:  -268809296, imgComplete:  7507968, imgError:  val_17, showErrors:  false, destroy:  false, cached:  true, save:  true);
    }
    private void OnImageLoaded(string filename, UnityEngine.Texture2D t)
    {
        UnityEngine.UI.RawImage val_5;
        this.imageLoaded = true;
        val_5 = 1152921504765685760;
        if(t == 0)
        {
                return;
        }
        
        val_5 = this.assetIconTexture;
        if(val_5 != 0)
        {
                this.assetIconTexture.texture = t;
            this.assetIconTexture.enabled = true;
            return;
        }
        
        this.ghostNumber = this.ghostNumber + 1;
        string val_4 = -268662368(-268662368) + 13152256 + -268662192(-268662192);
        UnityEngine.Debug.LogError(message:  -268662368);
    }
    public GameOfTheDayWindowUGUI()
    {
    
    }

}
