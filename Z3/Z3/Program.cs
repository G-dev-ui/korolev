
public class PhoneContact
{
    public string Phone { get; set; }
}

public class EmailContact
{
    public string Email { get; set; }
}
//обобщенный класс
public class Contact
{
    public List<string> PhoneContacts { get; set; }
    public List<string> EmailContacts { get; set; }

    public Contact(List<string> phoneContacts, List<string> emailContacts)
    {
        if (phoneContacts == null)
    {
        throw new ArgumentNullException(nameof(phoneContacts));
    }

    if (emailContacts == null)
    {
        throw new ArgumentNullException(nameof(emailContacts));
    }
        PhoneContacts = phoneContacts;
        EmailContacts = emailContacts;
    }
    //метод который выводит кол-во контактов 
    public void PrintTotalContacts()
    {
        Console.WriteLine($"Total contacts: {PhoneContacts.Count + EmailContacts.Count}");
    }
}




