using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//testing 
public sealed class Singelton : MonoBehaviour{
    
    private Singelton() {
        
        // GameObject some = new GameObject("called_Singelton"); //create a game obj
        
        }  

        


    private static readonly Singelton instance = new Singelton();  
    public static Singelton Instance {  
        get {  
            // if (instance == null) {  
            //     instance = new Singelton();  
            // }  
            return instance;  
        }  
    } 
}





// class Program {  
//         static void Main(string[] args) {  
//             Singleton obj1 = Singleton.Instance();  
//             Singleton obj2 = Singleton.Instance();  
//             if (obj1 == obj2) {  
//                 Debug.Log("We both are once instance having two names");  
//             }  
//             Console.ReadKey();  
//         }  
//    }  
