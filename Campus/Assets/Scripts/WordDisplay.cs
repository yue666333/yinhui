using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public GameObject wordWindow; 
    public Text words; 
    private string[] messages = { "清明上河图，中国十大传世名画之一。为北宋风俗画，北宋画家张择端仅见的存世精品，属国宝级文物，现藏于北京故宫博物院。清明上河图宽24.8厘米、长528.7厘米，绢本设色。作品以长卷形式，采用散点透视构图法，生动记录了中国十二世纪北宋都城东京的城市面貌和当时社会各阶层人民的生活状况，是北宋时期都城东京当年繁荣的见证，也是北宋城市经济情况的写照。",
    "富春山居图是元代画家黄公望于1350年创作的纸本水墨画，中国十大传世名画之一。黄公望为师弟郑樗（无用师）所绘，几经易手，并因“焚画殉葬”而身首两段。此画以横幅长卷的形式描绘了富春江两岸秀丽的山光水色。峰峦坡石随势起伏，山涧深处清泉飞泻。在群山环抱中，茅屋村舍参差其间，渔舟小桥错落有致，真可谓人随景迁、景随人移。此画集中体现了作者勾勒、皴擦、点染的高超技法，达到了炉火纯青的境界，清初吴其贞推崇为“亘古第一画”。",
    "《千里江山图》是北宋王希孟创作的绢本设色画，现收藏于北京故宫博物院。该作品以长卷形式，立足传统，画面细致入微，烟波浩渺的江河、层峦起伏的群山构成了一幅美妙的江南山水图，渔村野市、水榭亭台、茅庵草舍、水磨长桥等静景穿插捕鱼、驶船、游玩、赶集等动景，动静结合恰到好处。在该作品人物的刻画上，极其精细入微，意态栩栩如生，飞鸟用笔轻轻一点，具展翅翱翔之态。"};
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
                    // int.Parse强转整形
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
