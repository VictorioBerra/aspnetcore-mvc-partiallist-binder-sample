using System.Collections.Generic;


namespace MVCExampleNick.Models
{
public class MainViewModel
{

    public string Name { get; set; }

    public List<Department> Departments { get; set; }

}

public class MainComplexViewModel
{

    public User User { get; set; }

    public List<Department> Departments { get; set; }

}

public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public class Department
{
    public int Id { get; set; }

    public string Name { get; set; }
}
}

