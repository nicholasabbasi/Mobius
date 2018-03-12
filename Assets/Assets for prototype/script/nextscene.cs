using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextscene : MonoBehaviour
{
    //public scoreboard scoreManager;
    //public int i=0;
    private void OnCollisionEnter(Collision collision)
    {

       // scoreManager.AddPoint();
        //testcode.bulletNumber = 8;
        Debug.Log("Collision detected");
        Destroy(gameObject);
        SceneManager.LoadScene(1);
    }
    // Use this for initialization
    //void Start () {

    //}
    //void OnCollisionEnter(Collision target){
    //Debug.Log ("objectthatcollided" + target.gameObject.name);



    //}


    // Update is called once per frame
    void Update()
    {


    }
}
