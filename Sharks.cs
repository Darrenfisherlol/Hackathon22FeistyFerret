using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sharks : MonoBehaviour
{
    float maxtime;
    float timer;

    public GameObject SharkObstacle;
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
            GenerateShark();
            timer = 0;
        }
    }

    void GenerateShark()
    {
        GameObject newObstacle = Instantiate(SharkObstacle);
    }
    
}
