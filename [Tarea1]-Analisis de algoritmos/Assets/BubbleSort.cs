using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class BubbleSort : MonoBehaviour
{
    // Start is called before the first frame update

    const int arraysize = 2000;
    int[] arr = new int[arraysize];
    int k;
    Stopwatch sw = new Stopwatch();

    // Start is called before the first frame update
    void Start()
    {
        System.Random rnd = new System.Random();
        for (int i = 0; i < arraysize; i++)
        {
            k = rnd.Next(500);
            arr[i] = k;

        }

        sw.Start();
        bubbleSort(arr);
        sw.Stop();

        /*foreach (int a in arr)
        {
            //UnityEngine.Debug.Log(a);
        }*/
        UnityEngine.Debug.Log("(Bubble Sort)Time elapsed:" + sw.Elapsed.ToString("ss\\.fff"));

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Algoritmo para BubbleSort
    static void bubbleSort(int[] arr)
    {
        int len = arr.Length; int i; int j;

        for (i = 0; i < len - 1; i++)
            for (j = 0; j < len - i - 1; j++)
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
    }

}
