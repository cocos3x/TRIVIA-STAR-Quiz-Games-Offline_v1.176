using UnityEngine;

namespace SRF
{
    public abstract class SRMonoBehaviour : MonoBehaviour
    {
        // Fields
        private UnityEngine.Collider _collider;
        private UnityEngine.Transform _transform;
        private UnityEngine.Rigidbody _rigidBody;
        private UnityEngine.GameObject _gameObject;
        private UnityEngine.Rigidbody2D _rigidbody2D;
        private UnityEngine.Collider2D _collider2D;
        
        // Properties
        public UnityEngine.Transform CachedTransform { get; }
        public UnityEngine.Collider CachedCollider { get; }
        public UnityEngine.Collider2D CachedCollider2D { get; }
        public UnityEngine.Rigidbody CachedRigidBody { get; }
        public UnityEngine.Rigidbody2D CachedRigidBody2D { get; }
        public UnityEngine.GameObject CachedGameObject { get; }
        public UnityEngine.Transform transform { get; }
        public UnityEngine.Collider collider { get; }
        public UnityEngine.Collider2D collider2D { get; }
        public UnityEngine.Rigidbody rigidbody { get; }
        public UnityEngine.Rigidbody2D rigidbody2D { get; }
        public UnityEngine.GameObject gameObject { get; }
        
        // Methods
        public UnityEngine.Transform get_CachedTransform()
        {
            if(this._transform != 0)
            {
                    return;
            }
            
            UnityEngine.Transform val_2 = this._transform.transform;
            this._transform = this;
        }
        public UnityEngine.Collider get_CachedCollider()
        {
            if(this._collider != 0)
            {
                    return;
            }
            
            object val_2 = this._collider.GetComponent<System.Object>();
            this._collider = this;
        }
        public UnityEngine.Collider2D get_CachedCollider2D()
        {
            if(this._collider2D != 0)
            {
                    return;
            }
            
            object val_2 = this._collider2D.GetComponent<System.Object>();
            this._collider2D = this;
        }
        public UnityEngine.Rigidbody get_CachedRigidBody()
        {
            if(this._rigidBody != 0)
            {
                    return;
            }
            
            object val_2 = this._rigidBody.GetComponent<System.Object>();
            this._rigidBody = this;
        }
        public UnityEngine.Rigidbody2D get_CachedRigidBody2D()
        {
            if(this._rigidbody2D != 0)
            {
                    return;
            }
            
            object val_2 = this._rigidbody2D.GetComponent<System.Object>();
            this._rigidbody2D = this;
        }
        public UnityEngine.GameObject get_CachedGameObject()
        {
            if(this._gameObject != 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = this.gameObject;
            this._gameObject = this;
        }
        public UnityEngine.Transform get_transform()
        {
            return this.CachedTransform;
        }
        public UnityEngine.Collider get_collider()
        {
            return this.CachedCollider;
        }
        public UnityEngine.Collider2D get_collider2D()
        {
            return this.CachedCollider2D;
        }
        public UnityEngine.Rigidbody get_rigidbody()
        {
            return this.CachedRigidBody;
        }
        public UnityEngine.Rigidbody2D get_rigidbody2D()
        {
            return this.CachedRigidBody2D;
        }
        public UnityEngine.GameObject get_gameObject()
        {
            return this.CachedGameObject;
        }
        protected void AssertNotNull(object value, string fieldName)
        {
            SRDebugUtil.AssertNotNull(value:  value, message:  fieldName, instance:  367798752);
        }
        protected void Assert(bool condition, string message)
        {
            SRDebugUtil.Assert(condition:  condition, message:  message, instance:  367923040);
        }
        protected void EditorAssertNotNull(object value, string fieldName)
        {
            SRDebugUtil.AssertNotNull(value:  value, message:  fieldName, instance:  368047328);
        }
        protected void EditorAssert(bool condition, string message)
        {
            SRDebugUtil.Assert(condition:  condition, message:  message, instance:  368171616);
        }
        protected SRMonoBehaviour()
        {
        
        }
    
    }

}
