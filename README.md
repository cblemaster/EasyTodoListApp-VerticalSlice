
# EasyTodoListApp-VerticalSlice
## About
+ An application that provides todo functionality, nothing fancy, just the basics
+ My first time using vertical slice architecture and the MediatR library
+ Inspired by frustration with complexities of clean architecture-inspired 'layered' designs, such as how the layers communicate
+ Having heard of vertical slice architecture (VSA), I decided to give it a try and started reading up on it
+ The app will start small, with new features added incrementally (incidentally, the ease of adding features is a benefit of VSA)
## Acknowledgement
+ Many thanks to Ziggy Rafiq, whose write up of VSA caught my attention because it was the first I encountered that included code examples (in fact, a complete application)
+ https://github.com/ziggyrafiq/ECommerceApp-VerticalSlice/tree/main
## Objectives
+ Complete my first project that uses VSA
+ Understand the advantages and disadvantages of using VSA
+ Understand the role of the MediatR library and how it could have helped me with past projects
+ Make the app extensible so that adding features is easy
## Use cases
|#|Use case|Description|
|-|-|-|
|1|See all todos|As a user, I want to see an interactive list of my todos<br />All information related to a todo should be available in this view<br />The list should be sorted by due date desc, then description<br />This list excludes completed todos, which are visible elsewhere|
|2|See due today todos|As a user, I want to see an interactive list of my todos that are due today<br />All information related to a todo should be available in this view<br />The list should be sorted by description<br />This list excludes completed todos, which are visible elsewhere|
|3|See important todos|As a user, I want to see an interactive list of my todos that are important<br />All information related to a todo should be available in this view<br />The list should be sorted by due date desc, then description<br />This list excludes completed todos, which are visible elsewhere|
|4|See completed todos|As a user, I want to see an interactive list of my todos that are complete<br />All information related to a todo should be available in this view<br />The list should be sorted by due date desc, then description|
|5|See overdue todos|As a user, I want to see an interactive list of my todos that are due prior to today<br />All information related to a todo should be available in this view<br />The list should be sorted by due date desc, then description<br />This list excludes completed todos, which are visible elsewhere|
|6|Create todo|As a user, I want to create todos<br />The description for the new todo is required, cannot be all whitespace characters, and must be 100 or fewer characters in length<br />The due date for the new todo is optional, and if provided can be past, present, or future<br />The create date for the new todo is set and never subsequently modified|
|7|Update todo|As a user, I want to update todos<br />I want to be able to update the todo decription and/or the due date<br />The description for the todo is required, cannot be all whitespace characters, and must be 100 or fewer characters in length<br />The due date for the todo is optional, and if provided can be past, present, or future<br />Completed todos cannot be updated, except to toggle back to incomplete<br />The update date for the todo is set |
|8|Toggle todo importance|As a user, I want to update the importance of todos<br />Completed todos cannot be updated, except to toggle back to incomplete<br />The update date for the todo is set|
|9|Toggle todo completion|As a user, I want to update the completion of todos<br />The update date for the todo is set|
|10|Delete todo|As a user, I want to delete todos<br />Important todos cannot be deleted|
## Built with
+ .NET 9/ C# 13
+ Microsoft Visual Studio Community 2022
## Improvement opportunities / new features
+ TBD
