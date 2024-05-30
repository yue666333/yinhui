using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light myLight;
    public Animation anim; // ��Ӷ������
    private bool isLightOn = false; // �ƹ�״̬����ʼΪ����
    private bool isAnimating = false; // �Ƿ����ڲ��Ŷ���

    private void Update()
    {
        // ��������
        if (Input.GetMouseButtonDown(0) && !isAnimating)
        {
            // ����һ�����߼�������λ���Ƿ��ڷ�����
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
        isAnimating = true; // ����Ϊ���ڲ��Ŷ���״̬

        if (isLightOn)
        {
            // ���ŵ�һ������
            anim.Play("oc");
        }
        else
        {
            // ���ŵڶ�������
            anim.Play("oc1");
        }

        // �л��ƹ�״̬
        isLightOn = !isLightOn;

        // ���û���õƹ�
        myLight.enabled = isLightOn;

        // �ӳ����� isAnimating Ϊ false���Ա��ڶ�����������ٴε����ť
        Invoke("SetAnimationStatus", 1f);
        
    }

    private void SetAnimationStatus()
    {
        isAnimating = false;
    }
}
