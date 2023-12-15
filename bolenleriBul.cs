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

        // Liste i�indeki t�m say�lar� ekrana yazd�r
        Debug.Log("T�m Say�lar: " + string.Join(", ", resultList));

        // 2'ye b�l�nenleri ekrana yazd�r
        Debug.Log("2'ye b�l�nenler: " + string.Join(", ", resultList.FindAll(sayi => tamBolunuyorMu(sayi, 2))));

        // 3'e b�l�nenleri ekrana yazd�r
        Debug.Log("3'e b�l�nenler: " + string.Join(", ", resultList.FindAll(sayi => tamBolunuyorMu(sayi, 3))));

        // 4'e b�l�nenleri ekrana yazd�r
        Debug.Log("4'e b�l�nenler: " + string.Join(", ", resultList.FindAll(sayi => tamBolunuyorMu(sayi, 4))));

        // 5'e b�l�nenleri ekrana yazd�r
        Debug.Log("5'e b�l�nenler: " + string.Join(", ", resultList.FindAll(sayi => tamBolunuyorMu(sayi, 5))));
    }

    // �lk say�dan son say�ya kadar olan say�lar� birer birer artt�rarak listeye eleman olarak ekler
    List<int> BolenBul(int ilk, int son)
    {
        List<int> sonuc = new List<int>();

        for (int i = ilk; i <= son; i++)
        {
            sonuc.Add(i);
        }

        return sonuc;
    }
    // B�len say�y� tam b�l�yor mu
    bool tamBolunuyorMu(int sayi, int bolen)
    {
        return sayi % bolen == 0;
    }
}