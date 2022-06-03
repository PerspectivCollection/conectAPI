using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//libaryservices
using SingletonCreatePice;


public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        SingletonPice instance  = SingletonPice.Instance;

        instance.TestSingleton();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        
    }
}
