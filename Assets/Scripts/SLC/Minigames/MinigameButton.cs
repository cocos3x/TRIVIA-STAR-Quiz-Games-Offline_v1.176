using UnityEngine;

namespace SLC.Minigames
{
    public class MinigameButton : MonoBehaviour
    {
        // Fields
        private TMPro.TMP_Text minigameName;
        private UGUINetworkedButton minigameButton;
        private UnityEngine.UI.Image minigameIcon;
        private UnityEngine.UI.Image DLCButtonImage;
        private UnityEngine.UI.Image spinningAnimation;
        private UnityEngine.UI.Slider rankSlider;
        private UnityEngine.UI.Image rankSliderFill;
        private TMPro.TMP_Text rankText;
        private SLC.Minigames.MinigamesPopup myParentPopup;
        private int index;
        private string myGameName;
        private bool isLoaded;
        private bool isLoading;
        
        // Properties
        private bool IsLoading { get; set; }
        
        // Methods
        private bool get_IsLoading()
        {
            var val_4;
            bool val_2 = (UnityEngine.Object.op_Inequality(x:  this.myParentPopup, y:  0)) ^ 1;
            if(this.isLoading == true)
            {
                    this.isLoading = 1;
            }
            
            val_4 = 1 & val_2;
            if(val_2 == true)
            {
                    return true;
            }
            
            if(this.isLoading == false)
            {
                    return true;
            }
            
            if(this.myParentPopup.someMinigameLoading == true)
            {
                    val_4 = 1;
            }
            
            return true;
        }
        private void set_IsLoading(bool value)
        {
            this.isLoading = value;
            if((UnityEngine.Object.op_Implicit(exists:  this.myParentPopup)) == false)
            {
                    return;
            }
            
            if(this.isLoading == true)
            {
                    this.isLoading = 1;
            }
            
            this.myParentPopup.ToggleLoading(isLoading:  true);
        }
        public void ToggleInteractable(bool interactable)
        {
            this.minigameButton.interactable = interactable;
        }
        public void Setup(string gameName, int minigameIndex, int reqLevel, UnityEngine.Sprite gameIcon, string displayGameName, SLC.Minigames.MinigamesPopup parentPopup)
        {
            var val_9;
            var val_10;
            this.myParentPopup = parentPopup;
            this.minigameIcon.sprite = gameIcon;
            System.Action<System.Boolean> val_1 = new System.Action<System.Boolean>(object:  894675312, method:  new IntPtr(894628784));
            this.minigameButton.OnConnectionClick = null;
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  894675312, method:  new IntPtr(894633904));
            this.minigameButton.AddListener(call:  162246656);
            this.index = minigameIndex;
            this.myGameName = gameName;
            var val_9 = 23295210;
            val_9 = 12334792 + val_9;
            if(val_9 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_9 = null;
            val_9 = null;
            AppConfigs val_3 = App.Configuration;
            MiniGame val_4 = 83886592.GetMiniGameById(id:  this.myGameName);
            AppConfigs val_5 = App.Configuration;
            if((App.dlcManager.IsAssetAvailable(bundleName:  mem[83886620], version:  23)) != false)
            {
                    this.isLoaded = true;
                val_10 = 0;
            }
            else
            {
                    this.isLoaded = false;
                val_10 = 1;
            }
            
            this.DLCButtonImage.enabled = true;
            UnityEngine.GameObject val_7 = this.spinningAnimation.gameObject;
            this.spinningAnimation.SetActive(value:  false);
            SLC.Minigames.MinigamePlayerData val_8 = SLC.Minigames.MinigameManager.LoadMiniGameData(minigameId:  gameName);
            this.UpdateSliderToRank(mgPlayerData:  gameName);
        }
        private void OnMyButtonClick()
        {
            if(this.IsLoading == true)
            {
                    return;
            }
            
            if(this.isLoaded == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HandlePlayMinigame(minigame:  this.index);
            this.IsLoading = true;
            this.minigameButton.OnConnectionClick = 0;
        }
        private void OnNetworkedButtonResult(bool result)
        {
            System.Action<twelvegigs.storage.JsonDictionary> val_16;
            var val_17;
            var val_18;
            System.Func<System.Boolean> val_20;
            System.String[] val_21;
            var val_22;
            var val_23;
            val_16 = 35637911;
            if(result == false)
            {
                    true = this.isLoaded;
            }
            
            if(true == false)
            {
                goto label_1;
            }
            
            if(this.IsLoading == true)
            {
                    return;
            }
            
            if(this.isLoaded == false)
            {
                goto label_3;
            }
            
            val_16 = 1152921504901095424;
            val_17 = 1152921511277694048;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HandlePlayMinigame(minigame:  this.index);
            this.IsLoading = true;
            return;
            label_1:
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            CloseCurrentWindow();
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_6 = ShowUGUIMonolith<System.Object>(showNext:  false);
            string val_7 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
            string val_8 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
            typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
            string val_9 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
            typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
            val_18 = null;
            val_18 = null;
            val_20 = MinigameButton.<>c.<>9__19_0;
            if(val_20 == 0)
            {
                    val_20 = null;
                val_20 = new System.Func<System.Boolean>(object:  MinigameButton.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(894932656));
                MinigameButton.<>c.<>9__19_0 = val_20;
            }
            
            typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_20;
            val_21 = null;
            val_22 = null;
            val_22 = null;
            SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  val_21, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
            return;
            label_3:
            UnityEngine.GameObject val_11 = this.spinningAnimation.gameObject;
            this.spinningAnimation.SetActive(value:  true);
            this.DLCButtonImage.enabled = false;
            this.IsLoading = true;
            var val_16 = 23292434;
            val_16 = 12337568 + val_16;
            if(val_16 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_23 = null;
            val_23 = null;
            AppConfigs val_12 = App.Configuration;
            MiniGame val_13 = 83886592.GetMiniGameById(id:  this.myGameName);
            val_21 = mem[83886620];
            AppConfigs val_14 = App.Configuration;
            val_17 = 23;
            val_16 = null;
            val_16 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  894970992, method:  new IntPtr(894945968));
            App.dlcManager.DownloadResource(bundlePath:  -2040495296, bundleName:  val_21, bundleVersion:  23, onDownloadedCallback:  val_16);
        }
        private void PlayGame(UnityEngine.AssetBundle loaded)
        {
            if(895099376 == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static Bootstrapper MonoSingleton<Bootstrapper>::get_Instance().__il2cppRuntimeField_20) != 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_3 = R4 + 28.gameObject;
            R4 + 28.SetActive(value:  false);
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            R7.HandlePlayMinigame(minigame:  R4 + 48);
        }
        private void UpdateSliderToRank(SLC.Minigames.MinigamePlayerData mgPlayerData)
        {
            string val_1 = SLC.Minigames.MinigameLevelRank.RankIndexToName(index:  mgPlayerData.rankIndex);
            string val_2 = mgPlayerData.rankIndex.ToUpper();
            int val_3 = mgPlayerData.GetCheckpointsCompletedInRank();
            string val_4 = SLC.Minigames.MinigamesUtils.RomanNumeralize(num:  val_3);
            string val_5 = System.String.Format(format:  1592589744, arg0:  mgPlayerData.rankIndex, arg1:  val_3);
            float val_6 = mgPlayerData.LevelsForNextRank();
            UnityEngine.Color32 val_7 = SLC.Minigames.MinigameLevelRank.RankColors.Item[mgPlayerData.rankIndex];
            UnityEngine.Color val_8 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 96, g = 248, b = 91, a = 53});
            this.rankSliderFill.color = new UnityEngine.Color() {a = ???};
        }
        public MinigameButton()
        {
            this.index = 0;
            this.myGameName = "";
        }
    
    }

}
