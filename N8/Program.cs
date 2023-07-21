//using System.Collections;

//Console.WriteLine(Guid.NewGuid());


//#region Pattern Matching 

//Console.WriteLine("Pattern Matching: ");

// Don't use convert or cast for type  convertion
//var value = (object)"false";


// #region Array and Collections

//using System.Collections;

Console.WriteLine("Array and Collactions");


// Simple Array
var arrayValu = new int[10];

//      Arraylist

// - Add
// - AddRange
// - Remove
// - RemmoveRange
// - Clear

var arrayList = new ArrayList();
arrayList.Add(10);
arrayList.Add("10");
arrayList.Add(10D);
arrayList.Add(10F);

//       List
// - Special Methods
// - Add
// - AddRange
// - Contains
// - Insert
// - Reverse
// - Remove
// - RemoveRange
// - RemoveAt

var list = new List<int>();

list.Add(10);
list.AddRange(new int[] { 10, 20 });
list.Contains(1);
list.Insert(1, 10);
list.Reverse();
list.Remove(10);
list.RemoveRange(0, 2);
list.RemoveAt(0);


//      Stack
// -  FIFO  -> First In First Out  

// - Special Methods
// - Enqueue - ddelete
// - Dequeue
// - Peek

var queue = new Queue<string>();
queue.Enqueue("John");
queue.Enqueue("G'ayrat");
queue.Enqueue("Teshavoy");
queue.Enqueue("Bob");
queue.Enqueue("G'ishmat");


//      LinkedList

// - Sppecial Methods
// Find
// FindLast
// FindFirst
// AddLast
// AddFirst
// AddBefore
// AddAfter
// Remove
// RemoveFirst
// RemoveLast

var linkedList = new LinkedList<int>();

Console.WriteLine(linkedList.Find(10));

linkedList.Find(10);
linkedList.FindLast(10);

linkedList.AddFirst(5);
linkedList.AddLast(10);

linkedList.AddBefore(linkedList.Find(10), 20);
linkedList.AddAfter(linkedList.Find(10), 20);

linkedList.Remove(5);
linkedList.RemoveFirst();
linkedList.RemoveLast();



//      Dictionary

var dictionary = new Dictionary<string, int>();

dictionary.Add("John", 12);

