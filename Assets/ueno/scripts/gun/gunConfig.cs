using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GunConfig
{
    public Transform shotTrans;     //発射位置
    public GameObject lazerPrefub;  //弾
    public float speed;             //弾速
    public int numBullet;           //弾数
    public int remainingBullet;     //残弾
    public float reloadTime;        //リロード時間
    public float fileRate;          //発射レート
    public float temperatureRate;   //温度上昇率
    public float temperature;       //温度
    public float coolingTime;       //冷却時間
}
