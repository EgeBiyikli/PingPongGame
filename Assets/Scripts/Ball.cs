using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public Rigidbody2D rb;
    public float speed;
   

    public Vector3 startPosition;

    void Start () {
        startPosition = transform.position;
        Launch();
    }
    public void Reset() {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        Launch();
    }

    private void Launch() {
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }
    
    
}
