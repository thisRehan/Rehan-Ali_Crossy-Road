using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject train;
    [SerializeField] GameObject van;
    [SerializeField] PlayerController player;
    private int spawnStart = 2;
    private int spawnDelay = 3;
   
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnStart, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn()
    {
        if (!player.GameOver)
        {
            Vector3 spawnRandom = new Vector3(train.transform.position.x, train.transform.position.y, Random.Range(1, 9));
            Instantiate(train, spawnRandom, train.transform.rotation);
            Vector3 spawnPosition = new Vector3(van.transform.position.x, van.transform.position.y, Random.Range(-1, -9));
            Instantiate(van, spawnPosition, van.transform.rotation);
        }
    }
  
}
