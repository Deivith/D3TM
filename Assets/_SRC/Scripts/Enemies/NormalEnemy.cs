using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.odaclick.enemies {


    public class NormalEnemy : BaseEnemy {

        public override string Attack() {
            return "Normal Enemy Attack";
        }

        private void Start() {
            identifier = 1;
        }

    }

}