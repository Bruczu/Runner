using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
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
            Debug.Log("dosz³o do kolizji");
        }
    }
}
