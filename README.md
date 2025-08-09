Over the past few days, I have worked on strengthening my understanding of asynchronous programming in .NET and how it differs from multithreading. Initially, my knowledge was surface level — I understood the purpose of async and await and could give examples, but I was unclear about the internal behaviour, the number of threads involved, and the exact relationship between asynchronous execution and Task.Run.

Steps I Took:
1.	Studied Microsoft Documentation
I went through the Microsoft Learn article and video “Distinguish asynchronous and multithreading in C#”. This gave me a clearer picture of:
o	How async/await works under the hood.
o	The fact that I/O-bound asynchronous code does not necessarily create extra threads — instead, it uses I/O completion ports managed by the operating system.
o	When and why Task.Run is used for CPU-bound work, and how that differs from I/O-bound asynchronous operations.
2.	Created Practical Sample Code
To move beyond theory, I developed a small C# console application with two separate demonstrations:
o	Async I/O example using HttpClient.GetStringAsync() to show that no extra thread is created for waiting on network data.
 
o	CPU-bound example using Task.Run to perform heavy calculations on a background thread from the thread pool. 
I included thread ID logging at each stage so I could visually confirm which threads were actually doing the work and when control was handed back to the main thread.
3.	Verified the Behaviour by Running the Code
By executing the program, I see:
o	In the async I/O example, the start and completion often ran on the same thread, proving no extra worker thread was created during the wait.
o	In the CPU-bound example, Task.Run clearly executed the work on a different thread pool thread, confirming this as true multithreading.
 

4.	Documented Findings
I summarized the differences between asynchronous programming and multithreading in a clear, side-by-side table, making it easier to decide when to use each approach.
Additionally, I prepared a visual flow diagram to help internalize the “pause → free thread → resume” process in async/await.
 

Outcome:
I now have a much deeper and practical understanding of asynchronous programming in .NET and how it relates to (and differs from) multithreading. I can confidently explain:
•	When async does not create new threads.
•	When and why to use Task.Run for CPU-bound operations.
•	How to analyse thread usage in a running application.
This exercise not only clarified the concepts but also gave me reusable reference material for future projects and interviews.

Attached Supporting Materials
•	Reference: Microsoft Learn — Distinguish Asynchronous and Multithreading in C#
•	Sample Code: Console application with both I/O-bound and CPU-bound examples, including thread ID tracking. 
•	Notes & Diagram: A concise table and flow illustration showing the distinction between async and multithreading.

