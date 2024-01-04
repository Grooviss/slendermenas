using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageManager : MonoBehaviour
{
    public int pages;
    public Enemy enemy;
    public Animator animator;
    public AudioSource scary;
    public GameObject enemy2;
    public FirstPersonMovement runSpeed;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        pages++;
        if (pages == 1) ;
        {
            //ai wake up
            enemy.target = transform;

        }
        if (pages == 2) ;
        {
            enemy.speed *= 2;

        }
        if (pages == 3) ;
        {
            enemy.viewDistance *= 2;
        }
        if (pages == 4) ;
        {

            enemy2.SetActive(true);
        }
        if (pages == 5) ;
        {
            runSpeed.runSpeed = 0;
        }
    }
}
