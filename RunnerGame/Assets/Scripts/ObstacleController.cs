using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //localposition, gdyby chodzi o pozycjê wzglêdêm grupy do której nale¿y
        if (transform.position.z < -2.5f)
        {
            playerController.points++;
            Destroy(gameObject);
        }
    }
}
