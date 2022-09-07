namespace PYP_TemplateT4.Models;
public class Orders
{
public int OrderID {get;set;}
public int CustomerID {get;set;}
public int EmployeeID {get;set;}
public int OrderDate {get;set;}
public int RequiredDate {get;set;}
public int ShippedDate {get;set;}
public int ShipVia {get;set;}
public decimal Freight {get;set;}
public string ShipName {get;set;}
public string ShipAddress {get;set;}
public string ShipCity {get;set;}
public string ShipRegion {get;set;}
public string ShipPostalCode {get;set;}
public string ShipCountry {get;set;}
}
