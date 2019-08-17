﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController 
{
    public TankController(TankModel tankModel,TankView tankPrefab, BulletService bulletService)
    {
        TankModel = tankModel;
        TankView = GameObject.Instantiate<TankView>(tankPrefab);
        
       
                
        //Debug.Log("Tank View Created", TankView);
    }

    public TankModel TankModel { get; }
    public TankView TankView { get; }


}
