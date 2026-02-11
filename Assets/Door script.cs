using UnityEngine;

public class Doorscript : MonoBehaviour
{
    public int hitsRequired = 3;
    private int currentHits = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        // Count the hit
        currentHits++;

        Debug.Log("Hit " + currentHits + " of " + hitsRequired);

        // Check if we've hit it 3 times
        if (currentHits >= hitsRequired)
        {
            OpenDoor();
        }
    }

    void OpenDoor()
    {
        Debug.Log("Door is opening!");

        // Open the door (you can customize this part)
        // Example: Rotate the door
        transform.Rotate(0, 90, 0);

        // Or move it up
        // transform.position += Vector3.up * 3;

        // Or disable it
        // gameObject.SetActive(false);
    }
}
