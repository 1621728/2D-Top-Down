using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject bullet;
    public AudioSource aud;
    public GameObject collide;
    private Rigidbody2D rb2;
    public float dizzySpeed;

    // Start is called before the first frame update
    // void Start()
    // {
    //     gun = GameObject.FindGameObjectWithTag("Gun").GetComponent<GunScript>();
    // }

    void Start()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(ExampleCoroutine());

    }

    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);
        Destroy(this.gameObject);
        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    private void Update()
    {
        //if (rb2.velocity.magnitude != dizzySpeed)
        //{
        //    aud.Play();
        //    Instantiate(collide, bullet.transform);
        //}
        //if (rb2.velocity.magnitude != -dizzySpeed)
        //{
        //    aud.Play();
        //    Instantiate(collide, bullet.transform);
        //}
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        aud.Play();
        Instantiate(collide, bullet.transform);
    }
}
