using UnityEngine;

namespace SRF.Service
{
    public abstract class SRSceneServiceBase<T, TImpl> : SRServiceBase<T>, IAsyncService
    {
        // Fields
        private TImpl _rootObject;
        
        // Properties
        protected abstract string SceneName { get; }
        protected TImpl RootObject { get; }
        public bool IsLoaded { get; }
        
        // Methods
        protected abstract string get_SceneName(); // 0
        protected TImpl get_RootObject()
        {
        
        }
        public bool get_IsLoaded()
        {
            return UnityEngine.Object.op_Inequality(x:  401355008, y:  0);
        }
        private void Log(string msg, UnityEngine.Object target)
        {
            UnityEngine.Debug.Log(message:  msg, context:  target);
        }
        protected override void Start()
        {
            if(this != 0)
            {
                    this.Start();
            }
            else
            {
                    this.Start();
            }
            
            UnityEngine.Coroutine val_1 = this.StartCoroutine(routine:  401595392);
        }
        protected override void OnDestroy()
        {
            var val_2 = 35648756;
            if(this != 0)
            {
                    UnityEngine.GameObject val_1 = static_value_021FF4F4.gameObject;
                val_2 = val_2;
                UnityEngine.Object.Destroy(obj:  static_value_021FF4F4);
            }
            
            if(this == 0)
            {
                
            }
        
        }
        protected virtual void OnLoaded()
        {
        
        }
        private System.Collections.IEnumerator LoadCoroutine()
        {
            mem2[0] = this;
        }
        protected SRSceneServiceBase<T, TImpl>()
        {
            if(this == 0)
            {
                
            }
        
        }
    
    }

}
