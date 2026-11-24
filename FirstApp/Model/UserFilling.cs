namespace FirstApp.Model
{
    public static class UserFilling
    {
        public static List<userModel> GetUserFilling()
        {
            return new List<userModel> {
                new userModel
                {
                    Name = "Giorgi",
                    Surname = "Giorgadze",
                },
                 new userModel
                {
                    Name = "Vano",
                    Surname = "Giorgadze",
                },
                  new userModel
                {
                    Name = "Mariam",
                    Surname = "Giorgadze",
                }
            };
        }
    }
}
