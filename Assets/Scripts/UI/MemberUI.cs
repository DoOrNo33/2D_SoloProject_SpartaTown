using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MemberUI : MonoBehaviour
{
    public GameObject MemberFormat;
    public List<Text> memberFormatTxt;
    public RectTransform rectTransform;
    public List<string> Members = new List<string>();

    private void Awake()
    {
        Members.Add("������");
        Members.Add("���¿�");
        Members.Add("����â");
        Members.Add("��ſ�");

    }

    private void Start()
    {
        for (int i = 0; i < Members.Count; i++)
        {
            Vector3 position = new Vector3(1720, 890 - (50 * i), 0);
            memberFormatTxt.Add(MemberFormat.GetComponentInChildren<Text>());
            memberFormatTxt[i].text = Members[i].ToString();
            Instantiate(MemberFormat, position, Quaternion.identity, transform);

        }

    }
}