using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerGunOverHeat : GunState
{
    private float startTime;

    public LazerGunOverHeat(gunFacade gun) : base(gun) { }

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
        if (gun.gun.coolingTime <= Time.time - startTime)
        {
            gun.gun.temperature = 0.0f;
            gun.changeState(new LazerGunDefault(gun));
        }
    }
}
