using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeBeginGame : SpectreNode {

    public override void Setup()
    {
        AddOut(new DataActivator());
    }

    // Use this for initialization
    void Start () {

        FireNode(0);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
