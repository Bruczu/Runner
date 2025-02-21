using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>(); //automatycznie przypisuje gracza
    }

    // Update is called once per frame
    void Update()
    {
        //localposition, gdyby chodzi o pozycj� wzgl�d�m grupy do kt�rej nale�y
        if (transform.position.z < -2.5f)
        {
            playerController.points++;
            Destroy(gameObject);
        }
    }
}
