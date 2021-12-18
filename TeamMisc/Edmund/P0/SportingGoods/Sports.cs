using Sports;

List<User> UserList = new List<User>();
bool exit= false;


while(!exit)
{
    Console.WriteLine("Welcome to our Sports Store");
    Console.WriteLine("1. Log in to Profile (Existing Users)");
    Console.WriteLine("2. Sign Up as a New User");
    Console.WriteLine("3. Employees Log in Here");
    Console.WriteLine("4. Exit");
    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
        Console.WriteLine("Log in to Profile (Existing Users) ");
        // searching database for existing customers, by username and password
        // ask for username and password from users
        // search collection of users for authenticated existing users
        // if credentials are wrong -> try again or do you want to sign up as new user
        // if credentials are right -> user can view order history or order existing inventory
        
        break;

        case "2":
        Console.WriteLine("Sign Up as a New User");
        // prompt user to enter a username -> check the collection if username already exists -> return null
        // if collections returns that same name, prompt user that name has already been taken and to create a different one
        // if collections returns nulls, username does not exists and user can create a password
        // save username and password in collection database
        // redirect them to log-in page
        Console.WriteLine("Enter a New Username");
        string newUsername = Console.ReadLine();
        Console.WriteLine("Create a New Password");
        string newPassword = Console.ReadLine();
        User newCustomer = new User {
                Username = newUsername,
                Password = newPassword
        };

        UserList.Add(newCustomer);
                
        
        break;


        case "3":
        Console.WriteLine("Employees Log in Here");
        //prompt employee to enter their username -> search database for existing employees
        //search collection of users for authenticated existing users
        // if credentials are wrong -> tell user that credentials not found/ ask them to contact their company
        // if credentials are right -> user can view store inventory

        break;


        case "4":
            exit = true;
            Console.WriteLine("Thank you. Please come again.");
            
        break;
    
    }
}


