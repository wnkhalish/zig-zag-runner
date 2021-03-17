using System.Collections;
using UnityEngine;

public class TileScript : MonoBehaviour
{

    float fallDelay = 10f;

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            TileManager.Instance.SpawnTiles();
        StartCoroutine(FallDown());
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            TileManager.Instance.SpawnTiles();
            StartCoroutine(FallDown());
        }
    }

    IEnumerator FallDown()
    {
        yield return new WaitForSeconds(fallDelay);
        GetComponent<Rigidbody>().isKinematic = false;
        yield return new WaitForSeconds(2);
        switch (gameObject.name)
        {
            case "LeftTile":
                TileManager.Instance.LeftTiles.Push(gameObject);
                gameObject.GetComponent<Rigidbody>().isKinematic = true;
                gameObject.SetActive(false);
                break;
            case "TopTile":
                TileManager.Instance.TopTiles.Push(gameObject);
                gameObject.GetComponent<Rigidbody>().isKinematic = true;
                gameObject.SetActive(false);
                break;
        }
    }
}
