    public class User
    {
    public string Firstname = "Muhammad" ;
    public string  Lastname = "Yaqubzoda";    
    public string  Username1 = "yakubow.l6";    
    public string  Password1 = "Softclub";   
    public bool IsLoggedOn;
    public  void Login(string username, string password) 
    {
    if(Username1 == username && Password1 == password)
    {
   IsLoggedOn = true;
    Console.WriteLine(" Userr logged successfully ");  
    }
    else
    {
      IsLoggedOn = false;
    Console.WriteLine ( " Your password or username is incorrect ");
    }

    }
    public void FullInfo()
    {
     System.Console.WriteLine($"{Firstname} {Lastname} - {IsLoggedOn}"); 
    }

    }