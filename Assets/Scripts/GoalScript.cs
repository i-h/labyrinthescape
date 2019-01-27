using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Collider2D))]
public class GoalScript : MonoBehaviour {
    public Text GoalText;
    private void Awake()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Movement m = collision.GetComponent<Movement>();
        if (m != null) m.Win(GoalText);
    }    
}
