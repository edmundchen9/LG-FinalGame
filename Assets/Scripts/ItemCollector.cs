using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private bool phoneCollected = false;
    [SerializeField] private Text phoneText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Phone"))
        {
            Destroy(collision.gameObject);
            phoneCollected = true;
            phoneText.text = "Phone Collected: Yes";
        }
    }
}
