using UnityEngine;
public class RESHackBehavior : HackBehavior
{
    // Methods
    public override SROptions GetGameSpecificSROptions()
    {
        return SuperLuckySROptionsParent<System.Object>.Instance;
    }
    public override void Hack_RestartLevel()
    {
        CUtils.ReloadScene(useScreenFader:  false);
    }
    public override void Hack_CompleteLevelBehavior()
    {
        var val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Hack_SetRestaurantComplete();
        SRDebugger.Services.IDebugService val_2 = SRDebug.Instance;
        if(mem[1179403825] == 0)
        {
            goto label_5;
        }
        
        var val_4 = 0;
        label_7:
        if((mem[1179403735] + 0) == null)
        {
            goto label_6;
        }
        
        val_4 = val_4 + 1;
        if(((uint)val_4 & 65535) < mem[1179403825])
        {
            goto label_7;
        }
        
        label_5:
        val_4 = 0;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        label_6:
        var val_3 = mem[1179403735] + 0;
        var val_5 = (mem[1179403735] + 0) + 4;
        val_5 = 1179403647 + (val_5 << 3);
        val_4 = val_5 + 268;
        goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
    }
    public override void Hack_CompleteChapterBehavior()
    {
        goto typeof(RESHackBehavior).__il2cppRuntimeField_EC;
    }
    public override void Hack_OnLevelChanged()
    {
        RestaurantRivals.RESPlayer val_1 = RestaurantRivals.RESPlayer.Instance;
        Player val_2 = App.Player;
        RestaurantRivals.Map val_3 = RestaurantRivals.RESGameEconHelper.CreateMap(level:  0, randomProgress:  false);
        mem[348] = 0;
    }
    public override void AppendGameLevelInfo(ref System.Text.StringBuilder builder)
    {
        var val_14;
        var val_15;
        MainController val_1 = MainController.instance;
        if(0 == 0)
        {
                val_14 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_14 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_14 == 1)
        {
                val_14 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_14 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
            System.Text.StringBuilder val_3 = builder.AppendFormat(format:  -731768576, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            return;
        }
        
        if(CategoryPacksManager.IsPlaying != false)
        {
                val_15 = 0;
            GameLevel val_6 = PlayingLevel.GetCategoryLevel(categoryPackId:  0);
        }
        else
        {
                val_15 = 0;
            GameLevel val_7 = PlayingLevel.GetLevelForPlayerLevel(levelIndex:  0, checkLevelSkip:  false);
        }
        
        System.Text.StringBuilder val_8 = builder.AppendFormat(format:  -731768448, arg0:  52);
        System.Text.StringBuilder val_9 = builder.AppendFormat(format:  -731768320, arg0:  1835037);
        System.Text.StringBuilder val_10 = builder.AppendFormat(format:  -731768176, arg0:  6);
        System.Text.StringBuilder val_11 = builder.AppendFormat(format:  -731768032, arg0:  52);
        System.Text.StringBuilder val_12 = builder.AppendFormat(format:  -731767888, arg0:  1);
        System.Text.StringBuilder val_13 = builder.AppendFormat(format:  -731767712, arg0:  15282176);
    }
    public override void ResetPlayer()
    {
        var val_24;
        var val_25;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_18.ResetForest();
        RestaurantRivals.RESPlayer val_2 = RestaurantRivals.RESPlayer.Instance;
        if(0 != 0)
        {
                val_24 = 0;
            mem[296] = 0;
            RestaurantRivals.Map val_3 = RestaurantRivals.RESGameEconHelper.CreateStartingMap();
            val_25 = 0;
        }
        else
        {
                val_24 = 296;
            mem[296] = 0;
            RestaurantRivals.Map val_4 = RestaurantRivals.RESGameEconHelper.CreateStartingMap();
            val_25 = 0;
        }
        
        mem[348] = val_25;
        GameBehavior val_5 = App.getBehavior;
        0.stars = 0;
        string val_7 = UnityEngine.Random.Range(min:  1000, max:  10000).ToString();
        string val_8 = System.String.Format(format:  -731651520, arg0:  -731639464);
        mem[340] = "Guest_{0}";
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        mem[336] = UnityEngine.Random.Range(min:  0, max:  public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_C.AvatarSpritesCount);
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Nullable<System.Int32> val_13 = new System.Nullable<System.Int32>(value:  0);
        System.Nullable<System.Int32> val_14 = new System.Nullable<System.Int32>(value:  4);
        System.Nullable<System.Int32> val_15 = new System.Nullable<System.Int32>(value:  0);
        RestaurantRivals.RESPlayer val_16 = RestaurantRivals.RESPlayer.Instance;
        RestaurantRivals.RESPlayer val_17 = RestaurantRivals.RESPlayer.Instance;
        System.Nullable<System.Int32> val_18 = new System.Nullable<System.Int32>(value:  mem[336]);
        public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_18.SetMapProfile(level:  new System.Nullable<System.Int32>() {HasValue = val_13.HasValue}, map:  0, stars:  new System.Nullable<System.Int32>() {HasValue = false}, shields:  new System.Nullable<System.Int32>() {HasValue = val_14.HasValue}, name:  val_14.HasValue, avatarid:  new System.Nullable<System.Int32>() {HasValue = false}, responseCallback:  0);
        twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        mem2[0] = 1;
        NotificationCenter val_20 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -2092882624);
        SLC.Social.Leagues.LeaguesDataController val_21 = SLC.Social.Leagues.LeaguesManager.DAO;
        if(0 == 0)
        {
                return;
        }
        
        SLC.Social.Leagues.LeaguesDataController val_23 = SLC.Social.Leagues.LeaguesManager.DAO;
        0.UpdateLocalProfile();
    }
    public RESHackBehavior()
    {
    
    }

}
