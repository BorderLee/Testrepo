using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientController : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseUp()
    {
        Hand.Instance.Grab(gameObject);
    }
}
