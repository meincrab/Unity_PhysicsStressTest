using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int howMany;
    public GameObject Ball;
    public float xRange;
    public float zRange;
    public float y;
    public float spawnRate;
    public int spawned;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0f, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn()
    {
        if (spawned >= howMany)
        {

        }
        else
        {
            Instantiate(Ball, new Vector3(Random.Range(-xRange, xRange), y, Random.Range(-zRange, zRange)), Quaternion.identity);
            spawned += 1;
        }
       
    }
}
