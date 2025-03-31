using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject item;
    [SerializeField] KeyCode code;

    private void Update()
    {
        if (Input.GetKeyDown(code))
        {
            Instantiate(item,transform);
        }
    }
}
