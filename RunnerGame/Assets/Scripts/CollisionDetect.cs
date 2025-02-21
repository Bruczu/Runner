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
            //Debug.Log("dosz³o do kolizji z przeszkoda");

            if (playerController.playerHasSHield) //if playerhasshield=true
            {
                playerController.playerHasSHield = false;
                playerController.shieldGameObject.SetActive(false);
                uiManager.shieldIcon.enabled = false;
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name); //³aduje aktualnie aktywn¹ scenê od nowa
            }
        }

        if (collision.gameObject.tag == "Shield")
        {
            //Debug.Log("zebrano tarczê");
            playerController.playerHasSHield = true;
            playerController.shieldGameObject.SetActive(true);
            uiManager.shieldIcon.enabled = true;
            Destroy(collision.gameObject);
        }
    }
}
