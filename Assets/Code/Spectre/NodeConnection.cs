using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeConnection : MonoBehaviour {

    public SpectreNode InNode;
    public SpectreNode OutNode;
    public int OutIndex;
    public int InIndex;
    public NodeData In;
    public NodeData Out;



    public NodeData Data;

    public void Fire()
    {
        OutNode.Receive(OutIndex,Out);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
