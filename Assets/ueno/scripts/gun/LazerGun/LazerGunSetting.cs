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
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (operation.whetherShot())
            gun.shot();
	}
}
