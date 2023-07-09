using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    [SerializeField] private BackgroundCheinger _backgroundCheinger;

    private void Start()
    {
        _backgroundCheinger = gameObject.transform.Find("Background").gameObject.GetComponent<BackgroundCheinger>();
    }

    public void ChengeBackground()
    {
        _backgroundCheinger.ChangeDarkenBackground();
    }
}
