using UnityEngine;
private sealed class WFOMysteryChestDisplay.<DoOpenChestAnimationSequence>d__86 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordForest.WFOMysteryChestDisplay <>4__this;
    private WordForest.WFOMysteryChestDisplay.<>c__DisplayClass86_0 <>8__1;
    private WordForest.WFOMysteryChestDisplay.<>c__DisplayClass86_1 <>8__2;
    private bool <canRaid>5__2;
    private bool <canAttack>5__3;
    private int <i>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WFOMysteryChestDisplay.<DoOpenChestAnimationSequence>d__86(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_68;
        UnityEngine.UI.Text val_69;
        int val_72;
        WFOMysteryChestDisplay.<>c__DisplayClass86_1 val_73;
        DG.Tweening.TweenCallback val_74;
        DG.Tweening.TweenCallback val_75;
        WFOMysteryChestDisplay.<>c__DisplayClass86_1 val_76;
        var val_77;
        WFOMysteryChestDisplay.<>c__DisplayClass86_1 val_78;
        var val_79;
        DG.Tweening.TweenCallback val_80;
        WFOMysteryChestDisplay.<>c__DisplayClass86_1 val_81;
        DG.Tweening.TweenCallback val_82;
        WFOMysteryChestDisplay.<>c__DisplayClass86_1 val_83;
        System.Func<System.Boolean> val_84;
        WFOMysteryChestDisplay.<>c__DisplayClass86_1 val_85;
        val_68 = 0;
        if((this.<>1__state) > 8)
        {
                return (bool)val_68;
        }
        
        var val_1 = 14115104 + (14115104 + (this.<>1__state) << 2);
        if((this.<>1__state) == 8)
        {
                14115104 + (this.<>1__state) << 2 = (14115104 + (this.<>1__state) << 2) & 325249360;
            14115104 + (this.<>1__state) << 2 = (14115104 + (this.<>1__state) << 2) & ((14115104 + (this.<>1__state) << 2) >> 4);
            14115104 + (this.<>1__state) << 2 = (14115104 + (this.<>1__state) << 2) & ((R8) >> 1);
            14115104 + (this.<>1__state) << 2 = (14115104 + (this.<>1__state) << 2) & 650498720;
            14115104 + (this.<>1__state) << 2 = (14115104 + (this.<>1__state) << 2) & (this >> R2);
            14115104 + (this.<>1__state) << 2 = (14115104 + (this.<>1__state) << 2) & (((IP) << (32-4)) | ((IP) << 4));
        }
        
        this.<>1__state = 0;
        this.<>8__1 = new System.Object();
        typeof(WFOMysteryChestDisplay.<>c__DisplayClass86_0).__il2cppRuntimeField_8 = this.<>4__this;
        val_68 = true;
        this.<>4__this.isAnimationActive = val_68;
        this.<>1__state = val_68;
        this.<>2__current = 0;
        return (bool)val_68;
        label_80:
        this.<>1__state = ;
        val_68 = 1;
        this.<>2__current = ;
        return (bool)val_68;
        label_64:
        object val_24 = new System.Object();
        this.<>8__2 = val_24;
        typeof(WFOMysteryChestDisplay.<>c__DisplayClass86_1).__il2cppRuntimeField_C = this.<>8__1;
        this.<>8__2.currItemIndex = this.<i>5__4;
        if(val_24 <= (this.<>8__2.currItemIndex))
        {
                var val_67 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_67 = val_67 + ((((this.<>8__2.currItemIndex) << 3) - (this.<>8__2.currItemIndex)) << 2);
        if(((0 + (((this.<>8__2.currItemIndex) << 3 - this.<>8__2.currItemIndex)) << 2) + 20) == 6)
        {
                (0 + (((this.<>8__2.currItemIndex) << 3 - this.<>8__2.currItemIndex)) << 2) + 20 = this.<canAttack>5__3;
        }
        
        if(((0 + (((this.<>8__2.currItemIndex) << 3 - this.<>8__2.currItemIndex)) << 2) + 20) == false)
        {
            goto label_53;
        }
        
        if(((0 + (((this.<>8__2.currItemIndex) << 3 - this.<>8__2.currItemIndex)) << 2) + 20) <= (this.<>8__2.currItemIndex))
        {
                var val_68 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_68 = val_68 + ((((this.<>8__2.currItemIndex) << 3) - (this.<>8__2.currItemIndex)) << 2);
        if(((0 + (((this.<>8__2.currItemIndex) << 3 - this.<>8__2.currItemIndex)) << 2) + 20) == 5)
        {
                (0 + (((this.<>8__2.currItemIndex) << 3 - this.<>8__2.currItemIndex)) << 2) + 20 = this.<canRaid>5__2;
        }
        
        if(((0 + (((this.<>8__2.currItemIndex) << 3 - this.<>8__2.currItemIndex)) << 2) + 20) == true)
        {
            goto label_57;
        }
        
        label_53:
        this.<>8__2.CS$<>8__locals1.completedItemSeq = (this.<>8__2.CS$<>8__locals1.completedItemSeq) + 1;
        val_72 = R7 + 1;
        mem2[0] = val_72;
        if(val_72 < R7)
        {
            goto label_64;
        }
        
        System.Func<System.Boolean> val_28 = new System.Func<System.Boolean>(object:  this.<>8__1, method:  new IntPtr(325028656));
        UnityEngine.WaitUntil val_29 = new UnityEngine.WaitUntil(predicate:  7667712);
        goto label_80;
        label_57:
        if(((0 + (((this.<>8__2.currItemIndex) << 3 - this.<>8__2.currItemIndex)) << 2) + 20) <= (this.<>8__2.currItemIndex))
        {
                var val_69 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_69 = val_69 + ((((this.<>8__2.currItemIndex) << 3) - (this.<>8__2.currItemIndex)) << 2);
        if(((0 + (((this.<>8__2.currItemIndex) << 3 - this.<>8__2.currItemIndex)) << 2) + 20) == 5)
        {
            goto label_69;
        }
        
        if(((0 + (((this.<>8__2.currItemIndex) << 3 - this.<>8__2.currItemIndex)) << 2) + 20) <= (this.<>8__2.currItemIndex))
        {
                var val_70 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_70 = val_70 + ((((this.<>8__2.currItemIndex) << 3) - (this.<>8__2.currItemIndex)) << 2);
        if(((0 + (((this.<>8__2.currItemIndex) << 3 - this.<>8__2.currItemIndex)) << 2) + 20) != 6)
        {
            goto label_73;
        }
        
        label_69:
        this.<>4__this.button.interactable = false;
        label_73:
        twelvegigs.Autopilot.AutopilotManager val_32 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  325050160, clipIndex:  0);
        if(R7 < 1)
        {
            goto label_79;
        }
        
        this.<>4__this.DoChestSquashStretchBounce();
        null = new UnityEngine.WaitForSeconds(seconds:  null);
        goto label_80;
        label_79:
        val_69 = this.<>4__this.labelTapToOpen;
        var val_71 = ~(this.<i>5__4);
        val_71 = R2 + val_71;
        string val_34 = System.String.Format(format:  322427456, arg0:  13152256);
        DG.Tweening.Sequence val_35 = DG.Tweening.DOTween.Sequence();
        this.<>4__this.itemDisplaySeqList.Add(item:  0);
        val_73 = this.<>8__2;
        val_74 = 1152921504797581312;
        DG.Tweening.TweenCallback val_36 = new DG.Tweening.TweenCallback(object:  val_73, method:  new IntPtr(325067664));
        DG.Tweening.Sequence val_37 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        DG.Tweening.Sequence val_38 = this.<>4__this.CreateMiniSeqSegmentShowItemIntro(itemIndex:  this.<>8__2.currItemIndex);
        DG.Tweening.Sequence val_39 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.<>4__this);
        DG.Tweening.Sequence val_40 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
        if(0 <= (this.<>8__2.currItemIndex))
        {
                var val_72 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_72 = val_72 + ((((this.<>8__2.currItemIndex) << 3) - (this.<>8__2.currItemIndex)) << 2);
        if(((0 + (((this.<>8__2.currItemIndex) << 3 - this.<>8__2.currItemIndex)) << 2) + 20) != 4)
        {
            goto label_90;
        }
        
        WordForest.WFOPlayer val_42 = WordForest.WFOPlayer.Instance;
        val_73 = 0;
        bool val_43 = MonoExtensions.IsBitSet(value:  132, bit:  8);
        if(val_43 == false)
        {
            goto label_92;
        }
        
        label_90:
        if(val_43 <= (this.<>8__2.currItemIndex))
        {
                var val_73 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_73 = val_73 + ((((this.<>8__2.currItemIndex) << 3) - (this.<>8__2.currItemIndex)) << 2);
        if(((0 + (((this.<>8__2.currItemIndex) << 3 - this.<>8__2.currItemIndex)) << 2) + 20) != 6)
        {
            goto label_96;
        }
        
        WordForest.WFOPlayer val_45 = WordForest.WFOPlayer.Instance;
        if((MonoExtensions.IsBitSet(value:  132, bit:  10)) == false)
        {
            goto label_98;
        }
        
        val_75 = val_74;
        WordForest.WFOPlayer val_47 = WordForest.WFOPlayer.Instance;
        val_76 = this.<>8__2;
        val_73 = null;
        if((MonoExtensions.IsBitSet(value:  132, bit:  11)) == false)
        {
            goto label_100;
        }
        
        val_77 = 1152921513521874832;
        goto label_111;
        label_96:
        if(((0 + (((this.<>8__2.currItemIndex) << 3 - this.<>8__2.currItemIndex)) << 2) + 20) <= (this.<>8__2.currItemIndex))
        {
                var val_74 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_74 = val_74 + ((((this.<>8__2.currItemIndex) << 3) - (this.<>8__2.currItemIndex)) << 2);
        if(((0 + (((this.<>8__2.currItemIndex) << 3 - this.<>8__2.currItemIndex)) << 2) + 20) != 5)
        {
            goto label_110;
        }
        
        val_75 = val_74;
        WordForest.WFOPlayer val_50 = WordForest.WFOPlayer.Instance;
        val_76 = this.<>8__2;
        val_73 = null;
        if((MonoExtensions.IsBitSet(value:  132, bit:  9)) == false)
        {
            goto label_107;
        }
        
        val_77 = 1152921513521888144;
        goto label_111;
        label_92:
        val_78 = this.<>8__2;
        val_73 = null;
        val_79 = 1152921513521893264;
        goto label_109;
        label_98:
        val_78 = this.<>8__2;
        val_73 = null;
        val_79 = 1152921513521898384;
        label_109:
        val_73 = new DG.Tweening.TweenCallback(object:  val_78, method:  new IntPtr(325116816));
        DG.Tweening.Sequence val_53 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        goto label_110;
        label_100:
        val_77 = 1152921513521899408;
        goto label_111;
        label_107:
        val_77 = 1152921513521900432;
        label_111:
        val_73 = new DG.Tweening.TweenCallback(object:  val_76, method:  new IntPtr(325118864));
        DG.Tweening.Sequence val_55 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        val_74 = val_75;
        label_110:
        DG.Tweening.Sequence val_56 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
        if(0 <= (this.<>8__2.currItemIndex))
        {
                var val_75 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_75 = val_75 + ((((this.<>8__2.currItemIndex) << 3) - (this.<>8__2.currItemIndex)) << 2);
        if(((0 + (((this.<>8__2.currItemIndex) << 3 - this.<>8__2.currItemIndex)) << 2) + 20) != 7)
        {
                DG.Tweening.Sequence val_58 = this.<>4__this.CreateMiniSeqSegmentShowItemOuttro(itemIndex:  this.<>8__2.currItemIndex);
            var val_76 = 0;
            DG.Tweening.Sequence val_59 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.<>4__this);
        }
        
        val_76 = val_76 - 1;
        if((this.<i>5__4) >= val_76)
        {
            goto label_118;
        }
        
        this.<>4__this.isAwaitingPlayerInputForItems = true;
        val_80 = this.<>8__2.CS$<>8__locals1.<>9__8;
        if(val_80 != 0)
        {
            goto label_121;
        }
        
        val_81 = this.<>8__2;
        if((this.<>8__2) != 0)
        {
            goto label_122;
        }
        
        val_81 = this.<>8__2;
        if(val_81 == 0)
        {
            goto label_135;
        }
        
        label_122:
        val_73 = this.<>8__2.CS$<>8__locals1;
        val_80 = val_74;
        val_80 = new DG.Tweening.TweenCallback(object:  this.<>8__2.CS$<>8__locals1, method:  new IntPtr(325164944));
        this.<>8__2.CS$<>8__locals1.<>9__8 = val_80;
        label_121:
        DG.Tweening.Sequence val_61 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        label_118:
        DG.Tweening.Sequence val_62 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
        val_82 = this.<>8__2.CS$<>8__locals1.<>9__9;
        if(val_82 != 0)
        {
            goto label_127;
        }
        
        val_83 = this.<>8__2;
        if((this.<>8__2) != 0)
        {
            goto label_128;
        }
        
        val_83 = this.<>8__2;
        if(val_83 == 0)
        {
            goto label_135;
        }
        
        label_128:
        val_73 = this.<>8__2.CS$<>8__locals1;
        val_82 = null;
        val_82 = new DG.Tweening.TweenCallback(object:  this.<>8__2.CS$<>8__locals1, method:  new IntPtr(325194640));
        this.<>8__2.CS$<>8__locals1.<>9__9 = val_82;
        label_127:
        object val_64 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
        val_84 = this.<>8__2.CS$<>8__locals1.<>9__10;
        if(val_84 != 0)
        {
            goto label_133;
        }
        
        val_85 = this.<>8__2;
        if((this.<>8__2) != 0)
        {
            goto label_134;
        }
        
        val_85 = this.<>8__2;
        if(val_85 == 0)
        {
            goto label_135;
        }
        
        label_134:
        val_73 = this.<>8__2.CS$<>8__locals1;
        val_84 = null;
        val_84 = new System.Func<System.Boolean>(object:  this.<>8__2.CS$<>8__locals1, method:  new IntPtr(325224336));
        this.<>8__2.CS$<>8__locals1.<>9__10 = val_84;
        label_133:
        this.<>1__state = 5;
        this.<>2__current = new UnityEngine.WaitUntil(predicate:  7667712);
        val_68 = 1;
        return (bool)val_68;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}
