using UnityEngine;
public class WADMysteryGiftPopup : WGMysteryGiftPopup
{
    // Fields
    private UnityEngine.GameObject titleGroup;
    private UnityEngine.GameObject radialRays;
    private CRotate raysRotation;
    private UnityEngine.RectTransform initialPosition;
    private UnityEngine.GameObject giftGroup;
    private UnityEngine.ParticleSystem starParticle;
    private UnityEngine.ParticleSystem glowParticle;
    private UnityEngine.GameObject coinGroup;
    private UnityEngine.ParticleSystem burstParticle;
    private UnityEngine.GameObject rewardAmountGroup;
    
    // Methods
    private void OnEnable()
    {
        GameEcon val_1 = App.getGameEcon;
        string val_2 = 792.ToString();
        this.InitialSetup();
        System.Collections.IEnumerator val_3 = this.GiftStageAnim();
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  -1150150272);
    }
    protected override void OnCollect()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
        var val_5 = 27930816;
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_D4 = 0;
        val_5 = 7696308 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        WGSubscriptionManager._subEntryPoint = 108;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -1150062272, clipIndex:  0);
        UnityEngine.GameObject val_4 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1150038160, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void InitialSetup()
    {
        this.titleGroup.SetActive(value:  false);
        this.radialRays.SetActive(value:  false);
        this.raysRotation.enabled = true;
        this.giftGroup.SetActive(value:  false);
        this.starParticle.Stop();
        this.glowParticle.Stop();
        UnityEngine.GameObject val_1 = this.glowParticle.gameObject;
        this.glowParticle.SetActive(value:  false);
        this.coinGroup.SetActive(value:  false);
        this.rewardAmountGroup.SetActive(value:  false);
        UnityEngine.Transform val_2 = this.radialRays.transform;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        this.radialRays.localScale = new UnityEngine.Vector3();
        UnityEngine.Transform val_4 = this.titleGroup.transform;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        this.titleGroup.localScale = new UnityEngine.Vector3();
        UnityEngine.Transform val_6 = this.titleGroup.transform;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
        this.titleGroup.localScale = new UnityEngine.Vector3();
        UnityEngine.Transform val_8 = this.coinGroup.transform;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        this.coinGroup.localScale = new UnityEngine.Vector3();
        UnityEngine.Transform val_10 = this.rewardAmountGroup.transform;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
        this.rewardAmountGroup.localScale = new UnityEngine.Vector3();
    }
    private System.Collections.IEnumerator GiftStageAnim()
    {
        object val_1 = new System.Object();
        typeof(WADMysteryGiftPopup.<GiftStageAnim>d__13).__il2cppRuntimeField_8 = 0;
        typeof(WADMysteryGiftPopup.<GiftStageAnim>d__13).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator CoinStageAnim()
    {
        object val_1 = new System.Object();
        typeof(WADMysteryGiftPopup.<CoinStageAnim>d__14).__il2cppRuntimeField_8 = 0;
        typeof(WADMysteryGiftPopup.<CoinStageAnim>d__14).__il2cppRuntimeField_10 = this;
    }
    public WADMysteryGiftPopup()
    {
    
    }

}
