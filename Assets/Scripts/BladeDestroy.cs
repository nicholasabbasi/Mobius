using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class BladeDestroy : MonoBehaviour
{

    public GameObject objToBeDestroyed;


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Minecart")
        {
            DestroyObject(objToBeDestroyed);
        }

        if (other.gameObject.tag == "Player")
        {
            Scenes.LoadMainScene();//(SceneManager.GetActiveScene ().name);
        }

    }
}
