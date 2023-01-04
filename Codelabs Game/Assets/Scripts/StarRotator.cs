using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarRotator : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(5, 20, 40) * Time.deltaTime);
    }
}
