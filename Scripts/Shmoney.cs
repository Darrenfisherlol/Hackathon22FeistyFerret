using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shmoney : MonoBehaviour
{
    float maxtime;
    float timer;

    public GameObject ShmoneyBarrel;
    // Start is called before the first frame update
    void Start()
    {
        maxtime = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= maxtime)
        {
            GenerateShmoney();
            timer = 0;
        }
    }

    void GenerateShmoney()
    {
        GameObject newObstacle = Instantiate(ShmoneyBarrel);
    }
}
