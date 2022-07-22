using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Vector3 startPos;
    public GameObject background;
    private float speed;
    private float posX;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.25f;
        startPos = new Vector3(-6,0,5);
        background.transform.position = startPos;
        posX = -6;
    }

    // Update is called once per frame
    void Update()
    {
        posX += speed*Time.deltaTime;
        background.transform.position = new Vector3(posX, 0, 5);
        //normalise^^
        
        if (posX >= 6)
        {
            posX = -6;
        }
    }
}
