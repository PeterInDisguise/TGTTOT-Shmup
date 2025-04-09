using UnityEngine;

public class PufferFish : MonoBehaviour
{
    [SerializeField] private float spikeTimer = 0f;

    //make some absolutely shit code involving 7 different spawnpoints (lesser men will see their computer start smoking)
    [SerializeField] private Transform spikePoint;
    [SerializeField] private Transform spikePoint1;
    [SerializeField] private Transform spikePoint2;
    [SerializeField] private Transform spikePoint3;
    [SerializeField] private Transform spikePoint4;
    [SerializeField] private Transform spikePoint5;
    [SerializeField] private Transform spikePoint6;

    [SerializeField] private GameObject spikePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spikeTimer = spikeTimer + Time.deltaTime;
        if (spikeTimer >= 5f)
        {
            Spikymcspikeface();
            spikeTimer = 0f;
        }
    }

    private void Spikymcspikeface()
    {
        Instantiate(spikePrefab, spikePoint.position, spikePoint.rotation);
        Instantiate(spikePrefab, spikePoint1.position, spikePoint1.rotation);
        Instantiate(spikePrefab, spikePoint2.position, spikePoint2.rotation);
        Instantiate(spikePrefab, spikePoint3.position, spikePoint3.rotation);
        Instantiate(spikePrefab, spikePoint4.position, spikePoint4.rotation);
        Instantiate(spikePrefab, spikePoint5.position, spikePoint5.rotation);
        Instantiate(spikePrefab, spikePoint6.position, spikePoint6.rotation);
    }
}
