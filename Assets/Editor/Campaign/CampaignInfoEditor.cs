using UnityEngine;
using UnityEditor;
using System.Collections;


public class CampaignInfoEditor : EditorWindow {

    CampaignInfo CurCam;

    [MenuItem("OpenFPS/Game/Campaign Info Editor")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(CampaignInfoEditor));
    }

    private void OnGUI()
    {
        GUILayout.BeginVertical();
        GUILayout.BeginHorizontal();

        GUILayout.Label("CampaignInfo Obj", EditorStyles.boldLabel);
        CurCam = EditorGUILayout.ObjectField(CurCam, typeof(CampaignInfo), true) as CampaignInfo;
        if (GUILayout.Button("New"))
        {
            CurCam = GameObject.Instantiate<CampaignInfo>(GameGlobals.StatGlobal.CamInfoBase);
            CurCam.name = "NewCamInfo1";
            
            //TitlesObj = GameGlobals.StatGlobal.TitlesBase.gameObject.   

        }
        GUILayout.EndHorizontal();

        if (CurCam == null)
        {
            GUILayout.EndVertical();
            return;
        }

        GUILayout.BeginHorizontal();

        GUILayout.Label("Campaign Name", EditorStyles.boldLabel);

        CurCam.CamName = GUILayout.TextField(CurCam.CamName);

        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();

        GUILayout.Label("Campaign Image");

        CurCam.CamImage = EditorGUILayout.ObjectField(CurCam.CamImage, typeof(Sprite), true) as Sprite;
        
        GUILayout.EndHorizontal();

        GUILayout.Label("Campaign Info");

        CurCam.CamInfo = GUILayout.TextArea(CurCam.CamInfo);

        GUILayout.BeginHorizontal();
        GUILayout.Label("Author");
        CurCam.Author = GUILayout.TextField(CurCam.Author);
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label("Copyright");
        CurCam.CopyRight = GUILayout.TextField(CurCam.CopyRight);

        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        GUILayout.Label("Scene Name");
        CurCam.CamScene = GUILayout.TextField(CurCam.CamScene);

        GUILayout.EndHorizontal();

        GUILayout.EndVertical();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
