using UnityEngine;

public class Food : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {
            other.GetComponent<SnakeMove>().AddTail();
            Destroy(gameObject);
        }
    }
}
