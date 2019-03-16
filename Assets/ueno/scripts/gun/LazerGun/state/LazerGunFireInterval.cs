using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerGunFireInterval : GunState
{
    private float startTime;

    public LazerGunFireInterval(gunFacade gun) : base(gun) { }

    public override void init()
    {
        startTime = Time.time;
    }

    public override void reload()
    {

    }

    public override void shot()
    {

    }

    public override void update()
    {
        if (gun.gun.fileRate <= Time.time - startTime)
            gun.changeState(new LazerGunDefault(gun));
    }
}
