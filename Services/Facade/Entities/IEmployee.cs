namespace Services.Facade
{
    public interface IEmployee
    {
        string Id
        { get; }

        //own stuff
        //
        string FirstName
        { get; set; }

        string LastName
        { get; set; }

        string Patronym
        { get; set; }

        BLL.Date BirthDate
        { get; set; }

        string Place
        { get; set; }

        //refs
        string DepartmentId
        { get; set; }
    }
}
