using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
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


    }
}
