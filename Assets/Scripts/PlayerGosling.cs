using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGosling : MonoBehaviour
{
    [SerializeField] private string gunTag = "gun";

    private void TakeGun(Collider2D collision)
    {
        if(collision.tag == gunTag)
        {
            collision.gameObject.SetActive(false);
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TakeGun(collision);
    }
}
