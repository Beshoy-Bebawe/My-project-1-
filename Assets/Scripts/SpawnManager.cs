using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public GameObject[] animalPrefabs2;

    public GameObject[] animalPrefabs3;
    private float spawnRangeX = 10;
    private float spawnPosZ = 10;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    private float spawnPosX = 10;
    private float spawnRangeZ = 8;
    // Start is called before the first frame update
    void Start()
    {
     InvokeRepeating ("SpawnRandomAnimal" , startDelay, spawnInterval);   //start delay is a delay for it spawning or start having a delay and 
     
    }//spawn interval is the rate of them spawning 

    // Update is called once per frame
    void Update() // Randomly generates a animal index and spawn postiison in if statment InvokeRepeating statment removed the use of a keycode 
    {
            
           
            
    }


    void SpawnRandomAnimal()
    {
      int animalIndex = Random.Range(0, animalPrefabs.Length);// an array index and array length are defined in unity 
      //length starts from 1 index starts from 0
     Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);
     Instantiate(animalPrefabs[animalIndex], spawnpos, animalPrefabs[animalIndex].transform.rotation);
     Vector3 spawnpos2 = new Vector3(spawnPosX,0,Random.Range(-spawnRangeZ,spawnRangeZ));// right
     Instantiate(animalPrefabs2[animalIndex],spawnpos2, animalPrefabs2[animalIndex].transform.rotation);
     Vector3 spawnpos3 = new Vector3(-spawnPosX,0,Random.Range(-spawnRangeZ,spawnRangeZ));// left
     Instantiate(animalPrefabs3[animalIndex],spawnpos3, animalPrefabs3[animalIndex].transform.rotation);

    }
}
