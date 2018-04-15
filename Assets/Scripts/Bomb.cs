using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {

    public float delay = 3f;
    float countdown;
    float soundDelay;
    bool hasExploded = false;
    public GameObject effect;

	// Use this for initialization
	void Start () {
        countdown = delay;
        soundDelay = 1f;
	}
	
	// Update is called once per frame
	void Update () {
        countdown -= Time.deltaTime;
        if(countdown <=0 && hasExploded == false)
        {
            Explode();
            
            hasExploded = true;

        }

        if(hasExploded == true)
        {
            soundDelay -= Time.deltaTime;
            if (soundDelay <= 0)
            {
                Blocker.Bombed = true;
                Destroy(gameObject);
            }
        }

	}

    void Explode()
    {
        Instantiate(effect, transform.position, transform.rotation);
        GetComponent<AudioSource>().Play();
       



    }


}
