# Homework - Class 02

**Work with the SEDC.PizzaApp**

1. Create new Controller for managing Orders (name it accordingly)

2. Add Index action that returns a view with a simple html that says “List of orders”.
   It should be accessed through custom route http://localhost:12345/Orders (Ignore the port number)

3. Add Details action with optional parameter id.
   If id is null it should return empty action result, else it should return a view with simple html. It should be accessed through route http://localhost:12345/[Controller Name]/Details/{id?}

4. Add an action that returns Json (create an example model), it should be accessed by http://localhost:12345/[Controller Name]/JsonData.

5. Add an action that redirects to Action Index in Home Controller.

## Bonus

Create model for Order and static list consisting of several orders. Use it to try and list the Orders in a View

---

## Contact

Trainer: panovski.martin93@gmail.com

Assistant: djovanov92@gmail.com
