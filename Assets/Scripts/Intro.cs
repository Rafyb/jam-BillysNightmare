﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Intro : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Return))
        { 
            SceneManager.LoadScene("GameScene");
        }

    }

}
