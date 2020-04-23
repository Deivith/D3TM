using com.odaclick.components;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.odaclick.enemies {

    public abstract class BaseEnemy : MonoBehaviour {
        
        protected int identifier;

        public HealthComponent healthComponent;
    
        public virtual bool HasHealthComponent() {
            return true;
        }

        public abstract string Attack();
    
        public int GetIdentifier() {
            return identifier;
        }

    }

}
