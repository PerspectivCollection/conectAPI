using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class seanManager : MonoBehaviour
{
    void OnGUI()
    {
        //This displays a Button on the screen at position (20,30), width 150 and height 50. The button’s text reads the last parameter. Press this for the SceneManager to load the Scene.
        if (GUI.Button(new Rect(20, 30, 150, 30), "Play Conect4"))
        {
            //The SceneManager loads your new Scene as a single Scene (not overlapping). This is Single mode.
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        }

        //Whereas pressing this Button loads the Additive Scene.
        if (GUI.Button(new Rect(20, 60, 150, 30), "Play senario1"))
        {
            //SceneManager loads your new Scene as an extra Scene (overlapping the other). This is Additive mode.
            SceneManager.LoadScene("senario1", LoadSceneMode.Single);
        }
    }
}
