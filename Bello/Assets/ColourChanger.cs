using UnityEngine;
using System.Collections;

public class ColourChanger : MonoBehaviour {

    public Color[] colors;
    public float duration = 1.0F;

    private int targetColorIndex;

	// Use this for initialization
	void Start () {

        renderer.material = new Material(renderer.material);

        if (colors.Length <= 1)
        {
            this.enabled = false;
            Debug.LogError("Not enough colors added!");
        }
        if (colors.Length == 1)
        {
            renderer.material.color = colors[0];
        }
        else
        {
            targetColorIndex = 1;
        }
	}
	
	// Update is called once per frame
    void Update()
    {
        float lerp = Time.deltaTime/duration;

        if (targetColorIndex > colors.Length-1)
            targetColorIndex = 0;

        renderer.material.color = Color.Lerp(renderer.material.color, colors[targetColorIndex], lerp);
        
        if (renderer.material.color == colors[targetColorIndex])
            targetColorIndex++;
	}
}
