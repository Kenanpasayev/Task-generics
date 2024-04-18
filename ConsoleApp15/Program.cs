namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Hotel> hotels = new List<Hotel>();
            bool exit = false;
            string input;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Sisteme giris");
                Console.WriteLine("0. Cixis");
                Console.Write("Secim edin: ");
                 input= Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Sisteme giris");
                        Console.WriteLine("1. Hotel yarat");
                        Console.WriteLine("2. Butun Hotelleri gor");
                        Console.WriteLine("3. Hotel sec");
                        Console.WriteLine("0. Exit");

                        input = Console.ReadLine();
                        switch (input)
                        {
                            case "1":
                                Console.WriteLine("Hotel adini daxil edin: ");
                                string hotelName = Console.ReadLine();
                                Hotel hotel = new Hotel(hotelName);
                                hotels.Add(hotel);
                                Console.WriteLine("Hotel yaradildi.");
                                break;
                            case "2":
                                Console.WriteLine("Butun Hoteller:");
                                foreach (var h in hotels)
                                {
                                    Console.WriteLine($"Hotel Id: {0}, Name: {h.Name}");
                                }
                                break;
                            case "3":
                                Console.WriteLine("Hotelin adini daxil edin: ");
                                string selectedHotelName = Console.ReadLine();
                                Console.WriteLine("hotel tapildi");
                                Hotel selectedHotel = hotels.Find(h => h.Name == selectedHotelName);
                                
                                if (selectedHotel != null)
                                    
                                {
                                    int hotelChoice;
                                    
                                    do 
                                    {
                                        Console.WriteLine("Hotel Menu");
                                        Console.WriteLine("1. Room yarat");
                                        Console.WriteLine("2. Roomlari gor");
                                        Console.WriteLine("3. Rezervasya et");
                                        Console.WriteLine("4. Evvelki menuya qayit");
                                        Console.WriteLine("0. Exit");

                                        Console.Write("Secimin edin:");
                                        input= Console.ReadLine();
                                        
                                        switch (input)
                                        {
                                            case "1":
                                                Console.WriteLine("Room adini daxil edin: ");
                                                string roomName = Console.ReadLine();
                                                Console.WriteLine("Roomun qiymetini daxil edin: ");
                                                double roomPrice = Convert.ToDouble(Console.ReadLine());
                                                Console.WriteLine("Roomun personcapacity-sini daxil edin: ");
                                                int personCapacity =Convert.ToInt32(Console.ReadLine());
                                                Room newRoom = new Room(roomName, roomPrice, personCapacity);
                                                selectedHotel.AddRoom(newRoom);
                                                Console.WriteLine("Room yaradildi");
                                                break;
                                            case "2":
                                                Console.WriteLine("Hotel seçin");
                                                string showroom = Console.ReadLine();

                                                if (selectedHotel == null)
                                                {
                                                    Console.WriteLine(" Hotel seçilməlidir.");
                                                    return;
                                                }

                                                List<Room> rooms = selectedHotel.GetAllRooms();
                                                Console.WriteLine($"{selectedHotel.Name} hotelindeki otaqlar:");
                                                foreach (var room in rooms)
                                                {
                                                    Console.WriteLine(room.Name);
                                                }
                                                break;
                                               case "3":   
                                            break;
                                               case "4":
                                            break;
                                                case "0":
                                                exit = true;
                                            break;
                                        }
                       
                                    } while (exit!=true);
                                    
                                }break;
                        }
                     break;

                }

            } while (exit!=true);

        }

    }
}
