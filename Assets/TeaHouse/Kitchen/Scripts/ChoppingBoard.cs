using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoppingBoard : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
        {
            Debug.Log("Trigger 발생: " + other.name);
        }
}