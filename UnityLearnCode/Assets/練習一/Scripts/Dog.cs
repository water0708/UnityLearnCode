using UnityEngine;
[System .Serializable ]
public class Dog
{
    #region 欄位
    public string name;
    public float weight;
    public string type;
    public string sex;
    public string color;
    public int age;
    #endregion

    #region 方法
    /// <summary>
    /// 狗叫的方法
    /// </summary>
    public void Bark()
    {
        Debug.Log(name + ":汪汪!!!");
    }
    /// <summary>
    /// 狗狗轉換年齡的方法
    /// </summary>
    /// <returns>狗狗年齡*7轉化成為人類年齡</returns>
    public int ConvertAge()
    {
        return age * 7;
    }
    /// <summary>
    /// 狗吃飯的方法
    /// </summary>
    /// <param name="food"></param>
    /// <param name="speed"></param>
    public void Eat(string food, string speed = "慢")
    {
        Debug.Log(name + ":" + food + ",速度:" + speed);   
    }
    /// <summary>
    /// 狗吃飯的方法
    /// </summary>
    /// <param name="food"></param>
    /// <param name="count"></param>
    public void Eat(string food, int count)
    {
        Debug.Log(name + ":" + food + ",份量:" + count);
    }
    #endregion
}