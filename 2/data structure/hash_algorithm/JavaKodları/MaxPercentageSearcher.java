import java.util.Iterator;

public class MaxPercentageSearcher {
	Utilities utility = new Utilities();
	
	public String getMaxValue(Dictionary<String, Integer> counter) {
		String result = "";
		Iterator<String> keyIterator = counter.getKeyIterator();
		Iterator<Integer> valueIterator = counter.getValueIterator();
		String maxKey = "";
		double maxPercentage = 0.0;
		int maxValue = 0;
		while(keyIterator.hasNext()) {
			int value = valueIterator.next();
			String key = keyIterator.next();
			if(utility.getPercentage(value, key) > maxPercentage) {
				maxPercentage = utility.getPercentage(value, key);
				maxValue = value;
				maxKey = key;
			}
		}
		result = maxKey + ":" + maxValue;
		return result;	
	}
	public String getMaxThreeValues(Dictionary<String, Integer> counter) {
		String result = "";
		for (int i = 0; i < 3; i++) {
			if(i < 2)
				result += getMaxValue(counter) + ",";
			else
				result += getMaxValue(counter);
			String[] tempSplittedResult = result.split(",");
			counter.remove(tempSplittedResult[tempSplittedResult.length - 1].split(":")[0]);
		}
		String[] splittedResult = result.split(",");
		counter.add(splittedResult[0].split(":")[0], Integer.parseInt(splittedResult[0].split(":")[1]));
		counter.add(splittedResult[1].split(":")[0], Integer.parseInt(splittedResult[1].split(":")[1]));
		counter.add(splittedResult[2].split(":")[0], Integer.parseInt(splittedResult[2].split(":")[1]));
		return result;
	}
	public String returnMaxValuesPercentage(String word) {
		String result = "";
		String maxes = getMaxThreeValues(SearchEngine.dataBase.getValue(word).getCounter());
		String[] splittedMaxes = maxes.split(",");
		result += splittedMaxes[0].split(":")[0] + ":" + utility.getPercentage(Integer.parseInt(splittedMaxes[0].split(":")[1]), splittedMaxes[0].split(":")[0]) + ",";
		result += splittedMaxes[1].split(":")[0] + ":" + utility.getPercentage(Integer.parseInt(splittedMaxes[1].split(":")[1]), splittedMaxes[1].split(":")[0]) + ",";
		result += splittedMaxes[2].split(":")[0] + ":" + utility.getPercentage(Integer.parseInt(splittedMaxes[2].split(":")[1]), splittedMaxes[2].split(":")[0]);
		return result;
	}
	public String[] returnMaxValuesPercentageForThree(String a, String b, String c) {
		String[] result = new String[3];
		result[0] = returnMaxValuesPercentage(a);
		result[1] = returnMaxValuesPercentage(b);
		result[2] = returnMaxValuesPercentage(c);
		return result;
	}
}
