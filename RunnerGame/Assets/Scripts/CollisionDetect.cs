using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetect : MonoBehaviour
{

    public PlayerController playerController;

    public UIManager uiManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) //metoda ktora zostaje wykonana na wejsciu w kolizje
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            //Debug.Log("dosz�o do kolizji z przeszkoda");

            if (playerController.playerHasSHield) //if playerhasshield=true
            {
                playerController.playerHasSHield = false;
                playerController.shieldGameObject.SetActive(false);
                uiManager.shieldIcon.gameObject.SetActive(false);
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name); //�aduje aktualnie aktywn� scen� od nowa
            }
        }

        if (collision.gameObject.tag == "Shield")
        {
            //Debug.Log("zebrano tarcz�");
            if (playerController.playerHasSHield == false)
            {
                playerController.playerHasSHield = true;
                playerController.shieldGameObject.SetActive(true);
                uiManager.shieldIcon.enabled = true;
                playerController.shieldAudioSource.PlayOneShot(playerController.shieldSound);
                Destroy(collision.gameObject);
            }
            if (playerController.playerHasSHield == true)
            {
                playerController.shieldAudioSource.PlayOneShot(playerController.shieldSound);
                playerController.points = playerController.points + 5;
                Destroy(collision.gameObject);
            }
        }
    }
}
