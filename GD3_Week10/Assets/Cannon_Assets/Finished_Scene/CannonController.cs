using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    public float BallSpeed = 100f;
    public GameObject ballPrefab;
    public Transform ShootPoint;
   
    
    AudioSource audioSource;
    public AudioClip shotSound;
   
    // Start is called before the first frame update

    private void Start()
    {
        audioSource = GetComponent<AudioSource>(); //gets the audio of the cannon
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //using the shoot method
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject ball = Instantiate(ballPrefab, ShootPoint.position, ShootPoint.rotation); //spawning the ball

        Rigidbody rb = ball.GetComponent<Rigidbody>(); //gets the rigidbody of the cannon ball

        rb.AddForce(ShootPoint.forward * BallSpeed); //adding force to the cannon ball
         
        audioSource.PlayOneShot(shotSound); // plays the audioclip

        Destroy(ball, 5f); //destroys the balls after 5 seconds
    }
}
