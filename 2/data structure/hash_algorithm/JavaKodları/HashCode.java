
public class HashCode {
	public int stringToHashKeyWithPAF(String value) {
		String alphabet = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
		int hashKey = 0;
		for (int i = 0; i < value.length(); i++) {
			hashKey += ((alphabet.indexOf(value.charAt(i)) / 2) + 1) * (int)(Math.pow(31, value.length() - i - 1));
		}
		return hashKey;
	}
	
	public int stringToHashKeyWithSSF(String value) {
		String alphabet = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
		int hashKey = 0;
		for (int i = 0; i < value.length(); i++) {
			hashKey += (alphabet.indexOf(value.charAt(i)) / 2) + 1;
		}
		return hashKey;
	}
}
