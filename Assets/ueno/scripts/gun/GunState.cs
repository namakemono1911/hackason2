using System.Collections;
using System.Collections.Generic;

abstract public class GunState
{
    protected gunFacade gun;

    public GunState(gunFacade gun) { this.gun = gun; }
    abstract public void init();
    abstract public void update();
    abstract public void shot();
    abstract public void reload();
}
