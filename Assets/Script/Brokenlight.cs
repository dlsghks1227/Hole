using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brokenlight : MonoBehaviour
{
    public Light light;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1.4f)
        {
            light.range = 0.0f;
            if (timer >= Random.Range(1.5f, 5.5f))
            {
                light.range = 15.0f;
                timer = 0.0f;
            }
        }

    }
}
