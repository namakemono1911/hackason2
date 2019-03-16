using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
abstract public class gunFacade
{
    [SerializeField]
    protected GunConfig gun;

    public abstract void shot();
    public abstract void reload();
}
