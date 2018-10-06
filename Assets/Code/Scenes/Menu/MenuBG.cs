using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBG : MonoBehaviour {

    public Texture LogoTex;
    public AudioClip MenuTrack;
    public AudioSource ts;
    public float Alpha;
	// Use this for initialization
	void Start () {

        ts = this.gameObject.AddComponent<AudioSource>();
        ts.clip = MenuTrack;
        ts.spatialBlend = 0;
        ts.Play();


	}
	
	// Update is called once per frame
	void Update () {

        if (Alpha < 1)
        {
            Alpha += 0.03f;
        }

	}

    private void OnGUI()
    {

        GUI.color = new Color(Alpha, Alpha, Alpha, Alpha);
        GUI.DrawTexture(new Rect(Screen.width / 2 - 256, 20, 512, 256),LogoTex);

    }

}
