        using UnityEngine;
using System.Collections;

public class SlowlyRotate : MonoBehaviour {

	public int speed;
    public bool x, y;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if(x) transform.Rotate(Time.deltaTime * speed, 0, 0);
        if(y) transform.Rotate(0, Time.deltaTime * speed, 0, Space.World);
	}
}
