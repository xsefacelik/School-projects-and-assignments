
public class ArrayFunction {
	//this method adds an item to a reference array
	public String[] addItemToArray(String[] srcArray, String elementToAdd) {
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
	public String[] dellIndexInArray(String[] srcArray, int delIndex) {
        String[] resultArray = null;
        for (int i = 0; i < srcArray.length; i++) {
            if (i != delIndex) {
                resultArray = addItemToArray(resultArray, srcArray[i]);
            }
        }
        return resultArray;
    }
    //this method dells an item from a reference array by item
	public String[] dellItemInArray(String[] srcArray, String item) {
        String[] resultArray = null;
        for (int i = 0; i < srcArray.length; i++) {
            if (!srcArray[i].equals(item)) {
                resultArray = addItemToArray(resultArray, srcArray[i]);
            }
        }
        return resultArray;
    }
    //this method combines two reference array and return them as one single array
	public String[] arrayCombiner(String[] firstArray, String[] secondArray) {
        String[] resultArray;
        if(firstArray == null) {
            resultArray = secondArray;
        }
        else if(secondArray == null){
            resultArray = firstArray;
        }
        else
            resultArray = new String[firstArray.length + secondArray.length];
            for (int i = 0; i < firstArray.length + secondArray.length; i++) {
                if (i < firstArray.length)
                    resultArray[i] = firstArray[i];
                else
                    resultArray[i] = secondArray[i - firstArray.length];
            }
        return resultArray;
    }
    //this method returns an index of a reference array
	public String returnIndexInArray(String[] srcArr, int indexToReturn) {
        String indexValue = "";
        for (int i = 0; i < srcArr.length; i++) {
            if(i == indexToReturn) {
                indexValue = srcArr[i];
            }
        }
        return indexValue;
    }
    

}
