using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class Prefab : MonoBehaviour
{
    //verschiedene Containertypen
    public GameObject BSHC2600BC2430 = null;
    public GameObject BSHC2600BC3000 = null;
    public GameObject BStHC2800BC2430 = null; 
    public GameObject BSHC2800BC3000 = null; 
    public GameObject BSHC2960BC2430 = null;
    public GameObject BSHC2960BC3000 = null; 

    public GameObject[] listContainer;

    private int weite = 0;
    private int hoehe = 0;

    public float breiteBSHC2600BC2430 = 2.44f;
    public float hoeheBSHC2600BC2430 = 2.6f;
    private string test = "test";
    private bool canRotate = false;

    //[DllImport("__Internal")]
    //private static extern void SendToJavscript(string test);


    // Start is called before the first frame update
    void Start()
    {
        this.set_hoehe(2);
        this.set_weite(2);
  



    }
    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                GameObject clickedObject = hit.collider.gameObject;
                Debug.Log(clickedObject.transform.name);
            }
        }

    }
   // void OnMouseDown() {
     //   Debug.Log("clicked");
    //}

    public void set_hoehe(int hoehe)
    {
  
        this.hoehe = hoehe;
      
    }
    public void set_weite(int weite)
    {
        this.weite = weite;
        showContainer();

    }
    private void showContainer()
    {
        float summeWeite = 0f;
        float summeHoehe = 0f;

        int anzahlContainer = 0;
        listContainer = new GameObject[hoehe * weite];
        int i;
        for (int j = 0; j < hoehe; j++)
        {
            for (i = 0; i < weite; i++)
            {
               
                listContainer[anzahlContainer] = Instantiate(BSHC2600BC2430, new Vector3(summeWeite, summeHoehe, 0), Quaternion.identity) as GameObject;
                listContainer[anzahlContainer].transform.name = anzahlContainer.ToString();
                listContainer[anzahlContainer].AddComponent<BoxCollider>();
                listContainer[anzahlContainer].GetComponent<BoxCollider>().size = new Vector3(2.44f, 2.6f, 5);
                


                summeWeite += breiteBSHC2600BC2430;
                anzahlContainer++;
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



}