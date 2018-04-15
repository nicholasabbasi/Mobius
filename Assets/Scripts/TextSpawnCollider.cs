using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSpawnCollider : MonoBehaviour {


    public GameObject textPrefab;
    public Transform spawnLoc;

    GameObject Boss_text;
    float displayTime;
    bool textUp;

    // Update is called once per frame
    void Start()
    {
        displayTime = 3f;
        textUp = false;
    }

    void Update()
    {
        displayTime -= Time.deltaTime;
        if(displayTime<=0 && textUp == true)
        {
            textUp = false;
            Destroy(Boss_text);
        }


    }



    void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                if (textUp == false) { 
                    Boss_text = Instantiate(textPrefab, spawnLoc.position, spawnLoc.rotation);

                    textUp = true;
                    displayTime = 3f;
                }   
            }
        }

       






    
}
