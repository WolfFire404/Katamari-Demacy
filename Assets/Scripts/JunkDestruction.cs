using UnityEngine;
using System.Collections;

public class JunkDestruction : MonoBehaviour
{
    void Start()
    {
        DestroyObject(gameObject, 5.0f);
    }
}
