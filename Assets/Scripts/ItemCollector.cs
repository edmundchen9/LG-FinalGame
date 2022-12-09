using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private Text sheepText;

    [SerializeField] private Text heartText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Sheep"))
        {
            Destroy(collision.gameObject);
            sheepText.text = "Favorite Plushy Collected: Yes";
        }
        
        if (collision.gameObject.CompareTag("Heart"))
        {
            Destroy(collision.gameObject);
            heartText.text = "Love and Care Collected: Yes";
        }
    }
}
