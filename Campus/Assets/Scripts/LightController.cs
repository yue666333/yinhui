using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light myLight;
    public Animation anim; // 添加动画组件
    private bool isLightOn = false; // 灯光状态，初始为开启
    private bool isAnimating = false; // 是否正在播放动画

    private void Update()
    {
        // 检测鼠标点击
        if (Input.GetMouseButtonDown(0) && !isAnimating)
        {
            // 发射一条射线检测鼠标点击位置是否在方块上
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.tag == "kaiguan")
            {
                ToggleLight();
            }
        }
    }

    public void ToggleLight()
    {
        isAnimating = true; // 设置为正在播放动画状态

        if (isLightOn)
        {
            // 播放第一个动画
            anim.Play("oc");
        }
        else
        {
            // 播放第二个动画
            anim.Play("oc1");
        }

        // 切换灯光状态
        isLightOn = !isLightOn;

        // 启用或禁用灯光
        myLight.enabled = isLightOn;

        // 延迟设置 isAnimating 为 false，以便在动画播放完后再次点击按钮
        Invoke("SetAnimationStatus", 1f);
        
    }

    private void SetAnimationStatus()
    {
        isAnimating = false;
    }
}
