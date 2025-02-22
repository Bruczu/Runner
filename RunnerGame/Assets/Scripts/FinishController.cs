using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FinishController : MonoBehaviour
{
    public UIManager manager;

    void Update()
    {
        if (transform.position.z < 0)
        {
            manager.background.gameObject.SetActive(true);
        }
    }
}
