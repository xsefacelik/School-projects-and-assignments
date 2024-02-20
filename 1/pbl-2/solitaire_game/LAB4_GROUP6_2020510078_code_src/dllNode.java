
public class dllNode {
	Object data;
	private dllNode prev;
	dllNode next;
	
	public  dllNode (Object dataToAdd) {
		data = dataToAdd;
		prev = null;
		next = null;
	}
	public Object getData() {
		return data;
	}
	public void setData(Object data) {
		this.data = data;
	}
	public dllNode getPrev() {
		return prev;
	}
	public void setPrev(dllNode prev) {
		this.prev = prev;
	}
	public dllNode getNext() {
		return next;
	}
	public void setNext(dllNode next) {
		this.next = next;
	}

}
