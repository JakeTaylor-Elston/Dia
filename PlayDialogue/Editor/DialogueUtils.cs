using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Dialogue;

public class DialogueUtils : EditorWindow
{
    private GUIStyle fontStyle = new GUIStyle();

    private DialogueData dialogueDataToEdit;
    private string nameOfDataAsset;

    private bool includeText;
    private bool includeAudio;

    private bool showText;
    private bool showAudio;

    private TextAsset textAssetRef;
    private bool splitNames;
    private string nameSplitString;

    private float delayTime;

    [MenuItem ("Window/Dialogue Utils")]
    static void EnableWindow()
    {
        EditorWindow.GetWindow<DialogueUtils>();
    }

    void OnEnable()
    {
        fontStyle.fontSize = 12;
        fontStyle.alignment = TextAnchor.MiddleCenter;
    }

    void OnGUI()
    {
        EditorGUILayout.BeginScrollView(new Vector2(0,0), false, true);
        GUILayout.Box("", GUILayout.ExpandWidth(true), GUILayout.Height(3));
        EditorGUILayout.LabelField("Creating New DialogueData", fontStyle);
        GUILayout.Box("", GUILayout.ExpandWidth(true), GUILayout.Height(3));

        EditorGUILayout.Space();

        dialogueDataToEdit = (DialogueData)EditorGUILayout.ObjectField(dialogueDataToEdit, typeof(DialogueData), false);

        nameOfDataAsset = EditorGUILayout.TextField("Datafile Name: ", nameOfDataAsset); 

        EditorGUILayout.Space();

        includeText = EditorGUILayout.Toggle("Include Text: ", includeText);
        includeAudio = EditorGUILayout.Toggle("Include Audio: ", includeAudio);

        EditorGUILayout.Space();

        showText = EditorGUILayout.Foldout(showText, "Text Options: ");
        if(showText)
        {
            textAssetRef = (TextAsset)EditorGUILayout.ObjectField(textAssetRef, typeof(TextAsset), false);

            splitNames = EditorGUILayout.Toggle("Include Names: ", splitNames);
            if(splitNames)
            {
                nameSplitString = EditorGUILayout.TextField("Split String: ", nameSplitString); 
            }
        }

        EditorGUILayout.Space();

        showAudio = EditorGUILayout.Foldout(showAudio, "Audio Options: ");
        if(showAudio)
        {
            //audioClipField = (AudioClip)EditorGUILayout.ObjectField(audioClipField, typeof(AudioClip), false);
        }

        EditorGUILayout.Space();

        delayTime = EditorGUILayout.FloatField("Delay Time: ", delayTime);

        EditorGUILayout.Space();

        // this should be true or false based on having a dialogue data in the field.
        DrawInteractButton(true);

        GUILayout.FlexibleSpace();
        GUILayout.Box("", GUILayout.ExpandWidth(true), GUILayout.Height(3));

        EditorGUILayout.EndScrollView();
    }

    void DrawInteractButton(bool createNew)
    {
        string buttonText = createNew ? ConstValues.createNewText : ConstValues.editCurrentText;

        if(GUILayout.Button(buttonText))
        {
            if(createNew)
            {
                CreateNewDataFile();
            }

            else
            {
                EditCurrentDataFile();
            }
        }
    }

    void CreateNewDataFile()
    {
        
    }

    void EditCurrentDataFile()
    {
        
    }
}