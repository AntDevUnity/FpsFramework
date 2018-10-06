using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBase : MonoBehaviour {

    public string Name = "Item";
    public ItemType Type = ItemType.Weapon;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

public enum ItemType
{
    Item,Weapon,Utility,Gadget,Interactor
}