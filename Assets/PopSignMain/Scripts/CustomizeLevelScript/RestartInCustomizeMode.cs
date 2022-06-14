﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartInCustomizeMode : MonoBehaviour
{
    public UnityEngine.UI.Text text;
    // Start is called before the first frame update
    void Start()
    {
        if (CustomizeLevelManager.Instance == null || !CustomizeLevelManager.Instance.tryingToCustomize)
        {
            text.text = "Restart";
        }
        else
        {
            text.text = "Recreate";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
