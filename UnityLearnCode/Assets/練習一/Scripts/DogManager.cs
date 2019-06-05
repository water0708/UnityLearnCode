using UnityEngine;
// DogManager:MonoBehaviour 繼承
public class DogManager : MonoBehaviour
{
    #region 欄位
    public Dog DogA = new Dog(35.5f,"男",7);
    public Dog DogB = new Dog( 42.5f, "女", 6);
    #endregion

    #region 事件
    private void Start()
    {
        /*
        DogA.name = "翔A";
        DogA.weight = 35.5f;
        DogA.type = "貴賓";
        DogA.sex = "男";
        DogA.color = "白色";
        DogA.age = 7;

        DogB.name = "翔B";
        DogB.weight = 42.5f;
        DogB.type = "哈士奇";
        DogB.sex = "女";
        DogB.color = "酒紅色";
        DogB.age = 6;
        */

        Debug.Log(DogA.name + "品種:" + DogA.type + "顏色:" + DogA.color);
        Debug.Log(DogB.name + "品種:" + DogB.type + "顏色:" + DogB.color);

        DogA.Bark();
        DogB.Bark();

        Debug .Log (DogA.name+"實際年齡為:"+DogA.ConvertAge());
        Debug.Log(DogB.name + "實際年齡為:" + DogB.ConvertAge());

        DogA.Eat("熱狗");
        DogB.Eat("大熱狗",10);
        #endregion
    }
}