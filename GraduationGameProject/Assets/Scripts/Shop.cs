﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour {

    public TurretBlueprint standardTurret;
    public TurretBlueprint missileLauncher;

    BuildManger buildManger;

    void Start()
    {
        buildManger = BuildManger.instance;
    }

    public void SelectStandardTurret()
    {
        Debug.Log("Standard Turret Selected");
        buildManger.SelectTurretToBuild(standardTurret);
    }

    public void SelectMissialeLauncher()
    {
        Debug.Log("Missile Launcher Selected");
        buildManger.SelectTurretToBuild(missileLauncher);
    }

}
