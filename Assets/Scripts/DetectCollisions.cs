using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

   
    PlayerController2 player;
    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController2>();
 
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {   if(other.CompareTag("Banana"))
        { 
         player.UpdateScore(0);
         Destroy(gameObject);
         
         
        }
        
        if (other.CompareTag("Player"))
        {
            player.UpdateLives(0);
            
        }

        

    }     
     
    
   
}
