using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//libaryservices
using UtilityLibraries; 

using Content4API.Scripts;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string input = "Hei";
        Debug.Log(input.StartsWithUpper());

        TurnaroundPlayer somO = new TurnaroundPlayer();
        somO.OnePlay(); 
        // ScoreBoard.ForOneMore();

        Avatar avatarO = new Avatar();
        Debug.Log(avatarO);
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void FixedUpdate()
    {
        
    }
}
