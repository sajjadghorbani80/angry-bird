using UnityEngine;

public class AudioSuorceManage : MonoBehaviour
{

    private void Update()
    {

        AudioManager.instance.Play("BackgroundMusic");

    }
}