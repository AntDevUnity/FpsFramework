using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour {

    public Light Light1;
    public bool Conform = false;
    public float ConformTime = 1;

    float NextFlick = 0;

    // Use this for initialization
    void Start()
    {
        if (Conform)
        {
            NextFlick = Time.realtimeSinceStartup + ConformTime;
        }
        else
        {
            NextFlick = Time.realtimeSinceStartup + Random.value * 2;
        }
    }
	
	// Update is called once per frame
	void Update () {

        if (Time.realtimeSinceStartup > NextFlick)
        {
            if (Conform)
            {
                NextFlick = Time.realtimeSinceStartup + ConformTime;
            }
            else
            {
                NextFlick = Time.realtimeSinceStartup + Random.value * 2;
            }
            if (Light1.enabled == true)
            {
                Light1.enabled = false;
            }
            else
            {
                Light1.enabled = true;
            }
        }

	}
}
