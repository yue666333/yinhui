using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public GameObject wordWindow; 
    public Text words; 
    private string[] messages = { "�����Ϻ�ͼ���й�ʮ��������֮һ��Ϊ���η��׻������λ�������˽����Ĵ�����Ʒ��������������ֲ��ڱ����ʹ�����Ժ�������Ϻ�ͼ��24.8���ס���528.7���ף����ɫ����Ʒ�Գ�����ʽ������ɢ��͸�ӹ�ͼ����������¼���й�ʮ�����ͱ��ζ��Ƕ����ĳ�����ò�͵�ʱ�����ײ����������״�����Ǳ���ʱ�ڶ��Ƕ������귱�ٵļ�֤��Ҳ�Ǳ��γ��о��������д�ա�",
    "����ɽ��ͼ��Ԫ�����һƹ�����1350�괴����ֽ��ˮī�����й�ʮ��������֮һ���ƹ���Ϊʦ��֣�ˣ�����ʦ�����棬�������֣����򡰷ٻ�ѳ�ᡱ���������Ρ��˻��Ժ���������ʽ����˸���������������ɽ��ˮɫ��������ʯ���������ɽ�����Ȫ��к����Ⱥɽ�����У�é�ݴ���β���䣬����С�Ŵ������£����ν���澰Ǩ���������ơ��˻��������������߹��ա��������Ⱦ�ĸ߳��������ﵽ��¯����ľ��磬����������Ƴ�Ϊ��ب�ŵ�һ������",
    "��ǧ�ｭɽͼ���Ǳ�����ϣ�ϴ����ľ��ɫ�������ղ��ڱ����ʹ�����Ժ������Ʒ�Գ�����ʽ�����㴫ͳ������ϸ����΢���̲�����Ľ��ӡ����������Ⱥɽ������һ������Ľ���ɽˮͼ�����Ұ�С�ˮ�̨ͤ��é�ֲ��ᡢˮĥ���ŵȾ������岶�㡢ʻ�������桢�ϼ��ȶ������������ǡ���ô����ڸ���Ʒ����Ŀ̻��ϣ����侫ϸ��΢����̬���������������ñ�����һ�㣬��չ�᰿��̬֮��"};
       // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
        RaycastHit hit;

        if (Input.GetMouseButton(0)) 
        {
            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.transform.tag == "T") 
                {
                    // int.Parseǿת����
                    words.text = messages[int.Parse(hit.transform.name)];
                    wordWindow.SetActive(true);

                }

            }

        }
        if(Input.GetKeyDown(KeyCode.P))
        {
            wordWindow.SetActive(false);
        }
    }
   
}
