using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class GameGlobals : MonoBehaviour {

    public static GameGlobals StatGlobal;

    public Titles TitlesBase;
    public CampaignInfo CamInfoBase;
    public GameMenu GameMenuBase;
    public GameMenuItem MenuItemBase;

    private void Awake()
    {
        StatGlobal = this;
    }

    // Use this for initialization
    void Start () {
        StatGlobal = this;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
