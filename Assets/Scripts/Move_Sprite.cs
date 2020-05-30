using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Sprite : MonoBehaviour
{
    //This public float is to edit the numbers within the engine.
    public float speedySpeedBoi = 0.1f;
    private float speedMultiplyer = 2;
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Once the space bar has been pressed it moves the character to the origin point of the area.
            transform.position = new Vector2(0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //This if stament moves the sprite up once the up arrow key has been pressed.
            transform.position += Vector3.up * speedySpeedBoi * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //This if stament moves the sprite right once the right arrow key has been pressed.

            transform.position += Vector3.right * speedySpeedBoi * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //This if stament moves the sprite down once the down arrow key has been pressed.

            transform.position += Vector3.down * speedySpeedBoi * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //This if stament moves the sprite left once the left arrow key has been pressed.
            transform.position += Vector3.left * speedySpeedBoi * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift) && speedySpeedBoi != speedySpeedBoi*speedMultiplyer)
        {
            //This if stament makes the sprite go twice as fast when the left shift button.
            speedySpeedBoi *= speedMultiplyer;


        }
        else if (Input.GetKeyUp(KeyCode.LeftShift) && speedySpeedBoi != speedySpeedBoi / speedMultiplyer)
        {
            //The else statement has it that once the key not been pressed it returns the value of the speed.
            speedySpeedBoi /= speedMultiplyer;
        }
    }
}
