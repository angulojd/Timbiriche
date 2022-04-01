using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class BoardManager : MonoBehaviour
{
    public static BoardManager Instance;
    public string N;
    public GameObject inputField;
    public int Width;
    public int Height;
    public Line LinePrefab;
    public Line1 Line1Prefab;
    public Box BoxPrefab;
    public Canvas botonInicio;


    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        botonInicio.gameObject.SetActive(true);
    }

    public void GenerateN()
    {
        N = inputField.GetComponent<Text>().text;
        Debug.Log(N);
        Width = Int32.Parse(N);
        Height = Int32.Parse(N);
        botonInicio.gameObject.SetActive(false);
        GenerateBoard();

    }

    private void GenerateBoard()
    {
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                var l1 = new Vector2(i, j);
                var l2 = new Vector4(i, j);
                if (i < Width - 1)
                {
                    Instantiate(Line1Prefab, l1, Quaternion.identity);
                }
                if(j != 0)
                {
                    Instantiate(LinePrefab, l2, Quaternion.identity);
                }

                if(i < Width -1 && j != 0)
                {
                    Instantiate(BoxPrefab, l1, Quaternion.identity);
                }
            }
        }
        var center = new Vector2((float)Height / 2 - 0.5f, (float)Width / 2 - 0.5f);
        var center1 = new Vector4((float)Height , (float)Width );
        Camera.main.transform.position = new Vector3(center1.x, center1.y, -5);
        Camera.main.transform.position = new Vector3(center.x, center.y, -5);
    }


    public void SetPoint(Point p)
    {
        GameManager.Instance.SwitchPlayer();
    }
    public void SetLine(Line l)
    {
        GameManager.Instance.SwitchPlayer();
    }

    public void SetLine1(Line1 l1)
    {
        GameManager.Instance.SwitchPlayer();
    }

}
