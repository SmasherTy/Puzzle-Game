using Unity.VisualScripting;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public bool KeyHandEquippable;

    private Transform keyHand;


    void Start()
    {
        keyHand = GameObject.Find("KeyHand").GetComponent<Transform>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (KeyHandEquippable == true)
            {
                transform.SetParent(keyHand);
            }
            transform.localPosition = Vector2.zero;
        }
    }
}

