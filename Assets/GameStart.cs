using UnityEngine;
using System.Collections;

public class GameStart : MonoBehaviour {
    [SerializeField]
    private float borderWeight = 2f;
    [SerializeField]
    private GameObject border;
    [SerializeField]
    private GameObject BordersWrapper;

    private float border_top;
    private float border_right;
    private float border_bottom;
    private float border_left;

    // Use this for initialization
    void Start () {
        //find border's positions
        Vector3 screenStart = Camera.main.ScreenToWorldPoint(new Vector3(0f, 0f, 0f));
        border_left = screenStart.x;
        border_bottom = screenStart.y;

        Vector3 screenEnd = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        border_right = screenEnd.x;
        border_top = screenEnd.y;

        PlaceBorders();
    }

    private void PlaceBorders()
    {
        //TODO
        //
        //LENGTH OF BORDERS

        //left
        GameObject leftB = (GameObject)Instantiate(border, new Vector3(border_left - borderWeight/2, 0f, 0f), Quaternion.identity);
        leftB.GetComponent<BoxCollider2D>().size = new Vector3(borderWeight, 100f, 2f);
        leftB.transform.parent = BordersWrapper.transform;
        //right
        GameObject rightB = (GameObject)Instantiate(border, new Vector3(border_right + borderWeight / 2, 0f, 0f), Quaternion.identity);
        rightB.GetComponent<BoxCollider2D>().size = new Vector3(borderWeight, 100f, 2f);
        rightB.transform.parent = BordersWrapper.transform;
        //top
        GameObject topB = (GameObject)Instantiate(border, new Vector3(0f, border_top - borderWeight/2, 0f), Quaternion.identity);
        topB.GetComponent<BoxCollider2D>().size = new Vector3(100f, borderWeight, 2f);
        topB.transform.parent = BordersWrapper.transform;
    }
	
	// Update is called once per frame
	void Update () {
	    
	}
}
