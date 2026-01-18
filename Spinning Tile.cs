using UnityEngine;

public class Spinning_Tile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    [SerializeField]
    private float Spin_Speed;
    // Update is called once per frame
    void Update()
    {
        transform.rotation *= Quaternion.Euler(0, 0, Spin_Speed);
    }
}
