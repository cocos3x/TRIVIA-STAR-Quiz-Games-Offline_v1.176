using UnityEngine;
public class ProfileAvatarManager : MonoSingleton<ProfileAvatarManager>
{
    // Fields
    private SLC.Social.AvatarConfig avatarConfig;
    private System.Collections.Generic.List<ProfileAvatarDisplayModifier> avatarDisplayModifiers;
    private bool hasSortedModifiers;
    private System.Collections.Generic.List<ProfileAvatarDisplayModifier> _orderedAvatarModifiers;
    
    // Properties
    public SLC.Social.AvatarConfig ProfileAvatarConfig { get; }
    private System.Collections.Generic.List<ProfileAvatarDisplayModifier> OrderedAvatarModifiers { get; }
    
    // Methods
    public SLC.Social.AvatarConfig get_ProfileAvatarConfig()
    {
        if(this.avatarConfig != 0)
        {
                return;
        }
        
        SLC.Social.AvatarConfig val_2 = SLC.Social.Leagues.LeaguesUIManager.memberAvatarHandler;
        this.avatarConfig = 0;
    }
    private System.Collections.Generic.List<ProfileAvatarDisplayModifier> get_OrderedAvatarModifiers()
    {
        var val_4;
        System.Func<ProfileAvatarDisplayModifier, System.Int32> val_6;
        if(this._orderedAvatarModifiers != 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        val_6 = ProfileAvatarManager.<>c.<>9__7_0;
        if(val_6 == 0)
        {
                val_6 = null;
            val_6 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  ProfileAvatarManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2577432512));
            ProfileAvatarManager.<>c.<>9__7_0 = val_6;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_2 = System.Linq.Enumerable.OrderBy<System.Object, System.Int32>(source:  this.avatarDisplayModifiers, keySelector:  7720960);
        System.Collections.Generic.List<TSource> val_3 = System.Linq.Enumerable.ToList<System.Object>(source:  this.avatarDisplayModifiers);
        this._orderedAvatarModifiers = this.avatarDisplayModifiers;
    }
    public void AppendAvatarDisplay(AvatarSlotUGUI avatarDisplay, SLC.Social.Profile profile)
    {
        var val_5;
        var val_6;
        val_5 = 4;
        goto label_1;
        label_15:
        System.Collections.Generic.List<ProfileAvatarDisplayModifier> val_1 = this.OrderedAvatarModifiers;
        if(this.avatarConfig <= R5)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(2621443 != 0)
        {
                System.Collections.Generic.List<ProfileAvatarDisplayModifier> val_2 = this.OrderedAvatarModifiers;
            if(this.avatarConfig <= R5)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(2621443 != 0)
        {
                System.Collections.Generic.List<ProfileAvatarDisplayModifier> val_3 = this.OrderedAvatarModifiers;
            val_6 = this;
            if(this.avatarConfig <= R5)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(0 != 0)
        {
                return;
        }
        
        }
        
        }
        
        val_5 = 5;
        label_1:
        System.Collections.Generic.List<ProfileAvatarDisplayModifier> val_4 = this.OrderedAvatarModifiers;
        val_6 = this;
        if((val_5 - 4) < this.avatarConfig)
        {
            goto label_15;
        }
    
    }
    public ProfileAvatarManager()
    {
    
    }

}
