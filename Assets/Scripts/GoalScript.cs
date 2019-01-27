using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Collider2D))]
public class GoalScript : MonoBehaviour {
    private void Awake()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Movement m = collision.GetComponent<Movement>();
        if (m != null) m.Win();
    }    
}
