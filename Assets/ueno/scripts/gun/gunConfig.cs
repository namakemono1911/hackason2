using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GunConfig
{
    public int numBullet;          //弾数
    public int remainingBullet;    //残弾
    public int reloadTime;         //リロード時間
    public float fileRate;         //発射レート
}
