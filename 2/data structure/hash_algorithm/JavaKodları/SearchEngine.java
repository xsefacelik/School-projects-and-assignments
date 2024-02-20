import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.HashSet;
import java.util.Iterator;
import java.util.Scanner;

public class SearchEngine {
	Utilities utility = new Utilities();
	HashCode hash = new HashCode();
	MaxPercentageSearcher maxSearcher = new MaxPercentageSearcher();
	FileReader reader = new FileReader();
	
	public static HashedDictionary<String, ValueNode> dataBase = new HashedDictionary<String, ValueNode>();
	public static Dictionary<String, Dictionary<String, Integer>> counter = new Dictionary<String, Dictionary<String, Integer>>();
	public static Dictionary<String, Integer> txtSize = new Dictionary<String, Integer>();
	public static ArrayList<String> stopWords = new ArrayList<String>();
	private long millis_startTime;
	private long millis_endTime;
	
	public SearchEngine() {
		millis_startTime = System.currentTimeMillis();
		utility.stopWordsTxtToArrayList("C:\\Users\\SEFA\\Desktop\\stop_words_en.txt");
		reader.txtFolderToCounterTable("C:\\Users\\SEFA\\Desktop\\Sport");
		reader.counterToHashTable(dataBase, counter);
		millis_endTime = System.currentTimeMillis();
		searchEngine();
	}
	
	
	
	public void searchEngine(){
		System.out.println("https://www.cengoogle.com/");
		System.out.println("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
		System.out.println("\n");
		System.out.println("      <<CENGOOGLE>>");
		System.out.println("      ||¯¯¯¯¯¯¯¯¯||");
		System.out.println("      || CME2203 ||");
		System.out.println("      ||_________||");
		System.out.println("\n\n");
		Scanner scanner = new Scanner(System.in);
	    System.out.println("Enter three words: ");
	    String words = scanner.nextLine();
	    scanner.close();
	    String[] wordsArr = words.split(" ");
	    HashSet<String> txts = wordsArrToHashSet(wordsArr);
	    Object[] txtsArr = txts.toArray();
	    
	    Dictionary<String, Double> percentDict = new Dictionary<String, Double>();
	    for (Object txt: txtsArr) {
	    	double percent = 0.0;
	    	for (String word : wordsArr) {
	    		Dictionary<String, Integer> dict = dataBase.getValue(word).getCounter();
	    		if(dict.getValue((String)txt) != null)
	    			percent += dict.getValue((String)txt) / (double)txtSize.getValue((String)txt);
			}
	    	percentDict.add((String)txt, percent);
		}
	    
	    System.out.println(getMaxTxt(percentDict));
	    System.out.println();
	    reader.returnTxtWithNumber("C:\\Users\\SEFA\\Desktop\\Sport", getMaxTxt(percentDict).split(":")[0].substring(0,3));
	}
	public HashSet<String> wordsArrToHashSet(String[] wordsArr){
		String[] searchedArr = maxSearcher.returnMaxValuesPercentageForThree(wordsArr[0], wordsArr[1], wordsArr[2]);
		String first = searchedArr[0];
		String second = searchedArr[1];
		String third = searchedArr[2];
		
		HashSet<String> txts = new HashSet<String>();
		
		txts.add(first.split(",")[0].split(":")[0]);
		txts.add(first.split(",")[1].split(":")[0]);
		txts.add(first.split(",")[2].split(":")[0]);
		
		txts.add(second.split(",")[0].split(":")[0]);
		txts.add(second.split(",")[1].split(":")[0]);
		txts.add(second.split(",")[2].split(":")[0]);
		
		txts.add(third.split(",")[0].split(":")[0]);
		txts.add(third.split(",")[1].split(":")[0]);
		txts.add(third.split(",")[2].split(":")[0]);
		
		return txts;
	}
	public String getMaxTxt(Dictionary<String, Double> dict) {
		Iterator<String> keyIterator = dict.getKeyIterator();
		Iterator<Double> valueIterator = dict.getValueIterator();
		double max = -1.0;
		String maxTxt = "";
		while (keyIterator.hasNext()) {
			double value = valueIterator.next();
			String txt = keyIterator.next();
			if(value > max) {
				max = value;
				maxTxt = txt;
			}
		}
		return maxTxt + ":" + max;
	}
	
	
	
	public void searchTxt(String location) {
		try {
		      File myObj = new File(location);
		      Scanner myReader = new Scanner(myObj);
		      while (myReader.hasNextLine()) {
		        String data = myReader.nextLine();
		        dataBase.contains(data);
		      }
		      myReader.close();
		    } catch (FileNotFoundException e) {
		      System.out.println("An error occurred.");
		      e.printStackTrace();
		    }
	}
	public String getmaxMinAndAvgSearch(String location) {
		long avg = 0;
		long maxSearhTime = Long.MIN_VALUE;
		long minSearchTime = Long.MAX_VALUE;
		try {
		      File myObj = new File(location);
		      Scanner myReader = new Scanner(myObj);
		      while (myReader.hasNextLine()) {
		        String data = myReader.nextLine();
		        long startTime = System.nanoTime();
		        dataBase.contains(data);
		        long endTime = System.nanoTime();
		        long time = utility.returnIndexingTime(startTime, endTime);
		        System.out.println(time);
		        if(time < minSearchTime)
		        	minSearchTime = time;
		        if(time > maxSearhTime)
		        	maxSearhTime = time;
		        avg += time;
		      }
		      myReader.close();
		    } catch (FileNotFoundException e) {
		      System.out.println("An error occurred.");
		      e.printStackTrace();
		    }
		
		String result = "Avarage: " + (avg / 1000.0) + "\n" + "Min: " + minSearchTime + "\n" + "Max: " + maxSearhTime;
		return result;
	}
	
}
