using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Vector3 direction = new Vector3(1f, 2f, 4f);
    public float speed = 2f;
    public float damage = 400f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    
    private void Move()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
    
}
