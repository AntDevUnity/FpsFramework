using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuReact : MonoBehaviour {


    private Vector3 ea;

    // Use this for initialization
    void Start () {

        ea = this.transform.localRotation.eulerAngles;



	}

    bool first = true;

	// Update is called once per frame
	void Update () {

        if (first)
        {
            ea = transform.eulerAngles;
            first = false;
        }
        float xs = Input.mousePosition.x;
        float ys = Input.mousePosition.y;

        var na = ea;

        xs = xs / Screen.width;
        ys = ys / Screen.height;

        xs = -0.5f + xs;
        ys = -0.5f + ys;


        na.y = na.y - (xs * 30);
        na.x = na.x + (ys * 30);

        this.transform.eulerAngles = na;


	}
}
