namespace WorkingWithAzureDB
{
     // Abstract class for testing the DB
    public abstract class IDemo
    {
        // Display customer list
        public abstract void ShowAllCustomers(int customerID = 0);
        // Methods for inserting row in DB (to be implemented in the extending class)
        public abstract void InsertNewCustomer(Customer givenCustomer);
        // Methods for update row (change atribute) in DB (to be implemented in the extending class)
        public abstract void UpdateCustomerName(int customerID, string firstName, string lastName);
        // Methods for deleting a row in DB (to be implemented in the extending class)
        public abstract void DeleteCustomer(int customerID);
        
        // Testing the functionality of the DB
        public virtual void RunDemo(Customer newCustomer)
        {
            // By every step, the Customers list is displayed
            ShowAllCustomers();
            System.Console.WriteLine("SELECTED EVERYTHING..." + System.Environment.NewLine);

            
            System.Console.WriteLine("Adding myself" + System.Environment.NewLine);
            ShowAllCustomers(newCustomer.CustomerID);
            InsertNewCustomer(newCustomer);
            System.Console.WriteLine("Added Myself..." + System.Environment.NewLine);

            
            ShowAllCustomers(newCustomer.CustomerID);
            System.Console.WriteLine("Updating myself..." + System.Environment.NewLine);
            UpdateCustomerName(newCustomer.CustomerID, newCustomer.LastName, newCustomer.FirstName);
            ShowAllCustomers(newCustomer.CustomerID);

            
            System.Console.WriteLine("Erasing myself..." + System.Environment.NewLine);
            DeleteCustomer(newCustomer.CustomerID);
            ShowAllCustomers(newCustomer.CustomerID);
        }

    }
}
