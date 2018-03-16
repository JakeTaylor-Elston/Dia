using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Dialogue
{
    [CustomEditor(typeof(DialogueData))]
    public class DialogueDataEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            DialogueData dataObject = (DialogueData)target;
            if(GUILayout.Button("Preview Audio"))
            {
                // Check there is audio?
                // Play on a dialogue manager with the target as object to play?
            }
        }
    }
}