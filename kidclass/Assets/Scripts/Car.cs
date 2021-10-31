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
    #endregion
}