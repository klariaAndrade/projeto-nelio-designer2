using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
   
   Rigidbody2D rb;

   void start(){
     rb = GetComponent<Rigidbody2D>();
   }
   
   void OnTriggerEnter2D (Collider2D other){
      
      if (other.gameObject.CompareTag("Coin")){
          SFXManager.instance.ShowCoinParticles(other.gameObject);
          AudioManager.instance.PlaySoundCoinPickup(other.gameObject);
          Destroy (other.gameObject);  
          LevelManager.instance.IncrementCoinCount();
          Impulse(100);
      }

       if (other.gameObject.CompareTag("gift")){
          AudioManager.instance.PlaySoundLevelComplete(gameObject);
          StopMusicandTape();
          Destroy(gameObject);
          LevelManager.instance.ShowLevelCompletePanel();
          

         
      }

        else if(other.gameObject.layer == LayerMask.NameToLayer("Enimes")) {
        KillPlayer();
      }

          else if(other.gameObject.layer == LayerMask.NameToLayer("Forbidden")) {
          KillPlayer();
      }
    }

   void StopMusicandTape(){
          Camera.main.GetComponentInChildren<AudioSource>().mute = true;
          LevelManager.instance.SetTapeSpeed(0);
   }
   
   
   void KillPlayer(){
          StopMusicandTape();
          AudioManager.instance.PlaySoundFail(gameObject);
          SFXManager.instance.ShowDieParticles(gameObject);
          Destroy(gameObject);
          LevelManager.instance.ShowGameOverPanel();
   }

   void Impulse (float force){
     rb.velocity = Vector3.zero;
     rb.AddForce(Vector3.up * force, ForceMode2D.Impulse);
   }
}

