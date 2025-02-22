using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float PlayerSpeed;

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

    public bool isJumping = false;
    public int heightChange = 0;

    //public bool isJumping = false;

    void Start()
    {
        shieldGameObject.SetActive(false);
        playerHasSHield = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

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

        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W))
        {
            //
            if (isJumping == false)
            {
                isJumping = true;
                //
                animator.Play("Jump");

                if (jumpAudioSource.isPlaying)
                {

                }
                else
                {
                    jumpAudioSource.PlayOneShot(jumpSound);
                }
                //
                StartCoroutine(JumpSequence());
                //
            }
        }
        //
        if (isJumping == true)
        {
            if (heightChange == 0)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 3);
            }
            if (heightChange == 1)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 0);
            }
            if (heightChange == 2)
            {
                transform.Translate(Vector3.up * Time.deltaTime * -3);
            }
        }
        //
    }
    //
    IEnumerator JumpSequence()
    {
        yield return new WaitForSeconds(0.45f);
        heightChange = 1;
        yield return new WaitForSeconds(0.6f);
        heightChange = 2;
        yield return new WaitForSeconds(0.45f);
        isJumping = false;
        heightChange = 0;
    }
    //
}
