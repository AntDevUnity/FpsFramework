using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameMenu : MonoBehaviour {


  
    public List<GameMenuItem> Items;
    public int YBegin = 200;


    private void OnGUI()
    {

        var y = YBegin;
        if(Items == null)
        {
            Debug.Log("Menu has no items set.");
            return;
        }
        foreach(var mi in Items)
        {

            if(GUI.Button(new Rect(Screen.width / 2 - 100, y, 200, 30), mi.Text))
            {
                SceneManager.LoadScene(mi.Scene);
                
            }
            y = y + 35;

        }
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
