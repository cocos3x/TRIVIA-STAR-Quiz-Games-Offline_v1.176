using UnityEngine;
public class TRVExpertDisplay : MonoBehaviour
{
    // Fields
    private readonly UnityEngine.Color barBlue;
    private readonly UnityEngine.Color barPink;
    private UnityEngine.UI.Image backgroundImage;
    private UnityEngine.UI.Image expertImage;
    private UnityEngine.UI.Image lockImage;
    private UnityEngine.UI.Image fillBarMask;
    private UnityEngine.UI.Text expertName;
    private UnityEngine.UI.Text expertLevel;
    private UnityEngine.UI.Text expertCards;
    private System.Collections.Generic.List<TRVExpertProficiencyDisplay> proficiencyDisplays;
    private UnityEngine.UI.Image upgradeImage;
    private UnityEngine.Sprite commonBG;
    private UnityEngine.Sprite uncommonBG;
    private UnityEngine.Sprite rareBG;
    private UnityEngine.Sprite epicBG;
    private UnityEngine.GameObject levelUpBar;
    
    // Methods
    public void Init(TRVExpert me, TRVExpertProgressData progress, bool upgraded = False, bool showName = True)
    {
        UnityEngine.Color val_38;
        var val_39;
        UnityEngine.UI.Image val_40;
        UnityEngine.UI.Image val_43;
        UnityEngine.Sprite val_44;
        var val_45;
        float val_46;
        float val_47;
        var val_50;
        var val_51;
        var val_52;
        val_38 = 1152921504765685760;
        if((UnityEngine.Object.op_Implicit(exists:  this.expertName)) != false)
        {
                UnityEngine.GameObject val_2 = this.expertName.gameObject;
            this.expertName.SetActive(value:  showName);
            string val_3 = me.GetLocalizedName;
        }
        
        val_39 = 0;
        this.expertImage.sprite = me.mySprite;
        if((UnityEngine.Object.op_Implicit(exists:  this.lockImage)) != false)
        {
                UnityEngine.GameObject val_5 = this.lockImage.gameObject;
            if(progress != 0)
        {
                this.lockImage = progress.<unlocked>k__BackingField;
            me.mySprite = this.lockImage ^ 1;
        }
        
            if(progress == 0)
        {
                me.mySprite = 1;
        }
        
            if(me.mySprite != 0)
        {
                me.mySprite = 1;
        }
        
            val_39 = 0;
            this.lockImage.SetActive(value:  true);
        }
        
        if(progress != 0)
        {
                this.lockImage = progress.<unlocked>k__BackingField;
        }
        
        if(this.lockImage != true)
        {
                UnityEngine.Color32 val_6 = new UnityEngine.Color32(r:  100, g:  100, b:  100, a:  255);
            UnityEngine.Color val_7 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 244, g = 114, b = 61, a = 219});
            this.backgroundImage.color = new UnityEngine.Color() {a = ???};
            UnityEngine.Color32 val_8 = new UnityEngine.Color32(r:  100, g:  100, b:  100, a:  255);
            UnityEngine.Color val_9 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 224, g = 114, b = 61, a = 219});
            this.expertImage.color = new UnityEngine.Color() {a = ???};
            val_39 = 0;
            this.levelUpBar.SetActive(value:  false);
            val_38 = 1152921504765685760;
            if((UnityEngine.Object.op_Implicit(exists:  this.lockImage)) != false)
        {
                UnityEngine.Color32 val_11 = new UnityEngine.Color32(r:  100, g:  100, b:  100, a:  255);
            UnityEngine.Color val_12 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 244, g = 114, b = 61, a = 219});
            this.lockImage.color = new UnityEngine.Color() {a = ???};
            val_38 = 1152921504765685760;
        }
        
            val_40 = this.backgroundImage;
        }
        else
        {
                val_40 = this.backgroundImage;
        }
        
        UnityEngine.Transform val_13 = mem[this.backgroundImage].transform;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.one;
        mem[this.backgroundImage].localScale = new UnityEngine.Vector3();
        TRVExpertRarites val_39 = me.rarity;
        val_39 = val_39 - 1;
        if(val_39 <= 3)
        {
                var val_15 = 7994680 + (7994680 + ((me.rarity - 1)) << 2);
            if(val_39 == 3)
        {
                7994680 + ((me.rarity - 1)) << 2 = (7994680 + ((me.rarity - 1)) << 2) & ((7994680 + ((me.rarity - 1)) << 2) << (7994680 + ((me.rarity - 1)) << 2));
            7994680 + ((me.rarity - 1)) << 2 = (7994680 + ((me.rarity - 1)) << 2) & ((IP) << (7994680 + ((me.rarity - 1)) << 2 & (7994680 + ((me.rarity - 1)) << 2) << 7994680 + ((me.rarity - 1)) << 2));
            7994680 + ((me.rarity - 1)) << 2 = (7994680 + ((me.rarity - 1)) << 2) & (me >> 32);
            7994680 + ((me.rarity - 1)) << 2 = (7994680 + ((me.rarity - 1)) << 2) & ((7994680 + ((me.rarity - 1)) << 2) >> (7994680 + ((me.rarity - 1)) << 2));
        }
        
            val_43 = this.backgroundImage;
            val_44 = this.commonBG;
            sprite = ;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.upgradeImage)) != false)
        {
                UnityEngine.GameObject val_20 = this.upgradeImage.gameObject;
            this.upgradeImage.SetActive(value:  false);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_21 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ExpertLevelReq val_22 = public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_C.getReqFromExpert(exp:  me, prog:  progress);
        if(progress == 0)
        {
            goto label_48;
        }
        
        UnityEngine.GameObject val_23 = this.fillBarMask.gameObject;
        this.fillBarMask.SetActive(value:  true);
        if((UnityEngine.Object.op_Implicit(exists:  this.expertCards)) == false)
        {
            goto label_52;
        }
        
        string val_25 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        val_45 = "{0}/{1}";
        goto label_54;
        label_48:
        this.fillBarMask.fillAmount = val_18.x;
        if((UnityEngine.Object.op_Implicit(exists:  this.expertCards)) != false)
        {
                string val_27 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
            val_38 = 1152921504765685760;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.expertLevel)) != false)
        {
                string val_29 = me.totalDefault.ToString();
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.expertCards)) == false)
        {
            goto label_87;
        }
        
        string val_31 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        if(this.expertCards != 0)
        {
            goto label_87;
        }
        
        goto label_87;
        label_54:
        label_52:
        if((UnityEngine.Object.op_Implicit(exists:  this.expertLevel)) != false)
        {
                string val_34 = progress.level.ToString();
        }
        
        if((progress.<cardsOwned>k__BackingField) != 0)
        {
                float val_40 = (float)public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_C + 12;
            val_40 = ((float)progress.<cardsOwned>k__BackingField) / val_40;
            this.fillBarMask.fillAmount = val_40;
            val_38 = this.barBlue;
            if(this.fillBarMask == 0)
        {
                val_46 = ???;
            val_47 = R3;
        }
        
            this.fillBarMask.color = new UnityEngine.Color() {r = val_38, g = val_46, b = val_47, a = ???};
        }
        else
        {
                this.fillBarMask.fillAmount = val_18.x;
        }
        
        label_87:
        val_50 = 4;
        goto label_89;
        label_112:
        if(progress == 0)
        {
            goto label_90;
        }
        
        if(this.fillBarMask <= )
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_51 = 2621443;
        if( >= (progress.<proficiencies>k__BackingField))
        {
            goto label_104;
        }
        
        val_38 = progress.<proficiencies>k__BackingField;
        if(0 <= )
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_52 = 2621443;
        if(upgraded == false)
        {
            goto label_107;
        }
        
        val_51.UpdateProf(data:  2621443);
        goto label_108;
        label_90:
        if(this.fillBarMask <= )
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_51 = 2621443;
        if( >= me.myProfs)
        {
            goto label_104;
        }
        
        val_38 = me.myProfs;
        if(0 <= )
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_52 = 2621443;
        label_107:
        val_51.DisplayProf(data:  2621443);
        goto label_108;
        label_104:
        UnityEngine.GameObject val_37 = val_51.gameObject;
        val_51.SetActive(value:  false);
        label_108:
        val_50 = 5;
        label_89:
        if((val_50 - 4) < val_51)
        {
            goto label_112;
        }
    
    }
    public void AnimateCardProgress(TRVExpert me, TRVExpertProgressData progress)
    {
        TRVExpert val_18;
        UnityEngine.UI.Text val_19;
        float val_20;
        var val_21;
        int val_22;
        float val_23;
        float val_24;
        val_18 = me;
        if(progress == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_1 = this.fillBarMask.gameObject;
        this.fillBarMask.SetActive(value:  true);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ExpertLevelReq val_3 = public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_C.getReqFromExpert(exp:  val_18, prog:  progress);
        val_20 = 1152921504765685760;
        if((UnityEngine.Object.op_Implicit(exists:  this.expertCards)) != false)
        {
                val_19 = this.expertCards;
            string val_5 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
            val_21 = "{0}/{1}";
        }
        
        val_18 = this.expertLevel;
        if((UnityEngine.Object.op_Implicit(exists:  val_18)) != false)
        {
                val_19 = this.expertLevel;
            string val_8 = progress.level.ToString();
            val_18;
        }
        
        val_19 = mem[public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_C + 12];
        val_19 = public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_C + 12;
        val_22 = progress.<cardsOwned>k__BackingField;
        if(val_22 == val_19)
        {
                PluginExtension.SetColorAlpha(graphic:  this.upgradeImage, a:  null);
            val_19 = mem[public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_C + 12];
            val_19 = public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_C + 12;
            val_22 = progress.<cardsOwned>k__BackingField;
        }
        
        if(val_22 > val_19)
        {
                return;
        }
        
        float val_18 = (float)val_19;
        val_18 = ((float)val_22 - 1) / val_18;
        this.fillBarMask.fillAmount = val_18;
        val_18 = this.fillBarMask;
        if(val_18 == 0)
        {
                val_23 = mem[this.barBlue + (0)];
            val_24 = mem[this.barBlue + (4)];
        }
        
        val_18.color = new UnityEngine.Color() {r = val_23, g = val_24, b = mem[this.barBlue + (8)], a = val_22};
        float val_19 = (float)public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_C + 12;
        val_19 = ((float)progress.<cardsOwned>k__BackingField) / val_19;
        DG.Tweening.Tweener val_10 = DG.Tweening.ShortcutExtensions46.DOFillAmount(target:  this.fillBarMask, endValue:  val_19, duration:  null);
        DG.Tweening.Sequence val_11 = DG.Tweening.DOTween.Sequence();
        object val_12 = DG.Tweening.TweenExtensions.Pause<System.Object>(t:  0);
        DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_19);
        DG.Tweening.Tweener val_14 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.upgradeImage, endValue:  val_19, duration:  null);
        DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.upgradeImage);
        val_18 = null;
        val_18 = new DG.Tweening.TweenCallback(object:  -616350832, method:  new IntPtr(3678591440));
        mem[68] = val_18;
        object val_17 = DG.Tweening.TweenExtensions.Play<System.Object>(t:  0);
    }
    public TRVExpertDisplay()
    {
        UnityEngine.Color val_1 = new UnityEngine.Color(r:  null, g:  null, b:  null);
        UnityEngine.Color val_2 = new UnityEngine.Color(r:  null, g:  null, b:  null);
    }
    private void <AnimateCardProgress>b__17_0()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.RectTransform val_2 = this.upgradeImage.rectTransform;
        UnityEngine.ParticleSystem val_3 = PlaySFX(reqType:  3, parent:  this.upgradeImage, playImmediate:  true);
    }

}
