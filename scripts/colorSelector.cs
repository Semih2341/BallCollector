using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorSelector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Color newColor= new Color( Random.value,Random.value,Random.value,1f);
        GetComponent<Renderer>().material.color = newColor;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void RenkDegis()
    {

        
            Color newColor = new Color(Random.value, Random.value, Random.value, 1f);
            GetComponent<Renderer>().material.color = newColor;
            Debug.Log("oldu");
        
    }
}
