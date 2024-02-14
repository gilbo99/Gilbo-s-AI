using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Gilbo
{


    public class GilboAIToolBox : EditorWindow
    {

        [MenuItem("Tools/Andrew toolbox")]
        public static void ShowWindow()
        {
            GetWindow<GilboAIToolBox>("WHERE ARE YOU");


        }


        private void OnGUI()
        {

            if (GUILayout.Button("All the AI"))
            {

                GameObject[] test = FindObjectsOfType(typeof(GilboEyes)) as GameObject[];

                foreach (GameObject var in test)
                {
                    Selection.activeTransform = var.transform;
                }
            }
        }

   
    }
}

