﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController 
{
    public TankController(TankModel tankModel,TankView tankPrefab)
    {
        TankView = GameObject.Instantiate<TankView>(tankPrefab);
        TankModel = tankModel;
        TankView.InitTankController(this);
        //Debug.Log("Tank Type"+TankType.);
        //TankView.Speed = tankModel.Speed;
        //TankView.Health = tankModel.Health;
        //TankView.Type = tankModel.Type;
    }

    public void Damage(float damage)
    {
        if (TankModel.Health - damage <= 0)
        {
            Debug.Log("Activate Dead State");
        }
        else
        {
            //TankModel.Health = TankModel.Health - damage;
        }
    }
    
    public void SetPosition()
    {
        Vector3 currentPosition = TankView.transform.position;
    }



    public void Fire()
    {
        BulletController bulletController = BulletService.Instance.SpawnBulletType(/*(int)(TankModel.TankType)*/);
        Vector3 Bullet_position = TankView.transform.position + new Vector3(0f,2.2f,0f);
        bulletController.SetPosition(Bullet_position, TankView.transform.rotation);
    }

    public TankModel TankModel { get;  }
    public TankView TankView { get; }
    
}
