using UnityEngine;                //���� unity �����������g : ����ʹ�ô˿��g�� API
// �����]��
// Falboij 2021/10/31
// class e:һ��������{�D
// �Z�� : e e���Q {��e���� (e�ɆT)��}
// ��eҪ�� unity ��ʹ�ñ���^�� MonoBehaviour
// ��̖���ǳɌ����F () ��[] ��{} ��<> ��"" ��''
public class Car : MonoBehaviour
{
    #region ��λ�Z�����Ĵ������
    // ��λ Field : ������N����Y��
    // �Z�� : ����~ �Y����� ��λ���Q ָ��(=) �A�Oֵ �Y����̖(;)
    // �Ĵ������ :
    //   ��  �� : ����]��С���c����ؓ����           - int
    //   ���c�� : ���控��С���c����ؓ����           - float
    //   ��  �� : ���������YӍ                      - string
    //   ����ֵ : ���� " ��(true) �c ��(false) "    - bool
    // ����~ :
    //   ˽  �� : ����e���ܴ�ȡ �����@ʾ private ( �A�Oֵ )
    //   ��  �_ : ����e���Դ�ȡ ���@  ʾ public
    // ��λ���� Attritube
    //   �Z�� : [�������Q(ֵ)]
    //    1. ���} Header(�ִ�)          (ֱ��������֮������})
    //    2. ��ʾ Tooltip(�ִ�)         (����Ƶ����ϕr�@ʾ�a������)
    //    3. ���� Range(��Сֵ, ���ֵ)  (���x헮a���޶������Ļ��U) (�H�m��추�ֵ���: int��float)
    [Header("CC ��"), Range(500, 5000)]
    public int cc = 1000;
    [Header("����"), Range(1, 10)]
    public float weight = 3.5f;  //��Ҫʹ�ø��c���tҪ�ڔ�ֵ���"f or F"
    [Header("Ʒ�����Q"), Tooltip("�@��܇�ӵ�Ʒ�����Q")]
    public string brand = "�eʿ";
    [Header("�Ƿ����촰")]
    public bool hasSkywindow = true;
    #endregion

    #region Unity���Y�����
    // �ɫ ������(����) �����I�Y�� ���[����� ��Ԫ��
    //�ɫ Color
    public Color color;
    public Color colorRed = Color.red;
    public Color colorYellow = Color.yellow;
    public Color colorCustom1 = new Color(0, 0, 1);
    public Color colorCustom2 = new Color(1, 0, 1, 0.5f);
    //���� 2 ~ 4 Vector
    public Vector2 v2;
    public Vector2 v2one = Vector2.one;
    public Vector2 v2right = Vector2.right;
    public Vector2 v2left = Vector2.left;
    public Vector2 v2custom = new Vector2(1, 2);
    public Vector3 v3custom = new Vector3(1, 2, 3);
    public Vector4 v4custom = new Vector4(1, 2, 3, 4);
    //���I Keycode
    public KeyCode keycode;
    public KeyCode keycodeMouseleft = KeyCode.Mouse0;
    public KeyCode keycodeJump = KeyCode.Space;
    //�[����� GameObject
    public GameObject goCamera;
    public GameObject goCar;
    //Ԫ�� Component
    public Transform traCamera;
    public Camera cam;
    public SpriteRenderer spr;
    #endregion
}