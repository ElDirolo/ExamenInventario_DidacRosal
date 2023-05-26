using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recogedor : MonoBehaviour
{
    public ScriptableIteam weapon;
    SpriteRenderer sRenderer;
    void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();
        sRenderer.sprite = weapon.iteamImage;
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        InventarioController.Instance.AddIteam(weapon);
        Destroy(gameObject);
    }
}
