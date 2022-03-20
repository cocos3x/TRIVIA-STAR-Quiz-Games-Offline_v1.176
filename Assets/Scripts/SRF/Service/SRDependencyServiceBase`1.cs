using UnityEngine;

namespace SRF.Service
{
    public abstract class SRDependencyServiceBase<T> : SRServiceBase<T>, IAsyncService
    {
        // Fields
        private bool _isLoaded;
        
        // Properties
        protected abstract System.Type[] Dependencies { get; }
        public bool IsLoaded { get; }
        
        // Methods
        protected abstract System.Type[] get_Dependencies(); // 0
        public bool get_IsLoaded()
        {
            return (bool)this;
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
            
            UnityEngine.Coroutine val_1 = this.StartCoroutine(routine:  400121824);
        }
        protected virtual void OnLoaded()
        {
        
        }
        private System.Collections.IEnumerator LoadDependencies()
        {
            mem2[0] = this;
        }
        protected SRDependencyServiceBase<T>()
        {
            if(this == 0)
            {
                
            }
        
        }
    
    }

}
