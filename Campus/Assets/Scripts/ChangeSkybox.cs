using UnityEngine;

public class ChangeSkybox : MonoBehaviour
{
    public Material[] skyboxes; // ���治ͬ��պеĲ���
    private int currentSkyboxIndex = 0; // ��ǰ��պе�����

    private void Start()
    {
        RenderSettings.skybox = skyboxes[currentSkyboxIndex]; // ���ó�ʼ��պ�
    }

    public void ChangeSkyboxOnClick()
    {
        currentSkyboxIndex++; // ������պ�����

        // ��������������鷶Χ��������Ϊ0
        if (currentSkyboxIndex >= skyboxes.Length)
        {
            currentSkyboxIndex = 0;
        }

        // �����µ���պ�
        RenderSettings.skybox = skyboxes[currentSkyboxIndex];
    }
}
