using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSorter : MonoBehaviour
{
    public float offset = 0;
    private int sortingOrderBase = 0;
    private Renderer render;

    private void Awake()
    {
        render = GetComponent<Renderer>();
    }
    private void LateUpdate()
    {
        render.sortingOrder = (int)(sortingOrderBase - transform.position.y + offset);
    }
}
