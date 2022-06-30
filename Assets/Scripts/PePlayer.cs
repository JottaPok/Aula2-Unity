using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PePlayer : MonoBehaviour
{

    public static bool TaVoando = true;
   
    void OnCollisionEnter2D(Collision2D colide)
    {
       if(colide.gameObject.tag == "Chao")
       {
           TaVoando = false;
       } 
      
    }
    void OnCollisionExit2D(Collision2D colide)
    {
       if(colide.gameObject.tag == "Chao")
       {
           TaVoando = true;
           
       } 
    }
}
