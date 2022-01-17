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
    List<Topic> GetAllTopics();
    Topic GetTopicByIndex(int index);
    void AddTopic(Topic topicToAdd);
    void TallyTopic(int topicId, decimal curAvg, decimal avg);
    void DestroyTopic(string topicName);


    List<Card> GetAllCards();
    Card GetCardByIndex(int index);
    void AddCard(Card restaurantToAdd);
    void ChangeCard(int cardId, decimal success);
    void TallyCard(int cardId, decimal avg);
    void DestroyCard(string topicName);
    void EditCard(Card cardInfo);

}