using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SpectreBaseEditor : EditorWindow {

    [MenuItem("OpenFPS/Spectre/Graph Editor")]
    public static void ShowWindow()
    {
        var win = EditorWindow.GetWindow(typeof(SpectreBaseEditor));
        win.position = new Rect(20, 20, 800, 600);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
