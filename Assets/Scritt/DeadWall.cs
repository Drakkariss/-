using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadWall : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain"))
        {

            {

                SceneManager.LoadScene(0);

            }
        }
    }
}
