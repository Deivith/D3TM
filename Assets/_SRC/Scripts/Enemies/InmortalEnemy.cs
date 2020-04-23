using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.odaclick.enemies {

    public class InmortalEnemy : BaseEnemy {

        private void Start() {
            identifier = 2;
        }

        public override bool HasHealthComponent() {
            return false;
        }

        public override string Attack() {
            return "Inmortal Enemy Attack";
        }

        public string PowerUp() {
            return "PowerUp";
        }
    }

}