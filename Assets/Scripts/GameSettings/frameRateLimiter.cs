﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frameRateLimiter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 30;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
