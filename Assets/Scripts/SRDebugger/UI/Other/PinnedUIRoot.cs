using UnityEngine;

namespace SRDebugger.UI.Other
{
    public class PinnedUIRoot : SRMonoBehaviourEx
    {
        // Fields
        public UnityEngine.Canvas Canvas;
        public UnityEngine.RectTransform Container;
        public SRDebugger.UI.Other.DockConsoleController DockConsoleController;
        public UnityEngine.GameObject Options;
        public SRF.UI.Layout.FlowLayoutGroup OptionsLayoutGroup;
        public UnityEngine.GameObject Profiler;
        public SRDebugger.UI.Other.HandleManager ProfilerHandleManager;
        public UnityEngine.UI.VerticalLayoutGroup ProfilerVerticalLayoutGroup;
        
        // Methods
        public PinnedUIRoot()
        {
        
        }
    
    }

}
