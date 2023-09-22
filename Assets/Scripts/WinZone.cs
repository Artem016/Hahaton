using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinZone : MonoBehaviour
{
    [SerializeField] GameObject winWindow;
    public string targetTag = "player";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(targetTag))
        {
            Time.timeScale = 0f;
            winWindow.SetActive(true);
        }
    }
}
