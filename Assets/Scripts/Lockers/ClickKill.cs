using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickKill : MonoBehaviour {

    string door_name = "";
    string wrongDoorNames = "BDoor CDoor EDoor FDoor GDoor HDoor JDoor KDoor LDoor NDoor ODoor PDoor QDoor TDoor UDoor VDoor WDoor XDoor YDoor ZDoor ";
    void Update()
    {
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

                        Scenes.LoadMainScene();
                        // DoorActivation.doorOpen = true;
                        // Destroy(gameObject);          //attach this to Cube and sucessfully destroy the Cube

                    }

                    // PrintName(hit.transform.gameObject);
                }

            }


        }
    }
}
