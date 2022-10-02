using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Give the object a collider, and you can use OnMouseOver/OnMouseExit
public class ShakeOnHoverAnimation : MonoBehaviour
{
    public const float speed = 2.0f;
    public const float intensity = 0.1f;
      
     void OnMouseOver()
    {
        transform.localPosition = intensity * new Vector2(
            Mathf.PerlinNoise(speed * Time.time, 1),
            Mathf.PerlinNoise(speed * Time.time, 2));
    }
}
