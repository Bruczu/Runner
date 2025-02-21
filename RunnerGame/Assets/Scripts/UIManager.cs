using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public PlayerController playerController;
    public TMP_Text playerPointsValue;

    public Image shieldIcon;
    // Start is called before the first frame update
    void Start()
    {
        shieldIcon.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        playerPointsValue.text = playerController.points.ToString();
    }
}
