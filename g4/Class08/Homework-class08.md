# Homework - Class 08

Use the SEDC.PizzaApp.Refactored project from Class 08

We need to add a feature for giving feedbacks for the services of our pizza store and pizza app. You will need to implement the whole flow, through
all the three levels of our new architecture. Be careful with the different types of models!

1. Create a model for Feedback that contains the following properties:
- Id (int)
- Name (string) - the name of the visitor that gives feedback 
- Email (string) - email of the visitor that gives the feedback
- Message (string) - content of the feedback

This entity (Feedback) is stand-alone, it doesn't have relations with other tables (entities).

2. Create a repository that handles data access for feedback entities and implements the CRUD operations.

3. Create a service that handles logic for feedbacks.

4. Create a corresponding Controller.

5. Add a menu link in Layout that leads to Feedback page.

6. Implement listing of all feedbacks, inserting a feedback, editing a feedback and deleting a feedback.


## Bonus
The content of the message can not be more than 100 characters. Think where should this validation be done.
Maximum three feedbacks are allowed per email. Think where should this validation be done.

In the method for creating a pizza from the previous homework, add validation that there should be only one pizza on promotion.

## Bonus **
Check if the email is in correct format. Think where should this validation be done. 


## Contact
Trainer: stojanovskatanja@hotmail.com

Assistant: spasevska.kristina87@gmail.com