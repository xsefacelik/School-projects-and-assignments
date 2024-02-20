import java.util.Arrays;
import java.util.Random;

public class QuickSort {
	
	public void sortPivotFirst(int[] arr) {
        if (arr == null || arr.length == 0) {
            return;
        }
        quickSortForPivotFirst(arr, 0, arr.length - 1);
    }
	public void sortPivotRandom(int[] arr) {
        if (arr == null || arr.length == 0) {
            return;
        }
        quickSortForPivotRandom(arr, 0, arr.length - 1);
    }
	public void sortPivotMedianOfThree(int[] arr) {
        if (arr == null || arr.length == 0) {
            return;
        }
        quickSortForPivotMedianOfThree(arr, 0, arr.length - 1);
    }
	
	
	
    private void quickSortForPivotFirst(int[] arr, int left, int right) {
        if (left < right) {         //eğer ki alınan sol değeri sağ değerden küçükse algoritmayı başlatır.
            int pivotIndex = partitionForPivotFirst(arr, left, right);   //partitionForPivotFirst ile pivotu belirler.
            quickSortForPivotFirst(arr, left, pivotIndex - 1);		//pivotun sol tarafındaki elemanları tekrar quick sort ile sıralar.
            quickSortForPivotFirst(arr, pivotIndex + 1, right);     //pivotun sağ tarafındaki elemanları tekrar quick sort ile sıralar.
        }
    }
    private int partitionForPivotFirst(int[] arr, int left, int right) {
        int pivot = arr[left];		//pivot elemanı alınan arrayin ilk elemanı olarak belirler.
        int i = left + 1;			//pivottan küçük elemanları pivotun sağına toplarken kullanılır.Her küçük elemanda bir artar.
        for (int j = left + 1; j <= right; j++) {		//arrayi gezer ve küçük eleman bulunca i indexli yere taşır.
            if (arr[j] < pivot) {
            	swap(arr, i, j);
                i++;
            }
        }
        swap(arr, left, i - 1);		//en son pivottan küçük ve büyük olanlar i indexli terimde ayrıldığı için pivotu i - 1 indexli konuma taşıyor.
        return i - 1;				//pivotun son durumda yeri i - 1 olduğu için geri dönecek olan pivotu i - 1 olarak return ediyor.
    }

    
    
    private void quickSortForPivotRandom(int[] arr, int start, int end) {
        if (start < end) {			//eğer ki alınan sol değeri sağ değerden küçükse algoritmayı başlatır.
            int pivotIndex = partitionForPivotRandom(arr, start, end);	//partitionForPivotFirst ile pivotu belirler.
            quickSortForPivotRandom(arr, start, pivotIndex - 1);		//pivotun sol tarafındaki elemanları tekrar quick sort ile sıralar.
            quickSortForPivotRandom(arr, pivotIndex + 1, end);			//pivotun sağ tarafındaki elemanları tekrar quick sort ile sıralar.
        }
    }
    private int partitionForPivotRandom(int[] arr, int start, int end) {
        int pivotIndex = new Random().nextInt(end - start + 1) + start;  //pivot elemanını random olarak seçilen bir index olarak belirler.
        int pivotValue = arr[pivotIndex];	//random indexteki pivotun değerini saklar.
        swap(arr, pivotIndex, end);			//pivotu sona taşır.
        int storeIndex = start;						//pivottan küçük olan elemanların sıralanmaya başlayacağı yeri gösterir.
        for (int i = start; i < end; i++) {			//array in içinde gezer ve küçük eleman bulunca storeIndex e taşır
            if (arr[i] < pivotValue) {
                swap(arr, i, storeIndex);			//storeIndex i bir arttırır ki gelen bir sonraki küçük eleman bir sonraki sıraya yerleşsin.
                storeIndex++;
            }
        }
        swap(arr, storeIndex, end);			//son durumda storeIndex pivottan küçükler ve büyükler olarak ayrılan nokta olduğundan en sondaki pivot ile storeIndex in yeri değişir.
        return storeIndex;
    }
    
    
    
    //bu kısım random olarak pivot seçilmesi ile aynıdır fakat pivotu random olarak seçmek yerine ilk orta ve son elemanın ortanca terimini alır.
    private void quickSortForPivotMedianOfThree(int[] arr, int start, int end) {
        if (start < end) {
            int pivotIndex = partitionForPivotMedianOfThree(arr, start, end);
            quickSortForPivotMedianOfThree(arr, start, pivotIndex - 1);
            quickSortForPivotMedianOfThree(arr, pivotIndex + 1, end);
        }
    }
    private int partitionForPivotMedianOfThree(int[] arr, int start, int end) {
    	int pivotIndex = 0;
    									
    	int left = start;
    	int right = end;
    	int middle = (start + end) / 2;
    	int[] pivotArr = {arr[left], arr[right], arr[middle]};	//ortanca elemanı seçmek için sol sağ ve ortanca elemanı alır ve bir diziye koyar.
    	Arrays.sort(pivotArr);									//oluşturduğu array i sort eder ve ortadaki elemanın hangi elemana denk geldiğini belirler. Bu sayede pivot ortadaki eleman olur.
    	if(pivotArr[1] == arr[left])
    		pivotIndex = left;
    	else if(pivotArr[1] == arr[right])
    		pivotIndex = right;
    	else if(pivotArr[1] == arr[middle])
    		pivotIndex = middle;
    	
    	
        int pivotValue = arr[pivotIndex];
        swap(arr, pivotIndex, end);
        int storeIndex = start;
        for (int i = start; i < end; i++) {
            if (arr[i] < pivotValue) {
                swap(arr, i, storeIndex);
                storeIndex++;
            }
        }
        swap(arr, storeIndex, end);
        return storeIndex;
    }
    
    
    
    //arraydeki i ve j indexli elemanları birbiri ile yer değiştirir.
    private void swap(int[] arr, int i, int j) {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
    
}
