using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpectreNode : MonoBehaviour {

    public string Name;
    public List<NodeData> In;
    public List<NodeData> Out;
    public SpectreNode Activate;
    public List<NodeConnection> OutCon;

	// Use this for initialization
	void Start () {
        Setup();
	}



    public void AddIn(NodeData data)
    {
        In.Add(data);
    }

    public void AddOut(NodeData data)
    {
        Out.Add(data);
    }
	
    public void FireNode(int index)
    {
        OutCon[index].Fire();
    }

    public void Receive(int index,NodeData data)
    {

    }

    public virtual void Process(int index,NodeData data)
    {

    }

	// Update is called once per frame
	void Update () {
		
	}

    public virtual void Setup()
    {

    }

    public virtual void Cycle()
    {

    }

    public virtual void Begin()
    {

    }

    public virtual void End()
    {

    }

}
