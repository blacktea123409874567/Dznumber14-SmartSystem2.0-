
using _if_DzNomber6;

class Program
{
    static void Main(string[] args)
    {




//ОТВЕТ НА ВОПРОС В README



        

        
        HomeManager manager = new HomeManager();

        manager.DisplayAllDevicesStatus();

     
        try
        {
            SmartLamp SmartLamp = manager.FindSmartLampByName("Лампа в гостиной");
            Console.WriteLine($"Найдено: {SmartLamp}");
            SmartLamp.Turn(true);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка поиска: {ex.Message}");
        }


        try
        {
            manager.FindSmartLampByName("Лампа в гараже");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка поиска: {ex.Message}");
        }

        manager.DisplayAllDevicesStatus();

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        IHasDisplay[] hasDisplays = 
        {
            new Heater 
            {
                IsTurnOn = true,
                Power = 50 
            },
            new Heater 
            {
                IsTurnOn = false,
                Power = 34 
            },
            new Heater 
            {
                IsTurnOn = true, 
                Power = 20 
            },
        };



        foreach (var hasDisplay in hasDisplays) 
        {
            Console.WriteLine(hasDisplay.GetStatus());
        }


    }
}

