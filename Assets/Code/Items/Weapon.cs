using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : ItemBase {

    public ProjectileType ProjT = ProjectileType.Direct;
    public ShotType ShotT = ShotType.Multi;
    public float ShotInterval = 0.15f;

    public Transform MuzzleBase;
    public Transform ProjBase;

    public AudioClip ShotAudio;
    public AudioSource MuzzleSource;

    public WeaponManager WeaponMan;

    private bool ShotIn = false;
    private float NextShot = 0;
    private bool NeedRelease = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void UpdateWeapon () {

        bool fb = Input.GetButton("Fire1");

        if (NeedRelease)
        {
            if (fb == false)
            {
                NeedRelease = false;
            }
        }

        if (fb && NeedRelease == false)
        {
            if (ShotIn==false)
            {
                ShotIn = true;
                DoShot();
                if(ShotT == ShotType.Single)
                {
                    ShotIn = false;
                    NeedRelease = true;
                }
                NextShot = Time.timeSinceLevelLoad + ShotInterval;
            }
            else
            {
                if (Time.timeSinceLevelLoad > NextShot)
                {
                    DoShot();
                    NextShot = Time.timeSinceLevelLoad + ShotInterval;
                }
            }
        }


	}

    void DoShot()
    {
        MuzzleSource.clip = ShotAudio;
        MuzzleSource.Play();
        switch (ProjT)
        {
            case ProjectileType.Direct:

                var np = GameObject.Instantiate<GameObject>(ProjBase.gameObject) as GameObject;
                np.transform.position = MuzzleBase.transform.position;
                np.transform.rotation = MuzzleBase.transform.rotation;
                var wp = new WeaponProjectile();
                wp.Speed = 5.0f;
                wp.Projectile = np.transform;
                WeaponMan.Projectiles.Add(wp);


                break;
        }
        Debug.Log("Shot!");
    }

}

public enum ShotType
{
    Single,Multi
}

public enum ProjectileType
{
    Instant,Direct,Physical
}
