using UnityEngine;

public class IcedTile : MonoBehaviour
{
    [SerializeField] private float iceSpeedOverride = 25f;
    Player player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Player player = collision.collider.GetComponent<Player>();
        if (player == null) return;

        player.Is_On_Ice = true;
        player.Ice_speed = iceSpeedOverride;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Player player = collision.collider.GetComponent<Player>();
        if (player == null) return;

        if (Ice_to_Ground == true)
        {
            player.Is_On_Ice = false;
        }
        
    }
    
    private void Start()
    {
        player = FindAnyObjectByType<Player>();
    }

    private bool Ice_to_Ground;
    private void Ice_to_Ground_Sensor ()
    {
        if (player.Is_Grounded == true && player.Is_On_Ice == false)
        {
            Ice_to_Ground = true;
        }
        else
        {
            Ice_to_Ground= false;
        }
    }
    private void Update()
    {
        Ice_to_Ground_Sensor();
    }
}
