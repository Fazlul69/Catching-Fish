using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookScripts : MonoBehaviour
{
    public GameObject startPoint, endPoint;
    public LineRenderer hookRenderer;
    // Start is called before the first frame update
    void Start()
    {
        hookRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
      
        createLine();

        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            endPoint.transform.position = Vector3.MoveTowards(endPoint.transform.position, mousePos, Time.deltaTime * 5);
        }
        else {

            endPoint.transform.position = Vector3.MoveTowards(endPoint.transform.position, startPoint.transform.position, Time.deltaTime * 5);
        }
       
    }

    private void createLine() {

        hookRenderer.SetPosition(0,startPoint.transform.position);
        hookRenderer.SetPosition(1,endPoint.transform.position);
    }
}
