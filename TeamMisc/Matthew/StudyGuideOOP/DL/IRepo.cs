namespace DL;

//What's an interface?
//Interface is a contract, in essence
//It enforces that any type that implements the interface
//must also implement all of the interface's members as public methods
//We use interface to define/enforce a certain set of behavior on a type (such as class)
//This is an example of Abstraction (one of 4 OOP Pillars)
//Other OOP Pillars are Polymorphism, Inheritance, Encapsulation (A PIE!)
//Interface only has methods
public interface IRepo
{
    //Notice, how we're lacking access modifiers
    //interface members are implicitely public
    //they also lack method body
    List<Subject> GetAllSubjects();
    void AddSubject(Subject SubjectToAdd);
    void RemoveSubject(Subject subToRemove);
    List<Question> GetAllQuestions();
    void AddQuestion(Question questionToAdd);
    void ChangeQuestion(int indexToChange, Question questionToChange);
    void RemoveQuestion(Question questToRemove);
}