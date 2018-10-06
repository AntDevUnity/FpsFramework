using UnityEngine;
using UnityEditor;
using System.Collections;


public class GameMenuEditor : EditorWindow
{

    public GameMenu Menu;

    [MenuItem("OpenFPS/Menu/GameMenu Editor")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(GameMenuEditor));
    }

    private void OnGUI()
    {

        GUILayout.BeginVertical();

        GUILayout.BeginHorizontal();

        GUILayout.Label("Game Menu");

        Menu = EditorGUILayout.ObjectField(Menu, typeof(GameMenu), true) as GameMenu;

        if (GUILayout.Button("New"))
        {
            if (GameGlobals.StatGlobal == null)
            {
                Debug.Log("Global info not set.");
                return;
            }
            if(GameGlobals.StatGlobal.GameMenuBase == null)
            {
                Debug.Log("No game menu base to spawn.");
                return;
            }
            Menu = GameObject.Instantiate<GameMenu>(GameGlobals.StatGlobal.GameMenuBase) as GameMenu;
           

        }

        GUILayout.EndHorizontal();

        if (Menu == null) return;

        if (Menu.Items == null) Menu.Items = new System.Collections.Generic.List<GameMenuItem>();

        foreach(var mi in Menu.Items)
        {
            GUILayout.BeginHorizontal();

            GUILayout.Label("Name");

            mi.Text = GUILayout.TextField(mi.Text);

            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();

            GUILayout.Label("To Scene");

            mi.Scene = GUILayout.TextField(mi.Scene);

            GUILayout.EndHorizontal();

            GUILayout.Label("Item Info");
            mi.Info = GUILayout.TextArea(mi.Info);



        }

        if(GUILayout.Button("New Item"))
        {

            var ni = GameObject.Instantiate<GameMenuItem>(GameGlobals.StatGlobal.MenuItemBase) as GameMenuItem;
            ni.Text = "New Item";
            ni.Scene = "Scene";
            ni.Info = "New Item Info";
            Menu.Items.Add(ni);

        }


        GUILayout.EndVertical();

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
