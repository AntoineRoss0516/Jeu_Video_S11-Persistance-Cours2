using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortailV2 : MonoBehaviour
{
    public int indexSceneACharger;

    public GameObject saveClick;
    private void OnTriggerEnter2D(Collider2D autre)
    {
        if (autre.CompareTag("Joueur"))
        {
            JeuEspaceV2.instance.ChangerScene(indexSceneACharger);
            JeuEspaceV2.instance.JouerSonPortail();
    

         
        
        // Si on a d�j� un singleton pr�t
      
            
        }
    }
}
