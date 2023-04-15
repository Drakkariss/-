using UnityEngine;

public class FoodGeneration : MonoBehaviour
{
    public float XSize = 427f;
    public float XxSize = 372.5f;
    public float ZSize = 359f;
    public float ZzSize = 302f;
    public GameObject foodPrefab;

    public Vector3 curPos;

    public GameObject currentFood;

    void AddNewFood()
    {
        RandomPos();
        currentFood = Instantiate(foodPrefab, curPos, Quaternion.identity);
    }
    void RandomPos()
    {
        curPos = new Vector3(Random.Range(XSize, XxSize), 1.2f, Random.Range(ZSize, ZzSize));
    }
    void Update()
    {
        if (!currentFood)
        {
            AddNewFood();
        }
        else
        {
            return;
        }
 
    }
}
