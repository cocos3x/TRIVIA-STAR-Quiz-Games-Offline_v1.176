using UnityEngine;
[Serializable]
public class SkeletonAnimator.MecanimTranslator
{
    // Fields
    public bool autoReset;
    public Spine.Unity.SkeletonAnimator.MecanimTranslator.MixMode[] layerMixModes;
    private readonly System.Collections.Generic.Dictionary<int, Spine.Animation> animationTable;
    private readonly System.Collections.Generic.Dictionary<UnityEngine.AnimationClip, int> clipNameHashCodeTable;
    private readonly System.Collections.Generic.List<Spine.Animation> previousAnimations;
    private UnityEngine.Animator animator;
    
    // Properties
    public UnityEngine.Animator Animator { get; }
    
    // Methods
    public UnityEngine.Animator get_Animator()
    {
    
    }
    public void Initialize(UnityEngine.Animator animator, Spine.Unity.SkeletonDataAsset skeletonDataAsset)
    {
        Spine.Animation val_4;
        this.animator = animator;
        this.animationTable.Clear();
        this.clipNameHashCodeTable.Clear();
        Spine.SkeletonData val_1 = skeletonDataAsset.GetSkeletonData(quiet:  true);
        ExposedList.Enumerator<T> val_2 = GetEnumerator();
        label_10:
        if(MoveNext() == false)
        {
            goto label_6;
        }
        
        this.animationTable.Add(key:  val_4 + 16, value:  val_4);
        goto label_10;
        label_6:
        Dispose();
    }
    public void Apply(Spine.Skeleton skeleton)
    {
        SkeletonAnimator.MecanimTranslator val_104;
        System.Collections.Generic.List<Spine.Animation> val_106;
        var val_108;
        System.Collections.Generic.List<Spine.Animation> val_109;
        var val_110;
        var val_111;
        float val_112;
        int val_113;
        UnityEngine.Animator val_114;
        var val_115;
        UnityEngine.Animator val_116;
        var val_117;
        var val_118;
        var val_119;
        float val_120;
        float val_121;
        var val_122;
        Spine.Skeleton val_123;
        UnityEngine.Animator val_124;
        var val_125;
        float val_126;
        var val_127;
        UnityEngine.Animator val_128;
        var val_129;
        var val_130;
        Spine.ExposedList<Spine.Event> val_131;
        float val_132;
        UnityEngine.Animator val_133;
        var val_134;
        UnityEngine.Animator val_135;
        var val_136;
        float val_137;
        Spine.ExposedList<Spine.Event> val_138;
        var val_139;
        Spine.ExposedList<Spine.Event> val_140;
        float val_141;
        Spine.ExposedList<Spine.Event> val_142;
        float val_143;
        val_104 = this;
        if(0 < this.animator.layerCount)
        {
                System.Array.Resize<System.Int32Enum>(array: ref  this.layerMixModes, newSize:  this.animator.layerCount);
        }
        
        if(this.autoReset == false)
        {
            goto label_12;
        }
        
        val_106 = this.previousAnimations;
        if(this.autoReset < true)
        {
            goto label_7;
        }
        
        val_108 = 0;
        goto label_8;
        label_10:
        val_108 = 1;
        label_8:
        if(this.autoReset <= val_108)
        {
                var val_100 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_100 = val_100 + 4;
        Spine.SkeletonExtensions.SetKeyedItemsToSetupPose(animation:  (0 + 4) + 16, skeleton:  skeleton);
        if((this.autoReset - 1) != val_108)
        {
            goto label_10;
        }
        
        label_7:
        val_106.Clear();
        int val_5 = this.animator.layerCount;
        if(val_5 < 1)
        {
            goto label_12;
        }
        
        label_34:
        if(0 == 0)
        {
            goto label_13;
        }
        
        float val_6 = this.animator.GetLayerWeight(layerIndex:  0);
        if(this.animator <= 0)
        {
            goto label_26;
        }
        
        label_13:
        UnityEngine.AnimatorStateInfo val_7 = GetNextAnimatorStateInfo(layerIndex:  this.animator);
        int val_8 = mem[val_7.m_Speed + (0)].fullPathHash;
        UnityEngine.AnimatorClipInfo[] val_9 = this.animator.GetCurrentAnimatorClipInfo(layerIndex:  val_7.m_Loop);
        val_106 = this.animator;
        val_109 = val_106;
        val_110 = 0;
        UnityEngine.AnimatorClipInfo[] val_10 = this.animator.GetNextAnimatorClipInfo(layerIndex:  val_7.m_Loop);
        val_111 = this.animator;
        UnityEngine.Animator val_11 = val_106 + 16;
        goto label_19;
        label_25:
        float val_12 = null.weight;
        uint val_101 = 2003683472;
        val_101 = this.animator * val_101;
        if(this.animator != val_110)
        {
                UnityEngine.AnimationClip val_13 = null.clip;
            Spine.Animation val_15 = this.animationTable.Item[this.NameHashCode(clip:  2003683472)];
            val_109.Add(item:  this.animationTable);
            val_104 = val_104;
        }
        
        val_11 = val_11 + 8;
        val_110 = 1;
        label_19:
        if(val_110 < val_109)
        {
            goto label_25;
        }
        
        if(val_8 == 0)
        {
            goto label_26;
        }
        
        UnityEngine.Animator val_16 = val_111 + 16;
        val_109 = 0;
        goto label_27;
        label_33:
        float val_17 = null.weight;
        uint val_102 = 2003683464;
        val_102 = this.animator * val_102;
        if(val_8 != val_109)
        {
                UnityEngine.AnimationClip val_18 = null.clip;
            Spine.Animation val_20 = this.animationTable.Item[this.NameHashCode(clip:  2003683464)];
            val_106 = val_106;
            val_106.Add(item:  this.animationTable);
        }
        
        val_16 = val_16 + 8;
        val_109 = 1;
        label_27:
        if(val_109 < val_106)
        {
            goto label_33;
        }
        
        label_26:
        var val_103 = 0;
        val_103 = val_103 + 1;
        if(val_103 != val_5)
        {
            goto label_34;
        }
        
        label_12:
        int val_21 = this.animator.layerCount;
        if(val_21 < 1)
        {
                return;
        }
        
        label_107:
        val_112 = 1f;
        if(0 != 0)
        {
                float val_22 = this.animator.GetLayerWeight(layerIndex:  0);
            val_112 = this.animator;
        }
        
        UnityEngine.AnimatorStateInfo val_23 = GetCurrentAnimatorStateInfo(layerIndex:  this.animator);
        UnityEngine.AnimatorStateInfo val_24 = GetNextAnimatorStateInfo(layerIndex:  this.animator);
        val_109;
        int val_25 = mem[val_24.m_Speed + (0)].fullPathHash;
        UnityEngine.AnimatorClipInfo[] val_26 = this.animator.GetCurrentAnimatorClipInfo(layerIndex:  val_23.m_SpeedMultiplier);
        val_113 = val_23.m_SpeedMultiplier;
        UnityEngine.AnimatorClipInfo[] val_27 = this.animator.GetNextAnimatorClipInfo(layerIndex:  val_113);
        if((this.layerMixModes + 12) <= val_23.m_SpeedMultiplier)
        {
                val_113 = 0;
        }
        
        var val_28 = this.layerMixModes + (val_23.m_SpeedMultiplier << 2);
        if(((this.layerMixModes + (val_23.m_SpeedMultiplier) << 2) + 16) == 0)
        {
            goto label_45;
        }
        
        val_114 = this.animator;
        val_115 = 0;
        val_104 = val_109;
        val_116 = val_114 + 16;
        goto label_46;
        label_50:
        val_116 = val_116 + 8;
        val_115 = 1;
        label_46:
        val_117 = mem[this.animator + 12];
        val_117 = this.animator + 12;
        if(val_115 >= val_117)
        {
            goto label_48;
        }
        
        if(val_117 <= val_115)
        {
                val_118 = 0;
        }
        
        float val_29 = val_116.weight;
        uint val_104 = 2003683416;
        val_104 = val_112 * val_104;
        if(val_117 == val_115)
        {
            goto label_50;
        }
        
        UnityEngine.AnimationClip val_30 = val_116.clip;
        Spine.Animation val_32 = this.animationTable.Item[this.NameHashCode(clip:  2003683416)];
        float val_33 = mem[val_23.m_Speed + (0)].normalizedTime;
        UnityEngine.AnimationClip val_34 = val_116.clip;
        val_109 = ;
        val_119 = 2003683424;
        float val_35 = val_116.length;
        bool val_36 = mem[val_23.m_Speed + (0)].loop;
        float val_37 = mem[val_23.m_Speed + (0)].speed;
        if( < 0)
        {
                val_120 = 2.003683E+09f;
            val_121 = (1f - val_119) + val_120;
            val_119 = val_121 + val_120;
        }
        
        val_122 = 2003683416 * val_119;
        if(val_36 != true)
        {
                val_120 = 2003683416 - val_122;
            if(val_36 < 0)
        {
                val_122 = 2003683416;
        }
        
        }
        
        val_123 = skeleton;
        this.animationTable.Apply(skeleton:  val_123, lastTime:  val_120, time:  null, loop:  false, events:  2003683416, alpha:  val_121, pose:  mem[val_23.m_Speed + (0)].loop, direction:  0);
        val_114 = this.animator;
        val_117 = mem[this.animator + 12];
        val_117 = this.animator + 12;
        label_48:
        val_124 = this.animator;
        if(val_115 < val_117)
        {
                var val_105 = 0;
            do
        {
            val_123 = 0;
            float val_40 = ((this.animator + 16) + 8) + 0.weight;
            UnityEngine.Animator val_41 = val_112 * 2003683408;
            if(val_117 != val_115)
        {
                UnityEngine.AnimationClip val_42 = ((this.animator + 16) + 8) + 0.clip;
            Spine.Animation val_44 = this.animationTable.Item[this.NameHashCode(clip:  2003683408)];
            float val_45 = mem[val_23.m_Speed + (0)].normalizedTime;
            UnityEngine.AnimationClip val_46 = ((this.animator + 16) + 8) + 0.clip;
            val_109 = ;
            val_125 = 2003683424;
            float val_47 = ((this.animator + 16) + 8) + 0.length;
            bool val_48 = mem[val_23.m_Speed + (0)].loop;
            float val_49 = mem[val_23.m_Speed + (0)].speed;
            if( < 0)
        {
                if( == 0)
        {
                -D16 = -(-D16);
        }
        
            val_126 = 2.003683E+09f;
            val_121 = (1f - val_125) + val_126;
            val_125 = val_121 + val_126;
        }
        
            val_127 = 2003683408 * val_125;
            if(val_48 != true)
        {
                val_126 = 2003683408 - val_127;
            if(val_48 < 0)
        {
                val_127 = 2003683408;
        }
        
        }
        
            val_123 = skeleton;
            this.animationTable.Apply(skeleton:  val_123, lastTime:  val_126, time:  null, loop:  false, events:  2003683408, alpha:  val_121, pose:  mem[val_23.m_Speed + (0)].loop, direction:  0);
            val_124 = this.animator;
            val_114 = this.animator;
        }
        
            val_115 = val_115 + 1;
            val_105 = val_105 + 8;
        }
        while(val_115 < (this.animator + 12));
        
        }
        
        if(val_25 == 0)
        {
            goto label_97;
        }
        
        if(((this.layerMixModes + (val_23.m_SpeedMultiplier) << 2) + 16) != 2)
        {
            goto label_66;
        }
        
        val_128 = val_124 + 16;
        val_129 = val_124 + 12;
        val_130 = 0;
        goto label_67;
        label_71:
        val_128 = val_128 + 8;
        val_130 = 1;
        label_67:
        if(val_130 >= val_129)
        {
            goto label_76;
        }
        
        if(val_129 <= val_130)
        {
                val_123 = 0;
        }
        
        float val_52 = val_128.weight;
        uint val_106 = 2003683400;
        val_106 = val_112 * val_106;
        if(val_129 == val_130)
        {
            goto label_71;
        }
        
        UnityEngine.AnimationClip val_53 = val_128.clip;
        Spine.Animation val_55 = this.animationTable.Item[this.NameHashCode(clip:  2003683400)];
        float val_56 = mem[val_24.m_Speed + (0)].normalizedTime;
        UnityEngine.AnimationClip val_57 = val_128.clip;
        val_109 = ;
        val_131 = 2003683440;
        float val_58 = val_128.length;
        float val_59 = mem[val_24.m_Speed + (0)].speed;
        if( < 0)
        {
                if( == 0)
        {
                -D16 = -(-D16);
        }
        
            val_132 = 2.003683E+09f;
            val_121 = (1f - val_131) + val_132;
            val_131 = val_121 + val_132;
        }
        
        val_131 = 2003683400 * val_131;
        this.animationTable.Apply(skeleton:  skeleton, lastTime:  val_132, time:  null, loop:  false, events:  val_131, alpha:  val_121, pose:  mem[val_24.m_Speed + (0)].loop, direction:  0);
        val_124 = this.animator;
        goto label_76;
        label_45:
        val_133 = this.animator;
        val_134 = 0;
        val_135 = this.animator;
        UnityEngine.Animator val_62 = val_133 + 16;
        goto label_77;
        label_86:
        float val_63 = val_24.m_Loop.weight;
        UnityEngine.Animator val_64 = val_112 * val_24.m_Loop;
        if(((this.layerMixModes + (val_23.m_SpeedMultiplier) << 2) + 16) != val_134)
        {
                UnityEngine.AnimationClip val_65 = val_24.m_Loop.clip;
            Spine.Animation val_67 = this.animationTable.Item[this.NameHashCode(clip:  val_24.m_Loop)];
            float val_68 = mem[val_23.m_Speed + (0)].normalizedTime;
            UnityEngine.AnimationClip val_69 = val_24.m_Loop.clip;
            val_136 = 2003683424;
            float val_70 = val_24.m_Loop.length;
            bool val_71 = mem[val_23.m_Speed + (0)].loop;
            float val_72 = mem[val_23.m_Speed + (0)].speed;
            if(val_24.m_Loop < 0)
        {
                float val_73 = 1f - val_136;
            val_137 = 2.003683E+09f;
            val_73 = val_73 + val_137;
            val_136 = val_73 + val_137;
        }
        
            val_138 = val_24.m_Loop * val_136;
            if(val_71 != true)
        {
                val_137 = val_24.m_Loop - val_138;
            if(val_71 < 0)
        {
                val_138 = val_24.m_Loop;
        }
        
        }
        
            this.animationTable.Apply(skeleton:  skeleton, lastTime:  val_137, time:  null, loop:  false, events:  val_138, alpha:  val_73, pose:  mem[val_23.m_Speed + (0)].loop, direction:  0);
            val_135 = this.animator;
            val_133 = this.animator;
        }
        
        val_62 = val_62 + 8;
        val_134 = 1;
        label_77:
        if(val_134 < (this.animator + 12))
        {
            goto label_86;
        }
        
        if(val_25 == 0)
        {
            goto label_97;
        }
        
        UnityEngine.Animator val_75 = val_135 + 16;
        val_139 = 0;
        goto label_88;
        label_96:
        float val_76 = val_75.weight;
        UnityEngine.Animator val_77 = val_112 * 2003683424;
        if(val_25 != val_139)
        {
                UnityEngine.AnimationClip val_78 = val_75.clip;
            Spine.Animation val_80 = this.animationTable.Item[this.NameHashCode(clip:  2003683424)];
            float val_81 = mem[val_24.m_Speed + (0)].normalizedTime;
            UnityEngine.AnimationClip val_82 = val_75.clip;
            val_140 = 2003683440;
            float val_83 = val_75.length;
            float val_84 = mem[val_24.m_Speed + (0)].speed;
            val_109 = ;
            if( < 0)
        {
                float val_85 = 1f - val_140;
            if( == 0)
        {
                -D16 = -(-D16);
        }
        
            val_141 = 2.003683E+09f;
            val_85 = val_85 + val_141;
            val_140 = val_85 + val_141;
        }
        
            val_135 = this.animator;
            val_140 = 2003683424 * val_140;
            this.animationTable.Apply(skeleton:  skeleton, lastTime:  val_141, time:  null, loop:  false, events:  val_140, alpha:  val_85, pose:  mem[val_24.m_Speed + (0)].loop, direction:  0);
        }
        
        val_75 = val_75 + 8;
        val_139 = 1;
        label_88:
        if(val_139 < (this.animator + 12))
        {
            goto label_96;
        }
        
        goto label_97;
        label_66:
        val_129 = val_124 + 12;
        val_130 = 0;
        label_76:
        UnityEngine.Animator val_87 = val_124 + 0;
        UnityEngine.Animator val_88 = val_87 + 16;
        goto label_98;
        label_106:
        float val_89 = val_88.weight;
        UnityEngine.Animator val_90 = val_112 * 2003683392;
        if(val_87 != val_130)
        {
                UnityEngine.AnimationClip val_91 = val_88.clip;
            Spine.Animation val_93 = this.animationTable.Item[this.NameHashCode(clip:  2003683392)];
            float val_94 = mem[val_24.m_Speed + (0)].normalizedTime;
            UnityEngine.AnimationClip val_95 = val_88.clip;
            val_109 = ;
            val_142 = 2003683440;
            float val_96 = val_88.length;
            float val_97 = mem[val_24.m_Speed + (0)].speed;
            if( < 0)
        {
                float val_98 = 1f - val_142;
            if( == 0)
        {
                -D16 = -(-D16);
        }
        
            val_143 = 2.003683E+09f;
            val_98 = val_98 + val_143;
            val_142 = val_98 + val_143;
        }
        
            val_142 = 2003683392 * val_142;
            this.animationTable.Apply(skeleton:  skeleton, lastTime:  val_143, time:  null, loop:  false, events:  val_142, alpha:  val_98, pose:  mem[val_24.m_Speed + (0)].loop, direction:  0);
            val_124 = this.animator;
        }
        
        val_88 = val_88 + 8;
        val_130 = val_130 + 1;
        label_98:
        if(val_130 < val_129)
        {
            goto label_106;
        }
        
        label_97:
        val_106 = val_23.m_SpeedMultiplier + 1;
        if(val_106 != val_21)
        {
            goto label_107;
        }
    
    }
    private static float AnimationTime(float normalizedTime, float clipLength, bool loop, bool reversed)
    {
        var val_1;
        var val_2;
        val_1 = loop;
        if(R3 != 0)
        {
                val_1 = 1f - val_1;
            float val_1 = (float)S6;
            val_1 = val_1 + val_1;
            val_1 = val_1 + val_1;
        }
        
        val_2 = val_1 * reversed;
        if(R2 != 0)
        {
                return (float)reversed;
        }
        
        val_1 = reversed - val_2;
        if(R2 < 0)
        {
                val_2 = reversed;
        }
        
        return (float)reversed;
    }
    private static float AnimationTime(float normalizedTime, float clipLength, bool reversed)
    {
        var val_1;
        var val_1 = R1;
        val_1 = reversed;
        if(R2 != 0)
        {
                val_1 = 1f - val_1;
            val_1 = val_1 + (float)S6;
            val_1 = val_1 + (float)S6;
        }
        
        val_1 = val_1 * val_1;
        return (float)val_1;
    }
    private int NameHashCode(UnityEngine.AnimationClip clip)
    {
        System.Collections.Generic.Dictionary<UnityEngine.AnimationClip, System.Int32> val_5 = this.clipNameHashCodeTable;
        if((val_5.TryGetValue(key:  clip, value: out  int val_1 = 2004111748)) == true)
        {
                return val_4;
        }
        
        string val_3 = clip.name;
        int val_4 = clip.GetHashCode();
        val_5 = val_4;
        this.clipNameHashCodeTable.Add(key:  clip, value:  val_5);
        return val_4;
    }
    public SkeletonAnimator.MecanimTranslator()
    {
        this.autoReset = true;
        this.layerMixModes = null;
        System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_1 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
        this.animationTable = null;
        System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32> val_2 = new System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32>();
        this.clipNameHashCodeTable = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.previousAnimations = null;
    }

}
