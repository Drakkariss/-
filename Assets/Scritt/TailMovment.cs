using UnityEngine;
using UnityEngine.SceneManagement;

public class TailMovment : MonoBehaviour
{
    public float Speed;

    public Vector3 tailTarget;

    public int indx;

    public GameObject tailTargetObject;

    public SnakeMove mainSnake;
    void Start()
    {
        mainSnake = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SnakeMove>();



        tailTargetObject = mainSnake.tailObject[mainSnake.tailObject.Count - 2];

        indx = mainSnake.tailObject.IndexOf(gameObject);
    }


    void Update()
    {
        tailTarget = tailTargetObject.transform.position;
        Speed = mainSnake.Speed;
        transform.LookAt(tailTarget);
        transform.position = Vector3.Lerp(transform.position, tailTarget, Time.deltaTime * Speed);

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {
            if (indx > 5)
            {

                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

        }
    }
}
