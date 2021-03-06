﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeController : MonoBehaviour {

    public ClickEvent click;
    public UnityEngine.UI.Text itemInfo;
    public float cost;
    public int count = 0;
    public int clickPower;
    public string itemName;
    private float _basecost;

    void Start() {
        _basecost = cost;
    }

    void Update() {
        itemInfo.text = itemName + "\n cost:" + cost + "\nPower= +" + clickPower;


    }
    public void PurchasedUpgrade() {
        if (click.wood >= cost) {
            click.wood -= cost;
            count += 1;
            click.woodclick += clickPower;
            cost = Mathf.Round(_basecost * Mathf.Pow(1.15f, count));


        }


    }

} 
