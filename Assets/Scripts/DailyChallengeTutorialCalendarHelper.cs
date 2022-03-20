using UnityEngine;
public class DailyChallengeTutorialCalendarHelper : MonoSingleton<DailyChallengeTutorialCalendarHelper>
{
    // Fields
    private UnityEngine.GameObject zooTilesFocus;
    private UnityEngine.GameObject previousChallengeFocus;
    private DynamicToolTip TT;
    
    // Methods
    private void OnEnable()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1448559232) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.ShowZooTilesStep();
    }
    private void ShowZooTilesStep()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Color val_2 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
        System.Nullable<UnityEngine.Color> val_3 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.r});
        SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_3.HasValue}, fadeInDuration:  null, fadeOutDuration:  null);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_5 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_7 = PlaceGameObject<System.Object>(loc:  0);
        this.TT = public static UGUIDynamicPlacementManager MonoSingleton<UGUIDynamicPlacementManager>::get_Instance();
        UnityEngine.GameObject val_8 = gameObject;
        string val_9 = Localization.Localize(key:  -1448438016, defaultValue:  -1448437904, useSingularKey:  false);
        System.Action val_10 = new System.Action(object:  -1448407568, method:  new IntPtr(2846529584));
        this.TT.ShowToolTip(objToToolTip:  this.zooTilesFocus, text:  -1448438016, topToolTip:  true, displayDuration:  null, width:  null, height:  null, tooltipOffsetX:  null, tooltipOffsetY:  null, viewportSettings:  3212836864, showGotItButton:  false, gotItCallback:  1133903872, showPick:  false, maxFontSize:  0);
        UnityEngine.Transform val_11 = this.zooTilesFocus.transform;
        Add(item:  this.zooTilesFocus);
        UnityEngine.Transform val_12 = transform;
        Add(item:  -2009104640);
        if((public static GameMaskOverlay MonoSingleton<GameMaskOverlay>::get_Instance()) != 0)
        {
                BlockRaycasts = true;
        }
        else
        {
                BlockRaycasts = true;
        }
        
        Interactable = true;
        T[] val_13 = ToArray();
        ShowOverlay(contentToOverlay:  80883712);
    }
    private void OnZooTilesGotItClicked()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.TT)) != false)
        {
                this.TT.Dismiss();
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CloseOverlay(onClosed:  0);
        this.ShowPreviousChallengeStep();
    }
    private void ShowPreviousChallengeStep()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Color val_2 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
        System.Nullable<UnityEngine.Color> val_3 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.r});
        SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_3.HasValue}, fadeInDuration:  null, fadeOutDuration:  null);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_5 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_7 = PlaceGameObject<System.Object>(loc:  0);
        this.TT = public static UGUIDynamicPlacementManager MonoSingleton<UGUIDynamicPlacementManager>::get_Instance();
        UnityEngine.GameObject val_8 = gameObject;
        string val_9 = Localization.Localize(key:  -1448170704, defaultValue:  -1448170592, useSingularKey:  false);
        System.Action val_10 = new System.Action(object:  -1448137184, method:  new IntPtr(2846796896));
        this.TT.ShowToolTip(objToToolTip:  this.previousChallengeFocus, text:  -1448170704, topToolTip:  false, displayDuration:  null, width:  null, height:  null, tooltipOffsetX:  null, tooltipOffsetY:  null, viewportSettings:  3212836864, showGotItButton:  false, gotItCallback:  1133903872, showPick:  false, maxFontSize:  3256877056);
        UnityEngine.Transform val_11 = this.previousChallengeFocus.transform;
        Add(item:  this.previousChallengeFocus);
        UnityEngine.Transform val_12 = transform;
        Add(item:  -2009104640);
        if((public static GameMaskOverlay MonoSingleton<GameMaskOverlay>::get_Instance()) != 0)
        {
                BlockRaycasts = true;
        }
        else
        {
                BlockRaycasts = true;
        }
        
        Interactable = true;
        T[] val_13 = ToArray();
        ShowOverlay(contentToOverlay:  80883712);
        AllowButtonClicks(parentObject:  this.previousChallengeFocus, allowInteraction:  false);
    }
    private void OnPreviousChallengeGotItClicked()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.TT)) != false)
        {
                this.TT.Dismiss();
        }
        
        this.TT.AllowButtonClicks(parentObject:  this.previousChallengeFocus, allowInteraction:  true);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CloseOverlay(onClosed:  0);
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HandlePreviousChallengesPrompted();
    }
    private void AllowButtonClicks(UnityEngine.GameObject parentObject, bool allowInteraction)
    {
        T[] val_1 = parentObject.GetComponentsInChildren<System.Object>(includeInactive:  false);
        UnityEngine.GameObject val_2 = parentObject + 16;
        goto label_2;
        label_6:
        1152921504764567552.interactable = allowInteraction;
        0 = 1;
        label_2:
        if(0 < 1152921504764567552)
        {
            goto label_6;
        }
    
    }
    public DailyChallengeTutorialCalendarHelper()
    {
    
    }

}
