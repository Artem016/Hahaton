using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerOpengamer : MonoBehaviour
{
    [SerializeField] private string _uraniumTag = "uranium";
    
     static private int _uraniumCounter = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        ColectingUranium(other);
    }

    private void ColectingUranium(Collider2D other)
    {
        if (other.CompareTag(_uraniumTag))
        {
            other.gameObject.SetActive(false);
            _uraniumCounter++;
        }
    }

    static public int GetUraniumCounter()
    {
        return _uraniumCounter;
    }
}
