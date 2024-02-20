import java.util.Random;
import java.util.Scanner;

public class Test {

	public static void main(String[] args) {
		MergeSort mergers = new MergeSort();
		QuickSort quickSorters = new QuickSort();
		long timeForStarting = 0;
		long timeForEnding = 0;
		long time;

		Scanner scanner = new Scanner(System.in);

		int[] arr = null;
		
		System.out.println("1-Merge\n2-Quick");
		System.out.println("1 or 2?");
		int mergeOrQuick = scanner.nextInt();

		if (mergeOrQuick == 1) {
			System.out.println("1-Two Part\n2-Three Part");
			System.out.println("1 or 2?");
			int partOption = scanner.nextInt();

			System.out.println("1-Equal Integers\n2-Random Integers\n3-Increasing Integers\n4-Decreasing Integers");
			System.out.println("1 or 2 or 3 or 4?");
			int intOption = scanner.nextInt();

			System.out.println("1-1,000\n2-10,000\n3-100,000");
			System.out.println("1 or 2 or 3?");
			int size = scanner.nextInt();

			if (partOption == 1) {
				if (intOption == 1) {
					if (size == 1) {
						arr = generateEquals(1000);
						timeForStarting = System.nanoTime();
						mergers.mergeSortForTwo(arr, 0, arr.length - 1);
					} else if (size == 2) {
						arr = generateEquals(10000);
						timeForStarting = System.nanoTime();
						mergers.mergeSortForTwo(arr, 0, arr.length - 1);
					} else if (size == 3) {
						arr = generateEquals(100000);
						timeForStarting = System.nanoTime();
						mergers.mergeSortForTwo(arr, 0, arr.length - 1);
					}
				}

				else if (intOption == 2) {
					if (size == 1) {
						arr = generateRandom(1000);
						timeForStarting = System.nanoTime();
						mergers.mergeSortForTwo(arr, 0, arr.length - 1);
					} else if (size == 2) {
						arr = generateRandom(10000);
						timeForStarting = System.nanoTime();
						mergers.mergeSortForTwo(arr, 0, arr.length - 1);
					} else if (size == 3) {
						arr = generateRandom(100000);
						timeForStarting = System.nanoTime();
						mergers.mergeSortForTwo(arr, 0, arr.length - 1);
					}
				} else if (intOption == 3) {
					if (size == 1) {
						arr = generateIncreasing(1000);
						timeForStarting = System.nanoTime();
						mergers.mergeSortForTwo(arr, 0, arr.length - 1);
					} else if (size == 2) {
						arr = generateIncreasing(10000);
						timeForStarting = System.nanoTime();
						mergers.mergeSortForTwo(arr, 0, arr.length - 1);
					} else if (size == 3) {
						arr = generateIncreasing(100000);
						timeForStarting = System.nanoTime();
						mergers.mergeSortForTwo(arr, 0, arr.length - 1);
					}
				} else if (intOption == 4) {
					if (size == 1) {
						arr = generateDecreasing(1000);
						timeForStarting = System.nanoTime();
						mergers.mergeSortForTwo(arr, 0, arr.length - 1);
					} else if (size == 2) {
						arr = generateDecreasing(10000);
						timeForStarting = System.nanoTime();
						mergers.mergeSortForTwo(arr, 0, arr.length - 1);
					} else if (size == 3) {
						arr = generateDecreasing(100000);
						timeForStarting = System.nanoTime();
						mergers.mergeSortForTwo(arr, 0, arr.length - 1);
					}
				}

			} else if (partOption == 2) {
				if (intOption == 1) {
					if (size == 1) {
						arr = generateEquals(1000);
						timeForStarting = System.nanoTime();
						mergers.mergeSortForThree(arr);
					} else if (size == 2) {
						arr = generateEquals(10000);
						timeForStarting = System.nanoTime();
						mergers.mergeSortForThree(arr);
					} else if (size == 3) {
						arr = generateEquals(100000);
						timeForStarting = System.nanoTime();
						mergers.mergeSortForThree(arr);
					}
				} else if (intOption == 2) {
					if (size == 1) {
						arr = generateRandom(1000);
						timeForStarting = System.nanoTime();
						mergers.mergeSortForThree(arr);
					} else if (size == 2) {
						arr = generateRandom(10000);
						timeForStarting = System.nanoTime();
						mergers.mergeSortForThree(arr);
					} else if (size == 3) {
						arr = generateRandom(100000);
						timeForStarting = System.nanoTime();
						mergers.mergeSortForThree(arr);
					}
				} else if (intOption == 3) {
					if (size == 1) {
						arr = generateIncreasing(1000);
						timeForStarting = System.nanoTime();
						mergers.mergeSortForThree(arr);
					} else if (size == 2) {
						arr = generateIncreasing(10000);
						timeForStarting = System.nanoTime();
						mergers.mergeSortForThree(arr);
					} else if (size == 3) {
						arr = generateIncreasing(100000);
						timeForStarting = System.nanoTime();
						mergers.mergeSortForThree(arr);
					}
				} else if (intOption == 4) {
					if (size == 1) {
						arr = generateDecreasing(1000);
						timeForStarting = System.nanoTime();
						mergers.mergeSortForThree(arr);
					} else if (size == 2) {
						arr = generateDecreasing(10000);
						timeForStarting = System.nanoTime();
						mergers.mergeSortForThree(arr);
					} else if (size == 3) {
						arr = generateDecreasing(100000);
						timeForStarting = System.nanoTime();
						mergers.mergeSortForThree(arr);
					}
				}
			}
		}

		else if (mergeOrQuick == 2) {
			System.out.println("1-Pivot First\n2-Pivot Random\n3-Pivot Median of Three");
			System.out.println("1 or 2 or 3?");
			int quickOption = scanner.nextInt();

			System.out.println("1-Equal Integers\n2-Random Integers\n3-Increasing Integers\n4-Decreasing Integers");
			System.out.println("1 or 2 or 3 or 4?");
			int intOption = scanner.nextInt();

			System.out.println("1-1,000\n2-10,000\n3-100,000");
			System.out.println("1 or 2 or 3?");
			int size = scanner.nextInt();

			if (quickOption == 1) {
				if (intOption == 1) {
					if (size == 1) {
						arr = generateEquals(1000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotFirst(arr);
					} else if (size == 2) {
						arr = generateEquals(10000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotFirst(arr);
					} else if (size == 3) {
						arr = generateEquals(100000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotFirst(arr);
					}
				} else if (intOption == 2) {
					if (size == 1) {
						arr = generateRandom(1000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotFirst(arr);
					} else if (size == 2) {
						arr = generateRandom(10000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotFirst(arr);
					} else if (size == 3) {
						arr = generateRandom(100000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotFirst(arr);
					}
				} else if (intOption == 3) {
					if (size == 1) {
						arr = generateIncreasing(1000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotFirst(arr);
					} else if (size == 2) {
						arr = generateIncreasing(10000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotFirst(arr);
					} else if (size == 3) {
						arr = generateIncreasing(100000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotFirst(arr);
					}
				} else if (intOption == 4) {
					if (size == 1) {
						arr = generateDecreasing(1000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotFirst(arr);
					} else if (size == 2) {
						arr = generateDecreasing(10000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotFirst(arr);
					} else if (size == 3) {
						arr = generateDecreasing(100000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotFirst(arr);
					}
				}
			}

			else if (quickOption == 2) {
				if (intOption == 1) {
					if (size == 1) {
						arr = generateEquals(1000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotRandom(arr);
					} else if (size == 2) {
						arr = generateEquals(10000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotRandom(arr);
					} else if (size == 3) {
						arr = generateEquals(100000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotRandom(arr);
					}
				} else if (intOption == 2) {
					if (size == 1) {
						arr = generateRandom(1000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotRandom(arr);
					} else if (size == 2) {
						arr = generateRandom(10000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotRandom(arr);
					} else if (size == 3) {
						arr = generateRandom(100000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotRandom(arr);
					}
				} else if (intOption == 3) {
					if (size == 1) {
						arr = generateIncreasing(1000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotRandom(arr);
					} else if (size == 2) {
						arr = generateIncreasing(10000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotRandom(arr);
					} else if (size == 3) {
						arr = generateIncreasing(100000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotRandom(arr);
					}
				} else if (intOption == 4) {
					if (size == 1) {
						arr = generateDecreasing(1000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotRandom(arr);
					} else if (size == 2) {
						arr = generateDecreasing(10000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotRandom(arr);
					} else if (size == 3) {
						arr = generateDecreasing(100000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotRandom(arr);
					}
				}
			}

			else if (quickOption == 3) {
				if (intOption == 1) {
					if (size == 1) {
						arr = generateEquals(1000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotMedianOfThree(arr);
					} else if (size == 2) {
						arr = generateEquals(10000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotMedianOfThree(arr);
					} else if (size == 3) {
						arr = generateEquals(100000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotMedianOfThree(arr);
					}
				} else if (intOption == 2) {
					if (size == 1) {
						arr = generateRandom(1000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotMedianOfThree(arr);
					} else if (size == 2) {
						arr = generateRandom(10000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotMedianOfThree(arr);
					} else if (size == 3) {
						arr = generateRandom(100000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotMedianOfThree(arr);
					}
				} else if (intOption == 3) {
					if (size == 1) {
						arr = generateIncreasing(1000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotMedianOfThree(arr);
					} else if (size == 2) {
						arr = generateIncreasing(10000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotMedianOfThree(arr);
					} else if (size == 3) {
						arr = generateIncreasing(100000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotMedianOfThree(arr);
					}
				} else if (intOption == 4) {
					if (size == 1) {

						arr = generateDecreasing(1000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotMedianOfThree(arr);
					} else if (size == 2) {
						arr = generateDecreasing(10000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotMedianOfThree(arr);
					} else if (size == 3) {
						arr = generateDecreasing(100000);
						timeForStarting = System.nanoTime();
						quickSorters.sortPivotMedianOfThree(arr);
					}
				}
			}
		}

		timeForEnding = System.nanoTime();
		time = timeForEnding - timeForStarting;
		System.out.println("Array sorted in " + time + "ns");
		System.out.println("Do you want to see the sorted array?\n1-Yes\n2-No");
		int yesNo = scanner.nextInt();
		if(yesNo == 1) {
			for (int i = 0; i < arr.length; i++) {
				System.out.println(arr[i]);
			}
		}
		scanner.close();
	}

	
	//alttaki 4 fonksiyon verilen size kadar elemanı istenilen şekilde üretir.
	public static int[] generateEquals(int size) {
		int[] arr = new int[size];
		for (int i = 0; i < arr.length; i++) {
			arr[i] = 1;
		}
		return arr;
	}
	public static int[] generateRandom(int size) {

		int[] arr = new int[size];
		for (int i = 0; i < arr.length; i++) {
			arr[i] = new Random().nextInt(size * 100);
		}
		return arr;
	}
	public static int[] generateIncreasing(int size) {

		int[] arr = new int[size];
		for (int i = 0; i < arr.length; i++) {
			arr[i] = i;
		}
		return arr;
	}
	public static int[] generateDecreasing(int size) {

		int[] arr = new int[size];
		for (int i = 0; i < arr.length; i++) {
			arr[i] = size - i;
		}
		return arr;
	}
}
