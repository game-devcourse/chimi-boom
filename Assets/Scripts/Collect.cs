using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    /**
    in this script we check if the player encounter a certain object with a giving tag if it does then the tag addad to the matirials
    list and get destroy.
    */
    [SerializeField] string triggeringTag;
    public static List<string> matirials;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(triggeringTag))
        {
            matirials.Add(triggeringTag);
            Destroy(other.gameObject);
        }
    }
}
