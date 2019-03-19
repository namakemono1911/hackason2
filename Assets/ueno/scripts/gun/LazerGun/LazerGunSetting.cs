using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerGunSetting : MonoBehaviour
{
    [SerializeField]
    private KeyMouseInput operation;

    [SerializeField]
    private LazerGun gun;

	// Use this for initialization
	void Start ()
    {
        gun.init();
	}
	
	// Update is called once per frame
	void Update ()
    {
        gun.update();

        if (operation.whetherShot())
            gun.shot();
	}
}
