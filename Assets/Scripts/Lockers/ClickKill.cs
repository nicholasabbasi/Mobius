using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickKill : MonoBehaviour {

    public GameObject explodeEffect;

    float delay = 1f;
    bool loadScene = false;
    string door_name = "";
    string wrongDoorNames = "BDoor CDoor EDoor FDoor GDoor HDoor JDoor KDoor LDoor NDoor ODoor PDoor QDoor TDoor UDoor VDoor WDoor XDoor YDoor ZDoor ";
    void Update()
    {
        
        
        if (loadScene==true)
        {
            delay -= Time.deltaTime;
            if (delay <= 0)
            {
                Scenes.LoadMainScene();
            }
        }



        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform)
                {
                    door_name = hit.transform.gameObject.name;

                    if (wrongDoorNames.Contains(door_name))
                    {

                        Explode();
                        loadScene = true;
                       
                        // DoorActivation.doorOpen = true;
                        // Destroy(gameObject);          //attach this to Cube and sucessfully destroy the Cube

                    }

                    // PrintName(hit.transform.gameObject);
                }

            }


        }
    }

    void Explode()
    {
        Instantiate(explodeEffect, transform.position, transform.rotation);
        GetComponent<AudioSource>().Play();


    }



}
