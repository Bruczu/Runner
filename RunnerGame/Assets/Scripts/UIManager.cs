using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public PlayerController playerController;
    public TMP_Text playerPointsValue;

    public TMP_Text BGPlayerPointsValue;

    public Image shieldIcon;

    public Image background;
    // Start is called before the first frame update
    void Start()
    {
        shieldIcon.gameObject.SetActive(false);
        background.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        playerPointsValue.text = playerController.points.ToString();
        BGPlayerPointsValue.text = playerController.points.ToString();
    }
}
