﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour {

    void OnTriggerEnter()
    {
        Scenes.LoadMainScene();//(SceneManager.GetActiveScene ().name);
    }
}
