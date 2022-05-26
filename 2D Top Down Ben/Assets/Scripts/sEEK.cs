using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sEEK : MonoBehaviour
{
    public Transform target;

    private Rigidbody2D rb2;

    public float thrustScale;


    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = new Vector2(target.transform.position.x - transform.position.x, target.transform.position.y - transform.position.y);
        transform.up = direction;

        //MoveForward
        rb2.AddForce(transform.up * thrustScale * Time.deltaTime);
    }
}
