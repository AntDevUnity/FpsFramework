using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodePlayMusic : SpectreNode {

	// Use this for initialization
	void Start () {
		
	}

    public override void Process(int index, NodeData data)
    {
        Debug.Log("Playing music!");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
