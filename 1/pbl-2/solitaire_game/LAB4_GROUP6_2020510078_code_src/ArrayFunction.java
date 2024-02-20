
public class ArrayFunction { 
	//this method adds an item to a reference array
    public int[] addItemToArray(int[] srcArray, int elementToAdd) {
        if (srcArray == null) {
            int[] resultArray = {elementToAdd};
            return resultArray;
        }

        int[] resultArray = new int[srcArray.length + 1];

        for (int i = 0; i < srcArray.length; i++) {
            resultArray[i] = srcArray[i];
        }

        resultArray[resultArray.length - 1] = elementToAdd;
        return resultArray;
    }
    public String[] addItemToArrayStr(String[] srcArray, String elementToAdd) {
        if (srcArray == null) {
        	String[] resultArray = {elementToAdd};
            return resultArray;
        }

        String[] resultArray = new String[srcArray.length + 1];

        for (int i = 0; i < srcArray.length; i++) {
            resultArray[i] = srcArray[i];
        }

        resultArray[resultArray.length - 1] = elementToAdd;
        return resultArray;
    }
	//this method dells an item from a reference array by index
	public int[] dellIndexInArray(int[] srcArray, int delIndex) {
        int[] resultArray = null;
        for (int i = 0; i < srcArray.length; i++) {
            if (i != delIndex) {
                resultArray = addItemToArray(resultArray, srcArray[i]);
            }
        }
        return resultArray;
    }
	public String[] dellIndexInArrayStr(String[] srcArray, int delIndex) {
		String[] resultArray = null;
        for (int i = 0; i < srcArray.length; i++) {
            if (i != delIndex) {
                resultArray = addItemToArrayStr(resultArray, srcArray[i]);
            }
        }
        return resultArray;
    }
	//this method dells an item from a reference array by item
	public int[] dellItemInArray(int[] srcArray, int item) {

        int[] resultArray = null;
        for (int i = 0; i < srcArray.length; i++) {
            if (srcArray[i] != item) {
                resultArray = addItemToArray(resultArray, srcArray[i]);
            }
        }
        return resultArray;
    }
    //this method combines two reference array and return them as one single array
	public int[] arrayCombiner(int[] firstArray, int[] secondArray) {
        int[] resultArray;
        if(firstArray == null) {
            resultArray = secondArray;
        }
        else if(secondArray == null){
            resultArray = firstArray;
        }
        else
            resultArray = new int[firstArray.length + secondArray.length];
            for (int i = 0; i < firstArray.length + secondArray.length; i++) {
                if (i < firstArray.length)
                    resultArray[i] = firstArray[i];
                else
                    resultArray[i] = secondArray[i - firstArray.length];
            }
        return resultArray;
    }
    //this method returns an index of a reference array
	public int returnIndexInArray(int[] srcArr, int indexToReturn) {
        int indexValue = -1;
        for (int i = 0; i < srcArr.length; i++) {
            if(i == indexToReturn) {
                indexValue = srcArr[i];
            }
        }
        return indexValue;
    }
    
}
