using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LazerGun : gunFacade
{
    public override void init()
    {
        changeState(new LazerGunDefault(this));
    }

    public override void update()
    {
        state.update();
    }

    public override void reload()
    {
        state.reload();
    }

    public override void shot()
    {
        state.shot();
    }
}
