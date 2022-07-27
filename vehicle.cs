public class vehicle
    {
        public string VehicleNumber { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int Mileage { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }


        public void SaveData()
        {
            // Save to database
        }

        public void Drive()
        {
            // Drive the vehicle
        }

        public void Park()
        {
            // Park the vehicle
        }

        public void Repair()
        {
            // Repair the vehicle
        }
    }

    public class User : vehicle
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        
        

        public void CreateUser()
        {          
            // Create a user
        }

        public void AssignVehicleToUser()
        {
            // Assign the vehicle to a user
        }

        public void RemoveVehicleFromUser()
        {
            // Remove the vehicle from a user
        }

       
    }