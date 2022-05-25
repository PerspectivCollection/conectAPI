using UnityEngine;
using System.Collections;


public interface IKilleblen{
        void Kill();
    }


    public interface IDamage<T>{
        void Damage(T damageTaken);
    }


public class Avatar : MonoBehaviour, IKilleblen, IDamage<float>
{
    //do somthing

    public void Kill(){
        //do somthing
    }

    public void Damage(float damageTaken){
        //do somthing
    }
}