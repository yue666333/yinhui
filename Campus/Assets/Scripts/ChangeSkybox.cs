using UnityEngine;

public class ChangeSkybox : MonoBehaviour
{
    public Material[] skyboxes; // 保存不同天空盒的材质
    private int currentSkyboxIndex = 0; // 当前天空盒的索引

    private void Start()
    {
        RenderSettings.skybox = skyboxes[currentSkyboxIndex]; // 设置初始天空盒
    }

    public void ChangeSkyboxOnClick()
    {
        currentSkyboxIndex++; // 增加天空盒索引

        // 如果索引超出数组范围，则重置为0
        if (currentSkyboxIndex >= skyboxes.Length)
        {
            currentSkyboxIndex = 0;
        }

        // 设置新的天空盒
        RenderSettings.skybox = skyboxes[currentSkyboxIndex];
    }
}
