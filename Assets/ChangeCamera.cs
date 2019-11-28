using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{

	public GameObject target;//the target object
	private float speedMod = 2.0f;//a speed modifier
	private bool anhalten = true;
	public Prefab prefab;
	private Vector3 point;

	int counter = 1;

	void Start()
    {
		point = new Vector3(prefab.getWeite() * prefab.getBreiteCont() * 0.5f, prefab.getHoehe()* prefab.getHoeheCont() * 0.5f, 3.1f);
		target.transform.position = new Vector3(prefab.getWeite() * prefab.getBreiteCont() * 0.5f, prefab.getHoehe() * prefab.getHoeheCont() * 0.5f, -16.5f);
	}

    // Update is called once per frame
    void Update()
    {
		if (anhalten == false)
		{
			target.transform.RotateAround(point, new Vector3(0.0f, 1.0f, 0.0f), 20 * Time.deltaTime * speedMod);
		}
	}
	public void setAnhalten()
	{
		if(anhalten == true)
		{
			anhalten = false;
		} else
		{
			anhalten = true;
		}
	}
}
