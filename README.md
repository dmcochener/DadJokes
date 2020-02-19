# DadJokes
![Welcome to Dad Jokes](https://github.com/dmcochener/DadJokes/blob/master/dadjokes.PNG)

---

Looking for some _good jokes_? This might not be the program for you.
    
But if you're looking for **Dad Jokes**, here's your hook-up!

---
## Basic Features
- Created using C# - Asp.NET MVC
- Utilizes the API "I Can Haz Dad Jokes"
- Connects to API using HttpClient
- Options for searching by term or random joke
- Groups search results by word count (short, mid, long)
- Capitalizes the search term in results to make it easy to find
- Includes Unit Tests for main functionality
- Focuses on back-end, used simple BootStrap for styling

---
While creating this project, I looked at multiple methods of connecting to APIs. I settled on HttpClient because it included all the functionality I needed without requiring me to install a new package or rely on code that is out of date. I made the API a singleton so there would not be repeated calls to the service. As this required making the service a sealed class, I created an interface to allow for unit testing.

For grouping by search term and capitalizing the term, I used different helper methods. This maintained a good separation of concerns and allowed me to focus on testing one element at a time. I opted to group by size rather than sort by size to reduce the BigO notation associated with the process.

The Unit Tests were created along the way so I could test functionality of the individual pieces without needing to implement a user interface. This made the integration of the various components easier to manage.

Instead of having all the integration code within the Controller, I opted to extract it to a DadJoke Service. This allows the controller code to just be focused on the task of getting and displaying a joke, while the DadJoke Service would handle all the steps needed to integrate the other pieces of code.
