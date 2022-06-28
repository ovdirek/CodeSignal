bool solution(int[] sequence) {
            bool result = true;
            int buyukCount = 0;
            int adet = sequence.Length;
            for (int i = 0; i < adet - 1; i++)
            {
                int sonuc = ArrayDuzgun(sequence);
                if (sonuc == -1)
                    break;
                else
                {
                    buyukCount++;
                    int[] deneme = new int[sequence.Length];
                    deneme = elemanCikar(sequence, sonuc);
                    int denemeSonuc = ArrayDuzgun(deneme);
                    if (denemeSonuc == -1)
                        sequence = deneme;
                    else
                    {
                        deneme = elemanCikar(sequence, sonuc + 1);
                        denemeSonuc = ArrayDuzgun(deneme);
                        if (denemeSonuc == -1)
                            sequence = deneme;
                        else
                            sequence = elemanCikar(sequence, sonuc);
                    }
                }
            }
            if (buyukCount > 1)
                result = false;

            return result;
}

        //Arrayden eleman çıkarıp yeni dizi oluşturuyoruz. Çıkarılması gereken indisi parametre olarak alıyoruz.
public static int[] elemanCikar(int[] arr, int indis)
        {
            int[] arr2 = new int[arr.Length - 1];
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == indis)
                {
                    continue;
                }
                else
                {
                    arr2[count] = arr[i];
                }
                count++;
            }

            return arr2;
        }

        //Array düzgünse -1 dönüyor. Aksi takdirde düzgün olmayan arrayin indisini dönüyor.
        public static int ArrayDuzgun(int[] arr)
        {
            int result = -1;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i + 1] > arr[i])
                    continue;
                else
                {
                    result = i;
                    break;
                }
                    
            }
            return result;
        }
