using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LazerGun : gunFacade
{
    [SerializeField]
    private Transform shotTrans;

    [SerializeField]
    private GameObject lazerPrefub;

    [SerializeField]
    private float speed;

    public override void reload()
    {
        gun.remainingBullet = gun.numBullet;
    }

    public override void shot()
    {
        var obj = GameObject.Instantiate(lazerPrefub, shotTrans.position, shotTrans.rotation * lazerPrefub.transform.rotation);
        var body = obj.GetComponent<Rigidbody>();
        body.velocity = shotTrans.forward * speed;

        gun.remainingBullet--;
    }
}
