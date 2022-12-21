using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectGolds : MonoBehaviour
{

   
    float score;
     void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Gold")
        {
            other.gameObject.SetActive(false);
            score++;
        }

        
    }
}
