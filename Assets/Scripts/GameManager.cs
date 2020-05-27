﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject deactivationObject;
    public MoveSpriteRight scriptDeactivation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Let's get this bread!");
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            scriptDeactivation.enabled = !scriptDeactivation.enabled;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            deactivationObject.SetActive(!deactivationObject.activeInHierarchy);
        }
    }
}
