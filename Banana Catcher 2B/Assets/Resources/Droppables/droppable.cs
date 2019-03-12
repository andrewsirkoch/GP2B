using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droppable : MonoBehaviour
{
    public GameObject monkey;

    // Start is called before the first frame update
    private void Awake()
    {
        monkey = GameObject.Find("monkey");
        gameObject.transform.position = new Vector3(monkey.transform.position.x, monkey.transform.position.y - 1.5f, monkey.transform.position.z);
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(monkey.GetComponent<monkeyMovement>().direction.x * Random.Range(50, 150), 0));
        gameObject.GetComponent<Rigidbody2D>().AddTorque(Random.Range(-25, 25));
    }
}
