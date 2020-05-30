using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu_Interact : MonoBehaviour
{
        public void enterScene ()
    {
        //Once the play button has been pressed it will get the player to the next scene over.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
        public void exitScene ()
    {
        //Using this void I will be able to assign it to the button to exit the game once the button is pressed.
        Debug.Log("It has been pressed!");
        Application.Quit();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
