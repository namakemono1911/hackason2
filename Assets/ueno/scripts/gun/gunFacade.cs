using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
abstract public class gunFacade
{
    public GunConfig gun;

    protected GunState state;

    public abstract void init();
    public abstract void update();
    public abstract void shot();
    public abstract void reload();
    public void changeState(GunState newState)
    {
        state = newState;
        newState.init();
    }
}
