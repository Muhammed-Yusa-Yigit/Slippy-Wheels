using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WaypointConteiner : MonoBehaviour
{
    public List<Transform> Waypoints;
    // Start is called before the first frame update
    void Awake()
    {
        foreach (Transform tr in gameObject.GetComponentsInChildren<Transform>())
        {
            Waypoints.Add(tr);
        }
        Waypoints.Remove(Waypoints[0]);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
     
