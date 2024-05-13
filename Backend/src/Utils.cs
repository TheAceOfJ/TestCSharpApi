namespace WebApp;
public static class Utils
{
    public static int SumInts(int a, int b)
    {
        return a + b;
    }
/*
    public static Arr CreateMockUsers()
    {
        // Read all mock users from the JSON file
        var read = File.ReadAllText(FilePath("json", "mock-users.json"));
        Arr mockUsers = JSON.Parse(read);
        Arr successFullyWrittenUsers = Arr();
        foreach (var user in mockUsers)
        {
            user.password = "12345678";
            var result = SQLQueryOne(
                @"INSERT INTO users(firstName,lastName,email,password)
                VALUES($firstName, $lastName, $email, $password)
            ", user);
            // If we get an error from the DB then we haven't added
            // the mock users, if not we have so add to the successful list
            if (!result.HasKey("error"))
            {
                // The specification says return the user list without password
                user.Delete("password");
                successFullyWrittenUsers.Push(user);
            }
        }
        return successFullyWrittenUsers;
    }
*/
    public static bool IsPasswordGoodEnough(string password)
{
     if (password.Length < 8 || 
        !password.Any(char.IsLower) || 
        !password.Any(char.IsUpper) || 
        !password.Any(char.IsDigit) || 
        !password.All(char.IsLetterOrDigit))

     {
        return false;
    }
    else
    {
        return true;
    }
}
}