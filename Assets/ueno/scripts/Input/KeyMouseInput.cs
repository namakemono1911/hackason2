using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ShotKeySetting
{
    public KeyCode shotKey;
    public KeyCode reloadKey;
}

[System.Serializable]
public class KeyMouseInput : InputFacade
{
    [SerializeField]
    private ShotKeySetting keySetting;

    public override bool whetherReroad()
    {
        return Input.GetKeyDown(keySetting.reloadKey);
    }

    public override bool whetherShot()
    {
        return Input.GetKey(keySetting.shotKey);
    }
}
