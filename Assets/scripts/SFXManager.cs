using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
   public static SFXManager instance = null; 

   public GameObject CoinParticles; 

   void Awake(){
       if (instance ==null){
           instance = this;
       }
   }

   public void ShowCoinParticles(GameObject obj){
       GameObject particles = Instantiate (CoinParticles, obj.transform.transform.position, Quaternion.identity);
       GameObject tape = GameObject.Find ("tape");
       particles.transform.SetParent(tape.transform);
       
   }
}
