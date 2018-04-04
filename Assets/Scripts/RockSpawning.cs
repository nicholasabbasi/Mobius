using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawning : MonoBehaviour {

    public GameObject FoodObj1;

    public GameObject FoodObj2;

    public Vector3 center;
    public Vector3 size;

    public float period = 0.0f;

	// Use this for initialization
	void Start ()
    {
        SpawnFood();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (period > 0.3)
        {
            SpawnFood();
            period = 0;
        }
        period += UnityEngine.Time.deltaTime;
    }

    public void SpawnFood()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));

        //Instantiate(FoodObj1, pos, Quaternion.identity);

        if(Random.Range(0,3) > 1)
        {
            GameObject newBullet = GameObject.Instantiate(FoodObj2, pos, Quaternion.identity) as GameObject;
            //newBullet.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

            Destroy(newBullet, 3);
        }
        else
        {
            GameObject newBullet = GameObject.Instantiate(FoodObj1, pos, Quaternion.identity) as GameObject;
            //newBullet.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

            Destroy(newBullet, 3);
        }

        


        
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1,0,0,0.5f);
        Gizmos.DrawCube(center, size);
    }
}
