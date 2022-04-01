using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line1 : MonoBehaviour
{
    public GameObject Inner;
    private Vector2 _position;

    public Vector2 Pos => _position;

    public void Init(Vector2 position)
    {
        this._position = position;
    }

    private void OnMouseDown()
    {
        Debug.Log("mouse down");
        if (GameManager.Instance.GetGameState == GameManager.GameState.player1)
            if (Inner.GetComponent<SpriteRenderer>().color == Color.blue || Inner.GetComponent<SpriteRenderer>().color == Color.red)
                Debug.Log("Color ya asignado!");
            else
            {
                Inner.GetComponent<SpriteRenderer>().color = Color.blue;
                BoardManager.Instance.SetLine1(this);
            }
        else
            if (Inner.GetComponent<SpriteRenderer>().color == Color.blue || Inner.GetComponent<SpriteRenderer>().color == Color.red)
            Debug.Log("Color ya asignado!");
        else
        {
            Inner.GetComponent<SpriteRenderer>().color = Color.red;
            BoardManager.Instance.SetLine1(this);
        }
    }
}
