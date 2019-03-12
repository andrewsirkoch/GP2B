using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droppable : MonoBehaviour
{

    // Start is called before the first frame update
    private void Awake()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-100, 100), 0));
        gameObject.GetComponent<Rigidbody2D>().AddTorque(Random.Range(-25, 25));
    }
}
