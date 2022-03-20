using UnityEngine;

namespace Spine.Unity
{
    public class SkeletonDataAsset : ScriptableObject
    {
        // Fields
        public Spine.Unity.AtlasAsset[] atlasAssets;
        public float scale;
        public UnityEngine.TextAsset skeletonJSON;
        public string[] fromAnimation;
        public string[] toAnimation;
        public float[] duration;
        public float defaultMix;
        public UnityEngine.RuntimeAnimatorController controller;
        private Spine.SkeletonData skeletonData;
        private Spine.AnimationStateData stateData;
        
        // Properties
        public bool IsLoaded { get; }
        
        // Methods
        public bool get_IsLoaded()
        {
            if(this.skeletonData != 0)
            {
                    this.skeletonData = 1;
            }
            
            return true;
        }
        private void Reset()
        {
            this.skeletonData = 0;
            this.stateData = 0;
        }
        public static Spine.Unity.SkeletonDataAsset CreateRuntimeInstance(UnityEngine.TextAsset skeletonDataFile, Spine.Unity.AtlasAsset atlasAsset, bool initialize, float scale = 0.01)
        {
            typeof(Spine.Unity.AtlasAsset[]).__il2cppRuntimeField_10 = atlasAsset;
            Spine.Unity.SkeletonDataAsset val_1 = Spine.Unity.SkeletonDataAsset.CreateRuntimeInstance(skeletonDataFile:  skeletonDataFile, atlasAssets:  -1949395168, initialize:  initialize, scale:  scale);
        }
        public static Spine.Unity.SkeletonDataAsset CreateRuntimeInstance(UnityEngine.TextAsset skeletonDataFile, Spine.Unity.AtlasAsset[] atlasAssets, bool initialize, float scale = 0.01)
        {
            UnityEngine.Networking.PlayerConnection.PlayerConnection val_1 = UnityEngine.ScriptableObject.CreateInstance<UnityEngine.Networking.PlayerConnection.PlayerConnection>();
            if((public static Spine.Unity.SkeletonDataAsset UnityEngine.ScriptableObject::CreateInstance<Spine.Unity.SkeletonDataAsset>()) != 0)
            {
                    public static Spine.Unity.SkeletonDataAsset UnityEngine.ScriptableObject::CreateInstance<Spine.Unity.SkeletonDataAsset>().__il2cppRuntimeField_2C = 0;
                public static Spine.Unity.SkeletonDataAsset UnityEngine.ScriptableObject::CreateInstance<Spine.Unity.SkeletonDataAsset>().__il2cppRuntimeField_30 = 0;
                public static Spine.Unity.SkeletonDataAsset UnityEngine.ScriptableObject::CreateInstance<Spine.Unity.SkeletonDataAsset>().__il2cppRuntimeField_14 = skeletonDataFile;
                public static Spine.Unity.SkeletonDataAsset UnityEngine.ScriptableObject::CreateInstance<Spine.Unity.SkeletonDataAsset>().__il2cppRuntimeField_C = atlasAssets;
            }
            else
            {
                    mem[44] = 0;
                mem[48] = 0;
                mem[20] = skeletonDataFile;
                mem[12] = atlasAssets;
            }
            
            public static Spine.Unity.SkeletonDataAsset UnityEngine.ScriptableObject::CreateInstance<Spine.Unity.SkeletonDataAsset>().__il2cppRuntimeField_10 = R3;
            if(initialize == false)
            {
                    return;
            }
            
            Spine.SkeletonData val_2 = GetSkeletonData(quiet:  true);
        }
        public void Clear()
        {
            this.skeletonData = 0;
            this.stateData = 0;
        }
        public Spine.SkeletonData GetSkeletonData(bool quiet)
        {
            UnityEngine.TextAsset val_13;
            Spine.SkeletonData val_14;
            Spine.SkeletonData val_15;
            val_13 = this.skeletonJSON;
            if(val_13 == 0)
            {
                    if(quiet != true)
            {
                    string val_2 = this.name;
                string val_3 = 1977736944 + 1977777584;
                UnityEngine.Debug.LogError(message:  1977736944, context:  1977777584);
            }
            
                val_14 = 0;
                this.skeletonData = val_14;
                this.stateData = val_14;
                return;
            }
            
            val_14 = this.skeletonData;
            if(val_14 != 0)
            {
                    return;
            }
            
            Spine.Atlas[] val_4 = this.GetAtlasArray();
            Spine.AtlasAttachmentLoader val_5 = null;
            val_13 = val_5;
            val_5 = new Spine.AtlasAttachmentLoader(atlasArray:  1977777584);
            string val_6 = this.skeletonJSON.name;
            string val_7 = this.skeletonJSON.ToLower();
            if((this.skeletonJSON.Contains(value:  1977745312)) != false)
            {
                    System.Byte[] val_9 = this.skeletonJSON.bytes;
                Spine.SkeletonData val_10 = Spine.Unity.SkeletonDataAsset.ReadSkeletonData(bytes:  this.skeletonJSON, attachmentLoader:  264110080, scale:  null);
                val_15 = this.skeletonJSON;
            }
            else
            {
                    string val_11 = this.skeletonJSON.text;
                Spine.SkeletonData val_12 = Spine.Unity.SkeletonDataAsset.ReadSkeletonData(text:  this.skeletonJSON, attachmentLoader:  264110080, scale:  null);
                val_15 = this.skeletonJSON;
            }
            
            this.InitializeWithData(sd:  val_15);
            val_14 = this.skeletonData;
        }
        internal void InitializeWithData(Spine.SkeletonData sd)
        {
            this.skeletonData = sd;
            this.stateData = new Spine.AnimationStateData(skeletonData:  sd);
            this.FillStateData();
        }
        internal Spine.Atlas[] GetAtlasArray()
        {
            var val_3;
            System.Collections.Generic.List<WGEventButtonV2> val_1 = new System.Collections.Generic.List<WGEventButtonV2>(capacity:  0);
            val_3 = 0;
            goto label_2;
            label_12:
            Spine.Unity.AtlasAsset val_3 = this.atlasAssets[val_3];
            if((val_3 != 0) && (val_3 != 0))
            {
                    Add(item:  val_3);
            }
            
            val_3 = 1;
            label_2:
            if(val_3 < null)
            {
                goto label_12;
            }
            
            if(null != 0)
            {
                    return ToArray();
            }
            
            return ToArray();
        }
        internal static Spine.SkeletonData ReadSkeletonData(byte[] bytes, Spine.AttachmentLoader attachmentLoader, float scale)
        {
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream(buffer:  bytes);
            if((new Spine.SkeletonBinary(attachmentLoader:  attachmentLoader)) != 0)
            {
                    typeof(Spine.SkeletonBinary).__il2cppRuntimeField_8 = R2;
                return ReadSkeletonData(input:  32747520);
            }
            
            mem[8] = R2;
            return ReadSkeletonData(input:  32747520);
        }
        internal static Spine.SkeletonData ReadSkeletonData(string text, Spine.AttachmentLoader attachmentLoader, float scale)
        {
            System.IO.StringReader val_1 = new System.IO.StringReader(s:  text);
            if((new Spine.SkeletonJson(attachmentLoader:  attachmentLoader)) != 0)
            {
                    typeof(Spine.SkeletonJson).__il2cppRuntimeField_8 = R2;
                return ReadSkeletonData(reader:  33439744);
            }
            
            mem[8] = R2;
            return ReadSkeletonData(reader:  33439744);
        }
        public void FillStateData()
        {
            var val_1;
            if(this.stateData == 0)
            {
                    return;
            }
            
            this.stateData.defaultMix = this.defaultMix;
            if(R7 < 1)
            {
                    return;
            }
            
            var val_6 = 16;
            var val_5 = 0;
            do
            {
                string val_1 = this.fromAnimation[val_5];
                if(this.fromAnimation[0x0][0].m_stringLength != 0)
            {
                    string val_2 = this.toAnimation[val_5];
                if(this.toAnimation[0x0][0].m_stringLength != 0)
            {
                    this.stateData.SetMix(fromName:  this.fromAnimation[val_5], toName:  this.toAnimation[val_5], duration:  null);
                val_1 = ???;
            }
            
            }
            
                val_5 = val_5 + 1;
                val_6 = val_6 + 4;
            }
            while(val_1 != val_5);
        
        }
        public Spine.AnimationStateData GetAnimationStateData()
        {
            if(this.stateData != 0)
            {
                    return;
            }
            
            Spine.SkeletonData val_1 = R4.GetSkeletonData(quiet:  false);
        }
        public SkeletonDataAsset()
        {
            this.atlasAssets = null;
            this.scale = 0.01f;
            this.fromAnimation = null;
            this.toAnimation = null;
            this.duration = null;
        }
    
    }

}
