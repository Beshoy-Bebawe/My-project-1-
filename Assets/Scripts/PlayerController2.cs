using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10;
    public float zRange = 10;
    public float forwardInput;
    public int score = 0;
    public int lives = 3;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * forwardInput * Time.deltaTime * speed);

        if (transform.position.x < -xRange ) 
    {
     transform.position = new Vector3( -xRange,transform.position.y, transform.position.z);

    }
          if (transform.position.x > xRange ) 
    {
     transform.position = new Vector3( xRange,transform.position.y, transform.position.z);



    }
         if (transform.position.z < -zRange)
         {
            transform.position = new Vector3(transform.position.x, transform.position.y , -zRange);

         }  
         if (transform.position.z > zRange)
         {

            transform.position = new Vector3(transform.position.x,transform.position.y , zRange);

         }

        if (Input.GetKeyDown(KeyCode.Space))

        {//if space key is pressed down then  launch a projectile delcared from the player
            Instantiate(projectilePrefab , transform.position , projectilePrefab.transform.rotation);

        }
        
}
  public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        Debug.Log("Score:" + score);
        
    }

}