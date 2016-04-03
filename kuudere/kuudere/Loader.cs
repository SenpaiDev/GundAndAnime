using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace kuudere {
    class Loader {
        public static GameObject kuudereObject;

        public static void Load() {
            kuudereObject = new GameObject();
            kuudereObject.AddComponent<kuudereGUI>();
            UnityEngine.Object.DontDestroyOnLoad(kuudereObject);
        }

    }
}

