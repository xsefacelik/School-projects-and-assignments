import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.Scanner;

public class Utilities {
	
	public String[] cleaner(String data) {
		String DELIMITERS = "[-+=" +
		        " " +        //space
		        "\r\n " +    //carriage return line fit
				"1234567890" + //numbers
				"’'\"" +       // apostrophe
				"(){}<>\\[\\]" + // brackets
				":" +        // colon
				"," +        // comma
				"‒–—―" +     // dashes
				"…" +        // ellipsis
				"!" +        // exclamation mark
				"." +        // full stop/period
				"«»" +       // guillemets
				"-‐" +       // hyphen
				"?" +        // question mark
				"‘’“”" +     // quotation marks
				";" +        // semicolon
				"/" +        // slash/stroke
				"⁄" +        // solidus
				"␠" +        // space?   
				"·" +        // interpunct
				"&" +        // ampersand
				"@" +        // at sign
				"*" +        // asterisk
				"\\" +       // backslash
				"•" +        // bullet
				"^" +        // caret
				"¤¢$€£¥₩₪" + // currency
				"†‡" +       // dagger
				"°" +        // degree
				"¡" +        // inverted exclamation point
				"¿" +        // inverted question mark
				"¬" +        // negation
				"#" +        // number sign (hashtag)
				"№" +        // numero sign ()
				"%‰‱" +      // percent and related signs
				"¶" +        // pilcrow
				"′" +        // prime
				"§" +        // section sign
				"~" +        // tilde/swung dash
				"¨" +        // umlaut/diaeresis
				"_" +        // underscore/understrike
				"|¦" +       // vertical/pipe/broken bar
				"⁂" +        // asterism
				"☞" +        // index/fist
				"∴" +        // therefore sign
				"‽" +        // interrobang
				"※" +          // reference mark
		        "]";
				
		return data.split(DELIMITERS);
	}

	public long returnIndexingTime(long start, long end) {
		return end - start;
	}

	public void stopWordsTxtToArrayList(String location) {
		try {
		      File myObj = new File(location);
		      Scanner myReader = new Scanner(myObj);
		      while (myReader.hasNextLine()) {
		        String data = myReader.nextLine();
		        SearchEngine.stopWords.add(data);
		      }
		      myReader.close();
		    } catch (FileNotFoundException e) {
		      System.out.println("An error occurred.");
		      e.printStackTrace();
		    }
	}

	public double getPercentage(int count, String txt) {
		double result = ((double)count / SearchEngine.txtSize.getValue(txt));
		return Math.round((result * 10000)) / 10000.0;
	}
}
