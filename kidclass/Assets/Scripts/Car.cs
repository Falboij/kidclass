using UnityEngine;                //引用 unity 引擎命名空間 : 可以使用此空間的 API
// 單行註解
// Falboij 2021/10/31
// class 類別:一個物件的藍圖
// 語法 : 類別 類別名稱 {　類別內容 (類別成員)　}
// 此類別要在 unity 內使用必須繼承 MonoBehaviour
// 括號皆是成對出現 () 、[] 、{} 、<> 、"" 、''
public class Car : MonoBehaviour
{
    #region 欄位語法及四大常用類型
    // 欄位 Field : 保存各種類型資料
    // 語法 : 修飾詞 資料類型 欄位名稱 指定(=) 預設值 結束符號(;)
    // 四大常用類型 :
    //   整  數 : 儲存沒有小數點的正負整數           - int
    //   浮點數 : 儲存帶有小數點的正負整數           - float
    //   字  串 : 儲存文字資訊                      - string
    //   布林值 : 儲存 " 是(true) 與 否(false) "    - bool
    // 修飾詞 :
    //   私  人 : 其他類別不能存取 、不顯示 private ( 預設值 )
    //   公  開 : 其他類別可以存取 、顯  示 public
    // 欄位屬性 Attritube
    //   語法 : [屬性名稱(值)]
    //    1. 標題 Header(字串)          (直接添加文字當作標題)
    //    2. 提示 Tooltip(字串)         (鼠標移到字上時顯示補充文字)
    //    3. 範圍 Range(最小值, 最大值)  (為選項產生限定範圍的滑桿) (僅適用於數值類型: int、float)
    [Header("CC 數"), Range(500, 5000)]
    public int cc = 1000;
    [Header("重量"), Range(1, 10)]
    public float weight = 3.5f;  //若要使用浮點數則要在數值後加"f or F"
    [Header("品牌名稱"), Tooltip("這是車子的品牌名稱")]
    public string brand = "賓士";
    [Header("是否有天窗")]
    public bool hasSkywindow = true;
    #endregion

    #region Unity內資料類型
    // 顏色 、向量(座標) 、按鍵資料 、遊戲物件 、元件
    #endregion
}