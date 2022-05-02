using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour{

    public GameObject Bullet;
    public float BulletSpeed;
    public Transform ShootPoint;
    Vector2 Direction;
    GameObject target;
    public AudioSource audios;
    public AudioSource Sound;
    public GameObject shootParticle;

    public class AudioScript : MonoBehaviour
    {
        AudioSource audiosource;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Direction = MousePos - (Vector2)transform.position;

        FaceMouse();

        if(Input.GetMouseButtonDown(0))
        {
                Shoot();
                audios.Play();
        }

        if (Input.GetMouseButtonDown(1))
        {
            Sound.Play();
            Release();
        }

        
    }

    void FaceMouse()
    {
        transform.right = Direction;
    }

    void Shoot()
    {
        GameObject BulletIns = Instantiate(Bullet, ShootPoint.position, Quaternion.identity);

        BulletIns.GetComponent<Rigidbody2D>().AddForce(transform.right * BulletSpeed);
        Instantiate(shootParticle, ShootPoint.position, Quaternion.identity);

    }

    public void TargetHit(GameObject hit)
    {
        target = hit;
        Sound.Play();
    }

    void Release()
    {
        target = null;
    }
}
