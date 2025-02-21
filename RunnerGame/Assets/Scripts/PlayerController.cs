using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float PlayerSpeed = 2f;

    public Animator animator;

    public int points = 0;

    public GameObject shieldGameObject;

    public bool playerHasSHield = false;

    public AudioClip jumpSound;
    public AudioSource jumpAudioSource;

    public AudioClip backgroundMusic;
    public AudioSource soundTrackAudioSource;

    public AudioClip shieldSound;
    public AudioSource shieldAudioSource;

    void Start()
    {
        shieldGameObject.SetActive(false);
        playerHasSHield = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -4f)
            {
                transform.Translate(Vector3.left * Time.deltaTime * PlayerSpeed);
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 4f)
            {
                transform.Translate(Vector3.right * Time.deltaTime * PlayerSpeed);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.Play("Jump");

            if (jumpAudioSource.isPlaying)
            {

            }
            else
            {
                jumpAudioSource.PlayOneShot(jumpSound);
            }
            
        }
    }
}
