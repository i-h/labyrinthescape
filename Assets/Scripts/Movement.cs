using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour {
    public enum Player { None, Player1, Player2 }
    public Player PlayerBind = Player.Player1;
    public float MoveSpeed = 5.0f;

    Vector2 _moveVector = new Vector2();
    Rigidbody2D _rb;

	void Awake() {
        _rb = GetComponent<Rigidbody2D>();
        _rb.gravityScale = 0;
        _rb.isKinematic = false;
        _rb.constraints = RigidbodyConstraints2D.FreezeRotation;
	}
	
	// Update is called once per frame
	void Update () {
        _moveVector.x = Input.GetAxisRaw("Horizontal" + (int)PlayerBind);
        _moveVector.y = Input.GetAxisRaw("Vertical" + (int)PlayerBind);

        _rb.MovePosition(transform.position += (Vector3)(_moveVector.normalized/50*MoveSpeed));
	}

    public void Win(Text winText)
    {
        Debug.Log(name + " finished!");
        winText.gameObject.SetActive(true);
        winText.GetComponent<Text>().text = PlayerBind + " wins!\nTotal time: " + Time.time;

        Invoke("Restart", 3.0f);
    }

    void Restart()
    {
        SceneManager.LoadScene("Main");
    }
}
