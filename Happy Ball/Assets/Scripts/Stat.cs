using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Stat : MonoBehaviour
{
    private float currentValue;
    [SerializeField]
    private float lerpSpeed;
    [SerializeField]
    private TextMeshProUGUI statValue;

    

    private Image content;
    private float currentFill;
    public float MyMaxValue { get; set; }
    private float overExpLevel;
    public float MyOverFlow
    {
        get
        {
            float tmp = overExpLevel;
            overExpLevel = 0;
            return tmp;
        }
    }
    public float MyCurrentValue
    {
    get
        {
        return currentValue;
        }
set
    {
            if(value>MyMaxValue)
            {
                overExpLevel = value -MyMaxValue;
                currentValue = MyMaxValue;
            }else if(value<0)
            {
                currentValue = 0;
            }
            else { currentValue = value; }
            currentFill = currentValue / MyMaxValue;

            statValue.text = currentValue + " / " + MyMaxValue;
    
    }
    }

    public bool IsFull
    {
        get { return content.fillAmount == 1; }
    }

    public void Reset()
    {
        content.fillAmount = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        content = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(currentFill != content.fillAmount)
        {
            content.fillAmount = Mathf.Lerp(content.fillAmount, currentFill, Time.deltaTime * lerpSpeed);  
        }
       
    }

    public void Initialize (float currentValue,float maxValue)
    {
        MyMaxValue = maxValue;
        MyCurrentValue = currentValue;
    }
}
