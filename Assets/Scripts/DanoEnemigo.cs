using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DanoEnemigo : MonoBehaviour
{


    void OnTriggerEnter(Collider other)
    {
      if(other.CompareTag("Enemy")) 
        { 

             SceneManager.LoadScene("GameOver");
            
        }


    }

    




}
