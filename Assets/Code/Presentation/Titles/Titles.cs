using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Titles : MonoBehaviour {

    public bool Use = false;
    public AudioClip TitleTrack;
    public AudioSource TitleSource;
    public List<Texture> Logos;
    public Texture curTex = null;
    public int texIndex = 0;
    public float texAlpha = 0;
    public bool texIn, texOut;
    public float texWait = 1;
    public bool done = false;
    // Use this for initialization
	void Start () {

        TitleSource = this.gameObject.AddComponent<AudioSource>();

        if (Use)
        {
            TitleSource.clip = TitleTrack;
            TitleSource.spatialBlend = 0;
            TitleSource.Play();
            curTex = Logos[0];
            texIn = texOut = false;
            texIn = true;
        }

        
    }
	
	// Update is called once per frame
	void Update () {

        if (texIn)
        {
            texAlpha = texAlpha + 0.01f;
            if(texAlpha >= 1.0f)
            {
                texOut = true;
                texIn = false;
                texWait = 1;
            }
        }
        if (texOut)
        {
            texWait = texWait - 0.01f;
            if (texWait < 0)
            {
                texAlpha = texAlpha - 0.02f;
            }
            if(texAlpha <= 0)
            {
                texIndex++;
                if (texIndex >= Logos.Count)
                {
                    done = true;
                    SceneManager.LoadScene(1);   
                }
                else
                {
                    curTex = Logos[texIndex];
                    texAlpha = 0;
                    texWait = 1;
                    texOut = false;
                    texIn = true;
                }
            }
        }

	}

    private void OnGUI()
    {
        if (done) return;
        if (curTex == null) return;
        GUI.DrawTexture(new Rect(Screen.width / 2 - 256, Screen.height / 2 - 128, 512, 256), curTex, ScaleMode.StretchToFill, true, 0, new Color(texAlpha, texAlpha, texAlpha, texAlpha), 0, 0);

    }
}
