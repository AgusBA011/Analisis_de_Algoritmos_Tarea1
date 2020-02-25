﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class QuickSort : MonoBehaviour
{
    // Start is called before the first frame update

    const int arraysize = 1000;
    int[] arr = new int[arraysize];
    int k;
    Stopwatch sw = new Stopwatch();

    public GameObject punto;
    public GameObject tiempo;
    public TextMesh tm;

    // Start is called before the first frame update
    void Start()
    {
        System.Random rnd = new System.Random();
        for (int i = 0; i < arraysize; i++)
        {
            k = rnd.Next(500);
            arr[i] = k;

        }

        int len = arr.Length;

        sw.Start();

        quickSort(arr, 0, len - 1);

        sw.Stop();

        UnityEngine.Debug.Log("(QuickSort)Time elapsed:" + ((double)(sw.Elapsed.TotalMilliseconds * 1000000) /
            1000000).ToString("0.00 ms"));

        float timeElapsed = sw.Elapsed.Milliseconds;

        UnityEngine.Debug.Log(timeElapsed);

        float bolaY = -3.1f + timeElapsed;
        float tiempoY = -3.2f + timeElapsed;

        Instantiate(punto);
        punto.transform.position = new Vector3(-0.8f, 2f, bolaY);

        Instantiate(tiempo);

        tiempo.transform.position = new Vector3(-11.12f, 0f, tiempoY);
        tiempo.transform.eulerAngles = new Vector3(90, 0, 0);

        TextMesh tm = new TextMesh();
        tm = tiempo.GetComponent("TextMesh") as TextMesh;
        tm.text = ((double)(sw.Elapsed.TotalMilliseconds * 1000000) /
            1000000).ToString("0.00 ms") + "---";

    }

    // Update is called once per frame
    void Update()
    {

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
