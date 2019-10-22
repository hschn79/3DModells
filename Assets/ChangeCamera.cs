using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
	/*public GameObject cameraOne;
	public GameObject cameraTwo;

	AudioListener cameraOneLis;
	AudioListener cameraTwoLis;*/

	public GameObject target;//the target object
	private float speedMod = 2.0f;//a speed modifier
	private bool anhalten = true;
	public Prefab prefab;
	private Vector3 point;

	int counter = 1;

	void Start()
    {
		/*cameraOneLis = cameraOne.GetComponent<AudioListener>();
		cameraTwoLis = cameraTwo.GetComponent<AudioListener>();*/
		point = new Vector3(prefab.getWeite() * prefab.getBreiteCont() * 0.5f, prefab.getHoehe()* prefab.getHoeheCont() * 0.5f, 0.0f);
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

	/*public void switchCamera()
	{
		if(counter == 1)
		{
			cameraTwoLis.enabled = false;
			cameraTwo.SetActive(false);

			cameraOne.SetActive(true);
			cameraOneLis.enabled = true;
			counter++;
		} else if(counter == 2)
		{
			cameraTwoLis.enabled = true;
			cameraTwo.SetActive(true);

			cameraOne.SetActive(false);
			cameraOneLis.enabled = false;
			counter--;
		}
	} */
}
