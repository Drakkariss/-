using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SnakeMove : MonoBehaviour
{
    public float Speed = 5;
    public float RotationSpeed;

    public List<GameObject> tailObject = new List<GameObject>();

    public Text ScoreText;
    private int Score;

    public GameObject TailPrefab;


    void Start()
    {
        tailObject.Add(gameObject);
        
    }


    void Update()
    {
        
        ScoreText.text = Score.ToString($"Ñ÷¸ò: {Score}");
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * RotationSpeed * Time.deltaTime);
        }
    }

    public void AddTail()
    {
        Score++;

        Vector3 newTailPos = tailObject[tailObject.Count - 1].transform.position;

        tailObject.Add(Instantiate(TailPrefab, newTailPos, Quaternion.identity));

        if (Speed < 25)
        {
            Speed++;
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }

}
