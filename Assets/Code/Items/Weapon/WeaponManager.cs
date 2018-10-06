using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour {

    public List<WeaponProjectile> Projectiles = new List<WeaponProjectile>();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Projectiles == null)
        {

            Debug.LogError("No projectiles.");
            return;

        }

        foreach(var wp in Projectiles)
        {

            wp.Projectile.Translate(new Vector3(-wp.Speed, 0, 0), Space.Self);


        }


	}
}
