using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNotice : MonoBehaviour
{

    public GameObject GotBombPrefab;
    public GameObject GotAxePrefab;
    public Transform GotBombSpwLoc;
    public Transform GotAxeSpwLoc;

    public static int GotBomb;
    public static int GotAxe;

    private int BombCountDown;
    private int AxeCountDown;
    private int startBomb = 0;
    private int startAxe = 0;

    // Use this for initialization
    void Start()
    {
        GotAxe = 0;
        GotBomb = 0;
        BombCountDown = 3;
        AxeCountDown = 3;

    }

    // Update is called once per frame
    void Update()
    {

        if (GotBomb == 1)
        {
            Instantiate(GotBombPrefab, GotBombSpwLoc.position, GotBombSpwLoc.rotation);
            startBomb = 1;
            GotBomb = 0;
        }


        if (startBomb == 1)
        {
            BombCountDown -= 1;
            if (BombCountDown <= 0)
            {
                DestroyObject(GotBombPrefab);
            }


            if (GotAxe == 1)
            {
                Instantiate(GotAxePrefab, GotAxeSpwLoc.position, GotAxeSpwLoc.rotation);
                startAxe = 1;
                GotAxe = 0;
            }


            if (startAxe == 1)
            {
                AxeCountDown -= 1;
                if (AxeCountDown <= 0)
                {
                    DestroyObject(GotAxePrefab);
                }





            }
        }
    }
}
