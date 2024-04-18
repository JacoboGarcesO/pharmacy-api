namespace pharmacy_api.Model.Entities
{
  public class Customer
  {
    public int CustomerId { get; set; }
    public string? FullName { get; set; }
    public DateTime BirthDate { get; set; }
    public int Age { get; set; }
  }
}
