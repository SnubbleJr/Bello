using UnityEngine;
using System.Collections;

public class SlowlyMoving : MonoBehaviour {

    public int speedX, speedY;
    public bool x, y;

    Vector3 pos;
    bool fade = false;

	// Use this for initialization
	void Start () {
        pos = transform.position;
	}
	
	// Update is called once per frame
    void Update(){
        if (x) transform.Translate(Time.deltaTime * speedX, 0, 0);
        if (y) transform.Translate(0, Time.deltaTime * speedY, 0);	

        if (fade)
        {
            Color color = renderer.material.color;
            color = Color.Lerp (color, Color.white, Time.deltaTime);
            renderer.material.color = color;
        }
	}

    void OnBecameInvisible()
    {
        transform.position = pos;
        fade = false;
    }

    void OnBecameVisible()
    {
        fade = true;
        renderer.material.color = Color.clear;
    }
}
