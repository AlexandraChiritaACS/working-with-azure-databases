namespace WorkingWithAzureDB
{
    public abstract class IDemo
    {
        // DIsplay the customers list
        public abstract void ShowAllCustomers(int customerID = 0);
        // Inserting a row in DB
        public abstract void InsertNewCustomer(Customer givenCustomer);
        // Update a row in DB
        public abstract void UpdateCustomerName(int customerID, string firstName, string lastName);
        // Delete a row from DB
        public abstract void DeleteCustomer(int customerID);

        public virtual void RunDemo(Customer newCustomer)
        {
            // Display initial customer list
            ShowAllCustomers();
            System.Console.WriteLine("SELECTED EVERYTHING..." + System.Environment.NewLine);

            // Test inserting
            System.Console.WriteLine("Adding myself" + System.Environment.NewLine);
            ShowAllCustomers(newCustomer.CustomerID);
            InsertNewCustomer(newCustomer);
            System.Console.WriteLine("Added Myself..." + System.Environment.NewLine);

            // Test updating
            ShowAllCustomers(newCustomer.CustomerID);
            System.Console.WriteLine("Updating myself..." + System.Environment.NewLine);
            UpdateCustomerName(newCustomer.CustomerID, newCustomer.LastName, newCustomer.FirstName);
            ShowAllCustomers(newCustomer.CustomerID);

            // Test deleting
            System.Console.WriteLine("Erasing myself..." + System.Environment.NewLine);
            DeleteCustomer(newCustomer.CustomerID);
            ShowAllCustomers(newCustomer.CustomerID);
        }

    }
}
