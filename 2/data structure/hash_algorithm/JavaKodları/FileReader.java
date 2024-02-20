import java.io.File;
import java.io.FileNotFoundException;
import java.util.Iterator;
import java.util.Scanner;

public class FileReader {
	HashCode hash = new HashCode();
	Utilities utility = new Utilities();
	
	public void txtFolderToCounterTable(String folderLocation) {
		for (int i = 1; i <= 511; i++) {
			String txtName = "";
			if(i > 0 && i < 10)
				txtName = "00" + i;
			else if(i > 9 && i < 100)
				txtName = "0" + i;
			else if(i > 99 && i < 1000)
				txtName = Integer.toString(i);
			loadingScreen(txtName);
			System.out.println("\n\n");
			String location = folderLocation + "\\" + txtName + ".txt";
			txtToCounterTable(location);
		}
	}
	public void loadingScreen(String txtName) {
		if(Integer.parseInt(txtName) < 50) {
			for (int i = 0; i < 20; i++) {
				System.out.println();
			}
			System.out.println("      ...LOADING...");
			System.out.println("      ____________");
			System.out.println("      |          |");
			System.out.println("      ¯¯¯¯¯¯¯¯¯¯¯¯");
			System.out.println("About 10 sec remaining...");
		}
		else if(Integer.parseInt(txtName) < 100 && Integer.parseInt(txtName) > 50) {
			for (int i = 0; i < 20; i++) {
				System.out.println();
			}
			System.out.println("      ...LOADING...");
			System.out.println("      ____________");
			System.out.println("      |<         |");
			System.out.println("      ¯¯¯¯¯¯¯¯¯¯¯¯");
			System.out.println("About 9 sec remaining...");
		}
		else if(Integer.parseInt(txtName) < 150 && Integer.parseInt(txtName) > 100) {
			for (int i = 0; i < 20; i++) {
				System.out.println();
			}
			System.out.println("      ...LOADING...");
			System.out.println("      ____________");
			System.out.println("      |<<        |");
			System.out.println("      ¯¯¯¯¯¯¯¯¯¯¯¯");
			System.out.println("About 8 sec remaining...");
		}
		else if(Integer.parseInt(txtName) < 200 && Integer.parseInt(txtName) > 150) {
			for (int i = 0; i < 20; i++) {
				System.out.println();
			}
			System.out.println("      ...LOADING...");
			System.out.println("      ____________");
			System.out.println("      |<<<       |");
			System.out.println("      ¯¯¯¯¯¯¯¯¯¯¯¯");
			System.out.println("About 7 sec remaining...");
		}
		else if(Integer.parseInt(txtName) < 250 && Integer.parseInt(txtName) > 200) {
			for (int i = 0; i < 20; i++) {
				System.out.println();
			}
			System.out.println("      ...LOADING...");
			System.out.println("      ____________");
			System.out.println("      |<<<<      |");
			System.out.println("      ¯¯¯¯¯¯¯¯¯¯¯¯");
			System.out.println("About 6 sec remaining...");
		}
		else if(Integer.parseInt(txtName) < 300 && Integer.parseInt(txtName) > 250) {
			for (int i = 0; i < 20; i++) {
				System.out.println();
			}
			System.out.println("      ...LOADING...");
			System.out.println("      ____________");
			System.out.println("      |<<<<<     |");
			System.out.println("      ¯¯¯¯¯¯¯¯¯¯¯¯");
			System.out.println("About 5 sec remaining...");
		}
		else if(Integer.parseInt(txtName) < 350 && Integer.parseInt(txtName) > 300) {
			for (int i = 0; i < 20; i++) {
				System.out.println();
			}
			System.out.println("      ...LOADING...");
			System.out.println("      ____________");
			System.out.println("      |<<<<<<    |");
			System.out.println("      ¯¯¯¯¯¯¯¯¯¯¯¯");
			System.out.println("About 4 sec remaining...");
		}
		else if(Integer.parseInt(txtName) < 400 && Integer.parseInt(txtName) > 350) {
			for (int i = 0; i < 20; i++) {
				System.out.println();
			}
			System.out.println("      ...LOADING...");
			System.out.println("      ____________");
			System.out.println("      |<<<<<<<   |");
			System.out.println("      ¯¯¯¯¯¯¯¯¯¯¯¯");
			System.out.println("About 3 sec remaining...");
		}
		else if(Integer.parseInt(txtName) < 450 && Integer.parseInt(txtName) > 400) {
			for (int i = 0; i < 20; i++) {
				System.out.println();
			}
			System.out.println("      ...LOADING...");
			System.out.println("      ____________");
			System.out.println("      |<<<<<<<<  |");
			System.out.println("      ¯¯¯¯¯¯¯¯¯¯¯¯");
			System.out.println("About 2 sec remaining...");
		}
		else if(Integer.parseInt(txtName) > 450) {
			for (int i = 0; i < 20; i++) {
				System.out.println();
			}
			System.out.println("      ...LOADING...");
			System.out.println("      ____________");
			System.out.println("      |<<<<<<<<< |");
			System.out.println("      ¯¯¯¯¯¯¯¯¯¯¯¯");
			System.out.println("About 1 sec remaining...");
		}
		
		
		
	}
	
	public void txtToCounterTable(String location) {
		try {
		      File myObj = new File(location);
		      Scanner myReader = new Scanner(myObj);
		      while (myReader.hasNextLine()) {
		        String data = myReader.nextLine();
		        String[] dataArr = utility.cleaner(data);
		        for (int i = 0; i < dataArr.length; i++) {
		        	if(!SearchEngine.stopWords.contains(dataArr[i])) {
		        		addTxtName(SearchEngine.counter, dataArr[i], location.substring(location.length() - 7));
		        		addTxtSize(SearchEngine.txtSize, location.substring(location.length() - 7));
		        	}
				}
		      }
		      myReader.close();
		    } catch (FileNotFoundException e) {
		      System.out.println("An error occurred.");
		      e.printStackTrace();
		    }
	}
	
	public void counterToHashTable(HashedDictionary<String, ValueNode> dataBase, Dictionary<String, Dictionary<String, Integer>> counter) {
		Iterator<String> keyIterator = counter.getKeyIterator();
		Iterator<Dictionary<String, Integer>> valueIterator = counter.getValueIterator();
		while(keyIterator.hasNext()) {
			String data = keyIterator.next();
			Dictionary<String, Integer> value = valueIterator.next();
			dataBase.add(data, new ValueNode(hash.stringToHashKeyWithPAF(data), value));
		}
	}
	
	public void addTxtName(Dictionary<String, Dictionary<String, Integer>> base, String word ,String txtName) {
		if(base.contains(word)) {
			if(base.getValue(word).contains(txtName)) {
				base.getValue(word).add(txtName, base.getValue(word).getValue(txtName) + 1);
			}
			else {
				base.getValue(word).add(txtName, 1);
			}
		}
		else {
			Dictionary<String, Integer> temp = new Dictionary<String, Integer>();
			temp.add(txtName, 1);
			base.add(word,temp);
		}
	}
	public void addTxtSize(Dictionary<String, Integer> txtDict, String txtName) {
		if(txtDict.contains(txtName)) {
			txtDict.add(txtName, txtDict.getValue(txtName) + 1);
		}
		else {
			txtDict.add(txtName, 1);
		}
	}

	public void returnTxtWithNumber(String folderLocation, String txtNumber) {
		for (int i = 1; i <= 511; i++) {
			if(i == Integer.parseInt(txtNumber)) {
				try {
					String location = folderLocation + "\\" + txtNumber + ".txt";
				      File myObj = new File(location);
				      Scanner myReader = new Scanner(myObj);
				      while (myReader.hasNextLine()) {
				        String data = myReader.nextLine();
				        System.out.println(data);
				      }
				      myReader.close();
				    } catch (FileNotFoundException e) {
				      System.out.println("An error occurred.");
				      e.printStackTrace();
				    }
			}
		}
	}
}
