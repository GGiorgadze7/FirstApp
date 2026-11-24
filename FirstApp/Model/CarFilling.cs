namespace FirstApp.Model
{
    public static class CarFilling
    {

        public static List<CarModel> GetCarFilling()
        {
            return new List<CarModel>
            {
                new CarModel
                {
                    Model = "Mercedes",
                    Color = "Black",
                    Releasedate = 2005
                },

                new CarModel
                {
                    Model = "BMW",
                    Color = "Blue",
                    Releasedate = 2008
                },

                new CarModel
                {
                    Model = "Audi",
                    Color = "Black",
                    Releasedate = 2010
                },

                new CarModel
                {
                    Model = "Porshe",
                    Color = "Black",
                    Releasedate = 2002
                }

            };
        }

    }
}
