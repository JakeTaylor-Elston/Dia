using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dialogue
{
    [System.Serializable]
    public struct DialogueSegment
    {
        public string segmentText;
        public string segmentCharacterName;
//        [FMODUnity.EventRef]
//        public string segmentFmodEvent;
        public AudioClip segmentAudioClip;

        public bool extraDelay;
        public float additionalDelayTime;
    }

    [CreateAssetMenu(fileName = "New DialogueData", menuName = "Dialogue/DialogueData")]
    public class DialogueData : ScriptableObject
    {
        [SerializeField]
        private DialogueSegment[] dialogueSegments;

        [SerializeField]
        private float segmentDelayTime;
    }
}