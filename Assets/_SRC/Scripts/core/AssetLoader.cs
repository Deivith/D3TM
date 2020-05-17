using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.odaclick.d3.core {

    public class AssetLoader {

        public static T GetAsset<T>(string identifier) where T : Object {
            return Resources.Load<T>(identifier);
        }

    }


}
