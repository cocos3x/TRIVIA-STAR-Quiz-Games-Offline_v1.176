using UnityEngine;
public class WGChallengeWindow : MonoBehaviour
{
    // Fields
    private WGChallengeProgressDisplay _progressDisplayPrefab;
    private WGChallengeDefinition myDef;
    private UnityEngine.Transform progressDisplayParent;
    private UnityEngine.GameObject checkLaterMessage;
    private GridCoinCollectAnimationInstantiator gridCoinAnimator;
    private UnityEngine.UI.Text coinRewardText;
    private System.Collections.Generic.Dictionary<ChallengeType, WGChallengeProgressDisplay> progressDisplays;
    private bool waitForAnimation;
    
    // Properties
    private WGChallengeProgressDisplay ProgressDisplayPrefab { get; }
    
    // Methods
    private WGChallengeProgressDisplay get_ProgressDisplayPrefab()
    {
        if(this._progressDisplayPrefab != 0)
        {
                return;
        }
        
        WordIQLineAnim val_2 = PrefabLoader.LoadPrefab<WordIQLineAnim>(featureName:  -1593567904);
        this._progressDisplayPrefab = "AchievementGoals";
    }
    private void OnEnable()
    {
        System.Action val_3;
        System.Action val_1 = new System.Action(object:  -1593410288, method:  new IntPtr(2701531984));
        System.Delegate val_2 = System.Delegate.Combine(a:  this.gridCoinAnimator.OnCompleteCallback, b:  7454720);
        val_3 = this.gridCoinAnimator.OnCompleteCallback;
        if(val_3 != 0)
        {
                if(null == null)
        {
            goto label_4;
        }
        
        }
        
        val_3 = 0;
        label_4:
        this.gridCoinAnimator.OnCompleteCallback = val_3;
        this.SetupUI();
    }
    public void SetupUI()
    {
        WGChallengeWindow val_29;
        var val_30;
        var val_32;
        float val_33;
        val_29 = this;
        val_30 = 1152921511095702560;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((-2101079008) == 0)
        {
                UnityEngine.Debug.LogError(message:  -1593314096);
            UnityEngine.GameObject val_3 = this.gameObject;
            this.SetActive(value:  false);
            return;
        }
        
        WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        WordPets.WPTDataParser val_5 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        string val_6 = public static WGChallengeController MonoSingletonSelfGenerating<WGChallengeController>::get_Instance().__il2cppRuntimeField_20.ToString();
        this.checkLaterMessage.SetActive(value:  false);
        val_32 = 4;
        val_33 = 1152921504912384000;
        val_30 = 1152921504617496576;
        var val_25 =  - 4;
    }
    private void OnClickCollect(ChallengeType myType)
    {
        int val_13;
        GridCoinCollectAnimationInstantiator val_13;
        float val_14;
        var val_15;
        bool val_16;
        val_13 = 35626981;
        if(this.waitForAnimation == true)
        {
                return;
        }
        
        val_14 = 1152921504901201920;
        val_15 = 1152921511095702560;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        val_13 = public static WGChallengeController MonoSingletonSelfGenerating<WGChallengeController>::get_Instance();
        if((TryCompleteChallenge(chalToComplete:  myType)) != false)
        {
                WGChallengeProgressDisplay val_3 = this.progressDisplays.Item[myType];
            UnityEngine.GameObject val_4 = this.progressDisplays.gameObject;
            UnityEngine.Transform val_5 = this.progressDisplays.transform;
            UnityEngine.Vector3 val_6 = position;
            this.gridCoinAnimator.SetCoinStartPosition(pos:  new UnityEngine.Vector3());
            mem2[0] = 0;
            Player val_7 = App.Player;
            var val_8 = 0 + 60;
            WordPets.WPTDataParser val_9 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            decimal val_10 = System.Decimal.op_Implicit(value:  -1593090192);
            decimal val_11 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1593090208, hi = mem[(0 + 60) + (0)], lo = mem[(0 + 60) + (4)], mid = mem[(0 + 60) + (8)]}, d2:  new System.Decimal() {flags = mem[(0 + 60) + (12)]});
            Player val_12 = App.Player;
            val_13 = this.gridCoinAnimator;
            val_14 = 3.587324E-43f;
            val_15 = 256;
            val_13.Play(fromValue:  new System.Decimal() {mid = val_13}, toValue:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, textTickTime:  val_6.x, delayBeforeComplete:  val_6.y);
            val_16 = 1;
        }
        else
        {
                val_16 = false;
        }
        
        this.waitForAnimation = val_16;
    }
    private void OnCollectComplete()
    {
        this.SetupUI();
        this.waitForAnimation = false;
    }
    public void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    public WGChallengeWindow()
    {
        System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_1 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
        this.progressDisplays = null;
    }

}
