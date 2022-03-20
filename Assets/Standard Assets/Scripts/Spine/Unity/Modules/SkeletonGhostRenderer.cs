using UnityEngine;

namespace Spine.Unity.Modules
{
    public class SkeletonGhostRenderer : MonoBehaviour
    {
        // Fields
        public float fadeSpeed;
        private UnityEngine.Color32[] colors;
        private UnityEngine.Color32 black;
        private UnityEngine.MeshFilter meshFilter;
        private UnityEngine.MeshRenderer meshRenderer;
        
        // Methods
        private void Awake()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            object val_2 = this.AddComponent<System.Object>();
            this.meshRenderer = this;
            UnityEngine.GameObject val_3 = this.gameObject;
            object val_4 = this.AddComponent<System.Object>();
            this.meshFilter = this;
        }
        public void Initialize(UnityEngine.Mesh mesh, UnityEngine.Material[] materials, UnityEngine.Color32 color, bool additive, float speed, int sortingLayerID, int sortingOrder)
        {
            int val_1;
            var val_10;
            UnityEngine.Color32[] val_11;
            var val_12;
            this.StopAllCoroutines();
            UnityEngine.GameObject val_2 = this.gameObject;
            this.SetActive(value:  true);
            this.meshRenderer.sharedMaterials = materials;
            this.meshRenderer.sortingLayerID = sortingOrder;
            this.meshRenderer.sortingOrder = val_1;
            object val_3 = UnityEngine.Object.Instantiate<System.Object>(original:  mesh);
            this.meshFilter.sharedMesh = mesh;
            UnityEngine.Mesh val_4 = this.meshFilter.sharedMesh;
            val_10 = 0;
            UnityEngine.Color32[] val_5 = this.meshFilter.colors32;
            this.colors = this.meshFilter;
            val_11 = this.meshFilter;
            if(((uint)(color.r >> 16) & 255) != (color.r >> 24))
            {
                goto label_10;
            }
            
            goto label_11;
            label_15:
            val_10 = 1;
            this.colors[val_10] = color;
            val_11 = this.colors;
            label_10:
            if(val_10 < this.colors[val_10])
            {
                goto label_15;
            }
            
            label_11:
            this.fadeSpeed = sortingLayerID;
            if(additive != false)
            {
                    val_12 = this;
                System.Collections.IEnumerator val_7 = this.FadeAdditive();
            }
            else
            {
                    val_12 = this;
                System.Collections.IEnumerator val_8 = this.Fade();
            }
            
            UnityEngine.Coroutine val_9 = val_12.StartCoroutine(routine:  2023410176);
        }
        private System.Collections.IEnumerator Fade()
        {
            object val_1 = new System.Object();
            typeof(SkeletonGhostRenderer.<Fade>d__7).__il2cppRuntimeField_8 = 0;
            typeof(SkeletonGhostRenderer.<Fade>d__7).__il2cppRuntimeField_10 = this;
        }
        private System.Collections.IEnumerator FadeAdditive()
        {
            object val_1 = new System.Object();
            typeof(SkeletonGhostRenderer.<FadeAdditive>d__8).__il2cppRuntimeField_8 = 0;
            typeof(SkeletonGhostRenderer.<FadeAdditive>d__8).__il2cppRuntimeField_10 = this;
        }
        public void Cleanup()
        {
            if(this.meshFilter != 0)
            {
                    UnityEngine.Mesh val_2 = this.meshFilter.sharedMesh;
                if(this.meshFilter != 0)
            {
                    UnityEngine.Mesh val_4 = this.meshFilter.sharedMesh;
                UnityEngine.Object.Destroy(obj:  this.meshFilter);
            }
            
            }
            
            UnityEngine.GameObject val_5 = this.meshFilter.gameObject;
            UnityEngine.Object.Destroy(obj:  2023893632);
        }
        public SkeletonGhostRenderer()
        {
            this.fadeSpeed = 10f;
            UnityEngine.Color32 val_1 = new UnityEngine.Color32(r:  0, g:  0, b:  0, a:  0);
            this.black = val_1.r;
        }
    
    }

}
