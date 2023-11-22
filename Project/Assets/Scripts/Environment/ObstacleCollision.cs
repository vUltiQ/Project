using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ObstacleCollision : MonoBehaviour
{    
    public GameObject thePlayer;
    public GameObject charModel;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;

    void OnTriggerEnter(Collider other)
    {	
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<PlayerMovement>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble Backwards");

        StartCoroutine(ShowGameOverAfterDelay());
    }

    IEnumerator ShowGameOverAfterDelay()
    {
        yield return new WaitForSeconds(1.5f); // 1.5-second delay

            gameOverText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
        
    }
}
