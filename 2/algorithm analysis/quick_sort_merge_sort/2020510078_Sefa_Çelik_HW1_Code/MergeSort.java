import java.util.Arrays;

public class MergeSort {

	public void mergeSortForTwo(int[] arr, int left, int right) {
		// girilen sol değer sağdan küçükse çalışmaya başlar.
		if (left < right) {
			int middle = (left + right) / 2; // verilen arrayin orta noktasını hesaplar.

			mergeSortForTwo(arr, left, middle); // orta noktaya kadar olan arry i tekrar fonksiyona sokar.
			mergeSortForTwo(arr, middle + 1, right); // orta noktadan sona kadar olan arry i tekrar fonksiyona sokar.

			mergeForTwo(arr, left, middle, right); // iki array i birleştirir.
		}
	}
	private void mergeForTwo(int[] arr, int left, int middle, int right) {

		// sol ve sağ arry in büyüklüklerini hesaplar.
		int n1 = middle - left + 1;
		int n2 = right - middle;

		// büyüklükleri kadar array oluşturur.
		int[] leftArr = new int[n1];
		int[] rightArr = new int[n2];

		// iki array in içini doldurur.
		for (int i = 0; i < n1; i++)
			leftArr[i] = arr[left + i];
		for (int j = 0; j < n2; j++)
			rightArr[j] = arr[middle + 1 + j];

		// i ilk arraydeki j ikinci arraydeki k ise toplamı olan arraydeki kullanılan
		// indexleri tutar.
		int i = 0, j = 0, k = left;

		// i ve j den herhangi biri bulunduğu arraydeki elemanları bitirene kadar bu
		// döngüde kalır.
		while (i < n1 && j < n2) {
			// küçük olanı ana array e ekler ve hangisini kullandıysa o index i arttırır ve
			// ana arraydeki index de bir artar.
			if (leftArr[i] <= rightArr[j]) {
				arr[k] = leftArr[i];
				i++;
			} else {
				arr[k] = rightArr[j];
				j++;
			}
			k++;
		}
		// en sonda kalan elemanları zaten sıralı olduğu için hangisinde kaldıysa ana
		// array e ekler.
		while (i < n1) {
			arr[k] = leftArr[i];
			i++;
			k++;
		}

		while (j < n2) {
			arr[k] = rightArr[j];
			j++;
			k++;
		}
	}

	
	
	public void mergeSortForThree(int[] arr) {
		// array in uzunluğu birden büyükse sıralama işlemi başlar.
		if (arr.length <= 1) {
			return;
		}

		// arrayi 3 parçeye bölmek için iki orta nokta belirler.
		int mid1 = arr.length / 3;
		int mid2 = 2 * arr.length / 3;

		int[] leftArr = Arrays.copyOfRange(arr, 0, mid1); // sol arrayi oluşturmak için arrayin ilk mid pointe kadar
															// olan yerini kopyalar.
		int[] middleArr = Arrays.copyOfRange(arr, mid1, mid2); // orta arrayi oluşturmak için arrayin ilk mid pointten
																// sonraki mid pointe kadar olan yerini kopyalar.
		int[] rightArr = Arrays.copyOfRange(arr, mid2, arr.length); // sağ array i oluşturmak için arrayin ikinci orta
																	// pointten sona kadar olan yerini kopyalar.

		// oluşan sol orta ve sağ arrayleri tekrar algoritmaya sokar.
		mergeSortForThree(leftArr);
		mergeSortForThree(middleArr);
		mergeSortForThree(rightArr);

		// 3 arrayi birleştirir.
		mergeForThree(arr, leftArr, middleArr, rightArr);
	}
	private void mergeForThree(int[] arr, int[] leftArr, int[] middleArr, int[] rightArr) {

		// i j ve k 3 tane arraydeki konumu tutar l ise toplanacak olan ana arraydeki
		// konumu tutar.
		int i = 0, j = 0, k = 0, l = 0;

		// üç arrayden herhangi birisindeki eleman bitene kadar bu döngüde kalır.
		while (i < leftArr.length && j < middleArr.length && k < rightArr.length) {
			if (leftArr[i] <= middleArr[j] && leftArr[i] <= rightArr[k]) {
				arr[l] = leftArr[i];
				i++;
			} else if (middleArr[j] <= leftArr[i] && middleArr[j] <= rightArr[k]) {
				arr[l] = middleArr[j];
				j++;
			} else {
				arr[l] = rightArr[k];
				k++;
			}
			l++;
			// 3 arrayden küçük olanı seçr ve o arrayin index sayacını bir arttırır ve ana
			// array i de bir arttırır.
		}

		// i ve j den biri bitene kadar çalışır aynı mantıkta.
		while (i < leftArr.length && j < middleArr.length) {
			if (leftArr[i] <= middleArr[j]) {
				arr[l] = leftArr[i];
				i++;
			} else {
				arr[l] = middleArr[j];
				j++;
			}
			l++;
		}

		// j ve k den herhangi biri bitene kadar çalışır aynı mantıkta.
		while (j < middleArr.length && k < rightArr.length) {
			if (middleArr[j] <= rightArr[k]) {
				arr[l] = middleArr[j];
				j++;
			} else {
				arr[l] = rightArr[k];
				k++;
			}
			l++;
		}

		// i ve k den herhangi biri bitene kadar çalışır aynı mantıkta.
		while (i < leftArr.length && k < rightArr.length) {
			if (leftArr[i] <= rightArr[k]) {
				arr[l] = leftArr[i];
				i++;
			} else {
				arr[l] = rightArr[k];
				k++;
			}
			l++;
		}

		// en son kalan arrayi de ana array e ekler.
		while (i < leftArr.length) {
			arr[l] = leftArr[i];
			i++;
			l++;
		}

		while (j < middleArr.length) {
			arr[l] = middleArr[j];
			j++;
			l++;
		}

		while (k < rightArr.length) {
			arr[l] = rightArr[k];
			k++;
			l++;
		}
	}

}
