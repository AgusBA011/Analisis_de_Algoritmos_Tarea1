using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Algoritmos : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

    // Start is called before the first frame update
    void Start()
    {
        int len = arr.Length;

        quickSort(arr, 0, len - 1);

        foreach (int a in arr)
        {
            Debug.Log(a);
        }

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


    //Algoritmo para QuickSort

    static int particionar(int[] arr, int imin, int imax)
    {
        int pivot = arr[imax];
        // index of smaller element 
        int i = (imin - 1);
        for (int j = imin; j < imax; j++)
        {
            // If current element is smaller  
            // than the pivot 
            if (arr[j] < pivot)
            {
                i++;

                // swap arr[i] and arr[j] 
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        // swap arr[i+1] and arr[high] (or pivot) 
        int temp1 = arr[i + 1];
        arr[i + 1] = arr[imax];
        arr[imax] = temp1;

        return i + 1;
    }

    static void quickSort(int[] arr, int imin, int imax)
    {

        if (imin >= imax) return;

        int k = particionar(arr, imin, imax);
        quickSort(arr, imin, k - 1);
        quickSort(arr, k + 1, imax);

    }
}
