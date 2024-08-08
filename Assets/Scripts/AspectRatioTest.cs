using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AspectRatioTest : MonoBehaviour
{
    public GameObject torre1;
    public GameObject torre2;
    public GameObject resource_bar_p1;
    public GameObject resource_bar_p2;
    public Camera camera;
    public float aspect;
    public GameObject uiresources;

    public GameObject uiresources1;
    public GameObject base1;
    public GameObject base2;

    // Start is called before the first frame update
    void Start()
    {
       camera=GetComponent<Camera>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (camera.aspect <= 1.78f){
            torre1.transform.position=new Vector3(1.40999997f,7.12605667f,0);
            torre1.transform.localScale=new Vector3(0.85215801f,0.975874901f,1);

            torre2.transform.position=new Vector3(19.3999996f,7.14212608f,0);
            torre2.transform.localScale=new Vector3(0.852157831f,0.975874901f,1);


            resource_bar_p1.transform.position=new Vector3(5.26000023f,0.752200007f,0);
            resource_bar_p1.transform.localScale=new Vector3(0.99000001f,1.02625382f,0.913249493f);

            resource_bar_p2.transform.position=new Vector3(15.4499998f,0.756399989f,0);
            resource_bar_p2.transform.localScale=new Vector3(0.99000001f,1.03744912f,0.887098849f);

            uiresources.transform.position=new Vector3(3.54999995f,2.25f,0);
            uiresources.transform.localScale=new Vector3(0.850000024f,1.00772023f,0.849443555f);

            uiresources1.transform.position=new Vector3(17.2999992f,2.25f,0);
            uiresources1.transform.localScale=new Vector3(0.850000024f,1.00772023f,0.849443555f);

            base1.transform.position=new Vector3(2.08999991f,7.09749985f,0);
            base1.transform.localScale=new Vector3(1.39999998f,0.75999999f,1);

            base2.transform.position=new Vector3(18.7000008f,7.09910011f,0);
            base2.transform.localScale=new Vector3(1.39999998f,0.75999999f,1);
        }
        else{
            /* torre1.transform.position=new Vector3(0.853553057f,7.12605667f,0);
            torre2.transform.position=new Vector3(19.9216309f,7.14212608f,0);
            resource_bar_p1.transform.position=new Vector3(4.59689999f,0.748199999f,0);
            resource_bar_p2.transform.position=new Vector3(16.0529003f,0.750999987f,0); */
            
            torre1.transform.position=new Vector3(1.40999997f,7.12605667f,0);
            torre1.transform.localScale=new Vector3(0.85215801f,0.975874901f,1);

            torre2.transform.position=new Vector3(19.3999996f,7.14212608f,0);
            torre2.transform.localScale=new Vector3(0.852157831f,0.975874901f,1);

            resource_bar_p1.transform.position=new Vector3(5.26000023f,0.752200007f,0);
            resource_bar_p1.transform.localScale=new Vector3(0.99000001f,1.02625382f,0.913249493f);

            resource_bar_p2.transform.position=new Vector3(15.4499998f,0.756399989f,0);
            resource_bar_p2.transform.localScale=new Vector3(0.99000001f,1.03744912f,0.887098849f);

            uiresources.transform.position=new Vector3(3.54999995f,2.25f,0);
            uiresources.transform.localScale=new Vector3(0.850000024f,1.00772023f,0.849443555f);

            uiresources1.transform.position=new Vector3(17.2999992f,2.25f,0);
            uiresources1.transform.localScale=new Vector3(0.850000024f,1.00772023f,0.849443555f);

            base1.transform.position=new Vector3(2.08999991f,7.09749985f,0);
            base1.transform.localScale=new Vector3(1.39999998f,0.75999999f,1);

            base2.transform.position=new Vector3(18.7000008f,7.09910011f,0);
            base2.transform.localScale=new Vector3(1.39999998f,0.75999999f,1);
        }
        aspect = camera.aspect;
    }
}
