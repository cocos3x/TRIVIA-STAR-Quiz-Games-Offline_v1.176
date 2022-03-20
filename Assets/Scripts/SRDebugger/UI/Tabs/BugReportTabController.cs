using UnityEngine;

namespace SRDebugger.UI.Tabs
{
    public class BugReportTabController : SRMonoBehaviourEx, IEnableTab
    {
        // Fields
        public SRDebugger.UI.Other.BugReportSheetController BugReportSheetPrefab;
        public UnityEngine.RectTransform Container;
        
        // Properties
        public bool IsEnabled { get; }
        
        // Methods
        public bool get_IsEnabled()
        {
            SRDebugger.Settings val_1 = SRDebugger.Settings.Instance;
            if(this != 0)
            {
                    return (bool)this;
            }
            
            return (bool)this;
        }
        protected override void Start()
        {
            this.Start();
            UnityEngine.RectTransform val_1 = SRInstantiate.Instantiate<UnityEngine.RectTransform>(prefab:  this.BugReportSheetPrefab);
            this.BugReportSheetPrefab.IsCancelButtonEnabled = false;
            System.Action val_2 = new System.Action(object:  424089280, method:  new IntPtr(424059136));
            this.BugReportSheetPrefab.TakingScreenshot = null;
            System.Action val_3 = new System.Action(object:  424089280, method:  new IntPtr(424060160));
            if(this.BugReportSheetPrefab != 0)
            {
                    this.BugReportSheetPrefab.ScreenshotComplete = null;
            }
            else
            {
                    mem[68] = null;
            }
            
            UnityEngine.Transform val_4 = this.BugReportSheetPrefab.CachedTransform;
            this.BugReportSheetPrefab.SetParent(parent:  this.Container, worldPositionStays:  false);
        }
        private void TakingScreenshot()
        {
            var val_3;
            SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
            if(mem[1179403825] == 0)
            {
                goto label_2;
            }
            
            var val_3 = 0;
            label_4:
            if((mem[1179403735] + 0) == null)
            {
                goto label_3;
            }
            
            val_3 = val_3 + 1;
            if(((uint)val_3 & 65535) < mem[1179403825])
            {
                goto label_4;
            }
            
            label_2:
            val_3 = 0;
            goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
            label_3:
            var val_2 = mem[1179403735] + 0;
            var val_4 = (mem[1179403735] + 0) + 4;
            val_4 = 1179403647 + (val_4 << 3);
            val_3 = val_4 + 268;
            goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 268);
        }
        private void ScreenshotComplete()
        {
            var val_3;
            SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
            if(mem[1179403825] == 0)
            {
                goto label_2;
            }
            
            var val_3 = 0;
            label_4:
            if((mem[1179403735] + 0) == null)
            {
                goto label_3;
            }
            
            val_3 = val_3 + 1;
            if(((uint)val_3 & 65535) < mem[1179403825])
            {
                goto label_4;
            }
            
            label_2:
            val_3 = 0;
            goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 252);
            label_3:
            var val_2 = mem[1179403735] + 0;
            var val_4 = (mem[1179403735] + 0) + 4;
            val_4 = 1179403647 + (val_4 << 3);
            val_3 = val_4 + 252;
            goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 252);
        }
        public BugReportTabController()
        {
        
        }
    
    }

}
