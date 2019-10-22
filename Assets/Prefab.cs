using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class Prefab : MonoBehaviour
{
    //verschiedene Containertypen
    public GameObject BSHC2600BC2430 = null;
    public GameObject[] listContainer;

    private int weite = 3;
    private int hoehe = 2;

    public float breiteBSHC2600BC2430 = 2.44f;
    public float hoeheBSHC2600BC2430 = 2.6f;
    private string test = "test";
    private bool canRotate = false;

    //[DllImport("__Internal")]
    //private static extern void SendToJavscript(string test);


    // Start is called before the first frame update
    void Start()
    {
		set_hoehe(3);
		set_weite(3);
        this.showContainer();
        //SendToJavscript(this.test);

    }
    // Update is called once per frame
    void Update()
    {
        if (canRotate == true && listContainer != null)
        {
             for (int k = 0; k < (hoehe * weite); k++)
            {

            listContainer[k].transform.Rotate(0, 0.5f, 0);
            }

        }

    }
    public void set_hoehe(int hoehe)
    {
        this.hoehe = hoehe;
        Instantiate(BSHC2600BC2430, new Vector3(0, 0, 0), Quaternion.identity);
    }
    public void set_weite(int weite)
    {
        this.weite = weite;

    }
    private void showContainer()
    {
        float summeWeite = 0f;
        float summeHoehe = 0f;
        //Nummerierung der Container in Array jetzt anders herum --> ändern?
        int anzahlContainer = hoehe * weite;
        listContainer = new GameObject[anzahlContainer];
        int i;
        for (int j = 0; j < hoehe; j++)
        {
            for (i = 0; i < weite; i++)
            {
               
                listContainer[anzahlContainer - 1] = Instantiate(BSHC2600BC2430, new Vector3(summeWeite, summeHoehe, 0), Quaternion.identity) as GameObject;
                summeWeite += breiteBSHC2600BC2430;
                anzahlContainer--;
            }
            summeWeite = 0f;
            summeHoehe += hoeheBSHC2600BC2430;
        }
    }


    public void drehungStart()
    {
        canRotate = true;
    }
    public void drehungStop()
    {
        canRotate = false;
    }
	public float getWeite()
	{
		return (float)weite;
	}
	public float getHoehe()
	{
		return (float)hoehe;
	}
	public float getBreiteCont()
	{
		return breiteBSHC2600BC2430;
	}
	public float getHoeheCont()
	{
		return hoeheBSHC2600BC2430;
	}


}