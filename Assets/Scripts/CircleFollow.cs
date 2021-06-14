using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleFollow : MonoBehaviour
{
    [SerializeField]
    private GameObject pug;

    private void Update()
    {
        transform.position = pug.transform.position;
    }
}
