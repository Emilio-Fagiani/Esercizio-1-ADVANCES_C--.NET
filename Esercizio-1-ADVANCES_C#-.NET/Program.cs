using Esercizio_1_ADVANCES_C__.NET;

MyQueue<int> myQueue = new MyQueue<int>();
myQueue.Enqueue(10);
myQueue.Enqueue(20);
myQueue.Enqueue(30);

Console.WriteLine(myQueue.Dequeue()); 
Console.WriteLine(myQueue.Peek());   
Console.WriteLine(myQueue.Dequeue());