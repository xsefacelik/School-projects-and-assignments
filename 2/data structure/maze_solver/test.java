package GraphPackage;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Arrays;
import java.util.Iterator;
import java.util.Random;
import java.util.Scanner;

import ADTPackage.LinkedQueue;
import ADTPackage.LinkedStack;
import ADTPackage.StackInterface;

public class test {
	@SuppressWarnings("rawtypes")
	public static Vertex[] vertices;
	public static int verticesEnd;
	@SuppressWarnings({ "unchecked", "rawtypes" })
	public static void main(String[] args) {
		
		
		UndirectedGraph<Vertex> graph = arrayToGrapghUnweighted("maze4");
		System.out.println("Number of Edge: " + graph.getNumberOfEdges());
		String[][] array = getAdjacencyMatrix();
		printAdjacencyMatrix(graph, array);
		
		
		BFS("maze4");
		DFS("maze4");
		UWeighted("maze4");
		Weighted("maze4");
		
	}
	
	
	
	public static void BFS(String maze) {
		System.out.println("\nGet BreadFirstTraversal: ");
		UndirectedGraph<Vertex> graphBreadthFirst = arrayToGrapghUnweighted(maze);
		printGraphBreadthFirst(mazeToArray(maze), graphBreadthFirst, maze.charAt(maze.length() - 1));
	}
	public static void DFS(String maze) {
		System.out.println("\nGet DepthFirstTraversal: ");
		UndirectedGraph<Vertex> graphDepthFirst = arrayToGrapghUnweighted(maze);
		printGraphDepthFirst(mazeToArray(maze), graphDepthFirst, maze.charAt(maze.length() - 1));
	}
	public static void UWeighted(String maze) {
		UndirectedGraph<Vertex> graphUnweighted = arrayToGrapghUnweighted(maze);
		System.out.println("\nGet Shortest Path With Unweighted Grapgh: ");
		printSolvedMazeUnweighted(mazeToArray(maze), graphUnweighted, maze.charAt(maze.length() - 1));
	}
	public static void Weighted(String maze) {
		UndirectedGraph<Vertex> graphWeighted = arrayToGrapghWeighted(maze);
		System.out.println("\nGet Cheapest Path With Weighted Grapgh: ");
		printSolvedMazeWeighted(mazeToArray(maze), graphWeighted, maze.charAt(maze.length() - 1));
	}
	
	

	public static String[][] getAdjacencyMatrix() {
		String[][] adjacencyMatrix = new String[verticesEnd + 1][verticesEnd + 1];
		int count = 1;
		for (int i = 0; i < verticesEnd; i++) {
			if(vertices[i] != null) {
				adjacencyMatrix[0][count] = (String)vertices[i].getLabel();
				adjacencyMatrix[count][0] = (String)vertices[i].getLabel();	
				count++;
			}
		}
		return adjacencyMatrix;
	}
	@SuppressWarnings("unchecked")
	public static void printAdjacencyMatrix(UndirectedGraph graph, String[][] array) {
		for (int i = 0; i < verticesEnd; i++) {
			for (int j = 0; j < verticesEnd; j++) {
				if(graph.hasEdge(vertices[i], vertices[j])) {
					array[i + 1][j + 1] = " 1 ";
				}
					
			}
		}
		
		for (int i = 0; i < verticesEnd + 1; i++) {
			for (int j = 0; j < verticesEnd + 1; j++) {
				if(array[i][j] != null)
					System.out.print(array[i][j] + " ");
				else {
					array[i][j] = " 0 ";
					System.out.print(array[i][j] + " ");
					
				}
			}
			System.out.println();
		}
	}
	
	
	@SuppressWarnings({ "unchecked", "rawtypes" })
	public static void printGraphBreadthFirst(Character[][] maze, UndirectedGraph graph, Character mazeNumber) {
		LinkedQueue<Vertex> vertexQueue = graph.getBreadthFirstSearch(vertices[0], vertices[verticesEnd]);
		LinkedQueue<Vertex> temp = vertexQueue;
		int mazeLenght = 0;
		if(mazeNumber == '1')
			mazeLenght = 10;
		else if(mazeNumber == '2')
			mazeLenght = 23;		
		else if(mazeNumber == '3')
			mazeLenght = 43;
		else if(mazeNumber == '4')
			mazeLenght = 102;
		
		
		String[] solve = new String[10000];
		int counter = 0;
		while(!temp.isEmpty()) {
			solve[counter] = (String) temp.dequeue().getLabel();
			counter++;
		}
		for (int i = 0; i < mazeLenght; i++) {
			for (int j = 0; j < mazeLenght; j++) {
				if(maze[i][j] != null && !isIn(solve, (i + "-" + j)))
					System.out.print(maze[i][j]);
				if(maze[i][j] != null && isIn(solve, (i + "-" + j)))
					System.out.print(".");
			}
			System.out.println();
		}
		
	}
	@SuppressWarnings({ "unchecked", "rawtypes" })
	public static void printGraphDepthFirst(Character[][] maze, UndirectedGraph graph, Character mazeNumber) {
		LinkedQueue<Vertex> vertexQueue = graph.getDepthFirstTraversal(vertices[0], vertices[verticesEnd]);
		LinkedQueue<Vertex> temp = vertexQueue;
		int mazeLenght = 0;
		if(mazeNumber == '1')
			mazeLenght = 10;
		else if(mazeNumber == '2')
			mazeLenght = 23;		
		else if(mazeNumber == '3')
			mazeLenght = 43;
		else if(mazeNumber == '4')
			mazeLenght = 102;
		
		
		String[] solve = new String[10000];
		int counter = 0;
		while(!temp.isEmpty()) {
			solve[counter] = (String) temp.dequeue().getLabel();
			counter++;
		}
		for (int i = 0; i < mazeLenght; i++) {
			for (int j = 0; j < mazeLenght; j++) {
				if(maze[i][j] != null && !isIn(solve, (i + "-" + j)))
					System.out.print(maze[i][j]);
				if(maze[i][j] != null && isIn(solve, (i + "-" + j)))
					System.out.print(".");
			}
			System.out.println();
		}
		
	}
	@SuppressWarnings({ "unchecked", "rawtypes" })
	public static void printSolvedMazeUnweighted(Character[][] maze, UndirectedGraph graph, int mazeNumber) {
		LinkedStack<Vertex> vertexStack = new LinkedStack<Vertex>();
		LinkedStack<Vertex> temp = vertexStack;
		int mazeLenght = 0;
		if(mazeNumber == '1')
			mazeLenght = 10;
		else if(mazeNumber == '2')
			mazeLenght = 23;		
		else if(mazeNumber == '3')
			mazeLenght = 43;
		else if(mazeNumber == '4')
			mazeLenght = 102;
		
		
		graph.getShortestPath(vertices[0], vertices[verticesEnd], temp);
		String[] solve = new String[10000];
		int counter = 0;
		while(!temp.isEmpty()) {
			solve[counter] = (String) temp.pop().getLabel();
			counter++;
		}
		for (int i = 0; i < mazeLenght; i++) {
			for (int j = 0; j < mazeLenght; j++) {
				if(maze[i][j] != null && !isIn(solve, (i + "-" + j)))
					System.out.print(maze[i][j]);
				if(maze[i][j] != null && isIn(solve, (i + "-" + j)))
					System.out.print(".");
			}
			System.out.println();
		}
		
	}
	@SuppressWarnings({ "unchecked", "rawtypes" })
	public static void printSolvedMazeWeighted(Character[][] maze, UndirectedGraph graph, Character mazeNumber) {
		LinkedStack<Vertex> vertexStack = new LinkedStack<Vertex>();
		LinkedStack<Vertex> temp = vertexStack;
		int mazeLenght = 0;
		if(mazeNumber == '1')
			mazeLenght = 10;
		else if(mazeNumber == '2')
			mazeLenght = 23;		
		else if(mazeNumber == '3')
			mazeLenght = 43;
		else if(mazeNumber == '4')
			mazeLenght = 102;

		
		System.out.print("Cost: " + graph.getCheapestPath(vertices[0], vertices[verticesEnd], temp));
		String[] solve = new String[10000];
		int counter = 0;
		while(!temp.isEmpty()) {
			solve[counter] = (String) temp.pop().getLabel();
			counter++;
		}
		System.out.println();
		for (int i = 0; i < mazeLenght; i++) {
			for (int j = 0; j < mazeLenght; j++) {
				if(maze[i][j] != null && !isIn(solve, (i + "-" + j)))
					System.out.print(maze[i][j]);
				if(maze[i][j] != null && isIn(solve, (i + "-" + j)))
					System.out.print(".");
			}
			System.out.println();
		}
		
	}
	
	public static boolean isIn(String[] array, String search) {
		for (int i = 0; i < array.length; i++) {
			if(array[i] != null && array[i].equals(search))
				return true;
		}
		return false;
	}
	
	
	public static Character[][] mazeToArray(String maze) {
		Character[][] array = new Character[102][102];
		try {
		      File myObj = new File("src/" + maze + ".txt");
		      Scanner myReader = new Scanner(myObj);
		      int counter_i = 0;
		      while (myReader.hasNextLine()) {
		        String data = myReader.nextLine();
		        for (int i = 0; i < data.length(); i++) {
					array[counter_i][i] = data.charAt(i);
						
				}
		        counter_i++;
		      }
		      myReader.close();
		    } catch (FileNotFoundException e) {
		      System.out.println("An error occurred.");
		      e.printStackTrace();
		    }
		return array;
	}
	@SuppressWarnings({ "rawtypes", "unchecked" })
	public static UndirectedGraph arrayToGrapghUnweighted(String maze) {
		Character[][] array = mazeToArray(maze);
		UndirectedGraph<Vertex> graph = new UndirectedGraph();
		vertices = new Vertex[10404];
		int counter = 0;
		
		for (int i = 0; i < 102; i++) {
			for (int j = 0; j < 102; j++) {
				if(array[i][j] != null && array[i][j] == ' ') {
					vertices[counter] = new Vertex(i + "-" + j);
					verticesEnd = counter;
					counter++;
				}
				
			}
		}
		
		for (Vertex vertex : vertices) {
			if(vertex != null)
				graph.addVertex(vertex);
		}
		
		for (int i = 0; i < vertices.length; i++) {
			if(vertices[i] != null) {
				String old = (String) vertices[i].getLabel();
				String old_i = old.split("-")[0];
				String old_j = old.split("-")[1];
				String searchForRight = old_i + "-" + (Integer.parseInt(old_j) + 1);
				String searchForDown = (Integer.parseInt(old_i) + 1) + "-" + old_j;
				if(getIndex(vertices, searchForRight) != -1) {
					graph.addEdge(vertices[i], vertices[getIndex(vertices, searchForRight)]);
					vertices[i].connect(vertices[getIndex(vertices, searchForRight)]);
					vertices[getIndex(vertices, searchForRight)].connect(vertices[i]);
				}
				if(getIndex(vertices, searchForDown) != -1) {
					graph.addEdge(vertices[i], vertices[getIndex(vertices, searchForDown)]);
					vertices[i].connect(vertices[getIndex(vertices, searchForDown)]);
					vertices[getIndex(vertices, searchForDown)].connect(vertices[i]);
				}
			}
		}		
		
		return graph;
	}
	@SuppressWarnings({ "rawtypes", "unchecked" })
	public static UndirectedGraph arrayToGrapghWeighted(String maze) {
		Random r = new Random();
		
		Character[][] array = mazeToArray(maze);
		UndirectedGraph<Vertex> graph = new UndirectedGraph();
		vertices = new Vertex[10404];
		int counter = 0;
		
		for (int i = 0; i < 102; i++) {
			for (int j = 0; j < 102; j++) {
				if(array[i][j] != null && array[i][j] == ' ') {
					vertices[counter] = new Vertex(i + "-" + j);
					verticesEnd = counter;
					counter++;
				}
				
			}
		}
		
		for (Vertex vertex : vertices) {
			if(vertex != null)
				graph.addVertex(vertex);
		}
		
		for (int i = 0; i < vertices.length; i++) {
			if(vertices[i] != null) {
				String old = (String) vertices[i].getLabel();
				String old_i = old.split("-")[0];
				String old_j = old.split("-")[1];
				String searchForRight = old_i + "-" + (Integer.parseInt(old_j) + 1);
				String searchForDown = (Integer.parseInt(old_i) + 1) + "-" + old_j;
				int random = r.nextInt(1,5);
				if(getIndex(vertices, searchForRight) != -1) {
					graph.addEdge(vertices[i], vertices[getIndex(vertices, searchForRight)], random);
					vertices[i].connect(vertices[getIndex(vertices, searchForRight)], random);
					vertices[getIndex(vertices, searchForRight)].connect(vertices[i], random);
				}
				if(getIndex(vertices, searchForDown) != -1) {
					graph.addEdge(vertices[i], vertices[getIndex(vertices, searchForDown)], random);
					vertices[i].connect(vertices[getIndex(vertices, searchForDown)], random);
					vertices[getIndex(vertices, searchForDown)].connect(vertices[i], random);
				}
			}
		}		
		
		return graph;
	}
	
	@SuppressWarnings("rawtypes")
	public static int getIndex(Vertex[] srcArr, String vertex) {
        int index = -1;
        for (int i = 0; i < srcArr.length; i++) {
        	if(srcArr[i] != null && ((String)srcArr[i].getLabel()).equals(vertex)) {
        		index = i;
        		return index;
            }
        }
        return index;
    }

}
