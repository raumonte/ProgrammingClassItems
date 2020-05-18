using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer renderSprite;
    // Start is called before the first frame update
    void Start()
    {
        renderSprite = gameObject.GetComponent<SpriteRenderer>();
        renderSprite.color = Color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
