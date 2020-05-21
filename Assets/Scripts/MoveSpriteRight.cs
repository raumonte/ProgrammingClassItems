using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpriteRight : MonoBehaviour
{
    //This public float is to edit the numbers within the engine.
    public float Speedyspeedboi = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*This part of the code tells the object which direction they should go. 
         *While also taking in the framerate of the game and input of the developer to get the speed of the object.
        */
        transform.position += Vector3.right* Speedyspeedboi* Time.deltaTime;
    }
}
