
public class ValueNode {
	private int value;
	private Dictionary<String, Integer> counter;
	
	ValueNode(int value, Dictionary<String, Integer> counter){
		this.value = value;
		this.counter = counter;
	}
	
	public int getValue(){
		return value;
	}
	
	public Dictionary<String, Integer> getCounter(){
		return counter;
	}
	
}
