using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //creating a container(variable) to contain our player speed
    //RerializeField allows us to see private variables in the inspector
    [SerializeField]
    public float _speed = 3.5f;
    // Start is called before the first frame update
    void Start()
    {
        //take the current player and we will be changing it to x=0,y=0,z=0
        transform.position = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        //move the player to the right
        //realtime 
        //x * realtime (time.deltaTime) = 1m/s
        //1 * fps e.g 1 * 1500fps (this calculation is used when not multiplying by Time.deltaTime)
        
        //if we press the right arrow 
        if(Input.GetKey(KeyCode.RightArrow))
        {
            //move the player to the right
            transform.Translate(_speed * Time.deltaTime,0,0);
            //Moving to the right changes the colour of the player to blue
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            //move player to the left
            transform.Translate(-_speed * Time.deltaTime,0,0);
            //Moving to the left chnages the colour of the player to green
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    
        
    }
}
