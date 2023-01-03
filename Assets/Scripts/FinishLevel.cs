using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class FinishLevel : MonoBehaviour
{

    public TextMeshProUGUI congratsText;
     void OnTriggerEnter(Collider other)
    {
        if(other.tag == "finish")
        {
            congratsText.text = "WELL DONE";

            Invoke("ReloadScene", 1);

        }
        if(other.tag == "failed")
        {
            Invoke("ReloadFailedScene", 1);
        }
    }
    public void ReloadFailedScene()
    {
        congratsText.text = "YOU FAILED!";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
