using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyClick : MonoBehaviour {


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
                    if (hit.transform.gameObject.name == "key_gold")
                    {


                        GateOpen.close = 0;

                        DestroyObject(this.gameObject);

                    }

                    // PrintName(hit.transform.gameObject);
                }

            }


        }
    }
}
