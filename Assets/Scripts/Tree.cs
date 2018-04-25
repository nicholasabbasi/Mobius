using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour {

    public GameObject textPrefab;
    public GameObject crossPrefab;
    public Transform crossSpwLoc;

    public GameObject AxePrefab;
    public Transform AxeSpwLoc;


    float textTime;
    float chopingTime;
    public static bool hasAxe;
    bool textUP;
    bool Chop;
    GameObject hintText;

	// Use this for initialization
	void Start () {
        hasAxe = false;
        textUP = false;
        Chop = false;
        textTime = 3f;
        chopingTime = 5f;
	}
	
	// Update is called once per frame
	void Update () {

        textTime -= Time.deltaTime;
        if(textTime<=0 && textUP == true)
        {
            Destroy(hintText);
            textUP = false;

        }


        if(Chop == true)
        {
            Instantiate(AxePrefab, AxeSpwLoc.position, AxeSpwLoc.rotation);
            GetComponent<AudioSource>().Play();
            chopingTime -= Time.deltaTime;
            if(chopingTime <= 0)
            {  
                Destroy(gameObject);
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
                    if (hit.transform.gameObject.name == "Tree")
                    {

                        if (hasAxe == false)
                        {
                          hintText =  Instantiate(textPrefab, transform.position, transform.rotation);
                            textTime = 3f;
                            textUP = true;
                        

                        }
                        else
                        {

                            Instantiate(crossPrefab, crossSpwLoc.position, crossSpwLoc.rotation);
                            Chase.detected = 0;
                            Chop = true;


                        }
                    }


                }

            }


        }
    }
}
