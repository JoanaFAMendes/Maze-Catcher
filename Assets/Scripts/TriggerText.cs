﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerText : MonoBehaviour {

    public GameObject player;

    void Update()
    {
        this.transform.LookAt(player.transform);
    }
}
