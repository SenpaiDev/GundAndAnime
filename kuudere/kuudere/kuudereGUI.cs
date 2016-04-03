using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace kuudere {
    class kuudereGUI : MonoBehaviour{
        bool menutog;
        void OnGUI() {
            if (menutog) {
                GUILayout.BeginArea(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 300, 100, 600));
                if (GUILayout.Button("button")) { }
                GUILayout.EndArea();
            }
        }
        void Update() {
            if (UnityEngine.Input.GetKeyDown(KeyCode.G)) {
                menutog = !menutog;
            }
        }
    }
}
