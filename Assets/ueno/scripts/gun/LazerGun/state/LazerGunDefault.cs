using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerGunDefault : GunState
{
    public LazerGunDefault(gunFacade gun) : base(gun) { }

    public override void init()
    {

    }

    public override void reload()
    {

    }

    public override void shot()
    {
        //発射
        var obj = GameObject.Instantiate(gun.gun.lazerPrefub, gun.gun.shotTrans.position, gun.gun.shotTrans.rotation * gun.gun.lazerPrefub.transform.rotation);
        var body = obj.GetComponent<Rigidbody>();
        body.velocity = gun.gun.shotTrans.forward * gun.gun.speed;

        //温度
        gun.gun.temperature += gun.gun.temperatureRate;
        if (gun.gun.temperature >= 100)
        {
            gun.changeState(new LazerGunOverHeat(gun));
            gun.gun.temperature = 100;
        }
        else
            gun.changeState(new LazerGunFireInterval(gun));
    }

    public override void update()
    {
        gun.gun.temperature -= 0.1f;

        if (gun.gun.temperature <= 0)
            gun.gun.temperature = 0;
    }
}
