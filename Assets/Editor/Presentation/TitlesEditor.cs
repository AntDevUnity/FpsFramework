using UnityEngine;
using UnityEditor;
using System.Collections;


public class TitlesEditor : EditorWindow {

    Titles TitlesObj;
    Texture curTex;

    [MenuItem("OpenFPS/Presentation/Titles Editor")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(TitlesEditor));
    }

    void OnGUI()
    {

        GUILayout.BeginVertical();
        GUILayout.BeginHorizontal(); 

        GUILayout.Label("Titles Obj", EditorStyles.boldLabel);
        TitlesObj = EditorGUILayout.ObjectField(TitlesObj, typeof(Titles), true) as Titles;
        if (GUILayout.Button("New"))
        {
            TitlesObj = GameObject.Instantiate<Titles>(GameGlobals.StatGlobal.TitlesBase);
            TitlesObj.name = "NewTitles1";
            TitlesObj.Use = true;
          //TitlesObj = GameGlobals.StatGlobal.TitlesBase.gameObject.   

        }
        GUILayout.EndHorizontal();

        if (TitlesObj == null) return;

        GUILayout.BeginHorizontal();
        GUILayout.Label("Title Track", EditorStyles.boldLabel);
        TitlesObj.TitleTrack = EditorGUILayout.ObjectField(TitlesObj.TitleTrack,typeof(AudioClip),true) as AudioClip;
      
        GUILayout.EndHorizontal();

        GUILayout.Label("Titles");

        GUILayout.BeginVertical();

        int ti = 1;
        foreach(var tex in TitlesObj.Logos)
        {
            GUILayout.Label("Title:" + ti.ToString() + ":" + tex.name);
            ti++;
        }

        GUILayout.EndVertical();

        GUILayout.BeginHorizontal();
        curTex = EditorGUILayout.ObjectField(curTex, typeof(Texture), true) as Texture;
        if (GUILayout.Button("New Title"))
        {
            if (curTex != null)
            {
                TitlesObj.Logos.Add(curTex);
            }
        }
        GUILayout.EndHorizontal();

        GUILayout.EndVertical();
    }

}
