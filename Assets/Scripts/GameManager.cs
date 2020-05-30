using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject deactivationObject;
    public Move_Sprite scriptDeactivation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Hitting the ESC button will exit the game.
            Application.Quit();
            Debug.Log("Let's get this bread!");
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            //Having the P button pressed will deactivate the assigned object and script to "Pause" the sprite.
            scriptDeactivation.enabled = !scriptDeactivation.enabled;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //Pressing Q will disable the sprite and pressing it again will reenable the sprite.
            deactivationObject.SetActive(!deactivationObject.activeInHierarchy);
        }
    }
}
