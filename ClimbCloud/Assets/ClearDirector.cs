﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



    // Use this for initialization

    public class ClearDirector : MonoBehaviour {
        // Update is called once per frame
        void Update() {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("GameScene");
            }
    }

   }

