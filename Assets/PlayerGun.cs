using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform muzzleTransform;


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.J))
        {
            Instantiate(bulletPrefab, muzzleTransform.position, muzzleTransform.rotation);
        }
    }
}
