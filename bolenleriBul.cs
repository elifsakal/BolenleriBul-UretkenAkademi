using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolenleriBul : MonoBehaviour
{
   void Start()
    {
        int ilksayi = 20;
        int sonsayi = 44;

        List<int> resultList = BolenBul(ilksayi, sonsayi);

        // Liste içindeki tüm sayýlarý ekrana yazdýr
        Debug.Log("Tüm Sayýlar: " + string.Join(", ", resultList));

        // 2'ye bölünenleri ekrana yazdýr
        Debug.Log("2'ye bölünenler: " + string.Join(", ", resultList.FindAll(sayi => tamBolunuyorMu(sayi, 2))));

        // 3'e bölünenleri ekrana yazdýr
        Debug.Log("3'e bölünenler: " + string.Join(", ", resultList.FindAll(sayi => tamBolunuyorMu(sayi, 3))));

        // 4'e bölünenleri ekrana yazdýr
        Debug.Log("4'e bölünenler: " + string.Join(", ", resultList.FindAll(sayi => tamBolunuyorMu(sayi, 4))));

        // 5'e bölünenleri ekrana yazdýr
        Debug.Log("5'e bölünenler: " + string.Join(", ", resultList.FindAll(sayi => tamBolunuyorMu(sayi, 5))));
    }

    // Ýlk sayýdan son sayýya kadar olan sayýlarý birer birer arttýrarak listeye eleman olarak ekler
    List<int> BolenBul(int ilk, int son)
    {
        List<int> sonuc = new List<int>();

        for (int i = ilk; i <= son; i++)
        {
            sonuc.Add(i);
        }

        return sonuc;
    }
    // Bölen sayýyý tam bölüyor mu
    bool tamBolunuyorMu(int sayi, int bolen)
    {
        return sayi % bolen == 0;
    }
}