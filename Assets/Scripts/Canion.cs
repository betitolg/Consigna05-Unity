using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canion : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject bulletPreFab;
    
    public float delaySpawn = 2f;
    public float intervaleSpawn = 2f;
 
    public Vector3 direction= new Vector3(1f, 2f, 4f);
  
    
    
    void Start()
    {
        InvokeRepeating("Disparo", delaySpawn, intervaleSpawn);

        
        
    }

    private void Disparo()
    {
      
        Instantiate(bulletPreFab, transform);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
