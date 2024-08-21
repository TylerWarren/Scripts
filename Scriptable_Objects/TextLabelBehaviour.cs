using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class TextLabelBehaviour : MonoBehaviour
{
    public Text label;
    public FloatData dataObj;

    private void Start()
    {
        label = GetComponant<Text>();
        label.text = dataObj.value.ToString();
    }
}
